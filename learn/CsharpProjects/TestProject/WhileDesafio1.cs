
namespace learn{
    public class WhileDesafio1{

        public WhileDesafio1(){
            
            int result=0;
            bool valueEnteredNOk = true;

                Console.WriteLine("Entre um valor inteiro entre 5 e 10.");

                do{

                    if(int.TryParse(Console.ReadLine(),out result)){
                        if(result > 4 && result < 11){
                            valueEnteredNOk = false;
                        }else{
                            Console.WriteLine(string.Format("Você entrou o valor {0}. Favor entre um número inteiro entre 5 e 10",result));
                        }
                    } else{
                        Console.WriteLine("Desculpe, mas você entrou um número inválido.\n\nFavor entre um número inteiro.");
                    }

                }while(valueEnteredNOk);

            Console.WriteLine(string.Format("O valor ({0}) inserido foi aceito",result));
        }
    }
}