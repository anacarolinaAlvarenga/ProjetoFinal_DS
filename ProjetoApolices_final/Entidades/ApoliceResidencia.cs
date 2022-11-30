using System;
using System.Globalization;
using System.Text;

namespace ProjetoApolices_final.Entidades
{
    class ApoliceResidencia : Apolice
    {
        public string Endereco { get;  set; }
        public int Cep { get;  set; }
        public string Bairro { get;  set; }
        public string Municipio { get;  set; }
        public string Cidade { get;  set; }
        public string Uf { get;  set; }

        public ApoliceResidencia()
        {

        }

        public ApoliceResidencia(string endereco, int cep, string bairro, string municipio, string cidade, string uf)
        {
            Endereco = endereco;
            Cep = cep;
            Bairro = bairro;
            Municipio = municipio;
            Cidade = cidade;
            Uf = uf;
        }

        public double calcularParcelamento()
        {
            System.Console.WriteLine("Numero de parcelas (entre 1 e 10): ");
            int parcelas = int.Parse(Console.ReadLine());

            double valorParcela = 0;

            ValorApolice = ValorBem * 0.01;

            if (parcelas > 1 && parcelas < 10)
            {
                valorParcela = ValorApolice / parcelas;
                Console.WriteLine("Valor parcela: {0}", valorParcela);
            }

            

            Console.WriteLine("Apólice residencial: {0}", ValorApolice);
            Console.ReadLine();
            return valorParcela;
        }

    }
}
