using System.Globalization;
namespace learn
{
    public class Casting
    {

        public Casting()
        {
            //Sample 1 - erro
            // int first = 2;
            // string second = "4";
            // int result = first + second;
            // Console.WriteLine(result);

            //Sample 2 - Conversão segura do compilador
            // int first = 2;
            // string second = "4";
            // string result = first + second;
            // Console.WriteLine(result);

            //Sample 3 - perda de informação (conversão de expansão)
            /*
                O termo conversão de expansão significa que você está tentando converter um valor de um tipo de dados que poderia armazenar menos 
                informações em um tipo de dados que pode armazenar mais informações. Neste caso, um valor armazenado em uma variável do tipo int 
                convertida em uma variável do tipo decimal não perde informação.
            */
            // int myInt = 3;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = myInt;
            // Console.WriteLine($"decimal: {myDecimal}");

            //Sample 4 - Coersão
            /*
                Para executar uma coerção, use o operador de coerção () para cercar um tipo de dados e coloque-o ao lado da variável que deseja 
                converter (por exemplo: (int)myDecimal). Você executará uma CONVERSÃO EXPLÍCITA para o tipo de dados de coerção definido (int).

                Pode ocorrer PERDA DE DADO
            */
            // decimal myDecimal = 3.14m;
            // Console.WriteLine($"decimal: {myDecimal}");

            // int myInt = (int)myDecimal;
            // Console.WriteLine($"int: {myInt}");

            //Sample 5 - Coersão - Expansão ou Restrição
            //Restrição
            // decimal myDecimal = 1.23456789m;
            // float myFloat = (float)myDecimal;

            // Console.WriteLine($"Decimal: {myDecimal}");
            // Console.WriteLine($"Float  : {myFloat}");

            //Expansão
            // float myFloat2 = 1.2345678f;
            // decimal myDecimal2 = (decimal)myFloat2;

            // Console.WriteLine($"Float2  : {myFloat2}");
            // Console.WriteLine($"Decimal2: {myDecimal2}");

            /*  
            ------------------------------------------------------------------------------
            * CONVERSÃ DE DADOS - COM MÉTODOS
            ------------------------------------------------------------------------------
            */
            
            //Sampe 6 - Método auxiliar na variavel
            // ToString()
            // int first = 5;
            // int second = 7;
            // string message = first.ToString() + second.ToString();
            // Console.WriteLine(message);

            //Sampe 7 - Método auxiliar no tipo do dado
            // ToString()
            // string firstInt = "5";
            // string secondInt = "7";
            // int sum = int.Parse(firstInt) + int.Parse(secondInt);
            // Console.WriteLine(sum);

            //Sample 8 - métodos da classe Convert
            // string value1 = "5";
            // string value2 = "7";
            // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            // Console.WriteLine(result);

            //Sample 9 - Comparar a coerção e a conversão de um decimal em um int
            // int value3 = (int)1.5m; // casting truncates
            // Console.WriteLine(value3);

            // int value4 = Convert.ToInt32(1.5m); // converting rounds up
            // Console.WriteLine(value4);

            /*  
            ------------------------------------------------------------------------------
            * TRY PARSE
            ------------------------------------------------------------------------------
            */

            //Sample - Erro
            // string name = "Bob";
            // Console.WriteLine(int.Parse(name));

            // string value = "102";
            // string value = "bad";
            // int result = 0;
            // if (int.TryParse(value, out result))
            // {
            // Console.WriteLine($"Measurement: {result}");
            // }
            // else
            // {
            // Console.WriteLine("Unable to report the measurement.");
            // }

            // if (result > 0)
            // Console.WriteLine($"Measurement (w/ offset): {50 + result}");

             /*  
            ------------------------------------------------------------------------------
            * DESAFIO
            ------------------------------------------------------------------------------
            */
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            // string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        //     int intResult = 0;
        //     float floatResult = 0;
        //     float sumResult = 0;
        //     string textResult = "";

        //     foreach (var item in values)
        //     {
        //         if(int.TryParse(item, out intResult))
        //         {
        //             sumResult += (float)intResult; 
        //         }else if(float.TryParse(item,out floatResult))
        //         { 
        //             sumResult = floatResult;
        //         }else
        //         {
        //             textResult += item;
        //         }
        //     }

        //     Console.WriteLine($"Number Result {sumResult}");
        //     Console.WriteLine($"Text Result {textResult}");

        //     // Solução melhor
        //     decimal total = 0m;
        //     string message = "";

        //     foreach (var value in values)
        //     {
        //         decimal number; // stores the TryParse "out" value
        //         if (decimal.TryParse(value, out number))
        //         {
        //             total += number;
        //         } else
        //         {
        //             message += value;
        //         }
        //     }

        //     Console.WriteLine($"Message: {message}");
        //     Console.WriteLine($"Total: {total}");

            /*  
            ------------------------------------------------------------------------------
            * DESAFIO2
            ------------------------------------------------------------------------------
            */
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = Convert.ToDecimal(value2 / (decimal)value3);
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3/value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}