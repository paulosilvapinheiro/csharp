
namespace learn{
    public class WhileDesafio2{

        public WhileDesafio2(){
            
            string? funcao;
            bool enteredInvalid = true;

            Console.WriteLine("Informe sua função ( ADMINISTRADOR | GERENTE | USUARIO ):");

            do
            {
                funcao = Console.ReadLine();

                if (string.IsNullOrEmpty(funcao) || string.IsNullOrWhiteSpace(funcao)){
                    Console.WriteLine("Não identificamos nenhuma resposta. Informe sua função!!!"); 
                }else {
                    funcao = funcao.Trim().ToLower();
                    if(funcao != "administrador" && funcao != "gerente" && funcao != "usuario"){

                        Console.WriteLine(string.Format("A funcao informada ({0}) não é valida.\nInforme uma das seguintes funções:\nADMINISTRADOR\nGERENTE\nUSUARIO", funcao.ToUpper()));
                    }else{

                        enteredInvalid = false; 
                        Console.WriteLine(string.Format("A funcao informada ({0}) foi aceita.\nBem vindo {0}", funcao.ToUpper())); 
                    }
                }

            } while (enteredInvalid);
        }
    }
}