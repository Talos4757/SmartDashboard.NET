// Decompiled with JetBrains decompiler
// Type: org.junit.rules.Timeout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.rules
{
  [Implements(new string[] {"org.junit.rules.MethodRule"})]
  public class Timeout : Object, MethodRule
  {
    [Modifiers]
    private int fMillis;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Timeout(int millis)
    {
      base.\u002Ector();
      Timeout timeout = this;
      this.fMillis = millis;
    }

    [LineNumberTable((ushort) 47)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Statement apply(Statement @base, FrameworkMethod method, object target)
    {
      return (Statement) new FailOnTimeout(@base, (long) this.fMillis);
    }
  }
}
