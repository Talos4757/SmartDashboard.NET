// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.Is
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class Is : BaseMatcher
  {
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<TT;>;")]
    private Matcher matcher;

    [Signature("(Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Is(Matcher matcher)
    {
      Is @is = this;
      this.matcher = matcher;
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 42)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(Matcher matcher)
    {
      return (Matcher) new Is(matcher);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 53)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(object value)
    {
      return Is.@is(IsEqual.equalTo(value));
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 64)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(Class type)
    {
      return Is.@is(IsInstanceOf.instanceOf(type));
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object arg)
    {
      return (this.matcher.matches(arg) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("is ").appendDescriptionOf((SelfDescribing) this.matcher);
    }
  }
}
