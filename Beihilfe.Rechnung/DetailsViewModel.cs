using System;
using Microsoft.Practices.Prism.ViewModel;

namespace Info.Krumnow.Beihilfe.Rechnung
{
    public class DetailsViewModel: NotificationObject
    {
        private Infrastruktur.Daten.Rechnung rechnung;

        private string verursacher;
        public string Verursacher
        {
            get { return verursacher; }
            set
            {
                if (value == verursacher) return;
                verursacher = value;
                RaisePropertyChanged(() => Verursacher);
            }
        }

        private decimal betrag;
        public decimal Betrag
        {
            get { return betrag; }
            set
            {
                if (value == betrag) return;
                betrag = value;
                RaisePropertyChanged(() => Betrag);
            }
        }

        private DateTime erstellt;
        public DateTime Erstellt {
            get { return erstellt; }
            set {
                if (value.Equals(erstellt)) return;
                erstellt = value;
                RaisePropertyChanged(() => Erstellt);
            }
        }

        public void ZeigeRechnung(Infrastruktur.Daten.Rechnung r)
        {
            rechnung = r;
            Verursacher = rechnung.Verursacher;
            Betrag = rechnung.Betrag;
            Erstellt = rechnung.ErstellDatum;
        }
    }
}
