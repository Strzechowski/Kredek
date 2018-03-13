using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZadanieDomoweLab7
{
    public partial class FormGame : Form
    {
        int time; //czas w grze, potrzebny do zwiększania szykości kulek

        Graphics graphics;  //grafika
        AllBalls allBalls = new AllBalls();  //klasa z kulami

        int points;  //ilość zdobytych punktów w grze
        int numberOfBallsYouCanMiss = 3; //ilość ominiętych kul, po której przegramy

        public FormGame()
        {   
            InitializeComponent();
            
            graphics = CreateGraphics();

            time = 0;
            timerMoveBalls.Start();  //start timerów
            timerSpawnBalls.Start();
            timerDifficultyLevel.Start();
        }     

        /// <summary>
        /// W raz z upływem czasu timer powoduje przesuwanie się kul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMoveBalls_Tick(object sender, EventArgs e)
        {
            allBalls.MoveBallsFromList();
            allBalls.DrawBallFromList(graphics);

            CheckIfLost();
        }

        /// <summary>
        /// Funkcja sprawdza, czy już przegraliśmy
        /// </summary>
        private void CheckIfLost()
        {
            //wykorzystujemy funkcje klasy AllBalls
            int alreadyMissed;
            alreadyMissed = allBalls.HowManyBallsWereMissed();

            if (alreadyMissed == numberOfBallsYouCanMiss)
            {
                timerMoveBalls.Stop();  //stop timerów
                timerSpawnBalls.Stop();

                this.Hide();  //chowamy okno gry

                FormEnd formEnd = new FormEnd(points); //otwarcie okna końcowego
                formEnd.Show();

                formEnd.Closed += (s, args) => this.Close(); //okno gry zamknie się, gdy zamkniemy okno końcowe
                

            }
        }

        /// <summary>
        /// W raz z upływem czasu timer powoduje pojawianie się nowych kul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSpawnBalls_Tick(object sender, EventArgs e)
        {
            //Rozmiary okna są nam potrzebne, aby wiedzieć na jakim obszarze mają pojawiać się kule
            int SizeY = this.Height;
            int SizeX = this.Width;

            allBalls.AddBallToList(SizeY,SizeX);
        }

        /// <summary>
        /// Obsługa kliknięcia myszą w oknie FormGame, dodaje punkty do wyniku jeśli klikniemy na kulę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_MouseClick(object sender, MouseEventArgs e)
        {
           points += allBalls.CheckIfClikedOnAnyBall(Cursor.Position);
        }

        /// <summary>
        /// Timer na podstawie czasu w grze zmienia częstotliwość timera odpowiedzialnego za prędkość kulek (chodzi o utrudnianie gry z biegiem czasu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDifficultyLevel_Tick(object sender, EventArgs e)
        {
            time++;

            if(time%10 == 0)
            {
                if (timerMoveBalls.Interval > 40)
                    timerMoveBalls.Interval -= 10;
            }
        }
    }
}
