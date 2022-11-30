using ProjetoApolices_final.Entidades;
using System;
using System.Globalization;

namespace ProjetoApolices_final
{
    class Program
    {
        private const string V = "1";

        static void Main(string[] args)
        {
            ApoliceCarro apocarro = new ApoliceCarro();
            ApoliceResidencia apocasa = new ApoliceResidencia();

            apocarro.Marca = "Chevrolet";
            apocarro.Modelo = "Spin";
            apocarro.Placa = "Dfideliz";
            apocarro.Renavam = "777";
            apocarro.AnoFabricacao = 123;
            apocarro.Quilometragem = 345321;
            apocarro.NumeroVistoria = 1234123;
            apocarro.DataVistoria = 12092022;

            apocasa.Endereco = "Rua Jardim Olieira";
            apocasa.Cep = 13333070;
            apocasa.Bairro = "Maria Bueno";
            apocasa.Municipio = "Itu";
            apocasa.Cidade = "São Paulo";
            apocasa.Uf = "Brasilia";

            apocasa.ValorBem = 200000;
            apocarro.ValorBem = 80000;


            System.Console.WriteLine("-----Apólices----");
            System.Console.WriteLine("Carro ou Residência?  (c/r)");
            char ch = char.Parse(Console.ReadLine());

            double valorParcela;

            if (ch == 'c')
            {
                valorParcela = apocarro.calcularParcelamento();
            }
            else if (ch == 'r')
            {
                valorParcela = apocasa.calcularParcelamento();
            }

        }
    }
}
