using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somodoisnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numb1=0;
            Double numb2=0;
            Double soma=0;
            string pergunta="";
            Console.WriteLine("Digite  primeiro numero ");
            pergunta = Console.ReadLine();
            numb1 = Convert.ToDouble(pergunta);

            Console.WriteLine("Digite  segundo numero ");
            pergunta = Console.ReadLine();
            numb2 = Convert.ToDouble(pergunta);

            soma = numb1 + numb2;
            Console.WriteLine($"A soma do numero {numb1} + {numb2} é ={soma}");
            Console.ReadKey();        
        }
    }
}
