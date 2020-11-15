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

public class TreeViewItem : HeaderedItemsControl {
  internal new static TreeViewItem CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TreeViewItem(cPtr, cMemoryOwn);
  }

  internal TreeViewItem(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TreeViewItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler Collapsed {
    add {
      AddHandler(CollapsedEvent, value);
    }
    remove {
      RemoveHandler(CollapsedEvent, value);
    }
  }

  public event RoutedEventHandler Expanded {
    add {
      AddHandler(ExpandedEvent, value);
    }
    remove {
      RemoveHandler(ExpandedEvent, value);
    }
  }

  public event RoutedEventHandler Selected {
    add {
      AddHandler(SelectedEvent, value);
    }
    remove {
      RemoveHandler(SelectedEvent, value);
    }
  }

  public event RoutedEventHandler Unselected {
    add {
      AddHandler(UnselectedEvent, value);
    }
    remove {
      RemoveHandler(UnselectedEvent, value);
    }
  }

  #endregion

  public TreeViewItem() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(TreeViewItem)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_TreeViewItem();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsExpandedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_IsExpandedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsSelectedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_IsSelectedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsSelectionActiveProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_IsSelectionActiveProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent CollapsedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_CollapsedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ExpandedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_ExpandedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent SelectedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_SelectedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent UnselectedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TreeViewItem_UnselectedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsExpanded {
    set {
      NoesisGUI_PINVOKE.TreeViewItem_IsExpanded_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.TreeViewItem_IsExpanded_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsSelected {
    set {
      NoesisGUI_PINVOKE.TreeViewItem_IsSelected_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.TreeViewItem_IsSelected_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsSelectionActive {
    get {
      bool ret = NoesisGUI_PINVOKE.TreeViewItem_IsSelectionActive_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_TreeViewItem(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

