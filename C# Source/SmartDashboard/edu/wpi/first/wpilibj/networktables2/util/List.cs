// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.util.List
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
  public class List : ResizeableArrayObject
  {
    protected internal int size;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List()
    {
      List list = this;
      this.size = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List(int i)
      : base(i)
    {
      List list = this;
      this.size = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(object obj)
    {
      this.ensureSize(this.size + 1);
      object[] objArray = this.array;
      List list1 = this;
      int num = list1.size;
      List list2 = list1;
      int index = num;
      list2.size = num + 1;
      object obj1 = obj;
      objArray[index] = obj1;
    }

    public virtual int size()
    {
      return this.size;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object get(int i)
    {
      if (i >= 0 && i < this.size)
        return this.array[i];
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IndexOutOfBoundsException();
    }

    public virtual void clear()
    {
      this.size = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool contains(object obj)
    {
      for (int index = 0; index < this.size; ++index)
      {
        object obj1 = this.array[index];
        if (obj == null)
        {
          if (obj1 != null)
            continue;
        }
        else if (!Object.instancehelper_equals(obj, obj1))
          continue;
        return true;
      }
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool remove(object obj)
    {
      for (int i = 0; i < this.size; ++i)
      {
        object obj1 = this.array[i];
        if (obj == null)
        {
          if (obj1 != null)
            continue;
        }
        else if (!Object.instancehelper_equals(obj, obj1))
          continue;
        this.remove(i);
        return true;
      }
      return false;
    }

    [Throws(new string[] {"java.lang.IndexOutOfBoundsException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(int i)
    {
      if (i < 0 || i >= this.size)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException();
      }
      else
      {
        if (i < this.size - 1)
          ByteCodeHelper.arraycopy((object) this.array, i + 1, (object) this.array, i, this.size - i - 1);
        --this.size;
      }
    }

    public virtual bool isEmpty()
    {
      return this.size == 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void set(int i, object obj)
    {
      if (i < 0 || i >= this.size)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException();
      }
      else
        this.array[i] = obj;
    }
  }
}
