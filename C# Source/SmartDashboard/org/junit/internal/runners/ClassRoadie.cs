// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.ClassRoadie
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit.@internal;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  public class ClassRoadie : Object
  {
    private RunNotifier fNotifier;
    private TestClass fTestClass;
    private Description fDescription;
    [Modifiers]
    private Runnable fRunnable;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassRoadie(RunNotifier notifier, TestClass testClass, Description description, Runnable runnable)
    {
      base.\u002Ector();
      ClassRoadie classRoadie = this;
      this.fNotifier = notifier;
      this.fTestClass = testClass;
      this.fDescription = description;
      this.fRunnable = runnable;
    }

    [Throws(new string[] {"org.junit.internal.runners.FailedBefore"})]
    [LineNumberTable(new byte[] {(byte) 4, (byte) 108, (byte) 123, (byte) 191, (byte) 25, (byte) 10, (byte) 98, (byte) 255, (byte) 1, (byte) 71, (byte) 226, (byte) 59, (byte) 97, (byte) 107, (byte) 98, (byte) 104, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runBefores()
    {
      InvocationTargetException invocationTargetException1;
      Exception exception1;
      try
      {
        try
        {
          try
          {
            Iterator iterator = this.fTestClass.getBefores().iterator();
            while (iterator.hasNext())
              ((Method) iterator.next()).invoke((object) null, new object[0], ClassRoadie.__\u003CGetCallerID\u003E());
            return;
          }
          catch (InvocationTargetException ex)
          {
            int num = 1;
            invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (AssumptionViolatedException ex)
        {
          goto label_7;
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_8;
      }
      InvocationTargetException invocationTargetException2 = invocationTargetException1;
      Exception exception2;
      try
      {
        InvocationTargetException invocationTargetException3 = invocationTargetException2;
        try
        {
          throw Throwable.__\u003Cunmap\u003E(invocationTargetException3.getTargetException());
        }
        catch (AssumptionViolatedException ex)
        {
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        exception2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_14;
      }
      // ISSUE: variable of the null type
      __Null local = null;
      goto label_16;
label_14:
      Exception targetException = exception2;
      goto label_17;
label_7:
      local = null;
      goto label_16;
label_8:
      targetException = exception1;
      goto label_17;
label_16:
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new FailedBefore();
label_17:
      this.addFailure(targetException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new FailedBefore();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runUnprotected()
    {
      this.fRunnable.run();
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 108, (byte) 158, (byte) 255, (byte) 20, (byte) 69, (byte) 226, (byte) 60, (byte) 98, (byte) 173, (byte) 2, (byte) 98, (byte) 104, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runAfters()
    {
      Iterator iterator = this.fTestClass.getAfters().iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        InvocationTargetException invocationTargetException;
        Exception targetException;
        try
        {
          try
          {
            method.invoke((object) null, new object[0], ClassRoadie.__\u003CGetCallerID\u003E());
            continue;
          }
          catch (InvocationTargetException ex)
          {
            int num = 1;
            invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (Exception ex)
        {
          int num = 0;
          targetException = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          goto label_7;
        }
        this.addFailure(invocationTargetException.getTargetException());
        continue;
label_7:
        this.addFailure(targetException);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addFailure(Exception targetException)
    {
      this.fNotifier.fireTestFailure(new Failure(this.fDescription, targetException));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 102, (byte) 172, (byte) 76, (byte) 102, (byte) 226, (byte) 61, (byte) 129, (byte) 102, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runProtected()
    {
      // ISSUE: fault handler
      try
      {
        this.runBefores();
        this.runUnprotected();
        goto label_4;
      }
      catch (FailedBefore ex)
      {
      }
      __fault
      {
        this.runAfters();
      }
      this.runAfters();
      return;
label_4:
      this.runAfters();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ClassRoadie.__\u003CcallerID\u003E == null)
        ClassRoadie.__\u003CcallerID\u003E = (CallerID) new ClassRoadie.__\u003CCallerID\u003E();
      return ClassRoadie.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
