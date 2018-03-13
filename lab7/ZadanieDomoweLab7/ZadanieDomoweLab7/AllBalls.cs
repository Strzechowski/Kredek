using System;
using System.Collections.Generic;
using System.Drawing;


namespace ZadanieDomoweLab7
{
    /// <summary>
    /// Klasa zawiera listę wszystkich kul
    /// </summary>
    public class AllBalls
    {
        List<Ball> listOfBalls = new List<Ball>();

        //Klasa random będzie potrzebna do losowania pozycji startowej kuli
        Random randomNumber = new Random();

        /// <summary>
        /// Dodanie kuli do listy
        /// </summary>
        public void AddBallToList(int losePositionY, int widthOfWindow)
        {
            Ball ballToAdd = new Ball(randomNumber, losePositionY, widthOfWindow);
            listOfBalls.Add(ballToAdd);
        }

        /// <summary>
        /// Przemieszczamy wszystkie kule po ekranie
        /// </summary>
        public void MoveBallsFromList()
        {
            for (int i = 0; i < listOfBalls.Count; i++)
            {
                listOfBalls[i].BallMove();
            }
        }

        /// <summary>
        /// Rysujemy wszystkie kule
        /// </summary>
        /// <param name="graph"></param>
        public void DrawBallFromList(Graphics graph)
        {
            //Czyszczenie kolorem tła w FormGame
            graph.Clear(SystemColors.Highlight);

            for (int i = 0; i < listOfBalls.Count; i++)
            {                
                    listOfBalls[i].BallDraw(graph);                            
            }
        }

        /// <summary>
        /// Sprawdza czy kliknięto na którąkolwiek z kulek, zwraca 1 jako zdobyty punkt (jeśli kulki się nakrywają to usuniemy tylko jedną)
        /// </summary>
        public int CheckIfClikedOnAnyBall(Point cursorPosition)
        {         
            for (int i = 0; i < listOfBalls.Count; i++)
            {
                if (listOfBalls[i].CheckIfClickedOnBall(cursorPosition) == true)
                {
                    listOfBalls.RemoveAt(i);
                    return 1;
                }       
            }
            return 0;
        }

        /// <summary>
        /// Zlicza ile kulek spadło poniżej dozwolonego poziomu
        /// </summary>
        /// <param name="cursorPosition"></param>
        /// <returns></returns>
        public int HowManyBallsWereMissed()
        {
            int MissedBalls = 0;

            for (int i = 0; i < listOfBalls.Count; i++)
            {
                MissedBalls += listOfBalls[i].CheckIfBallWasMissed();
            }
            return MissedBalls;
        }
    }
}
