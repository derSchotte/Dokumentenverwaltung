using Dokumentenverwaltung.Klassen;
// Erstellen Sie 5 Dokumente mit allen Feldern

namespace Dokumentenverwaltung {
    internal class Dokumente {
        public static Dokument Finanzen = new(1,new (2022,04,01),
                    new (1, 12,4,2),
                    new ("Georg", "Phishing",25,"Finanzen"),
                    "Finanzen, all das was mit Geld zu tun hat... ausser Kryptowährung.. Teufelszeug");

        public static Dokument Mitarbeiter = new(2, new (2002, 10,23),
            new(1,12,3,12),
            new("Alexander", "Lustlos",22, "Personalabteilung"),
            "Mitarbeiter, Praktikanten, Anwerber naja manchesmal sind es auch nur Werber... YouTube usw... Beklopptes Folk");

        public static Dokument Ware = new(3, new(2012, 05,22),
            new(1,12,6,1),
            new("Ilyass", "Lustig",69, "Lager"),
            "Wareneingang, Warenausgang, Warenumgang, Warenweggang, naja Waren halt.");

        public static Dokument Filialen = new(4,new(2006,06,09),
            new(1,12,1,2),
            new("Dietrich","Sause",27,"Bereichsleitung"),
            "Wo befinden sich den unsere Filialen, Buckstehude, Sandhausen, oder wo!");

        public static Dokument Werbung = new(5, new(2000,01,01),
            new(1,12,12,12),
            new("Frank","Rock",88,"PR"),
            "Alles was mit Werbung zu tun hat, Plagiat, Flyer, Visitenkarte, Internview, Röcke");
    }
}
