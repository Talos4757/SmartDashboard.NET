// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.ArrayData
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class ArrayData : ComplexData
  {
    [Modifiers]
    private ArrayEntryType type;
    private object[] data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayData(ArrayEntryType aet)
      : base((ComplexEntryType) aet)
    {
      ArrayData arrayData = this;
      this.data = new object[0];
      this.type = aet;
    }

    public virtual int size()
    {
      return this.data.Length;
    }

    public virtual void setSize(int i)
    {
      if (i == this.data.Length)
        return;
      object[] objArray = new object[i];
      if (i < this.data.Length)
      {
        ByteCodeHelper.arraycopy((object) this.data, 0, (object) objArray, 0, i);
      }
      else
      {
        ByteCodeHelper.arraycopy((object) this.data, 0, (object) objArray, 0, this.data.Length);
        for (int length = this.data.Length; length < objArray.Length; ++length)
          objArray[length] = (object) null;
      }
      this.data = objArray;
    }

    protected internal virtual object getAsObject(int i)
    {
      return this.data[i];
    }

    protected internal virtual void _set(int i, object obj)
    {
      this.data[i] = obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void _add(object obj)
    {
      this.setSize(this.size() + 1);
      this.data[this.size() - 1] = obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(int i)
    {
      if (i < 0 || i >= this.size())
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException();
      }
      else
      {
        if (i < this.size() - 1)
          ByteCodeHelper.arraycopy((object) this.data, i + 1, (object) this.data, i, this.size() - i - 1);
        this.setSize(this.size() - 1);
      }
    }

    internal virtual object[] getDataArray()
    {
      return this.data;
    }
  }
}
