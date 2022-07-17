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

public class FloatArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FloatArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FloatArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FloatArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FloatArray(int nelements) : this(FbxWrapperNativePINVOKE.new_FloatArray(nelements), true) {
  }

  public float getitem(int index) {
    float ret = FbxWrapperNativePINVOKE.FloatArray_getitem(swigCPtr, index);
    return ret;
  }

  public void setitem(int index, float value) {
    FbxWrapperNativePINVOKE.FloatArray_setitem(swigCPtr, index, value);
  }

  public SWIGTYPE_p_float cast() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FloatArray_cast(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public static FloatArray frompointer(SWIGTYPE_p_float t) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FloatArray_frompointer(SWIGTYPE_p_float.getCPtr(t));
    FloatArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new FloatArray(cPtr, false);
    return ret;
  }

}

}
