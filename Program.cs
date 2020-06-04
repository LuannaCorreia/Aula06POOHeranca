using System;

namespace Aula6POOPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CPF cpf = new CPF();
            cpf.nome = "Luanna";
            System.Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "000.000.000-00";
            System.Console.WriteLine( cpf.ValidarCPF() );
        }
    }
}
