// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialPointer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class DialPointer : AbstractDialLayer, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal double radius;
    internal int datasetIndex;

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 112, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal DialPointer(int datasetIndex)
    {
      DialPointer dialPointer = this;
      this.radius = 0.9;
      this.datasetIndex = datasetIndex;
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal DialPointer()
      : this(0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialPointer([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DialPointer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DialPointer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getDatasetIndex()
    {
      return this.datasetIndex;
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDatasetIndex(int index)
    {
      this.datasetIndex = index;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getRadius()
    {
      return this.radius;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadius(double radius)
    {
      this.radius = radius;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DialPointer))
        return false;
      DialPointer dialPointer = (DialPointer) obj;
      if (this.datasetIndex != dialPointer.datasetIndex || this.radius != dialPointer.radius)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 99, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(23, this.radius);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 204)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [InnerClass]
    [SourceFile("DialPointer.java")]
    [Serializable]
    public class Pin : DialPointer
    {
      internal const long serialVersionUID = -8445860485367689750L;
      [NonSerialized]
      private Paint paint;
      [NonSerialized]
      private Stroke stroke;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 105, (byte) 107, (byte) 146})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Pin(int datasetIndex)
        : base(datasetIndex)
      {
        DialPointer.Pin pin = this;
        this.paint = (Paint) Color.red;
        this.stroke = (Stroke) new BasicStroke(3f, 1, 2);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Pin()
        : this(0)
      {
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Pin([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual Paint getPaint()
      {
        return this.paint;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
        {
          this.paint = paint;
          this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
        }
      }

      public virtual Stroke getStroke()
      {
        return this.stroke;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
        {
          this.stroke = stroke;
          this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
        }
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 108, (byte) 108, (byte) 179, (byte) 110, (byte) 109, (byte) 137, (byte) 111, (byte) 137, (byte) 159, (byte) 2, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
      {
        g2.setPaint(this.paint);
        g2.setStroke(this.stroke);
        Rectangle2D rectangle2D = DialPlot.rectangleByRadius(frame, this.radius, this.radius);
        double d = plot.getValue(this.datasetIndex);
        double num = plot.getScaleForDataset(this.datasetIndex).valueToAngle(d);
        Point2D endPoint = ((Arc2D) new Arc2D.Double(rectangle2D, num, 0.0, 0)).getEndPoint();
        Line2D.Double @double = new Line2D.Double(((RectangularShape) frame).getCenterX(), ((RectangularShape) frame).getCenterY(), endPoint.getX(), endPoint.getY());
        g2.draw((Shape) @double);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool equals(object obj)
      {
        if (obj == this)
          return true;
        if (!(obj is DialPointer.Pin))
          return false;
        DialPointer.Pin pin = (DialPointer.Pin) obj;
        if (!PaintUtilities.equal(this.paint, pin.paint) || !Object.instancehelper_equals((object) this.stroke, (object) pin.stroke))
          return false;
        return (base.equals(obj) ? 1 : 0) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 238, (byte) 103, (byte) 109, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int hashCode()
      {
        return HashUtilities.hashCode(HashUtilities.hashCode(base.hashCode(), this.paint), this.stroke);
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 102, (byte) 108, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void writeObject([In] ObjectOutputStream obj0)
      {
        obj0.defaultWriteObject();
        SerialUtilities.writePaint(this.paint, obj0);
        SerialUtilities.writeStroke(this.stroke, obj0);
      }

      [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
      [LineNumberTable(new byte[] {(byte) 161, (byte) 11, (byte) 102, (byte) 108, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void readObject([In] ObjectInputStream obj0)
      {
        obj0.defaultReadObject();
        this.paint = SerialUtilities.readPaint(obj0);
        this.stroke = SerialUtilities.readStroke(obj0);
      }
    }

    [InnerClass]
    [SourceFile("DialPointer.java")]
    [Serializable]
    public class Pointer : DialPointer
    {
      internal const long serialVersionUID = -4180500011963176960L;
      private double widthRadius;
      [NonSerialized]
      private Paint fillPaint;
      [NonSerialized]
      private Paint outlinePaint;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 105, (byte) 112, (byte) 107, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Pointer(int datasetIndex)
        : base(datasetIndex)
      {
        DialPointer.Pointer pointer = this;
        this.widthRadius = 0.05;
        this.fillPaint = (Paint) Color.gray;
        this.outlinePaint = (Paint) Color.black;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Pointer()
        : this(0)
      {
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Pointer([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual double getWidthRadius()
      {
        return this.widthRadius;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 105, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setWidthRadius(double radius)
      {
        this.widthRadius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }

      public virtual Paint getFillPaint()
      {
        return this.fillPaint;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFillPaint(Paint paint)
      {
        if (paint == null)
        {
          string str = "Null 'paint' argument.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          this.fillPaint = paint;
          this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
        }
      }

      public virtual Paint getOutlinePaint()
      {
        return this.outlinePaint;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 143, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setOutlinePaint(Paint paint)
      {
        if (paint == null)
        {
          string str = "Null 'paint' argument.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          this.outlinePaint = paint;
          this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
        }
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 161, (byte) 107, (byte) 112, (byte) 147, (byte) 147, (byte) 110, (byte) 109, (byte) 138, (byte) 112, (byte) 105, (byte) 158, (byte) 105, (byte) 105, (byte) 154, (byte) 137, (byte) 103, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 103, (byte) 108, (byte) 136, (byte) 108, (byte) 159, (byte) 2, (byte) 136, (byte) 107, (byte) 136, (byte) 107, (byte) 136, (byte) 107, (byte) 136, (byte) 107, (byte) 136, (byte) 107, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
      {
        g2.setPaint((Paint) Color.blue);
        g2.setStroke((Stroke) new BasicStroke(1f));
        Rectangle2D rectangle2D1 = DialPlot.rectangleByRadius(frame, this.radius, this.radius);
        Rectangle2D rectangle2D2 = DialPlot.rectangleByRadius(frame, this.widthRadius, this.widthRadius);
        double d = plot.getValue(this.datasetIndex);
        double num = plot.getScaleForDataset(this.datasetIndex).valueToAngle(d);
        Point2D endPoint1 = ((Arc2D) new Arc2D.Double(rectangle2D1, num, 0.0, 0)).getEndPoint();
        Arc2D.Double double1 = new Arc2D.Double(rectangle2D2, num - 90.0, 180.0, 0);
        Point2D startPoint1 = ((Arc2D) double1).getStartPoint();
        Point2D endPoint2 = ((Arc2D) double1).getEndPoint();
        Point2D startPoint2 = ((Arc2D) new Arc2D.Double(rectangle2D2, num - 180.0, 0.0, 0)).getStartPoint();
        GeneralPath generalPath = new GeneralPath();
        ((Path2D.Float) generalPath).moveTo((float) endPoint1.getX(), (float) endPoint1.getY());
        ((Path2D.Float) generalPath).lineTo((float) startPoint1.getX(), (float) startPoint1.getY());
        ((Path2D.Float) generalPath).lineTo((float) startPoint2.getX(), (float) startPoint2.getY());
        ((Path2D.Float) generalPath).lineTo((float) endPoint2.getX(), (float) endPoint2.getY());
        ((Path2D) generalPath).closePath();
        g2.setPaint(this.fillPaint);
        g2.fill((Shape) generalPath);
        g2.setPaint(this.outlinePaint);
        Line2D.Double double2 = new Line2D.Double(((RectangularShape) frame).getCenterX(), ((RectangularShape) frame).getCenterY(), endPoint1.getX(), endPoint1.getY());
        g2.draw((Shape) double2);
        ((Line2D) double2).setLine(startPoint1, endPoint2);
        g2.draw((Shape) double2);
        ((Line2D) double2).setLine(endPoint2, endPoint1);
        g2.draw((Shape) double2);
        ((Line2D) double2).setLine(startPoint1, endPoint1);
        g2.draw((Shape) double2);
        ((Line2D) double2).setLine(startPoint1, startPoint2);
        g2.draw((Shape) double2);
        ((Line2D) double2).setLine(endPoint2, startPoint2);
        g2.draw((Shape) double2);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool equals(object obj)
      {
        if (obj == this)
          return true;
        if (!(obj is DialPointer.Pointer))
          return false;
        DialPointer.Pointer pointer = (DialPointer.Pointer) obj;
        if (this.widthRadius != pointer.widthRadius || !PaintUtilities.equal(this.fillPaint, pointer.fillPaint) || !PaintUtilities.equal(this.outlinePaint, pointer.outlinePaint))
          return false;
        return (base.equals(obj) ? 1 : 0) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 245, (byte) 103, (byte) 109, (byte) 109, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int hashCode()
      {
        return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(base.hashCode(), this.widthRadius), this.fillPaint), this.outlinePaint);
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 162, (byte) 4, (byte) 102, (byte) 108, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void writeObject([In] ObjectOutputStream obj0)
      {
        obj0.defaultWriteObject();
        SerialUtilities.writePaint(this.fillPaint, obj0);
        SerialUtilities.writePaint(this.outlinePaint, obj0);
      }

      [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
      [LineNumberTable(new byte[] {(byte) 162, (byte) 19, (byte) 102, (byte) 108, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void readObject([In] ObjectInputStream obj0)
      {
        obj0.defaultReadObject();
        this.fillPaint = SerialUtilities.readPaint(obj0);
        this.outlinePaint = SerialUtilities.readPaint(obj0);
      }
    }
  }
}
