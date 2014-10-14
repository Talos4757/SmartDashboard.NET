// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYSplineRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
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
  public class XYSplineRenderer : XYLineAndShapeRenderer
  {
    private Vector points;
    private int precision;

    [HideFromJava]
    static XYSplineRenderer()
    {
      XYLineAndShapeRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 104, (byte) 100, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSplineRenderer(int precision)
    {
      XYSplineRenderer xySplineRenderer = this;
      if (precision <= 0)
      {
        string str = "Requires precision > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.precision = precision;
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSplineRenderer()
      : this(5)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYSplineRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 103, (byte) 109, (byte) 114, (byte) 245, (byte) 61, (byte) 230, (byte) 69, (byte) 112, (byte) 105, (byte) 58, (byte) 166})]
    private void solveTridiag([In] float[] obj0, [In] float[] obj1, [In] float[] obj2, [In] float[] obj3, [In] int obj4)
    {
      for (int index = 2; index <= obj4; ++index)
      {
        obj0[index] = obj0[index] / obj1[index - 1];
        obj1[index] = obj1[index] - obj0[index] * obj2[index - 1];
        obj3[index] = obj3[index] - obj0[index] * obj3[index - 1];
      }
      obj3[obj4] = obj3[obj4] / obj1[obj4];
      int index1 = obj4 - 1;
      while (index1 >= 1)
      {
        obj3[index1] = (obj3[index1] - obj2[index1] * obj3[index1 + 1]) / obj1[index1];
        index1 += -1;
      }
    }

    public virtual int getPrecision()
    {
      return this.precision;
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 100, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPrecision(int p)
    {
      if (p <= 0)
      {
        string str = "Requires p > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.precision = p;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 115, (byte) 103, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      XYLineAndShapeRenderer.State state = (XYLineAndShapeRenderer.State) base.initialise(g2, dataArea, plot, data, info);
      state.setProcessVisibleItemsOnly(false);
      this.points = new Vector();
      this.setDrawSeriesLineAsPath(true);
      return (XYItemRendererState) state;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 103, (byte) 167, (byte) 109, (byte) 109, (byte) 110, (byte) 174, (byte) 114, (byte) 255, (byte) 19, (byte) 69, (byte) 111, (byte) 174, (byte) 114, (byte) 136, (byte) 145, (byte) 115, (byte) 122, (byte) 174, (byte) 115, (byte) 122, (byte) 165, (byte) 109, (byte) 105, (byte) 169, (byte) 102, (byte) 134, (byte) 169, (byte) 137, (byte) 105, (byte) 116, (byte) 108, (byte) 236, (byte) 61, (byte) 232, (byte) 70, (byte) 107, (byte) 51, (byte) 168, (byte) 107, (byte) 107, (byte) 139, (byte) 110, (byte) 122, (byte) 115, (byte) 113, (byte) 255, (byte) 20, (byte) 60, (byte) 235, (byte) 71, (byte) 210, (byte) 102, (byte) 102, (byte) 112, (byte) 142, (byte) 112, (byte) 117, (byte) 107, (byte) 191, (byte) 62, (byte) 109, (byte) 112, (byte) 99, (byte) 227, (byte) 55, (byte) 11, (byte) 235, (byte) 80, (byte) 212, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawPrimaryLineAsPath(XYItemRendererState state, Graphics2D g2, XYPlot plot, XYDataset dataset, int pass, int series, int item, ValueAxis domainAxis, ValueAxis rangeAxis, Rectangle2D dataArea)
    {
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge);
      if (!Double.isNaN(num1) && !Double.isNaN(num2))
      {
        XYSplineRenderer.ControlPoint controlPoint = new XYSplineRenderer.ControlPoint(this, plot.getOrientation() != PlotOrientation.__\u003C\u003EHORIZONTAL ? (float) num1 : (float) num2, plot.getOrientation() != PlotOrientation.__\u003C\u003EHORIZONTAL ? (float) num2 : (float) num1);
        if (!this.points.contains((object) controlPoint))
          this.points.add((object) controlPoint);
      }
      if (item != dataset.getItemCount(series) - 1)
        return;
      XYLineAndShapeRenderer.State state1 = (XYLineAndShapeRenderer.State) state;
      if (this.points.size() > 1)
      {
        XYSplineRenderer.ControlPoint controlPoint1 = (XYSplineRenderer.ControlPoint) this.points.get(0);
        ((Path2D.Float) state1.seriesPath).moveTo(controlPoint1.x, controlPoint1.y);
        if (this.points.size() == 2)
        {
          XYSplineRenderer.ControlPoint controlPoint2 = (XYSplineRenderer.ControlPoint) this.points.get(1);
          ((Path2D.Float) state1.seriesPath).lineTo(controlPoint2.x, controlPoint2.y);
        }
        else
        {
          int length = this.points.size();
          float[] numArray1 = new float[length];
          float[] numArray2 = new float[length];
          float[] numArray3 = new float[length];
          float[] numArray4 = new float[length];
          for (int index = 0; index < length; ++index)
          {
            XYSplineRenderer.ControlPoint controlPoint2 = (XYSplineRenderer.ControlPoint) this.points.get(index);
            numArray2[index] = controlPoint2.x;
            numArray1[index] = controlPoint2.y;
          }
          for (int index = 1; index <= length - 1; ++index)
            numArray4[index] = numArray2[index] - numArray2[index - 1];
          float[] numArray5 = new float[length - 1];
          float[] numArray6 = new float[length - 1];
          float[] numArray7 = new float[length - 1];
          for (int index = 1; index <= length - 2; ++index)
          {
            numArray6[index] = (numArray4[index] + numArray4[index + 1]) / 3f;
            numArray7[index] = numArray4[index + 1] / 6f;
            numArray5[index] = numArray4[index] / 6f;
            numArray3[index] = (numArray1[index + 1] - numArray1[index]) / numArray4[index + 1] - (numArray1[index] - numArray1[index - 1]) / numArray4[index];
          }
          this.solveTridiag(numArray5, numArray6, numArray7, numArray3, length - 2);
          float num3 = numArray2[0];
          float num4 = numArray1[0];
          ((Path2D.Float) state1.seriesPath).moveTo(num3, num4);
          for (int index1 = 1; index1 <= length - 1; ++index1)
          {
            for (int index2 = 1; index2 <= this.precision; ++index2)
            {
              float num5 = numArray4[index1] * (float) index2 / (float) this.precision;
              float num6 = numArray4[index1] - num5;
              float num7 = (((float) (-(double) numArray3[index1 - 1] / 6.0) * (num6 + numArray4[index1]) * num5 + numArray1[index1 - 1]) * num6 + ((float) (-(double) numArray3[index1] / 6.0) * (num5 + numArray4[index1]) * num6 + numArray1[index1]) * num5) / numArray4[index1];
              float num8 = numArray2[index1 - 1] + num5;
              ((Path2D.Float) state1.seriesPath).lineTo(num8, num7);
            }
          }
        }
        this.drawFirstPassShape(g2, pass, series, item, (Shape) state1.seriesPath);
      }
      this.points = new Vector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYSplineRenderer) || this.precision != ((XYSplineRenderer) obj).precision)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [InnerClass]
    [SourceFile("XYSplineRenderer.java")]
    [Modifiers]
    internal sealed class ControlPoint : Object
    {
      public float x;
      public float y;
      [Modifiers]
      private XYSplineRenderer this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 111, (byte) 104, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ControlPoint([In] XYSplineRenderer obj0, [In] float obj1, [In] float obj2)
      {
        base.\u002Ector();
        XYSplineRenderer.ControlPoint controlPoint = this;
        this.this\u00240 = obj0;
        this.x = obj1;
        this.y = obj2;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 162})]
      public virtual bool equals([In] object obj0)
      {
        return obj0 == this || obj0 is XYSplineRenderer.ControlPoint && (double) this.x == (double) ((XYSplineRenderer.ControlPoint) obj0).x;
      }
    }
  }
}
