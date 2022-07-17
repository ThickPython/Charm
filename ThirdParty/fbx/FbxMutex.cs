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

public class FbxMutex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxMutex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxMutex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxMutex() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxMutex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxMutex(bool pInitialOwnership) : this(FbxWrapperNativePINVOKE.new_FbxMutex__SWIG_0(pInitialOwnership), true) {
  }

  public FbxMutex() : this(FbxWrapperNativePINVOKE.new_FbxMutex__SWIG_1(), true) {
  }

  public void Acquire() {
    FbxWrapperNativePINVOKE.FbxMutex_Acquire(swigCPtr);
  }

  public bool TryAcquire(uint pRetryCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxMutex_TryAcquire(swigCPtr, pRetryCount);
    return ret;
  }

  public void Release() {
    FbxWrapperNativePINVOKE.FbxMutex_Release(swigCPtr);
  }

}

}
