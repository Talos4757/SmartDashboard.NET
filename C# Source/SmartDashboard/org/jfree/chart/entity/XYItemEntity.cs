// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.XYItemEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Serializable]
  public class XYItemEntity : ChartEntity
  {
    private const long serialVersionUID = -3870862224880283771L;
    [NonSerialized]
    private XYDataset dataset;
    private int series;
    private int item;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 109, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYItemEntity(Shape area, XYDataset dataset, int series, int item, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      XYItemEntity xyItemEntity = this;
      this.dataset = dataset;
      this.series = series;
      this.item = item;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYItemEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual int getSeriesIndex()
    {
      return this.series;
    }

    public virtual int getItem()
    {
      return this.item;
    }

    public virtual XYDataset getDataset()
    {
      return this.dataset;
    }

    public virtual void setDataset(XYDataset dataset)
    {
      this.dataset = dataset;
    }

    public virtual void setSeriesIndex(int series)
    {
      this.series = series;
    }

    public virtual void setItem(int item)
    {
      this.item = item;
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 100, (byte) 130, (byte) 113, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYItemEntity) || !base.equals(obj))
        return false;
      XYItemEntity xyItemEntity = (XYItemEntity) obj;
      return this.series == xyItemEntity.series && this.item == xyItemEntity.item;
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("XYItemEntity: series = ").append(this.getSeriesIndex()).append(", item = ").append(this.getItem()).append(", dataset = ").append((object) this.getDataset()).toString();
    }
  }
}
