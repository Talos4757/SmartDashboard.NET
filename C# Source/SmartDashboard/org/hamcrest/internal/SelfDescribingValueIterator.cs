// Decompiled with JetBrains decompiler
// Type: org.hamcrest.internal.SelfDescribingValueIterator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.hamcrest;
using org.hamcrest.@internal;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace org.hamcrest.@internal
{
  [Implements(new string[] {"java.util.Iterator"})]
  [Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<Lorg/hamcrest/SelfDescribing;>;")]
  public class SelfDescribingValueIterator : Object, Iterator
  {
    [Signature("Ljava/util/Iterator<TT;>;")]
    private Iterator values;

    [Signature("(Ljava/util/Iterator<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelfDescribingValueIterator(Iterator values)
    {
      base.\u002Ector();
      SelfDescribingValueIterator describingValueIterator = this;
      this.values = values;
    }

    [LineNumberTable((ushort) 19)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SelfDescribing next()
    {
      return (SelfDescribing) new SelfDescribingValue(this.values.next());
    }

    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasNext()
    {
      return (this.values.hasNext() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove()
    {
      this.values.remove();
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object \u003Cbridge\u003Enext()
    {
      return (object) this.next();
    }

    [HideFromJava]
    object Iterator.java\u002Eutil\u002EIterator\u002F\u0028\u0029Ljava\u002Elang\u002EObject\u003Bnext()
    {
      return this.\u003Cbridge\u003Enext();
    }
  }
}
