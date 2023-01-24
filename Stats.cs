using System.Reflection;

namespace H1W2D2RPG
{
    internal class Stats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public void GetRolled()
        {
            foreach (var property in GetType().GetProperties())
            {
                property.SetValue(this, Character.random.Next(3, 19));
                Console.WriteLine(property.Name + ": " + property.GetValue(this));
              
            }
            Console.WriteLine("");
        }

        public void ShowStats()
        {
            foreach (var property in GetType().GetProperties())
            {
                Console.WriteLine(property.Name + ": " + property.GetValue(this));
            }
        }

        public void ReRoll()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Press R to reroll: ");
                Console.ReadLine();

                int numThrows = 3;


                for (int i = 0; i < numThrows; i++)
                {
                    int dice_number = random.Next(1, 7);
                    GetRolled();

                }
            }
         

            
        }
    }
}
