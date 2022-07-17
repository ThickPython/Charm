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

public class FbxIteratorDstBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxIteratorDstBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxIteratorDstBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxIteratorDstBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxIteratorDstBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxIteratorDstBase(FbxProperty pProperty, FbxClassId pClassId) : this(FbxWrapperNativePINVOKE.new_FbxIteratorDstBase__SWIG_0(FbxProperty.getCPtr(pProperty), FbxClassId.getCPtr(pClassId)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxIteratorDstBase(FbxObject pObject, FbxClassId pClassId) : this(FbxWrapperNativePINVOKE.new_FbxIteratorDstBase__SWIG_1(FbxObject.getCPtr(pObject), FbxClassId.getCPtr(pClassId)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxObject GetFirst() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetFirst(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetNext() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetNext(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetSafeNext() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetSafeNext(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetLast() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetLast(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetPrevious() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetPrevious(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetSafePrevious() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIteratorDstBase_GetSafePrevious(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

}

}
