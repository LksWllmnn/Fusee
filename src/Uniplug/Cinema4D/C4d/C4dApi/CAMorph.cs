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

public class CAMorph : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CAMorph(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CAMorph obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string /* String_cstype */ GetName()  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.CAMorph_GetName(swigCPtr);
      return ret;
   } /* </String_csout> */ 

  public void SetName(string /* constString&_cstype */ name) {
    C4dApiPINVOKE.CAMorph_SetName(swigCPtr, name);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetID() {
    int ret = C4dApiPINVOKE.CAMorph_GetID(swigCPtr);
    return ret;
  }

  public bool CopyFrom(CAMorph src, AliasTrans trn, CAMORPH_COPY_FLAGS flags) {
    bool ret = C4dApiPINVOKE.CAMorph_CopyFrom(swigCPtr, CAMorph.getCPtr(src), AliasTrans.getCPtr(trn), (int)flags);
    return ret;
  }

  public CAMorphNode Find(CAPoseMorphTag tag, BaseList2D bl) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAMorph_Find(swigCPtr, CAPoseMorphTag.getCPtr(tag), BaseList2D.getCPtr(bl));
    CAMorphNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAMorphNode(cPtr, false);
    return ret;
  }

  public int GetNodeIndex(CAMorphNode node) {
    int ret = C4dApiPINVOKE.CAMorph_GetNodeIndex(swigCPtr, CAMorphNode.getCPtr(node));
    return ret;
  }

  public int FindIndex(CAPoseMorphTag tag, BaseList2D bl) {
    int ret = C4dApiPINVOKE.CAMorph_FindIndex(swigCPtr, CAPoseMorphTag.getCPtr(tag), BaseList2D.getCPtr(bl));
    return ret;
  }

  public CAMorphNode FindFromIndex(CAPoseMorphTag tag, int index) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAMorph_FindFromIndex(swigCPtr, CAPoseMorphTag.getCPtr(tag), index);
    CAMorphNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAMorphNode(cPtr, false);
    return ret;
  }

  public CAMorphNode GetFirst() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAMorph_GetFirst(swigCPtr);
    CAMorphNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAMorphNode(cPtr, false);
    return ret;
  }

  public bool SetMode(BaseDocument doc, CAPoseMorphTag tag, CAMORPH_MODE_FLAGS flags, CAMORPH_MODE mode) {
    bool ret = C4dApiPINVOKE.CAMorph_SetMode(swigCPtr, BaseDocument.getCPtr(doc), CAPoseMorphTag.getCPtr(tag), (int)flags, (int)mode);
    return ret;
  }

  public bool Store(BaseDocument doc, CAPoseMorphTag tag, CAMORPH_DATA_FLAGS flags) {
    bool ret = C4dApiPINVOKE.CAMorph_Store(swigCPtr, BaseDocument.getCPtr(doc), CAPoseMorphTag.getCPtr(tag), (int)flags);
    return ret;
  }

  public bool Apply(BaseDocument doc, CAPoseMorphTag tag, CAMORPH_DATA_FLAGS flags) {
    bool ret = C4dApiPINVOKE.CAMorph_Apply(swigCPtr, BaseDocument.getCPtr(doc), CAPoseMorphTag.getCPtr(tag), (int)flags);
    return ret;
  }

  public BaseList2D GetTarget(BaseDocument doc) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAMorph_GetTarget(swigCPtr, BaseDocument.getCPtr(doc));
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public void SetTarget(CAPoseMorphTag tag, BaseDocument doc, BaseList2D bl) {
    C4dApiPINVOKE.CAMorph_SetTarget(swigCPtr, CAPoseMorphTag.getCPtr(tag), BaseDocument.getCPtr(doc), BaseList2D.getCPtr(bl));
  }

  public void SetStrength(double strength) {
    C4dApiPINVOKE.CAMorph_SetStrength(swigCPtr, strength);
  }

  public double GetStrength() {
    double ret = C4dApiPINVOKE.CAMorph_GetStrength(swigCPtr);
    return ret;
  }

}

}