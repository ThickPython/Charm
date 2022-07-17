//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Internal.Fbx {

public class FbxLayerElementArrayTemplateFbxVoidPtr : FbxLayerElementArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementArrayTemplateFbxVoidPtr(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementArrayTemplateFbxVoidPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementArrayTemplateFbxVoidPtr() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxLayerElementArrayTemplateFbxVoidPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr(EFbxType pDataType) : this(FbxWrapperNativePINVOKE.new_FbxLayerElementArrayTemplateFbxVoidPtr((int)pDataType), true) {
  }

  public int Add(SWIGTYPE_p_void pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_Add(swigCPtr, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public int InsertAt(int pIndex, SWIGTYPE_p_void pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_InsertAt(swigCPtr, pIndex, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public void SetAt(int pIndex, SWIGTYPE_p_void pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_SetAt(swigCPtr, pIndex, SWIGTYPE_p_void.getCPtr(pItem));
  }

  public void SetLast(SWIGTYPE_p_void pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_SetLast(swigCPtr, SWIGTYPE_p_void.getCPtr(pItem));
  }

  public SWIGTYPE_p_void RemoveAt(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_RemoveAt(swigCPtr, pIndex);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void RemoveLast() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_RemoveLast(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public bool RemoveIt(SWIGTYPE_p_void pItem) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_RemoveIt(swigCPtr, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public SWIGTYPE_p_void GetAt(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_GetAt(swigCPtr, pIndex);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void GetFirst() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_GetFirst(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void GetLast() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_GetLast(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public int Find(SWIGTYPE_p_void pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_Find(swigCPtr, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public int FindAfter(int pAfterIndex, SWIGTYPE_p_void pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_FindAfter(swigCPtr, pAfterIndex, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public int FindBefore(int pBeforeIndex, SWIGTYPE_p_void pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_FindBefore(swigCPtr, pBeforeIndex, SWIGTYPE_p_void.getCPtr(pItem));
    return ret;
  }

  public SWIGTYPE_p_void at(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_at(swigCPtr, pIndex);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public FbxLayerElementArray assign(SWIGTYPE_p_FbxArrayT_void_p_t pArrayTemplate) {
    FbxLayerElementArray ret = new FbxLayerElementArray(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_assign__SWIG_0(swigCPtr, SWIGTYPE_p_FbxArrayT_void_p_t.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr assign(FbxLayerElementArrayTemplateFbxVoidPtr pArrayTemplate) {
    FbxLayerElementArrayTemplateFbxVoidPtr ret = new FbxLayerElementArrayTemplateFbxVoidPtr(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxVoidPtr_assign__SWIG_1(swigCPtr, FbxLayerElementArrayTemplateFbxVoidPtr.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
