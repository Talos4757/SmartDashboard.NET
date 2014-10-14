// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.ParallelComputer$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental
{
  [InnerClass]
  [Implements(new string[] {"org.junit.runners.model.RunnerScheduler"})]
  [EnclosingMethod("org.junit.experimental.ParallelComputer", "parallelize", "(Lorg.junit.runner.Runner;)Lorg.junit.runner.Runner;")]
  [SourceFile("ParallelComputer.java")]
  [Modifiers]
  internal sealed class ParallelComputer\u00241 : Object, RunnerScheduler
  {
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/util/concurrent/Future<Ljava/lang/Object;>;>;")]
    private List fResults;
    [Modifiers]
    private ExecutorService fService;

    [LineNumberTable(new byte[] {(byte) 2, (byte) 232, (byte) 50, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParallelComputer\u00241()
    {
      base.\u002Ector();
      ParallelComputer\u00241 parallelComputer1 = this;
      this.fResults = (List) new ArrayList();
      this.fService = Executors.newCachedThreadPool();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 254, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void schedule([In] Runnable obj0)
    {
      this.fResults.add((object) this.fService.submit((Callable) new ParallelComputer\u00241\u00241(this, obj0)));
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 159, (byte) 1, (byte) 190, (byte) 2, (byte) 97, (byte) 102, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void finished()
    {
      Iterator iterator = this.fResults.iterator();
      while (iterator.hasNext())
      {
        Future future = (Future) iterator.next();
        Exception exception;
        try
        {
          future.get();
          continue;
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            exception = (Exception) m0;
        }
        Throwable.instancehelper_printStackTrace((Exception) exception);
      }
    }
  }
}
