// Decompiled with JetBrains decompiler
// Type: org.jfree.io.SerialUtilities
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
using java.text;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.io
{
  public class SerialUtilities : Object
  {
    internal static Class class\u0024java\u0024io\u0024Serializable;
    internal static Class class\u0024java\u0024awt\u0024GradientPaint;
    internal static Class class\u0024java\u0024awt\u0024BasicStroke;
    internal static Class class\u0024java\u0024awt\u0024geom\u0024Line2D;
    internal static Class class\u0024java\u0024awt\u0024geom\u0024Rectangle2D;
    internal static Class class\u0024java\u0024awt\u0024geom\u0024Ellipse2D;
    internal static Class class\u0024java\u0024awt\u0024geom\u0024Arc2D;
    internal static Class class\u0024java\u0024awt\u0024geom\u0024GeneralPath;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerialUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 106)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, SerialUtilities.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable((ushort) 106)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isSerializable(Class c)
    {
      return ((SerialUtilities.class\u0024java\u0024io\u0024Serializable != null ? SerialUtilities.class\u0024java\u0024io\u0024Serializable : (SerialUtilities.class\u0024java\u0024io\u0024Serializable = SerialUtilities.class\u0024("java.io.Serializable"))).isAssignableFrom(c) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 73, (byte) 99, (byte) 144, (byte) 98, (byte) 103, (byte) 102, (byte) 108, (byte) 104, (byte) 145, (byte) 127, (byte) 7, (byte) 103, (byte) 104, (byte) 109, (byte) 104, (byte) 104, (byte) 109, (byte) 104, (byte) 179})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Paint readPaint(ObjectInputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        object obj1 = (object) null;
        if (!stream.readBoolean())
        {
          Class c = (Class) stream.readObject();
          if (SerialUtilities.isSerializable(c))
            obj1 = (object) (Paint) stream.readObject();
          else if (Object.instancehelper_equals((object) c, SerialUtilities.class\u0024java\u0024awt\u0024GradientPaint != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024GradientPaint : (object) (SerialUtilities.class\u0024java\u0024awt\u0024GradientPaint = SerialUtilities.class\u0024("java.awt.GradientPaint"))))
            obj1 = (object) new GradientPaint(stream.readFloat(), stream.readFloat(), (Color) stream.readObject(), stream.readFloat(), stream.readFloat(), (Color) stream.readObject(), stream.readBoolean());
        }
        object obj2 = obj1;
        if (obj2 == null)
          return (Paint) null;
        Paint paint = obj2 as Paint;
        if (paint != null)
          return paint;
        else
          throw new IncompatibleClassChangeError();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 110, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 108, (byte) 104, (byte) 140, (byte) 107, (byte) 103, (byte) 114, (byte) 114, (byte) 108, (byte) 114, (byte) 114, (byte) 108, (byte) 108, (byte) 162, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writePaint(Paint paint, ObjectOutputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (paint != null)
      {
        stream.writeBoolean(false);
        stream.writeObject((object) Object.instancehelper_getClass((object) paint));
        if (Serializable.IsInstance((object) paint))
        {
          stream.writeObject((object) paint);
        }
        else
        {
          if (!(paint is GradientPaint))
            return;
          GradientPaint gradientPaint = (GradientPaint) paint;
          stream.writeFloat((float) gradientPaint.getPoint1().getX());
          stream.writeFloat((float) gradientPaint.getPoint1().getY());
          stream.writeObject((object) gradientPaint.getColor1());
          stream.writeFloat((float) gradientPaint.getPoint2().getX());
          stream.writeFloat((float) gradientPaint.getPoint2().getY());
          stream.writeObject((object) gradientPaint.getColor2());
          stream.writeBoolean(gradientPaint.isCyclic());
        }
      }
      else
        stream.writeBoolean(true);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 99, (byte) 144, (byte) 98, (byte) 103, (byte) 102, (byte) 108, (byte) 127, (byte) 7, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 114, (byte) 104, (byte) 177, (byte) 130, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Stroke readStroke(ObjectInputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        object obj1 = (object) null;
        if (!stream.readBoolean())
          obj1 = !Object.instancehelper_equals((object) (Class) stream.readObject(), SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke : (object) (SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke = SerialUtilities.class\u0024("java.awt.BasicStroke"))) ? (object) (Stroke) stream.readObject() : (object) new BasicStroke(stream.readFloat(), stream.readInt(), stream.readInt(), stream.readFloat(), (float[]) stream.readObject(), stream.readFloat());
        object obj2 = obj1;
        if (obj2 == null)
          return (Stroke) null;
        Stroke stroke = obj2 as Stroke;
        if (stroke != null)
          return stroke;
        else
          throw new IncompatibleClassChangeError();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 107, (byte) 103, (byte) 127, (byte) 5, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 130, (byte) 108, (byte) 201, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeStroke(Stroke stroke, ObjectOutputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (stroke != null)
      {
        stream.writeBoolean(false);
        if (stroke is BasicStroke)
        {
          BasicStroke basicStroke = (BasicStroke) stroke;
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke : (object) (SerialUtilities.class\u0024java\u0024awt\u0024BasicStroke = SerialUtilities.class\u0024("java.awt.BasicStroke")));
          stream.writeFloat(basicStroke.getLineWidth());
          stream.writeInt(basicStroke.getEndCap());
          stream.writeInt(basicStroke.getLineJoin());
          stream.writeFloat(basicStroke.getMiterLimit());
          stream.writeObject((object) basicStroke.getDashArray());
          stream.writeFloat(basicStroke.getDashPhase());
        }
        else
        {
          stream.writeObject((object) Object.instancehelper_getClass((object) stroke));
          stream.writeObject((object) stroke);
        }
      }
      else
        stream.writeBoolean(true);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 99, (byte) 144, (byte) 98, (byte) 103, (byte) 102, (byte) 108, (byte) 127, (byte) 7, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 109, (byte) 101, (byte) 127, (byte) 7, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 109, (byte) 101, (byte) 127, (byte) 7, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 109, (byte) 101, (byte) 127, (byte) 7, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 104, (byte) 115, (byte) 101, (byte) 127, (byte) 10, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 104, (byte) 104, (byte) 43, (byte) 168, (byte) 159, (byte) 1, (byte) 111, (byte) 133, (byte) 111, (byte) 130, (byte) 159, (byte) 0, (byte) 130, (byte) 119, (byte) 130, (byte) 103, (byte) 130, (byte) 176, (byte) 109, (byte) 104, (byte) 101, (byte) 99, (byte) 130, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape readShape(ObjectInputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        object obj1 = (object) null;
        if (!stream.readBoolean())
        {
          Class @class = (Class) stream.readObject();
          if (Object.instancehelper_equals((object) @class, SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D = SerialUtilities.class\u0024("java.awt.geom.Line2D"))))
            obj1 = (object) new Line2D.Double(stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble());
          else if (Object.instancehelper_equals((object) @class, SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D = SerialUtilities.class\u0024("java.awt.geom.Rectangle2D"))))
            obj1 = (object) new Rectangle2D.Double(stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble());
          else if (Object.instancehelper_equals((object) @class, SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D = SerialUtilities.class\u0024("java.awt.geom.Ellipse2D"))))
            obj1 = (object) new Ellipse2D.Double(stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble());
          else if (Object.instancehelper_equals((object) @class, SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D = SerialUtilities.class\u0024("java.awt.geom.Arc2D"))))
            obj1 = (object) new Arc2D.Double(stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readDouble(), stream.readInt());
          else if (Object.instancehelper_equals((object) @class, SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath = SerialUtilities.class\u0024("java.awt.geom.GeneralPath"))))
          {
            GeneralPath generalPath = new GeneralPath();
            float[] numArray = new float[6];
            for (int index1 = stream.readBoolean() ? 1 : 0; index1 == 0; index1 = stream.readBoolean() ? 1 : 0)
            {
              int num = stream.readInt();
              for (int index2 = 0; index2 < 6; ++index2)
                numArray[index2] = stream.readFloat();
              switch (num)
              {
                case 0:
                  ((Path2D.Float) generalPath).moveTo(numArray[0], numArray[1]);
                  break;
                case 1:
                  ((Path2D.Float) generalPath).lineTo(numArray[0], numArray[1]);
                  break;
                case 2:
                  ((Path2D.Float) generalPath).quadTo(numArray[0], numArray[1], numArray[2], numArray[3]);
                  break;
                case 3:
                  ((Path2D.Float) generalPath).curveTo(numArray[0], numArray[1], numArray[2], numArray[3], numArray[4], numArray[5]);
                  break;
                case 4:
                  ((Path2D) generalPath).closePath();
                  break;
                default:
                  string str = "JFreeChart - No path exists";
                  Throwable.__\u003CsuppressFillInStackTrace\u003E();
                  throw new RuntimeException(str);
              }
              ((Path2D) generalPath).setWindingRule(stream.readInt());
            }
            obj1 = (object) generalPath;
          }
          else
            obj1 = (object) (Shape) stream.readObject();
        }
        object obj2 = obj1;
        if (obj2 == null)
          return (Shape) null;
        Shape shape = obj2 as Shape;
        if (shape != null)
          return shape;
        else
          throw new IncompatibleClassChangeError();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 104, (byte) 103, (byte) 127, (byte) 5, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 101, (byte) 104, (byte) 103, (byte) 127, (byte) 5, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 101, (byte) 104, (byte) 103, (byte) 127, (byte) 5, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 101, (byte) 107, (byte) 103, (byte) 127, (byte) 5, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 101, (byte) 107, (byte) 127, (byte) 5, (byte) 105, (byte) 104, (byte) 109, (byte) 105, (byte) 107, (byte) 168, (byte) 104, (byte) 43, (byte) 168, (byte) 109, (byte) 103, (byte) 109, (byte) 98, (byte) 130, (byte) 108, (byte) 201, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeShape(Shape shape, ObjectOutputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (shape != null)
      {
        stream.writeBoolean(false);
        if (shape is Line2D)
        {
          Line2D line2D = (Line2D) shape;
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Line2D = SerialUtilities.class\u0024("java.awt.geom.Line2D")));
          stream.writeDouble(line2D.getX1());
          stream.writeDouble(line2D.getY1());
          stream.writeDouble(line2D.getX2());
          stream.writeDouble(line2D.getY2());
        }
        else if (shape is Rectangle2D)
        {
          Rectangle2D rectangle2D = (Rectangle2D) shape;
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Rectangle2D = SerialUtilities.class\u0024("java.awt.geom.Rectangle2D")));
          stream.writeDouble(((RectangularShape) rectangle2D).getX());
          stream.writeDouble(((RectangularShape) rectangle2D).getY());
          stream.writeDouble(((RectangularShape) rectangle2D).getWidth());
          stream.writeDouble(((RectangularShape) rectangle2D).getHeight());
        }
        else if (shape is Ellipse2D)
        {
          Ellipse2D ellipse2D = (Ellipse2D) shape;
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Ellipse2D = SerialUtilities.class\u0024("java.awt.geom.Ellipse2D")));
          stream.writeDouble(((RectangularShape) ellipse2D).getX());
          stream.writeDouble(((RectangularShape) ellipse2D).getY());
          stream.writeDouble(((RectangularShape) ellipse2D).getWidth());
          stream.writeDouble(((RectangularShape) ellipse2D).getHeight());
        }
        else if (shape is Arc2D)
        {
          Arc2D arc2D = (Arc2D) shape;
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024Arc2D = SerialUtilities.class\u0024("java.awt.geom.Arc2D")));
          stream.writeDouble(((RectangularShape) arc2D).getX());
          stream.writeDouble(((RectangularShape) arc2D).getY());
          stream.writeDouble(((RectangularShape) arc2D).getWidth());
          stream.writeDouble(((RectangularShape) arc2D).getHeight());
          stream.writeDouble(arc2D.getAngleStart());
          stream.writeDouble(arc2D.getAngleExtent());
          stream.writeInt(arc2D.getArcType());
        }
        else if (shape is GeneralPath)
        {
          stream.writeObject(SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath != null ? (object) SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath : (object) (SerialUtilities.class\u0024java\u0024awt\u0024geom\u0024GeneralPath = SerialUtilities.class\u0024("java.awt.geom.GeneralPath")));
          PathIterator pathIterator = shape.getPathIterator((AffineTransform) null);
          float[] numArray = new float[6];
          stream.writeBoolean(pathIterator.isDone());
          while (!pathIterator.isDone())
          {
            int num = pathIterator.currentSegment(numArray);
            stream.writeInt(num);
            for (int index = 0; index < 6; ++index)
              stream.writeFloat(numArray[index]);
            stream.writeInt(pathIterator.getWindingRule());
            pathIterator.next();
            stream.writeBoolean(pathIterator.isDone());
          }
        }
        else
        {
          stream.writeObject((object) Object.instancehelper_getClass((object) shape));
          stream.writeObject((object) shape);
        }
      }
      else
        stream.writeBoolean(true);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 99, (byte) 144, (byte) 98, (byte) 103, (byte) 99, (byte) 104, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Point2D readPoint2D(ObjectInputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Point2D.Double @double = (Point2D.Double) null;
        if (!stream.readBoolean())
          @double = new Point2D.Double(stream.readDouble(), stream.readDouble());
        return (Point2D) @double;
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 110, (byte) 99, (byte) 144, (byte) 99, (byte) 103, (byte) 108, (byte) 174, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writePoint2D(Point2D p, ObjectOutputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (p != null)
      {
        stream.writeBoolean(false);
        stream.writeDouble(p.getX());
        stream.writeDouble(p.getY());
      }
      else
        stream.writeBoolean(true);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 139, (byte) 99, (byte) 144, (byte) 98, (byte) 103, (byte) 134, (byte) 108, (byte) 103, (byte) 103, (byte) 99, (byte) 104, (byte) 104, (byte) 109, (byte) 108, (byte) 100, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AttributedString readAttributedString(ObjectInputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        AttributedString attributedString = (AttributedString) null;
        if (!stream.readBoolean())
        {
          attributedString = new AttributedString((string) stream.readObject());
          int num1 = (int) stream.readChar();
          int num2 = 0;
          for (; num1 != (int) ushort.MaxValue; num1 = (int) stream.readChar())
          {
            int num3 = stream.readInt();
            Map map = (Map) stream.readObject();
            attributedString.addAttributes(map, num2, num3);
            num2 = num3;
          }
        }
        return attributedString;
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 172, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 167, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 137, (byte) 172, (byte) 103, (byte) 103, (byte) 200, (byte) 167, (byte) 104, (byte) 170, (byte) 109, (byte) 104, (byte) 105, (byte) 162, (byte) 107, (byte) 162, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeAttributedString(AttributedString @as, ObjectOutputStream stream)
    {
      if (stream == null)
      {
        string str = "Null 'stream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (@as != null)
      {
        stream.writeBoolean(false);
        AttributedCharacterIterator iterator = @as.getIterator();
        StringBuffer stringBuffer = new StringBuffer();
        for (int index = (int) ((CharacterIterator) iterator).first(); index != (int) ushort.MaxValue; index = (int) ((CharacterIterator) iterator).next())
          stringBuffer = stringBuffer.append((char) index);
        stream.writeObject((object) stringBuffer.toString());
        int num = (int) ((CharacterIterator) iterator).first();
        int beginIndex = ((CharacterIterator) iterator).getBeginIndex();
        for (; num != (int) ushort.MaxValue; {
          int runLimit;
          num = (int) ((CharacterIterator) iterator).setIndex(runLimit);
        }
        )
        {
          stream.writeChar(num);
          runLimit = iterator.getRunLimit();
          stream.writeInt(runLimit - beginIndex);
          HashMap hashMap = new HashMap(iterator.getAttributes());
          stream.writeObject((object) hashMap);
        }
        stream.writeChar((int) ushort.MaxValue);
      }
      else
        stream.writeBoolean(true);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (SerialUtilities.__\u003CcallerID\u003E == null)
        SerialUtilities.__\u003CcallerID\u003E = (CallerID) new SerialUtilities.__\u003CCallerID\u003E();
      return SerialUtilities.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
