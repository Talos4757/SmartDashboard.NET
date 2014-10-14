// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYDataImageAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "org.jfree.chart.annotations.XYAnnotationBoundsInfo"})]
  public class XYDataImageAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, XYAnnotationBoundsInfo
  {
    [NonSerialized]
    private Image image;
    private double x;
    private double y;
    private double w;
    private double h;
    private bool includeInDataBounds;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 109, (byte) 67, (byte) 136, (byte) 99, (byte) 144, (byte) 103, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDataImageAnnotation(Image image, double x, double y, double w, double h, bool includeInDataBounds)
    {
      int num = includeInDataBounds ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      XYDataImageAnnotation dataImageAnnotation = this;
      if (image == null)
      {
        string str = "Null 'image' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.image = image;
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.includeInDataBounds = num != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDataImageAnnotation(Image image, double x, double y, double w, double h)
      : this(image, x, y, w, h, false)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYDataImageAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    public virtual Image getImage()
    {
      return this.image;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual double getWidth()
    {
      return this.w;
    }

    public virtual double getHeight()
    {
      return this.h;
    }

    public virtual bool getIncludeInDataBounds()
    {
      return this.includeInDataBounds;
    }

    [LineNumberTable((ushort) 212)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getXRange()
    {
      return new Range(this.x, this.x + this.w);
    }

    [LineNumberTable((ushort) 223)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getYRange()
    {
      return new Range(this.y, this.y + this.h);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 103, (byte) 103, (byte) 103, (byte) 136, (byte) 137, (byte) 114, (byte) 115, (byte) 153, (byte) 154, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 100, (byte) 100, (byte) 100, (byte) 134, (byte) 104, (byte) 100, (byte) 100, (byte) 100, (byte) 164, (byte) 159, (byte) 31, (byte) 104, (byte) 104, (byte) 104, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      AxisLocation domainAxisLocation = plot.getDomainAxisLocation();
      AxisLocation rangeAxisLocation = plot.getRangeAxisLocation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(domainAxisLocation, orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(rangeAxisLocation, orientation);
      float num1 = (float) domainAxis.valueToJava2D(this.x, dataArea, re1);
      float num2 = (float) rangeAxis.valueToJava2D(this.y, dataArea, re2);
      float num3 = (float) domainAxis.valueToJava2D(this.x + this.w, dataArea, re1);
      float num4 = (float) rangeAxis.valueToJava2D(this.y + this.h, dataArea, re2);
      float num5 = 0.0f;
      float num6 = 0.0f;
      float num7 = 0.0f;
      float num8 = 0.0f;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num5 = num2;
        num7 = num4;
        num6 = num1;
        num8 = num3;
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num5 = num1;
        num7 = num3;
        num6 = num2;
        num8 = num4;
      }
      ((Graphics) g2).drawImage(this.image, ByteCodeHelper.f2i(num5), ByteCodeHelper.f2i(Math.min(num6, num8)), ByteCodeHelper.f2i(num7 - num5), ByteCodeHelper.f2i(Math.abs(num8 - num6)), (ImageObserver) null);
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, (Shape) new Rectangle2D.Float(num5, num6, num7 - num5, num8 - num6), rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYDataImageAnnotation))
        return false;
      XYDataImageAnnotation dataImageAnnotation = (XYDataImageAnnotation) obj;
      return this.x == dataImageAnnotation.x && this.y == dataImageAnnotation.y && (this.w == dataImageAnnotation.w && this.h == dataImageAnnotation.h) && (this.includeInDataBounds == dataImageAnnotation.includeInDataBounds && ObjectUtilities.equal((object) this.image, (object) dataImageAnnotation.image));
    }

    [LineNumberTable((ushort) 332)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return Object.instancehelper_hashCode((object) this.image);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 343)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 240, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
    }
  }
}
