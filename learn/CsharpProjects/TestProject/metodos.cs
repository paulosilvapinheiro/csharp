
namespace learn{
    public class Metodos{

        /*
        if ipAddress consists of 4 numbers
        and
        if each ipAddress number has no leading zeroes
        and
        if each ipAddress number is in range 0 - 255

        then ipAddress is valid

        else ipAddress is invalid
        */

        string ipv4Input = "107.31.1.5";
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;
        public Metodos(){

            ValidateLength(); 
            ValidateZeroes(); 
            ValidateRange();

            if (validLength && validZeroes && validRange) 
            {
                Console.WriteLine($"ip is a valid IPv4 address");
            } 
            else
            {
                Console.WriteLine($"ip is an invalid IPv4 address");
            }
        }
           
        void ValidateLength() 
        {
            string[] address = ipv4Input.Split(".");
            validLength = address.Length == 4;
        }
        void ValidateZeroes() 
        {
            string[] address = ipv4Input.Split(".");

            foreach (string number in address) 
            {
                if (number.Length > 1 && number.StartsWith("0")) 
                {
                    validZeroes = false;
                }
            }

            validZeroes = true;
        }

        void ValidateRange() 
        {
            string[] address = ipv4Input.Split(".");

            foreach (string number in address) 
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255) 
                {
                    validRange = false;
                    return;
                }
            }
            validRange = true;
        }
    }
}