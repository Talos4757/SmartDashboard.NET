// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.TaskSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.gantt
{
  [Serializable]
  public class TaskSeries : Series
  {
    private List tasks;

    [LineNumberTable(new byte[] {(byte) 21, (byte) 105, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TaskSeries(string name)
      : base((IComparable) name)
    {
      TaskSeries taskSeries = this;
      this.tasks = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TaskSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 99, (byte) 144, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Task task)
    {
      if (task == null)
      {
        string str = "Null 'task' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tasks.add((object) task);
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(Task task)
    {
      this.tasks.remove((object) task);
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAll()
    {
      this.tasks.clear();
      this.fireSeriesChanged();
    }

    [LineNumberTable((ushort) 118)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.tasks.size();
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Task get(int index)
    {
      return (Task) this.tasks.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 98, (byte) 108, (byte) 102, (byte) 114, (byte) 110, (byte) 98, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Task get(string description)
    {
      Task task1 = (Task) null;
      int num = this.tasks.size();
      for (int index = 0; index < num; ++index)
      {
        Task task2 = (Task) this.tasks.get(index);
        if (String.instancehelper_equals(task2.getDescription(), (object) description))
        {
          task1 = task2;
          break;
        }
      }
      return task1;
    }

    [LineNumberTable((ushort) 158)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getTasks()
    {
      return Collections.unmodifiableList(this.tasks);
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is TaskSeries && base.equals(obj) && Object.instancehelper_equals((object) this.tasks, (object) ((TaskSeries) obj).tasks);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      TaskSeries taskSeries = (TaskSeries) base.clone();
      taskSeries.tasks = (List) ObjectUtilities.deepClone((Collection) this.tasks);
      return (object) taskSeries;
    }
  }
}
