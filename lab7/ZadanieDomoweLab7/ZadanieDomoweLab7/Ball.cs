using System;
using System.Drawing;

namespace ZadanieDomoweLab7
{
    /// <summary>
    /// Klasa zawiera dane kul pojawiających się na ekranie
    /// </summary>
    public class Ball
    {
        //Do rysowania
        public int SideOfSquare { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        
        //Związki z wielkością okna gracza
        int LosePositionY { get; set; }
        int MaximumX { get; set; }

        //Poruszanie na boki
        int MoveRightOrLeft { get; set; }
        int WhenToTurn { get; set; }

        //losowe liczby
        Random RandomNumber { get; set; }

        /// <summary>
        /// Kontruktor kuli
        /// </summary>
        public Ball(Random randomNumber, int losePositionY, int widthOfWindow)
        {
            SideOfSquare = 100;
            PositionY = 0;
            LosePositionY = losePositionY;
            MaximumX = widthOfWindow - 120;  //odejmuję 120, aby kulki nie wychodziły poza ekran
            RandomNumber = randomNumber; 

            //losowanie pozycji x dla kuli
            PositionX = randomNumber.Next(0, MaximumX); 

            //Ruch prawo-lewo
            WhenToTurn = 0;
            MoveRightOrLeft = randomNumber.Next(0, 2);
        }

        /// <summary>
        /// Ruch kuli
        /// </summary>
        public void BallMove()
        {
            PositionY += 5; //ruch w dół
            MoveSideways();
        }

        /// <summary>
        /// Funkcja umożliwia ruch kulki na boki
        /// </summary>
        private void MoveSideways()
        {
            if(WhenToTurn < 50)
            {
                WhenToTurn++;
                MoveSidewaysInDirection();
            }
            else
            {
                WhenToTurn = 0;
                MoveRightOrLeft = RandomNumber.Next(0, 2);
            }
           
        }

        /// <summary>
        /// Funkcja decyduje, w którą stronę kula ma się poruszyć
        /// </summary>
        private void MoveSidewaysInDirection()
        {
            if(MoveRightOrLeft == 0)
            {
                if (PositionX > 0)
                    PositionX-=5;
            }
            else
            {
                if (PositionX < (MaximumX) )
                    PositionX+=5;
            }

        }


        /// <summary>
        /// Ryswoanie kuli 
        /// </summary>
        public void BallDraw(Graphics graph)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(brush);

            //Stworzenie kształtu - prostokąt (w zasadzie kwadrat)
            Rectangle rectangleForEllipse = new Rectangle(PositionX, PositionY, SideOfSquare, SideOfSquare);

            //Rysowanie elipsy na podstawie prostokąta
            graph.FillEllipse(brush, rectangleForEllipse);
        }


        /// <summary>
        /// Sprawdzamy, czy kliknięto na daną kulkę, jeśli tak to przestajemy ją rysować i zwracamy 1 jako zdobyty punkt
        /// </summary>
        /// <param name="cursorPosition"></param>
        public bool CheckIfClickedOnBall(Point cursorPosition)
        {
            double radius = SideOfSquare / 2;

            //Pozycja X i pozycja Y określają górny róg kwadratu na podstawie którego rysowane jest koło,
            //dodatkowo Y jest przesunięte ze względu na górny pasek okna naszego programu
            //My chcemy uzyskać współrzędne środka koła
            int middleY = PositionY + 75;
            int middleX = PositionX + 50;

            //Obliczamy potęgi oddzielnie, aby warunek był czytelniejszy
            double x2=Math.Pow(cursorPosition.X - middleX, 2);
            double y2 = Math.Pow(cursorPosition.Y - middleY, 2);
            double r2 = Math.Pow(radius, 2);

            //Używamy wzoru na punkty w kole
            if (x2 + y2 < r2)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Sprawdza czy kula przeszła za dozwolony poziom, a nie została kliknięta
        /// </summary>
        /// <returns></returns>
        public int CheckIfBallWasMissed()
        {
            if (PositionY > LosePositionY)
            {
                return 1;
            }
            return 0;
        }
    }
}
