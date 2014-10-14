// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.IsCollectionContaining
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.hamcrest;
using org.hamcrest.core;
using org.junit.@internal.matchers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.matchers
{
  [Signature("<T:Ljava/lang/Object;>Lorg/junit/internal/matchers/TypeSafeMatcher<Ljava/lang/Iterable<TT;>;>;")]
  public class IsCollectionContaining : TypeSafeMatcher
  {
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<+TT;>;")]
    private Matcher elementMatcher;

    [Signature("(Lorg/hamcrest/Matcher<+TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsCollectionContaining(Matcher elementMatcher)
    {
      IsCollectionContaining collectionContaining = this;
      this.elementMatcher = elementMatcher;
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 39)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItem(Matcher elementMatcher)
    {
      return (Matcher) new IsCollectionContaining(elementMatcher);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable((ushort) 44)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItem(object element)
    {
      return IsCollectionContaining.hasItem(IsEqual.equalTo(element));
    }

    [Signature("(Ljava/lang/Iterable<TT;>;)Z")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 118, (byte) 110, (byte) 164})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool matchesSafely(Iterable collection)
    {
      Iterator iterator = collection.iterator();
      while (iterator.hasNext())
      {
        if (this.elementMatcher.matches(iterator.next()))
          return true;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("a collection containing ").appendDescriptionOf((SelfDescribing) this.elementMatcher);
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 136, (byte) 112, (byte) 46, (byte) 166})]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItems(params Matcher[] elementMatchers)
    {
      ArrayList arrayList = new ArrayList(elementMatchers.Length);
      Matcher[] matcherArray = elementMatchers;
      int length = matcherArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Matcher elementMatcher = matcherArray[index];
        ((Collection) arrayList).add((object) IsCollectionContaining.hasItem(elementMatcher));
      }
      return AllOf.allOf((Iterable) arrayList);
    }

    [Signature("<T:Ljava/lang/Object;>([TT;)Lorg/hamcrest/Matcher<Ljava/lang/Iterable<TT;>;>;")]
    [LineNumberTable(new byte[] {(byte) 9, (byte) 136, (byte) 112, (byte) 46, (byte) 166})]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasItems(params object[] elements)
    {
      ArrayList arrayList = new ArrayList(elements.Length);
      object[] objArray = elements;
      int length = objArray.Length;
      for (int index = 0; index < length; ++index)
      {
        object element = objArray[index];
        ((Collection) arrayList).add((object) IsCollectionContaining.hasItem(element));
      }
      return AllOf.allOf((Iterable) arrayList);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matchesSafely(object x0)
    {
      return (this.matchesSafely((Iterable) x0) ? 1 : 0) != 0;
    }
  }
}
