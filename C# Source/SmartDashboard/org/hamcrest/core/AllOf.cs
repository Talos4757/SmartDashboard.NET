// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.AllOf
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
  public class AllOf : BaseMatcher
  {
    [Modifiers]
    [Signature("Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;")]
    private Iterable matchers;

    [Signature("(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AllOf(Iterable matchers)
    {
      AllOf allOf = this;
      this.matchers = matchers;
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 40)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher allOf(params Matcher[] matchers)
    {
      return AllOf.allOf((Iterable) Arrays.asList((object[]) matchers));
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 48)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher allOf(Iterable matchers)
    {
      return (Matcher) new AllOf(matchers);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 127, (byte) 1, (byte) 105, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object o)
    {
      Iterator iterator = this.matchers.iterator();
      while (iterator.hasNext())
      {
        if (!((Matcher) iterator.next()).matches(o))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendList("(", " and ", ")", this.matchers);
    }
  }
}
