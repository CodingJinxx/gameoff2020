using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;
using MonoBehaviours;
using MonoBehaviours.ViewModels;
using Shared.Classes;
using Shared.Classes.Models;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationTest : MonoBehaviour
{
    [SerializeField] private ButtonMenuVM vm;

    private Animator anim;
    private bool buttonPressed;
    private Timer timer;
    private float time;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        vm.Instance.OnButtonPress += (o, e) => buttonPressedCallback();
    }

    private void buttonPressedCallback()
    {
        anim.SetBool("isPressed", vm.Instance.IsButtonPressed);
    }
}
