using Finan;
using System;

Console.WriteLine("Informe o valor inicial do veículo: ");
var valorVeiculoStr = Console.ReadLine();
            

Console.WriteLine("Informe a quantidade de parcelas: ");
var quantidadeParcelasStr = Console.ReadLine();

Console.WriteLine("Informe a taxa mensal: (em %) ");
var taxaMensalStr = Console.ReadLine();

double resultado;
            
if (double.TryParse(valorVeiculoStr, out double valorVeiculo) && int.TryParse(quantidadeParcelasStr, out int quantidadeParcelas) && double.TryParse(taxaMensalStr, out double taxaMensal))
{
    Financiamento finan;
    finan = new Financiamento();
    resultado = finan.Calc(valorVeiculo, quantidadeParcelas, taxaMensal);
    double valorTotal = resultado * quantidadeParcelas;
    Console.WriteLine($"O valor de cada parcela é: {resultado:C} o valor total do veículo é: {valorTotal:C}");

}
else
{
    Console.WriteLine($"Os valores são inválidos.");
}
        
