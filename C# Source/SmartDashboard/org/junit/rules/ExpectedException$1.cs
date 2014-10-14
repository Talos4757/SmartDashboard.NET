// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ExpectedException$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal.matchers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  [InnerClass]
  [Signature("Lorg/junit/internal/matchers/TypeSafeMatcher<Ljava/lang/Throwable;>;")]
  [EnclosingMethod("org.junit.rules.ExpectedException", "hasMessage", "(Lorg.hamcrest.Matcher;)Lorg.hamcrest.Matcher;")]
  [SourceFile("ExpectedException.java")]
  [Modifiers]
  internal sealed class ExpectedException\u00241 : TypeSafeMatcher
  {
    [Modifiers]
    internal ExpectedException this\u00240 = obj0;
    [Modifiers]
    internal Matcher val\u0024matcher = obj1;

    [LineNumberTable((ushort) 131)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ExpectedException\u00241([In] ExpectedException obj0, [In] Matcher obj1)
    {
    }

    [LineNumberTable((ushort) 132)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool matchesSafely([In] Exception obj0)
    {
      return (this.val\u0024matcher.matches((object) Throwable.instancehelper_getMessage(obj0)) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo([In] Description obj0)
    {
      obj0.appendText("exception with message ");
      obj0.appendDescriptionOf((SelfDescribing) this.val\u0024matcher);
    }

    [Modifiers]
    [LineNumberTable((ushort) 131)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matchesSafely([In] object obj0)
    {
      return (this.matchesSafely((Exception) obj0) ? 1 : 0) != 0;
    }
  }
}
