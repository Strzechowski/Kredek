using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZadanieDomoweLab2
{
    public partial class Form1 : Form
    {
        Form2 formWinFunction = new Form2();
        Form3 formLossFunction = new Form3();
        Thieves yourThieves = new Thieves();
        Resources yourResources = new Resources();
       
        //Listy pracowników
        private List<Cook> listOfCooks;
        private List<MushroomPicker> listOfMushroomPickers;

        public Form1()
        {
            InitializeComponent();
            listOfCooks = new List<Cook>();
            listOfMushroomPickers = new List<MushroomPicker>();
            timeCounter.Start();
            StartingEmployees();
            yourResources.StartResources();
        }

        /// <summary>
        /// Funkcja przydziea nam po 1 początkowym pracowniku
        /// </summary>
        private void StartingEmployees()
        {
            Cook tempCook = new Cook("Romek", 1, "Łysy", "Polska", false);
            MushroomPicker tempPicker = new MushroomPicker("Janusz", 1, "Z tupecikiem", true);
            listOfCooks.Add(tempCook);
            listOfMushroomPickers.Add(tempPicker);
            ShowTable();
        }

        /// <summary>
        /// Obsługa przzycisku zakupu pracowników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyEmployeeButton_Click(object sender, EventArgs e)
        {
            BuyEmployee();
        }


        /// <summary>
        /// Funkcja sprawdza, czy mamy dość pieniędzy, aby kupić pracownika i jakiego chcemy kupić
        /// </summary>
        private void BuyEmployee()
        {
            int cost = Int32.Parse(howManyResourcesPerHourNumericUpDown.Text);
            if (yourResources.Money >= 10 * cost)
            {
                if (typeOfEmployeeComboBox.Text == "Grzybiarz")
                {
                    AddMushroomPicker();
                }
                else
                {
                    AddCook();
                }
                yourResources.Money -= 10 * cost;
                ShowTable();
                IntroduceEmployee();
            }
            else
            {
                MessageBox.Show("Nie masz wystarczająco pieniędzy! Porztebujesz 10 * ilość surowców na godzinę jaką ma mieć pracownik");
            }
        }

        /// <summary>
        /// Funkcja przekazuje tekst Przedstawienia się pracownika po starcie pracy
        /// </summary>
        private void IntroduceEmployee()
        {
            if (typeOfEmployeeComboBox.Text == "Grzybiarz")
            {
                employeeIntroductionTextBox.Text = listOfMushroomPickers[listOfMushroomPickers.Count - 1].SaySomething();
                employeeIntroductionTextBox.Text += listOfMushroomPickers[listOfMushroomPickers.Count - 1].WhatIHave();
            }
            else
            {
                employeeIntroductionTextBox.Text = listOfCooks[listOfCooks.Count - 1].SaySomething();
                employeeIntroductionTextBox.Text += listOfCooks[listOfCooks.Count - 1].WhatIHave();
            }
        }

        /// <summary>
        /// Funkcja dodająca kucharza do listy kucharzy
        /// </summary>
        private void AddCook()
        {
            string name = nameOfEmployeeTextBox.Text;
            string hairstyle = hairstyleOfEmployeeTextBox.Text;
            int howManyResourcesPerHour = Int32.Parse(howManyResourcesPerHourNumericUpDown.Text);
            string nationality = NationalityTextBox.Text;
            bool chefHat = mustacheOrChefHatCheckBox.Checked;

            var cook = new Cook(name, howManyResourcesPerHour, hairstyle, nationality, chefHat);
            listOfCooks.Add(cook);
        }

        /// <summary>
        /// Funkcja dodająca grzybiarza do listy grzybiaarzy
        /// </summary>
        private void AddMushroomPicker()
        {
            string name = nameOfEmployeeTextBox.Text;
            string hairstyle = hairstyleOfEmployeeTextBox.Text;
            int howManyResourcesPerHour = Int32.Parse(howManyResourcesPerHourNumericUpDown.Text);
            string nationality = NationalityTextBox.Text;
            bool mustache = mustacheOrChefHatCheckBox.Checked;

            var picker = new MushroomPicker(name, howManyResourcesPerHour, hairstyle, mustache);
            listOfMushroomPickers.Add(picker);
        }

        /// <summary>
        /// Funkcja przenosząca pracowników z list do tabeli w DataGridView
        /// </summary>
        private void ShowTable()
        {
            cooksTable.Rows.Clear();
            for (int i = 0; i < listOfCooks.Count; i++)
            {
                cooksTable.Rows.Add(listOfCooks[i].Name, listOfCooks[i].HowManyResourcesPerHour, listOfCooks[i].Hairstyle, listOfCooks[i].Nationality, listOfCooks[i].ChefHat);
            }

            mushroomPickersTable.Rows.Clear();
            for (int i = 0; i < listOfMushroomPickers.Count; i++)
            {
                mushroomPickersTable.Rows.Add(listOfMushroomPickers[i].Name, listOfMushroomPickers[i].HowManyResourcesPerHour,
                    listOfMushroomPickers[i].Hairstyle, listOfMushroomPickers[i].Mustache);
            }
        }

        /// <summary>
        /// Timer kontrolujący przypływ zasobów i ich wyświetlanie w TextBoxach oraz kradzieże
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeCounter_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfMushroomPickers.Count; i++)
            {
                yourResources.Mushrooms += (listOfMushroomPickers[i].HowManyResourcesPerHour);
            }

            for (int i = 0; i < listOfCooks.Count; i++)
            {
                yourResources.DumplingDoughs += (listOfCooks[i].HowManyResourcesPerHour);
            }

            //wyświetlanie na TextBoxach
            moneyTextBox.Text = yourResources.Money.ToString();
            mushroomTextBox.Text = yourResources.Mushrooms.ToString();
            dumplingDoughTextBox.Text = yourResources.DumplingDoughs.ToString();
            timeInGameTextBox.Text = yourResources.Time.ToString();
            

            //kradzieże
            howMuchToThievesProgressBar.PerformStep();
            if (yourResources.Time % 10 == 0)
            {
                howMuchToThievesProgressBar.Value = 0;
                Steal();
            }
            yourResources.Time++;
        }

        /// <summary>
        /// Funkcja obsługująca kradzieże
        /// </summary>
        private void Steal()
        {
            int whichAttack = yourThieves.WhichAttack();
            howMuchWillBeStolenTextBox.Text=yourThieves.BeastPower[whichAttack - 1].ToString();

            if (whichAttack >= 6 && yourResources.Money >= 40)
            {
                //Wygrana 
                timeCounter.Stop();
                formWinFunction.Show();
            }
            
            if (whoAttacksTextBox.Text == "Szaleni Grzybiarze")
            {
                yourResources.Mushrooms -= yourThieves.BeastPower[whichAttack - 2];
                if (yourResources.Mushrooms < 0)
                {
                    //przegrana
                    timeCounter.Stop();
                    formLossFunction.Show();
                }
            }
            if (whoAttacksTextBox.Text == "Pierogowy potwór")
            {
                yourResources.DumplingDoughs -= yourThieves.BeastPower[whichAttack - 2];
                if (yourResources.DumplingDoughs < 0)
                {
                    //przegrana
                    timeCounter.Stop();
                    formLossFunction.Show();
                }
            }
            string whoAttacksNext = yourThieves.WhoAttacks();
            whoAttacksTextBox.Text = whoAttacksNext;
        }

        /// <summary>
        /// Obsługa przycisku sprzedaży pierogów 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellDumplings_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Int32.Parse(sellDumplingsTextBox.Text);
                if (temp <= yourResources.Mushrooms && temp <= yourResources.DumplingDoughs)
                {
                    yourResources.DumplingDoughs -= temp;
                    yourResources.Mushrooms -= temp;
                    yourResources.Money += temp;

                    //średnia ilość pieniędzy 
                    avarageAmmountOfMoneyTextBox.Text = yourResources.AvarageAmmountOfMoney().ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj liczbę!");
            }

        }
    }
}
