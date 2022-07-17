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

public class FbxVertexCacheDeformer : FbxDeformer {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxVertexCacheDeformer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxVertexCacheDeformer obj) {
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

  public static FbxClassId ClassId {
    set {
      FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxVertexCacheDeformer Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxVertexCacheDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVertexCacheDeformer(cPtr, false);
    return ret;
  }

  public new static FbxVertexCacheDeformer Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxVertexCacheDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVertexCacheDeformer(cPtr, false);
    return ret;
  }

  public void SetCache(FbxCache pCache) {
    FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_SetCache(swigCPtr, FbxCache.getCPtr(pCache));
  }

  public FbxCache GetCache() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_GetCache(swigCPtr);
    FbxCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCache(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Active {
    set {
      FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Active_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Active_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t Channel {
    set {
      FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Channel_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Channel_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CacheSet {
    set {
      FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_CacheSet_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_CacheSet_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVertexCacheDeformer__ECacheChannelType_t Type {
    set {
      FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Type_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVertexCacheDeformer__ECacheChannelType_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Type_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVertexCacheDeformer__ECacheChannelType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVertexCacheDeformer__ECacheChannelType_t(cPtr, false);
      return ret;
    } 
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxDeformer.EDeformerType GetDeformerType() {
    FbxDeformer.EDeformerType ret = (FbxDeformer.EDeformerType)FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_GetDeformerType(swigCPtr);
    return ret;
  }

  public static FbxVertexCacheDeformer Cast(FbxObject arg0) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVertexCacheDeformer_Cast(FbxObject.getCPtr(arg0));
    FbxVertexCacheDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVertexCacheDeformer(cPtr, false);
    return ret;
  }

  public enum ECacheChannelType {
    ePositions,
    eNormals,
    eUVs,
    eTangents,
    eBinormals,
    eUserDefined
  }

}

}
