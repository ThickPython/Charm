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

public class FbxLimitsUtilities : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxLimitsUtilities(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLimitsUtilities obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLimitsUtilities() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxLimitsUtilities(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxLimitsUtilities(FbxNode pNode) : this(FbxWrapperNativePINVOKE.new_FbxLimitsUtilities(FbxNode.getCPtr(pNode)), true) {
  }

  public void SetAuto(FbxLimitsUtilities.EType pType, bool pAuto) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetAuto(swigCPtr, (int)pType, pAuto);
  }

  public bool GetAuto(FbxLimitsUtilities.EType pType) {
    bool ret = FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetAuto(swigCPtr, (int)pType);
    return ret;
  }

  public void SetEnable(FbxLimitsUtilities.EType pType, bool pEnable) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetEnable(swigCPtr, (int)pType, pEnable);
  }

  public bool GetEnable(FbxLimitsUtilities.EType pType) {
    bool ret = FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetEnable(swigCPtr, (int)pType);
    return ret;
  }

  public void SetDefault(FbxLimitsUtilities.EType pType, FbxVector4 pDefault) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetDefault(swigCPtr, (int)pType, FbxVector4.getCPtr(pDefault));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetDefault(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetDefault(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetMin(FbxLimitsUtilities.EType pType, FbxVector4 pMin) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetMin(swigCPtr, (int)pType, FbxVector4.getCPtr(pMin));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetMin(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetMin(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetMax(FbxLimitsUtilities.EType pType, FbxVector4 pMax) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetMax(swigCPtr, (int)pType, FbxVector4.getCPtr(pMax));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetMax(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetMax(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetRotationType(FbxLimitsUtilities.ERotationType pType) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetRotationType(swigCPtr, (int)pType);
  }

  public FbxLimitsUtilities.ERotationType GetRotationType() {
    FbxLimitsUtilities.ERotationType ret = (FbxLimitsUtilities.ERotationType)FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetRotationType(swigCPtr);
    return ret;
  }

  public FbxLimitsUtilities.ERotationClampType GetRotationClampType() {
    FbxLimitsUtilities.ERotationClampType ret = (FbxLimitsUtilities.ERotationClampType)FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetRotationClampType(swigCPtr);
    return ret;
  }

  public void SetRotationAxis(FbxVector4 pRotationAxis) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetRotationAxis(swigCPtr, FbxVector4.getCPtr(pRotationAxis));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetRotationAxis() {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetRotationAxis(swigCPtr), true);
    return ret;
  }

  public void SetAxisLength(double pLength) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_SetAxisLength(swigCPtr, pLength);
  }

  public double GetAxisLength() {
    double ret = FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetAxisLength(swigCPtr);
    return ret;
  }

  public void UpdateAutomatic(FbxNode pNode) {
    FbxWrapperNativePINVOKE.FbxLimitsUtilities_UpdateAutomatic(swigCPtr, FbxNode.getCPtr(pNode));
  }

  public FbxVector4 GetEndPointTranslation(FbxNode pNode) {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetEndPointTranslation(swigCPtr, FbxNode.getCPtr(pNode)), true);
    return ret;
  }

  public FbxVector4 GetEndSite(FbxNode pNode) {
    FbxVector4 ret = new FbxVector4(FbxWrapperNativePINVOKE.FbxLimitsUtilities_GetEndSite(swigCPtr, FbxNode.getCPtr(pNode)), true);
    return ret;
  }

  public FbxNode mNode {
    set {
      FbxWrapperNativePINVOKE.FbxLimitsUtilities_mNode_set(swigCPtr, FbxNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLimitsUtilities_mNode_get(swigCPtr);
      FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
      return ret;
    } 
  }

  public double mAxisLength {
    set {
      FbxWrapperNativePINVOKE.FbxLimitsUtilities_mAxisLength_set(swigCPtr, value);
    } 
    get {
      double ret = FbxWrapperNativePINVOKE.FbxLimitsUtilities_mAxisLength_get(swigCPtr);
      return ret;
    } 
  }

  public enum EType {
    eTranslation,
    eRotation,
    eScaling
  }

  public enum ERotationType {
    eQuaternion,
    eEuler
  }

  public enum ERotationClampType {
    eRectangular,
    eEllipsoid
  }

}

}