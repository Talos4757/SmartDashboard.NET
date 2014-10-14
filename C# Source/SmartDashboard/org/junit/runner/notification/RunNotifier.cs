// Decompiled with JetBrains decompiler
// Type: org.junit.runner.notification.RunNotifier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit.runner;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace org.junit.runner.notification
{
  public class RunNotifier : Object
  {
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runner/notification/RunListener;>;")]
    private List fListeners;
    private bool fPleaseStop;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 104, (byte) 144, (byte) 231, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RunNotifier()
    {
      base.\u002Ector();
      RunNotifier runNotifier = this;
      this.fListeners = Collections.synchronizedList((List) new ArrayList());
      this.fPleaseStop = false;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addListener(RunListener listener)
    {
      this.fListeners.add((object) listener);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestIgnored(Description description)
    {
      new RunNotifier\u00246(this, description).run();
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestFailure(Failure failure)
    {
      new RunNotifier\u00244(this, failure).run();
    }

    [Throws(new string[] {"org.junit.runner.notification.StoppedByUserException"})]
    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 107, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestStarted(Description description)
    {
      if (this.fPleaseStop)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new StoppedByUserException();
      }
      else
        new RunNotifier\u00243(this, description).run();
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestFinished(Description description)
    {
      new RunNotifier\u00247(this, description).run();
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestAssumptionFailed(Failure failure)
    {
      new RunNotifier\u00245(this, failure).run();
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addFirstListener(RunListener listener)
    {
      this.fListeners.add(0, (object) listener);
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestRunStarted(Description description)
    {
      new RunNotifier\u00241(this, description).run();
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 238, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTestRunFinished(Result result)
    {
      new RunNotifier\u00242(this, result).run();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeListener(RunListener listener)
    {
      this.fListeners.remove((object) listener);
    }

    [Modifiers]
    [LineNumberTable((ushort) 19)]
    internal static List access\u0024000([In] RunNotifier obj0)
    {
      return obj0.fListeners;
    }

    public virtual void pleaseStop()
    {
      this.fPleaseStop = true;
    }

    [InnerClass]
    [SourceFile("RunNotifier.java")]
    internal abstract class SafeNotifier : Object
    {
      [Modifiers]
      internal RunNotifier this\u00240;

      [LineNumberTable((ushort) 36)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private SafeNotifier([In] RunNotifier obj0)
      {
        base.\u002Ector();
      }

      [Modifiers]
      [LineNumberTable((ushort) 36)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal SafeNotifier([In] RunNotifier obj0, [In] RunNotifier\u00241 obj1)
        : this(obj0)
      {
      }

      [Throws(new string[] {"java.lang.Exception"})]
      protected internal abstract void notifyListener([In] RunListener obj0);

      [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 114, (byte) 159, (byte) 7, (byte) 223, (byte) 6, (byte) 242, (byte) 61, (byte) 98, (byte) 102, (byte) 119, (byte) 112, (byte) 117})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal virtual void run()
      {
        List list;
        Monitor.Enter((object) (list = RunNotifier.access\u0024000(this.this\u00240)));
        Iterator iterator;
        // ISSUE: fault handler
        try
        {
          iterator = RunNotifier.access\u0024000(this.this\u00240).iterator();
        }
        __fault
        {
          Monitor.Exit((object) list);
        }
        while (true)
        {
          Exception exception1;
          // ISSUE: fault handler
          try
          {
            if (iterator.hasNext())
            {
              try
              {
                this.notifyListener((RunListener) iterator.next());
                continue;
              }
              catch (Exception ex)
              {
                int num = 0;
                M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
                if (m0 == null)
                  throw;
                else
                  exception1 = (Exception) m0;
              }
            }
            else
              break;
          }
          __fault
          {
            Monitor.Exit((object) list);
          }
          Exception exception2 = exception1;
          // ISSUE: fault handler
          try
          {
            Exception exception3 = exception2;
            iterator.remove();
            this.this\u00240.fireTestFailure(new Failure(Description.__\u003C\u003ETEST_MECHANISM, (Exception) exception3));
          }
          __fault
          {
            Monitor.Exit((object) list);
          }
        }
        // ISSUE: fault handler
        try
        {
          Monitor.Exit((object) list);
        }
        __fault
        {
          Monitor.Exit((object) list);
        }
      }
    }
  }
}
