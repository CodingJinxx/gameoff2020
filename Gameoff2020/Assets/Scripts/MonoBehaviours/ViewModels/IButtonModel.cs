using System.Windows.Input;

namespace MonoBehaviours.ViewModels
{
    public interface IButtonModel
    {
        ICommand ButtonPressCommand { get; set; }
        bool IsButtonPressed { get; set; }
    }
}