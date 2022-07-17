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

public class FbxLayerElementTemplateFbxTexturePtr : FbxLayerElement {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementTemplateFbxTexturePtr(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementTemplateFbxTexturePtr obj) {
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

  public FbxLayerElementArrayTemplateFbxTexturePtr GetDirectArray() {
    FbxLayerElementArrayTemplateFbxTexturePtr ret = new FbxLayerElementArrayTemplateFbxTexturePtr(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_GetDirectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxInt GetIndexArray() {
    FbxLayerElementArrayTemplateFbxInt ret = new FbxLayerElementArrayTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_GetIndexArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override bool Clear() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_Clear(swigCPtr);
    return ret;
  }

  public bool eq(FbxLayerElementTemplateFbxTexturePtr pOther) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_eq(swigCPtr, FbxLayerElementTemplateFbxTexturePtr.getCPtr(pOther));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementTemplateFbxTexturePtr assign(FbxLayerElementTemplateFbxTexturePtr pOther) {
    FbxLayerElementTemplateFbxTexturePtr ret = new FbxLayerElementTemplateFbxTexturePtr(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_assign(swigCPtr, FbxLayerElementTemplateFbxTexturePtr.getCPtr(pOther)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemapIndexTo(FbxLayerElement.EMappingMode pNewMapping) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_RemapIndexTo(swigCPtr, (int)pNewMapping);
    return ret;
  }

  public override int MemorySize() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_MemorySize(swigCPtr);
    return ret;
  }

  public override bool ContentWriteTo(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_ContentWriteTo(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool ContentReadFrom(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_ContentReadFrom(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxTexturePtr mDirectArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_mDirectArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxTexturePtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_mDirectArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxTexturePtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxTexturePtr(cPtr, false);
      return ret;
    } 
  }

  public FbxLayerElementArrayTemplateFbxInt mIndexArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_mIndexArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxInt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxTexturePtr_mIndexArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxInt(cPtr, false);
      return ret;
    } 
  }

}

}
