/************************************************************
 * NOME: localArguments.cs
 * 
 * In questo file vengono memorizzate le variabili pubbliche
 * che potranno essere richiamate tramite il comando
 * variabili.xxxxx dove xxxxx è il nome della variabile
 * interessata.
 * 
 ************************************************************/

using System;
using System.Windows.Forms;

static class j_locVar
{
    /* Dichiarazione variabili locali GLOBALI (Local Variables); dato che la classe contiene tutte funzioni STATIC, le variabili globali devono essere
       STATIC, o semplicemente costanti (const)
    */
    public static string _nomeProgramma = "RobCellPhones2";
    public static string _versione = "2.0";

    // dati del database usato
    // public static string percorso_database = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\roblist\\db\\";
    public const string db_Name = "RobCellPhones2.db";
    public static string connectionString = "Data Source=" + Application.StartupPath + "\\" + db_Name + ";" + "Version=3;New=False;Compress=True;";
    //public const string fileMessaggi = Application.StartupPath + "\\Documentazione\\messaggisistema.csv"; // quando la APP sarà operativa
    // casa
    //public const string fileMessaggi = "C:\\Users\\jarod67\\Documents\\Programmazione\\C#\\src\\RobCellphones2\\myStd\\messaggisistema.csv";
    // ufficio
    public const string fileMessaggi = "C:\\MaXe\\Programmi\\C#\\src\\RobCellPhones2\\mystd\\messaggisistema.csv";
    public const string cellulari_Name = "cellulari";
    public const string modelli_Name = "modelli";
    public const string siti_Name = "siti";

    // dovrebbe essere dichiarata in un punto in cui decido il linguaggio
    public const int _langDEFAULT = j_Std.genVar._langITA;

    public static string _nomeUtente = "";
}
