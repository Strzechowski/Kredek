using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomoweLab1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Zmienne wykorzystywane do przechowywania ilości surowców
        /// </summary>
        int money = 0;
        int mushroom = 0;
        int truffle = 0;
        int dumplings = 0;
        int loveScore = 0;

        /// <summary>
        /// Okno pojawiające się po truflowym zwycięstwie
        /// </summary>
        Form2 formFunction = new Form2();

        public Form1()
        {
            InitializeComponent();
            timerCounter.Start();
        }


        /// <summary>
        /// Funkcja tworzy tabelę z menu i tabelę z pracownikami w DataGridView przy otwarciu okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            employesTable.Rows.Add("Kucharz", "20", "+ ciasto na 3 pierogi/s", "1", "Kup");
            employesTable.Rows.Add("MasterChef", "150", "+ ciasto na 30 pierogów/s", "0", "Kup");
            employesTable.Rows.Add("Grzybiarz", "10", "+1 grzyb/s", "1", "Kup");
            employesTable.Rows.Add("Świnia Do Truffli", "300", "+1 trufla/s", "0", "Kup");
            employesTable.Rows.Add("Kucharz z zapałem do grzybobrania", "28", "+ ciasto na 3 pierogi/s i +2 grzyb/s", "0", "Kup");
            employesTable.Rows.Add("FANATYK grzybiarstwa", "100", "+15 grzybów/s", "0", "Kup");


            menuTable.Rows.Add("10 Pierogów", "15", "10 ciast i 15 grzybów");
            menuTable.Rows.Add("2 Naleśniki", "10", "8 ciast i 8 grzybów");
            menuTable.Rows.Add("Pieróg z truflami", "Bezcenny", "2 ciasta i 1 trufla");
        }


        /// <summary>
        /// Funkcja obługująca zakup nowego pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4) && (e.RowIndex >= 0 && e.RowIndex <= 5))  //sprawdzamy czy kliknięto na zakup pracownika i czy nie poza tabelą
            {
                if (Int32.Parse(employesTable.Rows[e.RowIndex].Cells[1].Value.ToString()) <= money) //spradzamy czy mamy dość pieniędzy
                {
                    money = money - Int32.Parse(employesTable.Rows[e.RowIndex].Cells[1].Value.ToString()); //zabieramy sobie pieniądze
                    moneyTextBox.Text = money.ToString();

                    String numberFromTable = employesTable.Rows[e.RowIndex].Cells[3].Value.ToString(); //sprawdzamy ilu mamy pracowników
                    int numberAsInt = Int32.Parse(numberFromTable) + 1;
                    employesTable.Rows[e.RowIndex].Cells[3].Value = numberAsInt;  //zatrudniamy nowego
                }
            }


            //Używamy funckji, aby sprawdzić jak bardzo kochamy grzybiarzy
            loveScore = HowMuchYouLoveMushroomPickers(Int32.Parse(employesTable.Rows[2].Cells[3].Value.ToString()));
            mushroomPickersLoveScoreTextBox.Text = loveScore.ToString();
        }


        /// <summary>
        /// Funkcja obsługuje naliczanie zasobów wraz z upływem czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //ciasto na pierogi
            dumplings += 3 * Int32.Parse(employesTable.Rows[0].Cells[3].Value.ToString()); //Czy da się bez podwójnego rzutowania??
            dumplings += 20 * Int32.Parse(employesTable.Rows[1].Cells[3].Value.ToString());
            dumplings += 3 * Int32.Parse(employesTable.Rows[4].Cells[3].Value.ToString());
            dumplingsTextBox.Text = dumplings.ToString();

            //grzyby
            mushroom += 3 * Int32.Parse(employesTable.Rows[2].Cells[3].Value.ToString()); //Czy da się bez podwójnego rzutowania??
            mushroom += 2 * Int32.Parse(employesTable.Rows[4].Cells[3].Value.ToString());
            mushroom += 15 * Int32.Parse(employesTable.Rows[5].Cells[3].Value.ToString());
            mushroomTextBox.Text = mushroom.ToString();

            //Trufle
            truffle += Int32.Parse(employesTable.Rows[3].Cells[3].Value.ToString());
            truffleTextBox.Text = truffle.ToString();
        }


        /// <summary>
        /// Funkcja obługuje sprzedaż naleśników i dyspozycje zasobów z tym związanych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pancakeSell_Click(object sender, EventArgs e)
        {
            if (mushroom > 8 && dumplings > 8)
            {
                money += 10;
                mushroom -= 8;
                dumplings -= 8;
                moneyTextBox.Text = money.ToString();
            }
        }


        /// <summary>
        /// Funkcja obługuje sprzedaż pierogów i dyspozycje zasobów z tym związanych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dumplingSell_Click(object sender, EventArgs e)
        {
            if (mushroom > 15 && dumplings > 10)
            {
                money += 15;
                mushroom -= 15;
                dumplings -= 10;
                moneyTextBox.Text = money.ToString();
            }
        }


        /// <summary>
        /// Funkcja obsługująca otwarcie wygrywającego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void truffleCookButton_Click(object sender, EventArgs e)
        {
            if (truffle > 0)
            {
                formFunction.Show();
            }
        }


        /// <summary>
        /// Funkcja sprawdza twoją miłość do grzybiarzy w (skali 0-5)
        /// </summary>
        /// <param name="howManyMushroomPickersYouBought"></param>
        /// <returns></returns>
        private int HowMuchYouLoveMushroomPickers(int howManyMushroomPickersYouBought)
        {
            
            int score = 0;
            for (int i = howManyMushroomPickersYouBought; i > 0; i-=2) // 2 grzybiarzy == ocena w górę o 1 
            {
                score++;
            }

            if (score > 5)
            {
                score = 5;
            }
            
            return score;
        }

    }
}
