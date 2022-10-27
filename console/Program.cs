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
            bool ret = cSignal.JourneyBegins_checkPalindrome(Console.ReadLine());

        }
    }
}