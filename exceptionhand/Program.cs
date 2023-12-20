namespace exceptionhand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                List<int> numbers = new List<int> { 10,20};
                CheckForDuplicates(numbers);
                Console.WriteLine("No duplicates found. All numbers are unique.");
            }
            catch(excptionhand ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"good job");

            }




        }
        static void CheckForDuplicates(List<int> numbers)
        {
            Console.WriteLine("enter yr fav number");

            int num = Convert.ToInt32(Console.ReadLine());
            foreach (int number in numbers)
            {
                if (number == num)
                {
                    throw new excptionhand(number);
                }
                else
                {
                    numbers.Add(num);
                    Console.WriteLine("done");
                }
            }

        }
    }
}