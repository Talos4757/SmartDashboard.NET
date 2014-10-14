// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_legacy
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv.cpp
{
  public class opencv_legacy : Object
  {
    public const int CV_EIGOBJ_NO_CALLBACK = 0;
    public const int CV_EIGOBJ_INPUT_CALLBACK = 1;
    public const int CV_EIGOBJ_OUTPUT_CALLBACK = 2;
    public const int CV_EIGOBJ_BOTH_CALLBACK = 3;
    public const int CV_NOT_WEIGHTED = 0;
    public const int CV_WEIGHTED_VTX = 1;
    public const int CV_WEIGHTED_EDGE = 2;
    public const int CV_WEIGHTED_ALL = 3;
    public const int CV_DOMINANT_IPAN = 1;
    public const int CLIQUE_TIME_OFF = 2;
    public const int CLIQUE_FOUND = 1;
    public const int CLIQUE_END = 0;
    public const int CV_UNDEF_SC_PARAM = 12345;
    public const int CV_IDP_BIRCHFIELD_PARAM1 = 25;
    public const int CV_IDP_BIRCHFIELD_PARAM2 = 5;
    public const int CV_IDP_BIRCHFIELD_PARAM3 = 12;
    public const int CV_IDP_BIRCHFIELD_PARAM4 = 15;
    public const int CV_IDP_BIRCHFIELD_PARAM5 = 25;
    public const int CV_DISPARITY_BIRCHFIELD = 0;
    public const int CV_CAMERA_TO_WARP = 1;
    public const int CV_WARP_TO_CAMERA = 2;
    public const int CV_CONTOUR_TREES_MATCH_I1 = 1;
    public const int CV_VALUE = 1;
    public const int CV_ARRAY = 2;
    public const int CV_GLCM_OPTIMIZATION_NONE = -2;
    public const int CV_GLCM_OPTIMIZATION_LUT = -1;
    public const int CV_GLCM_OPTIMIZATION_HISTOGRAM = 0;
    public const int CV_GLCMDESC_OPTIMIZATION_ALLOWDOUBLENEST = 10;
    public const int CV_GLCMDESC_OPTIMIZATION_ALLOWTRIPLENEST = 11;
    public const int CV_GLCMDESC_OPTIMIZATION_HISTOGRAM = 4;
    public const int CV_GLCMDESC_ENTROPY = 0;
    public const int CV_GLCMDESC_ENERGY = 1;
    public const int CV_GLCMDESC_HOMOGENITY = 2;
    public const int CV_GLCMDESC_CONTRAST = 3;
    public const int CV_GLCMDESC_CLUSTERTENDENCY = 4;
    public const int CV_GLCMDESC_CLUSTERSHADE = 5;
    public const int CV_GLCMDESC_CORRELATION = 6;
    public const int CV_GLCMDESC_CORRELATIONINFO1 = 7;
    public const int CV_GLCMDESC_CORRELATIONINFO2 = 8;
    public const int CV_GLCMDESC_MAXIMUMPROBABILITY = 9;
    public const int CV_GLCM_ALL = 0;
    public const int CV_GLCM_GLCM = 1;
    public const int CV_GLCM_DESC = 2;
    public const int CV_NUM_FACE_ELEMENTS = 3;
    public const int CV_FACE_MOUTH = 0;
    public const int CV_FACE_LEFT_EYE = 1;
    public const int CV_FACE_RIGHT_EYE = 2;
    public const int CV_LEE_INT = 0;
    public const int CV_LEE_FLOAT = 1;
    public const int CV_LEE_DOUBLE = 2;
    public const int CV_LEE_AUTO = -1;
    public const int CV_LEE_ERODE = 0;
    public const int CV_LEE_ZOOM = 1;
    public const int CV_LEE_NON = 2;
    static IntPtr __\u003Cjniptr\u003EcvSegmentImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcDecompCoeff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreate2DHMM\u0028\u005BI\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRelease2DHMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUniformImgSegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitMixSegm\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEstimateHMMStateParams\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEstimateTransProb\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEstimateObsProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEViterbi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029F;
    static IntPtr __\u003Cjniptr\u003EcvMixSegmL2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateHandMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcImageHomography\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003B\u005BF\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcImageHomography\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvDrawMosaic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvSubdiv2DCheck\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCalcPGH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindDominantPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDDDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFindStereoCorrespondence\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetSymPoint3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetPieceLength3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvCompute3DPoint\u0028DDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028\u005BD\u005BD\u005BD\u005BD\u005BD\u005BD\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvComputeCoeffForStereo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossPieceVector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossLineDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BFFFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvDefinePointPosition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029F;
    static IntPtr __\u003Cjniptr\u003EicvStereoCalibration\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvComputeRestStereoParams\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvComputePerspectiveMap\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvComputePerspectiveMap\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossLines\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvComputeStereoLineCoeffs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetAngleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EicvGetCoefForPiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossPieceDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossPiecePiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetPieceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCrossRectDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetQuadsTransformStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvComputeStereoParamsForCameras\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCutPiece\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetCutPiece\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetMiddleAnglePoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetNormalDirect\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetNormalDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetVect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EicvCreateIsometricImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvDeInterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003B;
    static IntPtr __\u003Cjniptr\u003EcvContourFromContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMatchContourTrees\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BID\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u005BF\u005BF\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u005BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateGLCMDescriptors\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetGLCMDescriptor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetGLCMDescriptorStatistics\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u005BD\u005BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateGLCMImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B;
    static IntPtr __\u003Cjniptr\u003EcvTrackFace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BD\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvReleaseFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Ecv3dTrackerCalibrateCameras\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraIntrinsics\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003B\u0029Z;
    static IntPtr __\u003Cjniptr\u003Ecv3dTrackerLocateObjects\u0028IILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTracker2dTrackedObject\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerTrackedObject\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvVoronoiDiagramFromContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIII\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvVoronoiDiagramFromImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIF\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvReleaseVoronoiStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLinearContorModelFromVoronoiDiagram\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseLinearContorModelStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMakeScanlines\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMakeScanlines\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPreWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindRuns\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDynamicCorrespondMulti\u0028I\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMakeAlphaScanlines\u0028\u005BI\u005BI\u005BI\u005BIIF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMorphEpilinesMulti\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BIF\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPostWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDeleteMoire\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateConDensation\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseConDensation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvConDensUpdateByTime\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvConDensInitSampleSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;

    [LineNumberTable((ushort) 90)]
    static opencv_legacy()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<opencv_features2d>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 232, (byte) 164, (byte) 47})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_legacy()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 94)]
    public static float cvQueryHistValue_1D(object hist, int idx0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 97)]
    public static float cvQueryHistValue_2D(object hist, int idx0, int idx1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 100)]
    public static float cvQueryHistValue_3D(object hist, int idx0, int idx1, int idx2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 103)]
    public static float cvQueryHistValue_nD(object hist, int idx0, int[] idx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 107)]
    public static object cvGetHistValue_1D(object hist, int idx0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 110)]
    public static object cvGetHistValue_2D(object hist, int idx0, int idx1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 113)]
    public static object cvGetHistValue_3D(object hist, int idx0, int idx1, int idx2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 116)]
    public static object cvGetHistValue_nD(object hist, int idx0, int[] idx)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [Modifiers]
    public static object cvSegmentImage(object ca1, object ca2, double d1, double d2, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvSegmentImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvSegmentImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvSegmentImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDLcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, double, double, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvSegmentImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, (double) num3, (double) num4, num5, (IntPtr) num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcCovarMatrixEx(int i1, object p1, int i2, int i3, object bp, object p2, object ii, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcCovarMatrixEx", "(ILcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V)(num2, num3, (IntPtr) num4, num5, num6, num7, num8, (int) num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcEigenObjects(int i1, object p1, object p2, int i2, int i3, object p3, object ctc, object ii, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcEigenObjects", "(ILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        int num7 = i2;
        int num8 = i3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V)(num2, num3, (IntPtr) num4, num5, (int) num6, num7, (IntPtr) num8, num9, (int) num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvCalcDecompCoeff(object ii1, object ii2, object ii3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcDecompCoeff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029D == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcDecompCoeff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcDecompCoeff", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ii3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcDecompCoeff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029D)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEigenDecomposite(object ii1, int i1, object p1, int i2, object p2, object ii2, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEigenDecomposite", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;ILcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BF\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEigenProjection(object p1, int i1, int i2, object p2, float[] farr, object ii1, object ii2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEigenProjection", "(Lcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/Pointer;[FLcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcCovarMatrixEx(int i1, object p1, int i2, int i3, object bp, object p2, object ii, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcCovarMatrixEx", "(ILcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num6 = i2;
        int num7 = i3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcCovarMatrixEx\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, (IntPtr) num4, num5, num6, num7, num8, (int) num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcEigenObjects(int i1, object p1, object p2, int i2, int i3, object p3, object ctc, object ii, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcEigenObjects", "(ILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        int num7 = i2;
        int num8 = i3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcEigenObjects\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, (IntPtr) num4, num5, (int) num6, num7, (IntPtr) num8, num9, (int) num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEigenDecomposite(object ii1, int i1, object p1, int i2, object p2, object ii2, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEigenDecomposite", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;ILcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEigenDecomposite\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEigenProjection(object p1, int i1, int i2, object p2, FloatBuffer fb, object ii1, object ii2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEigenProjection", "(Lcom/googlecode/javacpp/Pointer;IILcom/googlecode/javacpp/Pointer;Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEigenProjection\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4, (IntPtr) num5, num6, (int) num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreate2DHMM(int[] iarr1, int[] iarr2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreate2DHMM\u0028\u005BI\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreate2DHMM\u0028\u005BI\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreate2DHMM", "([I[II)Lcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreate2DHMM\u0028\u005BI\u005BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvRelease2DHMM(object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvRelease2DHMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvRelease2DHMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvRelease2DHMM", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvRelease2DHMM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 277)]
    public static void CV_COUNT_OBS(object roi, object win, object delta, object numObs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(win, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(delta, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(numObs, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSize");
    }

    [Modifiers]
    public static object cvCreateObsInfo(object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateObsInfo", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;I)Lcom/googlecode/javacv/cpp/opencv_legacy$CvImgObsInfo;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseObsInfo(object cioi)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseObsInfo", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvImgObsInfo;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cioi);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseObsInfo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvImgToObs_DCT(object ca, float[] farr, object cs1, object cs2, object cs3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvImgToObs_DCT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[FLcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvImgToObs_DCT(object ca, FloatBuffer fb, object cs1, object cs2, object cs3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvImgToObs_DCT", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvImgToObs_DCT\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvUniformImgSegm(object cioi, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvUniformImgSegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvUniformImgSegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvUniformImgSegm", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvImgObsInfo;Lcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cioi);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvUniformImgSegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInitMixSegm(object pp, int i, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvInitMixSegm\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvInitMixSegm\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvInitMixSegm", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvInitMixSegm\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEstimateHMMStateParams(object pp, int i, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEstimateHMMStateParams\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEstimateHMMStateParams\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEstimateHMMStateParams", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEstimateHMMStateParams\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEstimateTransProb(object pp, int i, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEstimateTransProb\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEstimateTransProb\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEstimateTransProb", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEstimateTransProb\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvEstimateObsProb(object cioi, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEstimateObsProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEstimateObsProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEstimateObsProb", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvImgObsInfo;Lcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cioi);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEstimateObsProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static float cvEViterbi(object cioi, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvEViterbi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029F == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvEViterbi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029F = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvEViterbi", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvImgObsInfo;Lcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cioi);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvEViterbi\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvImgObsInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029F)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMixSegmL2(object pp, int i, object cehmm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMixSegmL2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMixSegmL2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMixSegmL2", "(Lcom/googlecode/javacpp/PointerPointer;ILcom/googlecode/javacv/cpp/opencv_legacy$CvEHMM;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cehmm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvMixSegmL2\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvEHMM\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCreateHandMask(object cs, object ii, object cr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateHandMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateHandMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateHandMask", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateHandMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindHandRegion(object cpd1, int i1, object cs1, float[] farr, object csd, int i2, object cpd2, object cms, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindHandRegion", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSeq;[FLcom/googlecode/javacv/cpp/opencv_core$CvSize2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindHandRegionA(object cpd1, int i1, object cs1, float[] farr, object csd, int i2, object cpd2, object cms, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindHandRegionA", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSeq;[FLcom/googlecode/javacv/cpp/opencv_core$CvSize2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindHandRegion(object cpd1, int i1, object cs1, FloatBuffer fb, object csd, int i2, object cpd2, object cms, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindHandRegion", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSeq;Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvSize2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindHandRegionA(object cpd1, int i1, object cs1, FloatBuffer fb, object csd, int i2, object cpd2, object cms, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindHandRegionA", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSeq;Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvSize2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvFindHandRegionA\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcImageHomography(float[] farr1, object cpd, float[] farr2, float[] farr3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003B\u005BF\u005BF\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003B\u005BF\u005BF\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcImageHomography", "([FLcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;[F[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003B\u005BF\u005BF\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCalcImageHomography(FloatBuffer fb1, object cpd, FloatBuffer fb2, FloatBuffer fb3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcImageHomography", "(Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) fb3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcImageHomography\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvDrawMosaic(object csd, object ii1, object ii2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvDrawMosaic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvDrawMosaic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvDrawMosaic", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvDrawMosaic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvSubdiv2DCheck(object csd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvSubdiv2DCheck\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvSubdiv2DCheck\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvSubdiv2DCheck", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvSubdiv2DCheck\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 324)]
    public static double icvSqDist2D32f(object pt1, object pt2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt1, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt2, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
    }

    [LineNumberTable((ushort) 331)]
    public static int CV_CURRENT_INT(object reader)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reader, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      throw new NoClassDefFoundError("com.googlecode.javacpp.IntPointer");
    }

    [LineNumberTable((ushort) 332)]
    public static int CV_PREV_INT(object reader)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reader, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvSeqReader");
      throw new NoClassDefFoundError("com.googlecode.javacpp.IntPointer");
    }

    [Modifiers]
    public static void cvCalcPGH(object cs, object ch)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCalcPGH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCalcPGH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCalcPGH", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvCalcPGH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvFindDominantPoints(object cs, object cms, int i, double d1, double d2, double d3, double d4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindDominantPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDDDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindDominantPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDDDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindDominantPoints", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;IDDDD)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num6 = i;
        double num7 = d1;
        double num8 = d2;
        double num9 = d3;
        double num10 = d4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, double, double, double, double)>) opencv_legacy.__\u003Cjniptr\u003EcvFindDominantPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDDDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((double) num2, (double) num3, (double) num4, (double) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindStereoCorrespondence(object ca1, object ca2, int i1, object ca3, int i2, double d1, double d2, double d3, double d4, double d5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindStereoCorrespondence\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDDD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindStereoCorrespondence\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDDD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindStereoCorrespondence", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;IDDDDD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num8 = i2;
        double num9 = d1;
        double num10 = d2;
        double num11 = d3;
        double num12 = d4;
        double num13 = d5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, double, double, double, double, double)>) opencv_legacy.__\u003Cjniptr\u003EcvFindStereoCorrespondence\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDDD\u0029V)((double) num2, (double) num3, (double) num4, (double) num5, (double) num6, (int) num7, (IntPtr) num8, (int) num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12, (IntPtr) num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvConvertWarpCoordinates(double[] darr, object cpd1, object cpd2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvConvertWarpCoordinates", "([DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvConvertWarpCoordinates(DoubleBuffer db, object cpd1, object cpd2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvConvertWarpCoordinates", "(Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EicvConvertWarpCoordinates\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetSymPoint3D(object cpd1, object cpd2, object cpd3, object cpd4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetSymPoint3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetSymPoint3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetSymPoint3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetSymPoint3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetPieceLength3D(object cpd1, object cpd2, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetPieceLength3D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength3D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvCompute3DPoint(double d1, double d2, object cslc, object cpd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvCompute3DPoint\u0028DDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvCompute3DPoint\u0028DDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvCompute3DPoint", "(DDLcom/googlecode/javacv/cpp/opencv_legacy$CvStereoLineCoeff;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        double num4 = d1;
        double num5 = d2;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cslc);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, double, double, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvCompute3DPoint\u0028DDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvCreateConvertMatrVect(double[] darr1, double[] darr2, double[] darr3, double[] darr4, double[] darr5, double[] darr6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028\u005BD\u005BD\u005BD\u005BD\u005BD\u005BD\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028\u005BD\u005BD\u005BD\u005BD\u005BD\u005BD\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvCreateConvertMatrVect", "([D[D[D[D[D[D)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) darr5);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) darr6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028\u005BD\u005BD\u005BD\u005BD\u005BD\u005BD\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvConvertPointSystem(object cpd1, object cpd2, double[] darr1, double[] darr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvConvertPointSystem", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;[D[D)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvCreateConvertMatrVect(DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, DoubleBuffer db4, DoubleBuffer db5, DoubleBuffer db6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvCreateConvertMatrVect", "(Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) db4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) db5);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) db6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvCreateConvertMatrVect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvConvertPointSystem(object cpd1, object cpd2, DoubleBuffer db1, DoubleBuffer db2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvConvertPointSystem", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvConvertPointSystem\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvComputeCoeffForStereo(object csc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeCoeffForStereo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeCoeffForStereo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeCoeffForStereo", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoCamera;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeCoeffForStereo\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetCrossPieceVector(object cpd1, object cpd2, object cpd3, object cpd4, object cpd5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceVector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceVector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossPieceVector", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceVector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetCrossLineDirect(object cpd1, object cpd2, float f1, float f2, float f3, object cpd3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLineDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BFFFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLineDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BFFFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossLineDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;FFFLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        double num6 = (double) f1;
        double num7 = (double) f2;
        double num8 = (double) f3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, float, float, float, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLineDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BFFFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029I)(num2, (float) num3, (float) num4, (float) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static float icvDefinePointPosition(object cpd1, object cpd2, object cpd3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvDefinePointPosition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029F == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvDefinePointPosition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029F = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvDefinePointPosition", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvDefinePointPosition\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029F)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvStereoCalibration(int i, int[] iarr, object cs, object cpd1, object cpd2, object cpd3, object csc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvStereoCalibration\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvStereoCalibration\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvStereoCalibration", "(I[ILcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D32f;Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoCamera;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(csc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvStereoCalibration\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I)(num2, num3, (IntPtr) num4, num5, num6, num7, (int) num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvComputeRestStereoParams(object csc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeRestStereoParams\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeRestStereoParams\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeRestStereoParams", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoCamera;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeRestStereoParams\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvComputePerspectiveMap(double[] darr, object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvComputePerspectiveMap", "([DLcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvComputePerspectiveMap(DoubleBuffer db, object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvComputePerspectiveMap", "(Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvComputePerspectiveMap\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvComCoeffForLine(object cpd1, object cpd2, object cpd3, object cpd4, double[] darr1, double[] darr2, double[] darr3, double[] darr4, double[] darr5, double[] darr6, object cslc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComCoeffForLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[D[D[D[D[D[DLcom/googlecode/javacv/cpp/opencv_legacy$CvStereoLineCoeff;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) darr4);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) darr5);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) darr6);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef(cslc);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvComCoeffForLine(object cpd1, object cpd2, object cpd3, object cpd4, DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, DoubleBuffer db4, DoubleBuffer db5, DoubleBuffer db6, object cslc, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComCoeffForLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoLineCoeff;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) db4);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) db5);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) db6);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef(cslc);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComCoeffForLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetDirectionForPoint(object cpd1, double[] darr, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetDirectionForPoint", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetDirectionForPoint(object cpd1, DoubleBuffer db, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetDirectionForPoint", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetDirectionForPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetCrossLines(object cpd1, object cpd2, object cpd3, object cpd4, object cpd5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLines\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLines\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossLines", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossLines\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvComputeStereoLineCoeffs(object cpd1, object cpd2, object cpd3, double d, object cslc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoLineCoeffs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoLineCoeffs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeStereoLineCoeffs", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;DLcom/googlecode/javacv/cpp/opencv_legacy$CvStereoLineCoeff;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        double num7 = d;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cslc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoLineCoeffs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoLineCoeff\u003B\u0029I)(num2, (double) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int icvGetAngleLine(object cpd1, object cs, object cpd2, object cpd3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetAngleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetAngleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetAngleLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetAngleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCoefForPiece(object cpd1, object cpd2, double[] darr1, double[] darr2, double[] darr3, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCoefForPiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCoefForPiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCoefForPiece", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[D[D[D[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCoefForPiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u005BD\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvComputeeInfiniteProject1(double[] darr1, double[] darr2, double[] darr3, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeeInfiniteProject1", "([D[D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvComputeeInfiniteProject1(DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeeInfiniteProject1", "(Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject1\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvComputeeInfiniteProject2(double[] darr1, double[] darr2, double[] darr3, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeeInfiniteProject2", "([D[D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvComputeeInfiniteProject2(DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeeInfiniteProject2", "(Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeeInfiniteProject2\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCrossDirectDirect(double[] darr1, double[] darr2, object cpd, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossDirectDirect", "([D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCrossDirectDirect(DoubleBuffer db1, DoubleBuffer db2, object cpd, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossDirectDirect", "(Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossDirectDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCrossPieceDirect(object cpd1, object cpd2, double d1, double d2, double d3, object cpd3, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossPieceDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;DDDLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        double num6 = d1;
        double num7 = d2;
        double num8 = d3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double, double, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPieceDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, (double) num4, (double) num5, num6, (IntPtr) num7, (IntPtr) num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCrossPiecePiece(object cpd1, object cpd2, object cpd3, object cpd4, object cpd5, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPiecePiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPiecePiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossPiecePiece", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd5);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossPiecePiece\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetPieceLength(object cpd1, object cpd2, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetPieceLength", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetPieceLength\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCrossRectDirect(object cs, double d1, double d2, double d3, object cpd1, object cpd2, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCrossRectDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCrossRectDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCrossRectDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;DDDLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        double num5 = d1;
        double num6 = d2;
        double num7 = d3;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double, double, double, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCrossRectDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BDDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvProjectPointToImage(object cpd1, double[] darr1, double[] darr2, double[] darr3, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvProjectPointToImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;[D[D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvProjectPointToImage(object cpd1, DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvProjectPointToImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetQuadsTransform(object cs1, double[] darr1, double[] darr2, double[] darr3, double[] darr4, double[] darr5, double[] darr6, object cs2, double[] darr7, double[] darr8, double[] darr9, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetQuadsTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;[D[D[D[D[D[DLcom/googlecode/javacv/cpp/opencv_core$CvSize;[D[D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) darr4);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) darr5);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) darr6);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) darr7);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) darr8);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) darr9);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num16 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BD\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BD\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15, num16);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetQuadsTransform(object cs1, DoubleBuffer db1, DoubleBuffer db2, DoubleBuffer db3, DoubleBuffer db4, DoubleBuffer db5, DoubleBuffer db6, object cs2, DoubleBuffer db7, DoubleBuffer db8, DoubleBuffer db9, object cpd1, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetQuadsTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint3D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) db3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) db4);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) db5);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) db6);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) db7);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) db8);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) db9);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num16 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint3D64f\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15, num16);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetQuadsTransformStruct(object csc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransformStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransformStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetQuadsTransformStruct", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoCamera;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetQuadsTransformStruct\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvComputeStereoParamsForCameras(object csc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoParamsForCameras\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoParamsForCameras\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvComputeStereoParamsForCameras", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvStereoCamera;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvComputeStereoParamsForCameras\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvStereoCamera\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCutPiece(double[] darr1, double[] darr2, object cpd1, object cs, object cpd2, object cpd3, object cpd4, object cpd5, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCutPiece", "([D[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cpd5);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028\u005BD\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetCutPiece(DoubleBuffer db1, DoubleBuffer db2, object cpd1, object cs, object cpd2, object cpd3, object cpd4, object cpd5, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetCutPiece", "(Ljava/nio/DoubleBuffer;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cpd5);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetCutPiece\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetMiddleAnglePoint(object cpd1, object cpd2, object cpd3, object cpd4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetMiddleAnglePoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetMiddleAnglePoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetMiddleAnglePoint", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetMiddleAnglePoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetNormalDirect(double[] darr1, object cpd, double[] darr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetNormalDirect", "([DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetNormalDirect(DoubleBuffer db1, object cpd, DoubleBuffer db2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetNormalDirect", "(Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Ljava/nio/DoubleBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) db1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetNormalDirect\u0028Ljava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double icvGetVect(object cpd1, object cpd2, object cpd3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetVect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029D == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetVect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetVect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetVect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029D)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvProjectPointToDirect(object cpd1, double[] darr, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvProjectPointToDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[DLcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvProjectPointToDirect(object cpd1, DoubleBuffer db, object cpd2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvProjectPointToDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvProjectPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetDistanceFromPointToDirect(object cpd, double[] darr1, double[] darr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetDistanceFromPointToDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;[D[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003B\u005BD\u005BD\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void icvGetDistanceFromPointToDirect(object cpd, DoubleBuffer db, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvGetDistanceFromPointToDirect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D64f;Ljava/nio/DoubleBuffer;[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EicvGetDistanceFromPointToDirect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D64f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003B\u005BD\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object icvCreateIsometricImage(object ii1, object ii2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EicvCreateIsometricImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EicvCreateIsometricImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "icvCreateIsometricImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;II)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_legacy.__\u003Cjniptr\u003EicvCreateIsometricImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDeInterlace(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvDeInterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvDeInterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvDeInterlace", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvDeInterlace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateContourTree(object cs, object cms, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateContourTree", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;D)Lcom/googlecode/javacv/cpp/opencv_legacy$CvContourTree;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003B)((double) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvContourFromContourTree(object cct, object cms, object ctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvContourFromContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvContourFromContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvContourFromContourTree", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvContourTree;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cct);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvContourFromContourTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvMatchContourTrees(object cct1, object cct2, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMatchContourTrees\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BID\u0029D == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMatchContourTrees\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BID\u0029D = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMatchContourTrees", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvContourTree;Lcom/googlecode/javacv/cpp/opencv_legacy$CvContourTree;ID)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cct1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cct2);
        int num6 = i;
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int, double)>) opencv_legacy.__\u003Cjniptr\u003EcvMatchContourTrees\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvContourTree\u003BID\u0029D)((double) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSnakeImage(object ii, object cp, int i1, float[] farr1, float[] farr2, float[] farr3, int i2, object cs, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u005BF\u005BF\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u005BF\u005BF\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvSnakeImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;I[F[F[FILcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) farr3);
        int num10 = i2;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num13 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u005BF\u005BF\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, (int) num5, (IntPtr) num6, num7, num8, (int) num9, (IntPtr) num10, num11, num12, (IntPtr) num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSnakeImage(object ii, object cp, int i1, FloatBuffer fb1, FloatBuffer fb2, FloatBuffer fb3, int i2, object cs, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvSnakeImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;ILjava/nio/FloatBuffer;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;ILcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) fb3);
        int num10 = i2;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num13 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvSnakeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, (int) num5, (IntPtr) num6, num7, num8, (int) num9, (IntPtr) num10, num11, num12, (IntPtr) num13);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateGLCM(object ii, int i1, int[] iarr, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u005BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u005BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateGLCM", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;I[III)Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BI\u005BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003B)((int) num2, (int) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseGLCM(object cglcm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseGLCM", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cglcm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseGLCM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCreateGLCMDescriptors(object cglcm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMDescriptors\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMDescriptors\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateGLCMDescriptors", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cglcm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMDescriptors\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetGLCMDescriptor(object cglcm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BII\u0029D == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BII\u0029D = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvGetGLCMDescriptor", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;II)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cglcm);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int)>) opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BII\u0029D)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvGetGLCMDescriptorStatistics(object cglcm, int i, double[] darr1, double[] darr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptorStatistics\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u005BD\u005BD\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptorStatistics\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u005BD\u005BD\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvGetGLCMDescriptorStatistics", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;I[D[D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cglcm);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) darr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvGetGLCMDescriptorStatistics\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u005BD\u005BD\u0029V)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateGLCMImage(object cglcm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateGLCMImage", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvGLCM;I)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cglcm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateGLCMImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvGLCM\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvInitFaceTracker(object cft, object ii, object cr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvInitFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvInitFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvInitFaceTracker", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvFaceTracker;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;I)Lcom/googlecode/javacv/cpp/opencv_legacy$CvFaceTracker;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_legacy.__\u003Cjniptr\u003EcvInitFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvTrackFace(object cft, object ii, object cr, int i, object cp, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvTrackFace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BD\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvTrackFace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BD\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvTrackFace", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvFaceTracker;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;ILcom/googlecode/javacv/cpp/opencv_core$CvPoint;[D)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvTrackFace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u005BD\u0029I)(num2, num3, (int) num4, num5, num6, (IntPtr) num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseFaceTracker(object cft)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseFaceTracker", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvFaceTracker;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseFaceTracker\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvFaceTracker\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 879)]
    public static object cv3dTracker2dTrackedObject(int id, object p)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(p, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$Cv3dTracker2dTrackedObject");
    }

    [LineNumberTable((ushort) 902)]
    public static object cv3dTrackerTrackedObject(int id, object p)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(p, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$CvPoint3D32f");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$Cv3dTrackerTrackedObject");
    }

    [Modifiers]
    public static bool cv3dTrackerCalibrateCameras(int i, object ctci1, object cs, float f, object pp, object ctci2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerCalibrateCameras\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraIntrinsics\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003B\u0029Z == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerCalibrateCameras\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraIntrinsics\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003B\u0029Z = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cv3dTrackerCalibrateCameras", "(ILcom/googlecode/javacv/cpp/opencv_legacy$Cv3dTrackerCameraIntrinsics;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;FLcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/opencv_legacy$Cv3dTrackerCameraInfo;)Z");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ctci1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        double num7 = (double) f;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ctci2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (bool) __calli((__FnPtr<byte (IntPtr, IntPtr, int, IntPtr, IntPtr, float, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerCalibrateCameras\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraIntrinsics\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003B\u0029Z)(num2, num3, (float) num4, num5, num6, (int) num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cv3dTrackerLocateObjects(int i1, int i2, object ctci, object ctto1, object ctto2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerLocateObjects\u0028IILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTracker2dTrackedObject\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerTrackedObject\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerLocateObjects\u0028IILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTracker2dTrackedObject\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerTrackedObject\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cv3dTrackerLocateObjects", "(IILcom/googlecode/javacv/cpp/opencv_legacy$Cv3dTrackerCameraInfo;Lcom/googlecode/javacv/cpp/opencv_legacy$Cv3dTracker2dTrackedObject;Lcom/googlecode/javacv/cpp/opencv_legacy$Cv3dTrackerTrackedObject;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        int num5 = i2;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ctci);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ctto1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ctto2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003Ecv3dTrackerLocateObjects\u0028IILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerCameraInfo\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTracker2dTrackedObject\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024Cv3dTrackerTrackedObject\u003B\u0029I)(num2, num3, (IntPtr) num4, num5, (int) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 965)]
    public static object CV_NEXT_VORONOISITE2D(object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
    }

    [LineNumberTable((ushort) 968)]
    public static object CV_PREV_VORONOISITE2D(object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
    }

    [LineNumberTable((ushort) 971)]
    public static object CV_FIRST_VORONOIEDGE2D(object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
    }

    [LineNumberTable((ushort) 974)]
    public static object CV_LAST_VORONOIEDGE2D(object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
    }

    [LineNumberTable((ushort) 977)]
    public static object CV_NEXT_VORONOIEDGE2D(object EDGE, object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(EDGE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
    }

    [LineNumberTable((ushort) 980)]
    public static object CV_PREV_VORONOIEDGE2D(object EDGE, object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(EDGE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
    }

    [LineNumberTable((ushort) 983)]
    public static object CV_VORONOIEDGE2D_BEGINNODE(object EDGE, object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(EDGE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
    }

    [LineNumberTable((ushort) 986)]
    public static object CV_VORONOIEDGE2D_ENDNODE(object EDGE, object SITE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(EDGE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
    }

    [LineNumberTable((ushort) 989)]
    public static object CV_TWIN_VORONOISITE2D(object SITE, object EDGE)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(SITE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiSite2D");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(EDGE, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_legacy$CvVoronoiEdge2D");
    }

    [Modifiers]
    public static int cvVoronoiDiagramFromContour(object cs, object cvdd, object cms, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIII\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIII\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvVoronoiDiagramFromContour", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_legacy$CvVoronoiDiagram2D;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;III)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cvdd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num7 = i1;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIII\u0029I)((int) num2, (int) num3, (int) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvVoronoiDiagramFromImage(object ii, object cs, object cvdd, object cms, int i, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIF\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIF\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvVoronoiDiagramFromImage", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_legacy$CvVoronoiDiagram2D;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;IF)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cvdd);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num8 = i;
        double num9 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, float)>) opencv_legacy.__\u003Cjniptr\u003EcvVoronoiDiagramFromImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIF\u0029I)((float) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseVoronoiStorage(object cvdd, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseVoronoiStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseVoronoiStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseVoronoiStorage", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvVoronoiDiagram2D;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cvdd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseVoronoiStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLinearContorModelFromVoronoiDiagram(object cvdd, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvLinearContorModelFromVoronoiDiagram\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvLinearContorModelFromVoronoiDiagram\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvLinearContorModelFromVoronoiDiagram", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvVoronoiDiagram2D;F)Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cvdd);
        double num5 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, float)>) opencv_legacy.__\u003Cjniptr\u003EcvLinearContorModelFromVoronoiDiagram\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvVoronoiDiagram2D\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B)((float) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvReleaseLinearContorModelStorage(object cg)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseLinearContorModelStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029I == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseLinearContorModelStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseLinearContorModelStorage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvGraph;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cg);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseLinearContorModelStorage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvGraph\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInitPerspectiveTransform(object cs, object cpd, double[] darr, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvInitPerspectiveTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;[DLcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvInitPerspectiveTransform(object cs, object cpd, DoubleBuffer db, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvInitPerspectiveTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Ljava/nio/DoubleBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) db);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvInitPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FDoubleBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMakeScanlines(float[] farr, object cs, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMakeScanlines", "([FLcom/googlecode/javacv/cpp/opencv_core$CvSize;[I[I[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMakeScanlines(FloatBuffer fb, object cs, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMakeScanlines", "(Ljava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;[I[I[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvMakeScanlines\u0028Ljava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPreWarpImage(int i, object ii, object bp, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvPreWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvPreWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvPreWarpImage", "(ILcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacpp/BytePointer;[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvPreWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u0029V)(num2, num3, (IntPtr) num4, num5, (int) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvFindRuns(int i, object bp1, object bp2, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5, int[] iarr6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvFindRuns\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvFindRuns\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvFindRuns", "(ILcom/googlecode/javacpp/BytePointer;Lcom/googlecode/javacpp/BytePointer;[I[I[I[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvFindRuns\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V)(num2, num3, (IntPtr) num4, num5, num6, num7, num8, num9, (int) num10, num11, num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDynamicCorrespondMulti(int i, int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5, int[] iarr6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvDynamicCorrespondMulti\u0028I\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvDynamicCorrespondMulti\u0028I\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvDynamicCorrespondMulti", "(I[I[I[I[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvDynamicCorrespondMulti\u0028I\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V)(num2, num3, (IntPtr) num4, num5, num6, num7, (int) num8, num9, num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMakeAlphaScanlines(int[] iarr1, int[] iarr2, int[] iarr3, int[] iarr4, int i, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMakeAlphaScanlines\u0028\u005BI\u005BI\u005BI\u005BIIF\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMakeAlphaScanlines\u0028\u005BI\u005BI\u005BI\u005BIIF\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMakeAlphaScanlines", "([I[I[I[IIF)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        int num8 = i;
        double num9 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, float)>) opencv_legacy.__\u003Cjniptr\u003EcvMakeAlphaScanlines\u0028\u005BI\u005BI\u005BI\u005BIIF\u0029V)((float) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMorphEpilinesMulti(int i, object bp1, int[] iarr1, object bp2, int[] iarr2, object bp3, int[] iarr3, float f, int[] iarr4, int[] iarr5, int[] iarr6, int[] iarr7, int[] iarr8, int[] iarr9)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvMorphEpilinesMulti\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BIF\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvMorphEpilinesMulti\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BIF\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvMorphEpilinesMulti", "(ILcom/googlecode/javacpp/BytePointer;[ILcom/googlecode/javacpp/BytePointer;[ILcom/googlecode/javacpp/BytePointer;[IF[I[I[I[I[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(bp2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(bp3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        double num11 = (double) f;
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr6);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr7);
        // ISSUE: explicit reference operation
        IntPtr num16 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr8);
        // ISSUE: explicit reference operation
        IntPtr num17 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr9);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvMorphEpilinesMulti\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BIF\u005BI\u005BI\u005BI\u005BI\u005BI\u005BI\u0029V)(num2, num3, (IntPtr) num4, num5, num6, num7, (float) num8, num9, num10, (IntPtr) num11, num12, num13, num14, (int) num15, num16, num17);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvPostWarpImage(int i, object bp, int[] iarr1, object ii, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvPostWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BI\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvPostWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvPostWarpImage", "(ILcom/googlecode/javacpp/BytePointer;[ILcom/googlecode/javacv/cpp/opencv_core$IplImage;[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(bp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvPostWarpImage\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u005BI\u0029V)(num2, num3, (IntPtr) num4, num5, (int) num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDeleteMoire(object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvDeleteMoire\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvDeleteMoire\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvDeleteMoire", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvDeleteMoire\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateConDensation(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvCreateConDensation\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvCreateConDensation\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvCreateConDensation", "(III)Lcom/googlecode/javacv/cpp/opencv_legacy$CvConDensation;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int)>) opencv_legacy.__\u003Cjniptr\u003EcvCreateConDensation\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseConDensation(object ccd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvReleaseConDensation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvReleaseConDensation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvReleaseConDensation", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvConDensation;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvReleaseConDensation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvConDensUpdateByTime(object ccd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvConDensUpdateByTime\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvConDensUpdateByTime\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvConDensUpdateByTime", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvConDensation;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvConDensUpdateByTime\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvConDensInitSampleSet(object ccd, object cm1, object cm2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_legacy.__\u003Cjniptr\u003EcvConDensInitSampleSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_legacy.__\u003Cjniptr\u003EcvConDensInitSampleSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_legacy.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_legacy", "cvConDensInitSampleSet", "(Lcom/googlecode/javacv/cpp/opencv_legacy$CvConDensation;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_legacy.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_legacy>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_legacy.__\u003Cjniptr\u003EcvConDensInitSampleSet\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_legacy\u0024CvConDensation\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 1211)]
    public static int iplWidth(object img)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (img == null)
        return 0;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 1215)]
    public static int iplHeight(object img)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(img, __typeref (opencv_legacy), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (img == null)
        return 0;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (opencv_legacy.__\u003CcallerID\u003E == null)
        opencv_legacy.__\u003CcallerID\u003E = (CallerID) new opencv_legacy.__\u003CCallerID\u003E();
      return opencv_legacy.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
