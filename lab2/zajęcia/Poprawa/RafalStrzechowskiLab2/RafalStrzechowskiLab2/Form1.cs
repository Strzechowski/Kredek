using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafalStrzechowskiLab2
{
    public partial class Form1 : Form
    {
        private List<Horse> listOfHorses;
        private List<Unicorn> listOfUnicorns;
        public Form1()
        {
            InitializeComponent();
            listOfHorses = new List<Horse>();
            listOfUnicorns = new List<Unicorn>();
        }

        /// <summary>
        /// Obsługa przycisku dodającego konie do listy koni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addHorseButton_Click(object sender, EventArgs e)
        {
            AddHorse();
        }

        /// <summary>
        /// Dodaje konia do tablicy na podstawie dany w TextBoxach
        /// </summary>
        private void AddHorse()
        {
            try
            {
                string name = nameOfHorseTextBox.Text;
                int numberOfLegs = Int32.Parse(numberOfLegsTextBox.Text);
                var horse = new Horse(name, numberOfLegs);
                listOfHorses.Add(horse);
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje we właściwym formacie");
            }
        }

        /// <summary>
        /// Pokazuje konie z tablicy w TextBoxie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showHorsesButton_Click(object sender, EventArgs e)
        {
            ShowHorses();
        }

        /// <summary>
        /// Pokazuje konie z tablicy w TextBoxie
        /// </summary>
        private void ShowHorses()
        {
            for (int i = 0; i < listOfHorses.Count; i++)
            {
                horseTextBox.Text += listOfHorses[i].Name + " " + listOfHorses[i].NumberOfLegs + " \r\n";
            }
            listOfHorses.Clear();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk "Dodaj jednorożca"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUnicornButton_Click(object sender, EventArgs e)
        {
            addUnicorn();
        }

        /// <summary>
        /// Dodaje jednorożca do tablicy (w DataGridView)
        /// </summary>
        private void addUnicorn()
        {
            try
            {
                string name = nameOfHorseTextBox.Text;
                string colorOfCequins = colorOfSequinsTextBox.Text;
                int numberOfLegs = Int32.Parse(numberOfLegsTextBox.Text);
                bool corner = cornerCheckBox.Checked;

                UnicornTable.Rows.Add(name, numberOfLegs, colorOfCequins, corner);
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje we właściwym formacie");
            }
        }
        /// <summary>
        /// Obsługa przycisku do usuwania jednorożcy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteUnicornButton_Click(object sender, EventArgs e)
        {
            try
            {
                UnicornTable.Rows.RemoveAt(UnicornTable.Rows.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nie można usunąć jednorożca, gdy żadnego nie ma!");
            }
        }

        /// <summary>
        /// Funkcja liczy średnią ilość nóg jednorożcy w tabeli po kliknięciu przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void averageNumberOfLegsButton_Click(object sender, EventArgs e)
        {
            int sumOfLegs = 0;
            int avarageOfLegs = 1;
            for (int i = 1; i < UnicornTable.Rows.Count; i++)
            {
                sumOfLegs += Int32.Parse(UnicornTable.Rows[i].Cells[1].Value.ToString());
            }
            avarageOfLegs = sumOfLegs / (UnicornTable.Rows.Count-1);
            averageNumberOfLegsTextBox.Text = avarageOfLegs.ToString();
        }
    }
}


