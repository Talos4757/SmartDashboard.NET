// Decompiled with JetBrains decompiler
// Type: org.junit.rules.Verifier
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
  public class Verifier : Object, MethodRule
  {
    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Verifier()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Statement apply(Statement @base, FrameworkMethod method, object target)
    {
      return (Statement) new Verifier\u00241(this, @base);
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    protected internal virtual void verify()
    {
    }
  }
}
