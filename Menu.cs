namespace Dokumentenverwaltung {
    // Erstellen Sie ein Menü, mit dem der Anwender das Dokument
    // anhand seiner Nummer wählen kann und dann alle relevanten
    // Informationen angezeigt bekommt.

    internal class Menu {
        public static void MainMenu() {
            int eingabe;

            Console.WriteLine( "Welches Dokument wollen sie sich anschauen?" );
            Console.WriteLine( "[1]Finanzen, [2]Mitarbeiter, [3]Ware, [4]Filialen, [5]Werbung" );
            eingabe = int.Parse( Console.ReadLine() );

            switch( eingabe ) {
                case 1:
                Dokumente.Finanzen.Ausgabe();
                break;
                case 2:
                Dokumente.Mitarbeiter.Ausgabe();
                break;
                case 3:
                Dokumente.Ware.Ausgabe();
                break;
                case 4:
                Dokumente.Filialen.Ausgabe();
                break;
                case 5:
                Dokumente.Werbung.Ausgabe();
                break;
            }
        }
    }
}
