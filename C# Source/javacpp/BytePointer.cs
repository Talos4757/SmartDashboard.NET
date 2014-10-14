// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.BytePointer
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
  public class BytePointer : Pointer
  {
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029B;
    static IntPtr __\u003Cjniptr\u003Eput\u0028B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B;

    [HideFromJava]
    static BytePointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BytePointer(int size)
    {
      BytePointer bytePointer = this;
      this.allocateArray(size);
    }

    [Throws(new string[] {"java.io.UnsupportedEncodingException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 114, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BytePointer(string s, string charsetName)
      : this(String.instancehelper_getBytes(s, charsetName).Length + 1)
    {
      BytePointer bytePointer = this;
      this.putString(s, charsetName);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 113, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BytePointer(string s)
      : this(String.instancehelper_getBytes(s).Length + 1)
    {
      BytePointer bytePointer = this;
      this.putString(s);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 106, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BytePointer(params byte[] array)
      : this(array.Length)
    {
      BytePointer bytePointer = this;
      this.asBuffer(array.Length).put(array);
    }

    [LineNumberTable((ushort) 46)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BytePointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.UnsupportedEncodingException"})]
    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BytePointer putString(string s, string charsetName)
    {
      byte[] bytes = String.instancehelper_getBytes(s, charsetName);
      this.asBuffer(bytes.Length + 1).put(bytes).put((byte) 0);
      return this;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 103, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BytePointer putString(string s)
    {
      byte[] bytes = String.instancehelper_getBytes(s);
      this.asBuffer(bytes.Length + 1).put(bytes).put((byte) 0);
      return this;
    }

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ByteBuffer asBuffer(int capacity)
    {
      // ISSUE: explicit non-virtual call
      return (ByteBuffer) __nonvirtual (((Pointer) this).asBuffer(capacity));
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (BytePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        BytePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(BytePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/BytePointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(BytePointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) BytePointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BytePointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (BytePointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    public virtual byte get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (BytePointer.__\u003Cjniptr\u003Eget\u0028\u0029B == IntPtr.Zero)
        BytePointer.__\u003Cjniptr\u003Eget\u0028\u0029B = JNI.Frame.GetFuncPtr(BytePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/BytePointer", "get", "()B");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(BytePointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<byte (IntPtr, IntPtr)>) BytePointer.__\u003Cjniptr\u003Eget\u0028\u0029B)(num2, num3);
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

    [LineNumberTable(new byte[] {(byte) 5, (byte) 104, (byte) 105, (byte) 125, (byte) 104, (byte) 101, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] getStringBytes()
    {
      byte[] numArray1 = new byte[16];
      int num1 = 0;
      int position = base.position();
      while (true)
      {
        do
        {
          byte[] numArray2 = numArray1;
          int num2 = num1;
          int num3 = (int) (sbyte) this.position(position).get();
          int index = num2;
          byte[] numArray3 = numArray2;
          int num4 = num3;
          numArray3[index] = (byte) num3;
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

    [Throws(new string[] {"java.io.UnsupportedEncodingException"})]
    [LineNumberTable((ushort) 67)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString(string charsetName)
    {
      return String.newhelper(this.getStringBytes(), charsetName);
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString()
    {
      return String.newhelper(this.getStringBytes());
    }

    [Modifiers]
    public virtual BytePointer put(byte b)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (BytePointer.__\u003Cjniptr\u003Eput\u0028B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B == IntPtr.Zero)
        BytePointer.__\u003Cjniptr\u003Eput\u0028B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B = JNI.Frame.GetFuncPtr(BytePointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/BytePointer", "put", "(B)Lcom/googlecode/javacpp/BytePointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(BytePointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = (int) b;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, byte)>) BytePointer.__\u003Cjniptr\u003Eput\u0028B\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FBytePointer\u003B)((byte) num2, num3, (IntPtr) num4);
        return (BytePointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Buffer \u003Cbridge\u003EasBuffer(int x0)
    {
      return (Buffer) this.asBuffer(x0);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pointer \u003Cbridge\u003Eposition(int x0)
    {
      return (Pointer) this.position(x0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (BytePointer.__\u003CcallerID\u003E == null)
        BytePointer.__\u003CcallerID\u003E = (CallerID) new BytePointer.__\u003CCallerID\u003E();
      return BytePointer.__\u003CcallerID\u003E;
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
