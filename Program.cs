using H1W2D2RPG;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Character firstChar = new Character();
firstChar.Name = "EtEllerAndet";

//The method is static, so it runs on the class and not the object
firstChar.CharacterClass = Character.GetCharacterClassRandomly();

Console.WriteLine(firstChar.Name);