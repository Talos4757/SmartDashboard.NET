// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.ComplexEntryType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public abstract class ComplexEntryType : NetworkTableEntryType
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ComplexEntryType(byte b, string str)
      : base(b, str)
    {
    }

    public abstract void exportValue(string str, object obj1, object obj2);

    public abstract object internalizeValue(string str, object obj1, object obj2);
  }
}
