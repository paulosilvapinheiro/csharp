
namespace learn{
    public class LoopWhile{

        public LoopWhile(){
            // Random random = new Random();
            // int current = 0;

            // do
            // {
            //     current = random.Next(1, 11);
            //     Console.WriteLine(current);
            // } while (current != 7);

            // current = random.Next(1, 11);

            // while (current >= 3)
            // {
            //     Console.WriteLine(current);
            //     current = random.Next(1, 11);
            // }
            // Console.WriteLine($"Last number: {current}");

            int heroi = 10;
            int monstro = 10;
            int golpe = 0;

            Random random = new Random();

            Console.WriteLine($"Integridade dos participantes\nHEROI: {heroi}\nMONSTRO: {monstro}\n\n----------------------------------");

            int iniciante = random.Next(1,10);

            if (iniciante > 5){

                Console.WriteLine("Ataque do MONSTRO!!!");

                golpe = random.Next(1,10);

                heroi -= golpe;

                Console.WriteLine($"O heroi perdeu {golpe} de integridade.\nFalta {heroi} de vida para o herói\n");
            }

            if (heroi > 0 && monstro > 0){
                do{
                    
                    Console.WriteLine("Ataque do HEROI!!!");

                    golpe = random.Next(1,10);

                    monstro -= golpe;

                    Console.WriteLine($"O monstro perdeu {golpe} de integridade.\nFalta {monstro} de vida para o monstro\n");

                    if(monstro < 0)
                        continue;
                    
                    Console.WriteLine("Ataque do MONSTRO!!!");

                    golpe = random.Next(1,10);

                    heroi -= golpe;

                    Console.WriteLine($"O heroi perdeu {golpe} de integridade.\nFalta {heroi} de vida para o herói\n");

                }while (heroi > 0 && monstro > 0);
            }

            if(heroi > monstro)
                Console.WriteLine("O vencedor foi o HERÓI!!!");
            else
                Console.WriteLine("O vencedor foi 0 MONSTRO!!!");
        }
    }
}