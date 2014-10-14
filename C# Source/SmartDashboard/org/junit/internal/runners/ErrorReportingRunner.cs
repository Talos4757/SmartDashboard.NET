// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.ErrorReportingRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  public class ErrorReportingRunner : Runner
  {
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/lang/Throwable;>;")]
    private List fCauses;
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fTestClass;

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/Throwable;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 104, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorReportingRunner(Class testClass, Exception cause)
    {
      ErrorReportingRunner errorReportingRunner = this;
      this.fTestClass = testClass;
      this.fCauses = this.getCauses(cause);
    }

    [Signature("(Ljava/lang/Throwable;)Ljava/util/List<Ljava/lang/Throwable;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 104, (byte) 111, (byte) 104, (byte) 110, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getCauses([In] Exception obj0)
    {
      if (obj0 is InvocationTargetException)
        return this.getCauses(Throwable.instancehelper_getCause(obj0));
      else if (obj0 is org.junit.runners.model.InitializationError)
        return ((org.junit.runners.model.InitializationError) obj0).getCauses();
      else if (obj0 is org.junit.@internal.runners.InitializationError)
      {
        return ((org.junit.@internal.runners.InitializationError) obj0).getCauses();
      }
      else
      {
        Exception[] exceptionArray = new Exception[1];
        int index = 0;
        Exception exception = obj0;
        exceptionArray[index] = exception;
        return Arrays.asList((object[]) exceptionArray);
      }
    }

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Description describeCause([In] Exception obj0)
    {
      return Description.createTestDescription(this.fTestClass, "initializationError");
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 104, (byte) 103, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runCause([In] Exception obj0, [In] RunNotifier obj1)
    {
      Description description = this.describeCause(obj0);
      obj1.fireTestStarted(description);
      obj1.fireTestFailure(new Failure(description, obj0));
      obj1.fireTestFinished(description);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 108, (byte) 127, (byte) 1, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Description getDescription()
    {
      Description suiteDescription = Description.createSuiteDescription(this.fTestClass);
      Iterator iterator = this.fCauses.iterator();
      while (iterator.hasNext())
      {
        Exception exception = (Exception) iterator.next();
        suiteDescription.addChild(this.describeCause(exception));
      }
      return suiteDescription;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 127, (byte) 1, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(RunNotifier notifier)
    {
      Iterator iterator = this.fCauses.iterator();
      while (iterator.hasNext())
        this.runCause((Exception) iterator.next(), notifier);
    }
  }
}
