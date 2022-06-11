namespace LetsCodePOOIAula5
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

            //caixaDoDia.Deposita(50);
            //Console.WriteLine(caixaDoDia.ObterSaldo());

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
                Console.WriteLine("Qual o valor entregue pelo cliente?");
                decimal dinheiroRecebido = decimal.Parse(Console.ReadLine());
                while (!caixaDoDia.Validacao(valorProduto, dinheiroRecebido))
                {
                    Console.WriteLine("Qual o valor do produto?");
                    valorProduto = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor dado pelo cliente?");
                    dinheiroRecebido = decimal.Parse(Console.ReadLine());
                }
                decimal troco = caixaDoDia.CalcularTroco(valorProduto, dinheiroRecebido);
                Console.WriteLine($"O troco do cliente é: {troco}");
                caixaDoDia.DevolverTroco(valorProduto, dinheiroRecebido);
                Console.WriteLine("Deseja registrar outra compra? (s/n)");
                registroDeCompra = Console.ReadLine();
                while (registroDeCompra != "s" && registroDeCompra != "n")
                {
                    Console.WriteLine("Informação inválida. Digite 's' caso deseje registrar outra compra ou, caso contrário, digite 'n'");
                    registroDeCompra = Console.ReadLine();
                }
            }
        }
    }
}