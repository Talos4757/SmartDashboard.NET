// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.Outlier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.geom;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"java.lang.Comparable"})]
  public class Outlier : Object, Comparable
  {
    private Point2D point;
    private double radius;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 117, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Outlier(double xCoord, double yCoord, double radius)
    {
      base.\u002Ector();
      Outlier outlier = this;
      this.point = (Point2D) new Point2D.Double(xCoord - radius, yCoord - radius);
      this.radius = radius;
    }

    public virtual Point2D getPoint()
    {
      return this.point;
    }

    [LineNumberTable((ushort) 105)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getX()
    {
      return this.getPoint().getX();
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getY()
    {
      return this.getPoint().getY();
    }

    public virtual void setPoint(Point2D point)
    {
      this.point = point;
    }

    public virtual double getRadius()
    {
      return this.radius;
    }

    public virtual void setRadius(double radius)
    {
      this.radius = radius;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 103, (byte) 103, (byte) 103, (byte) 105, (byte) 130, (byte) 124, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object o)
    {
      Outlier outlier = (Outlier) o;
      Point2D point1 = this.getPoint();
      Point2D point2 = outlier.getPoint();
      if (point1.equals((object) point2))
        return 0;
      return point1.getX() < point2.getX() || point1.getY() < point2.getY() ? -1 : 1;
    }

    [LineNumberTable((ushort) 171)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool overlaps(Outlier other)
    {
      return other.getX() >= this.getX() - this.radius * 1.1 && other.getX() <= this.getX() + this.radius * 1.1 && (other.getY() >= this.getY() - this.radius * 1.1 && other.getY() <= this.getY() + this.radius * 1.1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Outlier))
        return false;
      Outlier outlier = (Outlier) obj;
      return this.point.equals((object) outlier.point) && this.radius == outlier.radius;
    }

    [LineNumberTable((ushort) 207)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("{").append(this.getX()).append(",").append(this.getY()).append("}").toString();
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
    }
  }
}
