﻿using System;

namespace HHBK_Chemicals_ERP_CS
{
    internal interface IModel
    {
        Boolean createDB();

        Boolean createTestData();

        //Kunde
        Boolean KundeAnlegen(int Kundennummer, String Name, String Vorname, String Strasse, int Hausnummer,
            int Postleitzahl, String Ort, String emaliadresse, String password);

        //Produkt
        Boolean ProduktAnlegen(int Artikelnummer, String Artikelname, int Verkaufseinheit,
            String Einheit, Double PreisVK);


        //Bestellposition
        Boolean BestellpositionAnlegen(int Bestellpositionsnummer, int Bestellungsnummer, int Menge,
            DateTime Bestelldatum, int Artikelnummer, int Kundennummer, int idLieferposition);

        //Rechnungspositon
        Boolean RechnungspositionAnlegen(int Rechnungspositionsnummer, int Rechnungsnummer,
            int Bestellpositionsnummer, int Artikelnummer, int Kundennummer);

        //Zahlungseingang
        Boolean ZahlungseingangAnlegen(int Zahlungseingangsnummer, String VerwendungszweckKdNr,
            String VerwendungszweckBestNr, DateTime Datum, String NameKontoinhaber,
            String IBAN, int Kundennummer);

        //Lagerposition
        Boolean LagerpositionAnlegen(int Lagerpositionsnummer, String Grundstoffname,
            int Grundstoffmenge, String Gundstoffeinheit);

        //Rezept
        Boolean RezeptAnlegen(int Rezeptnummer, int HerstellungsdauerMin, int Artikelnummer);

        //Lagerposition_has_Rezept
        Boolean Lagerposition_has_RezeptAnlegen(int Lagerpositionsnummer, int Rezept_Rezeptnummer,
            int Menge, String Einheit);

        //Produktionsposition
        Boolean ProduktionspositionAnlegen(int Produktionspositionsnummer, int Artikelnummer,
            DateTime DatumProduktionsfreigabe, DateTime DatumProduktion, String NameProdkutionsfreigabe,
            String NameProduzent, int Bestellpositionsnummer, int Kundennummer);

        //Produktionsplan
        Boolean ProduktionsplanAnlegen(int Produktionsplannummer, DateTime StartSoll, DateTime StartIst,
            int Rezeptnummer, int Produktionspositionsnummer, int Bestellpositionsnummer, int Kundennummer);
        
        //Lieferposition
        Boolean LieferpositionAnlegen(int idLieferposition, String Liefernummer, DateTime Versanddatum,
            DateTime Lieferdatum, String NameVersandkontrolle, String NameSpedition);




    }
}