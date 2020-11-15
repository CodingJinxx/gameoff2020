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

public class Run : Inline {
  internal new static Run CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Run(cPtr, cMemoryOwn);
  }

  internal Run(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Run obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Run() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Run__SWIG_0();
  }

  public Run(string text) : this(NoesisGUI_PINVOKE.new_Run__SWIG_1(text != null ? text : string.Empty), true) {
  }

  public static DependencyProperty TextProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Run_TextProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string Text {
    set {
      NoesisGUI_PINVOKE.Run_Text_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.Run_Text_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

}

}

