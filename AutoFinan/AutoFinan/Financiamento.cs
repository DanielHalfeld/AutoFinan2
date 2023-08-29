using System;

namespace Finan
{
    public class Financiamento
    {

        double valorParcela;

        public double Calc(double valorVeiculo, double quantidadeParcelas, double taxaMensal)
        {
            taxaMensal = taxaMensal / 100;
            if (taxaMensal == 0)
            {
                valorParcela = (valorVeiculo/quantidadeParcelas) + 100; // Exemplo: taxa administrativa de 100
            }
            else
            {
                double prestacao = valorVeiculo / quantidadeParcelas;
                valorParcela = (1 - Math.Pow(1 + taxaMensal, -quantidadeParcelas)) / taxaMensal * prestacao;
            }

            return valorParcela;
        }
    }
}
