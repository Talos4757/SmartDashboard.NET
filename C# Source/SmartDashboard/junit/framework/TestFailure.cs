// Decompiled with JetBrains decompiler
// Type: junit.framework.TestFailure
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace junit.framework
{
  public class TestFailure : Object
  {
    protected internal Test fFailedTest;
    protected internal Exception fThrownException;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestFailure(Test failedTest, Exception thrownException)
    {
      base.\u002Ector();
      TestFailure testFailure = this;
      this.fFailedTest = failedTest;
      this.fThrownException = thrownException;
    }

    public virtual Exception thrownException()
    {
      return this.fThrownException;
    }

    public virtual Test failedTest()
    {
      return this.fFailedTest;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 102, (byte) 127, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(new StringBuilder().append((object) this.fFailedTest).append(": ").append(Throwable.instancehelper_getMessage(this.fThrownException)).toString());
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 102, (byte) 103, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string trace()
    {
      StringWriter stringWriter = new StringWriter();
      Throwable.instancehelper_printStackTrace(this.thrownException(), new PrintWriter((Writer) stringWriter));
      return stringWriter.getBuffer().toString();
    }

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string exceptionMessage()
    {
      return Throwable.instancehelper_getMessage(this.thrownException());
    }

    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isFailure()
    {
      return this.thrownException() is AssertionFailedError;
    }
  }
}
