// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.Task
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.time;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.gantt
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class Task : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1094303785346988894L;
    private string description;
    private TimePeriod duration;
    private Double percentComplete;
    private List subtasks;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Task(string description, TimePeriod duration)
    {
      base.\u002Ector();
      Task task = this;
      if (description == null)
      {
        string str = "Null 'description' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.description = description;
        this.duration = duration;
        this.percentComplete = (Double) null;
        this.subtasks = (List) new ArrayList();
      }
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Task(string description, Date start, Date end)
      : this(description, (TimePeriod) new SimpleTimePeriod(start, end))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Task([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Task obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Task obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual void setPercentComplete(Double percent)
    {
      this.percentComplete = percent;
    }

    public virtual string getDescription()
    {
      return this.description;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDescription(string description)
    {
      if (description == null)
      {
        string str = "Null 'description' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.description = description;
    }

    public virtual TimePeriod getDuration()
    {
      return this.duration;
    }

    public virtual void setDuration(TimePeriod duration)
    {
      this.duration = duration;
    }

    public virtual Double getPercentComplete()
    {
      return this.percentComplete;
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPercentComplete(double percent)
    {
      this.setPercentComplete(new Double(percent));
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 99, (byte) 144, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtask(Task subtask)
    {
      if (subtask == null)
      {
        string str = "Null 'subtask' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.subtasks.add((object) subtask);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSubtask(Task subtask)
    {
      this.subtasks.remove((object) subtask);
    }

    [LineNumberTable((ushort) 198)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubtaskCount()
    {
      return this.subtasks.size();
    }

    [LineNumberTable((ushort) 209)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Task getSubtask(int index)
    {
      return (Task) this.subtasks.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object @object)
    {
      if (@object == this)
        return true;
      if (!(@object is Task))
        return false;
      Task task = (Task) @object;
      return ObjectUtilities.equal((object) this.description, (object) task.description) && ObjectUtilities.equal((object) this.duration, (object) task.duration) && (ObjectUtilities.equal((object) this.percentComplete, (object) task.percentComplete) && ObjectUtilities.equal((object) this.subtasks, (object) task.subtasks));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (Task) base.clone();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
