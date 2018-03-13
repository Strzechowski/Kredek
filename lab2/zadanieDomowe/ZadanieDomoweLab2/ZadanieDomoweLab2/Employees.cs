namespace ZadanieDomoweLab2
{
    public abstract class Employees
    {
        public string Name { get; set; }
        public string Hairstyle { get; set; }
        public int HowManyResourcesPerHour { get; set; }

        /// <summary>
        /// Funkja zwraca string mówiący coś o pracowniku
        /// </summary>
        /// <returns></returns>
        public virtual string SaySomething()
        {
            return("I'm your employee.");
        }

        /// <summary>
        /// Funkcja zwraca string mówiący co posiada pracownik
        /// </summary>
        /// <returns></returns>
        public abstract string WhatIHave();
    }
}
