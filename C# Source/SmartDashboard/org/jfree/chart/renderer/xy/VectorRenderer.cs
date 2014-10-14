// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.VectorRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class VectorRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private double baseLength;
    private double headLength;

    [HideFromJava]
    static VectorRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 232, (byte) 55, (byte) 176, (byte) 240, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VectorRenderer()
    {
      VectorRenderer vectorRenderer = this;
      this.baseLength = 0.1;
      this.headLength = 0.14;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected VectorRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] VectorRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] VectorRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 53, (byte) 99, (byte) 144, (byte) 106, (byte) 106, (byte) 167, (byte) 107, (byte) 103, (byte) 107, (byte) 106, (byte) 108, (byte) 109, (byte) 105, (byte) 109, (byte) 170, (byte) 109, (byte) 136, (byte) 106, (byte) 234, (byte) 53, (byte) 11, (byte) 235, (byte) 80, (byte) 133, (byte) 107, (byte) 106, (byte) 105, (byte) 109, (byte) 100, (byte) 106, (byte) 234, (byte) 60, (byte) 8, (byte) 235, (byte) 74, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        if (dataset is VectorXYDataset)
        {
          VectorXYDataset vectorXyDataset = (VectorXYDataset) dataset;
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double vectorXvalue = vectorXyDataset.getVectorXValue(index, i2);
              double num1;
              double num2;
              if (vectorXvalue < 0.0)
              {
                num1 = vectorXyDataset.getXValue(index, i2);
                num2 = num1 + vectorXvalue;
              }
              else
              {
                num2 = vectorXyDataset.getXValue(index, i2);
                num1 = num2 + vectorXvalue;
              }
              lower = Math.min(lower, num2);
              upper = Math.max(upper, num1);
            }
          }
        }
        else
        {
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double xvalue = dataset.getXValue(index, i2);
              double num = xvalue;
              lower = Math.min(lower, xvalue);
              upper = Math.max(upper, num);
            }
          }
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 99, (byte) 144, (byte) 106, (byte) 106, (byte) 167, (byte) 107, (byte) 103, (byte) 107, (byte) 106, (byte) 108, (byte) 109, (byte) 105, (byte) 109, (byte) 170, (byte) 109, (byte) 136, (byte) 106, (byte) 234, (byte) 53, (byte) 11, (byte) 235, (byte) 80, (byte) 133, (byte) 107, (byte) 106, (byte) 105, (byte) 109, (byte) 100, (byte) 106, (byte) 234, (byte) 60, (byte) 8, (byte) 235, (byte) 74, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        if (dataset is VectorXYDataset)
        {
          VectorXYDataset vectorXyDataset = (VectorXYDataset) dataset;
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double vectorYvalue = vectorXyDataset.getVectorYValue(index, i2);
              double num1;
              double num2;
              if (vectorYvalue < 0.0)
              {
                num1 = vectorXyDataset.getYValue(index, i2);
                num2 = num1 + vectorYvalue;
              }
              else
              {
                num2 = vectorXyDataset.getYValue(index, i2);
                num1 = num2 + vectorYvalue;
              }
              lower = Math.min(lower, num2);
              upper = Math.max(upper, num1);
            }
          }
        }
        else
        {
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double yvalue = dataset.getYValue(index, i2);
              double num = yvalue;
              lower = Math.min(lower, yvalue);
              upper = Math.max(upper, num);
            }
          }
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 109, (byte) 109, (byte) 102, (byte) 102, (byte) 105, (byte) 114, (byte) 146, (byte) 147, (byte) 147, (byte) 149, (byte) 181, (byte) 105, (byte) 110, (byte) 177, (byte) 143, (byte) 112, (byte) 112, (byte) 168, (byte) 104, (byte) 104, (byte) 117, (byte) 149, (byte) 117, (byte) 149, (byte) 103, (byte) 105, (byte) 151, (byte) 116, (byte) 148, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 103, (byte) 105, (byte) 109, (byte) 109, (byte) 109, (byte) 175, (byte) 109, (byte) 109, (byte) 109, (byte) 141, (byte) 103, (byte) 168, (byte) 98, (byte) 100, (byte) 110, (byte) 100, (byte) 255, (byte) 2, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double num1 = 0.0;
      double num2 = 0.0;
      if (dataset is VectorXYDataset)
      {
        num1 = ((VectorXYDataset) dataset).getVectorXValue(series, item);
        num2 = ((VectorXYDataset) dataset).getVectorYValue(series, item);
      }
      double num3 = domainAxis.valueToJava2D(xvalue, dataArea, plot.getDomainAxisEdge());
      double num4 = rangeAxis.valueToJava2D(yvalue, dataArea, plot.getRangeAxisEdge());
      double num5 = domainAxis.valueToJava2D(xvalue + num1, dataArea, plot.getDomainAxisEdge());
      double num6 = rangeAxis.valueToJava2D(yvalue + num2, dataArea, plot.getRangeAxisEdge());
      PlotOrientation orientation = plot.getOrientation();
      Line2D.Double @double = !orientation.equals((object) PlotOrientation.__\u003C\u003EHORIZONTAL) ? new Line2D.Double(num3, num4, num5, num6) : new Line2D.Double(num4, num3, num6, num5);
      g2.setPaint(this.getItemPaint(series, item));
      g2.setStroke(this.getItemStroke(series, item));
      g2.draw((Shape) @double);
      double num7 = num5 - num3;
      double num8 = num6 - num4;
      double num9 = num3 + (1.0 - this.baseLength) * num7;
      double num10 = num4 + (1.0 - this.baseLength) * num8;
      double num11 = num3 + (1.0 - this.headLength) * num7;
      double num12 = num4 + (1.0 - this.headLength) * num8;
      double num13 = 0.0;
      if (num7 != 0.0)
        num13 = Math.PI / 2.0 - Math.atan(num8 / num7);
      double num14 = 2.0 * Math.cos(num13);
      double num15 = 2.0 * Math.sin(num13);
      double num16 = num11 + num14;
      double num17 = num12 - num15;
      double num18 = num11 - num14;
      double num19 = num12 + num15;
      GeneralPath generalPath = new GeneralPath();
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        ((Path2D.Float) generalPath).moveTo((float) num5, (float) num6);
        ((Path2D.Float) generalPath).lineTo((float) num18, (float) num19);
        ((Path2D.Float) generalPath).lineTo((float) num9, (float) num10);
        ((Path2D.Float) generalPath).lineTo((float) num16, (float) num17);
      }
      else
      {
        ((Path2D.Float) generalPath).moveTo((float) num6, (float) num5);
        ((Path2D.Float) generalPath).lineTo((float) num19, (float) num18);
        ((Path2D.Float) generalPath).lineTo((float) num10, (float) num9);
        ((Path2D.Float) generalPath).lineTo((float) num17, (float) num16);
      }
      ((Path2D) generalPath).closePath();
      g2.draw((Shape) generalPath);
      if (info == null)
        return;
      EntityCollection entityCollection = info.getOwner().getEntityCollection();
      if (entityCollection == null)
        return;
      this.addEntity(entityCollection, (Shape) ((Line2D) @double).getBounds(), dataset, series, item, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is VectorRenderer))
        return false;
      VectorRenderer vectorRenderer = (VectorRenderer) obj;
      if (this.baseLength != vectorRenderer.baseLength || this.headLength != vectorRenderer.headLength)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 343)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
