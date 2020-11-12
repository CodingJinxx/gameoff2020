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
internal struct NullableInt32 {

  [MarshalAs(UnmanagedType.U1)]
  private bool _hasValue;
  [MarshalAs(UnmanagedType.I4)]
  private int _value;

  public bool HasValue { get { return this._hasValue; } }

  public int Value {
    get {
      if (!HasValue) {
        throw new InvalidOperationException("Nullable does not have a value");
      }
      return this._value;
    }
  }

  public NullableInt32(int v) {
    this._hasValue = true;
    this._value = v;
  }

  public static explicit operator int(NullableInt32 n) {
    if (!n.HasValue) {
      throw new InvalidOperationException("Nullable does not have a value");
    }
    return n.Value;
  }

  public static implicit operator NullableInt32(int v) {
    return new NullableInt32(v);
  }

  public static implicit operator Nullable<int>(NullableInt32 n) {
    return n.HasValue ? new Nullable<int>(n.Value) : new Nullable<int>();
  }

  public static implicit operator NullableInt32(Nullable<int> n) {
    return n.HasValue ? new NullableInt32(n.Value) : new NullableInt32();
  }

  public static bool operator==(NullableInt32 n, int v) {
    return n.HasValue && n.Value == v;
  }

  public static bool operator!=(NullableInt32 n, int v) {
    return !(n == v);
  }

  public static bool operator==(int v, NullableInt32 n) {
    return n == v;
  }
  
  public static bool operator!=(int v, NullableInt32 n) {
    return n != v;
  }

  public static bool operator==(NullableInt32 n0, NullableInt32 n1) {
    return n0.HasValue && n1.HasValue ? n0.Value == n1.Value : n0.HasValue == n1.HasValue;
  }

  public static bool operator!=(NullableInt32 n0, NullableInt32 n1) {
    return !(n0 == n1);
  }

  public override bool Equals(System.Object obj) {
    return obj is NullableInt32 && this == (NullableInt32)obj;
  }

  public bool Equals(NullableInt32 n) {
    return this == n;
  }

  public override int GetHashCode() {
    return HasValue ? Value.GetHashCode() : 0;
  }

}

}

