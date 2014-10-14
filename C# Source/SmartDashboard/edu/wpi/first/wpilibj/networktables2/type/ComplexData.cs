// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.ComplexData
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class ComplexData : Object
  {
    [Modifiers]
    private ComplexEntryType type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComplexData(ComplexEntryType cet)
    {
      base.\u002Ector();
      ComplexData complexData = this;
      this.type = cet;
    }

    public virtual ComplexEntryType getType()
    {
      return this.type;
    }
  }
}
