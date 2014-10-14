// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_objdetect
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
  public class opencv_objdetect : Object
  {
    public const int CV_HAAR_MAGIC_VAL = 1112539136;
    public const string CV_TYPE_NAME_HAAR = "opencv-haar-classifier";
    public const int CV_HAAR_FEATURE_MAX = 3;
    public const int CV_HAAR_DO_CANNY_PRUNING = 1;
    public const int CV_HAAR_SCALE_IMAGE = 2;
    public const int CV_HAAR_FIND_BIGGEST_OBJECT = 4;
    public const int CV_HAAR_DO_ROUGH_SEARCH = 8;
    static IntPtr __\u003Cjniptr\u003EcvLoadHaarClassifierCascade\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcvReleaseHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvHaarDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;
    static IntPtr __\u003Cjniptr\u003EcvSetImagesForHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvRunHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003EcvLoadLatentSvmDetector\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B;
    static IntPtr __\u003Cjniptr\u003EcvReleaseLatentSvmDetector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvLatentSvmDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;

    [LineNumberTable((ushort) 85)]
    static opencv_objdetect()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<opencv_highgui>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 232, (byte) 160, (byte) 218})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_objdetect()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object cvHaarDetectObjects(object ca, object chcc, object cms, double d, int i1, int i2, object cs1, object cs2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvHaarDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvHaarDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvHaarDetectObjects", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_objdetect$CvHaarClassifierCascade;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;DIILcom/googlecode/javacv/cpp/opencv_core$CvSize;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(chcc);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        double num7 = d;
        int num8 = i1;
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, IntPtr, IntPtr)>) opencv_objdetect.__\u003Cjniptr\u003EcvHaarDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BDIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, (int) num4, (int) num5, (double) num6, (IntPtr) num7, (IntPtr) num8, (IntPtr) num9, num10, num11);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 91)]
    public static bool CV_IS_HAAR_CLASSIFIER(object haar)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(haar, __typeref (opencv_objdetect), "com.googlecode.javacv.cpp.opencv_objdetect$CvHaarClassifierCascade");
      if (haar == null)
        return false;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_objdetect$CvHaarClassifierCascade");
    }

    [Modifiers]
    public static object cvLoadHaarClassifierCascade(string str, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvLoadHaarClassifierCascade\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvLoadHaarClassifierCascade\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvLoadHaarClassifierCascade", "(Ljava/lang/String;Lcom/googlecode/javacv/cpp/opencv_core$CvSize;)Lcom/googlecode/javacv/cpp/opencv_objdetect$CvHaarClassifierCascade;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_objdetect.__\u003Cjniptr\u003EcvLoadHaarClassifierCascade\u0028Ljava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSize\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B)(num2, num3, num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseHaarClassifierCascade(object chcc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvReleaseHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B\u0029V == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvReleaseHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvReleaseHaarClassifierCascade", "(Lcom/googlecode/javacv/cpp/opencv_objdetect$CvHaarClassifierCascade;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(chcc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_objdetect.__\u003Cjniptr\u003EcvReleaseHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 232)]
    public static object cvHaarDetectObjects(object image, object cascade, object storage, double scale_factor, int min_neighbors, int flags)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_objdetect), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cascade, __typeref (opencv_objdetect), "com.googlecode.javacv.cpp.opencv_objdetect$CvHaarClassifierCascade");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_objdetect), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSize");
    }

    [Modifiers]
    public static void cvSetImagesForHaarClassifierCascade(object chcc, object ca1, object ca2, object ca3, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvSetImagesForHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvSetImagesForHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvSetImagesForHaarClassifierCascade", "(Lcom/googlecode/javacv/cpp/opencv_objdetect$CvHaarClassifierCascade;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(chcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(ca3);
        double num8 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double)>) opencv_objdetect.__\u003Cjniptr\u003EcvSetImagesForHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BD\u0029V)((double) num2, num3, num4, num5, num6, num7, (IntPtr) num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int cvRunHaarClassifierCascade(object chcc, object cp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvRunHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvRunHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvRunHaarClassifierCascade", "(Lcom/googlecode/javacv/cpp/opencv_objdetect$CvHaarClassifierCascade;Lcom/googlecode/javacv/cpp/opencv_core$CvPoint;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(chcc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cp);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_objdetect.__\u003Cjniptr\u003EcvRunHaarClassifierCascade\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvHaarClassifierCascade\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvPoint\u003BI\u0029I)((int) num2, num3, num4, num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLoadLatentSvmDetector(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvLoadLatentSvmDetector\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvLoadLatentSvmDetector\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvLoadLatentSvmDetector", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/opencv_objdetect$CvLatentSvmDetector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) opencv_objdetect.__\u003Cjniptr\u003EcvLoadLatentSvmDetector\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvReleaseLatentSvmDetector(object clsd)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvReleaseLatentSvmDetector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B\u0029V == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvReleaseLatentSvmDetector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvReleaseLatentSvmDetector", "(Lcom/googlecode/javacv/cpp/opencv_objdetect$CvLatentSvmDetector;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(clsd);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) opencv_objdetect.__\u003Cjniptr\u003EcvReleaseLatentSvmDetector\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object cvLatentSvmDetectObjects(object ii, object clsd, object cms, float f)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_objdetect.__\u003Cjniptr\u003EcvLatentSvmDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_objdetect.__\u003Cjniptr\u003EcvLatentSvmDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_objdetect.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_objdetect", "cvLatentSvmDetectObjects", "(Lcom/googlecode/javacv/cpp/opencv_core$IplImage;Lcom/googlecode/javacv/cpp/opencv_objdetect$CvLatentSvmDetector;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;F)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_objdetect.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_objdetect>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ii);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(clsd);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        double num7 = (double) f;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float)>) opencv_objdetect.__\u003Cjniptr\u003EcvLatentSvmDetectObjects\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024IplImage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_objdetect\u0024CvLatentSvmDetector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BF\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)((float) num2, num3, num4, num5, num6, (IntPtr) num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (opencv_objdetect.__\u003CcallerID\u003E == null)
        opencv_objdetect.__\u003CcallerID\u003E = (CallerID) new opencv_objdetect.__\u003CCallerID\u003E();
      return opencv_objdetect.__\u003CcallerID\u003E;
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
