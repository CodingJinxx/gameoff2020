#if UNITY_5_3_OR_NEWER
using Noesis;
#else
using System;
using System.ComponentModel;
#endif

using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Menu
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ICommand StartButton { get; set; }
        public ICommand OptionsButton { get; set; }
        public ICommand ExitButton { get; set; }

        public string DebugText
        {
            get => _debugText;
            set
            {
                _debugText = value;
                onPropertyRaisedEvent("DebugText");
            }
        }

        private string _debugText;

        public ViewModel()
        {
            StartButton = new DelegateCommand((i) => { execStartButton(); } );
            OptionsButton = new DelegateCommand((i) => { execOptionsButton(); });
            ExitButton = new DelegateCommand((i) => { execExitButton(); });
        }

        private void execStartButton()
        {
            Console.WriteLine("Start Pressed");
            DebugText = "Start executed";
        }

        private void execOptionsButton()
        {
            DebugText = "Options executed";
        }

        private void execExitButton()
        {
            DebugText = "Exit executed";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyRaisedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
