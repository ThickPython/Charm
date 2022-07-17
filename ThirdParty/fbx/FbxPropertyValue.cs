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

public class FbxPropertyValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxPropertyValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyValue obj) {
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

  public static FbxPropertyValue Create(SWIGTYPE_p_void pData, EFbxType pType) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPropertyValue_Create(SWIGTYPE_p_void.getCPtr(pData), (int)pType);
    FbxPropertyValue ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyValue(cPtr, false);
    return ret;
  }

  public void Destroy() {
    FbxWrapperNativePINVOKE.FbxPropertyValue_Destroy(swigCPtr);
  }

  public FbxPropertyValue Clone(FbxPropertyPage arg0) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPropertyValue_Clone(swigCPtr, FbxPropertyPage.getCPtr(arg0));
    FbxPropertyValue ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyValue(cPtr, false);
    return ret;
  }

  public bool Get(SWIGTYPE_p_void pValue, EFbxType pValueType) {
    bool ret = FbxWrapperNativePINVOKE.FbxPropertyValue_Get(swigCPtr, SWIGTYPE_p_void.getCPtr(pValue), (int)pValueType);
    return ret;
  }

  public bool Set(SWIGTYPE_p_void pValue, EFbxType pValueType) {
    bool ret = FbxWrapperNativePINVOKE.FbxPropertyValue_Set(swigCPtr, SWIGTYPE_p_void.getCPtr(pValue), (int)pValueType);
    return ret;
  }

  public uint GetSizeOf() {
    uint ret = FbxWrapperNativePINVOKE.FbxPropertyValue_GetSizeOf(swigCPtr);
    return ret;
  }

  public uint GetComponentCount() {
    uint ret = FbxWrapperNativePINVOKE.FbxPropertyValue_GetComponentCount(swigCPtr);
    return ret;
  }

  public void IncRef() {
    FbxWrapperNativePINVOKE.FbxPropertyValue_IncRef(swigCPtr);
  }

  public void DecRef() {
    FbxWrapperNativePINVOKE.FbxPropertyValue_DecRef(swigCPtr);
  }

  public int GetRef() {
    int ret = FbxWrapperNativePINVOKE.FbxPropertyValue_GetRef(swigCPtr);
    return ret;
  }

  public FbxPropertyValue() : this(FbxWrapperNativePINVOKE.new_FbxPropertyValue(), true) {
  }

}

}
