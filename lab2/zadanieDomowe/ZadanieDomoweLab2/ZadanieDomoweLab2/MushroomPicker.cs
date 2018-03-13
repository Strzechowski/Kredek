namespace ZadanieDomoweLab2
{
    class MushroomPicker : Employees
    {
        
        public bool Mustache { get; set; }


        /// <summary>
        /// Konstruktor dla grzybiarza
        /// </summary>
        /// <param name="name"></param>
        /// <param name="howManyResourcesPerHour"></param>
        /// <param name="hairstyle"></param>
        /// <param name="mustache"></param>
        public MushroomPicker(string name, int howManyResourcesPerHour, string hairstyle, bool mustache)
        {
            Name = name;
            HowManyResourcesPerHour = howManyResourcesPerHour;
            Hairstyle = hairstyle;
            Mustache = mustache;
        }

        /// <summary>
        /// Nadpisanie funkcji mówiącej o pracowniku dla grzybiarza
        /// </summary>
        /// <returns></returns>
        public override string SaySomething()
        {
            return ("Jestem grzybiarzem i to lubię! \r\n");
        }

        /// <summary>
        /// Nadpisanie funkcji mówiącej o tym co posiada pracownik dla grzybiarza
        /// </summary>
        /// <returns></returns>
        public override string WhatIHave()
        {
            string tmp = " ";
            if (Mustache == false)
                tmp = " nie ";

            return ("Jestem " + Name + " i " + tmp + "mam wąsa.");
        }
    }
}
