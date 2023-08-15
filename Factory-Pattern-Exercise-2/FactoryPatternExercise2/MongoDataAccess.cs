using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name="xbox",Price=350},
             new Product(){Name="guitar",Price=1000},
            new Product(){Name="BLENDER",Price=50},
             new Product(){Name="KITE",Price=35},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("i am reading from mongo data access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("i am saving data from mongo DataAccess");
        }
    }
}
