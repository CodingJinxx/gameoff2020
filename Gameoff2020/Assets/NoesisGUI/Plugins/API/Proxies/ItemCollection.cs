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
using System.Collections;

namespace Noesis
{

public class ItemCollection : BaseComponent, IList {
  internal new static ItemCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ItemCollection(cPtr, cMemoryOwn);
  }

  internal ItemCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ItemCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ItemCollection() {
  }

  #region IList
  object IList.this[int index] {
    get { return this[index]; }
    set { this[index] = value; }
  }

  int IList.Add(object value) {
    return this.Add(value);
  }

  bool IList.Contains(object value) {
    return this.Contains(value);
  }

  void IList.Clear() {
    this.Clear();
  }

  bool IList.IsReadOnly {
    get { return false; }
  }

  bool IList.IsFixedSize {
    get { return false; }
  }

  int IList.IndexOf(object value) {
    return this.IndexOf(value);
  }

  void IList.Insert(int index, object value) {
    this.Insert(index, value);
  }

  void IList.Remove(object value) {
    this.Remove(value);
  }

  void IList.RemoveAt(int index) {
    this.RemoveAt(index);
  }
  #endregion

  #region ICollection
  int ICollection.Count {
    get { return this.Count; }
  }

  bool ICollection.IsSynchronized {
    get { return false; }
  }

  object ICollection.SyncRoot {
    get { return null; }
  }

  void ICollection.CopyTo(Array array, int arrayIndex) {
    this.CopyTo(array, arrayIndex);
  }
  #endregion

  #region Enumerator
  public Enumerator GetEnumerator() {
    return new Enumerator(this);
  }

  IEnumerator IEnumerable.GetEnumerator() {
    return new Enumerator(this);
  }

  public struct Enumerator :  IEnumerator {
    object IEnumerator.Current {
      get { return Current; }
    }
    public object Current {
      get { return this._collection[this._index]; }
    }
    public bool MoveNext() {
      if (++this._index >= this._collection.Count) {
        return false;
      }
      return true;
    }
    public void Reset() {
      this._index = -1;
    }
    public Enumerator(ItemCollection c) {
      this._collection = c;
      this._index = -1;
    }
    private ItemCollection _collection;
    private int _index;
  }
  #endregion

  public object this[int index] {
    get {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      return GetItemAt(index);
    }
    set {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      Set(index, value);
    }
  }

  public object GetItemAt(int index) {
    IntPtr cPtr = GetItemAtHelper(index);
    return Noesis.Extend.GetProxy(cPtr, true);
  }

  void CopyTo(Array array, int arrayIndex) {
    if (array == null) {
      throw new ArgumentNullException("array");
    }
    if (arrayIndex < 0) {
      throw new ArgumentOutOfRangeException("arrayIndex is less than 0.");
    }
    if ((array != null) && (array.Rank != 1)) {
      throw new ArgumentException("array is multidimensional.");
    }
    if (array.Length - arrayIndex < Count) { 
      throw new ArgumentException("There is no available space in array to copy all elements in the ICollection.");
    }
    int numElements = Count;
    for (int i = 0; i < numElements; ++i) {
      array.SetValue(this[i], arrayIndex + i);
    }
  }

  public ItemCollection(ItemsControl itemsControl) : this(NoesisGUI_PINVOKE.new_ItemCollection(ItemsControl.getCPtr(itemsControl)), true) {
  }

  private void Set(int index, object item) {
    NoesisGUI_PINVOKE.ItemCollection_Set(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
  }

  public int Add(object item) {
    int ret = NoesisGUI_PINVOKE.ItemCollection_Add(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public void Insert(int index, object item) {
    NoesisGUI_PINVOKE.ItemCollection_Insert(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
  }

  public int IndexOf(object item) {
    int ret = NoesisGUI_PINVOKE.ItemCollection_IndexOf(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public bool Remove(object item) {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_Remove(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public void RemoveAt(int index) {
    NoesisGUI_PINVOKE.ItemCollection_RemoveAt(swigCPtr, index);
  }

  public void Clear() {
    NoesisGUI_PINVOKE.ItemCollection_Clear(swigCPtr);
  }

  public bool Contains(object item) {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_Contains(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public bool MoveCurrentTo(object item) {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentTo(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public bool MoveCurrentToFirst() {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentToFirst(swigCPtr);
    return ret;
  }

  public bool MoveCurrentToLast() {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentToLast(swigCPtr);
    return ret;
  }

  public bool MoveCurrentToNext() {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentToNext(swigCPtr);
    return ret;
  }

  public bool MoveCurrentToPosition(int position) {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentToPosition(swigCPtr, position);
    return ret;
  }

  public bool MoveCurrentToPrevious() {
    bool ret = NoesisGUI_PINVOKE.ItemCollection_MoveCurrentToPrevious(swigCPtr);
    return ret;
  }

  public void Refresh() {
    NoesisGUI_PINVOKE.ItemCollection_Refresh(swigCPtr);
  }

  public bool CanFilter {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_CanFilter_get(swigCPtr);
      return ret;
    } 
  }

  public bool CanGroup {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_CanGroup_get(swigCPtr);
      return ret;
    } 
  }

  public bool CanSort {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_CanSort_get(swigCPtr);
      return ret;
    } 
  }

  public object CurrentItem {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ItemCollection_CurrentItem_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int CurrentPosition {
    get {
      int ret = NoesisGUI_PINVOKE.ItemCollection_CurrentPosition_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsCurrentAfterLast {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_IsCurrentAfterLast_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsCurrentBeforeFirst {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_IsCurrentBeforeFirst_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmpty {
    get {
      bool ret = NoesisGUI_PINVOKE.ItemCollection_IsEmpty_get(swigCPtr);
      return ret;
    } 
  }

  public int Count {
    get {
      int ret = NoesisGUI_PINVOKE.ItemCollection_Count_get(swigCPtr);
      return ret;
    } 
  }

  private IntPtr GetItemAtHelper(int index) {
    IntPtr ret = NoesisGUI_PINVOKE.ItemCollection_GetItemAtHelper(swigCPtr, index);
    return ret;
  }

}

}

