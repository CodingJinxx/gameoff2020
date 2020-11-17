using MonoBehaviours.ViewModels;
using Shared.Classes.Models;
using UnityEngine;

namespace MonoBehaviours.DataContextAssignments
{
    [RequireComponent(typeof(NoesisView))]
    public class ButtonMenuDTA : DataContextAssignment<ButtonMenuModelBase>
    {
        [SerializeField]
        private ButtonMenuVM vm;
        
        private new void Start()
        {
            base.instance = vm;
            base.Start();
        }
    }
}