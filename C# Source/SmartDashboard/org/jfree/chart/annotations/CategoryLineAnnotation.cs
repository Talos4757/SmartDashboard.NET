// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.CategoryLineAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"org.jfree.chart.annotations.CategoryAnnotation", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryLineAnnotation : Object, CategoryAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 3477740483341587984L;
    private IComparable category1;
    private double value1;
    private IComparable category2;
    private double value2;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Stroke stroke;

    [LineNumberTable(new byte[] {(byte) 61, (byte) 232, (byte) 46, (byte) 171, (byte) 240, (byte) 80, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 103, (byte) 105, (byte) 103, (byte) 106, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLineAnnotation(IComparable category1, double value1, IComparable category2, double value2, Paint paint, Stroke stroke)
    {
      base.\u002Ector();
      CategoryLineAnnotation categoryLineAnnotation = this;
      this.paint = (Paint) Color.black;
      this.stroke = (Stroke) new BasicStroke(1f);
      if (category1 == null)
      {
        string str = "Null 'category1' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (category2 == null)
      {
        string str = "Null 'category2' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.category1 = category1;
        this.value1 = value1;
        this.category2 = category2;
        this.value2 = value2;
        this.paint = paint;
        this.stroke = stroke;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryLineAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryLineAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryLineAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual IComparable getCategory1()
    {
      return this.category1;
    }

    public virtual double getValue1()
    {
      return this.value1;
    }

    public virtual IComparable getCategory2()
    {
      return this.category2;
    }

    public virtual double getValue2()
    {
      return this.value2;
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategory1(IComparable category)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.category1 = category;
    }

    public virtual void setValue1(double value)
    {
      this.value1 = value;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategory2(IComparable category)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.category2 = category;
    }

    public virtual void setValue2(double value)
    {
      this.value2 = value;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.paint = paint;
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.stroke = stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 103, (byte) 109, (byte) 109, (byte) 135, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 143, (byte) 175, (byte) 105, (byte) 180, (byte) 115, (byte) 180, (byte) 149, (byte) 105, (byte) 180, (byte) 115, (byte) 180, (byte) 147, (byte) 108, (byte) 108, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea, CategoryAxis domainAxis, ValueAxis rangeAxis)
    {
      CategoryDataset dataset = plot.getDataset();
      int columnIndex1 = dataset.getColumnIndex(this.category1);
      int columnIndex2 = dataset.getColumnIndex(this.category2);
      int columnCount = dataset.getColumnCount();
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge edge = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num2 = domainAxis.getCategoryJava2DCoordinate(CategoryAnchor.__\u003C\u003EMIDDLE, columnIndex1, columnCount, dataArea, edge);
        num1 = rangeAxis.valueToJava2D(this.value1, dataArea, re);
        num4 = domainAxis.getCategoryJava2DCoordinate(CategoryAnchor.__\u003C\u003EMIDDLE, columnIndex2, columnCount, dataArea, edge);
        num3 = rangeAxis.valueToJava2D(this.value2, dataArea, re);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num1 = domainAxis.getCategoryJava2DCoordinate(CategoryAnchor.__\u003C\u003EMIDDLE, columnIndex1, columnCount, dataArea, edge);
        num2 = rangeAxis.valueToJava2D(this.value1, dataArea, re);
        num3 = domainAxis.getCategoryJava2DCoordinate(CategoryAnchor.__\u003C\u003EMIDDLE, columnIndex2, columnCount, dataArea, edge);
        num4 = rangeAxis.valueToJava2D(this.value2, dataArea, re);
      }
      g2.setPaint(this.paint);
      g2.setStroke(this.stroke);
      ((Graphics) g2).drawLine(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num4));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryLineAnnotation))
        return false;
      CategoryLineAnnotation categoryLineAnnotation = (CategoryLineAnnotation) obj;
      return Object.instancehelper_equals((object) this.category1, (object) categoryLineAnnotation.getCategory1()) && this.value1 == categoryLineAnnotation.getValue1() && (Object.instancehelper_equals((object) this.category2, (object) categoryLineAnnotation.getCategory2()) && this.value2 == categoryLineAnnotation.getValue2()) && (PaintUtilities.equal(this.paint, categoryLineAnnotation.paint) && ObjectUtilities.equal((object) this.stroke, (object) categoryLineAnnotation.stroke));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 102, (byte) 113, (byte) 108, (byte) 109, (byte) 113, (byte) 108, (byte) 109, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 37 * 193 + Object.instancehelper_hashCode((object) this.category1);
      long num2 = Double.doubleToLongBits(this.value1);
      int num3 = 37 * (37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32))) + Object.instancehelper_hashCode((object) this.category2);
      long num4 = Double.doubleToLongBits(this.value2);
      return 37 * (37 * (37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32))) + HashUtilities.hashCodeForPaint(this.paint)) + Object.instancehelper_hashCode((object) this.stroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 391)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 32, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 47, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
