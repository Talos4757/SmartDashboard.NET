// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.FailOnTimeout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners.statements
{
  public class FailOnTimeout : Statement
  {
    private Statement fNext;
    [Modifiers]
    private long fTimeout;
    private bool fFinished;
    private Exception fThrown;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 232, (byte) 60, (byte) 135, (byte) 167, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FailOnTimeout(Statement next, long timeout)
    {
      FailOnTimeout failOnTimeout = this;
      this.fFinished = false;
      this.fThrown = (Exception) null;
      this.fNext = next;
      this.fTimeout = timeout;
    }

    [Modifiers]
    [LineNumberTable((ushort) 8)]
    internal static Statement access\u0024000([In] FailOnTimeout obj0)
    {
      return obj0.fNext;
    }

    [Modifiers]
    [LineNumberTable((ushort) 8)]
    internal static bool access\u0024102([In] FailOnTimeout obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      FailOnTimeout failOnTimeout1 = obj0;
      int num2 = num1;
      FailOnTimeout failOnTimeout2 = failOnTimeout1;
      int num3 = num2;
      failOnTimeout2.fFinished = num2 != 0;
      return num3 != 0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 8)]
    internal static Exception access\u0024202([In] FailOnTimeout obj0, [In] Exception obj1)
    {
      FailOnTimeout failOnTimeout1 = obj0;
      Exception exception1 = obj1;
      FailOnTimeout failOnTimeout2 = failOnTimeout1;
      Exception exception2 = exception1;
      failOnTimeout2.fThrown = exception1;
      return exception2;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 231, (byte) 75, (byte) 102, (byte) 108, (byte) 104, (byte) 97, (byte) 104, (byte) 108, (byte) 159, (byte) 5, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      FailOnTimeout\u00241 failOnTimeout1 = new FailOnTimeout\u00241(this);
      failOnTimeout1.start();
      failOnTimeout1.join(this.fTimeout);
      if (this.fFinished)
        return;
      if (this.fThrown != null)
        throw Throwable.__\u003Cunmap\u003E(this.fThrown);
      string str = "test timed out after %d milliseconds";
      object[] objArray = new object[1];
      int index = 0;
      Long @long = Long.valueOf(this.fTimeout);
      objArray[index] = (object) @long;
      Exception exception = new Exception(String.format(str, objArray));
      Throwable.instancehelper_setStackTrace((Exception) exception, failOnTimeout1.getStackTrace());
      throw Throwable.__\u003Cunmap\u003E((Exception) exception);
    }
  }
}
