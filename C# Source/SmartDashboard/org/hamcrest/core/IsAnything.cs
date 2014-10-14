// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsAnything
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
  public class IsAnything : BaseMatcher
  {
    [Modifiers]
    private string description;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsAnything(string description)
    {
      IsAnything isAnything = this;
      this.description = description;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsAnything()
      : this("ANYTHING")
    {
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 39)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anything()
    {
      return (Matcher) new IsAnything();
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 49)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anything(string description)
    {
      return (Matcher) new IsAnything(description);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 57)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher any(Class type)
    {
      return (Matcher) new IsAnything();
    }

    public override bool matches(object o)
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText(this.description);
    }
  }
}
