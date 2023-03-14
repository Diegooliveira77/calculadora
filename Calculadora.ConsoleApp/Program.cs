namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();

                Console.WriteLine("Calculadora da Academia do Programador");

                Console.WriteLine("Digite 1 para Adicionar ");

                Console.WriteLine("Digite 2 para Subtrair ");

                Console.WriteLine("digite 3 para Mutiplicar ");

                Console.WriteLine("digite 4 para Dividir ");

                Console.WriteLine("digite 5 para Gerar Tabuada ");

                Console.WriteLine("digitar S para sair");

                string operacao = Console.ReadLine();
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operaçao inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }
                if (operacao == "5")

                {
                    Console.Write("digite o primeiro numero para gerar a tabuada: ");

                int tabuada = Convert.ToInt32 (Console.ReadLine());

                int numero = 1;

                while ( numero < - 10 )
                {
                    int resultadoMultiplicacao = tabuada * numero;

                    Console.WriteLine( tabuada + " x " + numero +  " = " +  resultadoMultiplicacao );



                    numero = numero + 1;

                }



                Console.ReadLine();
                    continue;

                if (operacao == "S" || operacao == "s")


                {
                    break;
                }

                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtracao = operacao == "2";
                bool ehMutiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";
                  bool ehTabuada = operacao == "5";

                    if (ehAdicao)
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (ehSubtracao)
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (ehMutiplicacao)
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (ehDivisao)
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("segundo número nao pode ser Zero");
                        Console.ReadLine();
                        Console.WriteLine("digite novamente o Segundo numero");
                        resultado = primeiroNumero / segundoNumero;

                    }

                    resultado = primeiroNumero / segundoNumero;


                }
                decimal resultadoformatado = Math.Round(resultado, 2);

                Console.WriteLine("o resultado da operação é: " + resultadoformatado);

                Console.ReadLine();

            } while (true);









        }
}
}