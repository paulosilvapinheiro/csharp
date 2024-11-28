
namespace learn{
    public class MetodosJogoDados{

        Random random = new Random();
        public MetodosJogoDados(){

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay()) 
            {
                PlayGame();
            }                
        }

        void PlayGame() 
        {
            var play = true;

            while (play)
            {
                var target = GetTarget();
                var roll = RollDice();

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        private int GetTarget()
        {
            return random.Next(1, 5);
        }

        private int RollDice()
        {
            return random.Next(1, 6);
        }

        string WinOrLose(int roll, int target)
        {
            return roll > target ? "Você GANHOU!!!!!" : "Não foi dessa vez você perdeu.";
        }
        
        bool ShouldPlay()
        {
            string ?result;
            bool answerValid = false;

            do
            {
                result = Console.ReadLine();

                if(!string.IsNullOrEmpty(result) && !string.IsNullOrWhiteSpace(result))
                {    
                    result = result.ToLower().Trim();

                    if(result=="y" || result=="n")
                    {
                        answerValid = true;     
                    }
                }

                if (answerValid == false)
                {
                    Console.WriteLine("Por favor entre uma resposta valida. Y ou N");
                }

            }while(answerValid == false);

            return result == "y"  ? true : false;
        }
    }
}