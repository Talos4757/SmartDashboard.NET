// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.IntPointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using java.util;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  public class IntPointer : Pointer
  {
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029I;
    static IntPtr __\u003Cjniptr\u003Eput\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B;

    [HideFromJava]
    static IntPointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 39)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntPointer(int size)
    {
      IntPointer intPointer = this;
      this.allocateArray(size);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 112, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntPointer(string s)
      : this(String.instancehelper_length(s) + 1)
    {
      IntPointer intPointer = this;
      this.putString(s);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 106, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntPointer(params int[] array)
      : this(array.Length)
    {
      IntPointer intPointer = this;
      this.asBuffer(array.Length).put(array);
    }

    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntPointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 108, (byte) 103, (byte) 42, (byte) 166, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IntPointer putString(string s)
    {
      int[] numArray = new int[String.instancehelper_length(s)];
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] = String.instancehelper_codePointAt(s, index);
      this.asBuffer(numArray.Length + 1).put(numArray).put(0);
      return this;
    }

    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntBuffer asBuffer(int capacity)
    {
      return this.asByteBuffer(capacity).asIntBuffer();
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (IntPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        IntPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(IntPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/IntPointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(IntPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) IntPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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

    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IntPointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (IntPointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    public virtual int get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (IntPointer.__\u003Cjniptr\u003Eget\u0028\u0029I == IntPtr.Zero)
        IntPointer.__\u003Cjniptr\u003Eget\u0028\u0029I = JNI.Frame.GetFuncPtr(IntPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/IntPointer", "get", "()I");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(IntPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<int (IntPtr, IntPtr)>) IntPointer.__\u003Cjniptr\u003Eget\u0028\u0029I)(num2, num3);
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 104, (byte) 105, (byte) 124, (byte) 104, (byte) 101, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] getStringCodePoints()
    {
      int[] numArray1 = new int[16];
      int num1 = 0;
      int position = base.position();
      while (true)
      {
        do
        {
          int[] numArray2 = numArray1;
          int num2 = num1;
          int num3 = this.position(position).get();
          int index = num2;
          int[] numArray3 = numArray2;
          int num4 = num3;
          numArray3[index] = num3;
          if (num4 != 0)
          {
            ++num1;
            ++position;
          }
          else
            goto label_4;
        }
        while (num1 < numArray1.Length);
        numArray1 = Arrays.copyOf(numArray1, 2 * numArray1.Length);
      }
label_4:
      return Arrays.copyOf(numArray1, num1);
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString()
    {
      int[] stringCodePoints = this.getStringCodePoints();
      return String.newhelper(stringCodePoints, 0, stringCodePoints.Length);
    }

    [Modifiers]
    public virtual IntPointer put(int i)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (IntPointer.__\u003Cjniptr\u003Eput\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B == IntPtr.Zero)
        IntPointer.__\u003Cjniptr\u003Eput\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B = JNI.Frame.GetFuncPtr(IntPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/IntPointer", "put", "(I)Lcom/googlecode/javacpp/IntPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(IntPointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = i;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) IntPointer.__\u003Cjniptr\u003Eput\u0028I\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FIntPointer\u003B)((int) num2, num3, (IntPtr) num4);
        return (IntPointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Buffer \u003Cbridge\u003EasBuffer(int x0)
    {
      return (Buffer) this.asBuffer(x0);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pointer \u003Cbridge\u003Eposition(int x0)
    {
      return (Pointer) this.position(x0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (IntPointer.__\u003CcallerID\u003E == null)
        IntPointer.__\u003CcallerID\u003E = (CallerID) new IntPointer.__\u003CCallerID\u003E();
      return IntPointer.__\u003CcallerID\u003E;
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
