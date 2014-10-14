// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.Statement
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.junit.runners.model
{
  public abstract class Statement : Object
  {
    [LineNumberTable((ushort) 11)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Statement()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    public abstract void evaluate();
  }
}
