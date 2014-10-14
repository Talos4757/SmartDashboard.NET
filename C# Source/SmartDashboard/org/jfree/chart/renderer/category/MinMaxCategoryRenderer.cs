// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.MinMaxCategoryRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using javax.swing;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Serializable]
  public class MinMaxCategoryRenderer : AbstractCategoryItemRenderer
  {
    private const long serialVersionUID = 2935615937671064911L;
    private bool plotLines;
    [NonSerialized]
    private Paint groupPaint;
    [NonSerialized]
    private Stroke groupStroke;
    [NonSerialized]
    private Icon minIcon;
    [NonSerialized]
    private Icon maxIcon;
    [NonSerialized]
    private Icon objectIcon;
    private int lastCategory;
    private double min;
    private double max;

    [HideFromJava]
    static MinMaxCategoryRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 232, (byte) 27, (byte) 231, (byte) 69, (byte) 235, (byte) 69, (byte) 176, (byte) 223, (byte) 43, (byte) 223, (byte) 43, (byte) 223, (byte) 16, (byte) 231, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MinMaxCategoryRenderer()
    {
      MinMaxCategoryRenderer categoryRenderer = this;
      this.plotLines = false;
      this.groupPaint = (Paint) Color.black;
      this.groupStroke = (Stroke) new BasicStroke(1f);
      this.minIcon = this.getIcon((Shape) new Arc2D.Double(-4.0, -4.0, 8.0, 8.0, 0.0, 360.0, 0), (Paint) null, (Paint) Color.black);
      this.maxIcon = this.getIcon((Shape) new Arc2D.Double(-4.0, -4.0, 8.0, 8.0, 0.0, 360.0, 0), (Paint) null, (Paint) Color.black);
      this.objectIcon = this.getIcon((Shape) new Line2D.Double(-4.0, 0.0, 4.0, 0.0), false, true);
      this.lastCategory = -1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MinMaxCategoryRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGroupPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.groupPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 100, (byte) 108, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Icon getIcon([In] Shape obj0, [In] Paint obj1, [In] Paint obj2)
    {
      int num1 = (int) obj0.getBounds().width;
      int num2 = (int) obj0.getBounds().height;
      return (Icon) new MinMaxCategoryRenderer\u00241(this, new GeneralPath(obj0), obj1, obj2, num1, num2);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 15, (byte) 132, (byte) 108, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Icon getIcon([In] Shape obj0, [In] bool obj1, [In] bool obj2)
    {
      int num1 = obj1 ? 1 : 0;
      int num2 = obj2 ? 1 : 0;
      int num3 = (int) obj0.getBounds().width;
      int num4 = (int) obj0.getBounds().height;
      return (Icon) new MinMaxCategoryRenderer\u00242(this, new GeneralPath(obj0), num1 != 0, num2 != 0, num3, num4);
    }

    public virtual bool isDrawLines()
    {
      return this.plotLines;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 130, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawLines(bool draw)
    {
      int num = draw ? 1 : 0;
      if ((this.plotLines ? 1 : 0) == num)
        return;
      this.plotLines = num != 0;
      this.fireChangeEvent();
    }

    public virtual Paint getGroupPaint()
    {
      return this.groupPaint;
    }

    public virtual Stroke getGroupStroke()
    {
      return this.groupStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGroupStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.groupStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Icon getObjectIcon()
    {
      return this.objectIcon;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setObjectIcon(Icon icon)
    {
      if (icon == null)
      {
        string str = "Null 'icon' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.objectIcon = icon;
        this.fireChangeEvent();
      }
    }

    public virtual Icon getMaxIcon()
    {
      return this.maxIcon;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaxIcon(Icon icon)
    {
      if (icon == null)
      {
        string str = "Null 'icon' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.maxIcon = icon;
        this.fireChangeEvent();
      }
    }

    public virtual Icon getMinIcon()
    {
      return this.minIcon;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinIcon(Icon icon)
    {
      if (icon == null)
      {
        string str = "Null 'icon' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minIcon = icon;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 108, (byte) 134, (byte) 153, (byte) 151, (byte) 112, (byte) 112, (byte) 98, (byte) 159, (byte) 15, (byte) 105, (byte) 105, (byte) 187, (byte) 185, (byte) 109, (byte) 110, (byte) 141, (byte) 110, (byte) 205, (byte) 112, (byte) 108, (byte) 108, (byte) 152, (byte) 184, (byte) 105, (byte) 113, (byte) 122, (byte) 188, (byte) 113, (byte) 122, (byte) 154, (byte) 162, (byte) 104, (byte) 109, (byte) 205, (byte) 107, (byte) 103, (byte) 111, (byte) 135, (byte) 106, (byte) 188, (byte) 148, (byte) 112, (byte) 144, (byte) 105, (byte) 175, (byte) 141, (byte) 232, (byte) 70, (byte) 104, (byte) 103, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      double categoryMiddle1 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double num1 = rangeAxis.valueToJava2D(number1.doubleValue(), dataArea, plot.getRangeAxisEdge());
      g2.setPaint(this.getItemPaint(row, column));
      g2.setStroke(this.getItemStroke(row, column));
      Rectangle2D.Double double1 = new Rectangle2D.Double(categoryMiddle1 - 4.0, num1 - 4.0, 8.0, 8.0);
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        this.objectIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(categoryMiddle1), ByteCodeHelper.d2i(num1));
      else
        this.objectIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(categoryMiddle1));
      if (this.lastCategory == column)
      {
        if (this.min > number1.doubleValue())
          this.min = number1.doubleValue();
        if (this.max < number1.doubleValue())
          this.max = number1.doubleValue();
        if (dataset.getRowCount() - 1 == row)
        {
          g2.setPaint(this.groupPaint);
          g2.setStroke(this.groupStroke);
          double num2 = rangeAxis.valueToJava2D(this.min, dataArea, plot.getRangeAxisEdge());
          double num3 = rangeAxis.valueToJava2D(this.max, dataArea, plot.getRangeAxisEdge());
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            g2.draw((Shape) new Line2D.Double(categoryMiddle1, num2, categoryMiddle1, num3));
            this.minIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(categoryMiddle1), ByteCodeHelper.d2i(num2));
            this.maxIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(categoryMiddle1), ByteCodeHelper.d2i(num3));
          }
          else
          {
            g2.draw((Shape) new Line2D.Double(num2, categoryMiddle1, num3, categoryMiddle1));
            this.minIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(categoryMiddle1));
            this.maxIcon.paintIcon((Component) null, (Graphics) g2, ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(categoryMiddle1));
          }
        }
      }
      else
      {
        this.lastCategory = column;
        this.min = number1.doubleValue();
        this.max = number1.doubleValue();
      }
      if (this.plotLines && column != 0)
      {
        Number number2 = dataset.getValue(row, column - 1);
        if (number2 != null)
        {
          double d = number2.doubleValue();
          double categoryMiddle2 = domainAxis.getCategoryMiddle(column - 1, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
          double num2 = rangeAxis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
          g2.setPaint(this.getItemPaint(row, column));
          g2.setStroke(this.getItemStroke(row, column));
          Line2D.Double double2 = orientation != PlotOrientation.__\u003C\u003EVERTICAL ? new Line2D.Double(num2, categoryMiddle2, num1, categoryMiddle1) : new Line2D.Double(categoryMiddle2, num2, categoryMiddle1, num1);
          g2.draw((Shape) double2);
        }
      }
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null || double1 == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) double1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MinMaxCategoryRenderer))
        return false;
      MinMaxCategoryRenderer categoryRenderer = (MinMaxCategoryRenderer) obj;
      if (this.plotLines != categoryRenderer.plotLines || !PaintUtilities.equal(this.groupPaint, categoryRenderer.groupPaint) || !Object.instancehelper_equals((object) this.groupStroke, (object) categoryRenderer.groupStroke))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 174, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.groupStroke, obj0);
      SerialUtilities.writePaint(this.groupPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 102, (byte) 108, (byte) 140, (byte) 159, (byte) 43, (byte) 159, (byte) 43, (byte) 127, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.groupStroke = SerialUtilities.readStroke(obj0);
      this.groupPaint = SerialUtilities.readPaint(obj0);
      this.minIcon = this.getIcon((Shape) new Arc2D.Double(-4.0, -4.0, 8.0, 8.0, 0.0, 360.0, 0), (Paint) null, (Paint) Color.black);
      this.maxIcon = this.getIcon((Shape) new Arc2D.Double(-4.0, -4.0, 8.0, 8.0, 0.0, 360.0, 0), (Paint) null, (Paint) Color.black);
      this.objectIcon = this.getIcon((Shape) new Line2D.Double(-4.0, 0.0, 4.0, 0.0), false, true);
    }
  }
}
