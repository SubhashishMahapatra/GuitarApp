using System.Reflection;
using GuitarApp.Enums;
using GuitarApp.Model;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);
        GuitarSpec whatErinLikes = new GuitarSpec(Builder.COLLINGS, "CJ", Types.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.SITKA, 6);
        List<Guitar> matchingGuitars = inventory.SearchGuitar(whatErinLikes);
        if (matchingGuitars.Count > 0)
        {
            Console.WriteLine("Erin, you might like these guitars:");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {"Sr. No.",-8} | {"Builder",-10} | {"Model",-15} | {"Type",-10} | {"BackWood",-18} | {"TopWood",-10} | {"No. of Strings",-15} | {"Price",-8}|");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            foreach (Guitar guitar in matchingGuitars)
            {
                Console.WriteLine($"| {guitar.GetSerialNumber(),-8} | {guitar.specs.GetBuilder(),-10} | {guitar.specs.GetModel(),-15} | {guitar.specs.GetType(),-10} | {guitar.specs.BackWood,-10} | {guitar.specs.TopWood,-10} | {guitar.specs.NumberOfStrings,-15} | {guitar.GetPrice(),-8}|");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }
        }
        else
        {
            Console.WriteLine(" Erin, we have nothing for you :(");
        }


    }
    private static void InitializeInventory(Inventory inventory)
    {
        inventory.AddGuitar("1", new GuitarSpec(Builder.COLLINGS, "CJ", Types.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.SITKA, 6), 4000);
        inventory.AddGuitar("2", new GuitarSpec(Builder.FENDER, "Stratocaster", Types.ELECTRIC, Wood.ALDER, Wood.ALDER, 6), 1500);
        inventory.AddGuitar("3", new GuitarSpec(Builder.GIBSON, "Stratocaster", Types.ACOUSTIC, Wood.ALDER, Wood.ALDER, 6), 1149.50);
        inventory.AddGuitar("4", new GuitarSpec(Builder.COLLINGS, "CJ", Types.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.SITKA, 6), 2000);
    }
}