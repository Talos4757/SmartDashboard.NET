// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.LegendItemEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class LegendItemEntity : ChartEntity, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -7435683933545666702L;
    private Dataset dataset;
    private IComparable seriesKey;
    private int seriesIndex;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItemEntity(Shape area)
      : base(area)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendItemEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LegendItemEntity obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LegendItemEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Dataset getDataset()
    {
      return this.dataset;
    }

    public virtual void setDataset(Dataset dataset)
    {
      this.dataset = dataset;
    }

    public virtual IComparable getSeriesKey()
    {
      return this.seriesKey;
    }

    public virtual void setSeriesKey(IComparable key)
    {
      this.seriesKey = key;
    }

    [Obsolete]
    public virtual int getSeriesIndex()
    {
      return this.seriesIndex;
    }

    [Obsolete]
    public virtual void setSeriesIndex(int index)
    {
      this.seriesIndex = index;
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LegendItemEntity))
        return false;
      LegendItemEntity legendItemEntity = (LegendItemEntity) obj;
      if (!ObjectUtilities.equal((object) this.seriesKey, (object) legendItemEntity.seriesKey) || this.seriesIndex != legendItemEntity.seriesIndex || !ObjectUtilities.equal((object) this.dataset, (object) legendItemEntity.dataset))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 202)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable((ushort) 212)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("LegendItemEntity: seriesKey=").append((object) this.seriesKey).append(", dataset=").append((object) this.dataset).toString();
    }
  }
}
