// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYDifferenceRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class XYDifferenceRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, PublicCloneable, Cloneable.__Interface
  {
    private const long serialVersionUID = -8447915602375584857L;
    [NonSerialized]
    private Paint positivePaint;
    [NonSerialized]
    private Paint negativePaint;
    private bool shapesVisible;
    [NonSerialized]
    private Shape legendLine;
    private bool roundXCoordinates;

    [HideFromJava]
    static XYDifferenceRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 101, (byte) 130, (byte) 104, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 127, (byte) 8, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDifferenceRenderer(Paint positivePaint, Paint negativePaint, bool shapes)
    {
      int num = shapes ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      XYDifferenceRenderer differenceRenderer = this;
      if (positivePaint == null)
      {
        string str = "Null 'positivePaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (negativePaint == null)
      {
        string str = "Null 'negativePaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.positivePaint = positivePaint;
        this.negativePaint = negativePaint;
        this.shapesVisible = num != 0;
        this.legendLine = (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0);
        this.roundXCoordinates = false;
      }
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDifferenceRenderer()
      : this((Paint) Color.green, (Paint) Color.red, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYDifferenceRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYDifferenceRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 56, (byte) 106, (byte) 161, (byte) 171, (byte) 107, (byte) 193, (byte) 109, (byte) 193, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 167, (byte) 99, (byte) 106, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 107, (byte) 139, (byte) 99, (byte) 98, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 107, (byte) 171, (byte) 102, (byte) 99, (byte) 99, (byte) 117, (byte) 152, (byte) 108, (byte) 108, (byte) 103, (byte) 135, (byte) 105, (byte) 172, (byte) 170, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 227, (byte) 69, (byte) 110, (byte) 110, (byte) 110, (byte) 174, (byte) 99, (byte) 135, (byte) 109, (byte) 109, (byte) 111, (byte) 143, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 99, (byte) 106, (byte) 106, (byte) 106, (byte) 172, (byte) 109, (byte) 109, (byte) 111, (byte) 143, (byte) 105, (byte) 105, (byte) 105, (byte) 169, (byte) 134, (byte) 102, (byte) 99, (byte) 165, (byte) 134, (byte) 102, (byte) 99, (byte) 197, (byte) 140, (byte) 110, (byte) 100, (byte) 181, (byte) 105, (byte) 170, (byte) 140, (byte) 110, (byte) 100, (byte) 181, (byte) 105, (byte) 169, (byte) 106, (byte) 106, (byte) 106, (byte) 138, (byte) 200, (byte) 110, (byte) 117, (byte) 109, (byte) 109, (byte) 105, (byte) 137, (byte) 100, (byte) 105, (byte) 169, (byte) 108, (byte) 140, (byte) 111, (byte) 111, (byte) 105, (byte) 201, (byte) 155, (byte) 109, (byte) 109, (byte) 105, (byte) 137, (byte) 100, (byte) 105, (byte) 170, (byte) 108, (byte) 140, (byte) 111, (byte) 111, (byte) 105, (byte) 201, (byte) 99, (byte) 131, (byte) 99, (byte) 99, (byte) 131, (byte) 99, (byte) 163, (byte) 140, (byte) 108, (byte) 232, (byte) 69, (byte) 105, (byte) 137, (byte) 99, (byte) 99, (byte) 232, (byte) 69, (byte) 218, (byte) 104, (byte) 168, (byte) 148, (byte) 212, (byte) 155, (byte) 200, (byte) 135, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 135, (byte) 163, (byte) 146, (byte) 146, (byte) 242, (byte) 69, (byte) 104, (byte) 168, (byte) 191, (byte) 17, (byte) 110, (byte) 142, (byte) 105, (byte) 105, (byte) 99, (byte) 146, (byte) 210, (byte) 100, (byte) 100, (byte) 100, (byte) 228, (byte) 69, (byte) 167, (byte) 105, (byte) 169, (byte) 106, (byte) 170, (byte) 102, (byte) 103, (byte) 105, (byte) 170, (byte) 146, (byte) 212, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 167, (byte) 106, (byte) 100, (byte) 100, (byte) 100, (byte) 164, (byte) 106, (byte) 202, (byte) 102, (byte) 102, (byte) 165, (byte) 195, (byte) 102, (byte) 102, (byte) 165, (byte) 163, (byte) 106, (byte) 138, (byte) 165, (byte) 144, (byte) 110, (byte) 100, (byte) 213, (byte) 144, (byte) 110, (byte) 100, (byte) 245, (byte) 70, (byte) 145, (byte) 145, (byte) 145, (byte) 209, (byte) 105, (byte) 105, (byte) 105, (byte) 202, (byte) 105, (byte) 169, (byte) 102, (byte) 103, (byte) 105, (byte) 170, (byte) 146, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemPass0(Graphics2D x_graphics, Rectangle2D x_dataArea, PlotRenderingInfo x_info, XYPlot x_plot, ValueAxis x_domainAxis, ValueAxis x_rangeAxis, XYDataset x_dataset, int x_series, int x_item, CrosshairState x_crosshairState)
    {
      if (0 != x_series || 0 != x_item)
        return;
      int num1 = 1 == x_dataset.getSeriesCount() ? 1 : 0;
      if (this.isEitherSeriesDegenerate(x_dataset, num1 != 0) || num1 == 0 && this.areSeriesDisjoint(x_dataset))
        return;
      LinkedList linkedList1 = new LinkedList();
      LinkedList linkedList2 = new LinkedList();
      LinkedList linkedList3 = new LinkedList();
      LinkedList linkedList4 = new LinkedList();
      LinkedList linkedList5 = new LinkedList();
      LinkedList linkedList6 = new LinkedList();
      int i2_1 = 0;
      int itemCount = x_dataset.getItemCount(0);
      Double double1 = (Double) null;
      Double double2 = (Double) null;
      Double double3 = (Double) null;
      Double double4 = (Double) null;
      double num2 = double.NegativeInfinity;
      double num3 = double.PositiveInfinity;
      int i2_2 = 0;
      Double double5 = (Double) null;
      Double double6 = (Double) null;
      Double double7 = (Double) null;
      Double double8 = (Double) null;
      double num4 = double.NegativeInfinity;
      double num5 = double.PositiveInfinity;
      int num6;
      if (num1 != 0)
      {
        i2_2 = 0;
        num6 = 2;
        Double.__\u003Cclinit\u003E();
        double5 = new Double(x_dataset.getXValue(0, 0));
        Double.__\u003Cclinit\u003E();
        double6 = new Double(x_dataset.getXValue(0, itemCount - 1));
        double7 = new Double(0.0);
        double8 = new Double(0.0);
        num4 = 0.0;
        num5 = 0.0;
        linkedList3.add((object) double5);
        linkedList4.add((object) double7);
      }
      else
        num6 = x_dataset.getItemCount(1);
      int num7 = 0;
      int num8 = 1;
      int num9 = 0;
      int num10 = 0;
      int num11 = 0;
      int num12 = 1;
      int num13 = 0;
      int num14 = 0;
      int num15 = 0;
      double num16 = 0.0;
      double num17 = 0.0;
      double num18 = 0.0;
      double num19 = 0.0;
      double num20 = 0.0;
      double num21 = 0.0;
      double num22 = 0.0;
      double num23 = 0.0;
      int num24 = 0;
      while (num24 == 0)
      {
        num16 = x_dataset.getXValue(0, i2_1);
        num17 = x_dataset.getYValue(0, i2_1);
        num18 = x_dataset.getXValue(0, i2_1 + 1);
        num19 = x_dataset.getYValue(0, i2_1 + 1);
        double1 = new Double(num16);
        double3 = new Double(num17);
        double2 = new Double(num18);
        double4 = new Double(num19);
        if (num1 != 0)
        {
          num20 = double5.doubleValue();
          num21 = double7.doubleValue();
          num22 = double6.doubleValue();
          num23 = double8.doubleValue();
        }
        else
        {
          num20 = x_dataset.getXValue(1, i2_2);
          num21 = x_dataset.getYValue(1, i2_2);
          num22 = x_dataset.getXValue(1, i2_2 + 1);
          num23 = x_dataset.getYValue(1, i2_2 + 1);
          double5 = new Double(num20);
          double7 = new Double(num21);
          double6 = new Double(num22);
          double8 = new Double(num23);
        }
        if (num18 <= num20)
        {
          ++i2_1;
          num10 = 1;
        }
        else if (num22 <= num16)
        {
          ++i2_2;
          num14 = 1;
        }
        else
        {
          if (num20 < num16 && num16 < num22)
          {
            double num25 = (num23 - num21) / (num22 - num20);
            double5 = double1;
            double7 = new Double(num25 * num16 + (num21 - num25 * num20));
            linkedList3.add((object) double5);
            linkedList4.add((object) double7);
          }
          if (num16 < num20 && num20 < num18)
          {
            double num25 = (num19 - num17) / (num18 - num16);
            double1 = double5;
            double3 = new Double(num25 * num20 + (num17 - num25 * num16));
            linkedList1.add((object) double1);
            linkedList2.add((object) double3);
          }
          num2 = double3.doubleValue();
          num3 = double3.doubleValue();
          num4 = double7.doubleValue();
          num5 = double7.doubleValue();
          num24 = 1;
        }
      }
      for (; num7 == 0 && num11 == 0; num11 = i2_2 == num6 - 1 ? 1 : 0)
      {
        if (num7 == 0 && num10 == 0 && num8 != 0)
        {
          num16 = x_dataset.getXValue(0, i2_1);
          num17 = x_dataset.getYValue(0, i2_1);
          double1 = new Double(num16);
          double3 = new Double(num17);
          if (num9 == 0)
          {
            linkedList1.add((object) double1);
            linkedList2.add((object) double3);
          }
          num2 = Math.max(num2, num17);
          num3 = Math.min(num3, num17);
          num18 = x_dataset.getXValue(0, i2_1 + 1);
          num19 = x_dataset.getYValue(0, i2_1 + 1);
          double2 = new Double(num18);
          double4 = new Double(num19);
        }
        if (num1 == 0 && num11 == 0 && (num14 == 0 && num12 != 0))
        {
          num20 = x_dataset.getXValue(1, i2_2);
          num21 = x_dataset.getYValue(1, i2_2);
          double5 = new Double(num20);
          double7 = new Double(num21);
          if (num13 == 0)
          {
            linkedList3.add((object) double5);
            linkedList4.add((object) double7);
          }
          num4 = Math.max(num4, num21);
          num5 = Math.min(num5, num21);
          num22 = x_dataset.getXValue(1, i2_2 + 1);
          num23 = x_dataset.getYValue(1, i2_2 + 1);
          double6 = new Double(num22);
          double8 = new Double(num23);
        }
        num10 = 0;
        num14 = 0;
        Double double9 = (Double) null;
        Double double10 = (Double) null;
        int num25 = 0;
        num9 = 0;
        num13 = 0;
        if (num18 == num22 && num19 == num23)
        {
          if (num16 == num20 && num17 == num21)
          {
            num15 = 1;
          }
          else
          {
            double9 = new Double(num18);
            double10 = new Double(num19);
            num25 = 1;
            num9 = 1;
            num13 = 1;
          }
        }
        else
        {
          double num26 = (num23 - num21) * (num18 - num16) - (num22 - num20) * (num19 - num17);
          double num27 = num17 - num21;
          double num28 = num16 - num20;
          double num29 = (num22 - num20) * num27 - (num23 - num21) * num28;
          double num30 = (num18 - num16) * num27 - (num19 - num17) * num28;
          if (0.0 == num29 && 0.0 == num30 && 0.0 == num26)
          {
            num15 = 1;
          }
          else
          {
            if (num15 != 0)
            {
              linkedList1.clear();
              linkedList2.clear();
              linkedList3.clear();
              linkedList4.clear();
              linkedList5.clear();
              linkedList6.clear();
              num15 = 0;
              int num31 = num20 > num16 || num16 > num22 ? 0 : 1;
              linkedList5.add(num31 == 0 ? (object) double5 : (object) double1);
              linkedList6.add(num31 == 0 ? (object) double7 : (object) double3);
            }
            double num32 = num29 / num26;
            double num33 = num30 / num26;
            if (0.0 < num32 && num32 <= 1.0 && (0.0 < num33 && num33 <= 1.0))
            {
              double num31 = num16 + num32 * (num18 - num16);
              double num34 = num17 + num32 * (num19 - num17);
              double9 = new Double(num31);
              double10 = new Double(num34);
              num25 = 1;
              num9 = num31 != num18 || num34 != num19 ? 0 : 1;
              num13 = num31 != num22 || num34 != num23 ? 0 : 1;
              double1 = double9;
              double3 = double10;
              double5 = double9;
              double7 = double10;
            }
          }
        }
        if (num25 != 0)
        {
          linkedList5.addAll((Collection) linkedList1);
          linkedList6.addAll((Collection) linkedList2);
          linkedList5.add((object) double9);
          linkedList6.add((object) double10);
          Collections.reverse((List) linkedList3);
          Collections.reverse((List) linkedList4);
          linkedList5.addAll((Collection) linkedList3);
          linkedList6.addAll((Collection) linkedList4);
          int num26 = num4 > num2 || num5 > num3 ? 0 : 1;
          this.createPolygon(x_graphics, x_dataArea, x_plot, x_domainAxis, x_rangeAxis, num26 != 0, linkedList5, linkedList6);
          linkedList1.clear();
          linkedList2.clear();
          linkedList3.clear();
          linkedList4.clear();
          linkedList5.clear();
          linkedList6.clear();
          double num27 = double10.doubleValue();
          num2 = num27;
          num4 = num27;
          num3 = num27;
          num5 = num27;
          linkedList5.add((object) double9);
          linkedList6.add((object) double10);
        }
        if (num18 <= num22)
        {
          ++i2_1;
          num8 = 1;
        }
        else
          num8 = 0;
        if (num22 <= num18)
        {
          ++i2_2;
          num12 = 1;
        }
        else
          num12 = 0;
        num7 = i2_1 == itemCount - 1 ? 1 : 0;
      }
      if (num7 != 0 && num20 < num18 && num18 < num22)
      {
        double num25 = (num23 - num21) / (num22 - num20);
        double6 = double2;
        double8 = new Double(num25 * num18 + (num21 - num25 * num20));
      }
      if (num11 != 0 && num16 < num22 && num22 < num18)
      {
        double num25 = (num19 - num17) / (num18 - num16);
        double2 = double6;
        double4 = new Double(num25 * num22 + (num17 - num25 * num16));
      }
      double num35 = Math.max(num2, double4.doubleValue());
      double num36 = Math.max(num4, double8.doubleValue());
      double num37 = Math.min(num3, double4.doubleValue());
      double num38 = Math.min(num5, double8.doubleValue());
      linkedList1.add((object) double2);
      linkedList2.add((object) double4);
      linkedList3.add((object) double6);
      linkedList4.add((object) double8);
      linkedList5.addAll((Collection) linkedList1);
      linkedList6.addAll((Collection) linkedList2);
      Collections.reverse((List) linkedList3);
      Collections.reverse((List) linkedList4);
      linkedList5.addAll((Collection) linkedList3);
      linkedList6.addAll((Collection) linkedList4);
      int num39 = num36 > num35 || num38 > num37 ? 0 : 1;
      this.createPolygon(x_graphics, x_dataArea, x_plot, x_domainAxis, x_rangeAxis, num39 != 0, linkedList5, linkedList6);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 245, (byte) 98, (byte) 98, (byte) 100, (byte) 172, (byte) 107, (byte) 107, (byte) 103, (byte) 135, (byte) 105, (byte) 105, (byte) 137, (byte) 110, (byte) 110, (byte) 143, (byte) 175, (byte) 104, (byte) 108, (byte) 105, (byte) 207, (byte) 173, (byte) 106, (byte) 112, (byte) 136, (byte) 195, (byte) 103, (byte) 105, (byte) 191, (byte) 17, (byte) 99, (byte) 140, (byte) 101, (byte) 175, (byte) 99, (byte) 104, (byte) 101, (byte) 175, (byte) 159, (byte) 26, (byte) 200, (byte) 108, (byte) 220, (byte) 107, (byte) 107, (byte) 182, (byte) 101, (byte) 161, (byte) 154, (byte) 186, (byte) 99, (byte) 105, (byte) 145, (byte) 105, (byte) 175, (byte) 111, (byte) 112, (byte) 112, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemPass1(Graphics2D x_graphics, Rectangle2D x_dataArea, PlotRenderingInfo x_info, XYPlot x_plot, ValueAxis x_domainAxis, ValueAxis x_rangeAxis, XYDataset x_dataset, int x_series, int x_item, CrosshairState x_crosshairState)
    {
      object obj1 = (object) null;
      EntityCollection entityCollection = (EntityCollection) null;
      if (null != x_info)
        entityCollection = x_info.getOwner().getEntityCollection();
      Paint itemPaint = this.getItemPaint(x_series, x_item);
      Stroke itemStroke = this.getItemStroke(x_series, x_item);
      x_graphics.setPaint(itemPaint);
      x_graphics.setStroke(itemStroke);
      PlotOrientation orientation = x_plot.getOrientation();
      RectangleEdge domainAxisEdge = x_plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = x_plot.getRangeAxisEdge();
      double xvalue = x_dataset.getXValue(x_series, x_item);
      double yvalue = x_dataset.getYValue(x_series, x_item);
      double num1 = x_domainAxis.valueToJava2D(xvalue, x_dataArea, domainAxisEdge);
      double num2 = x_rangeAxis.valueToJava2D(yvalue, x_dataArea, rangeAxisEdge);
      if (this.getShapesVisible())
      {
        Shape itemShape = this.getItemShape(x_series, x_item);
        Shape shape = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? ShapeUtilities.createTranslatedShape(itemShape, num1, num2) : ShapeUtilities.createTranslatedShape(itemShape, num2, num1);
        if (shape.intersects(x_dataArea))
        {
          x_graphics.setPaint(this.getItemPaint(x_series, x_item));
          x_graphics.fill(shape);
        }
        obj1 = (object) shape;
      }
      if (null != entityCollection)
      {
        if (null == (Shape) obj1)
          obj1 = (object) new Rectangle2D.Double(num1 - 2.0, num2 - 2.0, 4.0, 4.0);
        string str1 = (string) null;
        XYToolTipGenerator toolTipGenerator = this.getToolTipGenerator(x_series, x_item);
        if (null != toolTipGenerator)
          str1 = toolTipGenerator.generateToolTip(x_dataset, x_series, x_item);
        string str2 = (string) null;
        XYURLGenerator urlGenerator = this.getURLGenerator();
        if (null != urlGenerator)
          str2 = urlGenerator.generateURL(x_dataset, x_series, x_item);
        object obj2 = obj1;
        XYDataset xyDataset1 = x_dataset;
        int num3 = x_series;
        int num4 = x_item;
        string str3 = str1;
        string str4 = str2;
        string str5 = str3;
        int num5 = num4;
        int num6 = num3;
        XYDataset xyDataset2 = xyDataset1;
        Shape area;
        if (obj2 != null)
        {
          Shape shape = obj2 as Shape;
          if (shape == null)
            throw new IncompatibleClassChangeError();
          area = shape;
        }
        else
          area = (Shape) null;
        XYDataset dataset = xyDataset2;
        int series = num6;
        int num7 = num5;
        string toolTipText = str5;
        string urlText = str4;
        XYItemEntity xyItemEntity = new XYItemEntity(area, dataset, series, num7, toolTipText, urlText);
        entityCollection.add((ChartEntity) xyItemEntity);
      }
      if (this.isItemLabelVisible(x_series, x_item))
        this.drawItemLabel(x_graphics, orientation, x_dataset, x_series, x_item, num1, num2, num2 < 0.0);
      int domainAxisIndex = x_plot.getDomainAxisIndex(x_domainAxis);
      int rangeAxisIndex = x_plot.getRangeAxisIndex(x_rangeAxis);
      this.updateCrosshairValues(x_crosshairState, xvalue, yvalue, domainAxisIndex, rangeAxisIndex, num1, num2, orientation);
      if (0 == x_item)
        return;
      double num8 = x_domainAxis.valueToJava2D(x_dataset.getXValue(x_series, x_item - 1), x_dataArea, domainAxisEdge);
      double num9 = x_rangeAxis.valueToJava2D(x_dataset.getYValue(x_series, x_item - 1), x_dataArea, rangeAxisEdge);
      Line2D.Double @double = (Line2D.Double) null;
      if (PlotOrientation.__\u003C\u003EHORIZONTAL == orientation)
        @double = new Line2D.Double(num2, num1, num9, num8);
      else if (PlotOrientation.__\u003C\u003EVERTICAL == orientation)
        @double = new Line2D.Double(num1, num2, num8, num9);
      if (null == @double || !((Line2D) @double).intersects(x_dataArea))
        return;
      x_graphics.setPaint(this.getItemPaint(x_series, x_item));
      x_graphics.setStroke(this.getItemStroke(x_series, x_item));
      x_graphics.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 153, (byte) 98, (byte) 99, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isEitherSeriesDegenerate([In] XYDataset obj0, [In] bool obj1)
    {
      if (obj1)
        return obj0.getItemCount(0) < 2;
      return obj0.getItemCount(0) < 2 || obj0.getItemCount(1) < 2;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 117, (byte) 104, (byte) 106, (byte) 140, (byte) 104, (byte) 107, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool areSeriesDisjoint([In] XYDataset obj0)
    {
      int itemCount1 = obj0.getItemCount(0);
      double xvalue1 = obj0.getXValue(0, 0);
      double xvalue2 = obj0.getXValue(0, itemCount1 - 1);
      int itemCount2 = obj0.getItemCount(1);
      double xvalue3 = obj0.getXValue(1, 0);
      double xvalue4 = obj0.getXValue(1, itemCount2 - 1);
      return xvalue2 < xvalue3 || xvalue4 < xvalue1;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 139, (byte) 99, (byte) 103, (byte) 103, (byte) 135, (byte) 105, (byte) 137, (byte) 135, (byte) 107, (byte) 186, (byte) 104, (byte) 170, (byte) 218, (byte) 109, (byte) 109, (byte) 187, (byte) 104, (byte) 170, (byte) 187, (byte) 237, (byte) 53, (byte) 235, (byte) 77, (byte) 103, (byte) 133, (byte) 186, (byte) 104, (byte) 170, (byte) 218, (byte) 109, (byte) 109, (byte) 187, (byte) 104, (byte) 170, (byte) 187, (byte) 237, (byte) 53, (byte) 235, (byte) 77, (byte) 167, (byte) 106, (byte) 151, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void createPolygon([In] Graphics2D obj0, [In] Rectangle2D obj1, [In] XYPlot obj2, [In] ValueAxis obj3, [In] ValueAxis obj4, [In] bool obj5, [In] LinkedList obj6, [In] LinkedList obj7)
    {
      int num1 = obj5 ? 1 : 0;
      PlotOrientation orientation = obj2.getOrientation();
      RectangleEdge domainAxisEdge = obj2.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = obj2.getRangeAxisEdge();
      object[] objArray1 = obj6.toArray();
      object[] objArray2 = obj7.toArray();
      GeneralPath generalPath = new GeneralPath();
      if (PlotOrientation.__\u003C\u003EVERTICAL == orientation)
      {
        double num2 = obj3.valueToJava2D(((Double) objArray1[0]).doubleValue(), obj1, domainAxisEdge);
        if (this.roundXCoordinates)
          num2 = Math.rint(num2);
        double num3 = obj4.valueToJava2D(((Double) objArray2[0]).doubleValue(), obj1, rangeAxisEdge);
        ((Path2D.Float) generalPath).moveTo((float) num2, (float) num3);
        for (int index = 1; index < objArray1.Length; ++index)
        {
          double num4 = obj3.valueToJava2D(((Double) objArray1[index]).doubleValue(), obj1, domainAxisEdge);
          if (this.roundXCoordinates)
            num4 = Math.rint(num4);
          double num5 = obj4.valueToJava2D(((Double) objArray2[index]).doubleValue(), obj1, rangeAxisEdge);
          ((Path2D.Float) generalPath).lineTo((float) num4, (float) num5);
        }
        ((Path2D) generalPath).closePath();
      }
      else
      {
        double num2 = obj3.valueToJava2D(((Double) objArray1[0]).doubleValue(), obj1, domainAxisEdge);
        if (this.roundXCoordinates)
          num2 = Math.rint(num2);
        double num3 = obj4.valueToJava2D(((Double) objArray2[0]).doubleValue(), obj1, rangeAxisEdge);
        ((Path2D.Float) generalPath).moveTo((float) num3, (float) num2);
        for (int index = 1; index < objArray1.Length; ++index)
        {
          double num4 = obj3.valueToJava2D(((Double) objArray1[index]).doubleValue(), obj1, domainAxisEdge);
          if (this.roundXCoordinates)
            num4 = Math.rint(num4);
          double num5 = obj4.valueToJava2D(((Double) objArray2[index]).doubleValue(), obj1, rangeAxisEdge);
          ((Path2D.Float) generalPath).lineTo((float) num5, (float) num4);
        }
        ((Path2D) generalPath).closePath();
      }
      if (!((Path2D) generalPath).intersects(obj1))
        return;
      obj0.setPaint(num1 == 0 ? this.getNegativePaint() : this.getPositivePaint());
      obj0.fill((Shape) generalPath);
    }

    public virtual bool getShapesVisible()
    {
      return this.shapesVisible;
    }

    public virtual Paint getPositivePaint()
    {
      return this.positivePaint;
    }

    public virtual Paint getNegativePaint()
    {
      return this.negativePaint;
    }

    public virtual Shape getLegendLine()
    {
      return this.legendLine;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositivePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.positivePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.negativePaint = paint;
        this.notifyListeners(new RendererChangeEvent((object) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 78, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(bool flag)
    {
      this.shapesVisible = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendLine(Shape line)
    {
      if (line == null)
      {
        string str = "Null 'line' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendLine = line;
        this.fireChangeEvent();
      }
    }

    public virtual bool getRoundXCoordinates()
    {
      return this.roundXCoordinates;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 64, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRoundXCoordinates(bool round)
    {
      this.roundXCoordinates = round;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 142, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      XYItemRendererState itemRendererState = base.initialise(g2, dataArea, plot, data, info);
      itemRendererState.setProcessVisibleItemsOnly(false);
      return itemRendererState;
    }

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 18, (byte) 100, (byte) 186, (byte) 101, (byte) 218})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (pass == 0)
      {
        this.drawItemPass0(g2, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState);
      }
      else
      {
        if (pass != 1)
          return;
        this.drawItemPass1(g2, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState);
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 238, (byte) 98, (byte) 103, (byte) 102, (byte) 104, (byte) 102, (byte) 109, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 207, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 104, (byte) 147, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 231, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      LegendItem legendItem = (LegendItem) null;
      XYPlot plot = this.getPlot();
      if (plot != null)
      {
        XYDataset dataset = plot.getDataset(datasetIndex);
        if (dataset != null && this.getItemVisible(series, 0))
        {
          string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
          string description = label;
          string toolTipText = (string) null;
          if (this.getLegendItemToolTipGenerator() != null)
            toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
          string urlText = (string) null;
          if (this.getLegendItemURLGenerator() != null)
            urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
          Paint linePaint = this.lookupSeriesPaint(series);
          Stroke lineStroke = this.lookupSeriesStroke(series);
          Shape legendLine = this.getLegendLine();
          legendItem = new LegendItem(label, description, toolTipText, urlText, legendLine, lineStroke, linePaint);
          legendItem.setLabelFont(this.lookupLegendTextFont(series));
          Paint paint = this.lookupLegendTextPaint(series);
          if (paint != null)
            legendItem.setLabelPaint(paint);
          legendItem.setDataset((Dataset) dataset);
          legendItem.setDatasetIndex(datasetIndex);
          legendItem.setSeriesKey(dataset.getSeriesKey(series));
          legendItem.setSeriesIndex(series);
        }
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 33, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYDifferenceRenderer) || !base.equals(obj))
        return false;
      XYDifferenceRenderer differenceRenderer = (XYDifferenceRenderer) obj;
      return PaintUtilities.equal(this.positivePaint, differenceRenderer.positivePaint) && PaintUtilities.equal(this.negativePaint, differenceRenderer.negativePaint) && (this.shapesVisible == differenceRenderer.shapesVisible && ShapeUtilities.equal(this.legendLine, differenceRenderer.legendLine)) && this.roundXCoordinates == differenceRenderer.roundXCoordinates;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 69, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYDifferenceRenderer differenceRenderer = (XYDifferenceRenderer) base.clone();
      differenceRenderer.legendLine = ShapeUtilities.clone(this.legendLine);
      return (object) differenceRenderer;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 82, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.positivePaint, obj0);
      SerialUtilities.writePaint(this.negativePaint, obj0);
      SerialUtilities.writeShape(this.legendLine, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 98, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.positivePaint = SerialUtilities.readPaint(obj0);
      this.negativePaint = SerialUtilities.readPaint(obj0);
      this.legendLine = SerialUtilities.readShape(obj0);
    }
  }
}
