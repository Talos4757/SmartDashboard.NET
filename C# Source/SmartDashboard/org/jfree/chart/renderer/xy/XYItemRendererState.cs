// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYItemRendererState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.data.xy;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.renderer.xy
{
  public class XYItemRendererState : RendererState
  {
    private int firstItemIndex;
    private int lastItemIndex;
    public Line2D workingLine;
    private bool processVisibleItemsOnly;

    [LineNumberTable(new byte[] {(byte) 47, (byte) 105, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYItemRendererState(PlotRenderingInfo info)
      : base(info)
    {
      XYItemRendererState itemRendererState = this;
      this.workingLine = (Line2D) new Line2D.Double();
      this.processVisibleItemsOnly = true;
    }

    public virtual bool getProcessVisibleItemsOnly()
    {
      return this.processVisibleItemsOnly;
    }

    public virtual void startSeriesPass(XYDataset dataset, int series, int firstItem, int lastItem, int pass, int passCount)
    {
      this.firstItemIndex = firstItem;
      this.lastItemIndex = lastItem;
    }

    public virtual void endSeriesPass(XYDataset dataset, int series, int firstItem, int lastItem, int pass, int passCount)
    {
    }

    public virtual int getLastItemIndex()
    {
      return this.lastItemIndex;
    }

    public virtual void setProcessVisibleItemsOnly(bool flag)
    {
      this.processVisibleItemsOnly = flag;
    }

    public virtual int getFirstItemIndex()
    {
      return this.firstItemIndex;
    }
  }
}
