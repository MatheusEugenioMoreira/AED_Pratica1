using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposAbstratosDeDados;

namespace pratica_1_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);

            //int numerovalido = 0;
            int total = 0;
            string resul = "";
            Console.Write("Insira um N° ou um Operador ou aperte 's' para sair: ");
            resul = Console.ReadLine();

            while (resul != "s")
            {

                if (resul == "+")
                {
                    int numero1 = p.desempilhar();
                    int numero2 = p.desempilhar();
                    total = numero1 + numero2;
                    p.empilhar(total);
                    Console.WriteLine("Seu reultado é: "+ total);
                }
                else if (resul == "-")
                {
                    int numero1 = p.desempilhar();
                    int numero2 = p.desempilhar();
                    total = numero2 - numero1;
                    p.empilhar(total);
                    Console.WriteLine("Seu reultado é: " + total);
                }
                else if (resul == "*")
                {
                    int numero1 = p.desempilhar();
                    int numero2 = p.desempilhar();
                    total = numero1 * numero2;
                    p.empilhar(total);
                    Console.WriteLine("Seu reultado é: " + total);
                }
                else if (resul == "/")
                {
                    int numero1 = p.desempilhar();
                    int numero2 = p.desempilhar();
                    total = numero2 / numero1;
                    p.empilhar(total);
                    Console.WriteLine("Seu reultado é: " + total);
                }
                else if (resul == "")
                {

                    Console.WriteLine("ERRO!! Você digitou um numero vazio");
                }
                else
                {
                    p.empilhar(Convert.ToInt32(resul));
                }

                Console.Write("Insira um N° ou um Operador (aperte 's' para sair): ");
                resul = Console.ReadLine();
            }


        }
    }
}
