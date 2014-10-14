// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.ByteArrayMap
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public class ByteArrayMap : ResizeableArrayObject
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ByteArrayMap()
    {
    }

    public virtual object get(byte b)
    {
      int index = (int) (sbyte) b + 128;
      if (index >= this.array.Length)
        return (object) null;
      else
        return this.array[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void put(byte b, object obj)
    {
      int index = (int) (sbyte) b + 128;
      this.ensureSize(index + 1);
      this.array[index] = obj;
    }

    public virtual void clear()
    {
      for (int index = 0; index < this.array.Length; ++index)
        this.array[index] = (object) null;
    }

    public virtual void remove(char ch)
    {
      int index = (int) ch + 128;
      if (index >= this.array.Length)
        return;
      this.array[index] = (object) null;
    }
  }
}
