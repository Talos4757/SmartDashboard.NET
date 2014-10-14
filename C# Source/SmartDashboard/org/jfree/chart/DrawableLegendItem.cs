// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.DrawableLegendItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  [Obsolete]
  public class DrawableLegendItem : Object
  {
    private LegendItem item;
    private double x;
    private double y;
    private double width;
    private double height;
    private Shape marker;
    private Line2D line;
    private Point2D labelPosition;

    [LineNumberTable(new byte[] {(byte) 44, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawableLegendItem(LegendItem item)
    {
      base.\u002Ector();
      DrawableLegendItem drawableLegendItem = this;
      this.item = item;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual double getWidth()
    {
      return this.width;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual double getHeight()
    {
      return this.height;
    }

    public virtual LegendItem getItem()
    {
      return this.item;
    }

    public virtual void setX(double x)
    {
      this.x = x;
    }

    public virtual void setY(double y)
    {
      this.y = y;
    }

    [LineNumberTable((ushort) 169)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaxX()
    {
      return this.getX() + this.getWidth();
    }

    [LineNumberTable((ushort) 180)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaxY()
    {
      return this.getY() + this.getHeight();
    }

    public virtual Shape getMarker()
    {
      return this.marker;
    }

    public virtual void setMarker(Shape marker)
    {
      this.marker = marker;
    }

    public virtual void setLine(Line2D l)
    {
      this.line = l;
    }

    public virtual Line2D getLine()
    {
      return this.line;
    }

    public virtual Point2D getLabelPosition()
    {
      return this.labelPosition;
    }

    public virtual void setLabelPosition(Point2D position)
    {
      this.labelPosition = position;
    }

    public virtual void setBounds(double x, double y, double width, double height)
    {
      this.x = x;
      this.y = y;
      this.width = width;
      this.height = height;
    }
  }
}
