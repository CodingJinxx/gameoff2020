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

public class GridViewColumn : Animatable {
  internal new static GridViewColumn CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GridViewColumn(cPtr, cMemoryOwn);
  }

  internal GridViewColumn(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GridViewColumn obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GridViewColumn() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_GridViewColumn();
  }

  public static DependencyProperty CellTemplateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_CellTemplateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CellTemplateSelectorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_CellTemplateSelectorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderContainerStyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderContainerStyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderStringFormatProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderStringFormatProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderTemplateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderTemplateSelectorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplateSelectorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty WidthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_WidthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float ActualWidth {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_ActualWidth_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.GridViewColumn_ActualWidth_get(swigCPtr);
      return ret;
    } 
  }

  public DataTemplate CellTemplate {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_CellTemplate_set(swigCPtr, DataTemplate.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_CellTemplate_get(swigCPtr);
      return (DataTemplate)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplateSelector CellTemplateSelector {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_CellTemplateSelector_set(swigCPtr, DataTemplateSelector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_CellTemplateSelector_get(swigCPtr);
      return (DataTemplateSelector)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public BindingExpressionBase DisplayMemberBinding {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_DisplayMemberBinding_set(swigCPtr, BindingExpressionBase.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_DisplayMemberBinding_get(swigCPtr);
      BindingExpressionBase ret = (cPtr == IntPtr.Zero) ? null : new BindingExpressionBase(cPtr, false);
      return ret;
    } 
  }

  public object Header {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_Header_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_Header_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Style HeaderContainerStyle {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_HeaderContainerStyle_set(swigCPtr, Style.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderContainerStyle_get(swigCPtr);
      return (Style)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string HeaderStringFormat {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_HeaderStringFormat_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderStringFormat_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public DataTemplate HeaderTemplate {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplate_set(swigCPtr, DataTemplate.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplate_get(swigCPtr);
      return (DataTemplate)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplateSelector HeaderTemplateSelector {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplateSelector_set(swigCPtr, DataTemplateSelector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumn_HeaderTemplateSelector_get(swigCPtr);
      return (DataTemplateSelector)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float Width {
    set {
      NoesisGUI_PINVOKE.GridViewColumn_Width_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.GridViewColumn_Width_get(swigCPtr);
      return ret;
    } 
  }

}

}

