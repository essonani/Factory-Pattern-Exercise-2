namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what data base do you choose?");
            Console.WriteLine("type :mongo");
            Console.WriteLine("type :sql");
            Console.WriteLine("type :list");
            var userInput=Console.ReadLine();
            IDataAccess db=DataAccessFactory.GetDataAccessType(userInput);
            var products = db.LoadData();
            db.SaveData();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name,product.Price);
            }
        }
    }
}
