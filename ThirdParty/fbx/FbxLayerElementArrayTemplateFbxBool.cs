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

public class FbxLayerElementArrayTemplateFbxBool : FbxLayerElementArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementArrayTemplateFbxBool(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementArrayTemplateFbxBool obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementArrayTemplateFbxBool() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxLayerElementArrayTemplateFbxBool(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxLayerElementArrayTemplateFbxBool(EFbxType pDataType) : this(FbxWrapperNativePINVOKE.new_FbxLayerElementArrayTemplateFbxBool((int)pDataType), true) {
  }

  public int Add(bool pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_Add(swigCPtr, pItem);
    return ret;
  }

  public int InsertAt(int pIndex, bool pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_InsertAt(swigCPtr, pIndex, pItem);
    return ret;
  }

  public void SetAt(int pIndex, bool pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_SetAt(swigCPtr, pIndex, pItem);
  }

  public void SetLast(bool pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_SetLast(swigCPtr, pItem);
  }

  public bool RemoveAt(int pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_RemoveAt(swigCPtr, pIndex);
    return ret;
  }

  public bool RemoveLast() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_RemoveLast(swigCPtr);
    return ret;
  }

  public bool RemoveIt(bool pItem) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_RemoveIt(swigCPtr, pItem);
    return ret;
  }

  public bool GetAt(int pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_GetAt(swigCPtr, pIndex);
    return ret;
  }

  public bool GetFirst() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_GetFirst(swigCPtr);
    return ret;
  }

  public bool GetLast() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_GetLast(swigCPtr);
    return ret;
  }

  public int Find(bool pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_Find(swigCPtr, pItem);
    return ret;
  }

  public int FindAfter(int pAfterIndex, bool pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_FindAfter(swigCPtr, pAfterIndex, pItem);
    return ret;
  }

  public int FindBefore(int pBeforeIndex, bool pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_FindBefore(swigCPtr, pBeforeIndex, pItem);
    return ret;
  }

  public bool at(int pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_at(swigCPtr, pIndex);
    return ret;
  }

  public FbxLayerElementArray assign(SWIGTYPE_p_FbxArrayT_bool_t pArrayTemplate) {
    FbxLayerElementArray ret = new FbxLayerElementArray(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_assign__SWIG_0(swigCPtr, SWIGTYPE_p_FbxArrayT_bool_t.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxBool assign(FbxLayerElementArrayTemplateFbxBool pArrayTemplate) {
    FbxLayerElementArrayTemplateFbxBool ret = new FbxLayerElementArrayTemplateFbxBool(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxBool_assign__SWIG_1(swigCPtr, FbxLayerElementArrayTemplateFbxBool.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
