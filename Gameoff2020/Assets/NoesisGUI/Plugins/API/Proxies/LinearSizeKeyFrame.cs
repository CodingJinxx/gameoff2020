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

public class LinearSizeKeyFrame : SizeKeyFrame {
  internal new static LinearSizeKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new LinearSizeKeyFrame(cPtr, cMemoryOwn);
  }

  internal LinearSizeKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(LinearSizeKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public LinearSizeKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_LinearSizeKeyFrame();
  }

}

}

