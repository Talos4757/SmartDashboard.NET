// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.StandardDialScale
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialScale", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardDialScale : AbstractDialLayer, DialScale, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 3715644629665918516L;
    private double lowerBound;
    private double upperBound;
    private double startAngle;
    private double extent;
    private double tickRadius;
    private double majorTickIncrement;
    private double majorTickLength;
    [NonSerialized]
    private Paint majorTickPaint;
    [NonSerialized]
    private Stroke majorTickStroke;
    private int minorTickCount;
    private double minorTickLength;
    [NonSerialized]
    private Paint minorTickPaint;
    [NonSerialized]
    private Stroke minorTickStroke;
    private double tickLabelOffset;
    private Font tickLabelFont;
    private bool tickLabelsVisible;
    private NumberFormat tickLabelFormatter;
    private bool firstTickLabelVisible;
    [NonSerialized]
    private Paint tickLabelPaint;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 104, (byte) 105, (byte) 106, (byte) 105, (byte) 105, (byte) 112, (byte) 103, (byte) 112, (byte) 103, (byte) 115, (byte) 107, (byte) 112, (byte) 106, (byte) 112, (byte) 107, (byte) 112, (byte) 104, (byte) 112, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialScale(double lowerBound, double upperBound, double startAngle, double extent, double majorTickIncrement, int minorTickCount)
    {
      StandardDialScale standardDialScale = this;
      this.startAngle = startAngle;
      this.extent = extent;
      this.lowerBound = lowerBound;
      this.upperBound = upperBound;
      this.tickRadius = 0.7;
      this.tickLabelsVisible = true;
      this.tickLabelFormatter = (NumberFormat) new DecimalFormat("0.0");
      this.firstTickLabelVisible = true;
      this.tickLabelFont = new Font("Dialog", 1, 16);
      this.tickLabelPaint = (Paint) Color.blue;
      this.tickLabelOffset = 0.1;
      this.majorTickIncrement = majorTickIncrement;
      this.majorTickLength = 0.04;
      this.majorTickPaint = (Paint) Color.black;
      this.majorTickStroke = (Stroke) new BasicStroke(3f);
      this.minorTickCount = minorTickCount;
      this.minorTickLength = 0.02;
      this.minorTickPaint = (Paint) Color.black;
      this.minorTickStroke = (Stroke) new BasicStroke(1f);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 127, (byte) 19})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialScale()
      : this(0.0, 100.0, 175.0, -170.0, 10.0, 4)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardDialScale([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardDialScale obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardDialScale obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double valueToAngle(double value)
    {
      return this.startAngle + this.extent / (this.upperBound - this.lowerBound) * (value - this.lowerBound);
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerBound(double lower)
    {
      this.lowerBound = lower;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperBound(double upper)
    {
      this.upperBound = upper;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getStartAngle()
    {
      return this.startAngle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 187, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartAngle(double angle)
    {
      this.startAngle = angle;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getExtent()
    {
      return this.extent;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExtent(double extent)
    {
      this.extent = extent;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getTickRadius()
    {
      return this.tickRadius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 105, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickRadius(double radius)
    {
      if (radius <= 0.0)
      {
        string str = "The 'radius' must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickRadius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getMajorTickIncrement()
    {
      return this.majorTickIncrement;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 105, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMajorTickIncrement(double increment)
    {
      if (increment <= 0.0)
      {
        string str = "The 'increment' must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.majorTickIncrement = increment;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getMajorTickLength()
    {
      return this.majorTickLength;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMajorTickLength(double length)
    {
      if (length < 0.0)
      {
        string str = "Negative 'length' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.majorTickLength = length;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getMajorTickPaint()
    {
      return this.majorTickPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMajorTickPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.majorTickPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Stroke getMajorTickStroke()
    {
      return this.majorTickStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMajorTickStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.majorTickStroke = stroke;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual int getMinorTickCount()
    {
      return this.minorTickCount;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 119, (byte) 100, (byte) 176, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickCount(int count)
    {
      if (count < 0)
      {
        string str = "The 'count' cannot be negative.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickCount = count;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getMinorTickLength()
    {
      return this.minorTickLength;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickLength(double length)
    {
      if (length < 0.0)
      {
        string str = "Negative 'length' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickLength = length;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getMinorTickPaint()
    {
      return this.minorTickPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Stroke getMinorTickStroke()
    {
      return this.minorTickStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 207, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickStroke = stroke;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getTickLabelOffset()
    {
      return this.tickLabelOffset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 234, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelOffset(double offset)
    {
      this.tickLabelOffset = offset;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual Font getTickLabelFont()
    {
      return this.tickLabelFont;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickLabelFont = font;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getTickLabelPaint()
    {
      return this.tickLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 27, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickLabelPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual bool getTickLabelsVisible()
    {
      return this.tickLabelsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 228, (byte) 130, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelsVisible(bool visible)
    {
      this.tickLabelsVisible = visible;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual NumberFormat getTickLabelFormatter()
    {
      return this.tickLabelFormatter;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 82, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFormatter(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickLabelFormatter = formatter;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual bool getFirstTickLabelVisible()
    {
      return this.firstTickLabelVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 214, (byte) 98, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFirstTickLabelVisible(bool visible)
    {
      this.firstTickLabelVisible = visible;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 138, (byte) 147, (byte) 191, (byte) 2, (byte) 98, (byte) 118, (byte) 223, (byte) 2, (byte) 223, (byte) 2, (byte) 131, (byte) 103, (byte) 103, (byte) 149, (byte) 158, (byte) 105, (byte) 158, (byte) 105, (byte) 108, (byte) 108, (byte) 107, (byte) 104, (byte) 158, (byte) 137, (byte) 104, (byte) 108, (byte) 108, (byte) 108, (byte) 255, (byte) 10, (byte) 70, (byte) 163, (byte) 124, (byte) 147, (byte) 112, (byte) 110, (byte) 106, (byte) 133, (byte) 139, (byte) 152, (byte) 105, (byte) 152, (byte) 105, (byte) 108, (byte) 108, (byte) 107, (byte) 232, (byte) 48, (byte) 235, (byte) 33, (byte) 241, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Rectangle2D rectangle2D1 = DialPlot.rectangleByRadius(frame, this.tickRadius, this.tickRadius);
      Rectangle2D rectangle2D2 = DialPlot.rectangleByRadius(frame, this.tickRadius - this.majorTickLength, this.tickRadius - this.majorTickLength);
      Rectangle2D rectangle2D3 = rectangle2D1;
      if (this.minorTickCount > 0 && this.minorTickLength > 0.0)
        rectangle2D3 = DialPlot.rectangleByRadius(frame, this.tickRadius - this.minorTickLength, this.tickRadius - this.minorTickLength);
      Rectangle2D rectangle2D4 = DialPlot.rectangleByRadius(frame, this.tickRadius - this.tickLabelOffset, this.tickRadius - this.tickLabelOffset);
      int num1 = 1;
      Arc2D.Double double1 = new Arc2D.Double();
      Line2D.Double double2 = new Line2D.Double();
      double num2 = this.lowerBound;
      while (num2 <= this.upperBound)
      {
        ((Arc2D) double1).setArc(rectangle2D1, this.startAngle, this.valueToAngle(num2) - this.startAngle, 0);
        Point2D endPoint1 = ((Arc2D) double1).getEndPoint();
        ((Arc2D) double1).setArc(rectangle2D2, this.startAngle, this.valueToAngle(num2) - this.startAngle, 0);
        Point2D endPoint2 = ((Arc2D) double1).getEndPoint();
        g2.setPaint(this.majorTickPaint);
        g2.setStroke(this.majorTickStroke);
        ((Line2D) double2).setLine(endPoint1, endPoint2);
        g2.draw((Shape) double2);
        ((Arc2D) double1).setArc(rectangle2D4, this.startAngle, this.valueToAngle(num2) - this.startAngle, 0);
        Point2D endPoint3 = ((Arc2D) double1).getEndPoint();
        if (this.tickLabelsVisible && (num1 == 0 || this.firstTickLabelVisible))
        {
          ((Graphics) g2).setFont(this.tickLabelFont);
          g2.setPaint(this.tickLabelPaint);
          TextUtilities.drawAlignedString(this.tickLabelFormatter.format(num2), g2, (float) endPoint3.getX(), (float) endPoint3.getY(), TextAnchor.__\u003C\u003ECENTER);
        }
        num1 = 0;
        if (this.minorTickCount > 0 && this.minorTickLength > 0.0)
        {
          double num3 = this.majorTickIncrement / (double) (this.minorTickCount + 1);
          for (int index = 0; index < this.minorTickCount; ++index)
          {
            double num4 = num2 + (double) (index + 1) * num3;
            if (num4 < this.upperBound)
            {
              double num5 = this.valueToAngle(num4);
              ((Arc2D) double1).setArc(rectangle2D1, this.startAngle, num5 - this.startAngle, 0);
              Point2D endPoint4 = ((Arc2D) double1).getEndPoint();
              ((Arc2D) double1).setArc(rectangle2D3, this.startAngle, num5 - this.startAngle, 0);
              Point2D endPoint5 = ((Arc2D) double1).getEndPoint();
              g2.setStroke(this.minorTickStroke);
              g2.setPaint(this.minorTickPaint);
              ((Line2D) double2).setLine(endPoint4, endPoint5);
              g2.draw((Shape) double2);
            }
            else
              break;
          }
        }
        num2 += this.majorTickIncrement;
      }
    }

    public virtual double angleToValue(double angle)
    {
      return double.NaN;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 250, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardDialScale))
        return false;
      StandardDialScale standardDialScale = (StandardDialScale) obj;
      if (this.lowerBound != standardDialScale.lowerBound || this.upperBound != standardDialScale.upperBound || (this.startAngle != standardDialScale.startAngle || this.extent != standardDialScale.extent) || (this.tickRadius != standardDialScale.tickRadius || this.majorTickIncrement != standardDialScale.majorTickIncrement || (this.majorTickLength != standardDialScale.majorTickLength || !PaintUtilities.equal(this.majorTickPaint, standardDialScale.majorTickPaint))) || (!Object.instancehelper_equals((object) this.majorTickStroke, (object) standardDialScale.majorTickStroke) || this.minorTickCount != standardDialScale.minorTickCount || (this.minorTickLength != standardDialScale.minorTickLength || !PaintUtilities.equal(this.minorTickPaint, standardDialScale.minorTickPaint)) || (!Object.instancehelper_equals((object) this.minorTickStroke, (object) standardDialScale.minorTickStroke) || this.tickLabelsVisible != standardDialScale.tickLabelsVisible || (this.tickLabelOffset != standardDialScale.tickLabelOffset || !this.tickLabelFont.equals((object) standardDialScale.tickLabelFont)))) || !PaintUtilities.equal(this.tickLabelPaint, standardDialScale.tickLabelPaint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 61, (byte) 134, (byte) 108, (byte) 141, (byte) 108, (byte) 141, (byte) 108, (byte) 141, (byte) 108, (byte) 141, (byte) 108, (byte) 237, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.lowerBound);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.upperBound);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.startAngle);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.extent);
      int num9 = 37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
      long num10 = Double.doubleToLongBits(this.tickRadius);
      return 37 * num9 + (int) (num10 ^ (long) ((ulong) num10 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 983)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 112, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.majorTickPaint, obj0);
      SerialUtilities.writeStroke(this.majorTickStroke, obj0);
      SerialUtilities.writePaint(this.minorTickPaint, obj0);
      SerialUtilities.writeStroke(this.minorTickStroke, obj0);
      SerialUtilities.writePaint(this.tickLabelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 130, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.majorTickPaint = SerialUtilities.readPaint(obj0);
      this.majorTickStroke = SerialUtilities.readStroke(obj0);
      this.minorTickPaint = SerialUtilities.readPaint(obj0);
      this.minorTickStroke = SerialUtilities.readStroke(obj0);
      this.tickLabelPaint = SerialUtilities.readPaint(obj0);
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
