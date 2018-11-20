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

public class BaseList2D : GeListNode {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BaseList2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.BaseList2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseList2D obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static BaseList2D Alloc(int type) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_Alloc(type);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BaseList2D bl) {
    C4dApiPINVOKE.BaseList2D_Free(SWIGTYPE_p_p_BaseList2D.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public new BaseList2D GetNext() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetNext(swigCPtr);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public new BaseList2D GetPred() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetPred(swigCPtr);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public void SetBit(int mask) {
    C4dApiPINVOKE.BaseList2D_SetBit(swigCPtr, mask);
  }

  public bool GetBit(int mask) {
    bool ret = C4dApiPINVOKE.BaseList2D_GetBit(swigCPtr, mask);
    return ret;
  }

  public void DelBit(int mask) {
    C4dApiPINVOKE.BaseList2D_DelBit(swigCPtr, mask);
  }

  public void ToggleBit(int mask) {
    C4dApiPINVOKE.BaseList2D_ToggleBit(swigCPtr, mask);
  }

  public int GetAllBits() {
    int ret = C4dApiPINVOKE.BaseList2D_GetAllBits(swigCPtr);
    return ret;
  }

  public void SetAllBits(int bits) {
    C4dApiPINVOKE.BaseList2D_SetAllBits(swigCPtr, bits);
  }

  public BaseContainer GetData() {
    BaseContainer ret = new BaseContainer(C4dApiPINVOKE.BaseList2D_GetData(swigCPtr), true);
    return ret;
  }

  public void SetData(BaseContainer bc, bool add) {
    C4dApiPINVOKE.BaseList2D_SetData__SWIG_0(swigCPtr, BaseContainer.getCPtr(bc), add);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetData(BaseContainer bc) {
    C4dApiPINVOKE.BaseList2D_SetData__SWIG_1(swigCPtr, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseContainer GetDataInstance() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetDataInstance__SWIG_0(swigCPtr);
    BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
    return ret;
  }

  public string /* constString&_cstype */ GetName() {
    string ret = C4dApiPINVOKE.BaseList2D_GetName(swigCPtr);
    return ret;
  }

  public void SetName(string /* constString&_cstype */ name) {
    C4dApiPINVOKE.BaseList2D_SetName(swigCPtr, name);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public string /* String_cstype */ GetBubbleHelp()  {  /* <String_csout> */
      string ret = C4dApiPINVOKE.BaseList2D_GetBubbleHelp(swigCPtr);
      return ret;
   } /* </String_csout> */ 

  public bool TransferGoal(BaseList2D dst, bool undolink) {
    bool ret = C4dApiPINVOKE.BaseList2D_TransferGoal(swigCPtr, BaseList2D.getCPtr(dst), undolink);
    return ret;
  }

  public bool TransferMarker(BaseList2D dst) {
    bool ret = C4dApiPINVOKE.BaseList2D_TransferMarker(swigCPtr, BaseList2D.getCPtr(dst));
    return ret;
  }

  public void GetMarkerStampEx(SWIGTYPE_p_UInt32 l1, SWIGTYPE_p_UInt32 l2) {
    C4dApiPINVOKE.BaseList2D_GetMarkerStampEx(swigCPtr, SWIGTYPE_p_UInt32.getCPtr(l1), SWIGTYPE_p_UInt32.getCPtr(l2));
  }

  public GeMarker GetMarker() {
    GeMarker ret = new GeMarker(C4dApiPINVOKE.BaseList2D_GetMarker(swigCPtr), false);
    return ret;
  }

  public void SetMarker(GeMarker m) {
    C4dApiPINVOKE.BaseList2D_SetMarker(swigCPtr, GeMarker.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool AddUniqueID(int appid, SWIGTYPE_p_Char mem, int bytes) {
    bool ret = C4dApiPINVOKE.BaseList2D_AddUniqueID(swigCPtr, appid, SWIGTYPE_p_Char.getCPtr(mem), bytes);
    return ret;
  }

  public bool FindUniqueID(int appid, SWIGTYPE_p_p_Char mem, SWIGTYPE_p_Int bytes) {
    bool ret = C4dApiPINVOKE.BaseList2D_FindUniqueID(swigCPtr, appid, SWIGTYPE_p_p_Char.getCPtr(mem), SWIGTYPE_p_Int.getCPtr(bytes));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetUniqueIDCount() {
    int ret = C4dApiPINVOKE.BaseList2D_GetUniqueIDCount(swigCPtr);
    return ret;
  }

  public bool GetUniqueIDIndex(int idx, SWIGTYPE_p_Int32 id, SWIGTYPE_p_p_Char mem, SWIGTYPE_p_Int bytes) {
    bool ret = C4dApiPINVOKE.BaseList2D_GetUniqueIDIndex(swigCPtr, idx, SWIGTYPE_p_Int32.getCPtr(id), SWIGTYPE_p_p_Char.getCPtr(mem), SWIGTYPE_p_Int.getCPtr(bytes));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetAnimatedParameter(CTrack track, DescID id, GeData t_data1, GeData t_data2, double mix, DESCFLAGS_SET flags) {
    bool ret = C4dApiPINVOKE.BaseList2D_SetAnimatedParameter(swigCPtr, CTrack.getCPtr(track), DescID.getCPtr(id), GeData.getCPtr(t_data1), GeData.getCPtr(t_data2), mix, (int)flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetAnimatedParameter(DescID id, GeData t_data1, GeData t_data2, SWIGTYPE_p_Float mix, DESCFLAGS_GET flags) {
    bool ret = C4dApiPINVOKE.BaseList2D_GetAnimatedParameter(swigCPtr, DescID.getCPtr(id), GeData.getCPtr(t_data1), GeData.getCPtr(t_data2), SWIGTYPE_p_Float.getCPtr(mix), (int)flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Scale(double scale) {
    bool ret = C4dApiPINVOKE.BaseList2D_Scale(swigCPtr, scale);
    return ret;
  }

  public BaseShader GetFirstShader() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetFirstShader(swigCPtr);
    BaseShader ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseShader(cPtr, false);
    return ret;
  }

  public void InsertShader(BaseShader shader, BaseShader pred) {
    C4dApiPINVOKE.BaseList2D_InsertShader__SWIG_0(swigCPtr, BaseShader.getCPtr(shader), BaseShader.getCPtr(pred));
  }

  public void InsertShader(BaseShader shader) {
    C4dApiPINVOKE.BaseList2D_InsertShader__SWIG_1(swigCPtr, BaseShader.getCPtr(shader));
  }

  public bool Edit() {
    bool ret = C4dApiPINVOKE.BaseList2D_Edit(swigCPtr);
    return ret;
  }

  public void GetIcon(SWIGTYPE_p_IconData dat) {
    C4dApiPINVOKE.BaseList2D_GetIcon(swigCPtr, SWIGTYPE_p_IconData.getCPtr(dat));
  }

  public void ClearKeyframeSelection() {
    C4dApiPINVOKE.BaseList2D_ClearKeyframeSelection(swigCPtr);
  }

  public bool FindKeyframeSelection(DescID id) {
    bool ret = C4dApiPINVOKE.BaseList2D_FindKeyframeSelection(swigCPtr, DescID.getCPtr(id));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetKeyframeSelection(DescID id, bool selection) {
    bool ret = C4dApiPINVOKE.BaseList2D_SetKeyframeSelection(swigCPtr, DescID.getCPtr(id), selection);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool KeyframeSelectionContent() {
    bool ret = C4dApiPINVOKE.BaseList2D_KeyframeSelectionContent(swigCPtr);
    return ret;
  }

  public LayerObject GetLayerObject(BaseDocument doc) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetLayerObject(swigCPtr, BaseDocument.getCPtr(doc));
    LayerObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new LayerObject(cPtr, false);
    return ret;
  }

  public bool SetLayerObject(LayerObject layer) {
    bool ret = C4dApiPINVOKE.BaseList2D_SetLayerObject(swigCPtr, LayerObject.getCPtr(layer));
    return ret;
  }

  public LayerData GetLayerData(BaseDocument doc, bool rawdata) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetLayerData__SWIG_0(swigCPtr, BaseDocument.getCPtr(doc), rawdata);
    LayerData ret = (cPtr == global::System.IntPtr.Zero) ? null : new LayerData(cPtr, false);
    return ret;
  }

  public LayerData GetLayerData(BaseDocument doc) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetLayerData__SWIG_1(swigCPtr, BaseDocument.getCPtr(doc));
    LayerData ret = (cPtr == global::System.IntPtr.Zero) ? null : new LayerData(cPtr, false);
    return ret;
  }

  public bool SetLayerData(BaseDocument doc, LayerData data) {
    bool ret = C4dApiPINVOKE.BaseList2D_SetLayerData(swigCPtr, BaseDocument.getCPtr(doc), LayerData.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GeListHead GetCTrackRoot() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetCTrackRoot(swigCPtr);
    GeListHead ret = (cPtr == global::System.IntPtr.Zero) ? null : new GeListHead(cPtr, false);
    return ret;
  }

  public CTrack GetFirstCTrack() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetFirstCTrack(swigCPtr);
    CTrack ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTrack(cPtr, false);
    return ret;
  }

  public CTrack FindCTrack(DescID id) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_FindCTrack(swigCPtr, DescID.getCPtr(id));
    CTrack ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTrack(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GeListHead GetNLARoot() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetNLARoot(swigCPtr);
    GeListHead ret = (cPtr == global::System.IntPtr.Zero) ? null : new GeListHead(cPtr, false);
    return ret;
  }

  public BaseList2D AnimationLayerRemap(SWIGTYPE_p_p_BaseObject layer) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_AnimationLayerRemap__SWIG_0(swigCPtr, SWIGTYPE_p_p_BaseObject.getCPtr(layer));
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public BaseList2D AnimationLayerRemap() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_AnimationLayerRemap__SWIG_1(swigCPtr);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public string /* constString&_cstype */ GetTypeName() {
    string ret = C4dApiPINVOKE.BaseList2D_GetTypeName(swigCPtr);
    return ret;
  }

  public BaseList2D GetMain() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetMain(swigCPtr);
    BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public void InsertTrackSorted(CTrack track) {
    C4dApiPINVOKE.BaseList2D_InsertTrackSorted(swigCPtr, CTrack.getCPtr(track));
  }

  public bool AddEventNotification(BaseList2D bl, NOTIFY_EVENT eventid, NOTIFY_EVENT_FLAG flags, BaseContainer data) {
    bool ret = C4dApiPINVOKE.BaseList2D_AddEventNotification(swigCPtr, BaseList2D.getCPtr(bl), (int)eventid, (int)flags, BaseContainer.getCPtr(data));
    return ret;
  }

  public bool RemoveEventNotification(BaseDocument doc, BaseList2D bl, NOTIFY_EVENT eventid) {
    bool ret = C4dApiPINVOKE.BaseList2D_RemoveEventNotification(swigCPtr, BaseDocument.getCPtr(doc), BaseList2D.getCPtr(bl), (int)eventid);
    return ret;
  }

  public bool FindEventNotification(BaseDocument doc, BaseList2D bl, NOTIFY_EVENT eventid) {
    bool ret = C4dApiPINVOKE.BaseList2D_FindEventNotification(swigCPtr, BaseDocument.getCPtr(doc), BaseList2D.getCPtr(bl), (int)eventid);
    return ret;
  }

  public bool SetDescIDState(DescID id, DESCIDSTATE descidstate) {
    bool ret = C4dApiPINVOKE.BaseList2D_SetDescIDState(swigCPtr, DescID.getCPtr(id), (int)descidstate);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DESCIDSTATE GetDescIDState(DescID id, bool tolerant) {
    DESCIDSTATE ret = (DESCIDSTATE)C4dApiPINVOKE.BaseList2D_GetDescIDState(swigCPtr, DescID.getCPtr(id), tolerant);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GeListHead GetOverrideRoot() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetOverrideRoot(swigCPtr);
    GeListHead ret = (cPtr == global::System.IntPtr.Zero) ? null : new GeListHead(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_BaseOverride GetFirstOverride() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetFirstOverride(swigCPtr);
    SWIGTYPE_p_BaseOverride ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_BaseOverride(cPtr, false);
    return ret;
  }

  public GeListHead GetShaderRepositoryRoot() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseList2D_GetShaderRepositoryRoot(swigCPtr);
    GeListHead ret = (cPtr == global::System.IntPtr.Zero) ? null : new GeListHead(cPtr, false);
    return ret;
  }

}

}