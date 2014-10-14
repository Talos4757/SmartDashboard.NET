// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.MultiplePiePlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.title;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class MultiplePiePlot : Plot, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -355377800470807389L;
    private JFreeChart pieChart;
    private CategoryDataset dataset;
    private TableOrder dataExtractOrder;
    private double limit;
    private IComparable aggregatedItemsKey;
    [NonSerialized]
    private Paint aggregatedItemsPaint;
    [NonSerialized]
    private Map sectionPaints;
    [NonSerialized]
    private Shape legendItemShape;

    [HideFromJava]
    static MultiplePiePlot()
    {
      Plot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 232, (byte) 21, (byte) 236, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 108, (byte) 107, (byte) 107, (byte) 108, (byte) 157, (byte) 107, (byte) 108, (byte) 107, (byte) 107, (byte) 107, (byte) 127, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiplePiePlot(CategoryDataset dataset)
    {
      MultiplePiePlot multiplePiePlot = this;
      this.limit = 0.0;
      this.setDataset(dataset);
      PiePlot piePlot = new PiePlot((PieDataset) null);
      piePlot.setIgnoreNullValues(true);
      this.pieChart = new JFreeChart((Plot) piePlot);
      this.pieChart.removeLegend();
      this.dataExtractOrder = TableOrder.__\u003C\u003EBY_COLUMN;
      this.pieChart.setBackgroundPaint((Paint) null);
      TextTitle.__\u003Cclinit\u003E();
      TextTitle title = new TextTitle("Series Title", new Font("SansSerif", 1, 12));
      title.setPosition(RectangleEdge.__\u003C\u003EBOTTOM);
      this.pieChart.setTitle(title);
      this.aggregatedItemsKey = (IComparable) "Other";
      this.aggregatedItemsPaint = (Paint) Color.lightGray;
      this.sectionPaints = (Map) new HashMap();
      this.legendItemShape = (Shape) new Ellipse2D.Double(-4.0, -4.0, 8.0, 8.0);
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiplePiePlot()
      : this((CategoryDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MultiplePiePlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] MultiplePiePlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MultiplePiePlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataExtractOrder(TableOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataExtractOrder = order;
        this.fireChangeEvent();
      }
    }

    public virtual JFreeChart getPieChart()
    {
      return this.pieChart;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 99, (byte) 144, (byte) 109, (byte) 176, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPieChart(JFreeChart pieChart)
    {
      if (pieChart == null)
      {
        string str = "Null 'pieChart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (!(pieChart.getPlot() is PiePlot))
      {
        string str = "The 'pieChart' argument must be a chart based on a PiePlot.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.pieChart = pieChart;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 104, (byte) 204, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(CategoryDataset dataset)
    {
      if (this.dataset != null)
        this.dataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 150, (byte) 145, (byte) 144, (byte) 115, (byte) 109, (byte) 104, (byte) 99, (byte) 114, (byte) 99, (byte) 172, (byte) 238, (byte) 55, (byte) 238, (byte) 78, (byte) 115, (byte) 109, (byte) 104, (byte) 99, (byte) 114, (byte) 99, (byte) 172, (byte) 238, (byte) 55, (byte) 233, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void prefetchSectionPaints()
    {
      PiePlot piePlot = (PiePlot) this.getPieChart().getPlot();
      if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
      {
        for (int i = 0; i < this.dataset.getColumnCount(); ++i)
        {
          IComparable columnKey = this.dataset.getColumnKey(i);
          Paint paint = piePlot.getSectionPaint(columnKey) ?? (Paint) this.sectionPaints.get((object) columnKey) ?? this.getDrawingSupplier().getNextPaint();
          this.sectionPaints.put((object) columnKey, (object) paint);
        }
      }
      else
      {
        for (int i = 0; i < this.dataset.getRowCount(); ++i)
        {
          IComparable rowKey = this.dataset.getRowKey(i);
          Paint paint = piePlot.getSectionPaint(rowKey) ?? (Paint) this.sectionPaints.get((object) rowKey) ?? this.getDrawingSupplier().getNextPaint();
          this.sectionPaints.put((object) rowKey, (object) paint);
        }
      }
    }

    public virtual Shape getLegendItemShape()
    {
      return this.legendItemShape;
    }

    public virtual CategoryDataset getDataset()
    {
      return this.dataset;
    }

    public virtual TableOrder getDataExtractOrder()
    {
      return this.dataExtractOrder;
    }

    public virtual double getLimit()
    {
      return this.limit;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLimit(double limit)
    {
      this.limit = limit;
      this.fireChangeEvent();
    }

    public virtual IComparable getAggregatedItemsKey()
    {
      return this.aggregatedItemsKey;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAggregatedItemsKey(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.aggregatedItemsKey = key;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getAggregatedItemsPaint()
    {
      return this.aggregatedItemsPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 221, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAggregatedItemsPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.aggregatedItemsPaint = paint;
        this.fireChangeEvent();
      }
    }

    public override string getPlotType()
    {
      return "Multiple Pie Plot";
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 6, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemShape(Shape shape)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemShape = shape;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 31, (byte) 103, (byte) 103, (byte) 104, (byte) 168, (byte) 109, (byte) 106, (byte) 161, (byte) 98, (byte) 109, (byte) 174, (byte) 204, (byte) 114, (byte) 208, (byte) 114, (byte) 99, (byte) 98, (byte) 163, (byte) 134, (byte) 109, (byte) 109, (byte) 119, (byte) 119, (byte) 99, (byte) 99, (byte) 103, (byte) 99, (byte) 135, (byte) 107, (byte) 190, (byte) 98, (byte) 109, (byte) 182, (byte) 148, (byte) 141, (byte) 98, (byte) 149, (byte) 109, (byte) 215, (byte) 132, (byte) 114, (byte) 124, (byte) 169, (byte) 127, (byte) 5, (byte) 159, (byte) 3, (byte) 111, (byte) 170, (byte) 148, (byte) 235, (byte) 55, (byte) 235, (byte) 76, (byte) 99, (byte) 100, (byte) 135, (byte) 112, (byte) 100, (byte) 152, (byte) 174, (byte) 102, (byte) 101, (byte) 99, (byte) 134, (byte) 107, (byte) 233, (byte) 7, (byte) 235, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      this.getInsets().trim(area);
      this.drawBackground(g2, area);
      this.drawOutline(g2, area);
      if (DatasetUtilities.isEmptyOrNull(this.dataset))
      {
        this.drawNoDataMessage(g2, area);
      }
      else
      {
        int num1 = this.dataExtractOrder != TableOrder.__\u003C\u003EBY_ROW ? this.dataset.getColumnCount() : this.dataset.getRowCount();
        int num2 = ByteCodeHelper.d2i(Math.ceil(Math.sqrt((double) num1)));
        int num3 = ByteCodeHelper.d2i(Math.ceil((double) num1 / (double) num2));
        if (num2 > num3 && ((RectangularShape) area).getWidth() < ((RectangularShape) area).getHeight())
        {
          int num4 = num2;
          num2 = num3;
          num3 = num4;
        }
        this.prefetchSectionPaints();
        int num5 = ByteCodeHelper.d2i(((RectangularShape) area).getX());
        int num6 = ByteCodeHelper.d2i(((RectangularShape) area).getY());
        int num7 = ByteCodeHelper.d2i(((RectangularShape) area).getWidth());
        int num8 = num2;
        int num9 = -1;
        int num10 = num8 != num9 ? num7 / num8 : -num7;
        int num11 = ByteCodeHelper.d2i(((RectangularShape) area).getHeight());
        int num12 = num3;
        int num13 = -1;
        int num14 = num12 != num13 ? num11 / num12 : -num11;
        int num15 = 0;
        int num16 = 0;
        int num17 = num3 * num2 - num1;
        int num18 = 0;
        Rectangle rectangle = new Rectangle();
        for (int index = 0; index < num1; ++index)
        {
          rectangle.setBounds(num5 + num18 + num10 * num16, num6 + num14 * num15, num10, num14);
          this.pieChart.setTitle(this.dataExtractOrder != TableOrder.__\u003C\u003EBY_ROW ? Object.instancehelper_toString((object) this.dataset.getColumnKey(index)) : Object.instancehelper_toString((object) this.dataset.getRowKey(index)));
          CategoryToPieDataset categoryToPieDataset = new CategoryToPieDataset(this.dataset, this.dataExtractOrder, index);
          object obj1 = this.limit <= 0.0 ? (object) categoryToPieDataset : (object) DatasetUtilities.createConsolidatedPieDataset((PieDataset) categoryToPieDataset, this.aggregatedItemsKey, this.limit);
          PiePlot piePlot1 = (PiePlot) this.pieChart.getPlot();
          PiePlot piePlot2 = piePlot1;
          object obj2 = obj1;
          PieDataset dataset;
          if (obj2 != null)
          {
            PieDataset pieDataset = obj2 as PieDataset;
            if (pieDataset == null)
              throw new IncompatibleClassChangeError();
            dataset = pieDataset;
          }
          else
            dataset = (PieDataset) null;
          piePlot2.setDataset(dataset);
          piePlot1.setPieIndex(index);
          int num4 = 0;
          while (true)
          {
            int num19 = num4;
            object obj3 = obj1;
            PieDataset pieDataset1;
            if (obj3 != null)
            {
              PieDataset pieDataset2 = obj3 as PieDataset;
              if (pieDataset2 != null)
                pieDataset1 = pieDataset2;
              else
                break;
            }
            else
              pieDataset1 = (PieDataset) null;
            int itemCount = pieDataset1.getItemCount();
            if (num19 < itemCount)
            {
              object obj4 = obj1;
              int num20 = num4;
              PieDataset pieDataset2;
              if (obj4 != null)
              {
                PieDataset pieDataset3 = obj4 as PieDataset;
                if (pieDataset3 != null)
                  pieDataset2 = pieDataset3;
                else
                  goto label_19;
              }
              else
                pieDataset2 = (PieDataset) null;
              int i = num20;
              IComparable key = pieDataset2.getKey(i);
              Paint paint = !Object.instancehelper_equals((object) key, (object) this.aggregatedItemsKey) ? (Paint) this.sectionPaints.get((object) key) : this.aggregatedItemsPaint;
              piePlot1.setSectionPaint(key, paint);
              ++num4;
            }
            else
              goto label_22;
          }
          throw new IncompatibleClassChangeError();
label_19:
          throw new IncompatibleClassChangeError();
label_22:
          ChartRenderingInfo info1 = (ChartRenderingInfo) null;
          if (info != null)
            info1 = new ChartRenderingInfo();
          this.pieChart.draw(g2, (Rectangle2D) rectangle, info1);
          if (info != null)
          {
            info.getOwner().getEntityCollection().addAll(info1.getEntityCollection());
            info.addSubplotInfo(info1.getPlotInfo());
          }
          ++num16;
          if (num16 == num2)
          {
            num16 = 0;
            ++num15;
            if (num15 == num3 - 1 && num17 != 0)
              num18 = num17 * num10 / 2;
          }
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 190, (byte) 102, (byte) 104, (byte) 162, (byte) 98, (byte) 102, (byte) 109, (byte) 142, (byte) 109, (byte) 172, (byte) 102, (byte) 98, (byte) 103, (byte) 107, (byte) 109, (byte) 105, (byte) 100, (byte) 116, (byte) 191, (byte) 2, (byte) 109, (byte) 104, (byte) 100, (byte) 133, (byte) 109, (byte) 255, (byte) 32, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection1 = new LegendItemCollection();
      if (this.dataset == null)
        return legendItemCollection1;
      List list = (List) null;
      this.prefetchSectionPaints();
      if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
        list = this.dataset.getColumnKeys();
      else if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_COLUMN)
        list = this.dataset.getRowKeys();
      if (list != null)
      {
        int num = 0;
        Iterator iterator = list.iterator();
        while (iterator.hasNext())
        {
          IComparable comparable = (IComparable) iterator.next();
          string label = Object.instancehelper_toString((object) comparable);
          string description = label;
          Paint paint = (Paint) this.sectionPaints.get((object) comparable);
          LegendItem.__\u003Cclinit\u003E();
          LegendItem legendItem = new LegendItem(label, description, (string) null, (string) null, this.getLegendItemShape(), paint, Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE, paint);
          legendItem.setDataset((Dataset) this.getDataset());
          legendItemCollection1.add(legendItem);
          ++num;
        }
      }
      if (this.limit > 0.0)
      {
        LegendItemCollection legendItemCollection2 = legendItemCollection1;
        LegendItem.__\u003Cclinit\u003E();
        LegendItem legendItem = new LegendItem(Object.instancehelper_toString((object) this.aggregatedItemsKey), Object.instancehelper_toString((object) this.aggregatedItemsKey), (string) null, (string) null, this.getLegendItemShape(), this.aggregatedItemsPaint, Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE, this.aggregatedItemsPaint);
        legendItemCollection2.add(legendItem);
      }
      return legendItemCollection1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 239, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MultiplePiePlot))
        return false;
      MultiplePiePlot multiplePiePlot = (MultiplePiePlot) obj;
      return this.dataExtractOrder == multiplePiePlot.dataExtractOrder && this.limit == multiplePiePlot.limit && (Object.instancehelper_equals((object) this.aggregatedItemsKey, (object) multiplePiePlot.aggregatedItemsKey) && PaintUtilities.equal(this.aggregatedItemsPaint, multiplePiePlot.aggregatedItemsPaint)) && (ObjectUtilities.equal((object) this.pieChart, (object) multiplePiePlot.pieChart) && ShapeUtilities.equal(this.legendItemShape, multiplePiePlot.legendItemShape) && base.equals(obj));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 24, (byte) 108, (byte) 118, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      MultiplePiePlot multiplePiePlot = (MultiplePiePlot) base.clone();
      multiplePiePlot.pieChart = (JFreeChart) this.pieChart.clone();
      multiplePiePlot.sectionPaints = (Map) new HashMap(this.sectionPaints);
      multiplePiePlot.legendItemShape = ShapeUtilities.clone(this.legendItemShape);
      return (object) multiplePiePlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 39, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.aggregatedItemsPaint, obj0);
      SerialUtilities.writeShape(this.legendItemShape, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 54, (byte) 102, (byte) 108, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.aggregatedItemsPaint = SerialUtilities.readPaint(obj0);
      this.legendItemShape = SerialUtilities.readShape(obj0);
      this.sectionPaints = (Map) new HashMap();
    }
  }
}
