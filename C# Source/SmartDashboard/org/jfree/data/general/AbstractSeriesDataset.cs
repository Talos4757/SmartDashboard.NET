// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.AbstractSeriesDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.SeriesDataset", "org.jfree.data.general.SeriesChangeListener", "java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractSeriesDataset : AbstractDataset, SeriesDataset, Dataset, SeriesChangeListener, EventListener, Serializable.__Interface
  {
    private const long serialVersionUID = -6074996219705033171L;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractSeriesDataset()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractSeriesDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractSeriesDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public abstract int getSeriesCount();

    public abstract IComparable getSeriesKey(int i);

    [LineNumberTable(new byte[] {(byte) 45, (byte) 103, (byte) 102, (byte) 111, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(IComparable seriesKey)
    {
      int seriesCount = this.getSeriesCount();
      for (int i = 0; i < seriesCount; ++i)
      {
        if (Object.instancehelper_equals((object) this.getSeriesKey(i), (object) seriesKey))
          return i;
      }
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void seriesChanged(SeriesChangeEvent @event)
    {
      this.fireDatasetChanged();
    }
  }
}
