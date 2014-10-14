// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.Set
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public class Set : List
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Set()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void add(object obj)
    {
      if (this.contains(obj))
        return;
      base.add(obj);
    }
  }
}
