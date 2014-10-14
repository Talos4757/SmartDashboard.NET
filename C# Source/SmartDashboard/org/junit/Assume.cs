// Decompiled with JetBrains decompiler
// Type: org.junit.Assume
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.hamcrest;
using org.junit.@internal;
using org.junit.@internal.matchers;
using System;
using System.Runtime.CompilerServices;

namespace org.junit
{
  public class Assume : Object
  {
    [LineNumberTable((ushort) 33)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Assume()
    {
      base.\u002Ector();
    }

    [Signature("<T:Ljava/lang/Object;>(TT;Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 19, (byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assumeThat(object actual, Matcher matcher)
    {
      if (matcher.matches(actual))
        return;
      object obj = actual;
      Matcher matcher1 = matcher;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new AssumptionViolatedException(obj, matcher1);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 162, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assumeTrue(bool b)
    {
      Assume.assumeThat((object) Boolean.valueOf(b), CoreMatchers.@is((object) Boolean.valueOf(true)));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assumeNotNull(params object[] objects)
    {
      Assume.assumeThat((object) Arrays.asList(objects), Each.each(CoreMatchers.notNullValue()));
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assumeNoException(Exception t)
    {
      Assume.assumeThat((object) t, CoreMatchers.nullValue());
    }
  }
}
