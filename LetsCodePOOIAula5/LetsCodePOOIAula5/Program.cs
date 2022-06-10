﻿namespace LetsCodePOOIAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixaDoDia = new Caixa();
            caixaDoDia.AbrirCaixa();

            //Console.WriteLine("Data do dia:" + caixaDoDia.DataCaixa);
            //Console.WriteLine(caixaDoDia.Saldo);

            //caixaDoDia.Deposita(10);
            //Console.WriteLine(caixaDoDia.Saldo);

            //caixaDoDia.Deposita(50);
            //Console.WriteLine(caixaDoDia.Saldo);

            //caixaDoDia.Saca(10);
            //Console.WriteLine(caixaDoDia.Saldo);

            //caixaDoDia.Saca(1000);
            //Console.WriteLine(caixaDoDia.Saldo);
            Console.WriteLine("Deseja registrar uma compra? (s/n)");
            string registroDeCompra = Console.ReadLine();
            while (registroDeCompra != "s" && registroDeCompra != "n")
            {
                Console.WriteLine("Informação inválida. Digite 's' caso deseje registrar outra compra ou, caso contrário, digite 'n'");
                registroDeCompra = Console.ReadLine();
            }
            while (registroDeCompra == "s")
            {
                Console.Clear();
                Console.WriteLine("Qual o valor do produto?");
                decimal valorProduto = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor dado pelo cliente?");
                decimal dinheiroRecebido = decimal.Parse(Console.ReadLine());
                decimal troco = caixaDoDia.CalcularTroco(valorProduto, dinheiroRecebido);
                while (troco < 0)
                {
                    Console.WriteLine("Valor insuficiente. O cliente deve entregar um valor maior");
                    Console.WriteLine("Qual o novo valor dado pelo cliente?");
                    dinheiroRecebido = decimal.Parse(Console.ReadLine());
                    troco = caixaDoDia.CalcularTroco(valorProduto, dinheiroRecebido);
                }
                Console.WriteLine($"O troco do cliente é: {troco}");
                caixaDoDia.DevolverTroco(valorProduto, dinheiroRecebido);
                Console.WriteLine($"O saldo atual é: {caixaDoDia.Saldo}");
                Console.WriteLine("Deseja registrar outra compra? (s/n)");
                registroDeCompra = Console.ReadLine();
                while (registroDeCompra != "s" && registroDeCompra != "n")
                {
                    Console.WriteLine("Informação inválida. Digite 's' caso deseje registrar outra compra ou, caso contrário, digite 'n'");
                    registroDeCompra = Console.ReadLine();
                }
            }
            //caixaDoDia.Deposita(50);
            //Console.WriteLine(caixaDoDia.ObterSaldo());
        }
    }
}