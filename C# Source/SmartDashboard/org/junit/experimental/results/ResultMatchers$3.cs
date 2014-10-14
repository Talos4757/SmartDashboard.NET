// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.results.ResultMatchers$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.results
{
  [InnerClass]
  [Signature("Lorg/hamcrest/BaseMatcher<Lorg/junit/experimental/results/PrintableResult;>;")]
  [EnclosingMethod("org.junit.experimental.results.ResultMatchers", "hasFailureContaining", "(Ljava.lang.String;)Lorg.hamcrest.Matcher;")]
  [SourceFile("ResultMatchers.java")]
  [Modifiers]
  internal sealed class ResultMatchers\u00243 : BaseMatcher
  {
    [Modifiers]
    internal string val\u0024string = obj0;

    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ResultMatchers\u00243([In] string obj0)
    {
    }

    [LineNumberTable((ushort) 62)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches([In] object obj0)
    {
      string str = Object.instancehelper_toString(obj0);
      object obj = (object) this.val\u0024string;
      CharSequence charSequence1;
      charSequence1.__\u003Cref\u003E = (__Null) obj;
      CharSequence charSequence2 = charSequence1;
      return (String.instancehelper_contains(str, charSequence2) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo([In] Description obj0)
    {
      obj0.appendText(new StringBuilder().append("has failure containing ").append(this.val\u0024string).toString());
    }
  }
}
