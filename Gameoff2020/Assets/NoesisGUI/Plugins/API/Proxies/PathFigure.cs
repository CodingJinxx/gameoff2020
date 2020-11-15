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

public class PathFigure : Animatable {
  internal new static PathFigure CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PathFigure(cPtr, cMemoryOwn);
  }

  internal PathFigure(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PathFigure obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override string ToString() {
    return ToStringHelper();
  }

  public PathFigure() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PathFigure();
  }

  public bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.PathFigure_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty IsClosedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathFigure_IsClosedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsFilledProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathFigure_IsFilledProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SegmentsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathFigure_SegmentsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StartPointProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathFigure_StartPointProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsClosed {
    set {
      NoesisGUI_PINVOKE.PathFigure_IsClosed_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.PathFigure_IsClosed_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsFilled {
    set {
      NoesisGUI_PINVOKE.PathFigure_IsFilled_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.PathFigure_IsFilled_get(swigCPtr);
      return ret;
    } 
  }

  public PathSegmentCollection Segments {
    set {
      NoesisGUI_PINVOKE.PathFigure_Segments_set(swigCPtr, PathSegmentCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathFigure_Segments_get(swigCPtr);
      return (PathSegmentCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Point StartPoint {
    set {
      NoesisGUI_PINVOKE.PathFigure_StartPoint_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.PathFigure_StartPoint_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Point>(ret);
      }
      else {
        return new Point();
      }
    }

  }

  private string ToStringHelper() {
    IntPtr strPtr = NoesisGUI_PINVOKE.PathFigure_ToStringHelper(swigCPtr);
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

}

}

