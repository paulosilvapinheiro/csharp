
namespace learn{
    public class MetodosEnderecoEmail{

        string[,] corporate = 
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external = 
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";
        public MetodosEnderecoEmail(){           

            for (int i = 0; i < corporate.GetLength(0); i++) 
            {
                Console.WriteLine(definirEmail(corporate[i,0], corporate[i,1]));
            }

            for (int i = 0; i < external.GetLength(0); i++) 
            {
            Console.WriteLine(definirEmail(external[i,0], external[i,1],externalDomain));
            }
        }

        public string definirEmail(string fisrtName, string lastName, string dominio = "contoso.com"){

            return $"{fisrtName.Substring(0,2)}{lastName}@{dominio}".ToLower();
        }
           
    }
}