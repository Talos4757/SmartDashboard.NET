// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.CharPointer
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
  public class CharPointer : Pointer
  {
    static IntPtr __\u003Cjniptr\u003EallocateArray\u0028I\u0029V;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;
    static IntPtr __\u003Cjniptr\u003Eget\u0028\u0029C;
    static IntPtr __\u003Cjniptr\u003Eput\u0028C\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FCharPointer\u003B;

    [HideFromJava]
    static CharPointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 39)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPointer(int size)
    {
      CharPointer charPointer = this;
      this.allocateArray(size);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 113, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPointer(string s)
      : this(String.instancehelper_toCharArray(s).Length + 1)
    {
      CharPointer charPointer = this;
      this.putString(s);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 106, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPointer(params char[] array)
      : this(array.Length)
    {
      CharPointer charPointer = this;
      this.asBuffer(array.Length).put(array);
    }

    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 103, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CharPointer putString(string s)
    {
      char[] chArray = String.instancehelper_toCharArray(s);
      this.asBuffer(chArray.Length + 1).put(chArray).put(char.MinValue);
      return this;
    }

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharBuffer asBuffer(int capacity)
    {
      return this.asByteBuffer(capacity).asCharBuffer();
    }

    [Modifiers]
    private void allocateArray([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (CharPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V == IntPtr.Zero)
        CharPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V = JNI.Frame.GetFuncPtr(CharPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/CharPointer", "allocateArray", "(I)V");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(CharPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void (IntPtr, IntPtr, int)>) CharPointer.__\u003Cjniptr\u003EallocateArray\u0028I\u0029V)((int) num2, num3, (IntPtr) num4);
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
    public virtual CharPointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (CharPointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    public virtual char get()
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (CharPointer.__\u003Cjniptr\u003Eget\u0028\u0029C == IntPtr.Zero)
        CharPointer.__\u003Cjniptr\u003Eget\u0028\u0029C = JNI.Frame.GetFuncPtr(CharPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/CharPointer", "get", "()C");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(CharPointer.__\u003CGetCallerID\u003E());
      try
      {
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        return __calli((__FnPtr<char (IntPtr, IntPtr)>) CharPointer.__\u003Cjniptr\u003Eget\u0028\u0029C)(num2, num3);
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
    public virtual char[] getStringChars()
    {
      char[] chArray1 = new char[16];
      int num1 = 0;
      int position = base.position();
      while (true)
      {
        do
        {
          char[] chArray2 = chArray1;
          int num2 = num1;
          int num3 = (int) this.position(position).get();
          int index = num2;
          char[] chArray3 = chArray2;
          int num4 = num3;
          chArray3[index] = (char) num3;
          if (num4 != 0)
          {
            ++num1;
            ++position;
          }
          else
            goto label_4;
        }
        while (num1 < chArray1.Length);
        chArray1 = Arrays.copyOf(chArray1, 2 * chArray1.Length);
      }
label_4:
      return Arrays.copyOf(chArray1, num1);
    }

    [LineNumberTable((ushort) 60)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString()
    {
      return String.newhelper(this.getStringChars());
    }

    [Modifiers]
    public virtual CharPointer put(char ch)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (CharPointer.__\u003Cjniptr\u003Eput\u0028C\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FCharPointer\u003B == IntPtr.Zero)
        CharPointer.__\u003Cjniptr\u003Eput\u0028C\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FCharPointer\u003B = JNI.Frame.GetFuncPtr(CharPointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/CharPointer", "put", "(C)Lcom/googlecode/javacpp/CharPointer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(CharPointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = (int) ch;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, char)>) CharPointer.__\u003Cjniptr\u003Eput\u0028C\u0029Lcom\u002Fgooglecode\u002Fjavacpp\u002FCharPointer\u003B)((char) num2, num3, (IntPtr) num4);
        return (CharPointer) ((JNI.Frame) local).UnwrapLocalRef(num5);
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
      if (CharPointer.__\u003CcallerID\u003E == null)
        CharPointer.__\u003CcallerID\u003E = (CallerID) new CharPointer.__\u003CCallerID\u003E();
      return CharPointer.__\u003CcallerID\u003E;
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
