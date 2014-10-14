// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_highgui
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv.cpp
{
  public class opencv_highgui : Object
  {
    public const int CV_FONT_LIGHT = 25;
    public const int CV_FONT_NORMAL = 50;
    public const int CV_FONT_DEMIBOLD = 63;
    public const int CV_FONT_BOLD = 75;
    public const int CV_FONT_BLACK = 87;
    public const int CV_STYLE_NORMAL = 0;
    public const int CV_STYLE_ITALIC = 1;
    public const int CV_STYLE_OBLIQUE = 2;
    public static int CV_PUSH_BUTTON;
    public static int CV_CHECKBOX;
    public static int CV_RADIOBOX;
    public const int CV_WND_PROP_FULLSCREEN = 0;
    public const int CV_WND_PROP_AUTOSIZE = 1;
    public const int CV_WND_PROP_ASPECTRATIO = 2;
    public const int CV_WINDOW_NORMAL = 0;
    public const int CV_WINDOW_AUTOSIZE = 1;
    public const int CV_GUI_EXPANDED = 0;
    public const int CV_GUI_NORMAL = 16;
    public const int CV_WINDOW_FULLSCREEN = 1;
    public const int CV_WINDOW_FREERATIO = 256;
    public const int CV_WINDOW_KEEPRATIO = 0;
    public const int CV_EVENT_MOUSEMOVE = 0;
    public const int CV_EVENT_LBUTTONDOWN = 1;
    public const int CV_EVENT_RBUTTONDOWN = 2;
    public const int CV_EVENT_MBUTTONDOWN = 3;
    public const int CV_EVENT_LBUTTONUP = 4;
    public const int CV_EVENT_RBUTTONUP = 5;
    public const int CV_EVENT_MBUTTONUP = 6;
    public const int CV_EVENT_LBUTTONDBLCLK = 7;
    public const int CV_EVENT_RBUTTONDBLCLK = 8;
    public const int CV_EVENT_MBUTTONDBLCLK = 9;
    public const int CV_EVENT_FLAG_LBUTTON = 1;
    public const int CV_EVENT_FLAG_RBUTTON = 2;
    public const int CV_EVENT_FLAG_MBUTTON = 4;
    public const int CV_EVENT_FLAG_CTRLKEY = 8;
    public const int CV_EVENT_FLAG_SHIFTKEY = 16;
    public const int CV_EVENT_FLAG_ALTKEY = 32;
    public const int CV_LOAD_IMAGE_UNCHANGED = -1;
    public const int CV_LOAD_IMAGE_GRAYSCALE = 0;
    public const int CV_LOAD_IMAGE_COLOR = 1;
    public const int CV_LOAD_IMAGE_ANYDEPTH = 2;
    public const int CV_LOAD_IMAGE_ANYCOLOR = 4;
    public const int CV_IMWRITE_JPEG_QUALITY = 1;
    public const int CV_IMWRITE_PNG_COMPRESSION = 16;
    public const int CV_IMWRITE_PXM_BINARY = 32;
    public const int CV_CVTIMG_FLIP = 1;
    public const int CV_CVTIMG_SWAP_RB = 2;
    public const int CV_CAP_ANY = 0;
    public const int CV_CAP_MIL = 100;
    public const int CV_CAP_VFW = 200;
    public const int CV_CAP_V4L = 200;
    public const int CV_CAP_V4L2 = 200;
    public const int CV_CAP_FIREWARE = 300;
    public const int CV_CAP_FIREWIRE = 300;
    public const int CV_CAP_IEEE1394 = 300;
    public const int CV_CAP_DC1394 = 300;
    public const int CV_CAP_CMU1394 = 300;
    public const int CV_CAP_STEREO = 400;
    public const int CV_CAP_TYZX = 400;
    public const int CV_TYZX_LEFT = 400;
    public const int CV_TYZX_RIGHT = 401;
    public const int CV_TYZX_COLOR = 402;
    public const int CV_TYZX_Z = 403;
    public const int CV_CAP_QT = 500;
    public const int CV_CAP_UNICAP = 600;
    public const int CV_CAP_DSHOW = 700;
    public const int CV_CAP_PVAPI = 800;
    public const int CV_CAP_PROP_POS_MSEC = 0;
    public const int CV_CAP_PROP_POS_FRAMES = 1;
    public const int CV_CAP_PROP_POS_AVI_RATIO = 2;
    public const int CV_CAP_PROP_FRAME_WIDTH = 3;
    public const int CV_CAP_PROP_FRAME_HEIGHT = 4;
    public const int CV_CAP_PROP_FPS = 5;
    public const int CV_CAP_PROP_FOURCC = 6;
    public const int CV_CAP_PROP_FRAME_COUNT = 7;
    public const int CV_CAP_PROP_FORMAT = 8;
    public const int CV_CAP_PROP_MODE = 9;
    public const int CV_CAP_PROP_BRIGHTNESS = 10;
    public const int CV_CAP_PROP_CONTRAST = 11;
    public const int CV_CAP_PROP_SATURATION = 12;
    public const int CV_CAP_PROP_HUE = 13;
    public const int CV_CAP_PROP_GAIN = 14;
    public const int CV_CAP_PROP_EXPOSURE = 15;
    public const int CV_CAP_PROP_CONVERT_RGB = 16;
    public const int CV_CAP_PROP_WHITE_BALANCE = 17;
    public const int CV_CAP_PROP_RECTIFICATION = 18;
    public const int CV_CAP_PROP_MONOCROME = 19;
    public const int CV_FOURCC_PROMPT = -1;
    internal static int __\u003C\u003ECV_FOURCC_DEFAULT;
    static IntPtr __\u003Cjniptr\u003EcvFontQt\u0028Ljava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcvAddText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDisplayOverlay\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDisplayStatusBar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateOpenGLCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvOpenGLCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BDDD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSaveWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLoadWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvStartLoop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024Pt2Func\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvStopLoop\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvCreateButton\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvButtonCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvInitSystem\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvStartWindowThread\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvNamedWindow\u0028Ljava\u002Flang\u002FString\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BID\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvShowImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvResizeWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMoveWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDestroyWindow\u0028Ljava\u002Flang\u002FString\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvDestroyAllWindows\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetWindowHandle\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGetWindowName\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateTrackbar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateTrackbar2\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvSetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvSetMouseCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvMouseCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLoadImage\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvLoadImageM\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSaveImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvDecodeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvDecodeImageM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvEncodeImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B;
    static IntPtr __\u003Cjniptr\u003EcvConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvWaitKey\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateFileCapture\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B;
    static IntPtr __\u003Cjniptr\u003EcvCreateCameraCapture\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B;
    static IntPtr __\u003Cjniptr\u003EcvGrabFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvRetrieveFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvQueryFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseCapture\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029D;
    static IntPtr __\u003Cjniptr\u003EcvSetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BID\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvGetCaptureDomain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvCreateVideoWriter\u0028Ljava\u002Flang\u002FString\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B;
    static IntPtr __\u003Cjniptr\u003EcvWriteFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvReleaseVideoWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B\u0029V;

    [Modifiers]
    public static int CV_FOURCC_DEFAULT
    {
      [HideFromJava] get
      {
        return opencv_highgui.__\u003C\u003ECV_FOURCC_DEFAULT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 216, (byte) 243, (byte) 61, (byte) 161})]
    static opencv_highgui()
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<avformat>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 2;
        ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      __fault
      {
        // ISSUE: variable of the null type
        __Null temp_9 = ClassLiteral<opencv_imgproc>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      // ISSUE: variable of the null type
      __Null local1 = ClassLiteral<opencv_imgproc>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 232, (byte) 161, (byte) 20})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_highgui()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object cvCreateFileCapture(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateFileCapture\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateFileCapture\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateFileCapture", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateFileCapture\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateCameraCapture(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateCameraCapture\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateCameraCapture\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateCameraCapture", "(I)Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateCameraCapture\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSetCaptureProperty(object cc, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BID\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BID\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSetCaptureProperty", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;ID)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        int num5 = i;
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, double)>) opencv_highgui.__\u003Cjniptr\u003EcvSetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BID\u0029I)((double) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGrabFrame(object cc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGrabFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGrabFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGrabFrame", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvGrabFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 325)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvRetrieveFrame(object capture)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(capture, __typeref (opencv_highgui), "com.googlecode.javacv.cpp.opencv_highgui$CvCapture");
      return opencv_highgui.cvRetrieveFrame(capture, 0);
    }

    [Modifiers]
    public static void cvReleaseCapture(object cc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvReleaseCapture\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvReleaseCapture\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvReleaseCapture", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvReleaseCapture\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvQueryFrame(object cc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvQueryFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvQueryFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvQueryFrame", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvQueryFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetCaptureProperty(object cc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029D == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetCaptureProperty", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureProperty\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029D)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvCreateVideoWriter(string str, int i1, double d, object cs, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateVideoWriter\u0028Ljava\u002Flang\u002FString\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateVideoWriter\u0028Ljava\u002Flang\u002FString\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateVideoWriter", "(Ljava/lang/String;IDLcom/googlecode/javacv/cpp/opencv_core$CvSize;I)Lcom/googlecode/javacv/cpp/opencv_highgui$CvVideoWriter;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i1;
        double num6 = d;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, double, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateVideoWriter\u0028Ljava\u002Flang\u002FString\u003BIDLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B)((int) num2, num3, (double) num4, num5, (IntPtr) num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseVideoWriter(object cvw)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvReleaseVideoWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvReleaseVideoWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvReleaseVideoWriter", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvVideoWriter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cvw);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvReleaseVideoWriter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvWriteFrame(object cvw, object ii)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvWriteFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvWriteFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvWriteFrame", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvVideoWriter;Lcom/googlecode/javacv/cpp/opencv_core$IplImage;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cvw);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvWriteFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvVideoWriter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvNamedWindow(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvNamedWindow\u0028Ljava\u002Flang\u002FString\u003BI\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvNamedWindow\u0028Ljava\u002Flang\u002FString\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvNamedWindow", "(Ljava/lang/String;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvNamedWindow\u0028Ljava\u002Flang\u002FString\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLoadImage(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvLoadImage\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvLoadImage\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvLoadImage", "(Ljava/lang/String;I)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvLoadImage\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLoadImageM(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvLoadImageM\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvLoadImageM\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvLoadImageM", "(Ljava/lang/String;I)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvLoadImageM\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvSaveImage(string str, object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSaveImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSaveImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSaveImage", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvSaveImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029I)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvDecodeImage(object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDecodeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDecodeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDecodeImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;I)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvDecodeImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvDecodeImageM(object cm, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDecodeImageM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDecodeImageM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDecodeImageM", "(Lcom/googlecode/javacv/cpp/opencv_core$CvMat;I)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cm);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvDecodeImageM\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvEncodeImage(string str, object ca, int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvEncodeImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvEncodeImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvEncodeImage", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;[I)Lcom/googlecode/javacv/cpp/opencv_core$CvMat;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvEncodeImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMat\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvWaitKey(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvWaitKey\u0028I\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvWaitKey\u0028I\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvWaitKey", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvWaitKey\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvRetrieveFrame(object cc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvRetrieveFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvRetrieveFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvRetrieveFrame", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;I)Lcom/googlecode/javacv/cpp/opencv_core$IplImage;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvRetrieveFrame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    public static int CV_FOURCC(byte c1, byte c2, byte c3, byte c4)
    {
      return ((int) (sbyte) c1 & (int) byte.MaxValue) + (((int) (sbyte) c2 & (int) byte.MaxValue) << 8) + (((int) (sbyte) c3 & (int) byte.MaxValue) << 16) + (((int) (sbyte) c4 & (int) byte.MaxValue) << 24);
    }

    [LineNumberTable((ushort) 367)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CV_FOURCC(char c1, char c2, char c3, char c4)
    {
      return opencv_highgui.CV_FOURCC((byte) (sbyte) c1, (byte) (sbyte) c2, (byte) (sbyte) c3, (byte) (sbyte) c4);
    }

    [Modifiers]
    public static object cvFontQt(string str, int i1, object cs, int i2, int i3, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvFontQt\u0028Ljava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvFontQt\u0028Ljava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvFontQt", "(Ljava/lang/String;ILcom/googlecode/javacv/cpp/opencv_core$CvScalar;III)Lcom/googlecode/javacv/cpp/opencv_core$CvFont;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        int num7 = i2;
        int num8 = i3;
        int num9 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, int)>) opencv_highgui.__\u003Cjniptr\u003EcvFontQt\u0028Ljava\u002Flang\u002FString\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (int) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvAddText(object ca, string str, object cp, object cf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvAddText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvAddText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvAddText", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;Lcom/googlecode/javacv/cpp/opencv_core$CvFont;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvAddText\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvFont\u003B\u0029V)(num2, num3, num4, num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDisplayOverlay(string str1, string str2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDisplayOverlay\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDisplayOverlay\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDisplayOverlay", "(Ljava/lang/String;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvDisplayOverlay\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDisplayStatusBar(string str1, string str2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDisplayStatusBar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDisplayStatusBar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDisplayStatusBar", "(Ljava/lang/String;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvDisplayStatusBar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvCreateOpenGLCallback(string str, object coglc, object p, double d1, double d2, double d3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateOpenGLCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvOpenGLCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BDDD\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateOpenGLCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvOpenGLCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BDDD\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateOpenGLCallback", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_highgui$CvOpenGLCallback;Lcom/googlecode/javacpp/Pointer;DDD)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(coglc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        double num7 = d1;
        double num8 = d2;
        double num9 = d3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, double, double)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateOpenGLCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvOpenGLCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BDDD\u0029V)((double) num2, (double) num3, (double) num4, num5, num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSaveWindowParameters(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSaveWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSaveWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSaveWindowParameters", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvSaveWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvLoadWindowParameters(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvLoadWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvLoadWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvLoadWindowParameters", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvLoadWindowParameters\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvStartLoop(object pf, int i, object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvStartLoop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024Pt2Func\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvStartLoop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024Pt2Func\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvStartLoop", "(Lcom/googlecode/javacv/cpp/opencv_highgui$Pt2Func;ILcom/googlecode/javacpp/PointerPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pf);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvStartLoop\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024Pt2Func\u003BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I)(num2, (int) num3, num4, (IntPtr) num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvStopLoop()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvStopLoop\u0028\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvStopLoop\u0028\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvStopLoop", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvStopLoop\u0028\u0029V)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCreateButton(string str, object cbc, object p, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateButton\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvButtonCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateButton\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvButtonCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateButton", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_highgui$CvButtonCallback;Lcom/googlecode/javacpp/Pointer;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cbc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateButton\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvButtonCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003BII\u0029I)((int) num2, (int) num3, num4, num5, num6, (IntPtr) num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvInitSystem(int i, object pp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvInitSystem\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvInitSystem\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvInitSystem", "(ILcom/googlecode/javacpp/PointerPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvInitSystem\u0028ILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u0029I)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvStartWindowThread()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvStartWindowThread\u0028\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvStartWindowThread\u0028\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvStartWindowThread", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvStartWindowThread\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 177)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvNamedWindow(string name)
    {
      return opencv_highgui.cvNamedWindow(name, 1);
    }

    [Modifiers]
    public static void cvSetWindowProperty(string str, int i, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BID\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BID\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSetWindowProperty", "(Ljava/lang/String;ID)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        double num6 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, double)>) opencv_highgui.__\u003Cjniptr\u003EcvSetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BID\u0029V)((double) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static double cvGetWindowProperty(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BI\u0029D == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BI\u0029D = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetWindowProperty", "(Ljava/lang/String;I)D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvGetWindowProperty\u0028Ljava\u002Flang\u002FString\u003BI\u0029D)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvShowImage(string str, object ca)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvShowImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvShowImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvShowImage", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvShowImage\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003B\u0029V)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvResizeWindow(string str, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvResizeWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvResizeWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvResizeWindow", "(Ljava/lang/String;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) opencv_highgui.__\u003Cjniptr\u003EcvResizeWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvMoveWindow(string str, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvMoveWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvMoveWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvMoveWindow", "(Ljava/lang/String;II)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i1;
        int num6 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int)>) opencv_highgui.__\u003Cjniptr\u003EcvMoveWindow\u0028Ljava\u002Flang\u002FString\u003BII\u0029V)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDestroyWindow(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDestroyWindow\u0028Ljava\u002Flang\u002FString\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDestroyWindow\u0028Ljava\u002Flang\u002FString\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDestroyWindow", "(Ljava/lang/String;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvDestroyWindow\u0028Ljava\u002Flang\u002FString\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvDestroyAllWindows()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvDestroyAllWindows\u0028\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvDestroyAllWindows\u0028\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvDestroyAllWindows", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvDestroyAllWindows\u0028\u0029V)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvGetWindowHandle(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetWindowHandle\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetWindowHandle\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetWindowHandle", "(Ljava/lang/String;)Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvGetWindowHandle\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string cvGetWindowName(object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetWindowName\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetWindowName\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetWindowName", "(Lcom/googlecode/javacpp/Pointer;)Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvGetWindowName\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3, num4);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCreateTrackbar(string str1, string str2, int[] iarr, int i, object ctc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateTrackbar", "(Ljava/lang/String;Ljava/lang/String;[IILcom/googlecode/javacv/cpp/opencv_highgui$CvTrackbarCallback;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback\u003B\u0029I)(num2, (int) num3, num4, num5, num6, (IntPtr) num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvCreateTrackbar2(string str1, string str2, int[] iarr, int i, object ctc, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar2\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar2\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvCreateTrackbar2", "(Ljava/lang/String;Ljava/lang/String;[IILcom/googlecode/javacv/cpp/opencv_highgui$CvTrackbarCallback2;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        int num7 = i;
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(ctc);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvCreateTrackbar2\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u005BIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvTrackbarCallback2\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, (int) num4, num5, num6, (IntPtr) num7, num8, num9);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvGetTrackbarPos(string str1, string str2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetTrackbarPos", "(Ljava/lang/String;Ljava/lang/String;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvGetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003B\u0029I)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetTrackbarPos(string str1, string str2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSetTrackbarPos", "(Ljava/lang/String;Ljava/lang/String;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvSetTrackbarPos\u0028Ljava\u002Flang\u002FString\u003BLjava\u002Flang\u002FString\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvSetMouseCallback(string str, object cmc, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvSetMouseCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvMouseCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvSetMouseCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvMouseCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvSetMouseCallback", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_highgui$CvMouseCallback;Lcom/googlecode/javacpp/Pointer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cmc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvSetMouseCallback\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvMouseCallback\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029V)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 256)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvLoadImage(string filename)
    {
      return opencv_highgui.cvLoadImage(filename, 1);
    }

    [LineNumberTable((ushort) 258)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvLoadImageM(string filename)
    {
      return opencv_highgui.cvLoadImageM(filename, 1);
    }

    [LineNumberTable((ushort) 266)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvSaveImage(string filename, object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_highgui), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      return opencv_highgui.cvSaveImage(filename, image, (int[]) null);
    }

    [LineNumberTable((ushort) 269)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvDecodeImage(object buf)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(buf, __typeref (opencv_highgui), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return opencv_highgui.cvDecodeImage(buf, 1);
    }

    [LineNumberTable((ushort) 271)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvDecodeImageM(object buf)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(buf, __typeref (opencv_highgui), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return opencv_highgui.cvDecodeImageM(buf, 1);
    }

    [LineNumberTable((ushort) 273)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvEncodeImage(string ext, object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_highgui), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      return opencv_highgui.cvEncodeImage(ext, image, (int[]) null);
    }

    [Modifiers]
    public static void cvConvertImage(object ca1, object ca2, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvConvertImage", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_highgui.__\u003Cjniptr\u003EcvConvertImage\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 282)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int cvWaitKey()
    {
      return opencv_highgui.cvWaitKey(0);
    }

    [Modifiers]
    public static int cvGetCaptureDomain(object cc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureDomain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I == IntPtr.Zero)
        opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureDomain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I = JNI.Frame.GetFuncPtr(opencv_highgui.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_highgui", "cvGetCaptureDomain", "(Lcom/googlecode/javacv/cpp/opencv_highgui$CvCapture;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_highgui.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_highgui>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(cc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) opencv_highgui.__\u003Cjniptr\u003EcvGetCaptureDomain\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_highgui\u0024CvCapture\u003B\u0029I)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (opencv_highgui.__\u003CcallerID\u003E == null)
        opencv_highgui.__\u003CcallerID\u003E = (CallerID) new opencv_highgui.__\u003CCallerID\u003E();
      return opencv_highgui.__\u003CcallerID\u003E;
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
