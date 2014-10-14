// Decompiled with JetBrains decompiler
// Type: org.junit.rules.TestWatchman
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.rules
{
  [Implements(new string[] {"org.junit.rules.MethodRule"})]
  public class TestWatchman : Object, MethodRule
  {
    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestWatchman()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Statement apply(Statement @base, FrameworkMethod method, object target)
    {
      return (Statement) new TestWatchman\u00241(this, method, @base);
    }

    public virtual void succeeded(FrameworkMethod method)
    {
    }

    public virtual void failed(Exception e, FrameworkMethod method)
    {
    }

    public virtual void starting(FrameworkMethod method)
    {
    }

    public virtual void finished(FrameworkMethod method)
    {
    }
  }
}
