using ProjetoEncapisulamentol;

class program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria(1000);
        conta.Depositar(500);
        conta.Sacar(200);
        Console.ReadLine();

    }

}