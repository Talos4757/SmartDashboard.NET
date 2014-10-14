// Decompiled with JetBrains decompiler
// Type: org.junit.runner.notification.RunListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner;
using System.Runtime.CompilerServices;

namespace org.junit.runner.notification
{
  public class RunListener : Object
  {
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RunListener()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testRunStarted(Description description)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testRunFinished(Result result)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testStarted(Description description)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testFinished(Description description)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testFailure(Failure failure)
    {
    }

    public virtual void testAssumptionFailure(Failure failure)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public virtual void testIgnored(Description description)
    {
    }
  }
}
