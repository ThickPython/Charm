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

public class FbxLayerElementTemplateFbxInt : FbxLayerElement {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementTemplateFbxInt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementTemplateFbxInt obj) {
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

  public FbxLayerElementArrayTemplateFbxInt GetDirectArray() {
    FbxLayerElementArrayTemplateFbxInt ret = new FbxLayerElementArrayTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_GetDirectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxInt GetIndexArray() {
    FbxLayerElementArrayTemplateFbxInt ret = new FbxLayerElementArrayTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_GetIndexArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override bool Clear() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_Clear(swigCPtr);
    return ret;
  }

  public bool eq(FbxLayerElementTemplateFbxInt pOther) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_eq(swigCPtr, FbxLayerElementTemplateFbxInt.getCPtr(pOther));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementTemplateFbxInt assign(FbxLayerElementTemplateFbxInt pOther) {
    FbxLayerElementTemplateFbxInt ret = new FbxLayerElementTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_assign(swigCPtr, FbxLayerElementTemplateFbxInt.getCPtr(pOther)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemapIndexTo(FbxLayerElement.EMappingMode pNewMapping) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_RemapIndexTo(swigCPtr, (int)pNewMapping);
    return ret;
  }

  public override int MemorySize() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_MemorySize(swigCPtr);
    return ret;
  }

  public override bool ContentWriteTo(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_ContentWriteTo(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool ContentReadFrom(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_ContentReadFrom(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxInt mDirectArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_mDirectArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxInt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_mDirectArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxInt(cPtr, false);
      return ret;
    } 
  }

  public FbxLayerElementArrayTemplateFbxInt mIndexArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_mIndexArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxInt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxInt_mIndexArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxInt(cPtr, false);
      return ret;
    } 
  }

}

}
