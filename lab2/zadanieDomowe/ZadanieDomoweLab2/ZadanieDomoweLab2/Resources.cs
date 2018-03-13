namespace ZadanieDomoweLab2
{
    class Resources
    {
        public int Money { get; set; }
        public int Mushrooms { get; set; }
        public int DumplingDoughs { get; set; }
        public int Time { get; set; }

        private double sum = 0;

        /// <summary>
        /// Ustawia początkowe zasoby na 0
        /// </summary>
        public void StartResources()
        {
            Money = 0;
            Mushrooms = 0;
            DumplingDoughs = 0;
        }

        /// <summary>
        /// Funkcja wylicza średnią ilość posiadanych pieniędzy podczas gry
        /// </summary>
        /// <returns></returns>
        public double AvarageAmmountOfMoney()
        {
            sum += Money;
            return sum/Time;
        }

    }
}
