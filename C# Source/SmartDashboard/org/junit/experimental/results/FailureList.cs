// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.results.FailureList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.results
{
  [Modifiers]
  internal sealed class FailureList : Object
  {
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runner/notification/Failure;>;")]
    private List failures;

    [Signature("(Ljava/util/List<Lorg/junit/runner/notification/Failure;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FailureList([In] List obj0)
    {
      base.\u002Ector();
      FailureList failureList = this;
      this.failures = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 102, (byte) 103, (byte) 159, (byte) 1, (byte) 188, (byte) 2, (byte) 97, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result result()
    {
      Result result = new Result();
      RunListener listener = result.createListener();
      Iterator iterator = this.failures.iterator();
      while (iterator.hasNext())
      {
        Failure failure = (Failure) iterator.next();
        try
        {
          listener.testFailure(failure);
          continue;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
        string str = "I can't believe this happened";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      return result;
    }
  }
}
