﻿using System;

namespace Info.Krumnow.Beihilfe.Infrastruktur.Daten
{
    public class Rechnung
    {
        Identity ID { get; set; }
        string Verursacher { get; set; }
        DateTime ErstellDatum { get; set; }
        decimal Betrag { get; set; }
    }
}