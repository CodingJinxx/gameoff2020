using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ViewModelBase : MonoBehaviour, INotifyPropertyChanged
{
    
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected void onPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

