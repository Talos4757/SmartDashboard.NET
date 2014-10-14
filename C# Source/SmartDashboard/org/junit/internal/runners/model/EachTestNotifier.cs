// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.model.EachTestNotifier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal;
using org.junit.@internal.runners.model;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners.model
{
  public class EachTestNotifier : Object
  {
    [Modifiers]
    private RunNotifier fNotifier;
    [Modifiers]
    private Description fDescription;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public EachTestNotifier(RunNotifier notifier, Description description)
    {
      base.\u002Ector();
      EachTestNotifier eachTestNotifier = this;
      this.fNotifier = notifier;
      this.fDescription = description;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestIgnored()
    {
      this.fNotifier.fireTestIgnored(this.fDescription);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 104, (byte) 142, (byte) 185})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addFailure(Exception targetException)
    {
      if (targetException is MultipleFailureException)
        this.addMultipleFailureException((MultipleFailureException) targetException);
      else
        this.fNotifier.fireTestFailure(new Failure(this.fDescription, targetException));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestStarted()
    {
      this.fNotifier.fireTestStarted(this.fDescription);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestFinished()
    {
      this.fNotifier.fireTestFinished(this.fDescription);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addFailedAssumption(AssumptionViolatedException e)
    {
      this.fNotifier.fireTestAssumptionFailed(new Failure(this.fDescription, (Exception) e));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 127, (byte) 1, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addMultipleFailureException([In] MultipleFailureException obj0)
    {
      Iterator iterator = obj0.getFailures().iterator();
      while (iterator.hasNext())
        this.addFailure((Exception) iterator.next());
    }
  }
}
