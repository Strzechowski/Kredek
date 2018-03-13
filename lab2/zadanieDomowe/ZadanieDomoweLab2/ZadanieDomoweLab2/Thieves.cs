using System;

namespace ZadanieDomoweLab2
{
    class Thieves
    {
        public int[] BeastPower = {0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70};
        public int numberOfAttacks = 0;

        /// <summary>
        /// Funkcja losowo wybiera kto nas okradnie
        /// </summary>
        /// <returns></returns>
        public string WhoAttacks()
        {
            int number;
            Random rnd = new Random();
            number=rnd.Next(0, 3);
            if (number == 0)
                return "Szaleni Grzybiarze";
            else if (number == 1)
                return "Pierogowy potwór";
            else
                return "Nikt";
        }

        /// <summary>
        /// Funkcja zapamiętuje, ile ataków przetrwaliśmy
        /// </summary>
        /// <returns></returns>
        public int WhichAttack()
        {
            numberOfAttacks++;
            return numberOfAttacks;
        }
    }
}
