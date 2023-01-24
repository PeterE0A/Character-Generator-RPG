namespace H1W2D2RPG
{
    internal class Character
    {
        //Because the method that uses this array is static, we also make the array static.
        private static string[] characterClass = { "Warrior", "Wizard", "Priest", "Rouge", "Summoner", "Druid", "Ranger" };

        public string Name { get; set; } = "NoNameYet";
        public string CharacterClass { get; set; }
        public DateTime Birthday { get; set; }

        public Character()
        {
            GetRandomBirthday();
        }

        private void GetRandomBirthday()
        {
            Random random = new Random();
            DateTime start = new DateTime(1020, 1, 1);
            DateTime end = new DateTime(1120, 1, 1);
            int range = (end - start).Days;
            int days = random.Next(range);
            Birthday = start.AddDays(days);
        }

        //Static method runs on class and not on object
        public static string GetCharacterClassRandomly()
        {
            Random random = new Random();
            int r = random.Next(characterClass.Length);
            string cc = characterClass[r];
            return cc;

            //return characterClass[new Random().Next(characterClass.Length)];
        }

    }
}
