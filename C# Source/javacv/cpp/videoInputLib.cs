// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.videoInputLib
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
  public class videoInputLib : Object
  {
    public const double VI_VERSION = 0.1995;
    public const int VI_MAX_CAMERAS = 20;
    public const int VI_NUM_TYPES = 18;
    public const int VI_NUM_FORMATS = 18;
    public const int VI_COMPOSITE = 0;
    public const int VI_S_VIDEO = 1;
    public const int VI_TUNER = 2;
    public const int VI_USB = 3;
    public const int VI_1394 = 4;
    public const int VI_NTSC_M = 0;
    public const int VI_PAL_B = 1;
    public const int VI_PAL_D = 2;
    public const int VI_PAL_G = 3;
    public const int VI_PAL_H = 4;
    public const int VI_PAL_I = 5;
    public const int VI_PAL_M = 6;
    public const int VI_PAL_N = 7;
    public const int VI_PAL_NC = 8;
    public const int VI_SECAM_B = 9;
    public const int VI_SECAM_D = 10;
    public const int VI_SECAM_G = 11;
    public const int VI_SECAM_H = 12;
    public const int VI_SECAM_K = 13;
    public const int VI_SECAM_K1 = 14;
    public const int VI_SECAM_L = 15;
    public const int VI_NTSC_M_J = 16;
    public const int VI_NTSC_433 = 17;
    static IntPtr __\u003Cjniptr\u003Everbose\u0028\u0029Z;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Everbose\u0028Z\u0029V;
    static IntPtr __\u003Cjniptr\u003EcomInitCount\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003EcomInitCount\u0028I\u0029V;

    [LineNumberTable((ushort) 81)]
    static videoInputLib()
    {
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 232, (byte) 160, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public videoInputLib()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static bool verbose()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (videoInputLib.__\u003Cjniptr\u003Everbose\u0028\u0029Z == IntPtr.Zero)
        videoInputLib.__\u003Cjniptr\u003Everbose\u0028\u0029Z = JNI.Frame.GetFuncPtr(videoInputLib.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/videoInputLib", "verbose", "()Z");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(videoInputLib.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<videoInputLib>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (bool) __calli((__FnPtr<byte (IntPtr, IntPtr)>) videoInputLib.__\u003Cjniptr\u003Everbose\u0028\u0029Z)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void verbose(bool b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (videoInputLib.__\u003Cjniptr\u003Everbose\u0028Z\u0029V == IntPtr.Zero)
        videoInputLib.__\u003Cjniptr\u003Everbose\u0028Z\u0029V = JNI.Frame.GetFuncPtr(videoInputLib.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/videoInputLib", "verbose", "(Z)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(videoInputLib.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<videoInputLib>.Value);
        int num4 = b ? 1 : 0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, bool)>) videoInputLib.__\u003Cjniptr\u003Everbose\u0028Z\u0029V)((bool) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int comInitCount()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028\u0029I == IntPtr.Zero)
        videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028\u0029I = JNI.Frame.GetFuncPtr(videoInputLib.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/videoInputLib", "comInitCount", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(videoInputLib.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<videoInputLib>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void comInitCount(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028I\u0029V == IntPtr.Zero)
        videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028I\u0029V = JNI.Frame.GetFuncPtr(videoInputLib.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/videoInputLib", "comInitCount", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(videoInputLib.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<videoInputLib>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) videoInputLib.__\u003Cjniptr\u003EcomInitCount\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (videoInputLib.__\u003CcallerID\u003E == null)
        videoInputLib.__\u003CcallerID\u003E = (CallerID) new videoInputLib.__\u003CCallerID\u003E();
      return videoInputLib.__\u003CcallerID\u003E;
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
