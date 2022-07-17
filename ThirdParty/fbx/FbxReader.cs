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

public class FbxReader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxReader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxReader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxReader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxReader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void GetVersion(SWIGTYPE_p_int pMajor, SWIGTYPE_p_int pMinor, SWIGTYPE_p_int pRevision) {
    FbxWrapperNativePINVOKE.FbxReader_GetVersion(swigCPtr, SWIGTYPE_p_int.getCPtr(pMajor), SWIGTYPE_p_int.getCPtr(pMinor), SWIGTYPE_p_int.getCPtr(pRevision));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool FileOpen(string pFileName) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_FileOpen__SWIG_0(swigCPtr, pFileName);
    return ret;
  }

  public virtual bool FileOpen(FbxStream pStream, SWIGTYPE_p_void pStreamData) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_FileOpen__SWIG_1(swigCPtr, FbxStream.getCPtr(pStream), SWIGTYPE_p_void.getCPtr(pStreamData));
    return ret;
  }

  public virtual bool FileClose() {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_FileClose(swigCPtr);
    return ret;
  }

  public virtual bool IsFileOpen() {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_IsFileOpen(swigCPtr);
    return ret;
  }

  public virtual bool GetReadOptions(bool pParseFileAsNeeded) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetReadOptions__SWIG_0(swigCPtr, pParseFileAsNeeded);
    return ret;
  }

  public virtual bool GetReadOptions() {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetReadOptions__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool Read(FbxDocument pDocument) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_Read(swigCPtr, FbxDocument.getCPtr(pDocument));
    return ret;
  }

  public virtual void PluginReadParameters(FbxObject pParams) {
    FbxWrapperNativePINVOKE.FbxReader_PluginReadParameters(swigCPtr, FbxObject.getCPtr(pParams));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool FileOpen(string pFileName, FbxReader.EFileOpenSpecialFlags arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_FileOpen__SWIG_2(swigCPtr, pFileName, (int)arg1);
    return ret;
  }

  public virtual bool GetAxisInfo(FbxAxisSystem arg0, FbxSystemUnit arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetAxisInfo(swigCPtr, FbxAxisSystem.getCPtr(arg0), FbxSystemUnit.getCPtr(arg1));
    return ret;
  }

  public virtual bool GetStatistics(FbxStatistics arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetStatistics(swigCPtr, FbxStatistics.getCPtr(arg0));
    return ret;
  }

  public virtual bool GetFrameRate(SWIGTYPE_p_FbxTime__EMode pTimeMode) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetFrameRate(swigCPtr, SWIGTYPE_p_FbxTime__EMode.getCPtr(pTimeMode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FbxDocumentInfo GetSceneInfo() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxReader_GetSceneInfo(swigCPtr);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t GetTakeInfo() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxReader_GetTakeInfo(swigCPtr);
    SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxTakeInfo_p_t(cPtr, false);
    return ret;
  }

  public virtual bool GetDefaultRenderResolution(FbxString pCamName, FbxString pResolutionMode, SWIGTYPE_p_double pW, SWIGTYPE_p_double pH) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_GetDefaultRenderResolution(swigCPtr, FbxString.getCPtr(pCamName), FbxString.getCPtr(pResolutionMode), SWIGTYPE_p_double.getCPtr(pW), SWIGTYPE_p_double.getCPtr(pH));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsGenuine() {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_IsGenuine(swigCPtr);
    return ret;
  }

  public virtual FbxIOSettings GetIOSettings() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxReader_GetIOSettings(swigCPtr);
    FbxIOSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOSettings(cPtr, false);
    return ret;
  }

  public virtual void SetIOSettings(FbxIOSettings pIOSettings) {
    FbxWrapperNativePINVOKE.FbxReader_SetIOSettings(swigCPtr, FbxIOSettings.getCPtr(pIOSettings));
  }

  public virtual void SetProgressHandler(FbxProgress arg0) {
    FbxWrapperNativePINVOKE.FbxReader_SetProgressHandler(swigCPtr, FbxProgress.getCPtr(arg0));
  }

  public virtual void SetEmbeddingExtractionFolder(string arg0) {
    FbxWrapperNativePINVOKE.FbxReader_SetEmbeddingExtractionFolder(swigCPtr, arg0);
  }

  public virtual bool SupportsStreams() {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_SupportsStreams(swigCPtr);
    return ret;
  }

  public virtual bool FileOpen(FbxFile pFile) {
    bool ret = FbxWrapperNativePINVOKE.FbxReader_FileOpen__SWIG_3(swigCPtr, FbxFile.getCPtr(pFile));
    return ret;
  }

  public FbxStatus GetStatus() {
    FbxStatus ret = new FbxStatus(FbxWrapperNativePINVOKE.FbxReader_GetStatus(swigCPtr), false);
    return ret;
  }

  public enum EInfoRequest {
    eInfoExtension,
    eInfoDescriptions,
    eReserved1 = 0xFBFB
  }

  public enum EFileOpenSpecialFlags {
    eParseForGlobalSettings = 1,
    eParseForStatistics = 2
  }

}

}
