namespace learn{
    public class Condicional{

        public Condicional(){

            Random dice = new Random();

            // int roll1 = dice.Next(1, 7);
            // int roll2 = dice.Next(1, 7);
            // int roll3 = dice.Next(1, 7);

            int roll1 = 6;
            int roll2 = 6;
            int roll3 = 6;

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) && (roll2 == roll3)) 
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            // if ((roll1 == roll2) && (roll2 == roll3)) 
            // {
            //     Console.WriteLine("You rolled triples! +6 bonus to total!");
            //     total += 6;
            // }

            if (total > 14)
            {
                Console.WriteLine("You win!");
            }
            else
            // if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }


            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if (message.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }


            // DESAFIO
            Console.WriteLine("DESAFIO");

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine($"dias para expirar {daysUntilExpiration}");

            if(daysUntilExpiration < 1){

               Console.WriteLine("Your subscription has expired.");

            }
            else if (daysUntilExpiration < 2){
                
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration < 6){
                
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 11;
            }
            else if (daysUntilExpiration < 11){
                
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            
            if ( discountPercentage > 0){
                
                Console.WriteLine($"Renew now and save {discountPercentage}%!");
            }
        }

    }
}