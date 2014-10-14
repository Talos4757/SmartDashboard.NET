// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.LegendItemBlockContainer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using org.jfree.chart.block;
using org.jfree.chart.entity;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Serializable]
  public class LegendItemBlockContainer : BlockContainer
  {
    private Dataset dataset;
    private IComparable seriesKey;
    private int datasetIndex;
    private int series;
    private string toolTipText;
    private string urlText;

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 53, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItemBlockContainer(Arrangement arrangement, int datasetIndex, int series)
      : base(arrangement)
    {
      LegendItemBlockContainer itemBlockContainer = this;
      this.datasetIndex = datasetIndex;
      this.series = series;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItemBlockContainer(Arrangement arrangement, Dataset dataset, IComparable seriesKey)
      : base(arrangement)
    {
      LegendItemBlockContainer itemBlockContainer = this;
      this.dataset = dataset;
      this.seriesKey = seriesKey;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendItemBlockContainer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    public virtual string getURLText()
    {
      return this.urlText;
    }

    public virtual Dataset getDataset()
    {
      return this.dataset;
    }

    public virtual IComparable getSeriesKey()
    {
      return this.seriesKey;
    }

    [Obsolete]
    public virtual int getDatasetIndex()
    {
      return this.datasetIndex;
    }

    public virtual int getSeriesIndex()
    {
      return this.series;
    }

    public virtual void setToolTipText(string text)
    {
      this.toolTipText = text;
    }

    public virtual void setURLText(string text)
    {
      this.urlText = text;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 106, (byte) 98, (byte) 102, (byte) 107, (byte) 103, (byte) 107, (byte) 102, (byte) 145, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      base.draw(g2, area, (object) null);
      BlockResult blockResult = new BlockResult();
      if (@params is EntityBlockParams && ((EntityBlockParams) @params).getGenerateEntities())
      {
        StandardEntityCollection entityCollection = new StandardEntityCollection();
        LegendItemEntity legendItemEntity = new LegendItemEntity((Shape) ((RectangularShape) area).clone());
        legendItemEntity.setSeriesIndex(this.series);
        legendItemEntity.setSeriesKey(this.seriesKey);
        legendItemEntity.setDataset(this.dataset);
        legendItemEntity.setToolTipText(this.getToolTipText());
        legendItemEntity.setURLText(this.getURLText());
        entityCollection.add((ChartEntity) legendItemEntity);
        blockResult.setEntityCollection((EntityCollection) entityCollection);
      }
      return (object) blockResult;
    }
  }
}
