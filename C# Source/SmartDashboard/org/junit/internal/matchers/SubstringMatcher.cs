// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.SubstringMatcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.matchers
{
  [Signature("Lorg/junit/internal/matchers/TypeSafeMatcher<Ljava/lang/String;>;")]
  public abstract class SubstringMatcher : TypeSafeMatcher
  {
    internal string __\u003C\u003Esubstring;

    [Modifiers]
    protected internal string substring
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Esubstring;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Esubstring = value;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 151, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal SubstringMatcher(string substring)
    {
      SubstringMatcher substringMatcher = this;
      this.__\u003C\u003Esubstring = substring;
    }

    protected internal abstract bool evalSubstringOf(string str);

    protected internal abstract string relationship();

    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool matchesSafely(string item)
    {
      return (this.evalSubstringOf(item) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 223, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("a string ").appendText(this.relationship()).appendText(" ").appendValue((object) this.__\u003C\u003Esubstring);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 5)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matchesSafely(object x0)
    {
      return (this.matchesSafely((string) x0) ? 1 : 0) != 0;
    }
  }
}
