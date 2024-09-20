
namespace learn{
    public class LoopFor{

        public LoopFor(){

            // FizzBuzz
            for(int i=1; i < 101; i++){

                string Fizz="";
                string Buzz="";

                if( i % 3 == 0)
                    Fizz = "Fizz";

                if( i % 5 == 0)
                    Buzz = "Buzz";


                Console.WriteLine($"{i} : {Fizz}{Buzz}");
            }
        }
           
    }
}