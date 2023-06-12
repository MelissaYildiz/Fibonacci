using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bitte Gib eine Fibonacci Zahl ein: ");

        // Ich nehme den Input vom Benutzer auf und Speicher sie in einer Variable
        int grenze = int.Parse(Console.ReadLine());

        // Hier tu ich meine Variable deklarieren und initialisieren also ich setze eine Variable ein und gebe ihr ein wert
        int vorherigeZahl = 0;
        int aktuelleZahl = 1; //anfangsbedingung von fibonacci
        int nächsteZahl = 1;  //anfangsbedingung von fibonacci
        int counter = 0;

        // Hier setze ich die While Schleife welche aufhört wenn die grenze erreicht ist bei der beliebigen Zahl
        while (counter < grenze) // das ist die schleife abbruchbedingung 
        {
            // In der While Schleife wird die aktuelle Zahl ausgegeben und dann berechnet
            Console.Write(aktuelleZahl + " ");
            nächsteZahl = vorherigeZahl + aktuelleZahl; // das ist der erste teil von der Fibonacci Zahl
            vorherigeZahl = aktuelleZahl;
            aktuelleZahl = nächsteZahl;
            counter++;
        }
    }
}