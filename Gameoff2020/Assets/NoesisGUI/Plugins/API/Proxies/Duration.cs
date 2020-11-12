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

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Duration {

  private enum DurationType {
    Automatic,
    TimeSpan,
    Forever
  }

  [MarshalAs(UnmanagedType.I4)]
  private DurationType _durationType;
  private TimeSpanStruct _timeSpan;

  public bool HasTimeSpan {
    get {
      return this._durationType == Duration.DurationType.TimeSpan;
    }
  }

  public System.TimeSpan TimeSpan {
    get {
      if (!HasTimeSpan) {
        throw new InvalidOperationException("Duration does not have TimeSpan");
      }
      return this._timeSpan;
    }
  }

  public static Duration Automatic {
    get {
      return new Duration { _durationType = Duration.DurationType.Automatic };
    }
  }

  public static Duration Forever {
    get {
      return new Duration { _durationType = Duration.DurationType.Forever };
    }
  }

  public Duration(System.TimeSpan timeSpan) {
    if (timeSpan < System.TimeSpan.Zero) {
      throw new ArgumentException("Duration cannot be negative");
    }
    this._durationType = Duration.DurationType.TimeSpan;
    this._timeSpan = timeSpan;
  }

  public static implicit operator Duration(System.TimeSpan timeSpan) {
    return new Duration(timeSpan);
  }

  public static Duration operator+(Duration t0, Duration t1) {
    if (t0.HasTimeSpan && t1.HasTimeSpan) {
      return new Duration(t0._timeSpan + t1._timeSpan);
    }
    if (t0._durationType == Duration.DurationType.Forever && t1._durationType == Duration.DurationType.Forever) {
      return Duration.Forever;
    }
    return Duration.Automatic;
  }

  public static Duration operator-(Duration t0, Duration t1) {
    if (t0.HasTimeSpan && t1.HasTimeSpan) {
      return new Duration(t0._timeSpan - t1._timeSpan);
    }
    if (t0._durationType == Duration.DurationType.Forever && t1.HasTimeSpan) {
      return Duration.Forever;
    }
    return Duration.Automatic;
  }

  public static bool operator==(Duration t0, Duration t1) {
    if (t0.HasTimeSpan && t1.HasTimeSpan) {
      return t0._timeSpan == t1._timeSpan;
    }
    return t0._durationType == t1._durationType;
  }

  public static bool operator!=(Duration t0, Duration t1) {
    return !(t0 == t1);
  }

  public static bool operator<(Duration t0, Duration t1) {
    if (t0.HasTimeSpan && t1.HasTimeSpan) {
        return t0._timeSpan < t1._timeSpan;
    }
    return t0.HasTimeSpan && t1._durationType == Duration.DurationType.Forever;
  }

  public static bool operator<=(Duration t0, Duration t1) {
    return (t0._durationType == Duration.DurationType.Automatic && t1._durationType == Duration.DurationType.Automatic) ||
     (t0._durationType != Duration.DurationType.Automatic && t1._durationType != Duration.DurationType.Automatic && !(t0 > t1));
  }

  public static bool operator>(Duration t0, Duration t1) {
    if (t0.HasTimeSpan && t1.HasTimeSpan) {
      return t0._timeSpan > t1._timeSpan;
    }
    return (!t0.HasTimeSpan || t1._durationType != Duration.DurationType.Forever) &&
     (t0._durationType == Duration.DurationType.Forever && t1.HasTimeSpan);
  }

  public static bool operator>=(Duration t0, Duration t1) {
    return (t0._durationType == Duration.DurationType.Automatic && t1._durationType == Duration.DurationType.Automatic) ||
     (t0._durationType != Duration.DurationType.Automatic && t1._durationType != Duration.DurationType.Automatic && !(t0 < t1));
  }

  public override bool Equals(System.Object obj) {
    return obj is Duration && this == (Duration)obj;
  }

  public bool Equals(Duration v) {
    return this == v;
  }

  public override int GetHashCode() {
    if (HasTimeSpan) {
        return this._timeSpan.GetHashCode();
    }
    return this._durationType.GetHashCode();
  }

  public override string ToString() {
    switch (this._durationType) {
      case Duration.DurationType.TimeSpan: return ((System.TimeSpan)this._timeSpan).ToString();
      case Duration.DurationType.Forever: return "Forever";
      case Duration.DurationType.Automatic: return "Automatic";
      default: return "Automatic";
    }
  }

  public static Duration Parse(string str) {
    Duration duration;
    if (Duration.TryParse(str, out duration)) {
      return duration;
    }
    throw new ArgumentException("Cannot create Duration from '" + str + "'");
  }

  public static bool TryParse(string str, out Duration result) {
    bool ret = NoesisGUI_PINVOKE.Duration_TryParse(str != null ? str : string.Empty, out result);
    return ret;
  }

}

}

