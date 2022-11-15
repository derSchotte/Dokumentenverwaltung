namespace Dokumentenverwaltung.Klassen {
    // Entwickeln Sie eine Klasse für den Verantwortlichen mit
    // folgenden Informationen:
    // Name, Büronummer, Abteilung

    internal class Verantwortlichen {
        string vorname;
        string nachname;
        int bueroNummer;
        string abteilung;

        public Verantwortlichen( string vorname, string nachname, int bueroNummer, string abteilung ) {
            this.vorname = vorname;
            this.nachname = nachname;
            this.bueroNummer = bueroNummer;
            this.abteilung = abteilung;
        }

        public void Ausgabe() {
            Console.WriteLine( $"Verantwortliche/r: {vorname} {nachname}\n" +
                $"BüroNr: {bueroNummer}\n" +
                $"Abteilung: {abteilung}" );
        }
    }
}
