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

public class GridViewRowPresenter : GridViewRowPresenterBase {
  internal new static GridViewRowPresenter CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GridViewRowPresenter(cPtr, cMemoryOwn);
  }

  internal GridViewRowPresenter(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GridViewRowPresenter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GridViewRowPresenter() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_GridViewRowPresenter();
  }

  public static DependencyProperty ContentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewRowPresenter_ContentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public object Content {
    set {
      NoesisGUI_PINVOKE.GridViewRowPresenter_Content_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewRowPresenter_Content_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

