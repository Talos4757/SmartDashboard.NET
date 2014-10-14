// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Runner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;

namespace org.junit.runner
{
  [Implements(new string[] {"org.junit.runner.Describable"})]
  public abstract class Runner : Object, Describable
  {
    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Runner()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int testCount()
    {
      return this.getDescription().testCount();
    }

    public abstract void run(RunNotifier rn);

    public abstract Description getDescription();
  }
}
