
using System.Diagnostics;

namespace learn{
    public class Matrizes{

        public Matrizes(){

            /*
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            // fraudulentOrderIDs[3] = "D000";
            */

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            foreach (string fraud in fraudulentOrderIDs)
            {
                Console.WriteLine(fraud);
            }

            int [] fibbonaci = { 1,1,2,3,5,8,13,21 };
            int sumItens=0;

            foreach(int item in fibbonaci){

                sumItens += item;

                Console.WriteLine($"item {item} acrescentado ao total da sequencia {sumItens}");
            }

            // DESAFIO
            Console.WriteLine("DESAFIO");

            string[] pedidos = {
                                    "B123"
                                    ,"C234"
                                    ,"A345"
                                    ,"C15"
                                    ,"B177"
                                    ,"G3003"
                                    ,"C235"
                                    ,"B179"
            }                   ;

            foreach(string pedido in pedidos){

                // if(pedido[0] == 'B'){
                if(pedido.StartsWith("B")){
                    
                    Console.WriteLine(pedido);
                }
            }

        }
           
    }
}