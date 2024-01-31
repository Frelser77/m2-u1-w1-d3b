using System;

namespace RicercaNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti nomi vuoi inserire? ");
            int numeroNomi = Convert.ToInt32(Console.ReadLine());// imposto dimensione array dall'imput utente

            // Creo array
            string[] nomi = new string[numeroNomi];

            // Carichiamo l'array con i nomi
            for (int i = 0; i < nomi.Length; i++)
            {
                Console.Write($"Inserisci il nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            Console.Write("Inserisci il nome da ricercare: ");
            string nomeDaCercare = Console.ReadLine();

            // Controllo nome nell'array
            bool nomeTrovato = false;

            // Ciclo array per ricerca nome
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaCercare))
                {
                    nomeTrovato = true;
                    break;
                }
            }

            if (nomeTrovato)
            {
                Console.WriteLine($"Il nome '{nomeDaCercare}' è presente nell'array.");
            }
            else
            {
                Console.WriteLine($"Il nome '{nomeDaCercare}' NON è presente nell'array.");
            }

            Console.ReadLine();
        }
    }
}
