namespace learn{

    public class Booleano{

        public Booleano(){
/*
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            myValue = "a";
            Console.WriteLine(myValue != "a");

            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));

            // These two lines of code will create the same output
            Console.WriteLine(pangram.Contains("fox") == false);
            Console.WriteLine(!pangram.Contains("fox"));

            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50; // if ternário
            Console.WriteLine($"Discount: {discount}");
            */
            // Console.WriteLine(new Random().Next(1,10) < 6  ? "head" : "tails");

            string permission = "user";
            int level = 19;

            if (permission.ToLower().Contains("admin")){
                if( level > 55)
                    Console.WriteLine("Welcome, Super Admin user.");
                else 
                    Console.WriteLine("Welcome, Admin user.");
            }
            else if (permission.ToLower().Contains("manager")){
                if( level > 19)
                    Console.WriteLine("Contact an Admin for access.");
                else 
                    Console.WriteLine("You do not have sufficient privileges.");
            }
            else{
                Console.WriteLine("You do not have sufficient privileges.");
            }
            
        }

    }

}
