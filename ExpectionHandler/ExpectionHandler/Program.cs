namespace ExpectionHandler
{

    public class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("please insert an index");

            var index = Convert.ToInt32(Console.ReadLine());

            var exc = new Expecton();

            var result = exc.GetNumber(index);
            if (Expecton.WrongAnswer)
            {
                Console.WriteLine("the number is wrong");
            }
            else
            {

                Console.WriteLine($"the number is {result}");
            }

            Console.ReadKey();
        }
    }
}