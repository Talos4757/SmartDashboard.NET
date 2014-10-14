// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CategoryCrosshairState
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
  public class CategoryCrosshairState : CrosshairState
  {
    private IComparable rowKey;
    private IComparable columnKey;

    [LineNumberTable(new byte[] {(byte) 21, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryCrosshairState()
    {
      CategoryCrosshairState categoryCrosshairState = this;
      this.rowKey = (IComparable) null;
      this.columnKey = (IComparable) null;
    }

    public virtual IComparable getRowKey()
    {
      return this.rowKey;
    }

    public virtual void setRowKey(IComparable key)
    {
      this.rowKey = key;
    }

    public virtual IComparable getColumnKey()
    {
      return this.columnKey;
    }

    public virtual void setColumnKey(IComparable key)
    {
      this.columnKey = key;
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 103, (byte) 102, (byte) 104, (byte) 104, (byte) 105, (byte) 98, (byte) 98, (byte) 130, (byte) 185, (byte) 105, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 201})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairPoint(IComparable rowKey, IComparable columnKey, double value, int datasetIndex, double transX, double transY, PlotOrientation orientation)
    {
      Point2D anchor = this.getAnchor();
      if (anchor == null)
        return;
      double num1 = anchor.getX();
      double num2 = anchor.getY();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num3 = num2;
        num2 = num1;
        num1 = num3;
      }
      double distance = (transX - num1) * (transX - num1) + (transY - num2) * (transY - num2);
      if (distance >= this.getCrosshairDistance())
        return;
      this.rowKey = rowKey;
      this.columnKey = columnKey;
      this.setCrosshairY(value);
      this.setDatasetIndex(datasetIndex);
      this.setCrosshairDistance(distance);
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 103, (byte) 99, (byte) 104, (byte) 105, (byte) 136, (byte) 108, (byte) 105, (byte) 103, (byte) 103, (byte) 103, (byte) 201})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateCrosshairX(IComparable rowKey, IComparable columnKey, int datasetIndex, double transX, PlotOrientation orientation)
    {
      Point2D anchor = this.getAnchor();
      if (anchor == null)
        return;
      double num = anchor.getX();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num = anchor.getY();
      double distance = Math.abs(transX - num);
      if (distance >= this.getCrosshairDistance())
        return;
      this.rowKey = rowKey;
      this.columnKey = columnKey;
      this.setDatasetIndex(datasetIndex);
      this.setCrosshairDistance(distance);
    }
  }
}
