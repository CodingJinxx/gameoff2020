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

public class Int32KeyFrame : Freezable {
  internal new static Int32KeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Int32KeyFrame(cPtr, cMemoryOwn);
  }

  internal Int32KeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Int32KeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Int32KeyFrame() {
  }

  public static DependencyProperty KeyTimeProperty {
    get {
      return NoesisGUI_.KeyFrame_KeyTimeProperty();
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int32KeyFrame_ValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyTime KeyTime {
    set {
      NoesisGUI_PINVOKE.Int32KeyFrame_KeyTime_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Int32KeyFrame_KeyTime_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<KeyTime>(ret);
      }
      else {
        return new KeyTime();
      }
    }

  }

  public int Value {
    set {
      NoesisGUI_PINVOKE.Int32KeyFrame_Value_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.Int32KeyFrame_Value_get(swigCPtr);
      return ret;
    } 
  }

}

}
