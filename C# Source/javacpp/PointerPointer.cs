// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.PointerPointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  public class PointerPointer : Pointer
  {
    private Pointer[] pointerArray;
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B;
    static IntPtr __\u003Cjniptr\u003Eput\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B;

    [HideFromJava]
    static PointerPointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(int size)
    {
      PointerPointer pointerPointer = this;
      this.allocateArray(size);
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params Pointer[] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params byte[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params short[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params int[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 32)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params long[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 33)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params float[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params double[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(params char[][] array)
      : this(array.Length)
    {
      PointerPointer pointerPointer = this;
      this.put(array);
      this.position(0);
    }

    [LineNumberTable((ushort) 37)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerPointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 103, (byte) 48, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params Pointer[] array)
    {
      for (int position = 0; position < array.Length; ++position)
        this.position(position).put(array[position]);
      return this;
    }

    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (PointerPointer) __nonvirtual (((Pointer) this).position(position));
    }

    [LineNumberTable(new byte[] {(byte) 4, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params byte[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        BytePointer.__\u003Cclinit\u003E();
        BytePointer bytePointer = new BytePointer(array[index1]);
        pointerArray[index2] = (Pointer) bytePointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params short[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        ShortPointer.__\u003Cclinit\u003E();
        ShortPointer shortPointer = new ShortPointer(array[index1]);
        pointerArray[index2] = (Pointer) shortPointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params int[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        IntPointer.__\u003Cclinit\u003E();
        IntPointer intPointer = new IntPointer(array[index1]);
        pointerArray[index2] = (Pointer) intPointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params long[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        LongPointer.__\u003Cclinit\u003E();
        LongPointer longPointer = new LongPointer(array[index1]);
        pointerArray[index2] = (Pointer) longPointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params float[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        FloatPointer.__\u003Cclinit\u003E();
        FloatPointer floatPointer = new FloatPointer(array[index1]);
        pointerArray[index2] = (Pointer) floatPointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params double[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        DoublePointer.__\u003Cclinit\u003E();
        DoublePointer doublePointer = new DoublePointer(array[index1]);
        pointerArray[index2] = (Pointer) doublePointer;
      }
      return this.put(this.pointerArray);
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 109, (byte) 103, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PointerPointer put(params char[][] array)
    {
      this.pointerArray = new Pointer[array.Length];
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        Pointer[] pointerArray = this.pointerArray;
        int index2 = index1;
        CharPointer.__\u003Cclinit\u003E();
        CharPointer charPointer = new CharPointer(array[index1]);
        pointerArray[index2] = (Pointer) charPointer;
      }
      return this.put(this.pointerArray);
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PointerPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        PointerPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(PointerPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/PointerPointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PointerPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) PointerPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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
    public virtual PointerPointer put(Pointer p)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PointerPointer.__\u003Cjniptr\u003Eput\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B == IntPtr.Zero)
        PointerPointer.__\u003Cjniptr\u003Eput\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B = JNI.Frame.GetFuncPtr(PointerPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/PointerPointer", "put", "(Lcom/googlecode/javacpp/Pointer;)Lcom/googlecode/javacpp/PointerPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PointerPointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: explicit reference operation
        IntPtr num4 = ((JNI.Frame) @frame).MakeLocalRef((object) p);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, IntPtr)>) PointerPointer.__\u003Cjniptr\u003Eput\u0028Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointerPointer\u003B)(num2, num3, num4);
        return (PointerPointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
    public virtual Pointer get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (PointerPointer.__\u003Cjniptr\u003Eget\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B == IntPtr.Zero)
        PointerPointer.__\u003Cjniptr\u003Eget\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B = JNI.Frame.GetFuncPtr(PointerPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/PointerPointer", "get", "()Lcom/googlecode/javacpp/Pointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(PointerPointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num4 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr)>) PointerPointer.__\u003Cjniptr\u003Eget\u0028\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FPointer\u003B)(num2, num3);
        return (Pointer) ((JNI.Frame) local).UnwrapLocalRef(num4);
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
    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pointer \u003Cbridge\u003Eposition(int x0)
    {
      return (Pointer) this.position(x0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PointerPointer.__\u003CcallerID\u003E == null)
        PointerPointer.__\u003CcallerID\u003E = (CallerID) new PointerPointer.__\u003CCallerID\u003E();
      return PointerPointer.__\u003CcallerID\u003E;
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
