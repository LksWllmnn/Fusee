//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class ToolSwitchActionMsgData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ToolSwitchActionMsgData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ToolSwitchActionMsgData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToolSwitchActionMsgData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ToolSwitchActionMsgData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_EditorWindow bw {
    set {
      C4dApiPINVOKE.ToolSwitchActionMsgData_bw_set(swigCPtr, SWIGTYPE_p_EditorWindow.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolSwitchActionMsgData_bw_get(swigCPtr);
      SWIGTYPE_p_EditorWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_EditorWindow(cPtr, false);
      return ret;
    } 
  }

  public BaseDocument doc {
    set {
      C4dApiPINVOKE.ToolSwitchActionMsgData_doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolSwitchActionMsgData_doc_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public BaseDraw bd {
    set {
      C4dApiPINVOKE.ToolSwitchActionMsgData_bd_set(swigCPtr, BaseDraw.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ToolSwitchActionMsgData_bd_get(swigCPtr);
      BaseDraw ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
      return ret;
    } 
  }

  public QUALIFIER qualifier {
    set {
      C4dApiPINVOKE.ToolSwitchActionMsgData_qualifier_set(swigCPtr, (int)value);
    } 
    get {
      QUALIFIER ret = (QUALIFIER)C4dApiPINVOKE.ToolSwitchActionMsgData_qualifier_get(swigCPtr);
      return ret;
    } 
  }

  public int action {
    set {
      C4dApiPINVOKE.ToolSwitchActionMsgData_action_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ToolSwitchActionMsgData_action_get(swigCPtr);
      return ret;
    } 
  }

  public ToolSwitchActionMsgData() : this(C4dApiPINVOKE.new_ToolSwitchActionMsgData(), true) {
  }

}

}