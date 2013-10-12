using System;

namespace Info.Krumnow.Beihilfe.Infrastruktur.Daten
{
    public class Rechnung
    {
        public int ID { get; set; }
        public string Verursacher { get; set; }
        public DateTime ErstellDatum { get; set; }
        public decimal Betrag { get; set; }
    }
}