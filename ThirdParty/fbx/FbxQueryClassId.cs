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

public class FbxQueryClassId : FbxQuery {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxQueryClassId(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxQueryClassId_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxQueryClassId obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxQueryClassId() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxQueryClassId(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxQueryClassId Create(FbxClassId pClassId) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxQueryClassId_Create(FbxClassId.getCPtr(pClassId));
    FbxQueryClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxQueryClassId(cPtr, false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetUniqueId() {
    int ret = FbxWrapperNativePINVOKE.FbxQueryClassId_GetUniqueId(swigCPtr);
    return ret;
  }

  public override bool IsValid(FbxProperty pProperty) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryClassId_IsValid(swigCPtr, FbxProperty.getCPtr(pProperty));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsEqual(FbxQuery pOtherQuery) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryClassId_IsEqual(swigCPtr, FbxQuery.getCPtr(pOtherQuery));
    return ret;
  }

}

}
