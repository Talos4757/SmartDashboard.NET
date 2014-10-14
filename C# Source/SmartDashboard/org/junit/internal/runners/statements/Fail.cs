// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.Fail
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.statements
{
  public class Fail : Statement
  {
    [Modifiers]
    private Exception fError;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 151, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Fail(Exception e)
    {
      Fail fail = this;
      this.fError = e;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 15)]
    public override void evaluate()
    {
      throw Throwable.__\u003Cunmap\u003E(this.fError);
    }
  }
}
