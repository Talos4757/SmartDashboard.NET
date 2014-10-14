// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PiePlotState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using org.jfree.chart.renderer;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.plot
{
  public class PiePlotState : RendererState
  {
    private int passesRequired;
    private double total;
    private double latestAngle;
    private Rectangle2D explodedPieArea;
    private Rectangle2D pieArea;
    private double pieCenterX;
    private double pieCenterY;
    private double pieHRadius;
    private double pieWRadius;
    private Rectangle2D linkArea;

    [LineNumberTable(new byte[] {(byte) 39, (byte) 105, (byte) 103, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PiePlotState(PlotRenderingInfo info)
      : base(info)
    {
      PiePlotState piePlotState = this;
      this.passesRequired = 1;
      this.total = 0.0;
    }

    public virtual void setPassesRequired(int passes)
    {
      this.passesRequired = passes;
    }

    public virtual void setTotal(double total)
    {
      this.total = total;
    }

    public virtual void setLatestAngle(double angle)
    {
      this.latestAngle = angle;
    }

    public virtual void setLinkArea(Rectangle2D area)
    {
      this.linkArea = area;
    }

    public virtual void setExplodedPieArea(Rectangle2D area)
    {
      this.explodedPieArea = area;
    }

    public virtual void setPieArea(Rectangle2D area)
    {
      this.pieArea = area;
    }

    public virtual void setPieCenterX(double x)
    {
      this.pieCenterX = x;
    }

    public virtual void setPieCenterY(double y)
    {
      this.pieCenterY = y;
    }

    public virtual void setPieWRadius(double radius)
    {
      this.pieWRadius = radius;
    }

    public virtual void setPieHRadius(double radius)
    {
      this.pieHRadius = radius;
    }

    public virtual int getPassesRequired()
    {
      return this.passesRequired;
    }

    public virtual double getLatestAngle()
    {
      return this.latestAngle;
    }

    public virtual double getTotal()
    {
      return this.total;
    }

    public virtual Rectangle2D getPieArea()
    {
      return this.pieArea;
    }

    public virtual Rectangle2D getExplodedPieArea()
    {
      return this.explodedPieArea;
    }

    public virtual Rectangle2D getLinkArea()
    {
      return this.linkArea;
    }

    public virtual double getPieCenterY()
    {
      return this.pieCenterY;
    }

    public virtual double getPieCenterX()
    {
      return this.pieCenterX;
    }

    public virtual double getPieWRadius()
    {
      return this.pieWRadius;
    }

    public virtual double getPieHRadius()
    {
      return this.pieHRadius;
    }
  }
}
