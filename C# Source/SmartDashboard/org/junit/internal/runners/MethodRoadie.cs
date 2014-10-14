// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.MethodRoadie
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
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  public class MethodRoadie : Object
  {
    [Modifiers]
    private object fTest;
    [Modifiers]
    private RunNotifier fNotifier;
    [Modifiers]
    private Description fDescription;
    private TestMethod fTestMethod;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MethodRoadie(object test, TestMethod method, RunNotifier notifier, Description description)
    {
      base.\u002Ector();
      MethodRoadie methodRoadie = this;
      this.fTest = test;
      this.fNotifier = notifier;
      this.fDescription = description;
      this.fTestMethod = method;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 109, (byte) 113, (byte) 129, (byte) 145, (byte) 108, (byte) 101, (byte) 137, (byte) 138, (byte) 84, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      if (this.fTestMethod.isIgnored())
      {
        this.fNotifier.fireTestIgnored(this.fDescription);
      }
      else
      {
        this.fNotifier.fireTestStarted(this.fDescription);
        try
        {
          long timeout = this.fTestMethod.getTimeout();
          if (timeout > 0L)
            this.runWithTimeout(timeout);
          else
            this.runTest();
        }
        finally
        {
          this.fNotifier.fireTestFinished(this.fDescription);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 113, (byte) 109, (byte) 255, (byte) 54, (byte) 78, (byte) 229, (byte) 51, (byte) 97, (byte) 103, (byte) 104, (byte) 97, (byte) 109, (byte) 105, (byte) 110, (byte) 159, (byte) 48, (byte) 206, (byte) 2, (byte) 98, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runTestMethod()
    {
      InvocationTargetException invocationTargetException;
      Exception e;
      try
      {
        try
        {
          this.fTestMethod.invoke(this.fTest);
          if (!this.fTestMethod.expectsException())
            return;
          this.addFailure((Exception) new AssertionError((object) new StringBuilder().append("Expected exception: ").append(this.fTestMethod.getExpectedException().getName()).toString()));
          return;
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
        e = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_5;
      }
      Exception targetException = invocationTargetException.getTargetException();
      if (targetException is AssumptionViolatedException)
        return;
      if (!this.fTestMethod.expectsException())
      {
        this.addFailure(targetException);
        return;
      }
      else
      {
        if (!this.fTestMethod.isUnexpected(targetException))
          return;
        this.addFailure((Exception) new Exception(new StringBuilder().append("Unexpected exception, expected<").append(this.fTestMethod.getExpectedException().getName()).append("> but was<").append(Object.instancehelper_getClass((object) targetException).getName()).append(">").toString(), targetException));
        return;
      }
label_5:
      this.addFailure(e);
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addFailure(Exception e)
    {
      this.fNotifier.fireTestFailure(new Failure(this.fDescription, e));
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 239, (byte) 89})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runWithTimeout([In] long obj0)
    {
      this.runBeforesThenTestThenAfters((Runnable) new MethodRoadie\u00241(this, obj0));
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 238, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runTest()
    {
      this.runBeforesThenTestThenAfters((Runnable) new MethodRoadie\u00242(this));
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 102, (byte) 248, (byte) 69, (byte) 79, (byte) 102, (byte) 226, (byte) 59, (byte) 193, (byte) 102, (byte) 228, (byte) 60, (byte) 97, (byte) 144, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runBeforesThenTestThenAfters(Runnable test)
    {
      // ISSUE: fault handler
      try
      {
        try
        {
          this.runBefores();
          test.run();
          goto label_7;
        }
        catch (FailedBefore ex)
        {
        }
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_6;
      }
      __fault
      {
        this.runAfters();
      }
      this.runAfters();
      return;
label_6:
      // ISSUE: fault handler
      try
      {
        string str = "test should never throw an exception to this level";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      __fault
      {
        this.runAfters();
      }
label_7:
      this.runAfters();
    }

    [Throws(new string[] {"org.junit.internal.runners.FailedBefore"})]
    [LineNumberTable(new byte[] {(byte) 77, (byte) 108, (byte) 123, (byte) 191, (byte) 30, (byte) 10, (byte) 98, (byte) 255, (byte) 1, (byte) 71, (byte) 226, (byte) 59, (byte) 97, (byte) 107, (byte) 98, (byte) 104, (byte) 139})]
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
            Iterator iterator = this.fTestMethod.getBefores().iterator();
            while (iterator.hasNext())
              ((Method) iterator.next()).invoke(this.fTest, new object[0], MethodRoadie.__\u003CGetCallerID\u003E());
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
      Exception e = exception2;
      goto label_17;
label_7:
      local = null;
      goto label_16;
label_8:
      e = exception1;
      goto label_17;
label_16:
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new FailedBefore();
label_17:
      this.addFailure(e);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new FailedBefore();
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 108, (byte) 158, (byte) 255, (byte) 25, (byte) 69, (byte) 226, (byte) 60, (byte) 98, (byte) 173, (byte) 2, (byte) 98, (byte) 104, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runAfters()
    {
      Iterator iterator = this.fTestMethod.getAfters().iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        InvocationTargetException invocationTargetException;
        Exception e;
        try
        {
          try
          {
            method.invoke(this.fTest, new object[0], MethodRoadie.__\u003CGetCallerID\u003E());
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
          e = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          goto label_7;
        }
        this.addFailure(invocationTargetException.getTargetException());
        continue;
label_7:
        this.addFailure(e);
      }
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (MethodRoadie.__\u003CcallerID\u003E == null)
        MethodRoadie.__\u003CcallerID\u003E = (CallerID) new MethodRoadie.__\u003CCallerID\u003E();
      return MethodRoadie.__\u003CcallerID\u003E;
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
