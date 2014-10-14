// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CrosshairState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.plot
{
  public class CrosshairState : Object
  {
    private bool calculateDistanceInDataSpace;
    private double anchorX;
    private double anchorY;
    private Point2D anchor;
    private double crosshairX;
    private double crosshairY;
    private int datasetIndex;
    private int domainAxisIndex;
    private int rangeAxisIndex;
    private double distance;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 98, (byte) 232, (byte) 2, (byte) 231, (byte) 127, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrosshairState(bool calculateDistanceInDataSpace)
    {
      int num = calculateDistanceInDataSpace ? 1 : 0;
      base.\u002Ector();
      CrosshairState crosshairState = this;
      this.calculateDistanceInDataSpace = false;
      this.calculateDistanceInDataSpace = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrosshairState()
      : this(false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 107, (byte) 102, (byte) 104, (byte) 223, (byte) 12, (byte) 109, (byte) 109, (byte) 105, (byte) 98, (byte) 98, (byte) 130, (byte) 217, (byte) 105, (byte) 105, (byte) 105, (byte) 103, (byte) 104, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairPoint(double x, double y, int domainAxisIndex, int rangeAxisIndex, double transX, double transY, PlotOrientation orientation)
    {
      if (this.anchor == null)
        return;
      double num1;
      if (this.calculateDistanceInDataSpace)
      {
        num1 = (x - this.anchorX) * (x - this.anchorX) + (y - this.anchorY) * (y - this.anchorY);
      }
      else
      {
        double num2 = this.anchor.getX();
        double num3 = this.anchor.getY();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double num4 = num3;
          num3 = num2;
          num2 = num4;
        }
        num1 = (transX - num2) * (transX - num2) + (transY - num3) * (transY - num3);
      }
      if (num1 >= this.distance)
        return;
      this.crosshairX = x;
      this.crosshairY = y;
      this.domainAxisIndex = domainAxisIndex;
      this.rangeAxisIndex = rangeAxisIndex;
      this.distance = num1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 112, (byte) 105, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairX(double candidateX, int domainAxisIndex)
    {
      double num = Math.abs(candidateX - this.anchorX);
      if (num >= this.distance)
        return;
      this.crosshairX = candidateX;
      this.domainAxisIndex = domainAxisIndex;
      this.distance = num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 112, (byte) 105, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairY(double candidateY, int rangeAxisIndex)
    {
      double num = Math.abs(candidateY - this.anchorY);
      if (num >= this.distance)
        return;
      this.crosshairY = candidateY;
      this.rangeAxisIndex = rangeAxisIndex;
      this.distance = num;
    }

    public virtual double getCrosshairDistance()
    {
      return this.distance;
    }

    public virtual void setCrosshairDistance(double distance)
    {
      this.distance = distance;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairPoint(double x, double y, double transX, double transY, PlotOrientation orientation)
    {
      this.updateCrosshairPoint(x, y, 0, 0, transX, transY, orientation);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairX(double candidateX)
    {
      this.updateCrosshairX(candidateX, 0);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairY(double candidateY)
    {
      this.updateCrosshairY(candidateY, 0);
    }

    public virtual Point2D getAnchor()
    {
      return this.anchor;
    }

    public virtual void setAnchor(Point2D anchor)
    {
      this.anchor = anchor;
    }

    public virtual double getAnchorX()
    {
      return this.anchorX;
    }

    public virtual void setAnchorX(double x)
    {
      this.anchorX = x;
    }

    public virtual double getAnchorY()
    {
      return this.anchorY;
    }

    public virtual void setAnchorY(double y)
    {
      this.anchorY = y;
    }

    public virtual double getCrosshairX()
    {
      return this.crosshairX;
    }

    public virtual void setCrosshairX(double x)
    {
      this.crosshairX = x;
    }

    public virtual double getCrosshairY()
    {
      return this.crosshairY;
    }

    public virtual void setCrosshairY(double y)
    {
      this.crosshairY = y;
    }

    public virtual int getDatasetIndex()
    {
      return this.datasetIndex;
    }

    public virtual void setDatasetIndex(int index)
    {
      this.datasetIndex = index;
    }

    [Obsolete]
    public virtual int getDomainAxisIndex()
    {
      return this.domainAxisIndex;
    }

    [Obsolete]
    public virtual int getRangeAxisIndex()
    {
      return this.rangeAxisIndex;
    }
  }
}
