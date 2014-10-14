// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.cvkernels
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
  public class cvkernels : Object
  {
    static IntPtr __\u003Cjniptr\u003EmultiWarpColorTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fcvkernels\u0024KernelData\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 41)]
    static cvkernels()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public cvkernels()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void multiWarpColorTransform(object kd, int i, object cr, object cs)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (cvkernels.__\u003Cjniptr\u003EmultiWarpColorTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fcvkernels\u0024KernelData\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V == IntPtr.Zero)
        cvkernels.__\u003Cjniptr\u003EmultiWarpColorTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fcvkernels\u0024KernelData\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V = JNI.Frame.GetFuncPtr(cvkernels.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/cvkernels", "multiWarpColorTransform", "(Lcom/googlecode/javacv/cpp/cvkernels$KernelData;ILcom/googlecode/javacv/cpp/opencv_core$CvRect;Lcom/googlecode/javacv/cpp/opencv_core$CvScalar;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(cvkernels.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<cvkernels>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(kd);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(cr);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(cs);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr)>) cvkernels.__\u003Cjniptr\u003EmultiWarpColorTransform\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fcvkernels\u0024KernelData\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvRect\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fopencv_core\u0024CvScalar\u003B\u0029V)(num2, num3, (int) num4, (IntPtr) num5, num6, num7);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (cvkernels.__\u003CcallerID\u003E == null)
        cvkernels.__\u003CcallerID\u003E = (CallerID) new cvkernels.__\u003CCallerID\u003E();
      return cvkernels.__\u003CcallerID\u003E;
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
