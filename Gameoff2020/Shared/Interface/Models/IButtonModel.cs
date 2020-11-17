using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shared.Interface.Models
{
    public interface IButtonModel
    {
        ICommand ButtonPressedCommand { get; set; }
        bool IsButtonPressed { get; set; }
    }
}
