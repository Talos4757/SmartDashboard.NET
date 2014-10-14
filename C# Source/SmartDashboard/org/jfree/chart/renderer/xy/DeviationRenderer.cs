// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.DeviationRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Serializable]
  public class DeviationRenderer : XYLineAndShapeRenderer
  {
    private float alpha;

    [HideFromJava]
    static DeviationRenderer()
    {
      XYLineAndShapeRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 100, (byte) 106, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeviationRenderer(bool lines, bool shapes)
      : base(lines, shapes)
    {
      DeviationRenderer deviationRenderer = this;
      base.setDrawSeriesLineAsPath(true);
      this.alpha = 0.5f;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeviationRenderer()
      : this(true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DeviationRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    protected internal override bool isLinePass(int pass)
    {
      return pass == 1;
    }

    protected internal override bool isItemPass(int pass)
    {
      return pass == 2;
    }

    public virtual float getAlpha()
    {
      return this.alpha;
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 114, (byte) 176, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAlpha(float alpha)
    {
      if ((double) alpha < 0.0 || (double) alpha > 1.0)
      {
        string str = "Requires 'alpha' in the range 0.0 to 1.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.alpha = alpha;
        this.fireChangeEvent();
      }
    }

    public override void setDrawSeriesLineAsPath(bool flag)
    {
    }

    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      return this.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 104, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset dataset, PlotRenderingInfo info)
    {
      DeviationRenderer.State state = new DeviationRenderer.State(info);
      state.seriesPath = new GeneralPath();
      state.setProcessVisibleItemsOnly(false);
      return (XYItemRendererState) state;
    }

    public override int getPassCount()
    {
      return 3;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 108, (byte) 193, (byte) 103, (byte) 104, (byte) 135, (byte) 108, (byte) 108, (byte) 141, (byte) 105, (byte) 137, (byte) 110, (byte) 142, (byte) 175, (byte) 105, (byte) 105, (byte) 124, (byte) 158, (byte) 105, (byte) 124, (byte) 188, (byte) 178, (byte) 104, (byte) 146, (byte) 112, (byte) 103, (byte) 120, (byte) 113, (byte) 114, (byte) 121, (byte) 17, (byte) 200, (byte) 109, (byte) 123, (byte) 113, (byte) 107, (byte) 121, (byte) 17, (byte) 200, (byte) 103, (byte) 104, (byte) 136, (byte) 107, (byte) 171, (byte) 202, (byte) 100, (byte) 104, (byte) 108, (byte) 168, (byte) 108, (byte) 249, (byte) 70, (byte) 170, (byte) 99, (byte) 100, (byte) 174, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      if (pass == 0)
      {
        IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
        DeviationRenderer.State state1 = (DeviationRenderer.State) state;
        double xvalue = ntervalXyDataset.getXValue(series, item);
        double startYvalue = ntervalXyDataset.getStartYValue(series, item);
        double endYvalue = ntervalXyDataset.getEndYValue(series, item);
        RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
        RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
        double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
        double num2 = rangeAxis.valueToJava2D(startYvalue, dataArea, rangeAxisEdge);
        double num3 = rangeAxis.valueToJava2D(endYvalue, dataArea, rangeAxisEdge);
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          List list1 = state1.lowerCoordinates;
          double[] numArray1 = new double[2];
          int index1 = 0;
          double num4 = num2;
          numArray1[index1] = num4;
          int index2 = 1;
          double num5 = num1;
          numArray1[index2] = num5;
          list1.add((object) numArray1);
          List list2 = state1.upperCoordinates;
          double[] numArray2 = new double[2];
          int index3 = 0;
          double num6 = num3;
          numArray2[index3] = num6;
          int index4 = 1;
          double num7 = num1;
          numArray2[index4] = num7;
          list2.add((object) numArray2);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          List list1 = state1.lowerCoordinates;
          double[] numArray1 = new double[2];
          int index1 = 0;
          double num4 = num1;
          numArray1[index1] = num4;
          int index2 = 1;
          double num5 = num2;
          numArray1[index2] = num5;
          list1.add((object) numArray1);
          List list2 = state1.upperCoordinates;
          double[] numArray2 = new double[2];
          int index3 = 0;
          double num6 = num1;
          numArray2[index3] = num6;
          int index4 = 1;
          double num7 = num3;
          numArray2[index4] = num7;
          list2.add((object) numArray2);
        }
        if (item == dataset.getItemCount(series) - 1)
        {
          Composite composite = g2.getComposite();
          g2.setComposite((Composite) AlphaComposite.getInstance(3, this.alpha));
          g2.setPaint(this.getItemFillPaint(series, item));
          GeneralPath generalPath = new GeneralPath();
          double[] numArray1 = (double[]) state1.lowerCoordinates.get(0);
          ((Path2D.Float) generalPath).moveTo((float) numArray1[0], (float) numArray1[1]);
          for (int index = 1; index < state1.lowerCoordinates.size(); ++index)
          {
            double[] numArray2 = (double[]) state1.lowerCoordinates.get(index);
            ((Path2D.Float) generalPath).lineTo((float) numArray2[0], (float) numArray2[1]);
          }
          int num4 = state1.upperCoordinates.size();
          double[] numArray3 = (double[]) state1.upperCoordinates.get(num4 - 1);
          ((Path2D.Float) generalPath).lineTo((float) numArray3[0], (float) numArray3[1]);
          int num5 = num4 - 2;
          while (num5 >= 0)
          {
            double[] numArray2 = (double[]) state1.upperCoordinates.get(num5);
            ((Path2D.Float) generalPath).lineTo((float) numArray2[0], (float) numArray2[1]);
            num5 += -1;
          }
          ((Path2D) generalPath).closePath();
          g2.fill((Shape) generalPath);
          g2.setComposite(composite);
          state1.lowerCoordinates.clear();
          state1.upperCoordinates.clear();
        }
      }
      if (this.isLinePass(pass))
      {
        if (item == 0)
        {
          DeviationRenderer.State state1 = (DeviationRenderer.State) state;
          ((Path2D) state1.seriesPath).reset();
          state1.setLastPointGood(false);
        }
        if (!this.getItemLineVisible(series, item))
          return;
        this.drawPrimaryLineAsPath(state, g2, plot, dataset, pass, series, item, domainAxis, rangeAxis, dataArea);
      }
      else
      {
        if (!this.isItemPass(pass))
          return;
        EntityCollection entities = (EntityCollection) null;
        if (info != null)
          entities = info.getOwner().getEntityCollection();
        this.drawSecondaryPass(g2, plot, dataset, pass, series, item, domainAxis, dataArea, rangeAxis, crosshairState, entities);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DeviationRenderer) || (double) this.alpha != (double) ((DeviationRenderer) obj).alpha)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [InnerClass]
    [SourceFile("DeviationRenderer.java")]
    public class State : XYLineAndShapeRenderer.State
    {
      public List upperCoordinates;
      public List lowerCoordinates;

      [LineNumberTable(new byte[] {(byte) 54, (byte) 105, (byte) 107, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public State(PlotRenderingInfo info)
        : base(info)
      {
        DeviationRenderer.State state = this;
        this.lowerCoordinates = (List) new ArrayList();
        this.upperCoordinates = (List) new ArrayList();
      }
    }
  }
}
