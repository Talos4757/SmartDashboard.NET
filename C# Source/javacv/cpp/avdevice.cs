// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.avdevice
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
  public class avdevice : Object
  {
    public const int LIBAVDEVICE_VERSION_MAJOR = 52;
    public const int LIBAVDEVICE_VERSION_MINOR = 2;
    public const int LIBAVDEVICE_VERSION_MICRO = 0;
    internal static int __\u003C\u003ELIBAVDEVICE_VERSION_INT;
    internal static string __\u003C\u003ELIBAVDEVICE_VERSION;
    internal static int __\u003C\u003ELIBAVDEVICE_BUILD;
    static IntPtr __\u003Cjniptr\u003Eavdevice_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eavdevice_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavdevice_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavdevice_register_all\u0028\u0029V;

    [Modifiers]
    public static int LIBAVDEVICE_VERSION_INT
    {
      [HideFromJava] get
      {
        return avdevice.__\u003C\u003ELIBAVDEVICE_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBAVDEVICE_VERSION
    {
      [HideFromJava] get
      {
        return avdevice.__\u003C\u003ELIBAVDEVICE_VERSION;
      }
    }

    [Modifiers]
    public static int LIBAVDEVICE_BUILD
    {
      [HideFromJava] get
      {
        return avdevice.__\u003C\u003ELIBAVDEVICE_BUILD;
      }
    }

    [LineNumberTable((ushort) 60)]
    static avdevice()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avformat>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public avdevice()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static void avdevice_register_all()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avdevice.__\u003Cjniptr\u003Eavdevice_register_all\u0028\u0029V == IntPtr.Zero)
        avdevice.__\u003Cjniptr\u003Eavdevice_register_all\u0028\u0029V = JNI.Frame.GetFuncPtr(avdevice.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avdevice", "avdevice_register_all", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avdevice.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avdevice>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avdevice.__\u003Cjniptr\u003Eavdevice_register_all\u0028\u0029V)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static int avdevice_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avdevice.__\u003Cjniptr\u003Eavdevice_version\u0028\u0029I == IntPtr.Zero)
        avdevice.__\u003Cjniptr\u003Eavdevice_version\u0028\u0029I = JNI.Frame.GetFuncPtr(avdevice.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avdevice", "avdevice_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avdevice.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avdevice>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avdevice.__\u003Cjniptr\u003Eavdevice_version\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string avdevice_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avdevice.__\u003Cjniptr\u003Eavdevice_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avdevice.__\u003Cjniptr\u003Eavdevice_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avdevice.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avdevice", "avdevice_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avdevice.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avdevice>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avdevice.__\u003Cjniptr\u003Eavdevice_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string avdevice_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avdevice.__\u003Cjniptr\u003Eavdevice_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avdevice.__\u003Cjniptr\u003Eavdevice_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avdevice.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avdevice", "avdevice_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avdevice.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avdevice>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avdevice.__\u003Cjniptr\u003Eavdevice_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
        return (string) ((JNI.Frame) local).UnwrapLocalRef(num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (avdevice.__\u003CcallerID\u003E == null)
        avdevice.__\u003CcallerID\u003E = (CallerID) new avdevice.__\u003CCallerID\u003E();
      return avdevice.__\u003CcallerID\u003E;
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
