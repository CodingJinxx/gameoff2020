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

public class Condition : BaseComponent {
  internal new static Condition CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Condition(cPtr, cMemoryOwn);
  }

  internal Condition(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Condition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Condition() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Condition();
  }

  public BindingBase Binding {
    set {
      NoesisGUI_PINVOKE.Condition_Binding_set(swigCPtr, BindingBase.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Condition_Binding_get(swigCPtr);
      return (BindingBase)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DependencyProperty Property {
    set {
      NoesisGUI_PINVOKE.Condition_Property_set(swigCPtr, DependencyProperty.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Condition_Property_get(swigCPtr);
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string SourceName {
    set {
      NoesisGUI_PINVOKE.Condition_SourceName_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.Condition_SourceName_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public object Value {
    set {
      NoesisGUI_PINVOKE.Condition_Value_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Condition_Value_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

