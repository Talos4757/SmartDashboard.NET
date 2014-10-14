// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.avfilter
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
  public class avfilter : Object
  {
    public const int LIBAVFILTER_VERSION_MAJOR = 1;
    public const int LIBAVFILTER_VERSION_MINOR = 19;
    public const int LIBAVFILTER_VERSION_MICRO = 0;
    internal static int __\u003C\u003ELIBAVFILTER_VERSION_INT;
    internal static string __\u003C\u003ELIBAVFILTER_VERSION;
    internal static int __\u003C\u003ELIBAVFILTER_BUILD;
    static IntPtr __\u003Cjniptr\u003Eavfilter_version\u0028\u0029I;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eavfilter_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_license\u0028\u0029Ljava\u002Flang\u002FString\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_ref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_unref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_make_format_list\u0028\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_add_colorspace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_all_colorspaces\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_merge_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_formats_ref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_formats_unref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_formats_changeref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_config_output_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_set_common_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_default_query_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_null_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_null_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_null_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_null_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BI\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_config_links\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_request_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_poll_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_register_all\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_uninit\u0028\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_get_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B;
    static IntPtr __\u003Cjniptr\u003Eav_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B;
    static IntPtr __\u003Cjniptr\u003Eavfilter_init_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_destroy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_insert_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BII\u0029I;
    static IntPtr __\u003Cjniptr\u003Eavfilter_insert_pad\u0028I\u005BIJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_insert_inpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V;
    static IntPtr __\u003Cjniptr\u003Eavfilter_insert_outpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V;

    [Modifiers]
    public static int LIBAVFILTER_VERSION_INT
    {
      [HideFromJava] get
      {
        return avfilter.__\u003C\u003ELIBAVFILTER_VERSION_INT;
      }
    }

    [Modifiers]
    public static string LIBAVFILTER_VERSION
    {
      [HideFromJava] get
      {
        return avfilter.__\u003C\u003ELIBAVFILTER_VERSION;
      }
    }

    [Modifiers]
    public static int LIBAVFILTER_BUILD
    {
      [HideFromJava] get
      {
        return avfilter.__\u003C\u003ELIBAVFILTER_BUILD;
      }
    }

    [LineNumberTable((ushort) 69)]
    static avfilter()
    {
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<avutil>.Value;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 232, (byte) 161, (byte) 47})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public avfilter()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    public static int avfilter_version()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_version\u0028\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_version\u0028\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_version", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_version\u0028\u0029I)(num2, num3);
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
    public static string avfilter_configuration()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_configuration", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_configuration\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static string avfilter_license()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_license\u0028\u0029Ljava\u002Flang\u002FString\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_license\u0028\u0029Ljava\u002Flang\u002FString\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_license", "()Ljava/lang/String;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_license\u0028\u0029Ljava\u002Flang\u002FString\u003B)(num2, num3);
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
    public static object avfilter_ref_pic(object avfpr, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_ref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_ref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_ref_pic", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;I)Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfpr);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_ref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B)((int) num2, num3, num4, (IntPtr) num5);
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
    public static void avfilter_unref_pic(object avfpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_unref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_unref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_unref_pic", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_unref_pic\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V)(num2, num3, num4);
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
    public static object avfilter_make_format_list(int[] iarr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_make_format_list\u0028\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_make_format_list\u0028\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_make_format_list", "([I)Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_make_format_list\u0028\u005BI\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B)(num2, num3, num4);
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
    public static int avfilter_add_colorspace(object avff, int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_add_colorspace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BI\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_add_colorspace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BI\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_add_colorspace", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avff);
        int num5 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_add_colorspace\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BI\u0029I)((int) num2, num3, num4, (IntPtr) num5);
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
    public static object avfilter_all_colorspaces()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_all_colorspaces\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_all_colorspaces\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_all_colorspaces", "()Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_all_colorspaces\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B)(num2, num3);
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
    public static object avfilter_merge_formats(object avff1, object avff2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_merge_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_merge_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_merge_formats", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;)Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avff1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avff2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_merge_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B)(num2, num3, num4, num5);
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
    public static void avfilter_formats_ref(object avff1, object avff2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_formats_ref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_formats_ref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_formats_ref", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avff1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avff2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_formats_ref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void avfilter_formats_unref(object avff)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_formats_unref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_formats_unref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_formats_unref", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avff);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_formats_unref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V)(num2, num3, num4);
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
    public static void avfilter_formats_changeref(object avff1, object avff2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_formats_changeref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_formats_changeref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_formats_changeref", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avff1);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avff2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_formats_changeref\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void avfilter_default_start_frame(object avfl, object avfpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_start_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avfpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void avfilter_default_draw_slice(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_draw_slice", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void avfilter_default_end_frame(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_end_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V)(num2, num3, num4);
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
    public static int avfilter_default_config_output_link(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_config_output_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_config_output_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_config_output_link", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_config_output_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I)(num2, num3, num4);
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
    public static object avfilter_default_get_video_buffer(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_get_video_buffer", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void avfilter_set_common_formats(object avfc, object avff)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_set_common_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_set_common_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_set_common_formats", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;Lcom/googlecode/javacv/cpp/avfilter$AVFilterFormats;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avff);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_set_common_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterFormats\u003B\u0029V)(num2, num3, num4, num5);
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
    public static int avfilter_default_query_formats(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_default_query_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_default_query_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_default_query_formats", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_default_query_formats\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I)(num2, num3, num4);
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
    public static void avfilter_null_start_frame(object avfl, object avfpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_null_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_null_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_null_start_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avfpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_null_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void avfilter_null_draw_slice(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_null_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_null_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_null_draw_slice", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_null_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void avfilter_null_end_frame(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_null_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_null_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_null_end_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_null_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V)(num2, num3, num4);
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
    public static object avfilter_null_get_video_buffer(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_null_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_null_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_null_get_video_buffer", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_null_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int avfilter_link(object avfc1, int i1, object avfc2, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BI\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BI\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_link", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;ILcom/googlecode/javacv/cpp/avfilter$AVFilterContext;I)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc1);
        int num5 = i1;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avfc2);
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, int, IntPtr, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_link\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BI\u0029I)((int) num2, num3, (int) num4, (IntPtr) num5, num6, (IntPtr) num7);
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
    public static int avfilter_config_links(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_config_links\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_config_links\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_config_links", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_config_links\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029I)(num2, num3, num4);
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
    public static object avfilter_get_video_buffer(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_get_video_buffer", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_get_video_buffer\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static int avfilter_request_frame(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_request_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_request_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_request_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_request_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I)(num2, num3, num4);
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
    public static int avfilter_poll_frame(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_poll_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_poll_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_poll_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_poll_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029I)(num2, num3, num4);
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
    public static void avfilter_start_frame(object avfl, object avfpr)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_start_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;Lcom/googlecode/javacv/cpp/avfilter$AVFilterPicRef;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avfpr);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_start_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPicRef\u003B\u0029V)(num2, num3, num4, num5);
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
    public static void avfilter_end_frame(object avfl)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_end_frame", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_end_frame\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003B\u0029V)(num2, num3, num4);
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
    public static void avfilter_draw_slice(object avfl, int i1, int i2, int i3)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_draw_slice", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;III)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        int num5 = i1;
        int num6 = i2;
        int num7 = i3;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_draw_slice\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BIII\u0029V)((int) num2, (int) num3, (int) num4, (IntPtr) num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void avfilter_register_all()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_register_all\u0028\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_register_all\u0028\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_register_all", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_register_all\u0028\u0029V)(num2, num3);
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
    public static void avfilter_uninit()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_uninit\u0028\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_uninit\u0028\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_uninit", "()V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_uninit\u0028\u0029V)(num2, num3);
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
    public static int avfilter_register(object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_register", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilter;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_register\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029I)(num2, num3, num4);
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
    public static object avfilter_get_by_name(string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_get_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_get_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_get_by_name", "(Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avfilter$AVFilter;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_get_by_name\u0028Ljava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B)(num2, num3, num4);
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
    public static object av_filter_next(object avf)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eav_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eav_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "av_filter_next", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilter;)Lcom/googlecode/javacv/cpp/avfilter$AVFilter;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eav_filter_next\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003B)(num2, num3, num4);
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
    public static object avfilter_open(object avf, string str)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_open", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilter;Ljava/lang/String;)Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avf);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return (object) __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_open\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilter\u003BLjava\u002Flang\u002FString\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B)(num2, num3, num4, num5);
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
    public static int avfilter_init_filter(object avfc, string str, object p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_init_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_init_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_init_filter", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;Ljava/lang/String;Lcom/googlecode/javacpp/Pointer;)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) str);
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_init_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BLjava\u002Flang\u002FString\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029I)(num2, num3, num4, num5, num6);
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
    public static void avfilter_destroy(object avfc)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_destroy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_destroy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_destroy", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_destroy\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003B\u0029V)(num2, num3, num4);
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
    public static int avfilter_insert_filter(object avfl, object avfc, int i1, int i2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_insert_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BII\u0029I == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_insert_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BII\u0029I = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_insert_filter", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterLink;Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;II)I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfl);
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num6 = i1;
        int num7 = i2;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr, IntPtr, IntPtr, int, int)>) avfilter.__\u003Cjniptr\u003Eavfilter_insert_filter\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterLink\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BII\u0029I)((int) num2, (int) num3, num4, num5, (IntPtr) num6, (IntPtr) num7);
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
    public static void avfilter_insert_pad(int i, int[] iarr, long l, object avfp1, object pp, object avfp2)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_insert_pad\u0028I\u005BIJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_insert_pad\u0028I\u005BIJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_insert_pad", "(I[IJLcom/googlecode/javacv/cpp/avfilter$AVFilterPad;Lcom/googlecode/javacpp/PointerPointer;Lcom/googlecode/javacv/cpp/avfilter$AVFilterPad;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        int num4 = i;
        // ISSUE: explicit reference operation
        IntPtr num5 = ((JNI.Frame) @frame).MakeLocalRef((object) iarr);
        long num6 = l;
        // ISSUE: explicit reference operation
        IntPtr num7 = ((JNI.Frame) @frame).MakeLocalRef(avfp1);
        // ISSUE: explicit reference operation
        IntPtr num8 = ((JNI.Frame) @frame).MakeLocalRef(pp);
        // ISSUE: explicit reference operation
        IntPtr num9 = ((JNI.Frame) @frame).MakeLocalRef(avfp2);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int, IntPtr, long, IntPtr, IntPtr, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_insert_pad\u0028I\u005BIJLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003BLcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003BLcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V)(num2, num3, (IntPtr) num4, (long) num5, (IntPtr) num6, (int) num7, num8, num9);
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
    public static void avfilter_insert_inpad(object avfc, int i, object avfp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_insert_inpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_insert_inpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_insert_inpad", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;ILcom/googlecode/javacv/cpp/avfilter$AVFilterPad;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avfp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_insert_inpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
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
    public static void avfilter_insert_outpad(object avfc, int i, object avfp)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (avfilter.__\u003Cjniptr\u003Eavfilter_insert_outpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V == IntPtr.Zero)
        avfilter.__\u003Cjniptr\u003Eavfilter_insert_outpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V = JNI.Frame.GetFuncPtr(avfilter.__\u003CGetCallerID\u003E(), "com/googlecode/javacv/cpp/avfilter", "avfilter_insert_outpad", "(Lcom/googlecode/javacv/cpp/avfilter$AVFilterContext;ILcom/googlecode/javacv/cpp/avfilter$AVFilterPad;)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(avfilter.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) ClassLiteral<avfilter>.Value);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef(avfc);
        int num5 = i;
        // ISSUE: explicit reference operation
        IntPtr num6 = ((JNI.Frame) @frame).MakeLocalRef(avfp);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, IntPtr, int, IntPtr)>) avfilter.__\u003Cjniptr\u003Eavfilter_insert_outpad\u0028Lcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterContext\u003BILcom\u002Fgooglecode\u002Fjavacv\u002Fcpp\u002Favfilter\u0024AVFilterPad\u003B\u0029V)(num2, (int) num3, num4, (IntPtr) num5, num6);
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
      if (avfilter.__\u003CcallerID\u003E == null)
        avfilter.__\u003CcallerID\u003E = (CallerID) new avfilter.__\u003CCallerID\u003E();
      return avfilter.__\u003CcallerID\u003E;
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
