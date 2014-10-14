// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.results.ResultMatchers
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.junit.experimental.results
{
  public class ResultMatchers : Object
  {
    [LineNumberTable((ushort) 16)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResultMatchers()
    {
      base.\u002Ector();
    }

    [Signature("(I)Lorg/hamcrest/Matcher<Lorg/junit/experimental/results/PrintableResult;>;")]
    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher failureCountIs(int count)
    {
      return (Matcher) new ResultMatchers\u00241(count);
    }

    [Signature("()Lorg/hamcrest/Matcher<Lorg/junit/experimental/results/PrintableResult;>;")]
    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher isSuccessful()
    {
      return ResultMatchers.failureCountIs(0);
    }

    [Signature("(Ljava/lang/String;)Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasSingleFailureContaining(string @string)
    {
      return (Matcher) new ResultMatchers\u00242(@string);
    }

    [Signature("(Ljava/lang/String;)Lorg/hamcrest/Matcher<Lorg/junit/experimental/results/PrintableResult;>;")]
    [LineNumberTable((ushort) 60)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher hasFailureContaining(string @string)
    {
      return (Matcher) new ResultMatchers\u00243(@string);
    }
  }
}
