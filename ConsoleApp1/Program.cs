namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Zahl eingegen: ");

            string eingabe = Console.ReadLine();

            int zahl = Convert.ToInt32(eingabe);

            int resultat = zahl + 1;

            Console.WriteLine(resultat);
        }



    }
}
