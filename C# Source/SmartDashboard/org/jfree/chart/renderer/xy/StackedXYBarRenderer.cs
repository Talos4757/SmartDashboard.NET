// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.StackedXYBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.general;
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
  public class StackedXYBarRenderer : XYBarRenderer
  {
    private const long serialVersionUID = -7049101055533436444L;
    private bool renderAsPercentages;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024xy\u0024IntervalXYDataset;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024xy\u0024TableXYDataset;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [HideFromJava]
    static StackedXYBarRenderer()
    {
      XYBarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 106, (byte) 199, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYBarRenderer(double margin)
      : base(margin)
    {
      StackedXYBarRenderer stackedXyBarRenderer = this;
      this.renderAsPercentages = false;
      ItemLabelPosition position = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER);
      this.setBasePositiveItemLabelPosition(position);
      this.setBaseNegativeItemLabelPosition(position);
      this.setPositiveItemLabelPositionFallback((ItemLabelPosition) null);
      this.setNegativeItemLabelPositionFallback((ItemLabelPosition) null);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYBarRenderer()
      : this(0.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedXYBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, StackedXYBarRenderer.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    public virtual bool getRenderAsPercentages()
    {
      return this.renderAsPercentages;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderAsPercentages(bool asPercentages)
    {
      this.renderAsPercentages = asPercentages;
      this.fireChangeEvent();
    }

    public override int getPassCount()
    {
      return 3;
    }

    [LineNumberTable((ushort) 190)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      return (XYItemRendererState) new XYBarRenderer.XYBarRendererState((XYBarRenderer) this, info);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 99, (byte) 104, (byte) 178, (byte) 238, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      if (this.renderAsPercentages)
        return new Range(0.0, 1.0);
      else
        return DatasetUtilities.findStackedRangeBounds((TableXYDataset) dataset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 149, (byte) 159, (byte) 17, (byte) 98, (byte) 127, (byte) 13, (byte) 123, (byte) 130, (byte) 127, (byte) 13, (byte) 99, (byte) 155, (byte) 187, (byte) 172, (byte) 104, (byte) 108, (byte) 104, (byte) 225, (byte) 74, (byte) 103, (byte) 104, (byte) 145, (byte) 166, (byte) 103, (byte) 135, (byte) 105, (byte) 110, (byte) 105, (byte) 104, (byte) 136, (byte) 105, (byte) 170, (byte) 232, (byte) 54, (byte) 232, (byte) 81, (byte) 105, (byte) 104, (byte) 143, (byte) 211, (byte) 143, (byte) 209, (byte) 105, (byte) 109, (byte) 105, (byte) 129, (byte) 175, (byte) 109, (byte) 105, (byte) 129, (byte) 143, (byte) 151, (byte) 109, (byte) 109, (byte) 108, (byte) 104, (byte) 178, (byte) 99, (byte) 105, (byte) 105, (byte) 216, (byte) 105, (byte) 214, (byte) 106, (byte) 137, (byte) 105, (byte) 112, (byte) 169, (byte) 201, (byte) 112, (byte) 169, (byte) 199, (byte) 100, (byte) 107, (byte) 219, (byte) 101, (byte) 181, (byte) 103, (byte) 142, (byte) 100, (byte) 190, (byte) 130, (byte) 165, (byte) 108, (byte) 140, (byte) 253, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!(dataset is IntervalXYDataset) || !(dataset is TableXYDataset))
      {
        string str1 = new StringBuffer().append("dataset (type ").append(Object.instancehelper_getClass((object) dataset).getName()).append(") has wrong type:").toString();
        int num = 0;
        if (!(StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024IntervalXYDataset != null ? StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024IntervalXYDataset : (StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024IntervalXYDataset = StackedXYBarRenderer.class\u0024("org.jfree.data.xy.IntervalXYDataset"))).isAssignableFrom(Object.instancehelper_getClass((object) dataset)))
        {
          str1 = new StringBuffer().append(str1).append(" it is no IntervalXYDataset").toString();
          num = 1;
        }
        if (!(StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024TableXYDataset != null ? StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024TableXYDataset : (StackedXYBarRenderer.class\u0024org\u0024jfree\u0024data\u0024xy\u0024TableXYDataset = StackedXYBarRenderer.class\u0024("org.jfree.data.xy.TableXYDataset"))).isAssignableFrom(Object.instancehelper_getClass((object) dataset)))
        {
          if (num != 0)
            str1 = new StringBuffer().append(str1).append(" and").toString();
          str1 = new StringBuffer().append(str1).append(" it is no TableXYDataset").toString();
        }
        string str2 = str1;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str2);
      }
      else
      {
        IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
        double yvalue1 = ntervalXyDataset.getYValue(series, item);
        if (Double.isNaN(yvalue1))
          return;
        double num1 = 0.0;
        if (this.renderAsPercentages)
        {
          num1 = DatasetUtilities.calculateStackTotal((TableXYDataset) dataset, item);
          yvalue1 /= num1;
        }
        double d1 = 0.0;
        double d2 = 0.0;
        for (int i1 = 0; i1 < series; ++i1)
        {
          double yvalue2 = dataset.getYValue(i1, item);
          if (!Double.isNaN(yvalue2))
          {
            if (this.renderAsPercentages)
              yvalue2 /= num1;
            if (yvalue2 > 0.0)
              d1 += yvalue2;
            else
              d2 += yvalue2;
          }
        }
        RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
        double num2;
        double num3;
        if (yvalue1 > 0.0)
        {
          num2 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
          num3 = rangeAxis.valueToJava2D(d1 + yvalue1, dataArea, rangeAxisEdge);
        }
        else
        {
          num2 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
          num3 = rangeAxis.valueToJava2D(d2 + yvalue1, dataArea, rangeAxisEdge);
        }
        RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
        double startXvalue = ntervalXyDataset.getStartXValue(series, item);
        if (Double.isNaN(startXvalue))
          return;
        double num4 = domainAxis.valueToJava2D(startXvalue, dataArea, domainAxisEdge);
        double endXvalue = ntervalXyDataset.getEndXValue(series, item);
        if (Double.isNaN(endXvalue))
          return;
        double num5 = domainAxis.valueToJava2D(endXvalue, dataArea, domainAxisEdge);
        double num6 = Math.max(1.0, Math.abs(num5 - num4));
        double num7 = Math.abs(num3 - num2);
        if (this.getMargin() > 0.0)
        {
          double num8 = num6 * this.getMargin();
          num6 -= num8;
          num4 += num8 / 2.0;
        }
        Rectangle2D.Double @double = (Rectangle2D.Double) null;
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Rectangle2D.Double(Math.min(num2, num3), num5, num7, num6);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Rectangle2D.Double(num4, Math.min(num2, num3), num6, num7);
        int num9 = yvalue1 > 0.0 ? 1 : 0;
        int num10 = rangeAxis.isInverted() ? 1 : 0;
        RectangleEdge re = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (num9 != 0 && num10 == 0 || num9 == 0 && num10 != 0 ? RectangleEdge.__\u003C\u003EBOTTOM : RectangleEdge.__\u003C\u003ETOP) : (num9 != 0 && num10 != 0 || num9 == 0 && num10 == 0 ? RectangleEdge.__\u003C\u003ERIGHT : RectangleEdge.__\u003C\u003ELEFT);
        if (pass == 0)
        {
          if (!this.getShadowsVisible())
            return;
          this.getBarPainter().paintBarShadow(g2, (XYBarRenderer) this, series, item, (RectangularShape) @double, re, false);
        }
        else if (pass == 1)
        {
          this.getBarPainter().paintBar(g2, (XYBarRenderer) this, series, item, (RectangularShape) @double, re);
          if (info == null)
            return;
          EntityCollection entityCollection = info.getOwner().getEntityCollection();
          if (entityCollection == null)
            return;
          this.addEntity(entityCollection, (Shape) @double, dataset, series, item, ((RectangularShape) @double).getCenterX(), ((RectangularShape) @double).getCenterY());
        }
        else
        {
          if (pass != 2 || !this.isItemLabelVisible(series, item))
            return;
          XYItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(series, item);
          this.drawItemLabel(g2, dataset, series, item, plot, itemLabelGenerator, (Rectangle2D) @double, yvalue1 < 0.0);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StackedXYBarRenderer) || this.renderAsPercentages != ((StackedXYBarRenderer) obj).renderAsPercentages)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 103, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode() * 37 + (!this.renderAsPercentages ? 0 : 1);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (StackedXYBarRenderer.__\u003CcallerID\u003E == null)
        StackedXYBarRenderer.__\u003CcallerID\u003E = (CallerID) new StackedXYBarRenderer.__\u003CCallerID\u003E();
      return StackedXYBarRenderer.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
