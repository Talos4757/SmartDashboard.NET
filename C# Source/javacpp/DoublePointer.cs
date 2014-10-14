// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.DoublePointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.nio;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  public class DoublePointer : Pointer
  {
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029D;
    static IntPtr __\u003Cjniptr\u003Eput\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FDoublePointer\u003B;

    [HideFromJava]
    static DoublePointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoublePointer(int size)
    {
      DoublePointer doublePointer = this;
      this.allocateArray(size);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 106, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoublePointer(params double[] array)
      : this(array.Length)
    {
      DoublePointer doublePointer = this;
      this.asBuffer(array.Length).put(array);
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoublePointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 46)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleBuffer asBuffer(int capacity)
    {
      return this.asByteBuffer(capacity).asDoubleBuffer();
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (DoublePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        DoublePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(DoublePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/DoublePointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(DoublePointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) DoublePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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

    [LineNumberTable((ushort) 39)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DoublePointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (DoublePointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    public virtual double get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (DoublePointer.__\u003Cjniptr\u003Eget\u0028\u0029D == IntPtr.Zero)
        DoublePointer.__\u003Cjniptr\u003Eget\u0028\u0029D = JNI.Frame.GetFuncPtr(DoublePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/DoublePointer", "get", "()D");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(DoublePointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<double (IntPtr, IntPtr)>) DoublePointer.__\u003Cjniptr\u003Eget\u0028\u0029D)(num2, num3);
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
    public virtual DoublePointer put(double d)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (DoublePointer.__\u003Cjniptr\u003Eput\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FDoublePointer\u003B == IntPtr.Zero)
        DoublePointer.__\u003Cjniptr\u003Eput\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FDoublePointer\u003B = JNI.Frame.GetFuncPtr(DoublePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/DoublePointer", "put", "(D)Lcom/googlecode/javacpp/DoublePointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(DoublePointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        double num4 = d;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, double)>) DoublePointer.__\u003Cjniptr\u003Eput\u0028D\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FDoublePointer\u003B)((double) num2, num3, (IntPtr) num4);
        return (DoublePointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
    public virtual Buffer \u003Cbridge\u003EasBuffer(int x0)
    {
      return (Buffer) this.asBuffer(x0);
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
      if (DoublePointer.__\u003CcallerID\u003E == null)
        DoublePointer.__\u003CcallerID\u003E = (CallerID) new DoublePointer.__\u003CCallerID\u003E();
      return DoublePointer.__\u003CcallerID\u003E;
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
