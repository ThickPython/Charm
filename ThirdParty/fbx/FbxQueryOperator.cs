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

public class FbxQueryOperator : FbxQuery {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxQueryOperator(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxQueryOperator_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxQueryOperator obj) {
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

  public static FbxQueryOperator Create(FbxQuery pA, FbxQueryOperator.EType pOperator, FbxQuery pB) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxQueryOperator_Create(FbxQuery.getCPtr(pA), (int)pOperator, FbxQuery.getCPtr(pB));
    FbxQueryOperator ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxQueryOperator(cPtr, false);
    return ret;
  }

  public override int GetUniqueId() {
    int ret = FbxWrapperNativePINVOKE.FbxQueryOperator_GetUniqueId(swigCPtr);
    return ret;
  }

  public override bool IsValid(FbxProperty pProperty) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryOperator_IsValid(swigCPtr, FbxProperty.getCPtr(pProperty));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsEqual(FbxQuery pOtherQuery) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryOperator_IsEqual(swigCPtr, FbxQuery.getCPtr(pOtherQuery));
    return ret;
  }

  public enum EType {
    eAND,
    eOR
  }

}

}
