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

public class Binding : BindingBase {
  internal new static Binding CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Binding(cPtr, cMemoryOwn);
  }

  internal Binding(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Binding obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public object ProvideValue(object targetObject, DependencyProperty targetProperty) {
    IntPtr cPtr = ProvideValueHelper(targetObject, targetProperty);
    return Noesis.Extend.GetProxy(cPtr, true);
  }

  public static object DoNothing {
    get {
      return GetDoNothing();
    }
  }

  public Noesis.IValueConverter Converter {
    get {
      return GetConverterHelper() as Noesis.IValueConverter;
    }
    set {
      SetConverterHelper(value);
    }
  }

  public Binding() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Binding__SWIG_0();
  }

  public Binding(string path) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_1(path != null ? path : string.Empty), true) {
  }

  public Binding(DependencyProperty path) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_2(DependencyProperty.getCPtr(path)), true) {
  }

  public Binding(string path, object source) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_3(path != null ? path : string.Empty, Noesis.Extend.GetInstanceHandle(source)), true) {
  }

  public Binding(DependencyProperty path, object source) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_4(DependencyProperty.getCPtr(path), Noesis.Extend.GetInstanceHandle(source)), true) {
  }

  public Binding(string path, string elementName) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_5(path != null ? path : string.Empty, elementName != null ? elementName : string.Empty), true) {
  }

  public Binding(DependencyProperty path, string elementName) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_6(DependencyProperty.getCPtr(path), elementName != null ? elementName : string.Empty), true) {
  }

  public Binding(string path, RelativeSource relativeSource) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_7(path != null ? path : string.Empty, RelativeSource.getCPtr(relativeSource)), true) {
  }

  public Binding(DependencyProperty path, RelativeSource relativeSource) : this(NoesisGUI_PINVOKE.new_Binding__SWIG_8(DependencyProperty.getCPtr(path), RelativeSource.getCPtr(relativeSource)), true) {
  }

  private static object GetDoNothing() {
    IntPtr cPtr = NoesisGUI_PINVOKE.Binding_GetDoNothing();
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public string ElementName {
    set {
      NoesisGUI_PINVOKE.Binding_ElementName_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.Binding_ElementName_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public object Source {
    set {
      NoesisGUI_PINVOKE.Binding_Source_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Binding_Source_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public RelativeSource RelativeSource {
    set {
      NoesisGUI_PINVOKE.Binding_RelativeSource_set(swigCPtr, RelativeSource.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Binding_RelativeSource_get(swigCPtr);
      return (RelativeSource)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PropertyPath Path {
    set {
      NoesisGUI_PINVOKE.Binding_Path_set(swigCPtr, PropertyPath.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Binding_Path_get(swigCPtr);
      return (PropertyPath)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public BindingMode Mode {
    set {
      NoesisGUI_PINVOKE.Binding_Mode_set(swigCPtr, (int)value);
    } 
    get {
      BindingMode ret = (BindingMode)NoesisGUI_PINVOKE.Binding_Mode_get(swigCPtr);
      return ret;
    } 
  }

  public object ConverterParameter {
    set {
      NoesisGUI_PINVOKE.Binding_ConverterParameter_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Binding_ConverterParameter_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public UpdateSourceTrigger UpdateSourceTrigger {
    set {
      NoesisGUI_PINVOKE.Binding_UpdateSourceTrigger_set(swigCPtr, (int)value);
    } 
    get {
      UpdateSourceTrigger ret = (UpdateSourceTrigger)NoesisGUI_PINVOKE.Binding_UpdateSourceTrigger_get(swigCPtr);
      return ret;
    } 
  }

  private IntPtr ProvideValueHelper(object targetObject, DependencyProperty targetProperty) {
    IntPtr ret = NoesisGUI_PINVOKE.Binding_ProvideValueHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(targetObject), DependencyProperty.getCPtr(targetProperty));
    return ret;
  }

  private object GetConverterHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.Binding_GetConverterHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private void SetConverterHelper(object converter) {
    NoesisGUI_PINVOKE.Binding_SetConverterHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(converter));
  }

}

}

