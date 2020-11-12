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

public class ClockGroup : Clock {
  internal new static ClockGroup CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ClockGroup(cPtr, cMemoryOwn);
  }

  internal ClockGroup(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ClockGroup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ClockGroup() {
  }

  public ClockGroup(TimelineGroup timelineGroup, bool controllable) : this(NoesisGUI_PINVOKE.new_ClockGroup(TimelineGroup.getCPtr(timelineGroup), controllable), true) {
  }

  public void Add(Clock clock) {
    NoesisGUI_PINVOKE.ClockGroup_Add(swigCPtr, Clock.getCPtr(clock));
  }

  public Clock GetChild(uint index) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ClockGroup_GetChild(swigCPtr, index);
    return (Clock)Noesis.Extend.GetProxy(cPtr, false);
  }

  public bool Tick(double time, ClockState parentState) {
    bool ret = NoesisGUI_PINVOKE.ClockGroup_Tick(swigCPtr, time, (int)parentState);
    return ret;
  }

  public int ChildrenCount {
    get {
      int ret = NoesisGUI_PINVOKE.ClockGroup_ChildrenCount_get(swigCPtr);
      return ret;
    } 
  }

  public new TimelineGroup Timeline {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ClockGroup_Timeline_get(swigCPtr);
      return (TimelineGroup)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

