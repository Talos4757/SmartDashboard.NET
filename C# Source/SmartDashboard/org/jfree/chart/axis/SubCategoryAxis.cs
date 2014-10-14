// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.SubCategoryAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class SubCategoryAxis : CategoryAxis, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -1279463299793228344L;
    private List subCategories;
    private Font subLabelFont;
    [NonSerialized]
    private Paint subLabelPaint;

    [HideFromJava]
    static SubCategoryAxis()
    {
      CategoryAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 233, (byte) 53, (byte) 179, (byte) 235, (byte) 73, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubCategoryAxis(string label)
      : base(label)
    {
      SubCategoryAxis subCategoryAxis = this;
      this.subLabelFont = new Font("SansSerif", 0, 10);
      this.subLabelPaint = (Paint) Color.black;
      this.subCategories = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SubCategoryAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SubCategoryAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SubCategoryAxis obj0)
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

    [LineNumberTable(new byte[] {(byte) 88, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subLabelFont = font;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subLabelPaint = paint;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 102, (byte) 108, (byte) 103, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 107, (byte) 102, (byte) 104, (byte) 172, (byte) 138, (byte) 106, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getMaxDim([In] Graphics2D obj0, [In] RectangleEdge obj1)
    {
      double num1 = 0.0;
      ((Graphics) obj0).setFont(this.subLabelFont);
      FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics();
      Iterator iterator = this.subCategories.iterator();
      while (iterator.hasNext())
      {
        Rectangle2D textBounds = TextUtilities.getTextBounds(Object.instancehelper_toString((object) (IComparable) iterator.next()), obj0, fontMetrics);
        double num2 = !RectangleEdge.isLeftOrRight(obj1) ? ((RectangularShape) textBounds).getHeight() : ((RectangularShape) textBounds).getWidth();
        num1 = Math.max(num1, num2);
      }
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 100, (byte) 176, (byte) 108, (byte) 108, (byte) 108, (byte) 98, (byte) 103, (byte) 99, (byte) 167, (byte) 107, (byte) 171, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 105, (byte) 143, (byte) 143, (byte) 106, (byte) 140, (byte) 105, (byte) 143, (byte) 143, (byte) 106, (byte) 140, (byte) 105, (byte) 143, (byte) 143, (byte) 106, (byte) 137, (byte) 105, (byte) 143, (byte) 143, (byte) 106, (byte) 135, (byte) 149, (byte) 109, (byte) 108, (byte) 108, (byte) 102, (byte) 102, (byte) 108, (byte) 105, (byte) 119, (byte) 172, (byte) 106, (byte) 151, (byte) 116, (byte) 251, (byte) 54, (byte) 235, (byte) 19, (byte) 235, (byte) 124, (byte) 110, (byte) 99, (byte) 105, (byte) 98, (byte) 110, (byte) 99, (byte) 105, (byte) 98, (byte) 105, (byte) 99, (byte) 105, (byte) 98, (byte) 105, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawSubCategoryLabels(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, AxisState state, PlotRenderingInfo plotState)
    {
      if (state == null)
      {
        string str = "Null 'state' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ((Graphics) g2).setFont(this.subLabelFont);
        g2.setPaint(this.subLabelPaint);
        CategoryPlot categoryPlot = (CategoryPlot) this.getPlot();
        int categoryCount = 0;
        CategoryDataset dataset = categoryPlot.getDataset();
        if (dataset != null)
          categoryCount = dataset.getColumnCount();
        double maxDim = this.getMaxDim(g2, edge);
        for (int category = 0; category < categoryCount; ++category)
        {
          double num1 = 0.0;
          double num2 = 0.0;
          double num3 = 0.0;
          double num4 = 0.0;
          if (edge == RectangleEdge.__\u003C\u003ETOP)
          {
            num1 = this.getCategoryStart(category, categoryCount, dataArea, edge);
            num2 = this.getCategoryEnd(category, categoryCount, dataArea, edge);
            num4 = state.getCursor();
            num3 = num4 - maxDim;
          }
          else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
          {
            num1 = this.getCategoryStart(category, categoryCount, dataArea, edge);
            num2 = this.getCategoryEnd(category, categoryCount, dataArea, edge);
            num3 = state.getCursor();
            num4 = num3 + maxDim;
          }
          else if (edge == RectangleEdge.__\u003C\u003ELEFT)
          {
            num3 = this.getCategoryStart(category, categoryCount, dataArea, edge);
            num4 = this.getCategoryEnd(category, categoryCount, dataArea, edge);
            num2 = state.getCursor();
            num1 = num2 - maxDim;
          }
          else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
          {
            num3 = this.getCategoryStart(category, categoryCount, dataArea, edge);
            num4 = this.getCategoryEnd(category, categoryCount, dataArea, edge);
            num1 = state.getCursor();
            num2 = num1 + maxDim;
          }
          Rectangle2D.Double @double = new Rectangle2D.Double(num1, num3, num2 - num1, num4 - num3);
          int num5 = this.subCategories.size();
          float num6 = (float) (num2 - num1) / (float) num5;
          float num7 = (float) (num4 - num3) / (float) num5;
          for (int index = 0; index < num5; ++index)
          {
            float x;
            float y;
            if (RectangleEdge.isTopOrBottom(edge))
            {
              x = (float) (num1 + ((double) index + 0.5) * (double) num6);
              y = (float) ((RectangularShape) @double).getCenterY();
            }
            else
            {
              x = (float) ((RectangularShape) @double).getCenterX();
              y = (float) (num3 + ((double) index + 0.5) * (double) num7);
            }
            TextUtilities.drawRotatedString(Object.instancehelper_toString(this.subCategories.get(index)), g2, x, y, TextAnchor.__\u003C\u003ECENTER, 0.0, TextAnchor.__\u003C\u003ECENTER);
          }
        }
        if (edge.equals((object) RectangleEdge.__\u003C\u003ETOP))
        {
          double units = maxDim;
          state.cursorUp(units);
        }
        else if (edge.equals((object) RectangleEdge.__\u003C\u003EBOTTOM))
        {
          double units = maxDim;
          state.cursorDown(units);
        }
        else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        {
          double units = maxDim;
          state.cursorLeft(units);
        }
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          double units = maxDim;
          state.cursorRight(units);
        }
        return state;
      }
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 99, (byte) 144, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubCategory(IComparable subCategory)
    {
      if (subCategory == null)
      {
        string str = "Null 'subcategory' axis.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subCategories.add((object) subCategory);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Font getSubLabelFont()
    {
      return this.subLabelFont;
    }

    public virtual Paint getSubLabelPaint()
    {
      return this.subLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 100, (byte) 199, (byte) 104, (byte) 163, (byte) 111, (byte) 107, (byte) 105, (byte) 140, (byte) 105, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisSpace reserveSpace(Graphics2D g2, Plot plot, Rectangle2D plotArea, RectangleEdge edge, AxisSpace space)
    {
      if (space == null)
        space = new AxisSpace();
      if (!this.isVisible())
        return space;
      space = base.reserveSpace(g2, plot, plotArea, edge, space);
      double maxDim = this.getMaxDim(g2, edge);
      if (RectangleEdge.isTopOrBottom(edge))
        space.add(maxDim, edge);
      else if (RectangleEdge.isLeftOrRight(edge))
        space.add(maxDim, edge);
      return space;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 104, (byte) 170, (byte) 104, (byte) 205, (byte) 104, (byte) 144, (byte) 144, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (!this.isVisible())
      {
        return new AxisState(cursor);
      }
      else
      {
        if (this.isAxisLineVisible())
          this.drawAxisLine(g2, cursor, dataArea, edge);
        AxisState state1 = new AxisState(cursor);
        AxisState state2 = this.drawSubCategoryLabels(g2, plotArea, dataArea, edge, state1, plotState);
        AxisState state3 = this.drawCategoryLabels(g2, plotArea, dataArea, edge, state2, plotState);
        return this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state3);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 35, (byte) 100, (byte) 130, (byte) 113, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SubCategoryAxis) || !base.equals(obj))
        return false;
      SubCategoryAxis subCategoryAxis = (SubCategoryAxis) obj;
      return Object.instancehelper_equals((object) this.subCategories, (object) subCategoryAxis.subCategories) && this.subLabelFont.equals((object) subCategoryAxis.subLabelFont) && Object.instancehelper_equals((object) this.subLabelPaint, (object) subCategoryAxis.subLabelPaint);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.subLabelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.subLabelPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
