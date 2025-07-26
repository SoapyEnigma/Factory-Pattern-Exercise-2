namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) // not good practice
            {
                Console.WriteLine("Hello, what Data would you like to access?\n"
                    + "[1] List\n"
                    + "[2] SQL\n"
                    + "[3] Mongo\n"
                    + "[4] Exit\n");

                int input;
                while (!int.TryParse(Console.ReadLine(), out input)
                    || input != (int)DBTypes.LIST && input != (int)DBTypes.SQL && input != (int)DBTypes.MONGO && input != 4)
                {
                    Console.WriteLine("Please only input 1, 2, 3, or 4.");
                }

                if (input == 4)
                    break;

                IDataAccess db = DataAccessFactory.GetDataAccessType((DBTypes)input);

                input = 0;
                while (input != 3)
                {
                    Console.WriteLine("What would you like to do?\n"
                        + "[1] Load Data\n"
                        + "[2] Save Data\n"
                        + "[3] Go Back\n");

                    while (!int.TryParse(Console.ReadLine(), out input)
                        || input != 1 && input != 2 && input != 3)
                    {
                        Console.WriteLine("Please only input 1, 2, or 3.");
                    }

                    if (input == 1)
                        db.LoadData();
                    else if (input == 2)
                        db.SaveData();
                }

                Console.Clear();
            }
        }
    }
}
