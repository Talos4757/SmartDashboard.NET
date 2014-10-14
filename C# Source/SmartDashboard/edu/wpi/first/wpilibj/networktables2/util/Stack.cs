// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.Stack
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public class Stack : List
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Stack()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void push(object obj)
    {
      this.add(obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object pop()
    {
      if (this.size == 0)
        return (object) null;
      object obj = this.get(this.size - 1);
      this.remove(this.size - 1);
      return obj;
    }
  }
}
