// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.SizeTPointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using com.googlecode.javacpp.annotation;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  [Name(new object[] {(byte) 64, "Lcom/googlecode/javacpp/annotation/Name;", "value", "size_t"})]
  public class SizeTPointer : Pointer
  {
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029J;
    static IntPtr __\u003Cjniptr\u003Eput\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003B;

    [HideFromJava]
    static SizeTPointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SizeTPointer(int size)
    {
      SizeTPointer sizeTpointer = this;
      this.allocateArray(size);
    }

    [LineNumberTable((ushort) 32)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SizeTPointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (SizeTPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        SizeTPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(SizeTPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/SizeTPointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(SizeTPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) SizeTPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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

    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SizeTPointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (SizeTPointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    public virtual long get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (SizeTPointer.__\u003Cjniptr\u003Eget\u0028\u0029J == IntPtr.Zero)
        SizeTPointer.__\u003Cjniptr\u003Eget\u0028\u0029J = JNI.Frame.GetFuncPtr(SizeTPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/SizeTPointer", "get", "()J");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(SizeTPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<long (IntPtr, IntPtr)>) SizeTPointer.__\u003Cjniptr\u003Eget\u0028\u0029J)(num2, num3);
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
    public virtual SizeTPointer put(long l)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (SizeTPointer.__\u003Cjniptr\u003Eput\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003B == IntPtr.Zero)
        SizeTPointer.__\u003Cjniptr\u003Eput\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003B = JNI.Frame.GetFuncPtr(SizeTPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/SizeTPointer", "put", "(J)Lcom/googlecode/javacpp/SizeTPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(SizeTPointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        long num4 = l;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, long)>) SizeTPointer.__\u003Cjniptr\u003Eput\u0028J\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FSizeTPointer\u003B)((long) num2, num3, (IntPtr) num4);
        return (SizeTPointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pointer \u003Cbridge\u003Eposition(int x0)
    {
      return (Pointer) this.position(x0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (SizeTPointer.__\u003CcallerID\u003E == null)
        SizeTPointer.__\u003CcallerID\u003E = (CallerID) new SizeTPointer.__\u003CCallerID\u003E();
      return SizeTPointer.__\u003CcallerID\u003E;
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
