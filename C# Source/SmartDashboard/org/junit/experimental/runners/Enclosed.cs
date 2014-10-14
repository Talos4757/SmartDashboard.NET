// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.runners.Enclosed
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using org.junit.runners;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.experimental.runners
{
  public class Enclosed : Suite
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;Lorg/junit/runners/model/RunnerBuilder;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Enclosed(Class klass, RunnerBuilder builder)
      : base(builder, klass, klass.getClasses(Enclosed.__\u003CGetCallerID\u003E()))
    {
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Enclosed.__\u003CcallerID\u003E == null)
        Enclosed.__\u003CcallerID\u003E = (CallerID) new Enclosed.__\u003CCallerID\u003E();
      return Enclosed.__\u003CcallerID\u003E;
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
