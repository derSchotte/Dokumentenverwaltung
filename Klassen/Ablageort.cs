namespace Dokumentenverwaltung.Klassen {
    // Entwickeln Sie eine Klasse für den Ablageort mit folgenden
    // Informationen:
    // Stockwerk, Raumnummer, Regalnummer, Fach

    internal class Ablageort {
        int stockwerk;
        int raumNummer;
        int regalNummer;
        int fach;

        public Ablageort( int stockwerk, int raumNummer, int regalNummer, int fach ) {
            this.stockwerk = stockwerk;
            this.raumNummer = raumNummer;
            this.regalNummer = regalNummer;
            this.fach = fach;
        }

        public void Ausgabe() {
            Console.WriteLine( $"Stockwerk: {stockwerk}\n" +
                $"RaumNr: {raumNummer}\n" +
                $"RegalNr: {regalNummer}\n" +
                $"Fach: {fach}" );
        }
    }
}
