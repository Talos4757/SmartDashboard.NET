// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.ResizeableArrayObject
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public class ResizeableArrayObject : Object
  {
    private const int GROW_FACTOR = 3;
    protected internal object[] array;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ResizeableArrayObject(int i)
    {
      base.\u002Ector();
      ResizeableArrayObject resizeableArrayObject = this;
      this.array = new object[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ResizeableArrayObject()
      : this(10)
    {
    }

    protected internal virtual int arraySize()
    {
      return this.array.Length;
    }

    protected internal virtual void ensureSize(int i)
    {
      if (i <= this.array.Length)
        return;
      int length = this.array.Length;
      while (i > length)
        length *= 3;
      object[] objArray = new object[length];
      ByteCodeHelper.arraycopy((object) this.array, 0, (object) objArray, 0, this.array.Length);
      this.array = objArray;
    }
  }
}
