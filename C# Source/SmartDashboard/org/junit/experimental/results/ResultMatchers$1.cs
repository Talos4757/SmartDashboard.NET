// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.results.ResultMatchers$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.results
{
  [InnerClass]
  [Signature("Lorg/junit/internal/matchers/TypeSafeMatcher<Lorg/junit/experimental/results/PrintableResult;>;")]
  [EnclosingMethod("org.junit.experimental.results.ResultMatchers", "failureCountIs", "(I)Lorg.hamcrest.Matcher;")]
  [SourceFile("ResultMatchers.java")]
  [Modifiers]
  internal sealed class ResultMatchers\u00241 : TypeSafeMatcher
  {
    [Modifiers]
    internal int val\u0024count = obj0;

    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ResultMatchers\u00241([In] int obj0)
    {
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool matchesSafely([In] PrintableResult obj0)
    {
      return obj0.failureCount() == this.val\u0024count;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 127, (byte) 17})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo([In] Description obj0)
    {
      obj0.appendText(new StringBuilder().append("has ").append(this.val\u0024count).append(" failures").toString());
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matchesSafely([In] object obj0)
    {
      return (this.matchesSafely((PrintableResult) obj0) ? 1 : 0) != 0;
    }
  }
}
