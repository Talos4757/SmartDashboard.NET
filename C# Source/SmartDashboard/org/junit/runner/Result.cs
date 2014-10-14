// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Result
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent.atomic;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner
{
  public class Result : Object
  {
    private AtomicInteger fCount;
    private AtomicInteger fIgnoreCount;
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runner/notification/Failure;>;")]
    private List fFailures;
    private long fRunTime;
    private long fStartTime;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 104, (byte) 107, (byte) 107, (byte) 112, (byte) 232, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Result()
    {
      base.\u002Ector();
      Result result = this;
      this.fCount = new AtomicInteger();
      this.fIgnoreCount = new AtomicInteger();
      this.fFailures = Collections.synchronizedList((List) new ArrayList());
      this.fRunTime = 0L;
    }

    [LineNumberTable((ushort) 102)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RunListener createListener()
    {
      return (RunListener) new Result.Listener(this, (Result.\u0031) null);
    }

    [Signature("()Ljava/util/List<Lorg/junit/runner/notification/Failure;>;")]
    public virtual List getFailures()
    {
      return this.fFailures;
    }

    public virtual long getRunTime()
    {
      return this.fRunTime;
    }

    [LineNumberTable((ushort) 62)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool wasSuccessful()
    {
      return this.getFailureCount() == 0;
    }

    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRunCount()
    {
      return this.fCount.get();
    }

    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getFailureCount()
    {
      return this.fFailures.size();
    }

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIgnoreCount()
    {
      return this.fIgnoreCount.get();
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static long access\u0024002([In] Result obj0, [In] long obj1)
    {
      Result result1 = obj0;
      long num1 = obj1;
      Result result2 = result1;
      long num2 = num1;
      result2.fStartTime = num1;
      return num2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static long access\u0024114([In] Result obj0, [In] long obj1)
    {
      Result result1 = obj0;
      long num1 = result1.fRunTime + obj1;
      Result result2 = result1;
      long num2 = num1;
      result2.fRunTime = num1;
      return num2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static long access\u0024000([In] Result obj0)
    {
      return obj0.fStartTime;
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static AtomicInteger access\u0024200([In] Result obj0)
    {
      return obj0.fCount;
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static List access\u0024300([In] Result obj0)
    {
      return obj0.fFailures;
    }

    [Modifiers]
    [LineNumberTable((ushort) 16)]
    internal static AtomicInteger access\u0024400([In] Result obj0)
    {
      return obj0.fIgnoreCount;
    }

    [InnerClass]
    [EnclosingMethod("org.junit.runner.Result", null, null)]
    [SourceFile("Result.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [SourceFile("Result.java")]
    [Modifiers]
    internal sealed class Listener : RunListener
    {
      [Modifiers]
      internal Result this\u00240 = obj0;

      [Modifiers]
      [LineNumberTable((ushort) 65)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal Listener([In] Result obj0, [In] Result.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 65)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Listener([In] Result obj0)
      {
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 18, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testRunStarted([In] Description obj0)
      {
        Result.access\u0024002(this.this\u00240, System.currentTimeMillis());
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 23, (byte) 102, (byte) 121})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testRunFinished([In] Result obj0)
      {
        Result.access\u0024114(this.this\u00240, System.currentTimeMillis() - Result.access\u0024000(this.this\u00240));
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 29, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testFinished([In] Description obj0)
      {
        Result.access\u0024200(this.this\u00240).getAndIncrement();
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 34, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testFailure([In] Failure obj0)
      {
        Result.access\u0024300(this.this\u00240).add((object) obj0);
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 39, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testIgnored([In] Description obj0)
      {
        Result.access\u0024400(this.this\u00240).getAndIncrement();
      }

      public override void testAssumptionFailure([In] Failure obj0)
      {
      }
    }
  }
}
