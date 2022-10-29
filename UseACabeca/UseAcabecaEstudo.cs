namespace UseACabeca;
public class UseAcabecaEstudo
{
    public void Operadores()
    {
        int number = 15;
        int numberAux = number;
        number = number + 10;
        Console.WriteLine("{0} + 10 = {1}", numberAux, number);

        number = 36 * 15;
        Console.WriteLine("36 * 15 = {0}", number);

        number = 12 - ( 42 / 7 );
        Console.WriteLine("12 - ( 42 / 7 ) = {0}", number);

        numberAux = number;
        number =+ 10;
        Console.WriteLine("{0} =+ 10 = {1}", numberAux, number);

        numberAux = number;
        number += 10;
        Console.WriteLine("{0} += 10 = {1}", numberAux, number);

        numberAux = number;
        number *= 3;
        Console.WriteLine("{0} *= 3 = {1}", numberAux, number);

        numberAux = number;
        number = 71 / 3;
        Console.WriteLine("71 / 3 = {0}", number);

        Console.WriteLine("--number = {0}", --number);
        Console.WriteLine("number = {0}", number);
        Console.WriteLine("number-- = {0}", number--);
        Console.WriteLine("number = {0}", number);

        Console.WriteLine("++number = {0}", ++number);
        Console.WriteLine("number = {0}", number);
        Console.WriteLine("number++ = {0}", number++);
        Console.WriteLine("number = {0}", number);

        string result = "hello";
        result += " again " + result;
        Console.WriteLine("{0}", result);

        bool bVar = true;
        Console.WriteLine("bVar = {0}", bVar);
        Console.WriteLine("!bVar = {0}", !bVar);

        Console.Read();
    }
}
