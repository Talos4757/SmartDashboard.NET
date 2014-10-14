// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.ARToolKitPlus
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
  public class ARToolKitPlus : Object
  {
    public const int PIXEL_FORMAT_ABGR = 1;
    public const int PIXEL_FORMAT_BGRA = 2;
    public const int PIXEL_FORMAT_BGR = 3;
    public const int PIXEL_FORMAT_RGBA = 4;
    public const int PIXEL_FORMAT_RGB = 5;
    public const int PIXEL_FORMAT_RGB565 = 6;
    public const int PIXEL_FORMAT_LUM = 7;
    public const int UNDIST_NONE = 0;
    public const int UNDIST_STD = 1;
    public const int UNDIST_LUT = 2;
    public const int IMAGE_HALF_RES = 0;
    public const int IMAGE_FULL_RES = 1;
    public const int MARKER_TEMPLATE = 0;
    public const int MARKER_ID_SIMPLE = 1;
    public const int MARKER_ID_BCH = 2;
    public const int POSE_ESTIMATOR_ORIGINAL = 0;
    public const int POSE_ESTIMATOR_ORIGINAL_CONT = 1;
    public const int POSE_ESTIMATOR_RPP = 2;
    static IntPtr __\u003Cjniptr\u003EcreateImagePatternBCH\u0028I\u005BB\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003EcreateImagePatternBCH\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003EcreateImagePatternSimple\u0028I\u005BB\u0029V;
    static IntPtr __\u003Cjniptr\u003EcreateImagePatternSimple\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V;

    [LineNumberTable((ushort) 54)]
    static ARToolKitPlus()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 232, (byte) 160, (byte) 230})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ARToolKitPlus()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void createImagePatternBCH(int i, ByteBuffer bb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V == IntPtr.Zero)
        ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(ARToolKitPlus.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/ARToolKitPlus", "createImagePatternBCH", "(ILjava/nio/ByteBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(ARToolKitPlus.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<ARToolKitPlus>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void createImagePatternBCH(int i, byte[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028I\u005BB\u0029V == IntPtr.Zero)
        ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028I\u005BB\u0029V = JNI.Frame.GetFuncPtr(ARToolKitPlus.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/ARToolKitPlus", "createImagePatternBCH", "(I[B)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(ARToolKitPlus.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<ARToolKitPlus>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternBCH\u0028I\u005BB\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void createImagePatternSimple(int i, byte[] barr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028I\u005BB\u0029V == IntPtr.Zero)
        ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028I\u005BB\u0029V = JNI.Frame.GetFuncPtr(ARToolKitPlus.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/ARToolKitPlus", "createImagePatternSimple", "(I[B)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(ARToolKitPlus.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<ARToolKitPlus>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028I\u005BB\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void createImagePatternSimple(int i, ByteBuffer bb)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V == IntPtr.Zero)
        ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V = JNI.Frame.GetFuncPtr(ARToolKitPlus.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/ARToolKitPlus", "createImagePatternSimple", "(ILjava/nio/ByteBuffer;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(ARToolKitPlus.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<ARToolKitPlus>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) bb);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr)>) ARToolKitPlus.__\u003Cjniptr\u003EcreateImagePatternSimple\u0028ILjava\u002Fnio\u002FByteBuffer\u003B\u0029V)(num2, (int) num3, (IntPtr) num4, num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (ARToolKitPlus.__\u003CcallerID\u003E == null)
        ARToolKitPlus.__\u003CcallerID\u003E = (CallerID) new ARToolKitPlus.__\u003CCallerID\u003E();
      return ARToolKitPlus.__\u003CcallerID\u003E;
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
