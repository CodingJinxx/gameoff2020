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

public class ListView : ListBox {
  internal new static ListView CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ListView(cPtr, cMemoryOwn);
  }

  internal ListView(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ListView obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ListView() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ListView();
  }

  public static DependencyProperty ViewProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ListView_ViewProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public new ViewBase View {
    set {
      NoesisGUI_PINVOKE.ListView_View_set(swigCPtr, ViewBase.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ListView_View_get(swigCPtr);
      return (ViewBase)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

