// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.AbstractXYAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.util;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"org.jfree.chart.annotations.XYAnnotation"})]
  public abstract class AbstractXYAnnotation : Object, XYAnnotation
  {
    private string toolTipText;
    private string url;

    [LineNumberTable(new byte[] {(byte) 21, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYAnnotation()
    {
      base.\u002Ector();
      AbstractXYAnnotation abstractXyAnnotation = this;
      this.toolTipText = (string) null;
      this.url = (string) null;
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    public virtual void setToolTipText(string text)
    {
      this.toolTipText = text;
    }

    public virtual string getURL()
    {
      return this.url;
    }

    public virtual void setURL(string url)
    {
      this.url = url;
    }

    public abstract void draw(Graphics2D gd, XYPlot xyp, Rectangle2D rd, ValueAxis va1, ValueAxis va2, int i, PlotRenderingInfo pri);

    [LineNumberTable(new byte[] {(byte) 103, (byte) 99, (byte) 129, (byte) 108, (byte) 99, (byte) 129, (byte) 140, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addEntity(PlotRenderingInfo info, Shape hotspot, int rendererIndex, string toolTipText, string urlText)
    {
      if (info == null)
        return;
      EntityCollection entityCollection = info.getOwner().getEntityCollection();
      if (entityCollection == null)
        return;
      XYAnnotationEntity annotationEntity = new XYAnnotationEntity(hotspot, rendererIndex, toolTipText, urlText);
      entityCollection.add((ChartEntity) annotationEntity);
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractXYAnnotation))
        return false;
      AbstractXYAnnotation abstractXyAnnotation = (AbstractXYAnnotation) obj;
      return ObjectUtilities.equal((object) this.toolTipText, (object) abstractXyAnnotation.toolTipText) && ObjectUtilities.equal((object) this.url, (object) abstractXyAnnotation.url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 102, (byte) 104, (byte) 145, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num = 193;
      if (this.toolTipText != null)
        num = 37 * num + String.instancehelper_hashCode(this.toolTipText);
      if (this.url != null)
        num = 37 * num + String.instancehelper_hashCode(this.url);
      return num;
    }
  }
}
