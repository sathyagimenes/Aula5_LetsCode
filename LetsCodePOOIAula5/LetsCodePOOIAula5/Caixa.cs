using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCodePOOIAula5
{
    public class Caixa
    {
        public DateTime DataCaixa { get; private set; } 
        public decimal Saldo { get; private set; }
        public void AbrirCaixa(decimal saldoInicial = 0)
        {
            DataCaixa = DateTime.Now;
            Saldo = saldoInicial;
        }
        public void Deposita(decimal valor)
        {
            Saldo += valor;
        }
        public void Saca(decimal valor)
        {
            if (Saldo >= valor)
                Saldo -= valor;
            else
                Console.WriteLine($"Saldo insuficiente. Saldo atual: R${Saldo}");
        }
        //public decimal ObterSaldo()
        //{
            //return Saldo;
        //}

        //Solução referente ao exercício proposto em sala de aula
        public decimal CalcularTroco(decimal valorVenda, decimal dinheiroRecebido)
        {
            if (Validacao(valorVenda, dinheiroRecebido))    
                return dinheiroRecebido - valorVenda;
            return -1;
        }
        public void DevolverTroco(decimal valorVenda, decimal dinheiroRecebido)
        {
            Saldo += dinheiroRecebido;
            Saldo -= (dinheiroRecebido - valorVenda);
            Console.WriteLine($"O saldo atual é: {Saldo}");
        }
        public bool Validacao(decimal valorVenda, decimal dinheiroRecebido)
        {
            if (valorVenda <= 0)
            {
                Console.WriteLine("O valor do produto é inválido.");
                return false;
            }
            else if (dinheiroRecebido <= 0)
            {
                Console.WriteLine("O valor entregue pelo cliente é inválido.");
                return false;
            }
            else if (valorVenda > dinheiroRecebido)
            {
                Console.WriteLine("Valor entregue pelo cliente é insuficiente. O cliente deve entregar um valor maior");
                return false;
            }
            return true;
        }
    }
}
