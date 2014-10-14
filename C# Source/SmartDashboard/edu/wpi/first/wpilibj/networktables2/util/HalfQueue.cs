// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.HalfQueue
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.util
{
  [SourceFile(null)]
  public class HalfQueue : Object
  {
    internal object[] __\u003C\u003Earray;
    private int size;

    [Modifiers]
    public object[] array
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Earray;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Earray = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HalfQueue(int i)
    {
      base.\u002Ector();
      HalfQueue halfQueue = this;
      this.size = 0;
      this.__\u003C\u003Earray = new object[i];
    }

    public virtual void queue(object obj)
    {
      object[] objArray = this.__\u003C\u003Earray;
      HalfQueue halfQueue1 = this;
      int num = halfQueue1.size;
      HalfQueue halfQueue2 = halfQueue1;
      int index = num;
      halfQueue2.size = num + 1;
      object obj1 = obj;
      objArray[index] = obj1;
    }

    public virtual bool isFull()
    {
      return this.size == this.__\u003C\u003Earray.Length;
    }

    public virtual int size()
    {
      return this.size;
    }

    public virtual void clear()
    {
      this.size = 0;
    }
  }
}
