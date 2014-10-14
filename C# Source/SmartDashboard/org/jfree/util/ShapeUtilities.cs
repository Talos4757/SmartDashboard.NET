// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ShapeUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.ui;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class ShapeUtilities : Object
  {
    [Modifiers]
    private static float SQRT2 = (float) Math.pow(2.0, 0.5);

    [LineNumberTable((ushort) 397)]
    static ShapeUtilities()
    {
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ShapeUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 99, (byte) 130, (byte) 142, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape rotateShape(Shape @base, double angle, float x, float y)
    {
      if (@base == null)
        return (Shape) null;
      else
        return AffineTransform.getRotateInstance(angle, (double) x, (double) y).createTransformedShape(@base);
    }

    [LineNumberTable(new byte[] {(byte) 83, (byte) 112, (byte) 148, (byte) 112, (byte) 148, (byte) 112, (byte) 148, (byte) 112, (byte) 148, (byte) 112, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Shape s1, Shape s2)
    {
      if (s1 is Line2D && s2 is Line2D)
        return (ShapeUtilities.equal((Line2D) s1, (Line2D) s2) ? 1 : 0) != 0;
      else if (s1 is Ellipse2D && s2 is Ellipse2D)
        return (ShapeUtilities.equal((Ellipse2D) s1, (Ellipse2D) s2) ? 1 : 0) != 0;
      else if (s1 is Arc2D && s2 is Arc2D)
        return (ShapeUtilities.equal((Arc2D) s1, (Arc2D) s2) ? 1 : 0) != 0;
      else if (s1 is Polygon && s2 is Polygon)
        return (ShapeUtilities.equal((Polygon) s1, (Polygon) s2) ? 1 : 0) != 0;
      else if (s1 is GeneralPath && s2 is GeneralPath)
        return (ShapeUtilities.equal((GeneralPath) s1, (GeneralPath) s2) ? 1 : 0) != 0;
      else
        return (ObjectUtilities.equal((object) s1, (object) s2) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Line2D l1, Line2D l2)
    {
      if (l1 == null)
        return l2 == null;
      else
        return l2 != null && l1.getP1().equals((object) l2.getP1()) && l1.getP2().equals((object) l2.getP2());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Ellipse2D e1, Ellipse2D e2)
    {
      if (e1 == null)
        return e2 == null;
      else
        return e2 != null && ((RectangularShape) e1).getFrame().equals((object) ((RectangularShape) e2).getFrame());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Arc2D a1, Arc2D a2)
    {
      if (a1 == null)
        return a2 == null;
      else
        return a2 != null && ((RectangularShape) a1).getFrame().equals((object) ((RectangularShape) a2).getFrame()) && (a1.getAngleStart() == a2.getAngleStart() && a1.getAngleExtent() == a2.getAngleExtent()) && a1.getArcType() == a2.getArcType();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 128, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(Polygon p1, Polygon p2)
    {
      if (p1 == null)
        return p2 == null;
      else
        return p2 != null && p1.npoints == p2.npoints && (Arrays.equals((int[]) p1.xpoints, (int[]) p2.xpoints) && Arrays.equals((int[]) p1.ypoints, (int[]) p2.ypoints));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 110, (byte) 130, (byte) 104, (byte) 104, (byte) 103, (byte) 103, (byte) 118, (byte) 103, (byte) 110, (byte) 130, (byte) 105, (byte) 105, (byte) 102, (byte) 130, (byte) 105, (byte) 130, (byte) 102, (byte) 102, (byte) 118, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(GeneralPath p1, GeneralPath p2)
    {
      if (p1 == null)
      {
        return p2 == null;
      }
      else
      {
        if (p2 == null || ((Path2D) p1).getWindingRule() != ((Path2D) p2).getWindingRule())
          return false;
        PathIterator pathIterator1 = ((Path2D.Float) p1).getPathIterator((AffineTransform) null);
        PathIterator pathIterator2 = ((Path2D.Float) p2).getPathIterator((AffineTransform) null);
        double[] numArray1 = new double[6];
        double[] numArray2 = new double[6];
        for (int index = !pathIterator1.isDone() || !pathIterator2.isDone() ? 0 : 1; index == 0; index = !pathIterator1.isDone() || !pathIterator2.isDone() ? 0 : 1)
        {
          if (pathIterator1.isDone() != pathIterator2.isDone() || pathIterator1.currentSegment(numArray1) != pathIterator2.currentSegment(numArray2) || !Arrays.equals(numArray1, numArray2))
            return false;
          pathIterator1.next();
          pathIterator2.next();
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 136, (byte) 154, (byte) 161, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape clone(Shape shape)
    {
      if (Cloneable.IsInstance((object) shape))
      {
        Shape shape1;
        try
        {
          shape1 = (Shape) ObjectUtilities.clone((object) shape);
        }
        catch (CloneNotSupportedException ex)
        {
          goto label_4;
        }
        return shape1;
label_4:;
      }
      return (Shape) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 99, (byte) 144, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createTranslatedShape(Shape shape, double transX, double transY)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return AffineTransform.getTranslateInstance(transX, transY).createTransformedShape(shape);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 141, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createTranslatedShape(Shape shape, RectangleAnchor anchor, double locationX, double locationY)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Point2D point2D = RectangleAnchor.coordinates(shape.getBounds2D(), anchor);
        return AffineTransform.getTranslateInstance(locationX - point2D.getX(), locationY - point2D.getY()).createTransformedShape(shape);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 17, (byte) 103, (byte) 143, (byte) 103, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void drawRotatedShape(Graphics2D g2, Shape shape, double angle, float x, float y)
    {
      AffineTransform transform = g2.getTransform();
      AffineTransform rotateInstance = AffineTransform.getRotateInstance(angle, (double) x, (double) y);
      g2.transform(rotateInstance);
      g2.draw(shape);
      g2.setTransform(transform);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 102, (byte) 116, (byte) 116, (byte) 117, (byte) 115, (byte) 115, (byte) 116, (byte) 114, (byte) 114, (byte) 116, (byte) 115, (byte) 115, (byte) 117, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createDiagonalCross(float l, float t)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(-l - t, -l + t);
      ((Path2D.Float) generalPath).lineTo(-l + t, -l - t);
      ((Path2D.Float) generalPath).lineTo(0.0f, -t * ShapeUtilities.SQRT2);
      ((Path2D.Float) generalPath).lineTo(l - t, -l - t);
      ((Path2D.Float) generalPath).lineTo(l + t, -l + t);
      ((Path2D.Float) generalPath).lineTo(t * ShapeUtilities.SQRT2, 0.0f);
      ((Path2D.Float) generalPath).lineTo(l + t, l - t);
      ((Path2D.Float) generalPath).lineTo(l - t, l + t);
      ((Path2D.Float) generalPath).lineTo(0.0f, t * ShapeUtilities.SQRT2);
      ((Path2D.Float) generalPath).lineTo(-l + t, l + t);
      ((Path2D.Float) generalPath).lineTo(-l - t, l - t);
      ((Path2D.Float) generalPath).lineTo(-t * ShapeUtilities.SQRT2, 0.0f);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 102, (byte) 107, (byte) 107, (byte) 107, (byte) 106, (byte) 106, (byte) 106, (byte) 107, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createRegularCross(float l, float t)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(-l, t);
      ((Path2D.Float) generalPath).lineTo(-t, t);
      ((Path2D.Float) generalPath).lineTo(-t, l);
      ((Path2D.Float) generalPath).lineTo(t, l);
      ((Path2D.Float) generalPath).lineTo(t, t);
      ((Path2D.Float) generalPath).lineTo(l, t);
      ((Path2D.Float) generalPath).lineTo(l, -t);
      ((Path2D.Float) generalPath).lineTo(t, -t);
      ((Path2D.Float) generalPath).lineTo(t, -l);
      ((Path2D.Float) generalPath).lineTo(-t, -l);
      ((Path2D.Float) generalPath).lineTo(-t, -t);
      ((Path2D.Float) generalPath).lineTo(-l, -t);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 89, (byte) 102, (byte) 110, (byte) 109, (byte) 109, (byte) 110, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createDiamond(float s)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(0.0f, -s);
      ((Path2D.Float) generalPath).lineTo(s, 0.0f);
      ((Path2D.Float) generalPath).lineTo(0.0f, s);
      ((Path2D.Float) generalPath).lineTo(-s, 0.0f);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 106, (byte) 102, (byte) 110, (byte) 106, (byte) 107, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createUpTriangle(float s)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(0.0f, -s);
      ((Path2D.Float) generalPath).lineTo(s, s);
      ((Path2D.Float) generalPath).lineTo(-s, s);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 122, (byte) 102, (byte) 109, (byte) 107, (byte) 108, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createDownTriangle(float s)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(0.0f, s);
      ((Path2D.Float) generalPath).lineTo(s, -s);
      ((Path2D.Float) generalPath).lineTo(-s, -s);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 141, (byte) 102, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 111, (byte) 116, (byte) 110, (byte) 110, (byte) 112, (byte) 112, (byte) 113, (byte) 113, (byte) 102, (byte) 162, (byte) 115, (byte) 115, (byte) 116, (byte) 116, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape createLineRegion(Line2D line, float width)
    {
      GeneralPath generalPath = new GeneralPath();
      float num1 = (float) line.getX1();
      float num2 = (float) line.getX2();
      float num3 = (float) line.getY1();
      float num4 = (float) line.getY2();
      if ((double) (num2 - num1) != 0.0)
      {
        double num5 = Math.atan((double) ((num4 - num3) / (num2 - num1)));
        float num6 = (float) Math.sin(num5) * width;
        float num7 = (float) Math.cos(num5) * width;
        ((Path2D.Float) generalPath).moveTo(num1 - num6, num3 + num7);
        ((Path2D.Float) generalPath).lineTo(num1 + num6, num3 - num7);
        ((Path2D.Float) generalPath).lineTo(num2 + num6, num4 - num7);
        ((Path2D.Float) generalPath).lineTo(num2 - num6, num4 + num7);
        ((Path2D) generalPath).closePath();
      }
      else
      {
        ((Path2D.Float) generalPath).moveTo(num1 - width / 2f, num3);
        ((Path2D.Float) generalPath).lineTo(num1 + width / 2f, num3);
        ((Path2D.Float) generalPath).lineTo(num2 + width / 2f, num4);
        ((Path2D.Float) generalPath).lineTo(num2 - width / 2f, num4);
        ((Path2D) generalPath).closePath();
      }
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 183, (byte) 123, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Point2D getPointInRectangle(double x, double y, Rectangle2D area)
    {
      x = Math.max(((RectangularShape) area).getMinX(), Math.min(x, ((RectangularShape) area).getMaxX()));
      y = Math.max(((RectangularShape) area).getMinY(), Math.min(y, ((RectangularShape) area).getMaxY()));
      return (Point2D) new Point2D.Double(x, y);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 201, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool contains(Rectangle2D rect1, Rectangle2D rect2)
    {
      double x1 = ((RectangularShape) rect1).getX();
      double y1 = ((RectangularShape) rect1).getY();
      double x2 = ((RectangularShape) rect2).getX();
      double y2 = ((RectangularShape) rect2).getY();
      double width = ((RectangularShape) rect2).getWidth();
      double height = ((RectangularShape) rect2).getHeight();
      return x2 >= x1 && y2 >= y1 && (x2 + width <= x1 + ((RectangularShape) rect1).getWidth() && y2 + height <= y1 + ((RectangularShape) rect1).getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 227, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool intersects(Rectangle2D rect1, Rectangle2D rect2)
    {
      double x1 = ((RectangularShape) rect1).getX();
      double y1 = ((RectangularShape) rect1).getY();
      double x2 = ((RectangularShape) rect2).getX();
      double width = ((RectangularShape) rect2).getWidth();
      double y2 = ((RectangularShape) rect2).getY();
      double height = ((RectangularShape) rect2).getHeight();
      return x2 + width >= x1 && y2 + height >= y1 && (x2 <= x1 + ((RectangularShape) rect1).getWidth() && y2 <= y1 + ((RectangularShape) rect1).getHeight());
    }
  }
}
