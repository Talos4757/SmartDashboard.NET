// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_imgproc
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
  public class opencv_imgproc : Object
  {
    public const int CV_BLUR_NO_SCALE = 0;
    public const int CV_BLUR = 1;
    public const int CV_GAUSSIAN = 2;
    public const int CV_MEDIAN = 3;
    public const int CV_BILATERAL = 4;
    public const int CV_GAUSSIAN_5x5 = 7;
    public const int CV_INPAINT_NS = 0;
    public const int CV_INPAINT_TELEA = 1;
    public const int CV_SCHARR = -1;
    public const int CV_MAX_SOBEL_KSIZE = 7;
    public const int CV_BGR2BGRA = 0;
    public const int CV_RGB2RGBA = 0;
    public const int CV_BGRA2BGR = 1;
    public const int CV_RGBA2RGB = 1;
    public const int CV_BGR2RGBA = 2;
    public const int CV_RGB2BGRA = 2;
    public const int CV_RGBA2BGR = 3;
    public const int CV_BGRA2RGB = 3;
    public const int CV_BGR2RGB = 4;
    public const int CV_RGB2BGR = 4;
    public const int CV_BGRA2RGBA = 5;
    public const int CV_RGBA2BGRA = 5;
    public const int CV_BGR2GRAY = 6;
    public const int CV_RGB2GRAY = 7;
    public const int CV_GRAY2BGR = 8;
    public const int CV_GRAY2RGB = 8;
    public const int CV_GRAY2BGRA = 9;
    public const int CV_GRAY2RGBA = 9;
    public const int CV_BGRA2GRAY = 10;
    public const int CV_RGBA2GRAY = 11;
    public const int CV_BGR2BGR565 = 12;
    public const int CV_RGB2BGR565 = 13;
    public const int CV_BGR5652BGR = 14;
    public const int CV_BGR5652RGB = 15;
    public const int CV_BGRA2BGR565 = 16;
    public const int CV_RGBA2BGR565 = 17;
    public const int CV_BGR5652BGRA = 18;
    public const int CV_BGR5652RGBA = 19;
    public const int CV_GRAY2BGR565 = 20;
    public const int CV_BGR5652GRAY = 21;
    public const int CV_BGR2BGR555 = 22;
    public const int CV_RGB2BGR555 = 23;
    public const int CV_BGR5552BGR = 24;
    public const int CV_BGR5552RGB = 25;
    public const int CV_BGRA2BGR555 = 26;
    public const int CV_RGBA2BGR555 = 27;
    public const int CV_BGR5552BGRA = 28;
    public const int CV_BGR5552RGBA = 29;
    public const int CV_GRAY2BGR555 = 30;
    public const int CV_BGR5552GRAY = 31;
    public const int CV_BGR2XYZ = 32;
    public const int CV_RGB2XYZ = 33;
    public const int CV_XYZ2BGR = 34;
    public const int CV_XYZ2RGB = 35;
    public const int CV_BGR2YCrCb = 36;
    public const int CV_RGB2YCrCb = 37;
    public const int CV_YCrCb2BGR = 38;
    public const int CV_YCrCb2RGB = 39;
    public const int CV_BGR2HSV = 40;
    public const int CV_RGB2HSV = 41;
    public const int CV_BGR2Lab = 44;
    public const int CV_RGB2Lab = 45;
    public const int CV_BayerBG2BGR = 46;
    public const int CV_BayerGB2BGR = 47;
    public const int CV_BayerRG2BGR = 48;
    public const int CV_BayerGR2BGR = 49;
    public const int CV_BayerBG2RGB = 48;
    public const int CV_BayerGB2RGB = 49;
    public const int CV_BayerRG2RGB = 46;
    public const int CV_BayerGR2RGB = 47;
    public const int CV_BGR2Luv = 50;
    public const int CV_RGB2Luv = 51;
    public const int CV_BGR2HLS = 52;
    public const int CV_RGB2HLS = 53;
    public const int CV_HSV2BGR = 54;
    public const int CV_HSV2RGB = 55;
    public const int CV_Lab2BGR = 56;
    public const int CV_Lab2RGB = 57;
    public const int CV_Luv2BGR = 58;
    public const int CV_Luv2RGB = 59;
    public const int CV_HLS2BGR = 60;
    public const int CV_HLS2RGB = 61;
    public const int CV_BayerBG2BGR_VNG = 62;
    public const int CV_BayerGB2BGR_VNG = 63;
    public const int CV_BayerRG2BGR_VNG = 64;
    public const int CV_BayerGR2BGR_VNG = 65;
    public const int CV_BayerBG2RGB_VNG = 64;
    public const int CV_BayerGB2RGB_VNG = 65;
    public const int CV_BayerRG2RGB_VNG = 62;
    public const int CV_BayerGR2RGB_VNG = 63;
    public const int CV_BGR2HSV_FULL = 66;
    public const int CV_RGB2HSV_FULL = 67;
    public const int CV_BGR2HLS_FULL = 68;
    public const int CV_RGB2HLS_FULL = 69;
    public const int CV_HSV2BGR_FULL = 70;
    public const int CV_HSV2RGB_FULL = 71;
    public const int CV_HLS2BGR_FULL = 72;
    public const int CV_HLS2RGB_FULL = 73;
    public const int CV_LBGR2Lab = 74;
    public const int CV_LRGB2Lab = 75;
    public const int CV_LBGR2Luv = 76;
    public const int CV_LRGB2Luv = 77;
    public const int CV_Lab2LBGR = 78;
    public const int CV_Lab2LRGB = 79;
    public const int CV_Luv2LBGR = 80;
    public const int CV_Luv2LRGB = 81;
    public const int CV_BGR2YUV = 82;
    public const int CV_RGB2YUV = 83;
    public const int CV_YUV2BGR = 84;
    public const int CV_YUV2RGB = 85;
    public const int CV_COLORCVT_MAX = 100;
    public const int CV_INTER_NN = 0;
    public const int CV_INTER_LINEAR = 1;
    public const int CV_INTER_CUBIC = 2;
    public const int CV_INTER_AREA = 3;
    public const int CV_INTER_LANCZOS4 = 4;
    public const int CV_WARP_FILL_OUTLIERS = 8;
    public const int CV_WARP_INVERSE_MAP = 16;
    public const int CV_SHAPE_RECT = 0;
    public const int CV_SHAPE_CROSS = 1;
    public const int CV_SHAPE_ELLIPSE = 2;
    public const int CV_SHAPE_CUSTOM = 100;
    public const int CV_MOP_ERODE = 0;
    public const int CV_MOP_DILATE = 1;
    public const int CV_MOP_OPEN = 2;
    public const int CV_MOP_CLOSE = 3;
    public const int CV_MOP_GRADIENT = 4;
    public const int CV_MOP_TOPHAT = 5;
    public const int CV_MOP_BLACKHAT = 6;
    public const int CV_TM_SQDIFF = 0;
    public const int CV_TM_SQDIFF_NORMED = 1;
    public const int CV_TM_CCORR = 2;
    public const int CV_TM_CCORR_NORMED = 3;
    public const int CV_TM_CCOEFF = 4;
    public const int CV_TM_CCOEFF_NORMED = 5;
    public const int CV_RETR_EXTERNAL = 0;
    public const int CV_RETR_LIST = 1;
    public const int CV_RETR_CCOMP = 2;
    public const int CV_RETR_TREE = 3;
    public const int CV_CHAIN_CODE = 0;
    public const int CV_CHAIN_APPROX_NONE = 1;
    public const int CV_CHAIN_APPROX_SIMPLE = 2;
    public const int CV_CHAIN_APPROX_TC89_L1 = 3;
    public const int CV_CHAIN_APPROX_TC89_KCOS = 4;
    public const int CV_LINK_RUNS = 5;
    public const int CV_SUBDIV2D_VIRTUAL_POINT_FLAG = 1073741824;
    public const int CV_PTLOC_ERROR = -2;
    public const int CV_PTLOC_OUTSIDE_RECT = -1;
    public const int CV_PTLOC_INSIDE = 0;
    public const int CV_PTLOC_VERTEX = 1;
    public const int CV_PTLOC_ON_EDGE = 2;
    public const int CV_NEXT_AROUND_ORG = 0;
    public const int CV_NEXT_AROUND_DST = 34;
    public const int CV_PREV_AROUND_ORG = 17;
    public const int CV_PREV_AROUND_DST = 51;
    public const int CV_NEXT_AROUND_LEFT = 19;
    public const int CV_NEXT_AROUND_RIGHT = 49;
    public const int CV_PREV_AROUND_LEFT = 32;
    public const int CV_PREV_AROUND_RIGHT = 2;
    public const int CV_POLY_APPROX_DP = 0;
    public const int CV_CONTOURS_MATCH_I1 = 1;
    public const int CV_CONTOURS_MATCH_I2 = 2;
    public const int CV_CONTOURS_MATCH_I3 = 3;
    public const int CV_CLOCKWISE = 1;
    public const int CV_COUNTER_CLOCKWISE = 2;
    public const int CV_COMP_CORREL = 0;
    public const int CV_COMP_CHISQR = 1;
    public const int CV_COMP_INTERSECT = 2;
    public const int CV_COMP_BHATTACHARYYA = 3;
    public const int CV_DIST_MASK_3 = 3;
    public const int CV_DIST_MASK_5 = 5;
    public const int CV_DIST_MASK_PRECISE = 0;
    public const int CV_DIST_USER = -1;
    public const int CV_DIST_L1 = 1;
    public const int CV_DIST_L2 = 2;
    public const int CV_DIST_C = 3;
    public const int CV_DIST_L12 = 4;
    public const int CV_DIST_FAIR = 5;
    public const int CV_DIST_WELSCH = 6;
    public const int CV_DIST_HUBER = 7;
    public const int CV_THRESH_BINARY = 0;
    public const int CV_THRESH_BINARY_INV = 1;
    public const int CV_THRESH_TRUNC = 2;
    public const int CV_THRESH_TOZERO = 3;
    public const int CV_THRESH_TOZERO_INV = 4;
    public const int CV_THRESH_MASK = 7;
    public const int CV_THRESH_OTSU = 8;
    public const int CV_ADAPTIVE_THRESH_MEAN_C = 0;
    public const int CV_ADAPTIVE_THRESH_GAUSSIAN_C = 1;
    public const int CV_FLOODFILL_FIXED_RANGE = 65536;
    public const int CV_FLOODFILL_MASK_ONLY = 131072;
    public const int CV_CANNY_L2_GRADIENT = -2147483648;
    public const int CV_HOUGH_STANDARD = 0;
    public const int CV_HOUGH_PROBABILISTIC = 1;
    public const int CV_HOUGH_MULTI_SCALE = 2;
    public const int CV_HOUGH_GRADIENT = 3;
    public const int CV_HIST_MAGIC_VAL = 1111818240;
    public const int CV_HIST_UNIFORM_FLAG = 1024;
    public const int CV_HIST_RANGES_FLAG = 2048;
    public const int CV_HIST_ARRAY = 0;
    public const int CV_HIST_SPARSE = 1;
    public const int CV_HIST_TREE = 1;
    public const int CV_HIST_UNIFORM = 1;
    static IntPtr __\u003Cjniptr\u003ECV_INIT_3X3_DELTAS\u0028\u005BIII\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003ECV_SUBDIV2D_NEXT_EDGE\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSquareAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMultiplyAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRunningAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCopyMakeBorder\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSmooth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIIDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFilter2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvIntegral\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPyrDown\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPyrUp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreatePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleasePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPyrSegmentation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPyrMeanShiftFiltering\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWatershed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInpaint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSobel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLaplace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCvtColor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvResize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWarpAffine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetAffineTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003Ecv2DRotationMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvWarpPerspective\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvRemap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvConvertMaps\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLogPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLinearPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUndistort2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitUndistortMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvInitUndistortRectifyMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUndistortPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateStructuringElementEx\u0028IIIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseStructuringElement\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvErode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDilate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMorphologyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetSpatialMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetNormalizedCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvGetHuMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHuMoments\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSampleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetRectSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetQuadrangleSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMatchTemplate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcEMD2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvDistanceFunction\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029F;
    static IntPtr __\u003Cjniptr\u003EcvFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvStartFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFindNextContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubstituteContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEndFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvApproxChains\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvStartReadChainPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvChain\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvReadChainPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B;
    static IntPtr __\u003Cjniptr\u003EcvInitSubdivDelaunay2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateSubdiv2D\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdivDelaunay2DInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DLocate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCalcSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindNearestPoint2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DRotateEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DSymEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DGetEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DEdgeOrg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSubdiv2DEdgeDst\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B;
    static IntPtr __\u003Cjniptr\u003EcvTriangleArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvApproxPoly\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvArcLength\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvBoundingRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B;
    static IntPtr __\u003Cjniptr\u003EcvContourArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvMinAreaRect2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMinEnclosingCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BF\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvMatchShapes\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BID\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvConvexHull2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCheckContourConvexity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvConvexityDefects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFitEllipse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMaxRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B;
    static IntPtr __\u003Cjniptr\u003EcvBoxPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPointSeqFromMat\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvContour\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvPointPolygonTest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvCreateHist\u0028I\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSetHistBinRanges\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B;
    static IntPtr __\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvClearHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetMinMaxHistValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BF\u005BF\u005BI\u005BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvNormalizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvThreshHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCompareHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvCopyHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcBayesianProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcArrHist\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcArrBackProject\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcArrBackProjectPatch\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcProbDensity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEqualizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDistTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvAdaptiveThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFloodFill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCanny\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvPreCornerDetect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCornerEigenValsAndVecs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCornerMinEigenVal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCornerHarris\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindCornerSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGoodFeaturesToTrack\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BIDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvHoughLines2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvHoughCircles\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDDDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDD\u005BF\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateKDTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateSpillTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseFeatureTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindFeatures\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvFindFeaturesBoxed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSHOperations\u003BIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateMemoryLSH\u0028IIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003ELSHSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvLSHAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLSHRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLSHQuery\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V;

    [LineNumberTable((ushort) 87)]
    static opencv_imgproc()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<opencv_core>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 232, (byte) 162, (byte) 247})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_imgproc()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void cvInitUndistortMap(object cm1, object cm2, object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvInitUndistortMap", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static void cvRemap(object ca1, object ca2, object ca3, object ca4, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvRemap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvRemap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvRemap", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num8 = i;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvRemap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, num9);
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
    public static void cvConvertMaps(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvConvertMaps\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvConvertMaps\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvConvertMaps", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvConvertMaps\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static void cvCvtColor(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCvtColor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCvtColor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCvtColor", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCvtColor\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvPyrDown(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPyrDown\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPyrDown\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPyrDown", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvPyrDown\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvUndistortPoints(object cm1, object cm2, object cm3, object cm4, object cm5, object cm6)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvUndistortPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvUndistortPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvUndistortPoints", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cm5);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cm6);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvUndistortPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9);
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
    public static void cvMorphologyEx(object ca1, object ca2, object ca3, object ick, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMorphologyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMorphologyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMorphologyEx", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_imgproc$IplConvKernel;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ick);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvMorphologyEx\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BII\u0029V)((int) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
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
    public static void cvDilate(object ca1, object ca2, object ick, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvDilate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvDilate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvDilate", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_imgproc$IplConvKernel;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ick);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvDilate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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

    [LineNumberTable((ushort) 758)]
    public static int cvFindContours(object image, object storage, object first_contour, int header_size, int mode, int method)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(first_contour, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [Modifiers]
    public static double cvContourArea(object ca, object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvContourArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvContourArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvContourArea", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvContourArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvMoments(object ca, object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMoments", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvMoments;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvIntegral(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvIntegral\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvIntegral\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvIntegral", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvIntegral\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static void cvResize(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvResize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvResize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvResize", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvResize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object cvMinAreaRect2(object ca, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMinAreaRect2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMinAreaRect2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMinAreaRect2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvBox2D;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvMinAreaRect2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B)(num2, num3, num4, num5);
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
    public static void cvFindCornerSubPix(object ca, object cpd, int i, object cs1, object cs2, object ctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindCornerSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindCornerSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindCornerSubPix", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindCornerSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V)(num2, num3, num4, (int) num5, (IntPtr) num6, num7, num8, num9);
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
    public static void cvErode(object ca1, object ca2, object ick, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvErode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvErode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvErode", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_imgproc$IplConvKernel;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ick);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvErode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static void cvWarpPerspective(object ca1, object ca2, object cm, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvWarpPerspective\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvWarpPerspective\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvWarpPerspective", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvWarpPerspective\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
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
    public static void cvSmooth(object ca1, object ca2, int i1, int i2, int i3, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSmooth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIIDD\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSmooth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIIDD\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSmooth", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IIIDD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        double num9 = d1;
        double num10 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, double, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvSmooth\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIIIDD\u0029V)((double) num2, (double) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void cvWarpAffine(object ca1, object ca2, object cm, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvWarpAffine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvWarpAffine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvWarpAffine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvWarpAffine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
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
    public static void cvUndistort2(object ca1, object ca2, object cm1, object cm2, object cm3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvUndistort2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvUndistort2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvUndistort2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvUndistort2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
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
    public static int cvFindContours(object ca, object cms, object cs, int i1, int i2, int i3, object cp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindContours", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;IIILcom/googlecode/javacv/cpp/opencv_core$CvPoint;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num7 = i1;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029I)(num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, num10);
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
    public static object cvStartFindContours(object ca, object cms, int i1, int i2, int i3, object cp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvStartFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvStartFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvStartFindContours", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;IIILcom/googlecode/javacv/cpp/opencv_core$CvPoint;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvContourScanner;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvStartFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B)(num2, (int) num3, (int) num4, (int) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, num9);
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
    public static object cvCreateSubdiv2D(int i1, int i2, int i3, int i4, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateSubdiv2D\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateSubdiv2D\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateSubdiv2D", "(IIIILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateSubdiv2D\u0028IIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
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
    public static void cvInitSubdivDelaunay2D(object csd, object cr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvInitSubdivDelaunay2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvInitSubdivDelaunay2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvInitSubdivDelaunay2D", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvInitSubdivDelaunay2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029V)(num2, num3, num4, num5);
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
    public static object CV_SUBDIV2D_NEXT_EDGE(object csde)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003ECV_SUBDIV2D_NEXT_EDGE\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003ECV_SUBDIV2D_NEXT_EDGE\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "CV_SUBDIV2D_NEXT_EDGE", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003ECV_SUBDIV2D_NEXT_EDGE\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B)(num2, num3, num4);
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
    public static double cvArcLength(object p, object cs, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvArcLength\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvArcLength\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvArcLength", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacv/cpp/opencv_core$CvSlice;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvArcLength\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSlice\u003BI\u0029D)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object cvCreateHist(int i1, int[] iarr, int i2, object pp, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateHist\u0028I\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateHist\u0028I\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateHist", "(I[IILcom/googlecode/javacpp/PointerPointer;I)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num6 = i2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, int, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateHist\u0028I\u005BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
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
    public static void cvSetHistBinRanges(object ch, object pp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSetHistBinRanges\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSetHistBinRanges\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSetHistBinRanges", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Lcom/googlecode/javacpp/PointerPointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvSetHistBinRanges\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object cvMakeHistHeaderForArray(int i1, int[] iarr, object ch, float[] farr, object pp, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMakeHistHeaderForArray", "(I[ILcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;[FLcom/googlecode/javacpp/PointerPointer;I)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B)((int) num2, num3, (IntPtr) num4, num5, num6, (int) num7, num8, (IntPtr) num9);
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
    public static object cvMakeHistHeaderForArray(int i1, int[] iarr, object ch, FloatBuffer fb, object pp, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMakeHistHeaderForArray", "(I[ILcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Ljava/nio/FloatBuffer;Lcom/googlecode/javacpp/PointerPointer;I)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvMakeHistHeaderForArray\u0028I\u005BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B)((int) num2, num3, (IntPtr) num4, num5, num6, (int) num7, num8, (IntPtr) num9);
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
    public static void cvCalcArrHist(object pp, object ch, int i, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrHist\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrHist\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcArrHist", "(Lcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrHist\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (int) num3, num4, num5, (IntPtr) num6, num7);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 163, (byte) 127, (byte) 20, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCalcHist(object arr, object hist, int accumulate, object mask)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_imgproc), "com.googlecode.javacpp.PointerPointer");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mask, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object pp = arr;
      object obj1 = hist;
      int num1 = accumulate;
      object obj2 = mask;
      int num2 = num1;
      object ch = obj1;
      int i = num2;
      object ca = obj2;
      opencv_imgproc.cvCalcArrHist(pp, ch, i, ca);
    }

    [Modifiers]
    public static void cvCalcArrBackProject(object pp, object ca, object ch)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProject\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProject\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcArrBackProject", "(Lcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProject\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, num3, num4, num5, num6);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 160, (byte) 159, (byte) 20, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCalcBackProject(object image, object dst, object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "com.googlecode.javacpp.PointerPointer");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      object pp = image;
      object obj1 = dst;
      object obj2 = hist;
      object ca = obj1;
      object ch = obj2;
      opencv_imgproc.cvCalcArrBackProject(pp, ca, ch);
    }

    [Modifiers]
    public static void cvCalcArrBackProjectPatch(object pp, object ca, object cs, object ch, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProjectPatch\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BID\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProjectPatch\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BID\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcArrBackProjectPatch", "(Lcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;ID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        int num8 = i;
        double num9 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcArrBackProjectPatch\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BID\u0029V)((double) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 156, (byte) 127, (byte) 37, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvCalcBackProjectPatch(object image, object dst, object range, object hist, int method, double factor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "com.googlecode.javacpp.PointerPointer");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(range, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      object pp = image;
      object obj1 = dst;
      object obj2 = range;
      object obj3 = hist;
      int num1 = method;
      double num2 = factor;
      int num3 = num1;
      object obj4 = obj3;
      object obj5 = obj2;
      object ca = obj1;
      object cs = obj5;
      object ch = obj4;
      int i = num3;
      double d = num2;
      opencv_imgproc.cvCalcArrBackProjectPatch(pp, ca, cs, ch, i, d);
    }

    [Modifiers]
    public static void CV_INIT_3X3_DELTAS(int[] iarr, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003ECV_INIT_3X3_DELTAS\u0028\u005BIII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003ECV_INIT_3X3_DELTAS\u0028\u005BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "CV_INIT_3X3_DELTAS", "([III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003ECV_INIT_3X3_DELTAS\u0028\u005BIII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static void cvAcc(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvAcc", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void cvSquareAcc(object ca1, object ca2, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSquareAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSquareAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSquareAcc", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSquareAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void cvMultiplyAcc(object ca1, object ca2, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMultiplyAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMultiplyAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMultiplyAcc", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvMultiplyAcc\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static void cvRunningAvg(object ca1, object ca2, double d, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvRunningAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvRunningAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvRunningAvg", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvRunningAvg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (double) num3, num4, num5, (IntPtr) num6, num7);
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
    public static void cvCopyMakeBorder(object ca1, object ca2, object cp, int i, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCopyMakeBorder\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCopyMakeBorder\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCopyMakeBorder", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCopyMakeBorder\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 246, (byte) 95, (byte) 3, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvSmooth(object src, object dst, int smoothtype, int size1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num1 = smoothtype;
      int num2 = size1;
      int num3 = 0;
      double num4 = 0.0;
      double num5 = 0.0;
      double num6 = num4;
      int num7 = num3;
      int num8 = num2;
      int num9 = num1;
      object ca2 = obj;
      int i1 = num9;
      int i2 = num8;
      int i3 = num7;
      double d1 = num6;
      double d2 = num5;
      opencv_imgproc.cvSmooth(ca1, ca2, i1, i2, i3, d1, d2);
    }

    [Modifiers]
    public static void cvFilter2D(object ca1, object ca2, object cm, object cp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFilter2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFilter2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFilter2D", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFilter2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static void cvPyrUp(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPyrUp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPyrUp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPyrUp", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvPyrUp\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static object cvCreatePyramid(object ca1, int i1, double d, object cs, object ca2, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreatePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreatePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreatePyramid", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IDLcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)Lcom/googlecode/javacpp/PointerPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        int num5 = i1;
        double num6 = d;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num9 = i2;
        int num10 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, double, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreatePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, num6, (int) num7, num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void cvReleasePyramid(object pp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReleasePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReleasePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReleasePyramid", "(Lcom/googlecode/javacpp/PointerPointer;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvReleasePyramid\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void cvPyrSegmentation(object ii1, object ii2, object cms, object cs, int i, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPyrSegmentation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIDD\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPyrSegmentation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIDD\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPyrSegmentation", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;IDD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i;
        double num9 = d1;
        double num10 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, double, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvPyrSegmentation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BIDD\u0029V)((double) num2, (double) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void cvPyrMeanShiftFiltering(object ca1, object ca2, double d1, double d2, int i, object ctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPyrMeanShiftFiltering\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPyrMeanShiftFiltering\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPyrMeanShiftFiltering", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDILcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        int num8 = i;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvPyrMeanShiftFiltering\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V)(num2, (int) num3, (double) num4, (double) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, num9);
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
    public static void cvWatershed(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvWatershed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvWatershed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvWatershed", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvWatershed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void cvInpaint(object ca1, object ca2, object ca3, double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvInpaint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvInpaint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvInpaint", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d;
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvInpaint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDI\u0029V)((int) num2, (double) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvSobel(object ca1, object ca2, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSobel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSobel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSobel", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        int num8 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvSobel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvLaplace(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLaplace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLaplace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLaplace", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvLaplace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 241, (byte) 191, (byte) 3, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvResize(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      object ca1 = src;
      object obj = dst;
      int num = 1;
      object ca2 = obj;
      int i = num;
      opencv_imgproc.cvResize(ca1, ca2, i);
    }

    [LineNumberTable((ushort) 635)]
    public static void cvWarpAffine(object src, object dst, object map_matrix)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map_matrix, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static object cvGetAffineTransform(object cpd1, object cpd2, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetAffineTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetAffineTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetAffineTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetAffineTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5, num6);
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
    public static object cv2DRotationMatrix(object cpd, double d1, double d2, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003Ecv2DRotationMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003Ecv2DRotationMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cv2DRotationMatrix", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;DDLcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        double num5 = d1;
        double num6 = d2;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, double, double, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003Ecv2DRotationMatrix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, (double) num3, (double) num4, (IntPtr) num5, (IntPtr) num6, num7);
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

    [LineNumberTable((ushort) 645)]
    public static void cvWarpPerspective(object src, object dst, object map_matrix)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map_matrix, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [Modifiers]
    public static object cvGetPerspectiveTransform(object cpd1, object cpd2, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetPerspectiveTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetPerspectiveTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5, num6);
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
    public static void cvLogPolar(object ca1, object ca2, object cpd, double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLogPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLogPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLogPolar", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;DI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        double num7 = d;
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvLogPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V)((int) num2, (double) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvLinearPolar(object ca1, object ca2, object cpd, double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLinearPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLinearPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLinearPolar", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;DI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        double num7 = d;
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvLinearPolar\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BDI\u0029V)((int) num2, (double) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 233, (byte) 127, (byte) 37, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void cvUndistort2(object src, object dst, object intrinsic_matrix, object distortion_coeffs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(intrinsic_matrix, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(distortion_coeffs, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1 = src;
      object obj1 = dst;
      object obj2 = intrinsic_matrix;
      object obj3 = distortion_coeffs;
      object obj4 = (object) null;
      object obj5 = obj3;
      object obj6 = obj2;
      object ca2 = obj1;
      object cm1 = obj6;
      object cm2 = obj5;
      object cm3 = obj4;
      opencv_imgproc.cvUndistort2(ca1, ca2, cm1, cm2, cm3);
    }

    [Modifiers]
    public static void cvInitUndistortRectifyMap(object cm1, object cm2, object cm3, object cm4, object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortRectifyMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortRectifyMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvInitUndistortRectifyMap", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvInitUndistortRectifyMap\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8, num9);
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
    public static object cvCreateStructuringElementEx(int i1, int i2, int i3, int i4, int i5, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateStructuringElementEx\u0028IIIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateStructuringElementEx\u0028IIIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateStructuringElementEx", "(IIIII[I)Lcom/googlecode/javacv/cpp/opencv_imgproc$IplConvKernel;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        int num8 = i5;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateStructuringElementEx\u0028IIIII\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B)(num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, num9);
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
    public static void cvReleaseStructuringElement(object ick)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReleaseStructuringElement\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReleaseStructuringElement\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReleaseStructuringElement", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$IplConvKernel;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ick);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvReleaseStructuringElement\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024IplConvKernel\u003B\u0029V)(num2, num3, num4);
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
    public static double cvGetSpatialMoment(object cm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetSpatialMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetSpatialMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetSpatialMoment", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvMoments;II)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetSpatialMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static double cvGetCentralMoment(object cm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetCentralMoment", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvMoments;II)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static double cvGetNormalizedCentralMoment(object cm, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetNormalizedCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetNormalizedCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetNormalizedCentralMoment", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvMoments;II)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetNormalizedCentralMoment\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BII\u0029D)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static void cvGetHuMoments(object cm, object chm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetHuMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHuMoments\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetHuMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHuMoments\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetHuMoments", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvMoments;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHuMoments;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(chm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetHuMoments\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvMoments\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHuMoments\u003B\u0029V)(num2, num3, num4, num5);
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
    public static int cvSampleLine(object ca, object cp1, object cp2, object p, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSampleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSampleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSampleLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacpp/Pointer;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvSampleLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BI\u0029I)((int) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
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
    public static void cvGetRectSubPix(object ca1, object ca2, object cpd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetRectSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetRectSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetRectSubPix", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetRectSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void cvGetQuadrangleSubPix(object ca1, object ca2, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetQuadrangleSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetQuadrangleSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetQuadrangleSubPix", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetQuadrangleSubPix\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void cvMatchTemplate(object ca1, object ca2, object ca3, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMatchTemplate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMatchTemplate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMatchTemplate", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvMatchTemplate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static float cvCalcEMD2(object ca1, object ca2, int i, object cdf, object ca3, object ca4, float[] farr, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcEMD2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvDistanceFunction\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029F == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcEMD2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvDistanceFunction\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029F = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcEMD2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_imgproc$CvDistanceFunction;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[FLcom/googlecode/javacpp/Pointer;)F");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cdf);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<float (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcEMD2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvDistanceFunction\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BFLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029F)(num2, num3, num4, num5, (IntPtr) num6, (int) num7, num8, num9, num10, num11);
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

    [LineNumberTable((ushort) 765)]
    public static object cvStartFindContours(object image, object storage, int header_size, int mode, int method)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [Modifiers]
    public static object cvFindNextContour(object ccs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindNextContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindNextContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindNextContour", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvContourScanner;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindNextContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4);
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
    public static void cvSubstituteContour(object ccs, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubstituteContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubstituteContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubstituteContour", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvContourScanner;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubstituteContour\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B\u0029V)(num2, num3, num4, num5);
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
    public static object cvEndFindContours(object ccs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvEndFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvEndFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvEndFindContours", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvContourScanner;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvEndFindContours\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvContourScanner\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4);
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
    public static object cvApproxChains(object cs, object cms, int i1, double d, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvApproxChains\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvApproxChains\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvApproxChains", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;IDII)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num6 = i1;
        double num7 = d;
        int num8 = i2;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, double, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvApproxChains\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((int) num2, (int) num3, (double) num4, (int) num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
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
    public static void cvStartReadChainPoints(object cc, object ccpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvStartReadChainPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvChain\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvStartReadChainPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvChain\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvStartReadChainPoints", "(Lcom/googlecode/javacv/cpp/opencv_core$CvChain;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvChainPtReader;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ccpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvStartReadChainPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvChain\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029V)(num2, num3, num4, num5);
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
    public static object cvReadChainPoint(object ccpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReadChainPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReadChainPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReadChainPoint", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvChainPtReader;)Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ccpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvReadChainPoint\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvChainPtReader\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B)(num2, num3, num4);
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

    [LineNumberTable((ushort) 784)]
    public static object cvCreateSubdivDelaunay2D(object rect, object storage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rect, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvSubdiv2D");
    }

    [Modifiers]
    public static object cvSubdivDelaunay2DInsert(object csd, object cpd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdivDelaunay2DInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdivDelaunay2DInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdivDelaunay2DInsert", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DPoint;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdivDelaunay2DInsert\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B)(num2, num3, num4, num5);
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
    public static int cvSubdiv2DLocate(object csd, object cpd, object stp, object csdp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DLocate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DLocate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DLocate", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacpp/SizeTPointer;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DPoint;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(stp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(csdp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DLocate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
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
    public static void cvCalcSubdivVoronoi2D(object csd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcSubdivVoronoi2D", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V)(num2, num3, num4);
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
    public static void cvClearSubdivVoronoi2D(object csd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvClearSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvClearSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvClearSubdivVoronoi2D", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvClearSubdivVoronoi2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003B\u0029V)(num2, num3, num4);
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
    public static object cvFindNearestPoint2D(object csd, object cpd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindNearestPoint2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindNearestPoint2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindNearestPoint2D", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2D;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DPoint;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindNearestPoint2D\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B)(num2, num3, num4, num5);
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

    [LineNumberTable((ushort) 797)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvSubdiv2DNextEdge(object edge)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(edge, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvSubdiv2DEdge");
      return opencv_imgproc.CV_SUBDIV2D_NEXT_EDGE(edge);
    }

    [Modifiers]
    public static object cvSubdiv2DRotateEdge(object csde, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DRotateEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DRotateEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DRotateEdge", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;I)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DRotateEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object cvSubdiv2DSymEdge(object csde)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DSymEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DSymEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DSymEdge", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DSymEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B)(num2, num3, num4);
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
    public static object cvSubdiv2DGetEdge(object csde, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DGetEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DGetEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DGetEdge", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;I)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DGetEdge\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object cvSubdiv2DEdgeOrg(object csde)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeOrg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeOrg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DEdgeOrg", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DPoint;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeOrg\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B)(num2, num3, num4);
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
    public static object cvSubdiv2DEdgeDst(object csde)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeDst\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeDst\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvSubdiv2DEdgeDst", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DEdge;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvSubdiv2DPoint;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(csde);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvSubdiv2DEdgeDst\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DEdge\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvSubdiv2DPoint\u003B)(num2, num3, num4);
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
    public static double cvTriangleArea(object cpd1, object cpd2, object cpd3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvTriangleArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvTriangleArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvTriangleArea", "(Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cpd3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvTriangleArea\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029D)(num2, num3, num4, num5, num6);
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
    public static object cvApproxPoly(object p, int i1, object cms, int i2, double d, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvApproxPoly\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvApproxPoly\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvApproxPoly", "(Lcom/googlecode/javacpp/Pointer;ILcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;IDI)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        int num7 = i2;
        double num8 = d;
        int num9 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvApproxPoly\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BIDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((int) num2, (double) num3, (int) num4, (IntPtr) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
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

    [LineNumberTable((ushort) 812)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cvContourPerimeter(object contour)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(contour, __typeref (opencv_imgproc), "com.googlecode.javacpp.Pointer");
      object p = contour;
      object obj = opencv_core.__\u003C\u003ECV_WHOLE_SEQ;
      int num = 1;
      object cs = obj;
      int i = num;
      return opencv_imgproc.cvArcLength(p, cs, i);
    }

    [Modifiers]
    public static object cvBoundingRect(object ca, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvBoundingRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvBoundingRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvBoundingRect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)Lcom/googlecode/javacv/cpp/opencv_core$CvRect;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvBoundingRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static int cvMinEnclosingCircle(object ca, object cpd, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMinEnclosingCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BF\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMinEnclosingCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BF\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMinEnclosingCircle", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;[F)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvMinEnclosingCircle\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BF\u0029I)(num2, num3, num4, num5, num6);
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
    public static double cvMatchShapes(object p1, object p2, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMatchShapes\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BID\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMatchShapes\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BID\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMatchShapes", "(Lcom/googlecode/javacpp/Pointer;Lcom/googlecode/javacpp/Pointer;ID)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p2);
        int num6 = i;
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvMatchShapes\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BID\u0029D)((double) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static object cvConvexHull2(object ca, object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvConvexHull2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvConvexHull2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvConvexHull2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/Pointer;II)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvConvexHull2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int cvCheckContourConvexity(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCheckContourConvexity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCheckContourConvexity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCheckContourConvexity", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCheckContourConvexity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029I)(num2, num3, num4);
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
    public static object cvConvexityDefects(object ca1, object ca2, object cms)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvConvexityDefects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvConvexityDefects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvConvexityDefects", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvConvexityDefects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4, num5, num6);
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
    public static object cvFitEllipse2(object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFitEllipse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFitEllipse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFitEllipse2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)Lcom/googlecode/javacv/cpp/opencv_core$CvBox2D;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFitEllipse2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B)(num2, num3, num4);
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
    public static object cvMaxRect(object cr1, object cr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvMaxRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvMaxRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvMaxRect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)Lcom/googlecode/javacv/cpp/opencv_core$CvRect;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cr1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvMaxRect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B)(num2, num3, num4, num5);
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
    public static void cvBoxPoints(object cbd, object cpd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvBoxPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvBoxPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvBoxPoints", "(Lcom/googlecode/javacv/cpp/opencv_core$CvBox2D;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbd);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvBoxPoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u0029V)(num2, num3, num4, num5);
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
    public static object cvPointSeqFromMat(int i, object ca, object cc, object csb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPointSeqFromMat\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvContour\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPointSeqFromMat\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvContour\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPointSeqFromMat", "(ILcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvContour;Lcom/googlecode/javacv/cpp/opencv_core$CvSeqBlock;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(csb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvPointSeqFromMat\u0028ILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvContour\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeqBlock\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, (IntPtr) num4, (int) num5, num6, num7);
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
    public static double cvPointPolygonTest(object ca, object cpd, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPointPolygonTest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPointPolygonTest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPointPolygonTest", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvPointPolygonTest\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BI\u0029D)((int) num2, num3, num4, num5, (IntPtr) num6);
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

    [LineNumberTable((ushort) 882)]
    public static bool CV_IS_HIST(object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 886)]
    public static bool CV_IS_UNIFORM_HIST(object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 889)]
    public static bool CV_IS_SPARSE_HIST(object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 892)]
    public static bool CV_HIST_HAS_RANGES(object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
    }

    [LineNumberTable((ushort) 897)]
    public static object cvCreateHist(int dims, int[] sizes, int type, float[][] ranges, int uniform)
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 903)]
    public static void cvSetHistBinRanges(object hist, float[][] ranges, int uniform)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 910)]
    public static object cvMakeHistHeaderForArray(int dims, int[] sizes, object hist, float[] data, float[][] ranges, int uniform)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 916)]
    public static object cvMakeHistHeaderForArray(int dims, int[] sizes, object hist, FloatBuffer data, float[][] ranges, int uniform)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static void cvReleaseHist(object ch)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReleaseHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReleaseHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReleaseHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvReleaseHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, num3, num4);
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
    public static void cvClearHist(object ch)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvClearHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvClearHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvClearHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvClearHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, num3, num4);
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
    public static void cvGetMinMaxHistValue(object ch, float[] farr1, float[] farr2, int[] iarr1, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGetMinMaxHistValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BF\u005BF\u005BI\u005BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGetMinMaxHistValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BF\u005BF\u005BI\u005BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGetMinMaxHistValue", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;[F[F[I[I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvGetMinMaxHistValue\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u005BF\u005BF\u005BI\u005BI\u0029V)(num2, num3, num4, num5, num6, num7, num8);
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
    public static void cvNormalizeHist(object ch, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvNormalizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvNormalizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvNormalizeHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        double num5 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvNormalizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V)((double) num2, num3, num4, (IntPtr) num5);
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
    public static void cvThreshHist(object ch, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvThreshHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvThreshHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvThreshHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch);
        double num5 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvThreshHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V)((double) num2, num3, num4, (IntPtr) num5);
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
    public static double cvCompareHist(object ch1, object ch2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCompareHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BI\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCompareHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCompareHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ch2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCompareHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BI\u0029D)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvCopyHist(object ch1, object ch2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCopyHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCopyHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCopyHist", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ch2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCopyHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void cvCalcBayesianProb(object ch1, int i, object ch2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcBayesianProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcBayesianProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcBayesianProb", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;ILcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch1);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ch2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcBayesianProb\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
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

    [LineNumberTable((ushort) 932)]
    public static void cvCalcArrHist(object arr, object hist, int accumulate, object mask)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mask, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 937)]
    public static void cvCalcHist(object arr, object hist, int accumulate, object mask)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(arr, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(mask, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 945)]
    public static void cvCalcArrBackProject(object image, object dst, object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 950)]
    public static void cvCalcBackProject(object image, object dst, object hist)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 959)]
    public static void cvCalcArrBackProjectPatch(object image, object dst, object range, object hist, int method, double factor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$CvArr;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(range, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [LineNumberTable((ushort) 965)]
    public static void cvCalcBackProjectPatch(object image, object dst, object range, object hist, int method, double factor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_imgproc), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(range, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_core$CvSize");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(hist, __typeref (opencv_imgproc), "com.googlecode.javacv.cpp.opencv_imgproc$CvHistogram");
      throw new NoClassDefFoundError("com.googlecode.javacpp.PointerPointer");
    }

    [Modifiers]
    public static void cvCalcProbDensity(object ch1, object ch2, object ch3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCalcProbDensity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCalcProbDensity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCalcProbDensity", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvHistogram;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ch1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ch2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ch3);
        double num7 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvCalcProbDensity\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvHistogram\u003BD\u0029V)((double) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static void cvEqualizeHist(object ca1, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvEqualizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvEqualizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvEqualizeHist", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvEqualizeHist\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void cvDistTransform(object ca1, object ca2, int i1, int i2, object fp, object ca3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvDistTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvDistTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvDistTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IILcom/googlecode/javacpp/FloatPointer;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(fp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvDistTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FFloatPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, (int) num4, (int) num5, (IntPtr) num6, (IntPtr) num7, num8, num9);
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
    public static double cvThreshold(object ca1, object ca2, double d1, double d2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029D == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029D = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvThreshold", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDI)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, double, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029D)((int) num2, (double) num3, (double) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvAdaptiveThreshold(object ca1, object ca2, double d1, int i1, int i2, int i3, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvAdaptiveThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIID\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvAdaptiveThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIID\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvAdaptiveThreshold", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DIIID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        int num7 = i1;
        int num8 = i2;
        int num9 = i3;
        double num10 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, int, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvAdaptiveThreshold\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIID\u0029V)((double) num2, (int) num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void cvFloodFill(object ca1, object cp, object cs1, object cs2, object cs3, object ccc, int i, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFloodFill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFloodFill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFloodFill", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvConnectedComp;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs3);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(ccc);
        int num10 = i;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFloodFill\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, (int) num3, num4, num5, num6, num7, num8, num9, (IntPtr) num10, num11);
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
    public static void cvCanny(object ca1, object ca2, double d1, double d2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCanny\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCanny\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCanny", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        int num8 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCanny\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V)((int) num2, (double) num3, (double) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvPreCornerDetect(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvPreCornerDetect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvPreCornerDetect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvPreCornerDetect", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvPreCornerDetect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvCornerEigenValsAndVecs(object ca1, object ca2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCornerEigenValsAndVecs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCornerEigenValsAndVecs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCornerEigenValsAndVecs", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCornerEigenValsAndVecs\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void cvCornerMinEigenVal(object ca1, object ca2, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCornerMinEigenVal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCornerMinEigenVal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCornerMinEigenVal", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvCornerMinEigenVal\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BII\u0029V)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void cvCornerHarris(object ca1, object ca2, int i1, int i2, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCornerHarris\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCornerHarris\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCornerHarris", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i1;
        int num7 = i2;
        double num8 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, int, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvCornerHarris\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V)((double) num2, (int) num3, (int) num4, num5, (IntPtr) num6, (IntPtr) num7, (IntPtr) num8);
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
    public static void cvGoodFeaturesToTrack(object ca1, object ca2, object ca3, object cpd, int[] iarr, double d1, double d2, object ca4, int i1, int i2, double d3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvGoodFeaturesToTrack\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BIDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvGoodFeaturesToTrack\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BIDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvGoodFeaturesToTrack", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;[IDDLcom/googlecode/javacv/cpp/opencv_core$CvArr;IID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cpd);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        double num9 = d1;
        double num10 = d2;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        int num12 = i1;
        int num13 = i2;
        double num14 = d3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, IntPtr, int, int, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvGoodFeaturesToTrack\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BIDDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIID\u0029V)((double) num2, (int) num3, (int) num4, num5, (double) num6, (double) num7, num8, (IntPtr) num9, (IntPtr) num10, num11, (IntPtr) num12, (IntPtr) num13, (IntPtr) num14);
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
    public static object cvHoughLines2(object ca, object p, int i1, double d1, double d2, int i2, double d3, double d4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvHoughLines2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvHoughLines2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvHoughLines2", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/Pointer;IDDIDD)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        double num7 = d1;
        double num8 = d2;
        int num9 = i2;
        double num10 = d3;
        double num11 = d4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, double, double, int, double, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvHoughLines2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((double) num2, (double) num3, (int) num4, (double) num5, (double) num6, (int) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
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
    public static object cvHoughCircles(object ca, object p, int i1, double d1, double d2, double d3, double d4, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvHoughCircles\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDDDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvHoughCircles\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDDDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvHoughCircles", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacpp/Pointer;IDDDDII)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num6 = i1;
        double num7 = d1;
        double num8 = d2;
        double num9 = d3;
        double num10 = d4;
        int num11 = i2;
        int num12 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, int, double, double, double, double, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvHoughCircles\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BIDDDDII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((int) num2, (int) num3, (double) num4, (double) num5, (double) num6, num7, (int) num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12);
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
    public static void cvFitLine(object ca, int i, double d1, double d2, double d3, float[] farr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDD\u005BF\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDD\u005BF\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFitLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IDDD[F)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        double num6 = d1;
        double num7 = d2;
        double num8 = d3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, double, double, double, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDD\u005BF\u0029V)(num2, (double) num3, (double) num4, (double) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, num9);
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
    public static void cvFitLine(object ca, int i, double d1, double d2, double d3, FloatBuffer fb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFitLine", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IDDDLjava/nio/FloatBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        double num6 = d1;
        double num7 = d2;
        double num8 = d3;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, double, double, double, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFitLine\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIDDDLjava\u002Fnio\u002FFloatBuffer\u003B\u0029V)(num2, (double) num3, (double) num4, (double) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, num9);
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
    public static object cvCreateKDTree(object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateKDTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateKDTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateKDTree", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvFeatureTree;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateKDTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B)(num2, num3, num4);
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
    public static object cvCreateSpillTree(object cm, int i, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateSpillTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateSpillTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateSpillTree", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;IDD)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvFeatureTree;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i;
        double num6 = d1;
        double num7 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, double, double)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateSpillTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BIDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B)((double) num2, (double) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void cvReleaseFeatureTree(object cft)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReleaseFeatureTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReleaseFeatureTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReleaseFeatureTree", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvFeatureTree;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvReleaseFeatureTree\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003B\u0029V)(num2, num3, num4);
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
    public static void cvFindFeatures(object cft, object cm1, object cm2, object cm3, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindFeatures\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindFeatures\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindFeatures", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvFeatureTree;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindFeatures\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V)((int) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
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
    public static int cvFindFeaturesBoxed(object cft, object cm1, object cm2, object cm3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvFindFeaturesBoxed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvFindFeaturesBoxed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvFindFeaturesBoxed", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvFeatureTree;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cft);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvFindFeaturesBoxed\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvFeatureTree\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
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
    public static object cvCreateLSH(object clsho, int i1, int i2, int i3, int i4, double d, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSHOperations\u003BIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSHOperations\u003BIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateLSH", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSHOperations;IIIIDJ)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsho);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        double num9 = d;
        long num10 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int, int, double, long)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSHOperations\u003BIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B)((long) num2, (double) num3, (int) num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10);
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
    public static object cvCreateMemoryLSH(int i1, int i2, int i3, int i4, int i5, double d, long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvCreateMemoryLSH\u0028IIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvCreateMemoryLSH\u0028IIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvCreateMemoryLSH", "(IIIIIDJ)Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        int num8 = i5;
        double num9 = d;
        long num10 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, int, double, long)>) opencv_imgproc.__\u003Cjniptr\u003EcvCreateMemoryLSH\u0028IIIIIDJ\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B)((long) num2, (double) num3, num4, num5, num6, num7, num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void cvReleaseLSH(object clsh)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvReleaseLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvReleaseLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvReleaseLSH", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsh);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvReleaseLSH\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029V)(num2, num3, num4);
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
    public static int LSHSize(object clsh)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003ELSHSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029I == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003ELSHSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "LSHSize", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsh);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003ELSHSize\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003B\u0029I)(num2, num3, num4);
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
    public static void cvLSHAdd(object clsh, object cm1, object cm2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLSHAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLSHAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLSHAdd", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsh);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvLSHAdd\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5, num6);
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
    public static void cvLSHRemove(object clsh, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLSHRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLSHRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLSHRemove", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsh);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_imgproc.__\u003Cjniptr\u003EcvLSHRemove\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void cvLSHQuery(object clsh, object cm1, object cm2, object cm3, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_imgproc.__\u003Cjniptr\u003EcvLSHQuery\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V == IntPtr.Zero)
        opencv_imgproc.__\u003Cjniptr\u003EcvLSHQuery\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_imgproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_imgproc", "cvLSHQuery", "(Lcom/googlecode/javacv/cpp/opencv_imgproc$CvLSH;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_imgproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_imgproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsh);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cm3);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_imgproc.__\u003Cjniptr\u003EcvLSHQuery\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvLSH\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BII\u0029V)((int) num2, (int) num3, num4, num5, num6, num7, (IntPtr) num8, (IntPtr) num9);
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

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (opencv_imgproc.__\u003CcallerID\u003E == null)
        opencv_imgproc.__\u003CcallerID\u003E = (CallerID) new opencv_imgproc.__\u003CCallerID\u003E();
      return opencv_imgproc.__\u003CcallerID\u003E;
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
