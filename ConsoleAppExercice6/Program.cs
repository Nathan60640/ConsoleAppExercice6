namespace ConsoleAppExercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un montant en euros (nombre entier) : ");
            int montant = int.Parse(Console.ReadLine());

            if (montant < 0)
            {
                Console.WriteLine("Le montant doit être positif ou nul.");
                return;
            }

            int[] valeurs = { 100, 50, 20, 10, 5, 2, 1 };
            int reste = montant;
            int i = 0;

            Console.WriteLine($"Montant : {montant} €");

            do
            {
                int nombre = reste / valeurs[i]; 
                reste = reste % valeurs[i];      

                if (nombre > 0)
                {
                    string type = valeurs[i] >= 5 ? "billet(s)" : "pièce(s)";
                    Console.WriteLine($"{nombre} {type} de {valeurs[i]} €");
                }

                i++;
            } while (reste > 0);
        }
    }
}
