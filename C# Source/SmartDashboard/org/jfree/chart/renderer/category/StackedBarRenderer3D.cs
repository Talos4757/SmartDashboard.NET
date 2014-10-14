// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.StackedBarRenderer3D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
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
  public class StackedBarRenderer3D : BarRenderer3D, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -5832945916493247123L;
    private bool renderAsPercentages;

    [HideFromJava]
    static StackedBarRenderer3D()
    {
      BarRenderer3D.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer3D()
      : this(false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 101, (byte) 130, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer3D(bool renderAsPercentages)
    {
      int num = renderAsPercentages ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      StackedBarRenderer3D stackedBarRenderer3D = this;
      this.renderAsPercentages = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer3D(double xOffset, double yOffset)
      : base(xOffset, yOffset)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 130, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer3D(double xOffset, double yOffset, bool renderAsPercentages)
    {
      int num = renderAsPercentages ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(xOffset, yOffset);
      StackedBarRenderer3D stackedBarRenderer3D = this;
      this.renderAsPercentages = num != 0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedBarRenderer3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StackedBarRenderer3D obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StackedBarRenderer3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 61, (byte) 67, (byte) 102, (byte) 99, (byte) 99, (byte) 103, (byte) 99, (byte) 209, (byte) 99, (byte) 100, (byte) 108, (byte) 102, (byte) 113, (byte) 100, (byte) 133, (byte) 106, (byte) 99, (byte) 136, (byte) 105, (byte) 101, (byte) 123, (byte) 131, (byte) 102, (byte) 159, (byte) 6, (byte) 105, (byte) 101, (byte) 123, (byte) 131, (byte) 102, (byte) 159, (byte) 4, (byte) 230, (byte) 38, (byte) 235, (byte) 93})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static List createStackedValueList(CategoryDataset dataset, IComparable category, int[] includedRows, double @base, bool asPercentages)
    {
      int num1 = asPercentages ? 1 : 0;
      ArrayList arrayList1 = new ArrayList();
      double num2 = @base;
      double num3 = @base;
      double num4 = 0.0;
      if (num1 != 0)
        num4 = DataUtilities.calculateColumnTotal((Values2D) dataset, dataset.getColumnIndex(category), includedRows);
      int num5 = -1;
      int length = includedRows.Length;
      for (int index1 = 0; index1 < length; ++index1)
      {
        int i = includedRows[index1];
        Number number = dataset.getValue(dataset.getRowKey(i), category);
        if (number != null)
        {
          double num6 = number.doubleValue();
          if (num1 != 0)
            num6 /= num4;
          if (num6 >= 0.0)
          {
            if (num5 < 0)
            {
              ArrayList arrayList2 = arrayList1;
              object[] objArray = new object[2];
              int index2 = 0;
              // ISSUE: variable of the null type
              __Null local = null;
              objArray[index2] = (object) local;
              int index3 = 1;
              Double @double = new Double(@base);
              objArray[index3] = (object) @double;
              ((List) arrayList2).add((object) objArray);
              num5 = 0;
            }
            num2 += num6;
            ArrayList arrayList3 = arrayList1;
            object[] objArray1 = new object[2];
            int index4 = 0;
            Integer integer = new Integer(i);
            objArray1[index4] = (object) integer;
            int index5 = 1;
            Double double1 = new Double(num2);
            objArray1[index5] = (object) double1;
            ((List) arrayList3).add((object) objArray1);
          }
          else if (num6 < 0.0)
          {
            if (num5 < 0)
            {
              ArrayList arrayList2 = arrayList1;
              object[] objArray = new object[2];
              int index2 = 0;
              // ISSUE: variable of the null type
              __Null local = null;
              objArray[index2] = (object) local;
              int index3 = 1;
              Double @double = new Double(@base);
              objArray[index3] = (object) @double;
              ((List) arrayList2).add((object) objArray);
              num5 = 0;
            }
            num3 += num6;
            ArrayList arrayList3 = arrayList1;
            int num7 = 0;
            object[] objArray1 = new object[2];
            int index4 = 0;
            Integer integer = new Integer(-i - 1);
            objArray1[index4] = (object) integer;
            int index5 = 1;
            Double double1 = new Double(num3);
            objArray1[index5] = (object) double1;
            ((List) arrayList3).add(num7, (object) objArray1);
            ++num5;
          }
        }
      }
      return (List) arrayList1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 105, (byte) 191, (byte) 13, (byte) 201, (byte) 166, (byte) 105, (byte) 106, (byte) 108, (byte) 113, (byte) 116, (byte) 118, (byte) 98, (byte) 102, (byte) 181, (byte) 112, (byte) 101, (byte) 179, (byte) 113, (byte) 181, (byte) 113, (byte) 181, (byte) 144, (byte) 107, (byte) 100, (byte) 110, (byte) 142, (byte) 104, (byte) 100, (byte) 100, (byte) 107, (byte) 143, (byte) 104, (byte) 101, (byte) 170, (byte) 155, (byte) 107, (byte) 100, (byte) 104, (byte) 235, (byte) 54, (byte) 235, (byte) 78, (byte) 255, (byte) 22, (byte) 69, (byte) 105, (byte) 100, (byte) 241, (byte) 8, (byte) 235, (byte) 125, (byte) 112, (byte) 116, (byte) 112, (byte) 107, (byte) 112, (byte) 139, (byte) 111, (byte) 244, (byte) 56, (byte) 235, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawStackHorizontal(List values, IComparable category, Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset)
    {
      int columnIndex = dataset.getColumnIndex(category);
      double num1 = domainAxis.getCategoryMiddle(columnIndex, dataset.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      double barWidth = state.getBarWidth();
      ArrayList arrayList1 = new ArrayList();
      int num2 = rangeAxis.isInverted() ? 1 : 0;
      int num3 = values.size() - 1;
      for (int index1 = 0; index1 < num3; ++index1)
      {
        int num4 = num2 == 0 ? index1 : num3 - index1 - 1;
        object[] objArray1 = (object[]) values.get(num4);
        object[] objArray2 = (object[]) values.get(num4 + 1);
        int row;
        if (objArray2[0] == null)
        {
          row = -((Integer) objArray1[0]).intValue() - 1;
        }
        else
        {
          row = ((Integer) objArray2[0]).intValue();
          if (row < 0)
            row = -((Integer) objArray1[0]).intValue() - 1;
        }
        double d1 = ((Double) objArray1[1]).doubleValue();
        double num5 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
        double d2 = ((Double) objArray2[1]).doubleValue();
        double num6 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
        Shape[] horizontalBlock = this.createHorizontalBlock(num1, barWidth, num5, num6, num2 != 0);
        Paint itemPaint = this.getItemPaint(row, columnIndex);
        object obj1 = (object) itemPaint;
        if ((Paint) obj1 is Color)
          obj1 = (object) ((Color) itemPaint).darker();
        int num7 = this.isDrawBarOutline() ? 1 : 0;
        Paint paint1 = itemPaint;
        if (num7 != 0)
        {
          paint1 = this.getItemOutlinePaint(row, columnIndex);
          g2.setStroke(this.getItemOutlineStroke(row, columnIndex));
        }
        for (int index2 = 0; index2 < 6; ++index2)
        {
          if (index2 == 5)
          {
            g2.setPaint(itemPaint);
          }
          else
          {
            Graphics2D graphics2D = g2;
            object obj2 = obj1;
            Paint paint2;
            if (obj2 != null)
            {
              Paint paint3 = obj2 as Paint;
              if (paint3 == null)
                throw new IncompatibleClassChangeError();
              paint2 = paint3;
            }
            else
              paint2 = (Paint) null;
            graphics2D.setPaint(paint2);
          }
          g2.fill(horizontalBlock[index2]);
          if (num7 != 0)
          {
            g2.setPaint(paint1);
            g2.draw(horizontalBlock[index2]);
          }
        }
        ArrayList arrayList2 = arrayList1;
        object[] objArray3 = new object[3];
        int index3 = 0;
        Integer integer = new Integer(row);
        objArray3[index3] = (object) integer;
        int index4 = 1;
        Rectangle2D bounds2D = horizontalBlock[5].getBounds2D();
        objArray3[index4] = (object) bounds2D;
        int index5 = 2;
        Boolean boolean = BooleanUtilities.valueOf(d1 < this.getBase());
        objArray3[index5] = (object) boolean;
        ((List) arrayList2).add((object) objArray3);
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection != null)
          this.addItemEntity(entityCollection, dataset, row, columnIndex, horizontalBlock[5]);
      }
      for (int index = 0; index < ((List) arrayList1).size(); ++index)
      {
        object[] objArray = (object[]) ((List) arrayList1).get(index);
        int row = ((Integer) objArray[0]).intValue();
        Rectangle2D bar = (Rectangle2D) objArray[1];
        int num4 = ((Boolean) objArray[2]).booleanValue() ? 1 : 0;
        CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, columnIndex);
        if (itemLabelGenerator != null && this.isItemLabelVisible(row, columnIndex))
          this.drawItemLabel(g2, dataset, row, columnIndex, plot, itemLabelGenerator, bar, num4 != 0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 17, (byte) 105, (byte) 191, (byte) 13, (byte) 201, (byte) 166, (byte) 105, (byte) 106, (byte) 108, (byte) 113, (byte) 116, (byte) 118, (byte) 98, (byte) 102, (byte) 181, (byte) 112, (byte) 101, (byte) 179, (byte) 113, (byte) 181, (byte) 113, (byte) 181, (byte) 144, (byte) 107, (byte) 100, (byte) 110, (byte) 142, (byte) 104, (byte) 100, (byte) 100, (byte) 107, (byte) 175, (byte) 104, (byte) 101, (byte) 170, (byte) 155, (byte) 107, (byte) 100, (byte) 104, (byte) 235, (byte) 54, (byte) 235, (byte) 78, (byte) 255, (byte) 22, (byte) 69, (byte) 105, (byte) 100, (byte) 241, (byte) 7, (byte) 235, (byte) 126, (byte) 112, (byte) 116, (byte) 112, (byte) 107, (byte) 112, (byte) 139, (byte) 111, (byte) 244, (byte) 56, (byte) 235, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawStackVertical(List values, IComparable category, Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset)
    {
      int columnIndex = dataset.getColumnIndex(category);
      double num1 = domainAxis.getCategoryMiddle(columnIndex, dataset.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      double barWidth = state.getBarWidth();
      ArrayList arrayList1 = new ArrayList();
      int num2 = rangeAxis.isInverted() ? 1 : 0;
      int num3 = values.size() - 1;
      for (int index1 = 0; index1 < num3; ++index1)
      {
        int num4 = num2 == 0 ? index1 : num3 - index1 - 1;
        object[] objArray1 = (object[]) values.get(num4);
        object[] objArray2 = (object[]) values.get(num4 + 1);
        int row;
        if (objArray2[0] == null)
        {
          row = -((Integer) objArray1[0]).intValue() - 1;
        }
        else
        {
          row = ((Integer) objArray2[0]).intValue();
          if (row < 0)
            row = -((Integer) objArray1[0]).intValue() - 1;
        }
        double d1 = ((Double) objArray1[1]).doubleValue();
        double num5 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
        double d2 = ((Double) objArray2[1]).doubleValue();
        double num6 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
        Shape[] verticalBlock = this.createVerticalBlock(num1, barWidth, num5, num6, num2 != 0);
        Paint itemPaint = this.getItemPaint(row, columnIndex);
        object obj1 = (object) itemPaint;
        if ((Paint) obj1 is Color)
          obj1 = (object) ((Color) itemPaint).darker();
        int num7 = this.isDrawBarOutline() ? 1 : 0;
        Paint paint1 = itemPaint;
        if (num7 != 0)
        {
          paint1 = this.getItemOutlinePaint(row, columnIndex);
          g2.setStroke(this.getItemOutlineStroke(row, columnIndex));
        }
        for (int index2 = 0; index2 < 6; ++index2)
        {
          if (index2 == 5)
          {
            g2.setPaint(itemPaint);
          }
          else
          {
            Graphics2D graphics2D = g2;
            object obj2 = obj1;
            Paint paint2;
            if (obj2 != null)
            {
              Paint paint3 = obj2 as Paint;
              if (paint3 == null)
                throw new IncompatibleClassChangeError();
              paint2 = paint3;
            }
            else
              paint2 = (Paint) null;
            graphics2D.setPaint(paint2);
          }
          g2.fill(verticalBlock[index2]);
          if (num7 != 0)
          {
            g2.setPaint(paint1);
            g2.draw(verticalBlock[index2]);
          }
        }
        ArrayList arrayList2 = arrayList1;
        object[] objArray3 = new object[3];
        int index3 = 0;
        Integer integer = new Integer(row);
        objArray3[index3] = (object) integer;
        int index4 = 1;
        Rectangle2D bounds2D = verticalBlock[5].getBounds2D();
        objArray3[index4] = (object) bounds2D;
        int index5 = 2;
        Boolean boolean = BooleanUtilities.valueOf(d1 < this.getBase());
        objArray3[index5] = (object) boolean;
        ((List) arrayList2).add((object) objArray3);
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection != null)
          this.addItemEntity(entityCollection, dataset, row, columnIndex, verticalBlock[5]);
      }
      for (int index = 0; index < ((List) arrayList1).size(); ++index)
      {
        object[] objArray = (object[]) ((List) arrayList1).get(index);
        int row = ((Integer) objArray[0]).intValue();
        Rectangle2D bar = (Rectangle2D) objArray[1];
        int num4 = ((Boolean) objArray[2]).booleanValue() ? 1 : 0;
        CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, columnIndex);
        if (itemLabelGenerator != null && this.isItemLabelVisible(row, columnIndex))
          this.drawItemLabel(g2, dataset, row, columnIndex, plot, itemLabelGenerator, bar, num4 != 0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 5, (byte) 163, (byte) 103, (byte) 106, (byte) 109, (byte) 159, (byte) 2, (byte) 191, (byte) 2, (byte) 108, (byte) 111, (byte) 159, (byte) 4, (byte) 191, (byte) 4, (byte) 103, (byte) 119, (byte) 117, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 117, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 117, (byte) 117, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 117, (byte) 117, (byte) 119, (byte) 119, (byte) 103, (byte) 101, (byte) 101, (byte) 99, (byte) 101, (byte) 167, (byte) 101, (byte) 133, (byte) 101, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Shape[] createHorizontalBlock([In] double obj0, [In] double obj1, [In] double obj2, [In] double obj3, [In] bool obj4)
    {
      int num = obj4 ? 1 : 0;
      Shape[] shapeArray = new Shape[6];
      Point2D.Double double1 = new Point2D.Double(obj2, obj0);
      Point2D.Double double2 = new Point2D.Double(obj2, obj0 + obj1);
      Point2D.Double double3 = new Point2D.Double(((Point2D) double2).getX() + this.getXOffset(), ((Point2D) double2).getY() - this.getYOffset());
      Point2D.Double double4 = new Point2D.Double(((Point2D) double1).getX() + this.getXOffset(), ((Point2D) double1).getY() - this.getYOffset());
      Point2D.Double double5 = new Point2D.Double(obj3, obj0);
      Point2D.Double double6 = new Point2D.Double(obj3, obj0 + obj1);
      Point2D.Double double7 = new Point2D.Double(((Point2D) double6).getX() + this.getXOffset(), ((Point2D) double6).getY() - this.getYOffset());
      Point2D.Double double8 = new Point2D.Double(((Point2D) double5).getX() + this.getXOffset(), ((Point2D) double5).getY() - this.getYOffset());
      GeneralPath generalPath1 = new GeneralPath();
      ((Path2D.Float) generalPath1).moveTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D) generalPath1).closePath();
      GeneralPath generalPath2 = new GeneralPath();
      ((Path2D.Float) generalPath2).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath2).closePath();
      GeneralPath generalPath3 = new GeneralPath();
      ((Path2D.Float) generalPath3).moveTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath3).closePath();
      GeneralPath generalPath4 = new GeneralPath();
      ((Path2D.Float) generalPath4).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D) generalPath4).closePath();
      GeneralPath generalPath5 = new GeneralPath();
      ((Path2D.Float) generalPath5).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath5).closePath();
      GeneralPath generalPath6 = new GeneralPath();
      ((Path2D.Float) generalPath6).moveTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D) generalPath6).closePath();
      shapeArray[0] = (Shape) generalPath1;
      shapeArray[1] = (Shape) generalPath3;
      if (num != 0)
      {
        shapeArray[2] = (Shape) generalPath6;
        shapeArray[3] = (Shape) generalPath5;
      }
      else
      {
        shapeArray[2] = (Shape) generalPath5;
        shapeArray[3] = (Shape) generalPath6;
      }
      shapeArray[4] = (Shape) generalPath2;
      shapeArray[5] = (Shape) generalPath4;
      return shapeArray;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 211, (byte) 67, (byte) 103, (byte) 106, (byte) 109, (byte) 159, (byte) 2, (byte) 223, (byte) 2, (byte) 108, (byte) 111, (byte) 159, (byte) 4, (byte) 191, (byte) 4, (byte) 103, (byte) 119, (byte) 117, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 117, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 117, (byte) 117, (byte) 135, (byte) 103, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 135, (byte) 103, (byte) 117, (byte) 117, (byte) 119, (byte) 119, (byte) 135, (byte) 101, (byte) 101, (byte) 101, (byte) 101, (byte) 101, (byte) 101, (byte) 99, (byte) 101, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Shape[] createVerticalBlock([In] double obj0, [In] double obj1, [In] double obj2, [In] double obj3, [In] bool obj4)
    {
      int num = obj4 ? 1 : 0;
      Shape[] shapeArray = new Shape[6];
      Point2D.Double double1 = new Point2D.Double(obj0, obj2);
      Point2D.Double double2 = new Point2D.Double(obj0 + obj1, obj2);
      Point2D.Double double3 = new Point2D.Double(((Point2D) double2).getX() + this.getXOffset(), ((Point2D) double2).getY() - this.getYOffset());
      Point2D.Double double4 = new Point2D.Double(((Point2D) double1).getX() + this.getXOffset(), ((Point2D) double1).getY() - this.getYOffset());
      Point2D.Double double5 = new Point2D.Double(obj0, obj3);
      Point2D.Double double6 = new Point2D.Double(obj0 + obj1, obj3);
      Point2D.Double double7 = new Point2D.Double(((Point2D) double6).getX() + this.getXOffset(), ((Point2D) double6).getY() - this.getYOffset());
      Point2D.Double double8 = new Point2D.Double(((Point2D) double5).getX() + this.getXOffset(), ((Point2D) double5).getY() - this.getYOffset());
      GeneralPath generalPath1 = new GeneralPath();
      ((Path2D.Float) generalPath1).moveTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath1).lineTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D) generalPath1).closePath();
      GeneralPath generalPath2 = new GeneralPath();
      ((Path2D.Float) generalPath2).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D.Float) generalPath2).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath2).closePath();
      GeneralPath generalPath3 = new GeneralPath();
      ((Path2D.Float) generalPath3).moveTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D.Float) generalPath3).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath3).closePath();
      GeneralPath generalPath4 = new GeneralPath();
      ((Path2D.Float) generalPath4).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath4).lineTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D) generalPath4).closePath();
      GeneralPath generalPath5 = new GeneralPath();
      ((Path2D.Float) generalPath5).moveTo((float) ((Point2D) double5).getX(), (float) ((Point2D) double5).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double6).getX(), (float) ((Point2D) double6).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double7).getX(), (float) ((Point2D) double7).getY());
      ((Path2D.Float) generalPath5).lineTo((float) ((Point2D) double8).getX(), (float) ((Point2D) double8).getY());
      ((Path2D) generalPath5).closePath();
      GeneralPath generalPath6 = new GeneralPath();
      ((Path2D.Float) generalPath6).moveTo((float) ((Point2D) double1).getX(), (float) ((Point2D) double1).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double2).getX(), (float) ((Point2D) double2).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double3).getX(), (float) ((Point2D) double3).getY());
      ((Path2D.Float) generalPath6).lineTo((float) ((Point2D) double4).getX(), (float) ((Point2D) double4).getY());
      ((Path2D) generalPath6).closePath();
      shapeArray[0] = (Shape) generalPath6;
      shapeArray[1] = (Shape) generalPath3;
      shapeArray[2] = (Shape) generalPath2;
      shapeArray[3] = (Shape) generalPath1;
      shapeArray[4] = (Shape) generalPath5;
      shapeArray[5] = (Shape) generalPath4;
      if (num != 0)
      {
        shapeArray[0] = (Shape) generalPath5;
        shapeArray[4] = (Shape) generalPath6;
      }
      return shapeArray;
    }

    public virtual bool getRenderAsPercentages()
    {
      return this.renderAsPercentages;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 90, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderAsPercentages(bool asPercentages)
    {
      this.renderAsPercentages = asPercentages;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 99, (byte) 130, (byte) 104, (byte) 178})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 105, (byte) 104, (byte) 102, (byte) 103, (byte) 102, (byte) 104, (byte) 138, (byte) 104, (byte) 136, (byte) 107, (byte) 104, (byte) 103, (byte) 101, (byte) 169, (byte) 187, (byte) 101, (byte) 182, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void calculateBarWidth(CategoryPlot plot, Rectangle2D dataArea, int rendererIndex, CategoryItemRendererState state)
    {
      CategoryAxis domainAxis = this.getDomainAxis(plot, rendererIndex);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset == null)
        return;
      PlotOrientation orientation = plot.getOrientation();
      double num1 = 0.0;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num1 = ((RectangularShape) dataArea).getHeight();
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num1 = ((RectangularShape) dataArea).getWidth();
      double num2 = num1 * this.getMaximumBarWidth();
      int columnCount = dataset.getColumnCount();
      double num3 = 0.0;
      if (columnCount > 1)
        num3 = domainAxis.getCategoryMargin();
      double num4 = num1 * (1.0 - domainAxis.getLowerMargin() - domainAxis.getUpperMargin() - num3);
      if (columnCount > 0)
        state.setBarWidth(Math.min(num4 / (double) columnCount, num2));
      else
        state.setBarWidth(Math.min(num4, num2));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 68, (byte) 98, (byte) 108, (byte) 103, (byte) 36, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static List createStackedValueList(CategoryDataset dataset, IComparable category, double @base, bool asPercentages)
    {
      int num = asPercentages ? 1 : 0;
      int[] includedRows = new int[dataset.getRowCount()];
      for (int index = 0; index < includedRows.Length; ++index)
        includedRows[index] = index;
      return StackedBarRenderer3D.createStackedValueList(dataset, category, includedRows, @base, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 109, (byte) 129, (byte) 138, (byte) 223, (byte) 4, (byte) 255, (byte) 20, (byte) 70, (byte) 168, (byte) 104, (byte) 213, (byte) 213})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (row < dataset.getRowCount() - 1)
        return;
      IComparable columnKey = dataset.getColumnKey(column);
      List stackedValueList = StackedBarRenderer3D.createStackedValueList(dataset, dataset.getColumnKey(column), state.getVisibleSeriesArray(), this.getBase(), this.renderAsPercentages);
      Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        this.drawStackHorizontal(stackedValueList, columnKey, g2, state, (Rectangle2D) @double, plot, domainAxis, rangeAxis, dataset);
      else
        this.drawStackVertical(stackedValueList, columnKey, g2, state, (Rectangle2D) @double, plot, domainAxis, rangeAxis, dataset);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 201, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is StackedBarRenderer3D && base.equals(obj) && this.renderAsPercentages == ((StackedBarRenderer3D) obj).getRenderAsPercentages();
    }
  }
}
