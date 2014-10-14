// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_features2d
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
  public class opencv_features2d : Object
  {
    static IntPtr __\u003Cjniptr\u003EcvSURFParams\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003B;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcvExtractSURF\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvMSERParams\u0028IIIFFIDDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B;
    static IntPtr __\u003Cjniptr\u003EcvExtractMSER\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcvGetStarKeypoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvStarDetectorParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B;

    [LineNumberTable((ushort) 79)]
    static opencv_features2d()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<opencv_calib3d>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 232, (byte) 160, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public opencv_features2d()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object cvSURFParams(double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_features2d.__\u003Cjniptr\u003EcvSURFParams\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003B == IntPtr.Zero)
        opencv_features2d.__\u003Cjniptr\u003EcvSURFParams\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003B = JNI.Frame.GetFuncPtr(opencv_features2d.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_features2d", "cvSURFParams", "(DI)Lcom/googlecode/javacv/cpp/opencv_features2d$CvSURFParams;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_features2d.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_features2d>.Value);
        double num4 = d;
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double, int)>) opencv_features2d.__\u003Cjniptr\u003EcvSURFParams\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003B)((int) num2, (double) num3, (IntPtr) num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void cvExtractSURF(object ca1, object ca2, object cs1, object cs2, object cms, object csurfp, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_features2d.__\u003Cjniptr\u003EcvExtractSURF\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003BI\u0029V == IntPtr.Zero)
        opencv_features2d.__\u003Cjniptr\u003EcvExtractSURF\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003BI\u0029V = JNI.Frame.GetFuncPtr(opencv_features2d.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_features2d", "cvExtractSURF", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_features2d$CvSURFParams;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_features2d.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_features2d>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(csurfp);
        int num10 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int)>) opencv_features2d.__\u003Cjniptr\u003EcvExtractSURF\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvSURFParams\u003BI\u0029V)((int) num2, num3, num4, num5, num6, num7, num8, num9, (IntPtr) num10);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 104)]
    public static object cvSURFPoint(object pt, int laplacian, int size, float dir, float hessian)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt, __typeref (opencv_features2d), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint");
    }

    [Modifiers]
    public static object cvMSERParams(int i1, int i2, int i3, float f1, float f2, int i4, double d1, double d2, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_features2d.__\u003Cjniptr\u003EcvMSERParams\u0028IIIFFIDDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B == IntPtr.Zero)
        opencv_features2d.__\u003Cjniptr\u003EcvMSERParams\u0028IIIFFIDDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B = JNI.Frame.GetFuncPtr(opencv_features2d.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_features2d", "cvMSERParams", "(IIIFFIDDI)Lcom/googlecode/javacv/cpp/opencv_features2d$CvMSERParams;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_features2d.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_features2d>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        double num7 = (double) f1;
        double num8 = (double) f2;
        int num9 = i4;
        double num10 = d1;
        double num11 = d2;
        int num12 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, float, float, int, double, double, int)>) opencv_features2d.__\u003Cjniptr\u003EcvMSERParams\u0028IIIFFIDDI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B)((int) num2, (double) num3, (double) num4, num5, (float) num6, (float) num7, (int) num8, num9, (int) num10, (IntPtr) num11, (IntPtr) num12);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 218)]
    public static object cvStarDetectorParams(int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvStarDetectorParams");
    }

    [LineNumberTable((ushort) 227)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvStarDetectorParams()
    {
      return opencv_features2d.cvStarDetectorParams(45, 30, 10, 8, 5);
    }

    [Modifiers]
    public static object cvGetStarKeypoints(object ca, object cms, object csdp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_features2d.__\u003Cjniptr\u003EcvGetStarKeypoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvStarDetectorParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B == IntPtr.Zero)
        opencv_features2d.__\u003Cjniptr\u003EcvGetStarKeypoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvStarDetectorParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B = JNI.Frame.GetFuncPtr(opencv_features2d.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_features2d", "cvGetStarKeypoints", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_features2d$CvStarDetectorParams;)Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_features2d.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_features2d>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(csdp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_features2d.__\u003Cjniptr\u003EcvGetStarKeypoints\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvStarDetectorParams\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003B)(num2, num3, num4, num5, num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 100)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvSURFPoint(object pt, int laplacian, int size)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt, __typeref (opencv_features2d), "com.googlecode.javacv.cpp.opencv_core$CvPoint2D32f");
      object pt1 = pt;
      int num1 = laplacian;
      int num2 = size;
      double num3 = 0.0;
      float num4 = 0.0f;
      float num5 = (float) num3;
      int num6 = num2;
      int laplacian1 = num1;
      int size1 = num6;
      double num7 = (double) num5;
      double num8 = (double) num4;
      return opencv_features2d.cvSURFPoint(pt1, laplacian1, size1, (float) num7, (float) num8);
    }

    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvMSERParams()
    {
      return opencv_features2d.cvMSERParams(5, 60, 14400, 0.25f, 0.2f, 200, 1.01, 0.003, 5);
    }

    [Modifiers]
    public static void cvExtractMSER(object ca1, object ca2, object cs, object cms, object cmserp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (opencv_features2d.__\u003Cjniptr\u003EcvExtractMSER\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B\u0029V == IntPtr.Zero)
        opencv_features2d.__\u003Cjniptr\u003EcvExtractMSER\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B\u0029V = JNI.Frame.GetFuncPtr(opencv_features2d.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/opencv_features2d", "cvExtractMSER", "(Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvArr;Lcom/googlecode/javacv/cpp/opencv_core$CvSeq;Lcom/googlecode/javacv/cpp/opencv_core$CvMemStorage;Lcom/googlecode/javacv/cpp/opencv_features2d$CvMSERParams;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(opencv_features2d.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<opencv_features2d>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(ca1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(ca2);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cms);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(cmserp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) opencv_features2d.__\u003Cjniptr\u003EcvExtractMSER\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvArr\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvSeq\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvMemStorage\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_features2d\u0024CvMSERParams\u003B\u0029V)(num2, num3, num4, num5, num6, num7, num8);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable((ushort) 190)]
    public static object cvStarKeypoint(object pt, int size, float response)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pt, __typeref (opencv_features2d), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvStarKeypoint");
    }

    [LineNumberTable((ushort) 231)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object cvGetStarKeypoints(object image, object storage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (opencv_features2d), "com.googlecode.javacv.cpp.opencv_core$CvArr");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(storage, __typeref (opencv_features2d), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      object ca = image;
      object obj1 = storage;
      object obj2 = opencv_features2d.cvStarDetectorParams();
      object cms = obj1;
      object csdp = obj2;
      return opencv_features2d.cvGetStarKeypoints(ca, cms, csdp);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (opencv_features2d.__\u003CcallerID\u003E == null)
        opencv_features2d.__\u003CcallerID\u003E = (CallerID) new opencv_features2d.__\u003CCallerID\u003E();
      return opencv_features2d.__\u003CcallerID\u003E;
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
