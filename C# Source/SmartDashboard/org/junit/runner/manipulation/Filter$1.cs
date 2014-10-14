// Decompiled with JetBrains decompiler
// Type: org.junit.runner.manipulation.Filter$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.manipulation
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.manipulation.Filter", null, null)]
  [SourceFile("Filter.java")]
  [Modifiers]
  internal sealed class Filter\u00241 : Filter
  {
    [HideFromJava]
    static Filter\u00241()
    {
      Filter.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Filter\u00241()
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public override bool shouldRun([In] Description obj0)
    {
      return true;
    }

    public override string describe()
    {
      return "all tests";
    }
  }
}
