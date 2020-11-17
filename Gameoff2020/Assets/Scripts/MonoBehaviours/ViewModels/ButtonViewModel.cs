using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using MonoBehaviours.ViewModels;
using Noesis;
using UnityEditor.VersionControl;
using UnityEngine;
using EventArgs = System.EventArgs;
using EventHandler = System.EventHandler;

public class ButtonViewModel : ViewModelBase, IButtonModel
{

    [SerializeField]
    private NoesisView view;
    public ICommand ButtonPressCommand { get; set; }
    public event EventHandler ButtonEvents;
    public bool IsButtonPressed
    {
        get => isButtonPressed;
        set
        {
            isButtonPressed = value;
            onPropertyChanged(nameof(IsButtonPressed));
        }
    }

    private bool isButtonPressed;

    private void Start()
    {
        ButtonPressCommand = new DelegateCommand((i) => { IsButtonPressed = !IsButtonPressed; ButtonEvents?.Invoke(this, EventArgs.Empty);});
        view.Content.DataContext = this;
    }

    private void Update()
    {

    }
}

