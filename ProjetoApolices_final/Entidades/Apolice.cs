using System;
using System.Globalization;
using System.Text;

namespace ProjetoApolices_final.Entidades
{
    class Apolice
    {
        public int Numero { get;  set; }
        public int CodSeguradora { get;  set; }
        public double Data { get;  set; }
        public float ValorPremio { get;  set; }
        public double ValorBem { get;  set; }
        public double ValorApolice { get;  set; }

        public Apolice()
        {
        }

        public Apolice(int numero, int codSeguradora, double data, float valorPremio, double valorBem, double valorApolice)
        {
            Numero = Numero;
            CodSeguradora = codSeguradora;
            Data = data;
            ValorPremio = valorPremio;
            ValorBem = valorBem;
            ValorApolice = valorApolice;
        }

        public double calcularParcelamento()
        {
            return calcularParcelamento();
        }
    }
}
