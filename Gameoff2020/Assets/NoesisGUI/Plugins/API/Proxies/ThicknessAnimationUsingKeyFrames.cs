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

public class ThicknessAnimationUsingKeyFrames : AnimationTimeline {
  internal new static ThicknessAnimationUsingKeyFrames CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ThicknessAnimationUsingKeyFrames(cPtr, cMemoryOwn);
  }

  internal ThicknessAnimationUsingKeyFrames(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ThicknessAnimationUsingKeyFrames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ThicknessAnimationUsingKeyFrames() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ThicknessAnimationUsingKeyFrames();
  }

  public ThicknessKeyFrameCollection KeyFrames {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ThicknessAnimationUsingKeyFrames_KeyFrames_get(swigCPtr);
      return (ThicknessKeyFrameCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

