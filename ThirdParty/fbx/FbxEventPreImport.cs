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

public class FbxEventPreImport : FbxEventFbxEventPreImport {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxEventPreImport(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxEventPreImport_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventPreImport obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventPreImport() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxEventPreImport(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string GetEventName() {
    string ret = FbxWrapperNativePINVOKE.FbxEventPreImport_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventPreImport(FbxDocument pDocument) : this(FbxWrapperNativePINVOKE.new_FbxEventPreImport(FbxDocument.getCPtr(pDocument)), true) {
  }

  public FbxDocument mDocument {
    set {
      FbxWrapperNativePINVOKE.FbxEventPreImport_mDocument_set(swigCPtr, FbxDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEventPreImport_mDocument_get(swigCPtr);
      FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
      return ret;
    } 
  }

}

}
