// Decompiled with JetBrains decompiler
// Type: org.junit.matchers.JUnitMatchers
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;

namespace org.junit.matchers
{
  public class JUnitMatchers : Object
  {
    [LineNumberTable((ushort) 13)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnitMatchers()
    {
      base.\u002Ector();
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 19)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItem(object element)
    {
      return IsCollectionContaining.hasItem(element);
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItem(Matcher elementMatcher)
    {
      return IsCollectionContaining.hasItem(elementMatcher);
    }

    [Signature("<T:Ljava/lang/Object;>([TT;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItems(params object[] elements)
    {
      return IsCollectionContaining.hasItems(elements);
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItems(params Matcher[] elementMatchers)
    {
      return IsCollectionContaining.hasItems(elementMatchers);
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher everyItem(Matcher elementMatcher)
    {
      return Each.each(elementMatcher);
    }

    [Signature("(Ljava/lang/String;)Lorg/hamcrest/Matcher<Ljava/lang/String;>;")]
    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher containsString(string substring)
    {
      return StringContains.containsString(substring);
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/junit/internal/matchers/CombinableMatcher<TT;>;")]
    [LineNumberTable((ushort) 71)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CombinableMatcher both(Matcher matcher)
    {
      return new CombinableMatcher(matcher);
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/junit/internal/matchers/CombinableMatcher<TT;>;")]
    [LineNumberTable((ushort) 81)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CombinableMatcher either(Matcher matcher)
    {
      return new CombinableMatcher(matcher);
    }
  }
}
