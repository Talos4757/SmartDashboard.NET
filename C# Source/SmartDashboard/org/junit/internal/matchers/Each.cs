// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.Each
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.matchers
{
  public class Each : Object
  {
    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Each()
    {
      base.\u002Ector();
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 153, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher each(Matcher individual)
    {
      return (Matcher) new Each\u00241(CoreMatchers.not(IsCollectionContaining.hasItem(CoreMatchers.not(individual))), individual);
    }
  }
}
