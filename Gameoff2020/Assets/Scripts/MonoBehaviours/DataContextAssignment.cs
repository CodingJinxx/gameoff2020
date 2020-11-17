using System.Collections;
using System.Collections.Generic;
using MonoBehaviours;
using Shared.Classes;
using UnityEngine;

[RequireComponent(typeof(NoesisView))]
public class DataContextAssignment<T> : MonoBehaviour where T : ViewModelBase, new()
{
    protected ViewModelInstance<T> instance;
    private NoesisView view;

    protected void Start()
    {
        this.view = GetComponent<NoesisView>();
        view.Content.DataContext = instance.Instance;
    }
}
