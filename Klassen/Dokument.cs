namespace Dokumentenverwaltung.Klassen {
    internal class Dokument {
        int dokumentenNummer;
        DateOnly erstelltDatum;
        Ablageort ablageOrt;
        Verantwortlichen verantwortlichen;
        string beschreibung;

        public Dokument( int dokumentenNummer, DateOnly erstelltDatum, Ablageort ablageOrt, Verantwortlichen verantwortlichen, string beschreibung ) {
            this.dokumentenNummer = dokumentenNummer;
            this.erstelltDatum = erstelltDatum;
            this.ablageOrt = ablageOrt;
            this.verantwortlichen = verantwortlichen;
            this.beschreibung = beschreibung;
        }

        public void Ausgabe() {
            Console.WriteLine( $"DokumentenNr: {dokumentenNummer}\n" );
            verantwortlichen.Ausgabe();
            Console.WriteLine( $"Erstellt am: {erstelltDatum}\n" );
            ablageOrt.Ausgabe();
            Console.WriteLine( $"\nBeschreibung: {beschreibung}" );
        }
    }
}
