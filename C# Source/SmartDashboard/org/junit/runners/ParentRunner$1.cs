// Decompiled with JetBrains decompiler
// Type: org.junit.runners.ParentRunner$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [InnerClass]
  [Implements(new string[] {"org.junit.runners.model.RunnerScheduler"})]
  [EnclosingMethod("org.junit.runners.ParentRunner", null, null)]
  [SourceFile("ParentRunner.java")]
  [Modifiers]
  internal sealed class ParentRunner\u00241 : Object, RunnerScheduler
  {
    [Modifiers]
    internal ParentRunner this\u00240;

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParentRunner\u00241([In] ParentRunner obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void schedule([In] Runnable obj0)
    {
      obj0.run();
    }

    public virtual void finished()
    {
    }
  }
}
