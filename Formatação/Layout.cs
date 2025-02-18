namespace Layout
{
    public class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()
        {
            Cor("========================", ConsoleColor.Cyan);
            Cor("   GERENCIADOR DE TAREFAS   ", ConsoleColor.Green);
            Cor("========================", ConsoleColor.Cyan);
        }
    }
}
