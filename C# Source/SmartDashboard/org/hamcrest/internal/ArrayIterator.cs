// Decompiled with JetBrains decompiler
// Type: org.hamcrest.internal.ArrayIterator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.hamcrest.@internal;
using System.Runtime.CompilerServices;

namespace org.hamcrest.@internal
{
  [Implements(new string[] {"java.util.Iterator"})]
  [Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/lang/Object;>;")]
  public class ArrayIterator : Object, Iterator
  {
    [Modifiers]
    private object array;
    private int currentIndex;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 8, (byte) 167, (byte) 109, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayIterator(object array)
    {
      base.\u002Ector();
      ArrayIterator arrayIterator = this;
      this.currentIndex = 0;
      if (!Object.instancehelper_getClass(array).isArray())
      {
        string str = "not an array";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.array = array;
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasNext()
    {
      return this.currentIndex < Array.getLength(this.array);
    }

    [LineNumberTable((ushort) 22)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object next()
    {
      object obj = this.array;
      ArrayIterator arrayIterator1 = this;
      int num1 = arrayIterator1.currentIndex;
      ArrayIterator arrayIterator2 = arrayIterator1;
      int num2 = num1;
      arrayIterator2.currentIndex = num1 + 1;
      return Array.get(obj, num2);
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove()
    {
      string str = "cannot remove items from an array";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException(str);
    }
  }
}
