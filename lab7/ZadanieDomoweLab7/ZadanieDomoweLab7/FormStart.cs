using System;
using System.Windows.Forms;

namespace ZadanieDomoweLab7
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk obsługuje otwarcie okna gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //chowamy aktualne okno
            this.Hide();

            //tworzymy okno gry, gdy ono zostanie zamknięte zamknie się też okno startowe
            FormGame formGame = new FormGame();
            formGame.Closed += (s, args) => this.Close();
            formGame.Show();
        }
    }
}
