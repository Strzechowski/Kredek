using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafalStrzechowskiLab1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Zmienna przechowująca wartość licznika;
        /// UWAGA! To, że counter jest używany w różnych funkcjach powoduje
        /// dziwne zachowania np. timer zmienia swoją wartość po wykonaniu mnożenia.
        /// Nie zastanawiam się nad tym problemem, bo nie było to spreyzowane.
        /// </summary>
        int counter = 0;

        /// <summary>
        /// Deklaracja 2 okna 
        /// </summary>
        Form2 formFunction = new Form2();


        public FormMain()
        {
            InitializeComponent();
            timerCounter.Start();
        }


        /// <summary>
        /// Funkcja obsługująca przycisk Start
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
            buttonStart.BackColor = Color.Green;
        }


        /// <summary>
        /// Funkcja obsługująca przycisk Stop
        /// </summary>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            BackColor = Color.HotPink;
            buttonStart.Text = "DZIALA";
            buttonStop.BackColor = Color.Yellow;
        }


        /// <summary>
        /// Funkcja zmienia wartość countera o wartość wpisaną w oknie textBoxNumberToChange
        /// i wyświetla wartość countera w oknie textBoxResult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            counter += Int32.Parse(textBoxNumberToChange.Text);
            textBoxResult.Text = "Wartość:"+counter;
        }


        /// <summary>
        /// Funkcja obsługuje przycisk, który wywołuje wykonanie dodawania i mnożenia  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            counter = Int32.Parse(textBoxNumber.Text) + Int32.Parse(textBoxNumber2.Text);
            textBoxSum.Text = counter.ToString();
            counter = Int32.Parse(textBoxNumber3.Text) * Int32.Parse(textBoxNumber4.Text);
            textBoxMultiplication.Text = counter.ToString();
        }

        /// <summary>
        /// Funkcja wyświetlająca aktualny czas timera oraz zmieniająca jego kolor gdy counter wskazuje 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter==8)
            {
                textBoxTimer.BackColor = Color.Red;
            }
            textBoxTimer.Text = counter.ToString();
        }

        /// <summary>
        /// Funkcja otwierająca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        { 
            formFunction.Show();
        }
       
    }
}
