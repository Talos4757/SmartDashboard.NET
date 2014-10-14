// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Request$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.Request", "runner", "(Lorg.junit.runner.Runner;)Lorg.junit.runner.Request;")]
  [SourceFile("Request.java")]
  [Modifiers]
  internal sealed class Request\u00241 : Request
  {
    [Modifiers]
    internal Runner val\u0024runner = obj0;

    [LineNumberTable((ushort) 103)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Request\u00241([In] Runner obj0)
    {
    }

    public override Runner getRunner()
    {
      return this.val\u0024runner;
    }
  }
}
