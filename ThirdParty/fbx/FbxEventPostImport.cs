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

public class FbxEventPostImport : FbxEventFbxEventPostImport {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxEventPostImport(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxEventPostImport_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventPostImport obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventPostImport() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxEventPostImport(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string GetEventName() {
    string ret = FbxWrapperNativePINVOKE.FbxEventPostImport_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventPostImport(FbxDocument pDocument) : this(FbxWrapperNativePINVOKE.new_FbxEventPostImport(FbxDocument.getCPtr(pDocument)), true) {
  }

  public FbxDocument mDocument {
    set {
      FbxWrapperNativePINVOKE.FbxEventPostImport_mDocument_set(swigCPtr, FbxDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEventPostImport_mDocument_get(swigCPtr);
      FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
      return ret;
    } 
  }

}

}
