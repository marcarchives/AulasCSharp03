
namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 29;
            string nomeCompleto = "Marcos César";

            var variavelSemTipo = "Marcos";

            Console.WriteLine(variavelSemTipo.GetType());

            Console.WriteLine("Digite seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string idadeUsuario = Console.ReadLine();

            Console.WriteLine($"Meu nome é {nomeUsuario} e a minha idade é {idadeUsuario}");
        }
    }
}
