// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.postproc
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
  public class postproc : Object
  {
    public const int LIBPOSTPROC_VERSION_MAJOR = 51;
    public const int LIBPOSTPROC_VERSION_MINOR = 2;
    public const int LIBPOSTPROC_VERSION_MICRO = 0;
    internal static int __\u003C\u003ELIBPOSTPROC_VERSION_INT;
    internal static string __\u003C\u003ELIBPOSTPROC_VERSION;
    internal static int __\u003C\u003ELIBPOSTPROC_BUILD;
    internal static string __\u003C\u003ELIBPOSTPROC_IDENT;
    public const int PP_QUALITY_MAX = 6;
    public const int PP_CPU_CAPS_MMX = -2147483648;
    public const int PP_CPU_CAPS_MMX2 = 536870912;
    public const int PP_CPU_CAPS_3DNOW = 1073741824;
    public const int PP_CPU_CAPS_ALTIVEC = 268435456;
    public const int PP_FORMAT = 8;
    public const int PP_FORMAT_420 = 25;
    public const int PP_FORMAT_422 = 9;
    public const int PP_FORMAT_411 = 10;
    public const int PP_FORMAT_444 = 8;
    public const int PP_PICT_TYPE_QP2 = 16;
    static IntPtr __\u003Cjniptr\u003Epostproc_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Epostproc_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Epostproc_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Epp_help\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Epp_postprocess\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIII\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Epp_get_mode_by_name_and_quality\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B;
    static IntPtr __\u003Cjniptr\u003Epp_free_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Epp_get_context\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B;
    static IntPtr __\u003Cjniptr\u003Epp_free_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B\u0029V;

    [Modifiers]
    public static int LIBPOSTPROC_VERSION_INT
    {
      [HideFromJava] get
      {
        return postproc.__\u003C\u003ELIBPOSTPROC_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBPOSTPROC_VERSION
    {
      [HideFromJava] get
      {
        return postproc.__\u003C\u003ELIBPOSTPROC_VERSION;
      }
    }

    [Modifiers]
    public static int LIBPOSTPROC_BUILD
    {
      [HideFromJava] get
      {
        return postproc.__\u003C\u003ELIBPOSTPROC_BUILD;
      }
    }

    [Modifiers]
    public static string LIBPOSTPROC_IDENT
    {
      [HideFromJava] get
      {
        return postproc.__\u003C\u003ELIBPOSTPROC_IDENT;
      }
    }

    [LineNumberTable((ushort) 69)]
    static postproc()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avutil>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 232, (byte) 95})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public postproc()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static int postproc_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epostproc_version\u0028\u0029I == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epostproc_version\u0028\u0029I = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "postproc_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epostproc_version\u0028\u0029I)(num2, num3);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static string postproc_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epostproc_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epostproc_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "postproc_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epostproc_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string postproc_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epostproc_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epostproc_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "postproc_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epostproc_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string pp_help()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_help\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_help\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_help", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epp_help\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static void pp_postprocess(object pp1, int[] iarr1, object pp2, int[] iarr2, int i1, int i2, byte[] barr, int i3, object \u0031, object \u0032, int i4)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_postprocess\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIII\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003BI\u0029V == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_postprocess\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIII\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003BI\u0029V = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_postprocess", "(Lcom/googlecode/javacpp/PointerPointer;[ILcom/googlecode/javacpp/PointerPointer;[III[BILcom/googlecode/javacv/cpp/postproc$pp_mode;Lcom/googlecode/javacv/cpp/postproc$pp_context;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(pp1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(pp2);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        int num8 = i1;
        int num9 = i2;
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) barr);
        int num11 = i3;
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(param8);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef(param9);
        int num14 = i4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, IntPtr, int)>) postproc.__\u003Cjniptr\u003Epp_postprocess\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIII\u005BBILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003BI\u0029V)((int) num2, num3, num4, (int) num5, num6, (int) num7, num8, (IntPtr) num9, num10, (IntPtr) num11, num12, num13, (IntPtr) num14);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object pp_get_mode_by_name_and_quality(string str, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_get_mode_by_name_and_quality\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_get_mode_by_name_and_quality\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_get_mode_by_name_and_quality", "(Ljava/lang/String;I)Lcom/googlecode/javacv/cpp/postproc$pp_mode;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) postproc.__\u003Cjniptr\u003Epp_get_mode_by_name_and_quality\u0028Ljava\u002Flang\u002FString\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B)((int) num2, num3, num4, (IntPtr) num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void pp_free_mode(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_free_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B\u0029V == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_free_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B\u0029V = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_free_mode", "(Lcom/googlecode/javacv/cpp/postproc$pp_mode;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epp_free_mode\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_mode\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static object pp_get_context(int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_get_context\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_get_context\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_get_context", "(III)Lcom/googlecode/javacv/cpp/postproc$pp_context;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int)>) postproc.__\u003Cjniptr\u003Epp_get_context\u0028III\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B)((int) num2, (int) num3, num4, (IntPtr) num5, (IntPtr) num6);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [Modifiers]
    public static void pp_free_context(object _param1)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (postproc.__\u003Cjniptr\u003Epp_free_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B\u0029V == IntPtr.Zero)
        postproc.__\u003Cjniptr\u003Epp_free_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B\u0029V = JNI.Frame.GetFuncPtr(postproc.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/postproc", "pp_free_context", "(Lcom/googlecode/javacv/cpp/postproc$pp_context;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(postproc.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<postproc>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(param0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) postproc.__\u003Cjniptr\u003Epp_free_context\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fpostproc\u0024pp_context\u003B\u0029V)(num2, num3, num4);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
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
      if (postproc.__\u003CcallerID\u003E == null)
        postproc.__\u003CcallerID\u003E = (CallerID) new postproc.__\u003CCallerID\u003E();
      return postproc.__\u003CcallerID\u003E;
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
