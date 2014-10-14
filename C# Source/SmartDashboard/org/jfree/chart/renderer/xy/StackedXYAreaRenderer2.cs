// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.StackedXYAreaRenderer2
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
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StackedXYAreaRenderer2 : XYAreaRenderer2, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 7752676509764539182L;
    private bool roundXCoordinates;

    [HideFromJava]
    static StackedXYAreaRenderer2()
    {
      XYAreaRenderer2.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 106, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYAreaRenderer2(XYToolTipGenerator labelGenerator, XYURLGenerator urlGenerator)
      : base(labelGenerator, urlGenerator)
    {
      StackedXYAreaRenderer2 stackedXyAreaRenderer2 = this;
      this.roundXCoordinates = true;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYAreaRenderer2()
      : this((XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedXYAreaRenderer2([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StackedXYAreaRenderer2 obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StackedXYAreaRenderer2 obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 107, (byte) 103, (byte) 105, (byte) 106, (byte) 104, (byte) 104, (byte) 178, (byte) 240, (byte) 57, (byte) 233, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double[] getStackValues([In] TableXYDataset obj0, [In] int obj1, [In] int obj2)
    {
      double[] numArray1 = new double[2];
      for (int i1 = 0; i1 < obj1; ++i1)
      {
        double yvalue = obj0.getYValue(i1, obj2);
        if (!Double.isNaN(yvalue))
        {
          if (yvalue >= 0.0)
          {
            double[] numArray2 = numArray1;
            int index = 1;
            double[] numArray3 = numArray2;
            numArray3[index] = numArray3[index] + yvalue;
          }
          else
          {
            double[] numArray2 = numArray1;
            int index = 0;
            double[] numArray3 = numArray2;
            numArray3[index] = numArray3[index] + yvalue;
          }
        }
      }
      return numArray1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 132, (byte) 103, (byte) 117, (byte) 117})]
    private double[] averageStackValues([In] double[] obj0, [In] double[] obj1)
    {
      return new double[2]
      {
        (obj0[0] + obj1[0]) / 2.0,
        (obj0[1] + obj1[1]) / 2.0
      };
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 103, (byte) 116, (byte) 170, (byte) 149, (byte) 116, (byte) 170, (byte) 149})]
    private double[] adjustedStackValues([In] double[] obj0, [In] double[] obj1)
    {
      return new double[2]
      {
        obj0[0] == 0.0 || obj1[0] == 0.0 ? 0.0 : (obj0[0] + obj1[0]) / 2.0,
        obj0[1] == 0.0 || obj1[1] == 0.0 ? 0.0 : (obj0[1] + obj1[1]) / 2.0
      };
    }

    public virtual bool getRoundXCoordinates()
    {
      return this.roundXCoordinates;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRoundXCoordinates(bool round)
    {
      this.roundXCoordinates = round;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 99, (byte) 130, (byte) 106, (byte) 106, (byte) 103, (byte) 103, (byte) 104, (byte) 150, (byte) 108, (byte) 236, (byte) 60, (byte) 232, (byte) 70, (byte) 108, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      double lower = double.PositiveInfinity;
      double upper = double.NegativeInfinity;
      TableXYDataset tableXyDataset = (TableXYDataset) dataset;
      int itemCount = tableXyDataset.getItemCount();
      for (int index = 0; index < itemCount; ++index)
      {
        double[] stackValues = this.getStackValues((TableXYDataset) dataset, tableXyDataset.getSeriesCount(), index);
        lower = Math.min(lower, stackValues[0]);
        upper = Math.max(upper, stackValues[1]);
      }
      if (lower == double.PositiveInfinity)
        return (Range) null;
      return new Range(lower, upper);
    }

    public override int getPassCount()
    {
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 98, (byte) 98, (byte) 100, (byte) 173, (byte) 104, (byte) 168, (byte) 109, (byte) 110, (byte) 105, (byte) 135, (byte) 205, (byte) 118, (byte) 118, (byte) 105, (byte) 135, (byte) 181, (byte) 107, (byte) 153, (byte) 153, (byte) 105, (byte) 135, (byte) 184, (byte) 113, (byte) 113, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 137, (byte) 110, (byte) 143, (byte) 175, (byte) 104, (byte) 106, (byte) 106, (byte) 202, (byte) 137, (byte) 103, (byte) 103, (byte) 108, (byte) 148, (byte) 145, (byte) 209, (byte) 108, (byte) 119, (byte) 143, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 133, (byte) 104, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 139, (byte) 167, (byte) 177, (byte) 108, (byte) 119, (byte) 143, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 133, (byte) 104, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 139, (byte) 135, (byte) 133, (byte) 148, (byte) 145, (byte) 209, (byte) 108, (byte) 104, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 139, (byte) 173, (byte) 119, (byte) 143, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 135, (byte) 209, (byte) 108, (byte) 104, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 139, (byte) 172, (byte) 119, (byte) 143, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 173, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 231, (byte) 69, (byte) 108, (byte) 100, (byte) 104, (byte) 104, (byte) 200, (byte) 99, (byte) 105, (byte) 106, (byte) 100, (byte) 215})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      TableXYDataset tableXyDataset = (TableXYDataset) dataset;
      PlotOrientation orientation = plot.getOrientation();
      double xvalue1 = dataset.getXValue(series, item);
      double num1 = dataset.getYValue(series, item);
      if (Double.isNaN(num1))
        num1 = 0.0;
      double[] stackValues1 = this.getStackValues(tableXyDataset, series, item);
      double xvalue2 = dataset.getXValue(series, Math.max(item - 1, 0));
      double num2 = dataset.getYValue(series, Math.max(item - 1, 0));
      if (Double.isNaN(num2))
        num2 = 0.0;
      double[] stackValues2 = this.getStackValues(tableXyDataset, series, Math.max(item - 1, 0));
      int itemCount = dataset.getItemCount(series);
      double xvalue3 = dataset.getXValue(series, Math.min(item + 1, itemCount - 1));
      double num3 = dataset.getYValue(series, Math.min(item + 1, itemCount - 1));
      if (Double.isNaN(num3))
        num3 = 0.0;
      double[] stackValues3 = this.getStackValues(tableXyDataset, series, Math.min(item + 1, itemCount - 1));
      double d1 = (xvalue2 + xvalue1) / 2.0;
      double d2 = (xvalue1 + xvalue3) / 2.0;
      double[] numArray1 = this.averageStackValues(stackValues2, stackValues1);
      double[] numArray2 = this.averageStackValues(stackValues1, stackValues3);
      double[] numArray3 = this.adjustedStackValues(stackValues2, stackValues1);
      double[] numArray4 = this.adjustedStackValues(stackValues1, stackValues3);
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      float num4 = (float) domainAxis.valueToJava2D(xvalue1, dataArea, domainAxisEdge);
      float num5 = (float) domainAxis.valueToJava2D(d1, dataArea, domainAxisEdge);
      float num6 = (float) domainAxis.valueToJava2D(d2, dataArea, domainAxisEdge);
      if (this.roundXCoordinates)
      {
        num4 = (float) Math.round(num4);
        num5 = (float) Math.round(num5);
        num6 = (float) Math.round(num6);
      }
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      GeneralPath generalPath1 = new GeneralPath();
      GeneralPath generalPath2 = new GeneralPath();
      float num7;
      if (num1 >= 0.0)
      {
        num7 = (float) rangeAxis.valueToJava2D(num1 + stackValues1[1], dataArea, rangeAxisEdge);
        float num8 = (float) rangeAxis.valueToJava2D(stackValues1[1], dataArea, rangeAxisEdge);
        float num9 = (float) rangeAxis.valueToJava2D(numArray3[1], dataArea, rangeAxisEdge);
        if (num2 >= 0.0)
        {
          double d3 = (num2 + num1) / 2.0 + numArray1[1];
          float num10 = (float) rangeAxis.valueToJava2D(d3, dataArea, rangeAxisEdge);
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath1).moveTo(num4, num7);
            ((Path2D.Float) generalPath1).lineTo(num4, num8);
            ((Path2D.Float) generalPath1).lineTo(num5, num9);
            ((Path2D.Float) generalPath1).lineTo(num5, num10);
          }
          else
          {
            ((Path2D.Float) generalPath1).moveTo(num7, num4);
            ((Path2D.Float) generalPath1).lineTo(num8, num4);
            ((Path2D.Float) generalPath1).lineTo(num9, num5);
            ((Path2D.Float) generalPath1).lineTo(num10, num5);
          }
          ((Path2D) generalPath1).closePath();
        }
        else
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath1).moveTo(num4, num8);
            ((Path2D.Float) generalPath1).lineTo(num4, num7);
            ((Path2D.Float) generalPath1).lineTo(num5, num9);
          }
          else
          {
            ((Path2D.Float) generalPath1).moveTo(num8, num4);
            ((Path2D.Float) generalPath1).lineTo(num7, num4);
            ((Path2D.Float) generalPath1).lineTo(num9, num5);
          }
          ((Path2D) generalPath1).closePath();
        }
        float num11 = (float) rangeAxis.valueToJava2D(numArray4[1], dataArea, rangeAxisEdge);
        if (num3 >= 0.0)
        {
          double d3 = (num1 + num3) / 2.0 + numArray2[1];
          float num10 = (float) rangeAxis.valueToJava2D(d3, dataArea, rangeAxisEdge);
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath2).moveTo(num4, num8);
            ((Path2D.Float) generalPath2).lineTo(num4, num7);
            ((Path2D.Float) generalPath2).lineTo(num6, num10);
            ((Path2D.Float) generalPath2).lineTo(num6, num11);
          }
          else
          {
            ((Path2D.Float) generalPath2).moveTo(num8, num4);
            ((Path2D.Float) generalPath2).lineTo(num7, num4);
            ((Path2D.Float) generalPath2).lineTo(num10, num6);
            ((Path2D.Float) generalPath2).lineTo(num11, num6);
          }
          ((Path2D) generalPath2).closePath();
        }
        else
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath2).moveTo(num4, num8);
            ((Path2D.Float) generalPath2).lineTo(num4, num7);
            ((Path2D.Float) generalPath2).lineTo(num6, num11);
          }
          else
          {
            ((Path2D.Float) generalPath2).moveTo(num8, num4);
            ((Path2D.Float) generalPath2).lineTo(num7, num4);
            ((Path2D.Float) generalPath2).lineTo(num11, num6);
          }
          ((Path2D) generalPath2).closePath();
        }
      }
      else
      {
        num7 = (float) rangeAxis.valueToJava2D(num1 + stackValues1[0], dataArea, rangeAxisEdge);
        float num8 = (float) rangeAxis.valueToJava2D(stackValues1[0], dataArea, rangeAxisEdge);
        float num9 = (float) rangeAxis.valueToJava2D(numArray3[0], dataArea, rangeAxisEdge);
        if (num2 >= 0.0)
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath1).moveTo(num4, num8);
            ((Path2D.Float) generalPath1).lineTo(num4, num7);
            ((Path2D.Float) generalPath1).lineTo(num5, num9);
          }
          else
          {
            ((Path2D.Float) generalPath1).moveTo(num8, num4);
            ((Path2D.Float) generalPath1).lineTo(num7, num4);
            ((Path2D.Float) generalPath1).lineTo(num9, num5);
          }
          ((Path2D.Float) generalPath1).clone();
        }
        else
        {
          double d3 = (num2 + num1) / 2.0 + numArray1[0];
          float num10 = (float) rangeAxis.valueToJava2D(d3, dataArea, rangeAxisEdge);
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath1).moveTo(num4, num7);
            ((Path2D.Float) generalPath1).lineTo(num4, num8);
            ((Path2D.Float) generalPath1).lineTo(num5, num9);
            ((Path2D.Float) generalPath1).lineTo(num5, num10);
          }
          else
          {
            ((Path2D.Float) generalPath1).moveTo(num7, num4);
            ((Path2D.Float) generalPath1).lineTo(num8, num4);
            ((Path2D.Float) generalPath1).lineTo(num9, num5);
            ((Path2D.Float) generalPath1).lineTo(num10, num5);
          }
          ((Path2D) generalPath1).closePath();
        }
        float num11 = (float) rangeAxis.valueToJava2D(numArray4[0], dataArea, rangeAxisEdge);
        if (num3 >= 0.0)
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath2).moveTo(num4, num8);
            ((Path2D.Float) generalPath2).lineTo(num4, num7);
            ((Path2D.Float) generalPath2).lineTo(num6, num11);
          }
          else
          {
            ((Path2D.Float) generalPath2).moveTo(num8, num4);
            ((Path2D.Float) generalPath2).lineTo(num7, num4);
            ((Path2D.Float) generalPath2).lineTo(num11, num6);
          }
          ((Path2D) generalPath2).closePath();
        }
        else
        {
          double d3 = (num1 + num3) / 2.0 + numArray2[0];
          float num10 = (float) rangeAxis.valueToJava2D(d3, dataArea, rangeAxisEdge);
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath2).moveTo(num4, num8);
            ((Path2D.Float) generalPath2).lineTo(num4, num7);
            ((Path2D.Float) generalPath2).lineTo(num6, num10);
            ((Path2D.Float) generalPath2).lineTo(num6, num11);
          }
          else
          {
            ((Path2D.Float) generalPath2).moveTo(num8, num4);
            ((Path2D.Float) generalPath2).lineTo(num7, num4);
            ((Path2D.Float) generalPath2).lineTo(num10, num6);
            ((Path2D.Float) generalPath2).lineTo(num11, num6);
          }
          ((Path2D) generalPath2).closePath();
        }
      }
      Paint itemPaint = this.getItemPaint(series, item);
      if (pass == 0)
      {
        g2.setPaint(itemPaint);
        g2.fill((Shape) generalPath1);
        g2.fill((Shape) generalPath2);
      }
      if (entities == null)
        return;
      GeneralPath generalPath3 = new GeneralPath((Shape) generalPath1);
      ((Path2D) generalPath3).append((Shape) generalPath2, false);
      GeneralPath generalPath4 = generalPath3;
      this.addEntity(entities, (Shape) generalPath4, dataset, series, item, (double) num4, (double) num7);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StackedXYAreaRenderer2) || this.roundXCoordinates != ((StackedXYAreaRenderer2) obj).roundXCoordinates)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 564)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
