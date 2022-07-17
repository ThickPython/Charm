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

public class FbxRenamingStrategyUtils : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxRenamingStrategyUtils(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRenamingStrategyUtils obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxRenamingStrategyUtils() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxRenamingStrategyUtils(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool EncodeNonAlpha(FbxString pString, bool pFirstCharMustBeAlphaOnly, FbxString pPermittedChars, bool p8bitCharsOnly) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeNonAlpha__SWIG_0(FbxString.getCPtr(pString), pFirstCharMustBeAlphaOnly, FbxString.getCPtr(pPermittedChars), p8bitCharsOnly);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeNonAlpha(FbxString pString, bool pFirstCharMustBeAlphaOnly, FbxString pPermittedChars) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeNonAlpha__SWIG_1(FbxString.getCPtr(pString), pFirstCharMustBeAlphaOnly, FbxString.getCPtr(pPermittedChars));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeNonAlpha(FbxString pString, bool pFirstCharMustBeAlphaOnly) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeNonAlpha__SWIG_2(FbxString.getCPtr(pString), pFirstCharMustBeAlphaOnly);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeNonAlpha(FbxString pString) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeNonAlpha__SWIG_3(FbxString.getCPtr(pString));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DecodeNonAlpha(FbxString pString) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_DecodeNonAlpha(FbxString.getCPtr(pString));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeDuplicate(FbxString pString, int pInstanceNumber) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeDuplicate__SWIG_0(FbxString.getCPtr(pString), pInstanceNumber);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeDuplicate(FbxString pString) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeDuplicate__SWIG_1(FbxString.getCPtr(pString));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DecodeDuplicate(FbxString pString) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_DecodeDuplicate(FbxString.getCPtr(pString));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EncodeCaseInsensitive(FbxString pString, FbxString pString2) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_EncodeCaseInsensitive(FbxString.getCPtr(pString), FbxString.getCPtr(pString2));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DecodeCaseInsensitive(FbxString pString) {
    bool ret = FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_DecodeCaseInsensitive(FbxString.getCPtr(pString));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxString NoPrefixName(string pName) {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_NoPrefixName__SWIG_0(pName), true);
    return ret;
  }

  public static FbxString NoPrefixName(FbxString pName) {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxRenamingStrategyUtils_NoPrefixName__SWIG_1(FbxString.getCPtr(pName)), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxRenamingStrategyUtils() : this(FbxWrapperNativePINVOKE.new_FbxRenamingStrategyUtils(), true) {
  }

}

}
