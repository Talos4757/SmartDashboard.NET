// Decompiled with JetBrains decompiler
// Type: junit.framework.TestResult
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace junit.framework
{
  public class TestResult : Object
  {
    [Signature("Ljava/util/List<Ljunit/framework/TestFailure;>;")]
    protected internal List fFailures;
    [Signature("Ljava/util/List<Ljunit/framework/TestFailure;>;")]
    protected internal List fErrors;
    [Signature("Ljava/util/List<Ljunit/framework/TestListener;>;")]
    protected internal List fListeners;
    protected internal int fRunTests;
    private bool fStop;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestResult()
    {
      base.\u002Ector();
      TestResult testResult = this;
      this.fFailures = (List) new ArrayList();
      this.fErrors = (List) new ArrayList();
      this.fListeners = (List) new ArrayList();
      this.fRunTests = 0;
      this.fStop = false;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual bool shouldStop()
    {
      return this.fStop;
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 255, (byte) 22, (byte) 74, (byte) 226, (byte) 56, (byte) 97, (byte) 232, (byte) 71, (byte) 226, (byte) 59, (byte) 98, (byte) 136, (byte) 98, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runProtected(Test test, Protectable p)
    {
      AssertionFailedError assertionFailedError;
      ThreadDeath threadDeath;
      Exception exception;
      try
      {
        try
        {
          try
          {
            p.protect();
            return;
          }
          catch (AssertionFailedError ex)
          {
            int num = 1;
            assertionFailedError = (AssertionFailedError) ByteCodeHelper.MapException<AssertionFailedError>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<ThreadDeath>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
          {
            throw;
          }
          else
          {
            threadDeath = (ThreadDeath) m0;
            goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        exception = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_8;
      }
      AssertionFailedError t1 = assertionFailedError;
      this.addFailure(test, t1);
      return;
label_7:
      throw Throwable.__\u003Cunmap\u003E((Exception) threadDeath);
label_8:
      Exception t2 = exception;
      this.addError(test, t2);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 115, (byte) 127, (byte) 1, (byte) 106})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addError(Test test, Exception t)
    {
      this.fErrors.add((object) new TestFailure(test, t));
      Iterator iterator = this.cloneListeners().iterator();
      while (iterator.hasNext())
        ((TestListener) iterator.next()).addError(test, t);
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 127, (byte) 1, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endTest(Test test)
    {
      Iterator iterator = this.cloneListeners().iterator();
      while (iterator.hasNext())
        ((TestListener) iterator.next()).endTest(test);
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 103, (byte) 104, (byte) 110, (byte) 111, (byte) 127, (byte) 1, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startTest(Test test)
    {
      int num = test.countTestCases();
      lock (this)
        this.fRunTests += num;
      Iterator iterator = this.cloneListeners().iterator();
      while (iterator.hasNext())
        ((TestListener) iterator.next()).startTest(test);
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 103, (byte) 232, (byte) 69, (byte) 136, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void run(TestCase test)
    {
      this.startTest((Test) test);
      TestResult\u00241 testResult1 = new TestResult\u00241(this, test);
      this.runProtected((Test) test, (Protectable) testResult1);
      this.endTest((Test) test);
    }

    [Signature("()Ljava/util/List<Ljunit/framework/TestListener;>;")]
    [LineNumberTable(new byte[] {(byte) 15, (byte) 102, (byte) 109})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    private List cloneListeners()
    {
      ArrayList arrayList = new ArrayList();
      ((List) arrayList).addAll((Collection) this.fListeners);
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 115, (byte) 127, (byte) 1, (byte) 106})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addFailure(Test test, AssertionFailedError t)
    {
      this.fFailures.add((object) new TestFailure(test, (Exception) t));
      Iterator iterator = this.cloneListeners().iterator();
      while (iterator.hasNext())
        ((TestListener) iterator.next()).addFailure(test, t);
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual int failureCount()
    {
      return this.fFailures.size();
    }

    [LineNumberTable((ushort) 80)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual int errorCount()
    {
      return this.fErrors.size();
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 109})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addListener(TestListener listener)
    {
      this.fListeners.add((object) listener);
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 109})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void removeListener(TestListener listener)
    {
      this.fListeners.remove((object) listener);
    }

    [Signature("()Ljava/util/Enumeration<Ljunit/framework/TestFailure;>;")]
    [LineNumberTable((ushort) 86)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual Enumeration errors()
    {
      return Collections.enumeration((Collection) this.fErrors);
    }

    [Signature("()Ljava/util/Enumeration<Ljunit/framework/TestFailure;>;")]
    [LineNumberTable((ushort) 100)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual Enumeration failures()
    {
      return Collections.enumeration((Collection) this.fFailures);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual int runCount()
    {
      return this.fRunTests;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual void stop()
    {
      this.fStop = true;
    }

    [LineNumberTable((ushort) 167)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual bool wasSuccessful()
    {
      return this.failureCount() == 0 && this.errorCount() == 0;
    }
  }
}
