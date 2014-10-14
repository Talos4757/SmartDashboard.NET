// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.WaterfallBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Serializable]
  public class WaterfallBarRenderer : BarRenderer
  {
    private const long serialVersionUID = -2482910643727230911L;
    [NonSerialized]
    private Paint firstBarPaint;
    [NonSerialized]
    private Paint lastBarPaint;
    [NonSerialized]
    private Paint positiveBarPaint;
    [NonSerialized]
    private Paint negativeBarPaint;

    [HideFromJava]
    static WaterfallBarRenderer()
    {
      BarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 255, (byte) 160, (byte) 131, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaterfallBarRenderer()
      : this((Paint) new GradientPaint(0.0f, 0.0f, new Color(34, 34, (int) byte.MaxValue), 0.0f, 0.0f, new Color(102, 102, (int) byte.MaxValue)), (Paint) new GradientPaint(0.0f, 0.0f, new Color(34, (int) byte.MaxValue, 34), 0.0f, 0.0f, new Color(102, (int) byte.MaxValue, 102)), (Paint) new GradientPaint(0.0f, 0.0f, new Color((int) byte.MaxValue, 34, 34), 0.0f, 0.0f, new Color((int) byte.MaxValue, 102, 102)), (Paint) new GradientPaint(0.0f, 0.0f, new Color((int) byte.MaxValue, (int) byte.MaxValue, 34), 0.0f, 0.0f, new Color((int) byte.MaxValue, (int) byte.MaxValue, 102)))
    {
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 100, (byte) 144, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 144, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaterfallBarRenderer(Paint firstBarPaint, Paint positiveBarPaint, Paint negativeBarPaint, Paint lastBarPaint)
    {
      WaterfallBarRenderer waterfallBarRenderer = this;
      if (firstBarPaint == null)
      {
        string str = "Null 'firstBarPaint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (positiveBarPaint == null)
      {
        string str = "Null 'positiveBarPaint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (negativeBarPaint == null)
      {
        string str = "Null 'negativeBarPaint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (lastBarPaint == null)
      {
        string str = "Null 'lastBarPaint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.firstBarPaint = firstBarPaint;
        this.lastBarPaint = lastBarPaint;
        this.positiveBarPaint = positiveBarPaint;
        this.negativeBarPaint = negativeBarPaint;
        this.setGradientPaintTransformer((GradientPaintTransformer) new StandardGradientPaintTransformer(GradientPaintTransformType.__\u003C\u003ECENTER_VERTICAL));
        this.setMinimumBarLength(1.0);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WaterfallBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual Paint getFirstBarPaint()
    {
      return this.firstBarPaint;
    }

    public virtual Paint getLastBarPaint()
    {
      return this.lastBarPaint;
    }

    public virtual Paint getNegativeBarPaint()
    {
      return this.negativeBarPaint;
    }

    public virtual Paint getPositiveBarPaint()
    {
      return this.positiveBarPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFirstBarPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.firstBarPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLastBarPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lastBarPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveBarPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.positiveBarPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeBarPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.negativeBarPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 99, (byte) 130, (byte) 130, (byte) 102, (byte) 102, (byte) 103, (byte) 112, (byte) 103, (byte) 109, (byte) 108, (byte) 100, (byte) 98, (byte) 106, (byte) 135, (byte) 166, (byte) 136, (byte) 106, (byte) 234, (byte) 51, (byte) 11, (byte) 235, (byte) 84, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      int num1 = 1;
      double lower = 0.0;
      double upper = 0.0;
      int columnCount = dataset.getColumnCount();
      for (int i1 = 0; i1 < dataset.getRowCount(); ++i1)
      {
        double num2 = 0.0;
        for (int i2 = 0; i2 <= columnCount - 1; ++i2)
        {
          Number number = dataset.getValue(i1, i2);
          if (number != null)
          {
            num1 = 0;
            double num3 = number.doubleValue();
            if (i2 == columnCount - 1)
              num2 = num3;
            else
              num2 += num3;
            lower = Math.min(lower, num2);
            upper = Math.max(upper, num2);
          }
        }
      }
      if (num1 != 0)
        return (Range) null;
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 104, (byte) 109, (byte) 134, (byte) 102, (byte) 108, (byte) 99, (byte) 138, (byte) 135, (byte) 103, (byte) 137, (byte) 103, (byte) 135, (byte) 169, (byte) 206, (byte) 174, (byte) 102, (byte) 102, (byte) 100, (byte) 100, (byte) 196, (byte) 169, (byte) 184, (byte) 107, (byte) 107, (byte) 105, (byte) 188, (byte) 100, (byte) 105, (byte) 114, (byte) 218, (byte) 105, (byte) 156, (byte) 114, (byte) 132, (byte) 143, (byte) 103, (byte) 100, (byte) 138, (byte) 103, (byte) 170, (byte) 105, (byte) 138, (byte) 105, (byte) 170, (byte) 168, (byte) 150, (byte) 110, (byte) 145, (byte) 123, (byte) 168, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 200, (byte) 140, (byte) 112, (byte) 252, (byte) 69, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      double d1 = state.getSeriesRunningTotal();
      if (column == dataset.getColumnCount() - 1)
        d1 = 0.0;
      double d2 = 0.0;
      Number number = dataset.getValue(row, column);
      if (number != null)
        d2 = d1 + number.doubleValue();
      state.setSeriesRunningTotal(d2);
      int columnCount = this.getColumnCount();
      PlotOrientation orientation = plot.getOrientation();
      double num1 = 0.0;
      double num2 = 0.0;
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num3 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      double num4 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num5 = d2 - d1;
      if (num4 < num3)
      {
        double num6 = num4;
        num4 = num3;
        num3 = num6;
      }
      double num7 = state.getBarWidth();
      double num8 = Math.max(this.getMinimumBarLength(), Math.abs(num4 - num3));
      IComparable rowKey = dataset.getRowKey(row);
      IComparable columnKey = dataset.getColumnKey(column);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double categorySeriesMiddle = domainAxis.getCategorySeriesMiddle(columnKey, rowKey, dataset, this.getItemMargin(), dataArea, RectangleEdge.__\u003C\u003ELEFT);
        num1 = num3;
        num8 = state.getBarWidth();
        num2 = categorySeriesMiddle - num8 / 2.0;
        num7 = Math.max(this.getMinimumBarLength(), Math.abs(num4 - num3));
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num1 = domainAxis.getCategorySeriesMiddle(columnKey, rowKey, dataset, this.getItemMargin(), dataArea, RectangleEdge.__\u003C\u003ETOP) - num7 / 2.0;
        num2 = num3;
      }
      Rectangle2D.Double @double = new Rectangle2D.Double(num1, num2, num7, num8);
      this.getFirstBarPaint();
      object obj1 = column != 0 ? (column != columnCount - 1 ? (num5 >= 0.0 ? (num5 <= 0.0 ? (object) this.getLastBarPaint() : (object) this.getPositiveBarPaint()) : (object) this.getNegativeBarPaint()) : (object) this.getLastBarPaint()) : (object) this.getFirstBarPaint();
      if (this.getGradientPaintTransformer() != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) this.getGradientPaintTransformer().transform((GradientPaint) obj1, (Shape) @double);
      Graphics2D graphics2D = g2;
      object obj2 = obj1;
      Paint paint1;
      if (obj2 != null)
      {
        Paint paint2 = obj2 as Paint;
        if (paint2 == null)
          throw new IncompatibleClassChangeError();
        paint1 = paint2;
      }
      else
        paint1 = (Paint) null;
      graphics2D.setPaint(paint1);
      g2.fill((Shape) @double);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        Stroke itemOutlineStroke = this.getItemOutlineStroke(row, column);
        Paint itemOutlinePaint = this.getItemOutlinePaint(row, column);
        if (itemOutlineStroke != null && itemOutlinePaint != null)
        {
          g2.setStroke(itemOutlineStroke);
          g2.setPaint(itemOutlinePaint);
          g2.draw((Shape) @double);
        }
      }
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num5 < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 100, (byte) 130, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is WaterfallBarRenderer))
        return false;
      WaterfallBarRenderer waterfallBarRenderer = (WaterfallBarRenderer) obj;
      return PaintUtilities.equal(this.firstBarPaint, waterfallBarRenderer.firstBarPaint) && PaintUtilities.equal(this.lastBarPaint, waterfallBarRenderer.lastBarPaint) && (PaintUtilities.equal(this.positiveBarPaint, waterfallBarRenderer.positiveBarPaint) && PaintUtilities.equal(this.negativeBarPaint, waterfallBarRenderer.negativeBarPaint));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 128, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.firstBarPaint, obj0);
      SerialUtilities.writePaint(this.lastBarPaint, obj0);
      SerialUtilities.writePaint(this.positiveBarPaint, obj0);
      SerialUtilities.writePaint(this.negativeBarPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 145, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.firstBarPaint = SerialUtilities.readPaint(obj0);
      this.lastBarPaint = SerialUtilities.readPaint(obj0);
      this.positiveBarPaint = SerialUtilities.readPaint(obj0);
      this.negativeBarPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
