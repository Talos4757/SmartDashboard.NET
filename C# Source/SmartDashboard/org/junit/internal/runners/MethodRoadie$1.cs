// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.MethodRoadie$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using org.junit.@internal.runners;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("org.junit.internal.runners.MethodRoadie", "runWithTimeout", "(J)V")]
  [SourceFile("MethodRoadie.java")]
  [Modifiers]
  internal sealed class MethodRoadie\u00241 : Object, Runnable
  {
    [Modifiers]
    internal long val\u0024timeout;
    [Modifiers]
    internal MethodRoadie this\u00240;

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MethodRoadie\u00241([In] MethodRoadie obj0, [In] long obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 102, (byte) 231, (byte) 70, (byte) 104, (byte) 134, (byte) 146, (byte) 99, (byte) 103, (byte) 255, (byte) 13, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 191, (byte) 15, (byte) 2, (byte) 98, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ExecutorService executorService = Executors.newSingleThreadExecutor();
      MethodRoadie\u00241\u00241 methodRoadie11 = new MethodRoadie\u00241\u00241(this);
      Future future = executorService.submit((Callable) methodRoadie11);
      executorService.shutdown();
      Exception exception1;
      try
      {
        try
        {
          if (!executorService.awaitTermination(this.val\u0024timeout, (TimeUnit) TimeUnit.MILLISECONDS))
            executorService.shutdownNow();
          future.get(0L, (TimeUnit) TimeUnit.MILLISECONDS);
          return;
        }
        catch (TimeoutException ex)
        {
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception1 = (Exception) m0;
          goto label_9;
        }
      }
      MethodRoadie methodRoadie = this.this\u00240;
      string str = "test timed out after %d milliseconds";
      object[] objArray = new object[1];
      int index = 0;
      Long @long = Long.valueOf(this.val\u0024timeout);
      objArray[index] = (object) @long;
      Exception exception2 = new Exception(String.format(str, objArray));
      methodRoadie.addFailure((Exception) exception2);
      return;
label_9:
      this.this\u00240.addFailure((Exception) exception1);
    }
  }
}
