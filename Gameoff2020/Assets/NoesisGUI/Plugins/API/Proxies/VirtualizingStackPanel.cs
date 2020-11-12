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

public class VirtualizingStackPanel : VirtualizingPanel, Noesis.IScrollInfo {
  internal new static VirtualizingStackPanel CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VirtualizingStackPanel(cPtr, cMemoryOwn);
  }

  internal VirtualizingStackPanel(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VirtualizingStackPanel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public VirtualizingStackPanel() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_VirtualizingStackPanel();
  }

  public void LineLeft() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_LineLeft(swigCPtr);
  }

  public void LineRight() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_LineRight(swigCPtr);
  }

  public void LineUp() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_LineUp(swigCPtr);
  }

  public void LineDown() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_LineDown(swigCPtr);
  }

  public void PageLeft() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_PageLeft(swigCPtr);
  }

  public void PageRight() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_PageRight(swigCPtr);
  }

  public void PageUp() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_PageUp(swigCPtr);
  }

  public void PageDown() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_PageDown(swigCPtr);
  }

  public void MouseWheelLeft(float delta) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelLeft__SWIG_0(swigCPtr, delta);
  }

  public void MouseWheelLeft() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelLeft__SWIG_1(swigCPtr);
  }

  public void MouseWheelRight(float delta) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelRight__SWIG_0(swigCPtr, delta);
  }

  public void MouseWheelRight() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelRight__SWIG_1(swigCPtr);
  }

  public void MouseWheelUp(float delta) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelUp__SWIG_0(swigCPtr, delta);
  }

  public void MouseWheelUp() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelUp__SWIG_1(swigCPtr);
  }

  public void MouseWheelDown(float delta) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelDown__SWIG_0(swigCPtr, delta);
  }

  public void MouseWheelDown() {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_MouseWheelDown__SWIG_1(swigCPtr);
  }

  public void SetHorizontalOffset(float offset) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_SetHorizontalOffset(swigCPtr, offset);
  }

  public void SetVerticalOffset(float offset) {
    NoesisGUI_PINVOKE.VirtualizingStackPanel_SetVerticalOffset(swigCPtr, offset);
  }

  public Rect MakeVisible(Visual visual, Rect rect) {
    IntPtr ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_MakeVisible(swigCPtr, Visual.getCPtr(visual), ref rect);
    if (ret != IntPtr.Zero) {
      return Marshal.PtrToStructure<Rect>(ret);
    }
    else {
      return new Rect();
    }
  }

  public static DependencyProperty OrientationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingStackPanel_OrientationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Orientation Orientation {
    set {
      NoesisGUI_PINVOKE.VirtualizingStackPanel_Orientation_set(swigCPtr, (int)value);
    } 
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.VirtualizingStackPanel_Orientation_get(swigCPtr);
      return ret;
    } 
  }

  public bool CanHorizontallyScroll {
    set {
      NoesisGUI_PINVOKE.VirtualizingStackPanel_CanHorizontallyScroll_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_CanHorizontallyScroll_get(swigCPtr);
      return ret;
    } 
  }

  public bool CanVerticallyScroll {
    set {
      NoesisGUI_PINVOKE.VirtualizingStackPanel_CanVerticallyScroll_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_CanVerticallyScroll_get(swigCPtr);
      return ret;
    } 
  }

  public float ExtentWidth {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_ExtentWidth_get(swigCPtr);
      return ret;
    } 
  }

  public float ExtentHeight {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_ExtentHeight_get(swigCPtr);
      return ret;
    } 
  }

  public float ViewportWidth {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_ViewportWidth_get(swigCPtr);
      return ret;
    } 
  }

  public float ViewportHeight {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_ViewportHeight_get(swigCPtr);
      return ret;
    } 
  }

  public float HorizontalOffset {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_HorizontalOffset_get(swigCPtr);
      return ret;
    } 
  }

  public float VerticalOffset {
    get {
      float ret = NoesisGUI_PINVOKE.VirtualizingStackPanel_VerticalOffset_get(swigCPtr);
      return ret;
    } 
  }

  public ScrollViewer ScrollOwner {
    set {
      NoesisGUI_PINVOKE.VirtualizingStackPanel_ScrollOwner_set(swigCPtr, ScrollViewer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VirtualizingStackPanel_ScrollOwner_get(swigCPtr);
      return (ScrollViewer)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

