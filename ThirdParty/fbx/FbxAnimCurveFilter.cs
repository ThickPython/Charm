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

public class FbxAnimCurveFilter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveFilter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveFilter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveFilter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxAnimCurveFilter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string GetName() {
    string ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetName(swigCPtr);
    return ret;
  }

  public FbxTime GetStartTime() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetStartTime(swigCPtr), false);
    return ret;
  }

  public void SetStartTime(FbxTime pTime) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilter_SetStartTime(swigCPtr, FbxTime.getCPtr(pTime));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetStopTime() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetStopTime(swigCPtr), false);
    return ret;
  }

  public void SetStopTime(FbxTime pTime) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilter_SetStopTime(swigCPtr, FbxTime.getCPtr(pTime));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetStartKey(FbxAnimCurve pCurve) {
    int ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetStartKey(swigCPtr, FbxAnimCurve.getCPtr(pCurve));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetStopKey(FbxAnimCurve pCurve) {
    int ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetStopKey(swigCPtr, FbxAnimCurve.getCPtr(pCurve));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool NeedApply(FbxAnimStack pAnimStack, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_0(swigCPtr, FbxAnimStack.getCPtr(pAnimStack), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool NeedApply(FbxAnimStack pAnimStack) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_1(swigCPtr, FbxAnimStack.getCPtr(pAnimStack));
    return ret;
  }

  public virtual bool NeedApply(FbxObject pObj, FbxAnimStack pAnimStack, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_2(swigCPtr, FbxObject.getCPtr(pObj), FbxAnimStack.getCPtr(pAnimStack), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool NeedApply(FbxObject pObj, FbxAnimStack pAnimStack) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_3(swigCPtr, FbxObject.getCPtr(pObj), FbxAnimStack.getCPtr(pAnimStack));
    return ret;
  }

  public virtual bool NeedApply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_4(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool NeedApply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_5(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_6(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_7(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public virtual bool NeedApply(FbxAnimCurve pCurve, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_8(swigCPtr, FbxAnimCurve.getCPtr(pCurve), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool NeedApply(FbxAnimCurve pCurve) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_NeedApply__SWIG_9(swigCPtr, FbxAnimCurve.getCPtr(pCurve));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Apply(FbxAnimStack pAnimStack, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_0(swigCPtr, FbxAnimStack.getCPtr(pAnimStack), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool Apply(FbxAnimStack pAnimStack) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_1(swigCPtr, FbxAnimStack.getCPtr(pAnimStack));
    return ret;
  }

  public virtual bool Apply(FbxObject pObj, FbxAnimStack pAnimStack, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_2(swigCPtr, FbxObject.getCPtr(pObj), FbxAnimStack.getCPtr(pAnimStack), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool Apply(FbxObject pObj, FbxAnimStack pAnimStack) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_3(swigCPtr, FbxObject.getCPtr(pObj), FbxAnimStack.getCPtr(pAnimStack));
    return ret;
  }

  public virtual bool Apply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_4(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Apply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_5(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_6(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_7(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public virtual bool Apply(FbxAnimCurve pCurve, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_8(swigCPtr, FbxAnimCurve.getCPtr(pCurve), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Apply(FbxAnimCurve pCurve) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Apply__SWIG_9(swigCPtr, FbxAnimCurve.getCPtr(pCurve));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Reset() {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilter_Reset(swigCPtr);
  }

  public static bool GetContinuousOffset(FbxRotationOrder pOrder, FbxVector4 pOffset, FbxVector4 pNew, FbxVector4 pOld) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilter_GetContinuousOffset(FbxRotationOrder.getCPtr(pOrder), FbxVector4.getCPtr(pOffset), FbxVector4.getCPtr(pNew), FbxVector4.getCPtr(pOld));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
