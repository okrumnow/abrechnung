using System.ComponentModel;
using Info.Krumnow.Beihilfe.Rechnung.Properties;

namespace Info.Krumnow.Beihilfe.Rechnung
{
    public class DetailsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
