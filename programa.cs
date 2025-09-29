class Program
{
    static void Main(string[] args)
    {
        // Criando um cliente
        Cliente cliente1 = new Cliente("João da Silva", "123.456.789-00");

        // Criando uma conta para o cliente
        ContaBancaria conta1 = new ContaBancaria("0001", cliente1);

        // Operações
        conta1.Depositar(1000);
        conta1.Sacar(300);
        conta1.ExibirInformacoes();
    }
}
