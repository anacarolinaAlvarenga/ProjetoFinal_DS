using System;
using System.Globalization;
using System.Text;


namespace ProjetoApolices_final.Entidades
{
    class ApoliceCarro : Apolice
    {
        public string Marca { get;  set; }
        public string Modelo { get;  set; }
        public string Placa { get;  set; }
        public string Renavam { get;  set; }
        public int AnoFabricacao { get;  set; }
        public long Quilometragem { get;  set; }
        public long NumeroVistoria { get;  set; }
        public double DataVistoria { get;  set; }

        public ApoliceCarro()
        {

        }

        public ApoliceCarro(string marca, string modelo, string placa, string renavam, int anoFabricacao, long quilometragem, long numeroVistoria, double dataVistoria)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Renavam = renavam;
            AnoFabricacao = anoFabricacao;
            Quilometragem = quilometragem;
            NumeroVistoria = numeroVistoria;
            DataVistoria = dataVistoria;
        }

        public double calcularParcelamento()
        {
            Console.WriteLine("Numero de parcelas (entre 1 e 10): ");
            int parcelas = int.Parse(Console.ReadLine());

            double valorParcela = 0;

            ValorApolice = ValorBem * 0.05;

            if (parcelas >= 1 && parcelas <= 10)
            {
                valorParcela = ValorApolice / parcelas;
                Console.WriteLine("Valor parcela: {0}", valorParcela);
            }
           
        
           Console.WriteLine("Apólice carro: {0}", ValorApolice);
            Console.ReadLine();
            return valorParcela;

        }

    }
}
