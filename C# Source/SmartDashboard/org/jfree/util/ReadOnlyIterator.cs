// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ReadOnlyIterator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  [Implements(new string[] {"java.util.Iterator"})]
  public class ReadOnlyIterator : Object, Iterator
  {
    private Iterator @base;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReadOnlyIterator(Iterator it)
    {
      base.\u002Ector();
      ReadOnlyIterator readOnlyIterator = this;
      if (it == null)
      {
        string str = "Base iterator is null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.@base = it;
    }

    [LineNumberTable((ushort) 77)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasNext()
    {
      return (this.@base.hasNext() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object next()
    {
      return this.@base.next();
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove()
    {
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException();
    }
  }
}
