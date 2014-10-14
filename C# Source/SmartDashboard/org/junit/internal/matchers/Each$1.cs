// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.Each$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.hamcrest;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.matchers
{
  [InnerClass]
  [Signature("Lorg/hamcrest/BaseMatcher<Ljava/lang/Iterable<TT;>;>;")]
  [EnclosingMethod("org.junit.internal.matchers.Each", "each", "(Lorg.hamcrest.Matcher;)Lorg.hamcrest.Matcher;")]
  [SourceFile("Each.java")]
  [Modifiers]
  internal sealed class Each\u00241 : BaseMatcher
  {
    [Modifiers]
    internal Matcher val\u0024allItemsAre = obj0;
    [Modifiers]
    internal Matcher val\u0024individual = obj1;

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Each\u00241([In] Matcher obj0, [In] Matcher obj1)
    {
    }

    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches([In] object obj0)
    {
      return (this.val\u0024allItemsAre.matches(obj0) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo([In] Description obj0)
    {
      obj0.appendText("each ");
      this.val\u0024individual.describeTo(obj0);
    }
  }
}
