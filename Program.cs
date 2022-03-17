using System;
using System.Collections.Generic;
using TESTE_3_GFT.Models;
using static System.Console;

namespace TESTE_3_GFT
{
      class Program
      {
            public static void Main(string[]args)
            {
                  var Moradores = new List<Morador>();
                  Moradores.Add(new Morador("36958847",1));
                  Moradores.Add(new Morador("36958475",2));
                  Moradores.Add(new Morador("15478844",3));
                  Moradores.Add(new Morador("36914459",4));
                  Moradores.Add(new Morador("99111847",5));
                  Moradores.Add(new Morador("991012923",6));

                  int CasasImparesEntregues = 0;
                  foreach (var morador in Moradores)
                  {
                      WriteLine($"\n\n Na residencia numero {morador.getNumeroResidencia()}? tem cachorro? [S]sim / [N]ao");
                      var cachorroExists = ReadLine();
                      if (cachorroExists.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                      {
                        if (morador.getNumeroResidencia() % 2 == 1)
                        {
                        CasasImparesEntregues++;
                        }
                      }
                        else
                        {
                              WriteLine($"Correio nao foi entregue na casa numero {morador.getNumeroResidencia()}");
                        }

                      
                  }WriteLine($"O numero de casas ímpares que receberam sua correspôndencia foi de: {CasasImparesEntregues}");
                  
            }
      }
}