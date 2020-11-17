using System;
using UnityEngine;
using Shared.Classes;

namespace MonoBehaviours
{
    public abstract class ViewModelInstance<T> : MonoBehaviour where T : ViewModelBase, new()
    {
        private T _instance;
        public T Instance => _instance;

        private void Awake()
        {
            _instance = new T();
        }
    }
}