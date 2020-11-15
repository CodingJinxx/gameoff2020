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

public class TemplateBindingExtension : MarkupExtension {
  internal new static TemplateBindingExtension CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TemplateBindingExtension(cPtr, cMemoryOwn);
  }

  internal TemplateBindingExtension(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TemplateBindingExtension obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public object ProvideValue(object targetObject, DependencyProperty targetProperty) {
    IntPtr cPtr = ProvideValueHelper(targetObject, targetProperty);
    return Noesis.Extend.GetProxy(cPtr, true);
  }

  public TemplateBindingExtension() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_TemplateBindingExtension__SWIG_0();
  }

  public TemplateBindingExtension(DependencyProperty dp) : this(NoesisGUI_PINVOKE.new_TemplateBindingExtension__SWIG_1(DependencyProperty.getCPtr(dp)), true) {
  }

  public DependencyProperty Property {
    set {
      NoesisGUI_PINVOKE.TemplateBindingExtension_Property_set(swigCPtr, DependencyProperty.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TemplateBindingExtension_Property_get(swigCPtr);
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private IntPtr ProvideValueHelper(object targetObject, DependencyProperty targetProperty) {
    IntPtr ret = NoesisGUI_PINVOKE.TemplateBindingExtension_ProvideValueHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(targetObject), DependencyProperty.getCPtr(targetProperty));
    return ret;
  }

}

}

