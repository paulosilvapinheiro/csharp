
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


            // ------------------------------------------------------------------------------------
            // Use os métodos auxiliares IndexOf() e Substring() da cadeia de caracteres
            // ------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// Use os métodos auxiliares IndexOf() e Substring() da cadeia de caracteres
// ------------------------------------------------------------------------------------");

            message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            openingPosition +=1;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = "What is the value <span>between the tags</span>?";

            openingPosition = message.IndexOf("<span>");
            closingPosition = message.IndexOf("</span>");

            openingPosition += 6;
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // ------------------------------------------------------------------------------------
            // Versão sem numeros mágicos ou cadeias de caracteres mágicos
            // ------------------------------------------------------------------------------------

            message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            openingPosition = message.IndexOf(openSpan);
            closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // ------------------------------------------------------------------------------------
            // Exercício – Usar os métodos auxiliares IndexOf() e LastIndexOf() da cadeia de caracteres
            // ------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// Exercício – Usar os métodos auxiliares IndexOf() e LastIndexOf() da cadeia de caracteres
// ------------------------------------------------------------------------------------");

            message = "hello there!";

            int first_h = message.IndexOf('h');
            int last_h = message.LastIndexOf('h');

            Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

            message = "(What if) I am (only interested) in the last (set of parentheses)?";
            openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            closingPosition = message.LastIndexOf(')');
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                closingPosition = message.IndexOf(')');
                length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note the overload of the Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }

            message = "Help (find) the {opening symbols}";
            Console.WriteLine($"Searching THIS Message: {message}");
            char[] openSymbols = { '[', '{', '(' };
            int startPosition = 5;
            openingPosition = message.IndexOfAny(openSymbols);
            Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            openingPosition = message.IndexOfAny(openSymbols, startPosition);
            Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

            message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // You want to look for:

            openSymbols = new char[]{ '[', '{', '(' };

            // You'll use a slightly different technique for iterating through 
            // the characters in the string. This time, use the closing 
            // position of the previous iteration as the starting index for the 
            //next open symbol. So, you need to initialize the closingPosition 
            // variable to zero:

            closingPosition = 0;

            while (true)
            {
                openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now  find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Finally, use the techniques you've already learned to display the sub-string:

                length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
            }

            // ------------------------------------------------------------------------------------
            // Exercício – Usar os métodos Remove() e Replace()
            // ------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// Exercício – Usar os métodos Remove() e Replace()
// ------------------------------------------------------------------------------------");

            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);

            // ------------------------------------------------------------------------------------
            // Exercício: conclua um desafio para extrair, substituir e remover os dados de uma cadeia de caracteres de entrada
            // ------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(@"// ------------------------------------------------------------------------------------
// Exercício: conclua um desafio para extrair, substituir e remover os dados de uma cadeia de caracteres de entrada
// ------------------------------------------------------------------------------------");

            const string inputHTML = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            string openTag = "<span>";
            string closeTag = "</span>";

            int start = inputHTML.IndexOf(openTag);
            int end = inputHTML.IndexOf(closeTag);

            start += openTag.Length;
            length = end - start;
            quantity = $"Quantity: {inputHTML.Substring(start, length)}";

            openTag = "<div>";
            closeTag = "</div>";

            start = inputHTML.IndexOf(openTag);
            end = inputHTML.IndexOf(closeTag);

            start += openTag.Length;
            length = end - start;
            output = $"Output: {inputHTML.Substring(start, length).Replace("&trade", "&reg")}";

            Console.WriteLine(quantity);
            Console.WriteLine(output);
            
        }
    }
}