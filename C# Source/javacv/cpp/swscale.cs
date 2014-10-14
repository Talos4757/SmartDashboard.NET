// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.swscale
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
  public class swscale : Object
  {
    public const int LIBSWSCALE_VERSION_MAJOR = 0;
    public const int LIBSWSCALE_VERSION_MINOR = 11;
    public const int LIBSWSCALE_VERSION_MICRO = 0;
    internal static int __\u003C\u003ELIBSWSCALE_VERSION_INT;
    internal static string __\u003C\u003ELIBSWSCALE_VERSION;
    internal static int __\u003C\u003ELIBSWSCALE_BUILD;
    internal static string __\u003C\u003ELIBSWSCALE_IDENT;
    public const int SWS_FAST_BILINEAR = 1;
    public const int SWS_BILINEAR = 2;
    public const int SWS_BICUBIC = 4;
    public const int SWS_X = 8;
    public const int SWS_POINT = 16;
    public const int SWS_AREA = 32;
    public const int SWS_BICUBLIN = 64;
    public const int SWS_GAUSS = 128;
    public const int SWS_SINC = 256;
    public const int SWS_LANCZOS = 512;
    public const int SWS_SPLINE = 1024;
    public const int SWS_SRC_V_CHR_DROP_MASK = 196608;
    public const int SWS_SRC_V_CHR_DROP_SHIFT = 16;
    public const int SWS_PARAM_DEFAULT = 123456;
    public const int SWS_PRINT_INFO = 4096;
    public const int SWS_FULL_CHR_H_INT = 8192;
    public const int SWS_FULL_CHR_H_INP = 16384;
    public const int SWS_DIRECT_BGR = 32768;
    public const int SWS_ACCURATE_RND = 262144;
    public const int SWS_BITEXACT = 524288;
    public const int SWS_CPU_CAPS_MMX = -2147483648;
    public const int SWS_CPU_CAPS_MMX2 = 536870912;
    public const int SWS_CPU_CAPS_3DNOW = 1073741824;
    public const int SWS_CPU_CAPS_ALTIVEC = 268435456;
    public const int SWS_CPU_CAPS_BFIN = 16777216;
    public const double SWS_MAX_REDUCE_CUTOFF = 0.002;
    public const int SWS_CS_ITU709 = 1;
    public const int SWS_CS_FCC = 4;
    public const int SWS_CS_ITU601 = 5;
    public const int SWS_CS_ITU624 = 5;
    public const int SWS_CS_SMPTE170M = 5;
    public const int SWS_CS_SMPTE240M = 7;
    public const int SWS_CS_DEFAULT = 5;
    static IntPtr __\u003Cjniptr\u003Eswscale_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eswscale_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eswscale_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_getCoefficients\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_isSupportedInput\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_isSupportedOutput\u0028I\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_freeContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_getContext\u0028IIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_setColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u005BII\u005BIIIII\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_getColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Esws_allocVec\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_getGaussianVec\u0028DD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_getConstVec\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_getIdentityVec\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_scaleVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_normalizeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_convVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_addVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_subVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_shiftVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_cloneVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_printVec2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVClass\u003BI\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_freeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_getDefaultFilter\u0028FFFFFFI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B;
    static IntPtr __\u003Cjniptr\u003Esws_freeFilter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Esws_getCachedContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BIIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B;

    [Modifiers]
    public static int LIBSWSCALE_VERSION_INT
    {
      [HideFromJava] get
      {
        return swscale.__\u003C\u003ELIBSWSCALE_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBSWSCALE_VERSION
    {
      [HideFromJava] get
      {
        return swscale.__\u003C\u003ELIBSWSCALE_VERSION;
      }
    }

    [Modifiers]
    public static int LIBSWSCALE_BUILD
    {
      [HideFromJava] get
      {
        return swscale.__\u003C\u003ELIBSWSCALE_BUILD;
      }
    }

    [Modifiers]
    public static string LIBSWSCALE_IDENT
    {
      [HideFromJava] get
      {
        return swscale.__\u003C\u003ELIBSWSCALE_IDENT;
      }
    }

    [LineNumberTable((ushort) 68)]
    static swscale()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avutil>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 232, (byte) 160, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public swscale()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static object sws_getContext(int i1, int i2, int i3, int i4, int i5, int i6, int i7, object sf1, object sf2, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getContext\u0028IIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getContext\u0028IIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getContext", "(IIIIIIILcom/googlecode/javacv/cpp/swscale$SwsFilter;Lcom/googlecode/javacv/cpp/swscale$SwsFilter;[D)Lcom/googlecode/javacv/cpp/swscale$SwsContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        int num4 = i1;
        int num5 = i2;
        int num6 = i3;
        int num7 = i4;
        int num8 = i5;
        int num9 = i6;
        int num10 = i7;
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef(sf1);
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(sf2);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int, int, int, int, int, int, int, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_getContext\u0028IIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B)(num2, num3, (IntPtr) num4, num5, num6, num7, num8, num9, num10, (int) num11, num12, num13);
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
    public static int sws_scale(object sc, object pp1, object ip1, int i1, int i2, object pp2, object ip2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_scale", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;Lcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacpp/IntPointer;IILcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacpp/IntPointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(ip1);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(pp2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef(ip2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003BIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B\u0029I)(num2, num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, num9, num10);
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
    public static int swscale_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Eswscale_version\u0028\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Eswscale_version\u0028\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "swscale_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Eswscale_version\u0028\u0029I)(num2, num3);
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
    public static string swscale_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Eswscale_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Eswscale_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "swscale_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Eswscale_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string swscale_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Eswscale_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Eswscale_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "swscale_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Eswscale_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static object sws_getCoefficients(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getCoefficients\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getCoefficients\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getCoefficients", "(I)Lcom/googlecode/javacpp/IntPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_getCoefficients\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static int sws_isSupportedInput(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_isSupportedInput\u0028I\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_isSupportedInput\u0028I\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_isSupportedInput", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_isSupportedInput\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
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
    public static int sws_isSupportedOutput(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_isSupportedOutput\u0028I\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_isSupportedOutput\u0028I\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_isSupportedOutput", "(I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_isSupportedOutput\u0028I\u0029I)((int) num2, num3, (IntPtr) num4);
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
    public static void sws_freeContext(object sc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_freeContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_freeContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_freeContext", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_freeContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u0029V)(num2, num3, num4);
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
    public static int sws_scale(object sc, object pp1, int[] iarr1, int i1, int i2, object pp2, int[] iarr2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_scale", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;Lcom/googlecode/javacpp/PointerPointer;[IIILcom/googlecode/javacpp/PointerPointer;[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        int num7 = i1;
        int num8 = i2;
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(pp2);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_scale\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BIIILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u0029I)(num2, num3, (int) num4, (int) num5, num6, (IntPtr) num7, (IntPtr) num8, num9, num10);
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
    public static int sws_setColorspaceDetails(object sc, int[] iarr1, int i1, int[] iarr2, int i2, int i3, int i4, int i5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_setColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u005BII\u005BIIIII\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_setColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u005BII\u005BIIIII\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_setColorspaceDetails", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;[II[IIIII)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        int num6 = i1;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        int num8 = i2;
        int num9 = i3;
        int num10 = i4;
        int num11 = i5;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, int, int)>) swscale.__\u003Cjniptr\u003Esws_setColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B\u005BII\u005BIIIII\u0029I)((int) num2, (int) num3, (int) num4, (int) num5, (IntPtr) num6, (int) num7, (IntPtr) num8, (IntPtr) num9, (IntPtr) num10, (IntPtr) num11);
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
    public static int sws_getColorspaceDetails(object sc, object pp1, int[] iarr1, object pp2, int[] iarr2, int[] iarr3, int[] iarr4, int[] iarr5)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getColorspaceDetails", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;Lcom/googlecode/javacpp/PointerPointer;[ILcom/googlecode/javacpp/PointerPointer;[I[I[I[I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(pp1);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr1);
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(pp2);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr2);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr3);
        // ISSUE: explicit reference operation
        IntPtr num10 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr4);
        // ISSUE: explicit reference operation
        IntPtr num11 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr5);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_getColorspaceDetails\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BILcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B\u005BI\u005BI\u005BI\u005BI\u0029I)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11);
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
    public static object sws_allocVec(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_allocVec\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_allocVec\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_allocVec", "(I)Lcom/googlecode/javacv/cpp/swscale$SwsVector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_allocVec\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B)((int) num2, num3, (IntPtr) num4);
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
    public static object sws_getGaussianVec(double d1, double d2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getGaussianVec\u0028DD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getGaussianVec\u0028DD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getGaussianVec", "(DD)Lcom/googlecode/javacv/cpp/swscale$SwsVector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        double num4 = d1;
        double num5 = d2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double, double)>) swscale.__\u003Cjniptr\u003Esws_getGaussianVec\u0028DD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B)((double) num2, (double) num3, (IntPtr) num4, (IntPtr) num5);
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
    public static object sws_getConstVec(double d, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getConstVec\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getConstVec\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getConstVec", "(DI)Lcom/googlecode/javacv/cpp/swscale$SwsVector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        double num4 = d;
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double, int)>) swscale.__\u003Cjniptr\u003Esws_getConstVec\u0028DI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B)((int) num2, (double) num3, (IntPtr) num4, (IntPtr) num5);
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
    public static object sws_getIdentityVec()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getIdentityVec\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getIdentityVec\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getIdentityVec", "()Lcom/googlecode/javacv/cpp/swscale$SwsVector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_getIdentityVec\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B)(num2, num3);
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
    public static void sws_scaleVec(object sv, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_scaleVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_scaleVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_scaleVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        double num5 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double)>) swscale.__\u003Cjniptr\u003Esws_scaleVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V)((double) num2, num3, num4, (IntPtr) num5);
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
    public static void sws_normalizeVec(object sv, double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_normalizeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_normalizeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_normalizeVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;D)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        double num5 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, double)>) swscale.__\u003Cjniptr\u003Esws_normalizeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BD\u0029V)((double) num2, num3, num4, (IntPtr) num5);
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
    public static void sws_convVec(object sv1, object sv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_convVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_convVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_convVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;Lcom/googlecode/javacv/cpp/swscale$SwsVector;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(sv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_convVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void sws_addVec(object sv1, object sv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_addVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_addVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_addVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;Lcom/googlecode/javacv/cpp/swscale$SwsVector;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(sv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_addVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void sws_subVec(object sv1, object sv2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_subVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_subVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_subVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;Lcom/googlecode/javacv/cpp/swscale$SwsVector;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(sv2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_subVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void sws_shiftVec(object sv, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_shiftVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BI\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_shiftVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BI\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_shiftVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_shiftVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BI\u0029V)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object sws_cloneVec(object sv)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_cloneVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_cloneVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_cloneVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;)Lcom/googlecode/javacv/cpp/swscale$SwsVector;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_cloneVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B)(num2, num3, num4);
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
    public static void sws_printVec2(object sv, object avc, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_printVec2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVClass\u003BI\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_printVec2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVClass\u003BI\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_printVec2", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;Lcom/googlecode/javacv/cpp/avutil$AVClass;I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avc);
        int num6 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr, int)>) swscale.__\u003Cjniptr\u003Esws_printVec2\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favutil\u0024AVClass\u003BI\u0029V)((int) num2, num3, num4, num5, (IntPtr) num6);
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
    public static void sws_freeVec(object sv)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_freeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_freeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_freeVec", "(Lcom/googlecode/javacv/cpp/swscale$SwsVector;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sv);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_freeVec\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsVector\u003B\u0029V)(num2, num3, num4);
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
    public static object sws_getDefaultFilter(float f1, float f2, float f3, float f4, float f5, float f6, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getDefaultFilter\u0028FFFFFFI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getDefaultFilter\u0028FFFFFFI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getDefaultFilter", "(FFFFFFI)Lcom/googlecode/javacv/cpp/swscale$SwsFilter;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        double num4 = (double) f1;
        double num5 = (double) f2;
        double num6 = (double) f3;
        double num7 = (double) f4;
        double num8 = (double) f5;
        double num9 = (double) f6;
        int num10 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, float, float, float, float, float, float, int)>) swscale.__\u003Cjniptr\u003Esws_getDefaultFilter\u0028FFFFFFI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B)((int) num2, (float) num3, (float) num4, (float) num5, (float) num6, (float) num7, (float) num8, (IntPtr) num9, (IntPtr) num10);
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
    public static void sws_freeFilter(object sf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_freeFilter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u0029V == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_freeFilter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u0029V = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_freeFilter", "(Lcom/googlecode/javacv/cpp/swscale$SwsFilter;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_freeFilter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u0029V)(num2, num3, num4);
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
    public static object sws_getCachedContext(object sc, int i1, int i2, int i3, int i4, int i5, int i6, int i7, object sf1, object sf2, double[] darr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (swscale.__\u003Cjniptr\u003Esws_getCachedContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BIIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B == IntPtr.Zero)
        swscale.__\u003Cjniptr\u003Esws_getCachedContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BIIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B = JNI.Frame.GetFuncPtr(swscale.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/swscale", "sws_getCachedContext", "(Lcom/googlecode/javacv/cpp/swscale$SwsContext;IIIIIIILcom/googlecode/javacv/cpp/swscale$SwsFilter;Lcom/googlecode/javacv/cpp/swscale$SwsFilter;[D)Lcom/googlecode/javacv/cpp/swscale$SwsContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(swscale.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<swscale>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(sc);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        int num8 = i4;
        int num9 = i5;
        int num10 = i6;
        int num11 = i7;
        // ISSUE: explicit reference operation
        IntPtr num12 = ((JNI.Frame) @frame).MakeLocalRef(sf1);
        // ISSUE: explicit reference operation
        IntPtr num13 = ((JNI.Frame) @frame).MakeLocalRef(sf2);
        // ISSUE: explicit reference operation
        IntPtr num14 = ((JNI.Frame) @frame).MakeLocalRef((object) darr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, IntPtr, IntPtr, IntPtr)>) swscale.__\u003Cjniptr\u003Esws_getCachedContext\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003BIIIIIIILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsFilter\u003B\u005BD\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Fswscale\u0024SwsContext\u003B)(num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14);
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
      if (swscale.__\u003CcallerID\u003E == null)
        swscale.__\u003CcallerID\u003E = (CallerID) new swscale.__\u003CCallerID\u003E();
      return swscale.__\u003CcallerID\u003E;
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
