using System;

namespace FormatCpf
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpfNumerico = "52695148520";
            Console.WriteLine("Cpf somente números: " + cpfNumerico);

            string cpf = cpfNumerico.Substring(0, 3) + ".";
            cpf += cpfNumerico.Substring(3, 3) + ".";
            cpf += cpfNumerico.Substring(6, 3) + "-";
            cpf += cpfNumerico.Substring(9, 2);

            Console.WriteLine(cpf);

        }
    }
}
