using System;

namespace Beihilfe.Infrastruktur.Daten
{
    public class Vorgang
    {
        Identity ID { get; set; }
        string Verursacher { get; set; }
        DateTime ErstellDatum { get; set; }
        decimal Betrag { get; set; }
    }
}