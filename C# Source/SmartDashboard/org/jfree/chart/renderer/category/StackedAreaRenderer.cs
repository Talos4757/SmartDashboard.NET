// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.StackedAreaRenderer
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
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StackedAreaRenderer : AreaRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -3595635038460823663L;
    private bool renderAsPercentages;

    [HideFromJava]
    static StackedAreaRenderer()
    {
      AreaRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedAreaRenderer()
      : this(false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 112, (byte) 130, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedAreaRenderer(bool renderAsPercentages)
    {
      int num = renderAsPercentages ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      StackedAreaRenderer stackedAreaRenderer = this;
      this.renderAsPercentages = num != 0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedAreaRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StackedAreaRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StackedAreaRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 103, (byte) 102, (byte) 104, (byte) 171, (byte) 105, (byte) 108, (byte) 102, (byte) 106, (byte) 100, (byte) 105, (byte) 104, (byte) 165, (byte) 104, (byte) 104, (byte) 181, (byte) 243, (byte) 49, (byte) 233, (byte) 84})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double[] getStackValues(CategoryDataset dataset, int series, int index, int[] validRows)
    {
      double[] numArray1 = new double[2];
      double num1 = 0.0;
      if (this.renderAsPercentages)
        num1 = DataUtilities.calculateColumnTotal((Values2D) dataset, index, validRows);
      for (int index1 = 0; index1 < series; ++index1)
      {
        if (this.isSeriesVisible(index1))
        {
          double num2 = 0.0;
          Number number = dataset.getValue(index1, index);
          if (number != null)
          {
            num2 = number.doubleValue();
            if (this.renderAsPercentages)
              num2 /= num1;
          }
          if (!Double.isNaN(num2))
          {
            if (num2 >= 0.0)
            {
              double[] numArray2 = numArray1;
              int index2 = 1;
              double[] numArray3 = numArray2;
              numArray3[index2] = numArray3[index2] + num2;
            }
            else
            {
              double[] numArray2 = numArray1;
              int index2 = 0;
              double[] numArray3 = numArray2;
              numArray3[index2] = numArray3[index2] + num2;
            }
          }
        }
      }
      return numArray1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 88, (byte) 103, (byte) 117, (byte) 117})]
    private double[] averageStackValues([In] double[] obj0, [In] double[] obj1)
    {
      return new double[2]
      {
        (obj0[0] + obj1[0]) / 2.0,
        (obj0[1] + obj1[1]) / 2.0
      };
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 105, (byte) 103, (byte) 116, (byte) 170, (byte) 149, (byte) 116, (byte) 170, (byte) 149})]
    private double[] adjustedStackValues([In] double[] obj0, [In] double[] obj1)
    {
      return new double[2]
      {
        obj0[0] == 0.0 || obj1[0] == 0.0 ? 0.0 : (obj0[0] + obj1[0]) / 2.0,
        obj0[1] == 0.0 || obj1[1] == 0.0 ? 0.0 : (obj0[1] + obj1[1]) / 2.0
      };
    }

    public virtual bool getRenderAsPercentages()
    {
      return this.renderAsPercentages;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 105, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderAsPercentages(bool asPercentages)
    {
      this.renderAsPercentages = asPercentages;
      this.fireChangeEvent();
    }

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 99, (byte) 130, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      if (this.renderAsPercentages)
        return new Range(0.0, 1.0);
      else
        return DatasetUtilities.findStackedRangeBounds(dataset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 106, (byte) 193, (byte) 98, (byte) 135, (byte) 102, (byte) 108, (byte) 99, (byte) 104, (byte) 104, (byte) 145, (byte) 165, (byte) 244, (byte) 71, (byte) 250, (byte) 70, (byte) 103, (byte) 116, (byte) 99, (byte) 105, (byte) 104, (byte) 154, (byte) 168, (byte) 220, (byte) 186, (byte) 105, (byte) 103, (byte) 119, (byte) 99, (byte) 105, (byte) 104, (byte) 189, (byte) 168, (byte) 191, (byte) 0, (byte) 218, (byte) 100, (byte) 132, (byte) 108, (byte) 108, (byte) 108, (byte) 204, (byte) 137, (byte) 103, (byte) 103, (byte) 107, (byte) 147, (byte) 145, (byte) 209, (byte) 108, (byte) 118, (byte) 143, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 103, (byte) 130, (byte) 108, (byte) 108, (byte) 108, (byte) 167, (byte) 177, (byte) 108, (byte) 118, (byte) 143, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 103, (byte) 130, (byte) 108, (byte) 108, (byte) 108, (byte) 135, (byte) 133, (byte) 147, (byte) 145, (byte) 209, (byte) 105, (byte) 108, (byte) 108, (byte) 108, (byte) 173, (byte) 118, (byte) 143, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 135, (byte) 209, (byte) 105, (byte) 108, (byte) 108, (byte) 108, (byte) 172, (byte) 118, (byte) 143, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 199, (byte) 100, (byte) 108, (byte) 104, (byte) 104, (byte) 168, (byte) 99, (byte) 105, (byte) 106, (byte) 100, (byte) 143, (byte) 98, (byte) 101, (byte) 223, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.isSeriesVisible(row))
        return;
      EntityCollection entityCollection = state.getEntityCollection();
      double num1 = 0.0;
      Number number1 = dataset.getValue(row, column);
      if (number1 != null)
      {
        num1 = number1.doubleValue();
        if (this.renderAsPercentages)
        {
          double num2 = DataUtilities.calculateColumnTotal((Values2D) dataset, column, state.getVisibleSeriesArray());
          num1 /= num2;
        }
      }
      double[] stackValues1 = this.getStackValues(dataset, row, column, state.getVisibleSeriesArray());
      double categoryMiddle = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double num3 = 0.0;
      Number number2 = dataset.getValue(row, Math.max(column - 1, 0));
      if (number2 != null)
      {
        num3 = number2.doubleValue();
        if (this.renderAsPercentages)
        {
          double num2 = DataUtilities.calculateColumnTotal((Values2D) dataset, Math.max(column - 1, 0), state.getVisibleSeriesArray());
          num3 /= num2;
        }
      }
      double[] stackValues2 = this.getStackValues(dataset, row, Math.max(column - 1, 0), state.getVisibleSeriesArray());
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      int columnCount = dataset.getColumnCount();
      double num4 = 0.0;
      Number number3 = dataset.getValue(row, Math.min(column + 1, columnCount - 1));
      if (number3 != null)
      {
        num4 = number3.doubleValue();
        if (this.renderAsPercentages)
        {
          double num2 = DataUtilities.calculateColumnTotal((Values2D) dataset, Math.min(column + 1, columnCount - 1), state.getVisibleSeriesArray());
          num4 /= num2;
        }
      }
      double[] stackValues3 = this.getStackValues(dataset, row, Math.min(column + 1, columnCount - 1), state.getVisibleSeriesArray());
      double categoryEnd = domainAxis.getCategoryEnd(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double num5 = categoryStart;
      double num6 = categoryEnd;
      double[] numArray1 = this.averageStackValues(stackValues2, stackValues1);
      double[] numArray2 = this.averageStackValues(stackValues1, stackValues3);
      double[] numArray3 = this.adjustedStackValues(stackValues2, stackValues1);
      double[] numArray4 = this.adjustedStackValues(stackValues1, stackValues3);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      GeneralPath generalPath1 = new GeneralPath();
      GeneralPath generalPath2 = new GeneralPath();
      float num7;
      if (num1 >= 0.0)
      {
        num7 = (float) rangeAxis.valueToJava2D(num1 + stackValues1[1], dataArea, rangeAxisEdge);
        float num2 = (float) rangeAxis.valueToJava2D(stackValues1[1], dataArea, rangeAxisEdge);
        float num8 = (float) rangeAxis.valueToJava2D(numArray3[1], dataArea, rangeAxisEdge);
        if (num3 >= 0.0)
        {
          double d = (num3 + num1) / 2.0 + numArray1[1];
          float num9 = (float) rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((Path2D.Float) generalPath1).moveTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath1).lineTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num8);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num9);
          ((Path2D) generalPath1).closePath();
        }
        else
        {
          ((Path2D.Float) generalPath1).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath1).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num8);
          ((Path2D) generalPath1).closePath();
        }
        float num10 = (float) rangeAxis.valueToJava2D(numArray4[1], dataArea, rangeAxisEdge);
        if (num4 >= 0.0)
        {
          double d = (num1 + num4) / 2.0 + numArray2[1];
          float num9 = (float) rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((Path2D.Float) generalPath2).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath2).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num9);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num10);
          ((Path2D) generalPath2).closePath();
        }
        else
        {
          ((Path2D.Float) generalPath2).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath2).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num10);
          ((Path2D) generalPath2).closePath();
        }
      }
      else
      {
        num7 = (float) rangeAxis.valueToJava2D(num1 + stackValues1[0], dataArea, rangeAxisEdge);
        float num2 = (float) rangeAxis.valueToJava2D(stackValues1[0], dataArea, rangeAxisEdge);
        float num8 = (float) rangeAxis.valueToJava2D(numArray3[0], dataArea, rangeAxisEdge);
        if (num3 >= 0.0)
        {
          ((Path2D.Float) generalPath1).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath1).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num8);
          ((Path2D.Float) generalPath1).clone();
        }
        else
        {
          double d = (num3 + num1) / 2.0 + numArray1[0];
          float num9 = (float) rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((Path2D.Float) generalPath1).moveTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath1).lineTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num8);
          ((Path2D.Float) generalPath1).lineTo((float) num5, num9);
          ((Path2D) generalPath1).closePath();
        }
        float num10 = (float) rangeAxis.valueToJava2D(numArray4[0], dataArea, rangeAxisEdge);
        if (num4 >= 0.0)
        {
          ((Path2D.Float) generalPath2).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath2).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num10);
          ((Path2D) generalPath2).closePath();
        }
        else
        {
          double d = (num1 + num4) / 2.0 + numArray2[0];
          float num9 = (float) rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((Path2D.Float) generalPath2).moveTo((float) categoryMiddle, num2);
          ((Path2D.Float) generalPath2).lineTo((float) categoryMiddle, num7);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num9);
          ((Path2D.Float) generalPath2).lineTo((float) num6, num10);
          ((Path2D) generalPath2).closePath();
        }
      }
      if (pass == 0)
      {
        Paint itemPaint = this.getItemPaint(row, column);
        g2.setPaint(itemPaint);
        g2.fill((Shape) generalPath1);
        g2.fill((Shape) generalPath2);
        if (entityCollection == null)
          return;
        GeneralPath generalPath3 = new GeneralPath((Shape) generalPath1);
        ((Path2D) generalPath3).append((Shape) generalPath2, false);
        GeneralPath generalPath4 = generalPath3;
        this.addItemEntity(entityCollection, dataset, row, column, (Shape) generalPath4);
      }
      else
      {
        if (pass != 1)
          return;
        this.drawItemLabel(g2, plot.getOrientation(), dataset, row, column, categoryMiddle, (double) num7, num1 < 0.0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StackedAreaRenderer) || this.renderAsPercentages != ((StackedAreaRenderer) obj).renderAsPercentages)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 160, (byte) 134, (byte) 102, (byte) 104, (byte) 137, (byte) 102, (byte) 105, (byte) 99, (byte) 105, (byte) 104, (byte) 135, (byte) 230, (byte) 57, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double getPreviousHeight(CategoryDataset dataset, int series, int category)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (this.renderAsPercentages)
        num2 = DataUtilities.calculateColumnTotal((Values2D) dataset, category);
      for (int i1 = 0; i1 < series; ++i1)
      {
        Number number = dataset.getValue(i1, category);
        if (number != null)
        {
          double num3 = number.doubleValue();
          if (this.renderAsPercentages)
            num3 /= num2;
          num1 += num3;
        }
      }
      return num1;
    }
  }
}
