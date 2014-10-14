// Decompiled with JetBrains decompiler
// Type: org.hamcrest.CoreMatchers
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest.core;
using System.Runtime.CompilerServices;

namespace org.hamcrest
{
  public class CoreMatchers : Object
  {
    [LineNumberTable((ushort) 4)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoreMatchers()
    {
      base.\u002Ector();
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(Matcher matcher)
    {
      return Is.@is(matcher);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(object value)
    {
      return Is.@is(value);
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher @is(Class type)
    {
      return Is.@is(type);
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/hamcrest/Matcher<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher not(Matcher matcher)
    {
      return IsNot.not(matcher);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher not(object value)
    {
      return IsNot.not(value);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher equalTo(object operand)
    {
      return IsEqual.equalTo(operand);
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 66)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher instanceOf(Class type)
    {
      return IsInstanceOf.instanceOf(type);
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher allOf(params Matcher[] matchers)
    {
      return AllOf.allOf(matchers);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 80)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher allOf(Iterable matchers)
    {
      return AllOf.allOf(matchers);
    }

    [Signature("<T:Ljava/lang/Object;>([Lorg/hamcrest/Matcher<+TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anyOf(params Matcher[] matchers)
    {
      return AnyOf.anyOf(matchers);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<Lorg/hamcrest/Matcher<+TT;>;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anyOf(Iterable matchers)
    {
      return AnyOf.anyOf(matchers);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 104)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher sameInstance(object @object)
    {
      return IsSame.sameInstance(@object);
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 111)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anything()
    {
      return IsAnything.anything();
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher anything(string description)
    {
      return IsAnything.anything(description);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher any(Class type)
    {
      return IsAnything.any(type);
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 134)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher nullValue()
    {
      return IsNull.nullValue();
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 141)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher nullValue(Class type)
    {
      return IsNull.nullValue(type);
    }

    [Signature("<T:Ljava/lang/Object;>()Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher notNullValue()
    {
      return IsNull.notNullValue();
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher notNullValue(Class type)
    {
      return IsNull.notNullValue(type);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Lorg/hamcrest/Matcher<TT;>;[Ljava/lang/Object;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher describedAs(string description, Matcher matcher, params object[] values)
    {
      return DescribedAs.describedAs(description, matcher, values);
    }
  }
}
