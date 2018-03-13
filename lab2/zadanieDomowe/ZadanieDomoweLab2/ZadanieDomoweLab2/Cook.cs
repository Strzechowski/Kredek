namespace ZadanieDomoweLab2
{
    class Cook : Employees
    {
        public string Nationality { get; set; }
        public bool ChefHat { get; set; }


        /// <summary>
        /// Konstruktor dla kucharza
        /// </summary>
        /// <param name="name"></param>
        /// <param name="howManyResourcesPerHour"></param>
        /// <param name="hairstyle"></param>
        /// <param name="nationality"></param>
        /// <param name="chefHat"></param>
        public Cook(string name, int howManyResourcesPerHour, string hairstyle, string nationality, bool chefHat)
        {
            Name = name;
            HowManyResourcesPerHour = howManyResourcesPerHour;
            Nationality = nationality;           
            Hairstyle = hairstyle;
            ChefHat = chefHat;
        }

        /// <summary>
        /// Nadpisanie funkcji mówiącej o pracowniku dla kucharza
        /// </summary>
        /// <returns></returns>
        public override string SaySomething()
        {
            return ("Jestem kucharzem i robię pierogi! \r\n");
        }

        /// <summary>
        /// Nadpisanie funkcji mówiącej o tym co posiada pracownik dla kucharza
        /// </summary>
        /// <returns></returns>
        public override string WhatIHave()
        {
            string tmp = "Jetem " + Name + " i mam czapkę szefa kuchni.";
            if (ChefHat == false)
                 tmp = "Jestem " + Name + " i nie mam czapki szefa kuchni.";
            return tmp ;
        }
    }
}
