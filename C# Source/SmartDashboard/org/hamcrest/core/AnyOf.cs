// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.AnyOf
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class AnyOf : BaseMatcher
  {
    [Modifiers]
    [Signature("Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;")]
    private Iterable matchers;

    [Signature("(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnyOf(Iterable matchers)
    {
      AnyOf anyOf = this;
      this.matchers = matchers;
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 41)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anyOf(params Matcher[] matchers)
    {
      return AnyOf.anyOf((Iterable) Arrays.asList((object[]) matchers));
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 49)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anyOf(Iterable matchers)
    {
      return (Matcher) new AnyOf(matchers);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 127, (byte) 1, (byte) 105, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object o)
    {
      Iterator iterator = this.matchers.iterator();
      while (iterator.hasNext())
      {
        if (((Matcher) iterator.next()).matches(o))
          return true;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendList("(", " or ", ")", this.matchers);
    }
  }
}
