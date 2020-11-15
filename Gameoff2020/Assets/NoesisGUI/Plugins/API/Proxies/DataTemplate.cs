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

public class DataTemplate : FrameworkTemplate {
  internal new static DataTemplate CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new DataTemplate(cPtr, cMemoryOwn);
  }

  internal DataTemplate(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(DataTemplate obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public DataTemplate() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_DataTemplate();
  }

  public Type DataType {
    set {
      NoesisGUI_PINVOKE.DataTemplate_DataType_set(swigCPtr, value != null ? Noesis.Extend.EnsureNativeType(value) : IntPtr.Zero);
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DataTemplate_DataType_get(swigCPtr);
      if (cPtr != IntPtr.Zero) {
        Noesis.Extend.NativeTypeInfo info = Noesis.Extend.GetNativeTypeInfo(cPtr);
        return info.Type;
      }
      return null;
    }
  }

  public TriggerCollection Triggers {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DataTemplate_Triggers_get(swigCPtr);
      return (TriggerCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

