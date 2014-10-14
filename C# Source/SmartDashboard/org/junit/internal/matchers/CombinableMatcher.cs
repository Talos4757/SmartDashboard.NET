// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.CombinableMatcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.matchers
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class CombinableMatcher : BaseMatcher
  {
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<+TT;>;")]
    private Matcher fMatcher;

    [Signature("(Lorg/hamcrest/Matcher<+TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinableMatcher(Matcher matcher)
    {
      CombinableMatcher combinableMatcher = this;
      this.fMatcher = matcher;
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object item)
    {
      return (this.fMatcher.matches(item) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendDescriptionOf((SelfDescribing) this.fMatcher);
    }

    [Signature("(Lorg/hamcrest/Matcher<+TT;>;)Lorg/junit/internal/matchers/CombinableMatcher<TT;>;")]
    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CombinableMatcher and(Matcher matcher)
    {
      Matcher[] matcherArray = new Matcher[2];
      int index1 = 0;
      Matcher matcher1 = matcher;
      matcherArray[index1] = matcher1;
      int index2 = 1;
      Matcher matcher2 = this.fMatcher;
      matcherArray[index2] = matcher2;
      return new CombinableMatcher(CoreMatchers.allOf(matcherArray));
    }

    [Signature("(Lorg/hamcrest/Matcher<+TT;>;)Lorg/junit/internal/matchers/CombinableMatcher<TT;>;")]
    [LineNumberTable((ushort) 32)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CombinableMatcher or(Matcher matcher)
    {
      Matcher[] matcherArray = new Matcher[2];
      int index1 = 0;
      Matcher matcher1 = matcher;
      matcherArray[index1] = matcher1;
      int index2 = 1;
      Matcher matcher2 = this.fMatcher;
      matcherArray[index2] = matcher2;
      return new CombinableMatcher(CoreMatchers.anyOf(matcherArray));
    }
  }
}
