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

public class UIElementCollection : UICollection<UIElement> {
  internal new static UIElementCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new UIElementCollection(cPtr, cMemoryOwn);
  }

  internal UIElementCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(UIElementCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected UIElementCollection() {
  }

  public UIElementCollection(UIElement visualParent, FrameworkElement logicalParent) : this(NoesisGUI_PINVOKE.new_UIElementCollection(UIElement.getCPtr(visualParent), FrameworkElement.getCPtr(logicalParent)), true) {
  }

}

}
