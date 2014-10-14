// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ErrorCollector
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.util;
using java.util.concurrent;
using org.hamcrest;
using org.junit.@internal.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.rules
{
  public class ErrorCollector : Verifier
  {
    [Signature("Ljava/util/List<Ljava/lang/Throwable;>;")]
    private List errors;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorCollector()
    {
      ErrorCollector errorCollector = this;
      this.errors = (List) new ArrayList();
    }

    [Signature("(Ljava/util/concurrent/Callable<Ljava/lang/Object;>;)Ljava/lang/Object;")]
    [LineNumberTable(new byte[] {(byte) 20, (byte) 124, (byte) 97, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object checkSucceeds(Callable callable)
    {
      object obj;
      Exception error;
      try
      {
        obj = callable.call();
      }
      catch (Exception ex)
      {
        int num = 0;
        error = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return obj;
label_3:
      this.addError(error);
      return (object) null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addError(Exception error)
    {
      this.errors.add((object) error);
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void verify()
    {
      MultipleFailureException.assertEmpty(this.errors);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 5, (byte) 239, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void checkThat(object value, Matcher matcher)
    {
      this.checkSucceeds((Callable) new ErrorCollector\u00241(this, value, matcher));
    }
  }
}
