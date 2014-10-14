// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsNot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class IsNot : BaseMatcher
  {
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<TT;>;")]
    private Matcher matcher;

    [Signature("(Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsNot(Matcher matcher)
    {
      IsNot isNot = this;
      this.matcher = matcher;
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 35)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher not(Matcher matcher)
    {
      return (Matcher) new IsNot(matcher);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 46)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher not(object value)
    {
      return IsNot.not(IsEqual.equalTo(value));
    }

    [LineNumberTable((ushort) 23)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object arg)
    {
      return !this.matcher.matches(arg);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("not ").appendDescriptionOf((SelfDescribing) this.matcher);
    }
  }
}
