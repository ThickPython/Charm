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

public class FbxNurbs : FbxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxNurbs(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxNurbs_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxNurbs obj) {
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
      FbxWrapperNativePINVOKE.FbxNurbs_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxNurbs_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxNurbs Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxNurbs ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbs(cPtr, false);
    return ret;
  }

  public new static FbxNurbs Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxNurbs ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbs(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)FbxWrapperNativePINVOKE.FbxNurbs_GetAttributeType(swigCPtr);
    return ret;
  }

  public void Reset() {
    FbxWrapperNativePINVOKE.FbxNurbs_Reset(swigCPtr);
  }

  public void SetSurfaceMode(FbxGeometry.ESurfaceMode pMode) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetSurfaceMode(swigCPtr, (int)pMode);
  }

  public FbxGeometry.ESurfaceMode GetSurfaceMode() {
    FbxGeometry.ESurfaceMode ret = (FbxGeometry.ESurfaceMode)FbxWrapperNativePINVOKE.FbxNurbs_GetSurfaceMode(swigCPtr);
    return ret;
  }

  public void InitControlPoints(int pUCount, FbxNurbs.EType pUType, int pVCount, FbxNurbs.EType pVType) {
    FbxWrapperNativePINVOKE.FbxNurbs_InitControlPoints__SWIG_0(swigCPtr, pUCount, (int)pUType, pVCount, (int)pVType);
  }

  public int GetUCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetUCount(swigCPtr);
    return ret;
  }

  public int GetVCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetVCount(swigCPtr);
    return ret;
  }

  public FbxNurbs.EType GetNurbsUType() {
    FbxNurbs.EType ret = (FbxNurbs.EType)FbxWrapperNativePINVOKE.FbxNurbs_GetNurbsUType(swigCPtr);
    return ret;
  }

  public FbxNurbs.EType GetNurbsVType() {
    FbxNurbs.EType ret = (FbxNurbs.EType)FbxWrapperNativePINVOKE.FbxNurbs_GetNurbsVType(swigCPtr);
    return ret;
  }

  public int GetUKnotCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetUKnotCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_double GetUKnotVector() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_GetUKnotVector(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public int GetVKnotCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetVKnotCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_double GetVKnotVector() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_GetVKnotVector(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_int GetUMultiplicityVector() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_GetUMultiplicityVector(swigCPtr);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_int GetVMultiplicityVector() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNurbs_GetVMultiplicityVector(swigCPtr);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public void SetOrder(uint pUOrder, uint pVOrder) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetOrder(swigCPtr, pUOrder, pVOrder);
  }

  public int GetUOrder() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetUOrder(swigCPtr);
    return ret;
  }

  public int GetVOrder() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetVOrder(swigCPtr);
    return ret;
  }

  public void SetStep(int pUStep, int pVStep) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetStep(swigCPtr, pUStep, pVStep);
  }

  public int GetUStep() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetUStep(swigCPtr);
    return ret;
  }

  public int GetVStep() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetVStep(swigCPtr);
    return ret;
  }

  public int GetUSpanCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetUSpanCount(swigCPtr);
    return ret;
  }

  public int GetVSpanCount() {
    int ret = FbxWrapperNativePINVOKE.FbxNurbs_GetVSpanCount(swigCPtr);
    return ret;
  }

  public void SetApplyFlipUV(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetApplyFlipUV(swigCPtr, pFlag);
  }

  public bool GetApplyFlipUV() {
    bool ret = FbxWrapperNativePINVOKE.FbxNurbs_GetApplyFlipUV(swigCPtr);
    return ret;
  }

  public void SetApplyFlipLinks(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetApplyFlipLinks(swigCPtr, pFlag);
  }

  public bool GetApplyFlipLinks() {
    bool ret = FbxWrapperNativePINVOKE.FbxNurbs_GetApplyFlipLinks(swigCPtr);
    return ret;
  }

  public bool GetApplyFlip() {
    bool ret = FbxWrapperNativePINVOKE.FbxNurbs_GetApplyFlip(swigCPtr);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(FbxWrapperNativePINVOKE.FbxNurbs_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetControlPointAt(FbxVector4 pCtrlPoint, int pIndex) {
    FbxWrapperNativePINVOKE.FbxNurbs_SetControlPointAt(swigCPtr, FbxVector4.getCPtr(pCtrlPoint), pIndex);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InitControlPoints(int pCount) {
    FbxWrapperNativePINVOKE.FbxNurbs_InitControlPoints__SWIG_1(swigCPtr, pCount);
  }

  public enum EType {
    ePeriodic,
    eClosed,
    eOpen
  }

  public enum EErrorCode {
    eNurbsTypeUnknown,
    eWrongNumberOfControlPoint,
    eWeightTooSmall,
    eUMultiplicityVectorError,
    eVMultiplicityVectorError,
    eUKnotVectorError,
    eVKnotVectorError,
    eErrorCount
  }

}

}
