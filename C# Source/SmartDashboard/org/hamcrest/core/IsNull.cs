// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsNull
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
  public class IsNull : BaseMatcher
  {
    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsNull()
    {
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 28)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher nullValue()
    {
      return (Matcher) new IsNull();
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 44)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher nullValue(Class type)
    {
      return IsNull.nullValue();
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 36)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher notNullValue()
    {
      return IsNot.not(IsNull.nullValue());
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 52)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher notNullValue(Class type)
    {
      return IsNull.notNullValue();
    }

    public override bool matches(object o)
    {
      return o == null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("null");
    }
  }
}
