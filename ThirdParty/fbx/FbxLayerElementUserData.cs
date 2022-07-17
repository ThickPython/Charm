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

public class FbxLayerElementUserData : FbxLayerElementTemplateFbxVoidPtr {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementUserData(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementUserData_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementUserData obj) {
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

  public static FbxLayerElementUserData Create(FbxLayerContainer pOwner, string pName, int pId, SWIGTYPE_p_FbxArrayT_FbxDataType_t pDataTypes, SWIGTYPE_p_FbxArrayT_char_const_p_t pDataNames) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_Create__SWIG_0(FbxLayerContainer.getCPtr(pOwner), pName, pId, SWIGTYPE_p_FbxArrayT_FbxDataType_t.getCPtr(pDataTypes), SWIGTYPE_p_FbxArrayT_char_const_p_t.getCPtr(pDataNames));
    FbxLayerElementUserData ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementUserData(cPtr, false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxLayerElementUserData Create(FbxLayerContainer pOwner, FbxLayerElementUserData pOther) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_Create__SWIG_1(FbxLayerContainer.getCPtr(pOwner), FbxLayerElementUserData.getCPtr(pOther));
    FbxLayerElementUserData ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementUserData(cPtr, false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr GetDirectArrayVoid(int pIndex, SWIGTYPE_p_bool pStatus) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDirectArrayVoid__SWIG_0(swigCPtr, pIndex, SWIGTYPE_p_bool.getCPtr(pStatus));
    FbxLayerElementArrayTemplateFbxVoidPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxVoidPtr(cPtr, false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr GetDirectArrayVoid(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDirectArrayVoid__SWIG_1(swigCPtr, pIndex);
    FbxLayerElementArrayTemplateFbxVoidPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxVoidPtr(cPtr, false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr GetDirectArrayVoid(string pName, SWIGTYPE_p_bool pStatus) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDirectArrayVoid__SWIG_4(swigCPtr, pName, SWIGTYPE_p_bool.getCPtr(pStatus));
    FbxLayerElementArrayTemplateFbxVoidPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxVoidPtr(cPtr, false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVoidPtr GetDirectArrayVoid(string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDirectArrayVoid__SWIG_5(swigCPtr, pName);
    FbxLayerElementArrayTemplateFbxVoidPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxVoidPtr(cPtr, false);
    return ret;
  }

  public FbxDataType GetDataType(int pIndex) {
    FbxDataType ret = new FbxDataType(FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDataType__SWIG_0(swigCPtr, pIndex), true);
    return ret;
  }

  public FbxDataType GetDataType(string pName) {
    FbxDataType ret = new FbxDataType(FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDataType__SWIG_1(swigCPtr, pName), true);
    return ret;
  }

  public string GetDataName(int pIndex) {
    string ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDataName(swigCPtr, pIndex);
    return ret;
  }

  public void ResizeAllDirectArrays(int pSize) {
    FbxWrapperNativePINVOKE.FbxLayerElementUserData_ResizeAllDirectArrays(swigCPtr, pSize);
  }

  public void RemoveFromAllDirectArrays(int pIndex) {
    FbxWrapperNativePINVOKE.FbxLayerElementUserData_RemoveFromAllDirectArrays(swigCPtr, pIndex);
  }

  public int GetArrayCount(int pIndex) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetArrayCount(swigCPtr, pIndex);
    return ret;
  }

  public int GetId() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetId(swigCPtr);
    return ret;
  }

  public int GetDirectArrayCount() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_GetDirectArrayCount(swigCPtr);
    return ret;
  }

  public FbxLayerElementUserData assign(FbxLayerElementUserData pOther) {
    FbxLayerElementUserData ret = new FbxLayerElementUserData(FbxWrapperNativePINVOKE.FbxLayerElementUserData_assign(swigCPtr, FbxLayerElementUserData.getCPtr(pOther)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Clear() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_Clear(swigCPtr);
    return ret;
  }

  public override int MemorySize() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementUserData_MemorySize(swigCPtr);
    return ret;
  }

}

}
