// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.CategoryTextAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"org.jfree.chart.annotations.CategoryAnnotation", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryTextAnnotation : TextAnnotation, CategoryAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 3333360090781320147L;
    private IComparable category;
    private CategoryAnchor categoryAnchor;
    private double value;

    [HideFromJava]
    static CategoryTextAnnotation()
    {
      TextAnnotation.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 105, (byte) 99, (byte) 144, (byte) 103, (byte) 105, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryTextAnnotation(string text, IComparable category, double value)
      : base(text)
    {
      CategoryTextAnnotation categoryTextAnnotation = this;
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.category = category;
        this.value = value;
        this.categoryAnchor = CategoryAnchor.__\u003C\u003EMIDDLE;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryTextAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryTextAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryTextAnnotation obj0)
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

    public virtual IComparable getCategory()
    {
      return this.category;
    }

    public virtual CategoryAnchor getCategoryAnchor()
    {
      return this.categoryAnchor;
    }

    public virtual double getValue()
    {
      return this.value;
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategory(IComparable category)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.category = category;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategoryAnchor(CategoryAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.categoryAnchor = anchor;
    }

    public virtual void setValue(double value)
    {
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 103, (byte) 109, (byte) 135, (byte) 102, (byte) 103, (byte) 104, (byte) 143, (byte) 175, (byte) 105, (byte) 181, (byte) 180, (byte) 105, (byte) 180, (byte) 179, (byte) 108, (byte) 108, (byte) 191, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea, CategoryAxis domainAxis, ValueAxis rangeAxis)
    {
      CategoryDataset dataset = plot.getDataset();
      int columnIndex = dataset.getColumnIndex(this.category);
      int columnCount = dataset.getColumnCount();
      float x = 0.0f;
      float y = 0.0f;
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge edge = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        y = (float) domainAxis.getCategoryJava2DCoordinate(this.categoryAnchor, columnIndex, columnCount, dataArea, edge);
        x = (float) rangeAxis.valueToJava2D(this.value, dataArea, re);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        x = (float) domainAxis.getCategoryJava2DCoordinate(this.categoryAnchor, columnIndex, columnCount, dataArea, edge);
        y = (float) rangeAxis.valueToJava2D(this.value, dataArea, re);
      }
      ((Graphics) g2).setFont(this.getFont());
      g2.setPaint(this.getPaint());
      TextUtilities.drawRotatedString(this.getText(), g2, x, y, this.getTextAnchor(), this.getRotationAngle(), this.getRotationAnchor());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryTextAnnotation))
        return false;
      CategoryTextAnnotation categoryTextAnnotation = (CategoryTextAnnotation) obj;
      return base.equals(obj) && Object.instancehelper_equals((object) this.category, (object) categoryTextAnnotation.getCategory()) && (this.categoryAnchor.equals((object) categoryTextAnnotation.getCategoryAnchor()) && this.value == categoryTextAnnotation.getValue());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 103, (byte) 113, (byte) 113, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 37 * (37 * base.hashCode() + Object.instancehelper_hashCode((object) this.category)) + Object.instancehelper_hashCode((object) this.categoryAnchor);
      long num2 = Double.doubleToLongBits(this.value);
      return 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 274)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
