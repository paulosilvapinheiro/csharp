
namespace learn{
    public class MetodosEscopo{

        
        public MetodosEscopo(){

            DisplayStudents(students);
            DisplayStudents(new string[] {"Robert","Vanya"});

            PrintCircleInfo(12);
            PrintCircleInfo(24);
            
        }
        string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};        

        void DisplayStudents(string[] students) 
        {
            foreach (string student in students) 
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine();
        }

        double pi = 3.14159;

        void PrintCircleArea(int radius)
        {
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        void PrintCircleCircumference(int radius)
        {
            double circumference = 2 * pi * radius;
            Console.WriteLine($"Circumference = {circumference}");
        }

        void PrintCircleInfo(int radius) 
        {
            Console.WriteLine($"Circle with radius {radius}");
            PrintCircleArea(radius);
            PrintCircleCircumference(radius);
        }
    }
}