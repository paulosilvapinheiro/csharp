using CodeSignal;

namespace estudoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Here is the Paulo!!!");
            
            CodeSignalExercises cSignal = new CodeSignalExercises();

            //teste codesignal JourneyBegins_checkPalindrome
            //bool ret = cSignal.JourneyBegins_checkPalindrome(Console.ReadLine());

            int[] intArray = {-23, 4, -3, 8, -12};
            int i = cSignal.EdgeOfTheOcean_adjacentElementsProduct(intArray);
            Console.WriteLine("resultado de EdgeOfTheOcean_adjacentElementsProduct é {0}", i);

        }
    }
}