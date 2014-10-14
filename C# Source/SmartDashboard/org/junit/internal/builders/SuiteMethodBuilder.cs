// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.SuiteMethodBuilder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using org.junit.@internal.builders;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class SuiteMethodBuilder : RunnerBuilder
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 10)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SuiteMethodBuilder()
    {
    }

    [Signature("(Ljava/lang/Class<*>;)Z")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 191, (byte) 3, (byte) 2, (byte) 97, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasSuiteMethod(Class testClass)
    {
      try
      {
        testClass.getMethod("suite", new Class[0], SuiteMethodBuilder.__\u003CGetCallerID\u003E());
        goto label_3;
      }
      catch (NoSuchMethodException ex)
      {
      }
      return false;
label_3:
      return true;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class each)
    {
      if (!this.hasSuiteMethod(each))
        return (Runner) null;
      return (Runner) new SuiteMethod(each);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (SuiteMethodBuilder.__\u003CcallerID\u003E == null)
        SuiteMethodBuilder.__\u003CcallerID\u003E = (CallerID) new SuiteMethodBuilder.__\u003CCallerID\u003E();
      return SuiteMethodBuilder.__\u003CcallerID\u003E;
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
