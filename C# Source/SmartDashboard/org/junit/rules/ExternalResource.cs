// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ExternalResource
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.rules
{
  [Implements(new string[] {"org.junit.rules.MethodRule"})]
  public abstract class ExternalResource : Object, MethodRule
  {
    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExternalResource()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    protected internal virtual void before()
    {
    }

    protected internal virtual void after()
    {
    }

    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Statement apply(Statement @base, FrameworkMethod method, object target)
    {
      return (Statement) new ExternalResource\u00241(this, @base);
    }
  }
}
