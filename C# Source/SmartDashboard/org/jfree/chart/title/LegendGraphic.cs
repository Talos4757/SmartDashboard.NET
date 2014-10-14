// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.LegendGraphic
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.block;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"org.jfree.chart.block.Block", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class LegendGraphic : AbstractBlock, Block, Drawable, PublicCloneable, Cloneable.__Interface
  {
    internal const long serialVersionUID = -1338791523854985009L;
    private bool shapeVisible;
    [NonSerialized]
    private Shape shape;
    private RectangleAnchor shapeLocation;
    private RectangleAnchor shapeAnchor;
    private bool shapeFilled;
    [NonSerialized]
    private Paint fillPaint;
    private GradientPaintTransformer fillPaintTransformer;
    private bool shapeOutlineVisible;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;
    private bool lineVisible;
    [NonSerialized]
    private Shape line;
    [NonSerialized]
    private Stroke lineStroke;
    [NonSerialized]
    private Paint linePaint;

    [LineNumberTable(new byte[] {(byte) 104, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 107, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendGraphic(Shape shape, Paint fillPaint)
    {
      LegendGraphic legendGraphic = this;
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (fillPaint == null)
      {
        string str = "Null 'fillPaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.shapeVisible = true;
        this.shape = shape;
        this.shapeAnchor = RectangleAnchor.__\u003C\u003ECENTER;
        this.shapeLocation = RectangleAnchor.__\u003C\u003ECENTER;
        this.shapeFilled = true;
        this.fillPaint = fillPaint;
        this.fillPaintTransformer = (GradientPaintTransformer) new StandardGradientPaintTransformer();
        this.setPadding(2.0, 2.0, 2.0, 2.0);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendGraphic([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LegendGraphic obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 198, (byte) 102, (byte) 104, (byte) 150, (byte) 104, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(Graphics2D g2)
    {
      Rectangle2D rectangle2D = (Rectangle2D) new Rectangle2D.Double();
      if (this.line != null)
        rectangle2D.setRect(this.line.getBounds2D());
      if (this.shape != null)
        rectangle2D = rectangle2D.createUnion(this.shape.getBounds2D());
      return new Size2D(((RectangularShape) rectangle2D).getWidth(), ((RectangularShape) rectangle2D).getHeight());
    }

    public virtual Shape getLine()
    {
      return this.line;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 216, (byte) 105, (byte) 104, (byte) 105, (byte) 137, (byte) 104, (byte) 141, (byte) 158, (byte) 108, (byte) 108, (byte) 167, (byte) 107, (byte) 173, (byte) 158, (byte) 104, (byte) 103, (byte) 109, (byte) 108, (byte) 142, (byte) 122, (byte) 135, (byte) 104, (byte) 108, (byte) 108, (byte) 201})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      area = this.trimBorder(area);
      area = this.trimPadding(area);
      if (this.lineVisible)
      {
        Point2D point2D = RectangleAnchor.coordinates(area, this.shapeLocation);
        Shape translatedShape = ShapeUtilities.createTranslatedShape(this.getLine(), this.shapeAnchor, point2D.getX(), point2D.getY());
        g2.setPaint(this.linePaint);
        g2.setStroke(this.lineStroke);
        g2.draw(translatedShape);
      }
      if (!this.shapeVisible)
        return;
      Point2D point2D1 = RectangleAnchor.coordinates(area, this.shapeLocation);
      Shape translatedShape1 = ShapeUtilities.createTranslatedShape(this.shape, this.shapeAnchor, point2D1.getX(), point2D1.getY());
      if (this.shapeFilled)
      {
        object obj1 = (object) this.fillPaint;
        if ((Paint) obj1 is GradientPaint)
          obj1 = (object) this.fillPaintTransformer.transform((GradientPaint) this.fillPaint, translatedShape1);
        Graphics2D graphics2D = g2;
        object obj2 = obj1;
        Paint paint1;
        if (obj2 != null)
        {
          Paint paint2 = obj2 as Paint;
          if (paint2 == null)
            throw new IncompatibleClassChangeError();
          paint1 = paint2;
        }
        else
          paint1 = (Paint) null;
        graphics2D.setPaint(paint1);
        g2.fill(translatedShape1);
      }
      if (!this.shapeOutlineVisible)
        return;
      g2.setPaint(this.outlinePaint);
      g2.setStroke(this.outlineStroke);
      g2.draw(translatedShape1);
    }

    public virtual bool isShapeVisible()
    {
      return this.shapeVisible;
    }

    public virtual void setShapeVisible(bool visible)
    {
      this.shapeVisible = visible;
    }

    public virtual Shape getShape()
    {
      return this.shape;
    }

    public virtual void setShape(Shape shape)
    {
      this.shape = shape;
    }

    public virtual bool isShapeFilled()
    {
      return this.shapeFilled;
    }

    public virtual void setShapeFilled(bool filled)
    {
      this.shapeFilled = filled;
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    public virtual void setFillPaint(Paint paint)
    {
      this.fillPaint = paint;
    }

    public virtual GradientPaintTransformer getFillPaintTransformer()
    {
      return this.fillPaintTransformer;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaintTransformer(GradientPaintTransformer transformer)
    {
      if (transformer == null)
      {
        string str = "Null 'transformer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.fillPaintTransformer = transformer;
    }

    public virtual bool isShapeOutlineVisible()
    {
      return this.shapeOutlineVisible;
    }

    public virtual void setShapeOutlineVisible(bool visible)
    {
      this.shapeOutlineVisible = visible;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    public virtual void setOutlinePaint(Paint paint)
    {
      this.outlinePaint = paint;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    public virtual void setOutlineStroke(Stroke stroke)
    {
      this.outlineStroke = stroke;
    }

    public virtual RectangleAnchor getShapeAnchor()
    {
      return this.shapeAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 11, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapeAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.shapeAnchor = anchor;
    }

    public virtual RectangleAnchor getShapeLocation()
    {
      return this.shapeLocation;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 37, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapeLocation(RectangleAnchor location)
    {
      if (location == null)
      {
        string str = "Null 'location' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.shapeLocation = location;
    }

    public virtual bool isLineVisible()
    {
      return this.lineVisible;
    }

    public virtual void setLineVisible(bool visible)
    {
      this.lineVisible = visible;
    }

    public virtual void setLine(Shape line)
    {
      this.line = line;
    }

    public virtual Paint getLinePaint()
    {
      return this.linePaint;
    }

    public virtual void setLinePaint(Paint paint)
    {
      this.linePaint = paint;
    }

    public virtual Stroke getLineStroke()
    {
      return this.lineStroke;
    }

    public virtual void setLineStroke(Stroke stroke)
    {
      this.lineStroke = stroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 142, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 104, (byte) 141, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 242, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint rectangleConstraint = this.toContentConstraint(constraint);
      LengthConstraintType widthConstraintType = rectangleConstraint.getWidthConstraintType();
      LengthConstraintType heightConstraintType = rectangleConstraint.getHeightConstraintType();
      Size2D size2D = (Size2D) null;
      if (widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = this.arrangeNN(g2);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          size2D = new Size2D(rectangleConstraint.getWidth(), rectangleConstraint.getHeight());
      }
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 9, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      this.draw(g2, area);
      return (object) null;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 22, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (!(obj is LegendGraphic))
        return false;
      LegendGraphic legendGraphic = (LegendGraphic) obj;
      if (this.shapeVisible != legendGraphic.shapeVisible || !ShapeUtilities.equal(this.shape, legendGraphic.shape) || (this.shapeFilled != legendGraphic.shapeFilled || !PaintUtilities.equal(this.fillPaint, legendGraphic.fillPaint)) || (!ObjectUtilities.equal((object) this.fillPaintTransformer, (object) legendGraphic.fillPaintTransformer) || this.shapeOutlineVisible != legendGraphic.shapeOutlineVisible || (!PaintUtilities.equal(this.outlinePaint, legendGraphic.outlinePaint) || !ObjectUtilities.equal((object) this.outlineStroke, (object) legendGraphic.outlineStroke))) || (this.shapeAnchor != legendGraphic.shapeAnchor || this.shapeLocation != legendGraphic.shapeLocation || (this.lineVisible != legendGraphic.lineVisible || !ShapeUtilities.equal(this.line, legendGraphic.line)) || (!PaintUtilities.equal(this.linePaint, legendGraphic.linePaint) || !ObjectUtilities.equal((object) this.lineStroke, (object) legendGraphic.lineStroke))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 78, (byte) 102, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * 193 + ObjectUtilities.hashCode((object) this.fillPaint);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 92, (byte) 108, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      LegendGraphic legendGraphic = (LegendGraphic) base.clone();
      legendGraphic.shape = ShapeUtilities.clone(this.shape);
      legendGraphic.line = ShapeUtilities.clone(this.line);
      return (object) legendGraphic;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 106, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.shape, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writeShape(this.line, obj0);
      SerialUtilities.writePaint(this.linePaint, obj0);
      SerialUtilities.writeStroke(this.lineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 126, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.shape = SerialUtilities.readShape(obj0);
      this.fillPaint = SerialUtilities.readPaint(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.line = SerialUtilities.readShape(obj0);
      this.linePaint = SerialUtilities.readPaint(obj0);
      this.lineStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
