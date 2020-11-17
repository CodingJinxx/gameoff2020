using Shared.Interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Shared.Classes.Models
{
    public class ButtonMenuModelBase : ViewModelBase, IButtonModel
    {
        public event EventHandler OnButtonPress;
        public ICommand ButtonPressedCommand { get; set; }
        public bool IsButtonPressed { 
            get => _isButtonPressed; 
            set
            {
                _isButtonPressed = value;
                base.onPropertyChanged(nameof(IsButtonPressed));
            } 
        }
        private bool _isButtonPressed;

        public ButtonMenuModelBase()
        {
            ButtonPressedCommand = new DelegateCommand((args) => { IsButtonPressed = !IsButtonPressed; OnButtonPress?.Invoke(this, EventArgs.Empty); });
        }
    }
}
