using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;
using MonoBehaviours.ViewModels;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationTest : MonoBehaviour
{
    [SerializeField] private ButtonViewModel viewModel;

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
        viewModel.ButtonEvents += (o, e) => buttonPressedCallback();
    }

    private void buttonPressedCallback()
    {
        anim.SetBool("isPressed", viewModel.IsButtonPressed);
    }
}
