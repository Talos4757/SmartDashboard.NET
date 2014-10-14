// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.model.ReflectiveCallable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.model
{
  public abstract class ReflectiveCallable : Object
  {
    [LineNumberTable((ushort) 12)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReflectiveCallable()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 124, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object run()
    {
      object obj;
      InvocationTargetException invocationTargetException;
      try
      {
        obj = this.runReflectiveCall();
      }
      catch (InvocationTargetException ex)
      {
        int num = 1;
        invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return obj;
label_3:
      throw Throwable.__\u003Cunmap\u003E(invocationTargetException.getTargetException());
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    protected internal abstract object runReflectiveCall();
  }
}
