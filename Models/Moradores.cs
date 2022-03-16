using System;
namespace Teste_3_GFT_new_2.Models
{
    public class Moradores
    {
        private int Num { get; set; }
        private int Tel{ get; set; }

        private int CasaImpar { get; set; }
    
        public void Teste1()
        {               
                        string Casa;
                        int CasaImpar;
                        CasaImpar=0;

                                              
                        for (int i = 1; i <= 4; i++)
                        {
                        Console.WriteLine($"A casa {i} tem cachorro? Pressione [S] se Sim e [N] se não tiver cachorros: ");
                        Casa = Console.ReadLine();
                        Casa = Casa.ToUpper();
                        Console.WriteLine();
                           
                            if (Casa == "N")
                            {
                            int [] Num= new int [5];
                            Console.WriteLine($"Digite o numero da {i}º casa: ");
                            Num[i] = int.Parse(Console.ReadLine());
                        
                            int [] Tel =new int [5];
                            Console.WriteLine($"Digite o telefone da casa {i}º: ");
                            Tel[i] = int.Parse(Console.ReadLine());
                                if (Num[i] % 2==1)
                                {
                                    CasaImpar = CasaImpar +1; //Conta quantos ímpares foram somados.
                                }
                            }
                            if (Casa == "S")
                            {
                            Console.WriteLine("Você correu desesperadamente para a próxima casa! ");
                            Console.WriteLine();
                            }
                        }
                        Console.WriteLine($"Foram entregues {CasaImpar} corresondencias em casas de numeros ímpares. ");
        }               
    
    
    }
}
