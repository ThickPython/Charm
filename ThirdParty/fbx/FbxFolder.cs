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

public class FbxFolder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxFolder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxFolder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxFolder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxFolder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool Open(string pFolderPath_UTF8) {
    bool ret = FbxWrapperNativePINVOKE.FbxFolder_Open(swigCPtr, pFolderPath_UTF8);
    return ret;
  }

  public bool Next() {
    bool ret = FbxWrapperNativePINVOKE.FbxFolder_Next(swigCPtr);
    return ret;
  }

  public FbxFolder.EEntryType GetEntryType() {
    FbxFolder.EEntryType ret = (FbxFolder.EEntryType)FbxWrapperNativePINVOKE.FbxFolder_GetEntryType(swigCPtr);
    return ret;
  }

  public FbxString GetEntryName() {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxFolder_GetEntryName(swigCPtr), true);
    return ret;
  }

  public string GetEntryExtension() {
    string ret = FbxWrapperNativePINVOKE.FbxFolder_GetEntryExtension(swigCPtr);
    return ret;
  }

  public void Close() {
    FbxWrapperNativePINVOKE.FbxFolder_Close(swigCPtr);
  }

  public bool IsOpen() {
    bool ret = FbxWrapperNativePINVOKE.FbxFolder_IsOpen(swigCPtr);
    return ret;
  }

  public FbxFolder() : this(FbxWrapperNativePINVOKE.new_FbxFolder(), true) {
  }

  public enum EEntryType {
    eRegularEntry,
    eFolderEntry
  }

}

}
