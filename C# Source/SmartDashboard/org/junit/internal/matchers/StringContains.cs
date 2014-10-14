// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.StringContains
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.matchers
{
  public class StringContains : SubstringMatcher
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringContains(string substring)
      : base(substring)
    {
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool evalSubstringOf(string s)
    {
      return String.instancehelper_indexOf(s, this.__\u003C\u003Esubstring) >= 0;
    }

    protected internal override string relationship()
    {
      return "containing";
    }

    [Signature("(Ljava/lang/String;)Lorg/hamcrest/Matcher<Ljava/lang/String;>;")]
    [LineNumberTable((ushort) 28)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher containsString(string substring)
    {
      return (Matcher) new StringContains(substring);
    }
  }
}
