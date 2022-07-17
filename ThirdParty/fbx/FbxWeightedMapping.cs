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

public class FbxWeightedMapping : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxWeightedMapping(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxWeightedMapping obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxWeightedMapping() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxWeightedMapping(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class Element : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Element(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Element obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Element() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            FbxWrapperNativePINVOKE.delete_FbxWeightedMapping_Element(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public int mIndex {
      set {
        FbxWrapperNativePINVOKE.FbxWeightedMapping_Element_mIndex_set(swigCPtr, value);
      } 
      get {
        int ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_Element_mIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public double mWeight {
      set {
        FbxWrapperNativePINVOKE.FbxWeightedMapping_Element_mWeight_set(swigCPtr, value);
      } 
      get {
        double ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_Element_mWeight_get(swigCPtr);
        return ret;
      } 
    }
  
    public Element() : this(FbxWrapperNativePINVOKE.new_FbxWeightedMapping_Element(), true) {
    }
  
  }

  public FbxWeightedMapping(int pSourceSize, int pDestinationSize) : this(FbxWrapperNativePINVOKE.new_FbxWeightedMapping(pSourceSize, pDestinationSize), true) {
  }

  public void Reset(int pSourceSize, int pDestinationSize) {
    FbxWrapperNativePINVOKE.FbxWeightedMapping_Reset(swigCPtr, pSourceSize, pDestinationSize);
  }

  public void Add(int pSourceIndex, int pDestinationIndex, double pWeight) {
    FbxWrapperNativePINVOKE.FbxWeightedMapping_Add(swigCPtr, pSourceIndex, pDestinationIndex, pWeight);
  }

  public int GetElementCount(FbxWeightedMapping.ESet pSet) {
    int ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_GetElementCount(swigCPtr, (int)pSet);
    return ret;
  }

  public int GetRelationCount(FbxWeightedMapping.ESet pSet, int pElement) {
    int ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_GetRelationCount(swigCPtr, (int)pSet, pElement);
    return ret;
  }

  public FbxWeightedMapping.Element GetRelation(FbxWeightedMapping.ESet pSet, int pElement, int pIndex) {
    FbxWeightedMapping.Element ret = new FbxWeightedMapping.Element(FbxWrapperNativePINVOKE.FbxWeightedMapping_GetRelation(swigCPtr, (int)pSet, pElement, pIndex), false);
    return ret;
  }

  public int GetRelationIndex(FbxWeightedMapping.ESet pSet, int pElementInSet, int pElementInOtherSet) {
    int ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_GetRelationIndex(swigCPtr, (int)pSet, pElementInSet, pElementInOtherSet);
    return ret;
  }

  public double GetRelationSum(FbxWeightedMapping.ESet pSet, int pElement, bool pAbsoluteValue) {
    double ret = FbxWrapperNativePINVOKE.FbxWeightedMapping_GetRelationSum(swigCPtr, (int)pSet, pElement, pAbsoluteValue);
    return ret;
  }

  public void Normalize(FbxWeightedMapping.ESet pSet, bool pAbsoluteValue) {
    FbxWrapperNativePINVOKE.FbxWeightedMapping_Normalize(swigCPtr, (int)pSet, pAbsoluteValue);
  }

  public FbxWeightedMapping assign(FbxWeightedMapping pWMap) {
    FbxWeightedMapping ret = new FbxWeightedMapping(FbxWrapperNativePINVOKE.FbxWeightedMapping_assign(swigCPtr, FbxWeightedMapping.getCPtr(pWMap)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ESet {
    eSource,
    eDestination
  }

}

}
