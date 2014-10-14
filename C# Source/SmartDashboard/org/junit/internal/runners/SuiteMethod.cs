// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.SuiteMethod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using junit.framework;
using org.junit.@internal.runners;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners
{
  public class SuiteMethod : JUnit38ClassRunner
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SuiteMethod(Class klass)
      : base(SuiteMethod.testFromSuiteMethod(klass))
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Ljunit/framework/Test;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 98, (byte) 130, (byte) 119, (byte) 109, (byte) 159, (byte) 11, (byte) 191, (byte) 11, (byte) 2, (byte) 97, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Test testFromSuiteMethod(Class klass)
    {
      InvocationTargetException invocationTargetException;
      try
      {
        Method method = klass.getMethod("suite", new Class[0], SuiteMethod.__\u003CGetCallerID\u003E());
        if (Modifier.isStatic(method.getModifiers()))
          return (Test) method.invoke((object) null, new object[0], SuiteMethod.__\u003CGetCallerID\u003E());
        string str = new StringBuilder().append(klass.getName()).append(".suite() must be static").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      catch (InvocationTargetException ex)
      {
        int num = 1;
        invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      throw Throwable.__\u003Cunmap\u003E(invocationTargetException.getCause());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (SuiteMethod.__\u003CcallerID\u003E == null)
        SuiteMethod.__\u003CcallerID\u003E = (CallerID) new SuiteMethod.__\u003CCallerID\u003E();
      return SuiteMethod.__\u003CcallerID\u003E;
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
