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

public class FbxVector2 : FbxDouble2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxVector2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxVector2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxVector2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxVector2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxVector2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxVector2() : this(FbxWrapperNativePINVOKE.new_FbxVector2__SWIG_0(), true) {
  }

  public FbxVector2(FbxVector2 pVector2) : this(FbxWrapperNativePINVOKE.new_FbxVector2__SWIG_1(FbxVector2.getCPtr(pVector2)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector2(double pX, double pY) : this(FbxWrapperNativePINVOKE.new_FbxVector2__SWIG_2(pX, pY), true) {
  }

  public FbxVector2 assign(FbxVector2 pVector2) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_assign(swigCPtr, FbxVector2.getCPtr(pVector2)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(double pX, double pY) {
    FbxWrapperNativePINVOKE.FbxVector2_Set(swigCPtr, pX, pY);
  }

  public FbxVector2 add(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_add__SWIG_0(swigCPtr, pValue), true);
    return ret;
  }

  public FbxVector2 sub(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_sub__SWIG_0(swigCPtr, pValue), true);
    return ret;
  }

  public FbxVector2 mul(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_mul__SWIG_0(swigCPtr, pValue), true);
    return ret;
  }

  public FbxVector2 div(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_div__SWIG_0(swigCPtr, pValue), true);
    return ret;
  }

  public FbxVector2 add_assign(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_add_assign__SWIG_0(swigCPtr, pValue), false);
    return ret;
  }

  public FbxVector2 sub_assign(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_sub_assign__SWIG_0(swigCPtr, pValue), false);
    return ret;
  }

  public FbxVector2 mul_assign(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_mul_assign__SWIG_0(swigCPtr, pValue), false);
    return ret;
  }

  public FbxVector2 div_assign(double pValue) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_div_assign__SWIG_0(swigCPtr, pValue), false);
    return ret;
  }

  public FbxVector2 neg() {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_neg(swigCPtr), true);
    return ret;
  }

  public FbxVector2 add(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_add__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 sub(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_sub__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 mul(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_mul__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 div(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_div__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 add_assign(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_add_assign__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 sub_assign(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_sub_assign__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 mul_assign(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_mul_assign__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector2 div_assign(FbxVector2 pVector) {
    FbxVector2 ret = new FbxVector2(FbxWrapperNativePINVOKE.FbxVector2_div_assign__SWIG_1(swigCPtr, FbxVector2.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double DotProduct(FbxVector2 pVector) {
    double ret = FbxWrapperNativePINVOKE.FbxVector2_DotProduct(swigCPtr, FbxVector2.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(FbxVector2 pVector) {
    bool ret = FbxWrapperNativePINVOKE.FbxVector2_eq(swigCPtr, FbxVector2.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxVector2 pVector) {
    bool ret = FbxWrapperNativePINVOKE.FbxVector2_ne(swigCPtr, FbxVector2.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Length() {
    double ret = FbxWrapperNativePINVOKE.FbxVector2_Length(swigCPtr);
    return ret;
  }

  public double SquareLength() {
    double ret = FbxWrapperNativePINVOKE.FbxVector2_SquareLength(swigCPtr);
    return ret;
  }

  public double Distance(FbxVector2 pVector) {
    double ret = FbxWrapperNativePINVOKE.FbxVector2_Distance(swigCPtr, FbxVector2.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Normalize() {
    FbxWrapperNativePINVOKE.FbxVector2_Normalize(swigCPtr);
  }

  public SWIGTYPE_p_double ToDoublePtr() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVector2_ToDoublePtr(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_double ToConstDoublePtr() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxVector2_ToConstDoublePtr(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public bool IsZero(int pSize) {
    bool ret = FbxWrapperNativePINVOKE.FbxVector2_IsZero__SWIG_0(swigCPtr, pSize);
    return ret;
  }

  public bool IsZero() {
    bool ret = FbxWrapperNativePINVOKE.FbxVector2_IsZero__SWIG_1(swigCPtr);
    return ret;
  }

  public void FixIncorrectValue() {
    FbxWrapperNativePINVOKE.FbxVector2_FixIncorrectValue(swigCPtr);
  }

}

}
