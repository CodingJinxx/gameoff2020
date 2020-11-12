//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class VisualStateGroup : DependencyObject {
  internal new static VisualStateGroup CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VisualStateGroup(cPtr, cMemoryOwn);
  }

  internal VisualStateGroup(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VisualStateGroup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public VisualStateGroup() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_VisualStateGroup();
  }

  public VisualState GetCurrentState(FrameworkElement fe) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateGroup_GetCurrentState(swigCPtr, FrameworkElement.getCPtr(fe));
    return (VisualState)Noesis.Extend.GetProxy(cPtr, false);
  }

  public void SetCurrentState(FrameworkElement fe, VisualState state) {
    NoesisGUI_PINVOKE.VisualStateGroup_SetCurrentState(swigCPtr, FrameworkElement.getCPtr(fe), VisualState.getCPtr(state));
  }

  public VisualState FindState(string name) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateGroup_FindState(swigCPtr, name != null ? name : string.Empty);
    return (VisualState)Noesis.Extend.GetProxy(cPtr, false);
  }

  public VisualTransition FindTransition(VisualState from, VisualState to) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateGroup_FindTransition(swigCPtr, VisualState.getCPtr(from), VisualState.getCPtr(to));
    return (VisualTransition)Noesis.Extend.GetProxy(cPtr, false);
  }

  public void UpdateAnimations(FrameworkElement fe, Storyboard storyboard1, Storyboard storyboard2) {
    NoesisGUI_PINVOKE.VisualStateGroup_UpdateAnimations__SWIG_0(swigCPtr, FrameworkElement.getCPtr(fe), Storyboard.getCPtr(storyboard1), Storyboard.getCPtr(storyboard2));
  }

  public void UpdateAnimations(FrameworkElement fe, Storyboard storyboard1) {
    NoesisGUI_PINVOKE.VisualStateGroup_UpdateAnimations__SWIG_1(swigCPtr, FrameworkElement.getCPtr(fe), Storyboard.getCPtr(storyboard1));
  }

  public string Name {
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.VisualStateGroup_Name_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public VisualStateCollection States {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateGroup_States_get(swigCPtr);
      return (VisualStateCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public VisualTransitionCollection Transitions {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualStateGroup_Transitions_get(swigCPtr);
      return (VisualTransitionCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

