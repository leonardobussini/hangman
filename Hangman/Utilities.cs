public static class Utilities
{
    private static string[] tutteLeParole = [
        "koala",     //0    
        "auto",      //1
        "casa",      //2
        "bambino",   //3
        "camion",    //4
        "videogioco", 
        "gatto", 
        "mamma"
    ];

    /// <summary>
    /// Sceglie a caso una delle parole predefinite
    /// </summary>
    /// <returns>Ritorna la parola a caso</returns>
    public static string DammiUnaParolaACaso()
    {
        // Usando il secondo dell'ora attuale abbiamo una
        // cifra che possiamo usare come base per un valore casuale
        int questoSecondo = DateTime.Now.Second;

        // Uso la lunghezza dell'array per non dover tutte le 
        // volte dividere sempre per un numero fisso
        int lunghezzaArray = tutteLeParole.Length;

        // Siamo sicuri al 100% che il valore è tra 0 e [lunghezzaArray]
        int numeroCasuale = questoSecondo % lunghezzaArray; 

        // Prendiamo la parola dell'array corrispondente al numero causale
        string parolaACaso = tutteLeParole[numeroCasuale];

        // Ritorniamo la parola a caso
        return parolaACaso;
    }
}