using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafalStrzechowskiLab7
{
    public partial class Form1 : Form
    {
        DataClassesPositionsDataContext context = new DataClassesPositionsDataContext();

        Graphics graphics;
        int x = 0;
        int y = 0;
        int z = 0;

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            //graphics = buttonGet.CreateGraphics();

            timerTime.Start();
        }


        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Przycisk dodaje nową pozycję do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            RafalStrzechowski_Position positions = new RafalStrzechowski_Position
            {
                Name = textBoxPositionName.Text,
                X = Int32.Parse(textBoxX.Text),
                Y = Int32.Parse(textBoxY.Text)
            };

            context.RafalStrzechowski_Positions.InsertOnSubmit(positions);
            context.SubmitChanges();
        }

        /// <summary>
        /// Przycisk tworzący element graficzny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            //Czyszczenie kolorem tła systemowego
            graphics.Clear(SystemColors.Control);

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(brush);


            //Stworzenie kształtu - prostokąt 
            graphics.FillRectangle(brush, 200 + x, 200 + y, 300, 200);

            graphics.DrawLine(pen, 100, 200, 300, 400);
            graphics.DrawEllipse(pen, 100, 200, 300, 400);


            //inkrementacja
            x++;
        }


        /// <summary>
        /// Przesuwa kształt w górę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            // if(timerTime. )
            //Czyszczenie kolorem tła systemowego
            graphics.Clear(SystemColors.Control);

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Blue);

            //Stworzenie kształtu - prostokąt 
            graphics.FillRectangle(brush, 200 + x, 200 + y, 300, 200);

            y -= 5;
        }

        /// <summary>
        /// Przesuwa kształt w lewo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            //Czyszczenie kolorem tła systemowego
            graphics.Clear(SystemColors.Control);

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Purple);

            //Stworzenie kształtu - prostokąt 
            graphics.FillRectangle(brush, 200 + x, 200 + y, 300, 200);

            x -= 5;
        }

        /// <summary>
        /// Przesuwa kształt w prawo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            //Czyszczenie kolorem tła systemowego
            graphics.Clear(SystemColors.Control);

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Orange);

            //Stworzenie kształtu - prostokąt 
            graphics.FillRectangle(brush, 200 + x, 200 + y, 300, 200);

            x += 5;
        }

        /// <summary>
        /// Przesuwa kształt w dół
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            z = 0;
            //Czyszczenie kolorem tła systemowego
            graphics.Clear(SystemColors.Control);

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Red);

            //Stworzenie kształtu - prostokąt 
            graphics.FillRectangle(brush, 200 + x, 200 + y, 300, 200);

            y += (5 + z);

            //Przypisanie kooru wypełnienia

            Pen pen = new Pen(brush);
            //Rysowanie elisy
            graphics.DrawEllipse(pen, 100 + z + 5, 200 + z, 300 + z, 400 + z);
        }

        /// <summary>
        /// Obsługa timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            z++;

            //Przypisanie kooru wypełnienia
            SolidBrush brush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(brush);

            //Rysowanie elisy
            graphics.DrawEllipse(pen, 100 + z, 200 + z, 300 + z, 400 + z);



        }

        /// <summary>
        /// Przełączenie do pracy w tle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackground_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIconMonitor.Visible = true;
        }

        /// <summary>
        /// Przywrócenie programu do pracy okienkowej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconMonitor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconMonitor.Visible = false;
        }

        /// <summary>
        /// Przycisk uruchamiający nowy proces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\rafal\source\repos\RafalStrzechowskiLab7\RafalStrzechowskiLab7\bin\Debug\RafalStrzechowskiLab7.exe");
        }
    }
}
