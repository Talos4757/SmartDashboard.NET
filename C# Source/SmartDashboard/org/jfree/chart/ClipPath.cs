// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ClipPath
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.lang.Cloneable"})]
  [Obsolete]
  public class ClipPath : Object, Cloneable.__Interface
  {
    private double[] xValue;
    private double[] yValue;
    private bool clip;
    private bool drawPath;
    private bool fillPath;
    private Paint fillPaint;
    private Paint drawPaint;
    private Stroke drawStroke;
    private Composite composite;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 104, (byte) 232, (byte) 3, (byte) 167, (byte) 199, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 101, (byte) 103, (byte) 135, (byte) 103, (byte) 103, (byte) 135, (byte) 107, (byte) 107, (byte) 112, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClipPath(double[] xValue, double[] yValue, bool clip, bool fillPath, bool drawPath)
    {
      int num1 = clip ? 1 : 0;
      int num2 = fillPath ? 1 : 0;
      int num3 = drawPath ? 1 : 0;
      base.\u002Ector();
      ClipPath clipPath = this;
      this.xValue = (double[]) null;
      this.yValue = (double[]) null;
      this.clip = true;
      this.drawPath = false;
      this.fillPath = false;
      this.fillPaint = (Paint) null;
      this.drawPaint = (Paint) null;
      this.drawStroke = (Stroke) null;
      this.composite = (Composite) null;
      this.xValue = xValue;
      this.yValue = yValue;
      this.clip = num1 != 0;
      this.fillPath = num2 != 0;
      this.drawPath = num3 != 0;
      this.fillPaint = (Paint) Color.gray;
      this.drawPaint = (Paint) Color.blue;
      this.drawStroke = (Stroke) new BasicStroke(1f);
      this.composite = (Composite) AlphaComposite.Src;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 232, (byte) 33, (byte) 167, (byte) 199, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClipPath()
    {
      base.\u002Ector();
      ClipPath clipPath = this;
      this.xValue = (double[]) null;
      this.yValue = (double[]) null;
      this.clip = true;
      this.drawPath = false;
      this.fillPath = false;
      this.fillPaint = (Paint) null;
      this.drawPaint = (Paint) null;
      this.drawStroke = (Stroke) null;
      this.composite = (Composite) null;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClipPath(double[] xValue, double[] yValue)
      : this(xValue, yValue, true, false, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 101, (byte) 101, (byte) 232, (byte) 159, (byte) 167, (byte) 167, (byte) 199, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 160, (byte) 66, (byte) 103, (byte) 135, (byte) 103, (byte) 135, (byte) 104, (byte) 104, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClipPath(double[] xValue, double[] yValue, bool fillPath, bool drawPath, Paint fillPaint, Paint drawPaint, Stroke drawStroke, Composite composite)
    {
      int num1 = fillPath ? 1 : 0;
      int num2 = drawPath ? 1 : 0;
      base.\u002Ector();
      ClipPath clipPath = this;
      this.xValue = (double[]) null;
      this.yValue = (double[]) null;
      this.clip = true;
      this.drawPath = false;
      this.fillPath = false;
      this.fillPaint = (Paint) null;
      this.drawPaint = (Paint) null;
      this.drawStroke = (Stroke) null;
      this.composite = (Composite) null;
      this.xValue = xValue;
      this.yValue = yValue;
      this.fillPath = num1 != 0;
      this.drawPath = num2 != 0;
      this.fillPaint = fillPaint;
      this.drawPaint = drawPaint;
      this.drawStroke = drawStroke;
      this.composite = composite;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ClipPath obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 102, (byte) 182, (byte) 182, (byte) 106, (byte) 108, (byte) 182, (byte) 182, (byte) 234, (byte) 57, (byte) 230, (byte) 73, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual GeneralPath generateClipPath(Rectangle2D dataArea, ValueAxis horizontalAxis, ValueAxis verticalAxis)
    {
      GeneralPath generalPath = new GeneralPath();
      double num1 = horizontalAxis.valueToJava2D(this.xValue[0], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
      double num2 = verticalAxis.valueToJava2D(this.yValue[0], dataArea, RectangleEdge.__\u003C\u003ELEFT);
      ((Path2D.Float) generalPath).moveTo((float) num1, (float) num2);
      for (int index = 0; index < this.yValue.Length; ++index)
      {
        double num3 = horizontalAxis.valueToJava2D(this.xValue[index], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        double num4 = verticalAxis.valueToJava2D(this.yValue[index], dataArea, RectangleEdge.__\u003C\u003ELEFT);
        ((Path2D.Float) generalPath).lineTo((float) num3, (float) num4);
      }
      ((Path2D) generalPath).closePath();
      return generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 171, (byte) 115, (byte) 103, (byte) 103, (byte) 135, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 167, (byte) 104, (byte) 140, (byte) 104, (byte) 135, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual GeneralPath draw(Graphics2D g2, Rectangle2D dataArea, ValueAxis horizontalAxis, ValueAxis verticalAxis)
    {
      GeneralPath generalPath = this.generateClipPath(dataArea, horizontalAxis, verticalAxis);
      if (this.fillPath || this.drawPath)
      {
        Composite composite = g2.getComposite();
        Paint paint = g2.getPaint();
        Stroke stroke = g2.getStroke();
        if (this.fillPaint != null)
          g2.setPaint(this.fillPaint);
        if (this.composite != null)
          g2.setComposite(this.composite);
        if (this.fillPath)
          g2.fill((Shape) generalPath);
        if (this.drawStroke != null)
          g2.setStroke(this.drawStroke);
        if (this.drawPath)
          g2.draw((Shape) generalPath);
        g2.setPaint(paint);
        g2.setComposite(composite);
        g2.setStroke(stroke);
      }
      return generalPath;
    }

    public virtual Composite getComposite()
    {
      return this.composite;
    }

    public virtual Paint getDrawPaint()
    {
      return this.drawPaint;
    }

    public virtual bool isDrawPath()
    {
      return this.drawPath;
    }

    public virtual Stroke getDrawStroke()
    {
      return this.drawStroke;
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    public virtual bool isFillPath()
    {
      return this.fillPath;
    }

    public virtual double[] getXValue()
    {
      return this.xValue;
    }

    public virtual double[] getYValue()
    {
      return this.yValue;
    }

    public virtual void setComposite(Composite composite)
    {
      this.composite = composite;
    }

    public virtual void setDrawPaint(Paint drawPaint)
    {
      this.drawPaint = drawPaint;
    }

    public virtual void setDrawPath(bool drawPath)
    {
      this.drawPath = drawPath;
    }

    public virtual void setDrawStroke(Stroke drawStroke)
    {
      this.drawStroke = drawStroke;
    }

    public virtual void setFillPaint(Paint fillPaint)
    {
      this.fillPaint = fillPaint;
    }

    public virtual void setFillPath(bool fillPath)
    {
      this.fillPath = fillPath;
    }

    public virtual void setXValue(double[] xValue)
    {
      this.xValue = xValue;
    }

    public virtual void setYValue(double[] yValue)
    {
      this.yValue = yValue;
    }

    public virtual bool isClip()
    {
      return this.clip;
    }

    public virtual void setClip(bool clip)
    {
      this.clip = clip;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 63, (byte) 108, (byte) 123, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      ClipPath clipPath = (ClipPath) base.clone();
      clipPath.xValue = (double[]) this.xValue.Clone();
      clipPath.yValue = (double[]) this.yValue.Clone();
      return (object) clipPath;
    }
  }
}
