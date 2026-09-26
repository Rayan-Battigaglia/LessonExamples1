public class Program // Questa è una classe
{    
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella Easy Class 3E!");


        Console.WriteLine("Inserisci il nome del cliente:");

        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto  {nomeCliente} nella Easy Class 3E");

        Console.WriteLine("Inserisci il tipo di spedizione:");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi acquistati:");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());


        int costoSpedizioneSingoloPacco = 5; //dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; //assegnazione

        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        // Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine("Il tipo di consegna selezionato è: " + tipoConsegna);
        Console.WriteLine("Il costo totale è: " + costoTotale);
        // $ è il carattere speciale per l'interpolazione di stringhe
        // che permette di inserire variabili all'interno di una stringa
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è {costoTotale}");

    }
}
