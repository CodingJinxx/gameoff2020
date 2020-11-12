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

public class KeyboardFocusChangedEventArgs : KeyboardEventArgs {
  private HandleRef swigCPtr;

  internal KeyboardFocusChangedEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(KeyboardFocusChangedEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~KeyboardFocusChangedEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_KeyboardFocusChangedEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    KeyboardFocusChangedEventHandler handler_ = (KeyboardFocusChangedEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new KeyboardFocusChangedEventArgs(args, false));
    }
  }

  public UIElement OldFocus {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.KeyboardFocusChangedEventArgs_OldFocus_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public UIElement NewFocus {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.KeyboardFocusChangedEventArgs_NewFocus_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyboardFocusChangedEventArgs(object source, RoutedEvent arg1, UIElement oldFocus, UIElement newFocus) : this(NoesisGUI_PINVOKE.new_KeyboardFocusChangedEventArgs(Noesis.Extend.GetInstanceHandle(source), RoutedEvent.getCPtr(arg1), UIElement.getCPtr(oldFocus), UIElement.getCPtr(newFocus)), true) {
  }

}

}

