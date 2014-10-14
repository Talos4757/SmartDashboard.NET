// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_video
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
  public class opencv_video : Object
  {
    public const int CV_LKFLOW_PYR_A_READY = 1;
    public const int CV_LKFLOW_PYR_B_READY = 2;
    public const int CV_LKFLOW_INITIAL_GUESSES = 4;
    public const int CV_LKFLOW_GET_MIN_EIGENVALS = 8;
    public const int OPTFLOW_USE_INITIAL_FLOW = 4;
    public const int OPTFLOW_FARNEBACK_GAUSSIAN = 256;
    public const int CV_BG_MODEL_FGD = 0;
    public const int CV_BG_MODEL_MOG = 1;
    public const int CV_BG_MODEL_FGD_SIMPLE = 2;
    public const int CV_BGFG_FGD_LC = 128;
    public const int CV_BGFG_FGD_N1C = 15;
    public const int CV_BGFG_FGD_N2C = 25;
    public const int CV_BGFG_FGD_LCC = 64;
    public const int CV_BGFG_FGD_N1CC = 25;
    public const int CV_BGFG_FGD_N2CC = 40;
    public const float CV_BGFG_FGD_ALPHA_1 = 0.1f;
    public const float CV_BGFG_FGD_ALPHA_2 = 0.005f;
    public const float CV_BGFG_FGD_ALPHA_3 = 0.1f;
    public const float CV_BGFG_FGD_DELTA = 2f;
    public const float CV_BGFG_FGD_T = 0.9f;
    public const float CV_BGFG_FGD_MINAREA = 15f;
    public const float CV_BGFG_FGD_BG_UPDATE_TRESH = 0.5f;
    public const int CV_BGFG_MOG_MAX_NGAUSSIANS = 500;
    public const int CV_BGFG_MOG_WINDOW_SIZE = 200;
    public const int CV_BGFG_MOG_NGAUSSIANS = 5;
    public const int CV_BGFG_MOG_NCOLORS = 3;
    public const double CV_BGFG_MOG_BACKGROUND_THRESHOLD = 0.7;
    public const double CV_BGFG_MOG_STD_THRESHOLD = 2.5;
    public const double CV_BGFG_MOG_WEIGHT_INIT = 0.05;
    public const double CV_BGFG_MOG_SIGMA_INIT = 30.0;
    public const double CV_BGFG_MOG_MINAREA = 15.0;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowBM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowHS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvEstimateRigidTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCalcOpticalFlowFarneback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIIIDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUpdateMotionHistory\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcMotionGradient\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCalcGlobalOrientation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSegmentMotion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCamShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvMeanShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateKalman\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseKalman\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvKalmanPredict\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvKalmanCorrect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvUpdateBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003BD\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvRefineForegroundMaskBySegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvChangeDetection\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateFGDStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvFGDStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateGaussianBGModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvGaussBGStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateBGCodeBookModel\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseBGCodeBookModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvBGCodeBookUpdate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvBGCodeBookDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvBGCodeBookClearStale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSegmentFGMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;

    [LineNumberTable((ushort) 85)]
    static opencv_video()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<opencv_imgproc>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 232, (byte) 161, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_video()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object cvKalmanPredict(object ck, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvKalmanPredict\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvKalmanPredict\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvKalmanPredict", "(Lcom/googlecode/javacv/cpp/opencv_video$CvKalman;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ck);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvKalmanPredict\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5);
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
    public static object cvKalmanCorrect(object ck, object cm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvKalmanCorrect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvKalmanCorrect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvKalmanCorrect", "(Lcom/googlecode/javacv/cpp/opencv_video$CvKalman;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ck);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvKalmanCorrect\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5);
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
    public static void cvCalcOpticalFlowLK(object ca1, object ca2, object cs, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowLK", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
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
    public static void cvCalcOpticalFlowBM(object ca1, object ca2, object cs1, object cs2, object cs3, int i, object ca3, object ca4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowBM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowBM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowBM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cs3);
        int num9 = i;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowBM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, (int) num4, num5, num6, num7, num8, (IntPtr) num9, num10, num11);
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
    public static void cvCalcOpticalFlowHS(object ca1, object ca2, int i, object ca3, object ca4, double d, object ctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowHS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowHS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowHS", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;ILcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DLcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        double num9 = d;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, double, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowHS\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003B\u0029V)(num2, (double) num3, num4, num5, num6, num7, num8, (IntPtr) num9, num10);
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
    public static void cvCalcOpticalFlowPyrLK(object ca1, object ca2, object ca3, object ca4, object cpd1, object cpd2, int i1, object cs, int i2, byte[] barr, float[] farr, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowPyrLK", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSize;I[B[FLcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        int num10 = i1;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num12 = i2;
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) farr);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num16 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, num5, (int) num6, num7, (int) num8, num9, (IntPtr) num10, num11, (IntPtr) num12, num13, num14, num15, (IntPtr) num16);
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
    public static void cvCalcOpticalFlowPyrLK(object ca1, object ca2, object ca3, object ca4, object cpd1, object cpd2, int i1, object cs, int i2, byte[] barr, FloatBuffer fb, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowPyrLK", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;ILcom/googlecode/javacv/cpp/opencv_core$CvSize;I[BLjava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        int num10 = i1;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num12 = i2;
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) fb);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num16 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, num5, (int) num6, num7, (int) num8, num9, (IntPtr) num10, num11, (IntPtr) num12, num13, num14, num15, (IntPtr) num16);
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
    public static void cvCalcAffineFlowPyrLK(object ca1, object ca2, object ca3, object ca4, object cpd1, object cpd2, float[] farr1, int i1, object cs, int i2, byte[] barr, float[] farr2, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcAffineFlowPyrLK", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;[FILcom/googlecode/javacv/cpp/opencv_core$CvSize;I[B[FLcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) farr1);
        int num11 = i1;
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num13 = i2;
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef((object) farr2);
        // ISSUE: explicit reference operation
        IntPtr num16 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num17 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003B\u005BFILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BB\u005BFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, num5, (int) num6, num7, (int) num8, num9, num10, (IntPtr) num11, num12, (IntPtr) num13, num14, num15, num16, (IntPtr) num17);
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
    public static void cvCalcAffineFlowPyrLK(object ca1, object ca2, object ca3, object ca4, object cpd1, object cpd2, FloatBuffer fb1, int i1, object cs, int i2, byte[] barr, FloatBuffer fb2, object ctc, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcAffineFlowPyrLK", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint2D32f;Ljava/nio/FloatBuffer;ILcom/googlecode/javacv/cpp/opencv_core$CvSize;I[BLjava/nio/FloatBuffer;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca4);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cpd1);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(cpd2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) fb1);
        int num11 = i1;
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num13 = i2;
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: explicit reference operation
        IntPtr num15 = ((JNI.Frame) @frame).MakeLocalRef((object) fb2);
        // ISSUE: explicit reference operation
        IntPtr num16 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        int num17 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcAffineFlowPyrLK\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint2D32f\u003BLjava\u002Fnio\u002FFloatBuffer\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u005BBLjava\u002Fnio\u002FFloatBuffer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BI\u0029V)((int) num2, num3, num4, num5, (int) num6, num7, (int) num8, num9, num10, (IntPtr) num11, num12, (IntPtr) num13, num14, num15, num16, (IntPtr) num17);
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
    public static int cvEstimateRigidTransform(object ca1, object ca2, object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvEstimateRigidTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvEstimateRigidTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvEstimateRigidTransform", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMat;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num7 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_video.__\u003Cjniptr\u003EcvEstimateRigidTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029I)((int) num2, num3, num4, num5, num6, (IntPtr) num7);
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
    public static void cvCalcOpticalFlowFarneback(object ca1, object ca2, object ca3, double d1, int i1, int i2, int i3, int i4, double d2, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowFarneback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIIIDI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowFarneback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIIIDI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcOpticalFlowFarneback", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DIIIIDI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d1;
        int num8 = i1;
        int num9 = i2;
        int num10 = i3;
        int num11 = i4;
        double num12 = d2;
        int num13 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, int, int, double, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcOpticalFlowFarneback\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDIIIIDI\u0029V)((int) num2, (double) num3, (int) num4, (int) num5, (int) num6, (int) num7, (double) num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11, (IntPtr) num12, (IntPtr) num13);
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
    public static void cvUpdateMotionHistory(object ca1, object ca2, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvUpdateMotionHistory\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvUpdateMotionHistory\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvUpdateMotionHistory", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        double num6 = d1;
        double num7 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, double, double)>) opencv_video.__\u003Cjniptr\u003EcvUpdateMotionHistory\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029V)((double) num2, (double) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void cvCalcMotionGradient(object ca1, object ca2, object ca3, double d1, double d2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcMotionGradient\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcMotionGradient\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcMotionGradient", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DDI)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d1;
        double num8 = d2;
        int num9 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, int)>) opencv_video.__\u003Cjniptr\u003EcvCalcMotionGradient\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDDI\u0029V)((int) num2, (double) num3, (double) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
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
    public static double cvCalcGlobalOrientation(object ca1, object ca2, object ca3, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCalcGlobalOrientation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029D == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCalcGlobalOrientation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029D = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCalcGlobalOrientation", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;DD)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num7 = d1;
        double num8 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double)>) opencv_video.__\u003Cjniptr\u003EcvCalcGlobalOrientation\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BDD\u0029D)((double) num2, (double) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
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
    public static object cvSegmentMotion(object ca1, object ca2, object cms, double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvSegmentMotion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvSegmentMotion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvSegmentMotion", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;DD)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        double num7 = d1;
        double num8 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double)>) opencv_video.__\u003Cjniptr\u003EcvSegmentMotion\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((double) num2, (double) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
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
    public static int cvCamShift(object ca, object cr, object ctc, object ccc, object cbd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCamShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCamShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCamShift", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvConnectedComp;Lcom/googlecode/javacv/cpp/opencv_core$CvBox2D;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ccc);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cbd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCamShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvBox2D\u003B\u0029I)(num2, num3, num4, num5, num6, num7, num8);
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
    public static int cvMeanShift(object ca, object cr, object ctc, object ccc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvMeanShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003B\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvMeanShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvMeanShift", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvTermCriteria;Lcom/googlecode/javacv/cpp/opencv_imgproc$CvConnectedComp;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ccc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvMeanShift\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvTermCriteria\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_imgproc\u0024CvConnectedComp\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
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
    public static object cvCreateKalman(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCreateKalman\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCreateKalman\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCreateKalman", "(III)Lcom/googlecode/javacv/cpp/opencv_video$CvKalman;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int)>) opencv_video.__\u003Cjniptr\u003EcvCreateKalman\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
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
    public static void cvReleaseKalman(object ck)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvReleaseKalman\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvReleaseKalman\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvReleaseKalman", "(Lcom/googlecode/javacv/cpp/opencv_video$CvKalman;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ck);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvReleaseKalman\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvKalman\u003B\u0029V)(num2, num3, num4);
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

    [LineNumberTable((ushort) 205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvKalmanUpdateByTime(object kalman, object control)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(kalman, __typeref (opencv_video), "com.googlecode.javacv.cpp.opencv_video$CvKalman");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(control, __typeref (opencv_video), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return opencv_video.cvKalmanPredict(kalman, control);
    }

    [LineNumberTable((ushort) 208)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvKalmanUpdateByMeasurement(object kalman, object measurement)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(kalman, __typeref (opencv_video), "com.googlecode.javacv.cpp.opencv_video$CvKalman");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(measurement, __typeref (opencv_video), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return opencv_video.cvKalmanCorrect(kalman, measurement);
    }

    [Modifiers]
    public static void cvReleaseBGStatModel(object cbgsm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvReleaseBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvReleaseBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvReleaseBGStatModel", "(Lcom/googlecode/javacv/cpp/opencv_video$CvBGStatModel;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbgsm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvReleaseBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V)(num2, num3, num4);
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
    public static int cvUpdateBGStatModel(object ii, object cbgsm, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvUpdateBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003BD\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvUpdateBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003BD\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvUpdateBGStatModel", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_video$CvBGStatModel;D)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cbgsm);
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_video.__\u003Cjniptr\u003EcvUpdateBGStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003BD\u0029I)((double) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void cvRefineForegroundMaskBySegm(object cs, object cbgsm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvRefineForegroundMaskBySegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvRefineForegroundMaskBySegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvRefineForegroundMaskBySegm", "(Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_video$CvBGStatModel;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cbgsm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvRefineForegroundMaskBySegm\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B\u0029V)(num2, num3, num4, num5);
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
    public static int cvChangeDetection(object ii1, object ii2, object ii3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvChangeDetection\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvChangeDetection\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvChangeDetection", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ii3);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvChangeDetection\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I)(num2, num3, num4, num5, num6);
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
    public static object cvCreateFGDStatModel(object ii, object cfgdsmp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCreateFGDStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvFGDStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCreateFGDStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvFGDStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCreateFGDStatModel", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_video$CvFGDStatModelParams;)Lcom/googlecode/javacv/cpp/opencv_video$CvBGStatModel;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cfgdsmp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCreateFGDStatModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvFGDStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B)(num2, num3, num4, num5);
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
    public static object cvCreateGaussianBGModel(object ii, object cgbgsmp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCreateGaussianBGModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvGaussBGStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCreateGaussianBGModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvGaussBGStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCreateGaussianBGModel", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_video$CvGaussBGStatModelParams;)Lcom/googlecode/javacv/cpp/opencv_video$CvBGStatModel;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cgbgsmp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCreateGaussianBGModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvGaussBGStatModelParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGStatModel\u003B)(num2, num3, num4, num5);
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
    public static object cvCreateBGCodeBookModel()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvCreateBGCodeBookModel\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvCreateBGCodeBookModel\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvCreateBGCodeBookModel", "()Lcom/googlecode/javacv/cpp/opencv_video$CvBGCodeBookModel;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvCreateBGCodeBookModel\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B)(num2, num3);
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
    public static void cvReleaseBGCodeBookModel(object cbgcbm)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvReleaseBGCodeBookModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvReleaseBGCodeBookModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvReleaseBGCodeBookModel", "(Lcom/googlecode/javacv/cpp/opencv_video$CvBGCodeBookModel;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbgcbm);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvReleaseBGCodeBookModel\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003B\u0029V)(num2, num3, num4);
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
    public static void cvBGCodeBookUpdate(object cbgcbm, object ca1, object cr, object ca2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvBGCodeBookUpdate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvBGCodeBookUpdate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvBGCodeBookUpdate", "(Lcom/googlecode/javacv/cpp/opencv_video$CvBGCodeBookModel;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbgcbm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvBGCodeBookUpdate\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
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
    public static int cvBGCodeBookDiff(object cbgcbm, object ca1, object ca2, object cr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvBGCodeBookDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029I == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvBGCodeBookDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvBGCodeBookDiff", "(Lcom/googlecode/javacv/cpp/opencv_video$CvBGCodeBookModel;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvRect;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbgcbm);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvBGCodeBookDiff\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003B\u0029I)(num2, num3, num4, num5, num6, num7);
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
    public static void cvBGCodeBookClearStale(object cbgcbm, int i, object cr, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvBGCodeBookClearStale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvBGCodeBookClearStale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvBGCodeBookClearStale", "(Lcom/googlecode/javacv/cpp/opencv_video$CvBGCodeBookModel;ILcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cbgcbm);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvBGCodeBookClearStale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_video\u0024CvBGCodeBookModel\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
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
    public static object cvSegmentFGMask(object ca, int i, float f, object cms, object cp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_video.__\u003Cjniptr\u003EcvSegmentFGMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_video.__\u003Cjniptr\u003EcvSegmentFGMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_video.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_video", "cvSegmentFGMask", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;IFLcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_video.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_video>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        int num5 = i;
        double num6 = (double) f;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, float, IntPtr, IntPtr)>) opencv_video.__\u003Cjniptr\u003EcvSegmentFGMask\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BIFLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, (float) num4, num5, (IntPtr) num6, num7, num8);
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
      if (opencv_video.__\u003CcallerID\u003E == null)
        opencv_video.__\u003CcallerID\u003E = (CallerID) new opencv_video.__\u003CCallerID\u003E();
      return opencv_video.__\u003CcallerID\u003E;
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
