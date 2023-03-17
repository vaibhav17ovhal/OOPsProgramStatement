using System;

namespace OOPsProgramStatement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs");
            InventoryOperation inventory = new InventoryOperation();
            inventory.ReadJsonFile(@"");
        }
    }
}
