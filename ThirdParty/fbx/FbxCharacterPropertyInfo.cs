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

public class FbxCharacterPropertyInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxCharacterPropertyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCharacterPropertyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxCharacterPropertyInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxCharacterPropertyInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string mHIKPropertyName {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mHIKPropertyName_set(swigCPtr, value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mHIKPropertyName_get(swigCPtr);
      return ret;
    } 
  }

  public string mFbxCharacterPropertyModeName {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyModeName_set(swigCPtr, value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyModeName_get(swigCPtr);
      return ret;
    } 
  }

  public string mFbxCharacterPropertyName {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyName_set(swigCPtr, value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyName_get(swigCPtr);
      return ret;
    } 
  }

  public int mIndex {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mIndex_set(swigCPtr, value);
    } 
    get {
      int ret = FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mIndex_get(swigCPtr);
      return ret;
    } 
  }

  public FbxCharacter.EPropertyUnit mUnit {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mUnit_set(swigCPtr, (int)value);
    } 
    get {
      FbxCharacter.EPropertyUnit ret = (FbxCharacter.EPropertyUnit)FbxWrapperNativePINVOKE.FbxCharacterPropertyInfo_mUnit_get(swigCPtr);
      return ret;
    } 
  }

  public FbxCharacterPropertyInfo() : this(FbxWrapperNativePINVOKE.new_FbxCharacterPropertyInfo(), true) {
  }

}

}
