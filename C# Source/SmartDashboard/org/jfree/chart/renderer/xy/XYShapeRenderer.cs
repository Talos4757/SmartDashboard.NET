// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYShapeRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYShapeRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 8320552104211173221L;
    private PaintScale paintScale;
    private bool drawOutlines;
    private bool useOutlinePaint;
    private bool useFillPaint;
    private bool guideLinesVisible;
    [NonSerialized]
    private Paint guideLinePaint;
    [NonSerialized]
    private Stroke guideLineStroke;

    [HideFromJava]
    static XYShapeRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 104, (byte) 107, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 127, (byte) 16, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYShapeRenderer()
    {
      XYShapeRenderer xyShapeRenderer = this;
      this.paintScale = (PaintScale) new LookupPaintScale();
      this.useFillPaint = false;
      this.drawOutlines = false;
      this.useOutlinePaint = true;
      this.guideLinesVisible = false;
      this.guideLinePaint = (Paint) Color.darkGray;
      this.guideLineStroke = (Stroke) new BasicStroke();
      this.setBaseShape((Shape) new Ellipse2D.Double(-5.0, -5.0, 10.0, 10.0));
      this.setAutoPopulateSeriesShape(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYShapeRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYShapeRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYShapeRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 98, (byte) 104, (byte) 111, (byte) 109, (byte) 130, (byte) 104, (byte) 171, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint getPaint(XYDataset dataset, int series, int item)
    {
      return !(dataset is XYZDataset) ? (!this.useFillPaint ? this.getItemPaint(series, item) : this.getItemFillPaint(series, item)) : this.paintScale.getPaint(((XYZDataset) dataset).getZValue(series, item));
    }

    public virtual bool getUseOutlinePaint()
    {
      return this.useOutlinePaint;
    }

    public virtual PaintScale getPaintScale()
    {
      return this.paintScale;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaintScale(PaintScale scale)
    {
      if (scale == null)
      {
        string str = "Null 'scale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paintScale = scale;
        this.notifyListeners(new RendererChangeEvent((object) this));
      }
    }

    public virtual bool getDrawOutlines()
    {
      return this.drawOutlines;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawOutlines(bool flag)
    {
      this.drawOutlines = flag;
      this.fireChangeEvent();
    }

    public virtual bool getUseFillPaint()
    {
      return this.useFillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseFillPaint(bool flag)
    {
      this.useFillPaint = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 79, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseOutlinePaint(bool use)
    {
      this.useOutlinePaint = use;
      this.fireChangeEvent();
    }

    public virtual bool isGuideLinesVisible()
    {
      return this.guideLinesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 72, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGuideLinesVisible(bool visible)
    {
      this.guideLinesVisible = visible;
      this.fireChangeEvent();
    }

    public virtual Paint getGuideLinePaint()
    {
      return this.guideLinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGuideLinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.guideLinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getGuideLineStroke()
    {
      return this.guideLineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGuideLineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.guideLineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 234, (byte) 99, (byte) 104, (byte) 102, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      Range domainBounds = DatasetUtilities.findDomainBounds(dataset, false);
      double num = 0.0;
      return new Range(domainBounds.getLowerBound() + num, domainBounds.getUpperBound() + num);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 99, (byte) 104, (byte) 102, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      Range rangeBounds = DatasetUtilities.findRangeBounds(dataset, false);
      double num = 0.0;
      return new Range(rangeBounds.getLowerBound() + num, rangeBounds.getUpperBound() + num);
    }

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 98, (byte) 98, (byte) 100, (byte) 173, (byte) 109, (byte) 109, (byte) 144, (byte) 161, (byte) 146, (byte) 179, (byte) 169, (byte) 114, (byte) 108, (byte) 108, (byte) 105, (byte) 155, (byte) 222, (byte) 153, (byte) 223, (byte) 1, (byte) 104, (byte) 108, (byte) 105, (byte) 174, (byte) 105, (byte) 172, (byte) 100, (byte) 138, (byte) 114, (byte) 136, (byte) 104, (byte) 104, (byte) 178, (byte) 144, (byte) 112, (byte) 232, (byte) 69, (byte) 99, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      if (Double.isNaN(xvalue) || Double.isNaN(yvalue))
        return;
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, plot.getDomainAxisEdge());
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, plot.getRangeAxisEdge());
      PlotOrientation orientation = plot.getOrientation();
      if (pass == 0 && this.guideLinesVisible)
      {
        g2.setStroke(this.guideLineStroke);
        g2.setPaint(this.guideLinePaint);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          g2.draw((Shape) new Line2D.Double(num2, ((RectangularShape) dataArea).getMinY(), num2, ((RectangularShape) dataArea).getMaxY()));
          g2.draw((Shape) new Line2D.Double(((RectangularShape) dataArea).getMinX(), num1, ((RectangularShape) dataArea).getMaxX(), num1));
        }
        else
        {
          g2.draw((Shape) new Line2D.Double(num1, ((RectangularShape) dataArea).getMinY(), num1, ((RectangularShape) dataArea).getMaxY()));
          g2.draw((Shape) new Line2D.Double(((RectangularShape) dataArea).getMinX(), num2, ((RectangularShape) dataArea).getMaxX(), num2));
        }
      }
      else
      {
        if (pass != 1)
          return;
        Shape shape = this.getItemShape(series, item);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num2, num1);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num1, num2);
        Shape area = shape;
        if (shape.intersects(dataArea))
        {
          g2.setPaint(this.getPaint(dataset, series, item));
          g2.fill(shape);
          if (this.drawOutlines)
          {
            if (this.getUseOutlinePaint())
              g2.setPaint(this.getItemOutlinePaint(series, item));
            else
              g2.setPaint(this.getItemPaint(series, item));
            g2.setStroke(this.getItemOutlineStroke(series, item));
            g2.draw(shape);
          }
        }
        if (entities == null)
          return;
        this.addEntity(entities, area, dataset, series, item, num1, num2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 154, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 159, (byte) 4, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 159, (byte) 4, (byte) 98, (byte) 159, (byte) 4, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYShapeRenderer))
        return false;
      XYShapeRenderer xyShapeRenderer = (XYShapeRenderer) obj;
      if (this.paintScale == null && xyShapeRenderer.paintScale != null || (!Object.instancehelper_equals((object) this.paintScale, (object) xyShapeRenderer.paintScale) || this.drawOutlines != xyShapeRenderer.drawOutlines) || (this.useOutlinePaint != xyShapeRenderer.useOutlinePaint || this.useFillPaint != xyShapeRenderer.useFillPaint || this.guideLinesVisible != xyShapeRenderer.guideLinesVisible) || (this.guideLinePaint == null && xyShapeRenderer.guideLinePaint != null || !Object.instancehelper_equals((object) this.guideLinePaint, (object) xyShapeRenderer.guideLinePaint) || (this.guideLineStroke == null && xyShapeRenderer.guideLineStroke != null || !Object.instancehelper_equals((object) this.guideLineStroke, (object) xyShapeRenderer.guideLineStroke))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 196, (byte) 108, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYShapeRenderer xyShapeRenderer = (XYShapeRenderer) base.clone();
      if (this.paintScale is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.paintScale;
        xyShapeRenderer.paintScale = (PaintScale) publicCloneable.clone();
      }
      return (object) xyShapeRenderer;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 214, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.guideLinePaint = SerialUtilities.readPaint(obj0);
      this.guideLineStroke = SerialUtilities.readStroke(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 227, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.guideLinePaint, obj0);
      SerialUtilities.writeStroke(this.guideLineStroke, obj0);
    }
  }
}
