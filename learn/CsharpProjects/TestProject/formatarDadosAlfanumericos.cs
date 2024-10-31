
using System.Globalization;

namespace learn{
    public class FormatarDadosAlfanumericos{

        public FormatarDadosAlfanumericos(){

            // Sample formatação composta
            string name = "Eduardo";
            string sobrenome = "da Silva";

            Console.WriteLine("{0} {1}", name, sobrenome);

            // Sample formatação com interpolação
            Console.WriteLine($"{name} {sobrenome}");

            // ---------------------------------------------------------
            // |                       FORMTAÇÃO
            // ---------------------------------------------------------

            // MOEDA
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"preço: {price} com desconto de {discount}");
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"preço: {price:C} com desconto de {discount:C}");
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
            Console.WriteLine($"preço: {price:C} com desconto de {discount:C}");

            // NUMÉRICO
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");            
            Console.WriteLine($"Measurement: {measurement:N4} units");  

            // PERCENTUAL
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            // SAMPLE
            decimal salePrice = 59.99m;

            string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            Console.WriteLine(yourDiscount);

            yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
            Console.WriteLine(yourDiscount);

            // ------------------------------------------------------------------------------------
            // EXERCÍCIO – EXPLORAR A INTERPOLAÇÃO DE CADEIA DE CARACTERES
            // ------------------------------------------------------------------------------------
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// EXERCÍCIO – EXPLORAR A INTERPOLAÇÃO DE CADEIA DE CARACTERES
// ------------------------------------------------------------------------------------");
            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"    Shares: {productShares:N3} Product");
            Console.WriteLine($"        Sub Total: {subtotal:C}");
            Console.WriteLine($"            Tax: {taxPercentage:P2}");
            Console.WriteLine($"        Total Billed: {total:C}");

            // ------------------------------------------------------------------------------------
            // EXERCÍCIO – DESCOBRIR O PREENCHIMENTO E ALINHAMENTO
            // ------------------------------------------------------------------------------------
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// EXERCÍCIO – DESCOBRIR O PREENCHIMENTO E ALINHAMENTO
// ------------------------------------------------------------------------------------");

            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));
            Console.WriteLine("\n\n");

            string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);

            // ------------------------------------------------------------------------------------
            // DESAFIO
            // ------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// DESAFIO
// ------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            string message = "";

            message = string.Format($"Dear {customerName},\n");
            
            message += string.Format($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n");

            message += string.Format($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P}.\n\n");

            message += string.Format($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n");

            Console.WriteLine(message);

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = $"{currentProduct}".PadRight(19);
            comparisonMessage += $"{currentReturn:P}";
            comparisonMessage += $"{currentProfit:C}\n".PadLeft(20);
            comparisonMessage += $"{newProduct}".PadRight(19);
            comparisonMessage += $"{newReturn:P}";
            comparisonMessage += $"{newProfit:C}\n".PadLeft(20);

            Console.WriteLine(comparisonMessage);

        }
    }
}