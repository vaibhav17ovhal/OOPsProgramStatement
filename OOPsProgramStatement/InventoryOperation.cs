using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OOPsProgramStatement.InventoryDataManagement;


namespace OOPsProgramStatement
{
    public class InventoryOperation
    {
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result  = JsonConvert.DeserializeObject<List<InventoryData>>(data);
            foreach(var inventory in result)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
    }
}
