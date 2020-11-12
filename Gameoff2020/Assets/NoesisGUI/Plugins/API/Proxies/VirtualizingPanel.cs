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

public class VirtualizingPanel : Panel {
  internal new static VirtualizingPanel CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VirtualizingPanel(cPtr, cMemoryOwn);
  }

  internal VirtualizingPanel(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VirtualizingPanel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected VirtualizingPanel() {
  }

  public Noesis.IItemContainerGenerator ItemContainerGenerator {
    get {
      return (Noesis.IItemContainerGenerator)GetGeneratorHelper();
    }
  }

  public void BringIndexIntoViewPublic(int index) {
    BringIndexIntoView(index);
  }

  protected virtual void BringIndexIntoView(int index) {
  }

  public static VirtualizationCacheLength GetCacheLength(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      IntPtr ret = NoesisGUI_PINVOKE.VirtualizingPanel_GetCacheLength(DependencyObject.getCPtr(element));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<VirtualizationCacheLength>(ret);
      }
      else {
        return new VirtualizationCacheLength();
      }
    }
  }

  public static void SetCacheLength(DependencyObject element, VirtualizationCacheLength len) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetCacheLength(DependencyObject.getCPtr(element), ref len);
    }
  }

  public static VirtualizationCacheLengthUnit GetCacheLengthUnit(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      VirtualizationCacheLengthUnit ret = (VirtualizationCacheLengthUnit)NoesisGUI_PINVOKE.VirtualizingPanel_GetCacheLengthUnit(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetCacheLengthUnit(DependencyObject element, VirtualizationCacheLengthUnit unit) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetCacheLengthUnit(DependencyObject.getCPtr(element), (int)unit);
    }
  }

  public static bool GetIsContainerVirtualizable(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      bool ret = NoesisGUI_PINVOKE.VirtualizingPanel_GetIsContainerVirtualizable(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetIsContainerVirtualizable(DependencyObject element, bool isVirtualizable) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetIsContainerVirtualizable(DependencyObject.getCPtr(element), isVirtualizable);
    }
  }

  public static bool GetIsVirtualizing(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      bool ret = NoesisGUI_PINVOKE.VirtualizingPanel_GetIsVirtualizing(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetIsVirtualizing(DependencyObject element, bool isVirtualizing) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetIsVirtualizing(DependencyObject.getCPtr(element), isVirtualizing);
    }
  }

  public static ScrollUnit GetScrollUnit(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      ScrollUnit ret = (ScrollUnit)NoesisGUI_PINVOKE.VirtualizingPanel_GetScrollUnit(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetScrollUnit(DependencyObject element, ScrollUnit unit) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetScrollUnit(DependencyObject.getCPtr(element), (int)unit);
    }
  }

  public static VirtualizationMode GetVirtualizationMode(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      VirtualizationMode ret = (VirtualizationMode)NoesisGUI_PINVOKE.VirtualizingPanel_GetVirtualizationMode(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetVirtualizationMode(DependencyObject element, VirtualizationMode mode) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.VirtualizingPanel_SetVirtualizationMode(DependencyObject.getCPtr(element), (int)mode);
    }
  }

  public static DependencyProperty CacheLengthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_CacheLengthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CacheLengthUnitProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_CacheLengthUnitProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsContainerVirtualizableProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_IsContainerVirtualizableProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsVirtualizingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_IsVirtualizingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ScrollUnitProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_ScrollUnitProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty VirtualizationModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_VirtualizationModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private object GetGeneratorHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingPanel_GetGeneratorHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

