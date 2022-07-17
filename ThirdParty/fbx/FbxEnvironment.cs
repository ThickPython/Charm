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

public class FbxEnvironment : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxEnvironment(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxEnvironment_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEnvironment obj) {
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
      FbxWrapperNativePINVOKE.FbxEnvironment_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEnvironment_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxEnvironment_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxEnvironment Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEnvironment_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxEnvironment ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxEnvironment(cPtr, false);
    return ret;
  }

  public new static FbxEnvironment Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEnvironment_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxEnvironment ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxEnvironment(cPtr, false);
    return ret;
  }

  public bool ProvidesLighting() {
    bool ret = FbxWrapperNativePINVOKE.FbxEnvironment_ProvidesLighting(swigCPtr);
    return ret;
  }

}

}
