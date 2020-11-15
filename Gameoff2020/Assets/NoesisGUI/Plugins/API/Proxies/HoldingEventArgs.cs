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

public class HoldingEventArgs : TouchEventArgs {
  private HandleRef swigCPtr;

  internal HoldingEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HoldingEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HoldingEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_HoldingEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    HoldingEventHandler handler_ = (HoldingEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new HoldingEventArgs(args, false));
    }
  }

  public HoldingState HoldingState {
    get {
      HoldingState ret = (HoldingState)NoesisGUI_PINVOKE.HoldingEventArgs_HoldingState_get(swigCPtr);
      return ret;
    } 
  }

  public HoldingEventArgs(object source, RoutedEvent arg1, Point p, ulong device, HoldingState holdingState) : this(NoesisGUI_PINVOKE.new_HoldingEventArgs(Noesis.Extend.GetInstanceHandle(source), RoutedEvent.getCPtr(arg1), ref p, device, (int)holdingState), true) {
  }

}

}

