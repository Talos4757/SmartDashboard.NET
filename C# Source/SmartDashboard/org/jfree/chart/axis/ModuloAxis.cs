// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.ModuloAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using org.jfree.chart.@event;
using org.jfree.data;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class ModuloAxis : NumberAxis
  {
    private Range fixedRange;
    private double displayStart;
    private double displayEnd;

    [HideFromJava]
    static ModuloAxis()
    {
      NumberAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 105, (byte) 103, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuloAxis(string label, Range fixedRange)
      : base(label)
    {
      ModuloAxis moduloAxis = this;
      this.fixedRange = fixedRange;
      this.displayStart = 270.0;
      this.displayEnd = 90.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ModuloAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 109, (byte) 109, (byte) 101, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double mapValueToFixedRange([In] double obj0)
    {
      double lowerBound = this.fixedRange.getLowerBound();
      double length = this.fixedRange.getLength();
      if (obj0 < lowerBound)
        return lowerBound + length + (obj0 - lowerBound) % length;
      else
        return lowerBound + (obj0 - lowerBound) % length;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 145, (byte) 104, (byte) 104, (byte) 143, (byte) 104, (byte) 222})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double trans([In] double obj0, [In] Rectangle2D obj1, [In] RectangleEdge obj2)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(obj2))
      {
        num1 = ((RectangularShape) obj1).getX();
        num2 = ((RectangularShape) obj1).getX() + ((RectangularShape) obj1).getWidth();
      }
      else if (RectangleEdge.isLeftOrRight(obj2))
      {
        num1 = ((RectangularShape) obj1).getMaxY();
        num2 = ((RectangularShape) obj1).getMaxY() - ((RectangularShape) obj1).getHeight();
      }
      if (this.isInverted())
        return num2 - (obj0 - this.displayStart) / (this.displayEnd - this.displayStart) * (num2 - num1);
      else
        return num1 + (obj0 - this.displayStart) / (this.displayEnd - this.displayStart) * (num2 - num1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 157, (byte) 104, (byte) 104, (byte) 187, (byte) 104, (byte) 255, (byte) 4, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double transStart([In] double obj0, [In] Rectangle2D obj1, [In] RectangleEdge obj2, [In] double obj3, [In] double obj4)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(obj2))
      {
        num1 = ((RectangularShape) obj1).getX();
        num2 = ((RectangularShape) obj1).getX() + ((RectangularShape) obj1).getWidth() * obj3 / (obj3 + obj4);
      }
      else if (RectangleEdge.isLeftOrRight(obj2))
      {
        num1 = ((RectangularShape) obj1).getMaxY();
        num2 = ((RectangularShape) obj1).getMaxY() - ((RectangularShape) obj1).getHeight() * obj3 / (obj3 + obj4);
      }
      if (this.isInverted())
        return num2 - (obj0 - this.displayStart) / (this.fixedRange.getUpperBound() - this.displayStart) * (num2 - num1);
      else
        return num1 + (obj0 - this.displayStart) / (this.fixedRange.getUpperBound() - this.displayStart) * (num2 - num1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 189, (byte) 104, (byte) 104, (byte) 187, (byte) 104, (byte) 255, (byte) 9, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double transEnd([In] double obj0, [In] Rectangle2D obj1, [In] RectangleEdge obj2, [In] double obj3, [In] double obj4)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(obj2))
      {
        num2 = ((RectangularShape) obj1).getMaxX();
        num1 = ((RectangularShape) obj1).getMaxX() - ((RectangularShape) obj1).getWidth() * obj4 / (obj3 + obj4);
      }
      else if (RectangleEdge.isLeftOrRight(obj2))
      {
        num2 = ((RectangularShape) obj1).getMinY();
        num1 = ((RectangularShape) obj1).getMinY() + ((RectangularShape) obj1).getHeight() * obj4 / (obj3 + obj4);
      }
      if (this.isInverted())
        return num2 - (obj0 - this.fixedRange.getLowerBound()) / (this.displayEnd - this.fixedRange.getLowerBound()) * (num2 - num1);
      else
        return num1 + (obj0 - this.fixedRange.getLowerBound()) / (this.displayEnd - this.fixedRange.getLowerBound()) * (num2 - num1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 110, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getDisplayLength()
    {
      if (this.displayStart < this.displayEnd)
        return this.displayEnd - this.displayStart;
      else
        return this.fixedRange.getUpperBound() - this.displayStart + (this.displayEnd - this.fixedRange.getLowerBound());
    }

    [LineNumberTable((ushort) 332)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getDisplayCentralValue()
    {
      return this.mapValueToFixedRange(this.displayStart + this.getDisplayLength() / 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 105, (byte) 117, (byte) 110, (byte) 130, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void resizeRange(double percent, double anchorValue)
    {
      if (percent > 0.0)
      {
        double num = this.getDisplayLength() * percent / 2.0;
        this.setDisplayRange(anchorValue - num, anchorValue + num);
      }
      else
        this.setAutoRange(true);
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 111, (byte) 111, (byte) 110, (byte) 180, (byte) 191, (byte) 11, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDisplayRange(double start, double end)
    {
      this.displayStart = this.mapValueToFixedRange(start);
      this.displayEnd = this.mapValueToFixedRange(end);
      if (this.displayStart < this.displayEnd)
        this.setRange(this.displayStart, this.displayEnd);
      else
        this.setRange(this.displayStart, this.fixedRange.getUpperBound() + (this.displayEnd - this.fixedRange.getLowerBound()));
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual double getDisplayStart()
    {
      return this.displayStart;
    }

    public virtual double getDisplayEnd()
    {
      return this.displayEnd;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      this.setRange(this.fixedRange, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 102, (byte) 106, (byte) 110, (byte) 176, (byte) 121, (byte) 148, (byte) 117, (byte) 100, (byte) 176, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = this.mapValueToFixedRange(value);
      double num2;
      if (this.displayStart < this.displayEnd)
      {
        num2 = this.trans(num1, area, edge);
      }
      else
      {
        double num3 = (this.displayStart + this.displayEnd) / 2.0;
        double num4 = this.fixedRange.getUpperBound() - this.displayStart;
        double num5 = this.displayEnd - this.fixedRange.getLowerBound();
        num2 = num1 <= num3 ? this.transEnd(num1, area, edge, num4, num5) : this.transStart(num1, area, edge, num4, num5);
      }
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 187, (byte) 102, (byte) 110, (byte) 236, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D area, RectangleEdge edge)
    {
      double num = 0.0;
      if (this.displayStart < this.displayEnd)
        num = base.java2DToValue(java2DValue, area, edge);
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 234, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void resizeRange(double percent)
    {
      this.resizeRange(percent, this.getDisplayCentralValue());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 16, (byte) 102, (byte) 110, (byte) 177, (byte) 191, (byte) 8, (byte) 102, (byte) 104, (byte) 170, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double lengthToJava2D(double length, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = this.displayEnd <= this.displayStart ? this.fixedRange.getUpperBound() - this.displayStart + (this.displayEnd - this.fixedRange.getLowerBound()) : this.displayEnd - this.displayStart;
      double num2 = !RectangleEdge.isLeftOrRight(edge) ? ((RectangularShape) area).getWidth() : ((RectangularShape) area).getHeight();
      return length / num1 * num2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ModuloAxis))
        return false;
      ModuloAxis moduloAxis = (ModuloAxis) obj;
      if (this.displayStart != moduloAxis.displayStart || this.displayEnd != moduloAxis.displayEnd || !this.fixedRange.equals((object) moduloAxis.fixedRange))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
