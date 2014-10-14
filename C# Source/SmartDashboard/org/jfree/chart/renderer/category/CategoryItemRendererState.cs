// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.CategoryItemRendererState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.renderer.category
{
  public class CategoryItemRendererState : RendererState
  {
    private double barWidth;
    private double seriesRunningTotal;
    private int[] visibleSeries;
    private CategoryCrosshairState crosshairState;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 105, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryItemRendererState(PlotRenderingInfo info)
      : base(info)
    {
      CategoryItemRendererState itemRendererState = this;
      this.barWidth = 0.0;
      this.seriesRunningTotal = 0.0;
    }

    public virtual void setCrosshairState(CategoryCrosshairState state)
    {
      this.crosshairState = state;
    }

    public virtual void setVisibleSeriesArray(int[] visibleSeries)
    {
      this.visibleSeries = visibleSeries;
    }

    public virtual CategoryCrosshairState getCrosshairState()
    {
      return this.crosshairState;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 104, (byte) 130})]
    public virtual int getVisibleSeriesCount()
    {
      if (this.visibleSeries == null)
        return -1;
      else
        return this.visibleSeries.Length;
    }

    public virtual void setBarWidth(double width)
    {
      this.barWidth = width;
    }

    public virtual double getBarWidth()
    {
      return this.barWidth;
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 104, (byte) 130, (byte) 98, (byte) 108, (byte) 107, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    public virtual int getVisibleSeriesIndex(int rowIndex)
    {
      if (this.visibleSeries == null)
        return rowIndex;
      int num = -1;
      for (int index = 0; index < this.visibleSeries.Length; ++index)
      {
        if (this.visibleSeries[index] == rowIndex)
        {
          num = index;
          break;
        }
      }
      return num;
    }

    public virtual double getSeriesRunningTotal()
    {
      return this.seriesRunningTotal;
    }

    internal virtual void setSeriesRunningTotal([In] double obj0)
    {
      this.seriesRunningTotal = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 104, (byte) 130, (byte) 109, (byte) 149})]
    public virtual int[] getVisibleSeriesArray()
    {
      if (this.visibleSeries == null)
        return (int[]) null;
      int[] numArray = new int[this.visibleSeries.Length];
      ByteCodeHelper.arraycopy_primitive_4((Array) this.visibleSeries, 0, (Array) numArray, 0, this.visibleSeries.Length);
      return numArray;
    }
  }
}
