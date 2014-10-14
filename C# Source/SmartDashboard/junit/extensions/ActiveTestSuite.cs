// Decompiled with JetBrains decompiler
// Type: junit.extensions.ActiveTestSuite
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using junit.framework;
using System.Runtime.CompilerServices;
using System.Threading;

namespace junit.extensions
{
  public class ActiveTestSuite : TestSuite
  {
    private volatile int fActiveTestDeathCount;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveTestSuite()
    {
    }

    [Signature("(Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveTestSuite(Class theClass)
      : base(theClass)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveTestSuite(string name)
      : base(name)
    {
    }

    [Signature("(Ljava/lang/Class<+Ljunit/framework/TestCase;>;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveTestSuite(Class theClass, string name)
      : base(theClass, name)
    {
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 119, (byte) 104})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void runFinished()
    {
      ++this.fActiveTestDeathCount;
      Thread.MemoryBarrier();
      Object.instancehelper_notifyAll((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 144, (byte) 177, (byte) 2, (byte) 97, (byte) 161})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    internal virtual void waitUntilFinished()
    {
      while (this.fActiveTestDeathCount < this.testCount())
      {
        try
        {
          Object.instancehelper_wait((object) this);
          continue;
        }
        catch (InterruptedException ex)
        {
        }
        break;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 110, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(TestResult result)
    {
      this.fActiveTestDeathCount = 0;
      Thread.MemoryBarrier();
      base.run(result);
      this.waitUntilFinished();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 233, (byte) 76, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void runTest(Test test, TestResult result)
    {
      new ActiveTestSuite\u00241(this, test, result).start();
    }
  }
}
