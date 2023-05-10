using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Player_Investigator_UI.Core
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));  
        }
            
    }
}
