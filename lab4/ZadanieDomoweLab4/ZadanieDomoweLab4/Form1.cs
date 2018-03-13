using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ZadanieDomoweLab4
{
    public partial class FormZoo : System.Windows.Forms.Form
    {
        Export export = new Export();
        DataClassesZooDataBaseDataContext context = new DataClassesZooDataBaseDataContext();

        public FormZoo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk wyświetlający dane w dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (comboBoxShowData.Text == "Pracowników")
            {
                ShowEmployeesInTable();
            }
            else
            {
                ShowAnimalsInTable();
            }
        }

        /// <summary>
        /// Funkcja wyświetlająca tabelę Zwierząt w dataGridview
        /// </summary>
        private void ShowAnimalsInTable()
        {
            var animal = from W in context.WorkSchedules
                         join A in context.Animals on W.AnimalId equals A.Id
                         join B in context.Buildings on W.BuildingId equals B.Id
                         select new
                         {
                             A.NameOfTheAnimal,
                             A.HowManyAnimals,
                             A.BasicInfo.TypeOfAnAnimal,
                             A.BasicInfo.Climate,
                             B.NameOfTheBuilding
                         };

            dataGridViewShowData.DataSource = animal;
        }

        /// <summary>
        /// /Funckja wyświetlająca tabelę Pracowników w dataaGridView
        /// </summary>
        private void ShowEmployeesInTable()
        {
            var employee = from Employee in context.Employees
                           select new
                           {
                               Employee.Id,
                               Employee.Name,
                               Employee.Surname,
                               Employee.PESEL,
                               Employee.WorkType.Job,
                               Employee.WorkType.Salary
                           };

            dataGridViewShowData.DataSource = employee;
        }

        /// <summary>
        /// Funkcja służy do zmiany nazwy pracy na odpowiadający jej numer id
        /// </summary>
        /// <returns></returns>
        private short ChooseTypeOfWork()
        {
            short number = 1;
            if (comboBoxWorkType.Text == "Ogrodnik")
            {
                number = 2;
            }
            else if (comboBoxWorkType.Text == "Opiekun Zwierząt")
            {
                number = 3;
            }
            return number;
        }

        /// <summary>
        /// Przycisk do dodawania pracowników na podstawie danych z textBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                PESEL = textBoxPesel.Text,
                JobId = ChooseTypeOfWork()
            };

            context.Employees.InsertOnSubmit(employee);
            context.SubmitChanges();

            ShowEmployeesInTable();
        }

        /// <summary>
        /// Funckja zwraca id pracownika wybrane w textBoxie
        /// </summary>
        /// <returns></returns>
        private short ChooseTheEmployee()
        {
            try
            {
                short idNumber = short.Parse(textBoxId.Text);

                return idNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Podane Id nie jest liczbą!!");
            }
            return -1;
        }

        /// <summary>
        /// Przycisk do edytowania pracowników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = (from element in context.Employees
                                 where element.Id == ChooseTheEmployee()
                                 select element).FirstOrDefault();

            if (employee != null)
            {
                employee.Name = textBoxName.Text;
                employee.Surname = textBoxSurname.Text;
                employee.PESEL = textBoxPesel.Text;
                employee.JobId = ChooseTypeOfWork();
                context.SubmitChanges();

                ShowEmployeesInTable();
            }
            else
            {
                MessageBox.Show("Podaj poprawne Id pracownika!");
            }
        }

        /// <summary>
        /// Przycisk do usuwania pracowników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = (from element in context.Employees
                                 where element.Id == ChooseTheEmployee()
                                 orderby element.Id descending
                                 select element).FirstOrDefault();

            if (employee != null)
            {
                context.Employees.DeleteOnSubmit(employee);
                context.SubmitChanges();
                ShowEmployeesInTable();
            }
            else
            {
                MessageBox.Show("Podaj poprawne Id pracownika!");
            }

        }

        /// <summary>
        /// Przycisk do zapisu tabeli w csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMakeCsvTable_Click(object sender, EventArgs e)
        {
            export.PrintToCsv(dataGridViewShowData, textBoxPath.Text, textBoxFileName.Text);
        }

        /// <summary>
        /// Przycisk do zapisu pdfa z informacją o wypłacie pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMakePdf_Click(object sender, EventArgs e)
        {
            export.MakePdf(context, ChooseTheEmployee());
        }

        /// <summary>
        /// Przycisk do wyszukiwania pracowników po nazwisku w tabeli 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            var employee = from Employee in context.Employees
                           where Employee.Surname == textBoxSurname.Text
                           select new
                           {
                               Employee.Id,
                               Employee.Name,
                               Employee.Surname,
                               Employee.PESEL,
                               Employee.JobId
                           };

            dataGridViewShowData.DataSource = employee;
        }
    }
}
