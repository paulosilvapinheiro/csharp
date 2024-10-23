
namespace learn{
    public class OperacoesMatrizes{

        public OperacoesMatrizes(){

                string[] pallets = {"B14", "A11", "B12", "A13"};

                // Console.WriteLine("Sorted...");
                // ---------------------------------------------------------
                // |                       SORT
                // ---------------------------------------------------------
                // Array.Sort(pallets);

                // foreach (var pallet in pallets)
                // {
                //     Console.WriteLine($"--{pallet}");
                // }

                // Console.WriteLine("");

                // ---------------------------------------------------------
                // |                       REVERSE
                // ---------------------------------------------------------
                // Console.WriteLine("Reversed....");

                // Array.Reverse(pallets);

                // foreach (var pallet in pallets)
                // {
                //     Console.WriteLine($"--{pallet}");
                // }
                // Console.WriteLine($"Before: {pallets[0]}");

                // ---------------------------------------------------------
                // |                       CLEAR
                // ---------------------------------------------------------
                // Array.Clear(pallets, 0, 2);
                // Console.WriteLine($"After: {pallets[0]}");
                // Console.WriteLine($"Before: {pallets[0].ToLower()}");
                // Array.Clear(pallets, 0, 2);
                // Console.WriteLine($"After: {pallets[0].ToLower()}");
                // Console.WriteLine($"Clearing 2 ... cont: {pallets.Length}");

                // Console.WriteLine("");
                // ---------------------------------------------------------
                // |                       REZISE
                // ---------------------------------------------------------
                // Array.Resize(ref pallets, 6);
                // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

                // pallets[4] = "C01";
                // pallets[5] = "C02";

                // foreach (var pallet in pallets)
                // {
                //     Console.WriteLine($"-- {pallet}");
                // }

                // Console.WriteLine("");
                // Array.Resize(ref pallets, 3);
                // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

                // foreach (var pallet in pallets)
                // {
                //     Console.WriteLine($"-- {pallet}");
                // }

                // ---------------------------------------------------------
                // |                       ToArrayChar
                // ---------------------------------------------------------
                string value = "ABCDEF";
                char[] valueArray = value.ToCharArray();

                Array.Reverse(valueArray);
                string newValue = new string(valueArray);
                Console.WriteLine(newValue);

                // ---------------------------------------------------------
                // |                       JOIN
                // ---------------------------------------------------------

                valueArray = newValue.ToCharArray();
                newValue = string.Join(",", valueArray);
                Console.WriteLine(newValue);

                // ---------------------------------------------------------
                // |                       SPLIT
                // ---------------------------------------------------------

                string[] itens = newValue.Split(',');

                for(int i=0; i < itens.Length; i++ )
                {
                    Console.WriteLine(itens[i]);
                }

                // ---------------------------------------------------------
                // |                       DESAFIO 1
                // ---------------------------------------------------------
                string pangram = "The quick brown fox jumps over the lazy dog";

                string[] palavras = pangram.Split(' ');

                for(int i=0;i<palavras.Length;i++ )
                {
                    char[] palavraArray = palavras[i].ToCharArray();
                    Array.Reverse(palavraArray);
                    palavras[i] = new string(palavraArray);
                }

                pangram = string.Join(" ", palavras);

                Console.WriteLine(pangram);

                // ---------------------------------------------------------
                // |                       DESAFIO 2
                // ---------------------------------------------------------
                string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

                string[] orders = orderStream.Split(',');
                string[] messageOrders = new string[orders.Length];

                Array.Sort(orders);

                foreach (string order in orders)
                {
                    if(order.Length != 4)
                    {
                        Console.WriteLine($"{order} \t- Error");
                    }
                    else
                    {
                        Console.WriteLine(order);
                    }
                }
        }
           
    }
}