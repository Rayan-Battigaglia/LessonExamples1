public class Program // Questa è una classe
{    
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella Easy Class 3E!");

        int costoSpedizioneSingoloPacco = 5; //dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; //assegnazione

        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard"; //dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        // Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine("Il tipo di consegna selezionato è: " + tipoConsegna);
        Console.WriteLine("Il costo totale è: " + costoTotale);
        // $ è il carattere speciale per l'interpolazione di stringhe
        // che permette di inserire variabili all'interno di una stringa
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è {costoTotale}");

    }
}
