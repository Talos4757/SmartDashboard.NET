// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PiePlot3D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class PiePlot3D : PiePlot, Serializable.__Interface
  {
    private const long serialVersionUID = 3408984188945161432L;
    private double depthFactor;
    private bool darkerSides;

    [HideFromJava]
    static PiePlot3D()
    {
      PiePlot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 233, (byte) 39, (byte) 240, (byte) 72, (byte) 231, (byte) 82, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PiePlot3D(PieDataset dataset)
      : base(dataset)
    {
      PiePlot3D piePlot3D = this;
      this.depthFactor = 0.12;
      this.darkerSides = false;
      this.setCircular(false, false);
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PiePlot3D()
      : this((PieDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PiePlot3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PiePlot3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 243, (byte) 73, (byte) 104, (byte) 109, (byte) 108, (byte) 103, (byte) 194, (byte) 105, (byte) 105, (byte) 136, (byte) 168, (byte) 140, (byte) 141, (byte) 141, (byte) 144, (byte) 102, (byte) 255, (byte) 32, (byte) 69, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 229, (byte) 69, (byte) 223, (byte) 22, (byte) 137, (byte) 255, (byte) 27, (byte) 69, (byte) 105, (byte) 122, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 104, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 229, (byte) 69, (byte) 102, (byte) 223, (byte) 22, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 168, (byte) 102, (byte) 223, (byte) 22, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 229, (byte) 70, (byte) 109, (byte) 112, (byte) 102, (byte) 255, (byte) 32, (byte) 69, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 197, (byte) 223, (byte) 27, (byte) 137, (byte) 255, (byte) 22, (byte) 69, (byte) 137, (byte) 122, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 104, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 197, (byte) 102, (byte) 223, (byte) 27, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 168, (byte) 102, (byte) 223, (byte) 27, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 229, (byte) 69, (byte) 140, (byte) 141, (byte) 141, (byte) 112, (byte) 102, (byte) 255, (byte) 32, (byte) 69, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 165, (byte) 223, (byte) 27, (byte) 137, (byte) 223, (byte) 22, (byte) 137, (byte) 122, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 104, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 165, (byte) 102, (byte) 223, (byte) 27, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 168, (byte) 102, (byte) 223, (byte) 27, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 229, (byte) 69, (byte) 109, (byte) 112, (byte) 102, (byte) 255, (byte) 32, (byte) 69, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 104, (byte) 197, (byte) 223, (byte) 27, (byte) 137, (byte) 223, (byte) 27, (byte) 137, (byte) 122, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 104, (byte) 99, (byte) 104, (byte) 168, (byte) 99, (byte) 168, (byte) 197, (byte) 102, (byte) 223, (byte) 22, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 168, (byte) 102, (byte) 223, (byte) 22, (byte) 105, (byte) 122, (byte) 104, (byte) 104, (byte) 234, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawSide(Graphics2D g2, Rectangle2D plotArea, Arc2D arc, Area front, Area back, Paint paint, Paint outlinePaint, Stroke outlineStroke, bool drawFront, bool drawBack)
    {
      object obj1 = (object) paint;
      int num1 = drawFront ? 1 : 0;
      int num2 = drawBack ? 1 : 0;
      if (this.getDarkerSides() && (Paint) obj1 is Color)
        obj1 = (object) ((Color) obj1).darker();
      double angleStart = arc.getAngleStart();
      double angleExtent = arc.getAngleExtent();
      double num3 = angleStart + angleExtent;
      g2.setStroke(outlineStroke);
      if (angleExtent < 0.0)
      {
        if (this.isAngleAtFront(angleStart))
        {
          if (!this.isAngleAtBack(num3))
          {
            if (angleExtent > -180.0)
            {
              if (num1 == 0)
                return;
              Area.__\u003Cclinit\u003E();
              Area area = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), arc.getStartPoint().getX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
              area.intersect(front);
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
              g2.fill((Shape) area);
              g2.setPaint(outlinePaint);
              g2.draw((Shape) area);
            }
            else
            {
              Area.__\u003Cclinit\u003E();
              Area area1 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getStartPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
              area1.intersect(front);
              Area.__\u003Cclinit\u003E();
              Area area2 = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
              area2.intersect(front);
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
              if (num1 != 0)
              {
                g2.fill((Shape) area1);
                g2.fill((Shape) area2);
              }
              if (num2 != 0)
                g2.fill((Shape) back);
              g2.setPaint(outlinePaint);
              if (num1 != 0)
              {
                g2.draw((Shape) area1);
                g2.draw((Shape) area2);
              }
              if (num2 == 0)
                return;
              g2.draw((Shape) back);
            }
          }
          else
          {
            if (num2 != 0)
            {
              Area.__\u003Cclinit\u003E();
              Area area = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
              area.intersect(back);
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
              g2.fill((Shape) area);
              g2.setPaint(outlinePaint);
              g2.draw((Shape) area);
            }
            if (num1 == 0)
              return;
            Area.__\u003Cclinit\u003E();
            Area area1 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getStartPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
            area1.intersect(front);
            Graphics2D graphics2D1 = g2;
            object obj3 = obj1;
            Paint paint3;
            if (obj3 != null)
            {
              Paint paint1 = obj3 as Paint;
              if (paint1 == null)
                throw new IncompatibleClassChangeError();
              paint3 = paint1;
            }
            else
              paint3 = (Paint) null;
            graphics2D1.setPaint(paint3);
            g2.fill((Shape) area1);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area1);
          }
        }
        else if (!this.isAngleAtFront(num3))
        {
          if (angleExtent > -180.0)
          {
            if (num2 == 0)
              return;
            Area.__\u003Cclinit\u003E();
            Area area = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area.intersect(back);
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
            g2.fill((Shape) area);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area);
          }
          else
          {
            Area.__\u003Cclinit\u003E();
            Area area1 = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area1.intersect(back);
            Area.__\u003Cclinit\u003E();
            Area area2 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
            area2.intersect(back);
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
            if (num2 != 0)
            {
              g2.fill((Shape) area1);
              g2.fill((Shape) area2);
            }
            if (num1 != 0)
              g2.fill((Shape) front);
            g2.setPaint(outlinePaint);
            if (num2 != 0)
            {
              g2.draw((Shape) area1);
              g2.draw((Shape) area2);
            }
            if (num1 == 0)
              return;
            g2.draw((Shape) front);
          }
        }
        else
        {
          if (num2 != 0)
          {
            Area.__\u003Cclinit\u003E();
            Area area = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area.intersect(back);
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
            g2.fill((Shape) area);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area);
          }
          if (num1 == 0)
            return;
          Area.__\u003Cclinit\u003E();
          Area area1 = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
          area1.intersect(front);
          Graphics2D graphics2D1 = g2;
          object obj3 = obj1;
          Paint paint3;
          if (obj3 != null)
          {
            Paint paint1 = obj3 as Paint;
            if (paint1 == null)
              throw new IncompatibleClassChangeError();
            paint3 = paint1;
          }
          else
            paint3 = (Paint) null;
          graphics2D1.setPaint(paint3);
          g2.fill((Shape) area1);
          g2.setPaint(outlinePaint);
          g2.draw((Shape) area1);
        }
      }
      else
      {
        if (angleExtent <= 0.0)
          return;
        if (this.isAngleAtFront(angleStart))
        {
          if (!this.isAngleAtBack(num3))
          {
            if (angleExtent < 180.0)
            {
              if (num1 == 0)
                return;
              Area.__\u003Cclinit\u003E();
              Area area = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
              area.intersect(front);
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
              g2.fill((Shape) area);
              g2.setPaint(outlinePaint);
              g2.draw((Shape) area);
            }
            else
            {
              Area.__\u003Cclinit\u003E();
              Area area1 = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
              area1.intersect(front);
              Area.__\u003Cclinit\u003E();
              Area area2 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
              area2.intersect(front);
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
              if (num1 != 0)
              {
                g2.fill((Shape) area1);
                g2.fill((Shape) area2);
              }
              if (num2 != 0)
                g2.fill((Shape) back);
              g2.setPaint(outlinePaint);
              if (num1 != 0)
              {
                g2.draw((Shape) area1);
                g2.draw((Shape) area2);
              }
              if (num2 == 0)
                return;
              g2.draw((Shape) back);
            }
          }
          else
          {
            if (num2 != 0)
            {
              Area.__\u003Cclinit\u003E();
              Area area = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
              area.intersect(back);
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
              g2.fill((Shape) area);
              g2.setPaint(outlinePaint);
              g2.draw((Shape) area);
            }
            if (num1 == 0)
              return;
            Area.__\u003Cclinit\u003E();
            Area area1 = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area1.intersect(front);
            Graphics2D graphics2D1 = g2;
            object obj3 = obj1;
            Paint paint3;
            if (obj3 != null)
            {
              Paint paint1 = obj3 as Paint;
              if (paint1 == null)
                throw new IncompatibleClassChangeError();
              paint3 = paint1;
            }
            else
              paint3 = (Paint) null;
            graphics2D1.setPaint(paint3);
            g2.fill((Shape) area1);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area1);
          }
        }
        else if (!this.isAngleAtFront(num3))
        {
          if (angleExtent < 180.0)
          {
            if (num2 == 0)
              return;
            Area.__\u003Cclinit\u003E();
            Area area = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), arc.getStartPoint().getX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area.intersect(back);
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
            g2.fill((Shape) area);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area);
          }
          else
          {
            Area.__\u003Cclinit\u003E();
            Area area1 = new Area((Shape) new Rectangle2D.Double(arc.getStartPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getX() - arc.getStartPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area1.intersect(back);
            Area.__\u003Cclinit\u003E();
            Area area2 = new Area((Shape) new Rectangle2D.Double(arc.getEndPoint().getX(), ((RectangularShape) plotArea).getY(), ((RectangularShape) plotArea).getMaxX() - arc.getEndPoint().getX(), ((RectangularShape) plotArea).getHeight()));
            area2.intersect(back);
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
            if (num2 != 0)
            {
              g2.fill((Shape) area1);
              g2.fill((Shape) area2);
            }
            if (num1 != 0)
              g2.fill((Shape) front);
            g2.setPaint(outlinePaint);
            if (num2 != 0)
            {
              g2.draw((Shape) area1);
              g2.draw((Shape) area2);
            }
            if (num1 == 0)
              return;
            g2.draw((Shape) front);
          }
        }
        else
        {
          if (num2 != 0)
          {
            Area.__\u003Cclinit\u003E();
            Area area = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getStartPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
            area.intersect(back);
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
            g2.fill((Shape) area);
            g2.setPaint(outlinePaint);
            g2.draw((Shape) area);
          }
          if (num1 == 0)
            return;
          Area.__\u003Cclinit\u003E();
          Area area1 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getY(), arc.getEndPoint().getX() - ((RectangularShape) plotArea).getX(), ((RectangularShape) plotArea).getHeight()));
          area1.intersect(front);
          Graphics2D graphics2D1 = g2;
          object obj3 = obj1;
          Paint paint3;
          if (obj3 != null)
          {
            Paint paint1 = obj3 as Paint;
            if (paint1 == null)
              throw new IncompatibleClassChangeError();
            paint3 = paint1;
          }
          else
            paint3 = (Paint) null;
          graphics2D1.setPaint(paint3);
          g2.fill((Shape) area1);
          g2.setPaint(outlinePaint);
          g2.draw((Shape) area1);
        }
      }
    }

    public virtual bool getDarkerSides()
    {
      return this.darkerSides;
    }

    [LineNumberTable((ushort) 990)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isAngleAtFront([In] double obj0)
    {
      return Math.sin(Math.toRadians(obj0)) < 0.0;
    }

    [LineNumberTable((ushort) 1003)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isAngleAtBack([In] double obj0)
    {
      return Math.sin(Math.toRadians(obj0)) > 0.0;
    }

    public virtual double getDepthFactor()
    {
      return this.depthFactor;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDepthFactor(double factor)
    {
      this.depthFactor = factor;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 90, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDarkerSides(bool darker)
    {
      this.darkerSides = darker;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 103, (byte) 135, (byte) 108, (byte) 100, (byte) 104, (byte) 168, (byte) 136, (byte) 103, (byte) 167, (byte) 104, (byte) 103, (byte) 104, (byte) 144, (byte) 152, (byte) 245, (byte) 78, (byte) 118, (byte) 118, (byte) 108, (byte) 172, (byte) 107, (byte) 118, (byte) 120, (byte) 120, (byte) 111, (byte) 175, (byte) 206, (byte) 156, (byte) 233, (byte) 77, (byte) 108, (byte) 108, (byte) 191, (byte) 16, (byte) 233, (byte) 69, (byte) 105, (byte) 142, (byte) 109, (byte) 109, (byte) 255, (byte) 36, (byte) 70, (byte) 117, (byte) 147, (byte) 137, (byte) 105, (byte) 110, (byte) 124, (byte) 120, (byte) 188, (byte) 104, (byte) 109, (byte) 104, (byte) 103, (byte) 106, (byte) 193, (byte) 120, (byte) 103, (byte) 111, (byte) 104, (byte) 106, (byte) 139, (byte) 191, (byte) 39, (byte) 225, (byte) 69, (byte) 104, (byte) 158, (byte) 223, (byte) 17, (byte) 137, (byte) 105, (byte) 193, (byte) 106, (byte) 170, (byte) 104, (byte) 178, (byte) 106, (byte) 103, (byte) 101, (byte) 161, (byte) 231, (byte) 70, (byte) 105, (byte) 140, (byte) 110, (byte) 107, (byte) 100, (byte) 105, (byte) 130, (byte) 106, (byte) 105, (byte) 105, (byte) 130, (byte) 105, (byte) 110, (byte) 152, (byte) 155, (byte) 114, (byte) 255, (byte) 18, (byte) 69, (byte) 137, (byte) 104, (byte) 133, (byte) 136, (byte) 191, (byte) 8, (byte) 191, (byte) 12, (byte) 223, (byte) 12, (byte) 191, (byte) 12, (byte) 105, (byte) 110, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 105, (byte) 142, (byte) 105, (byte) 238, (byte) 69, (byte) 191, (byte) 16, (byte) 105, (byte) 140, (byte) 112, (byte) 100, (byte) 133, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 169, (byte) 159, (byte) 37, (byte) 159, (byte) 43, (byte) 108, (byte) 107, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 232, (byte) 35, (byte) 235, (byte) 97, (byte) 107, (byte) 104, (byte) 168, (byte) 99, (byte) 105, (byte) 108, (byte) 110, (byte) 100, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 183, (byte) 102, (byte) 165, (byte) 99, (byte) 105, (byte) 108, (byte) 110, (byte) 100, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 183, (byte) 102, (byte) 133, (byte) 200, (byte) 140, (byte) 112, (byte) 100, (byte) 133, (byte) 223, (byte) 13, (byte) 112, (byte) 107, (byte) 106, (byte) 106, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 168, (byte) 103, (byte) 142, (byte) 103, (byte) 99, (byte) 104, (byte) 132, (byte) 141, (byte) 99, (byte) 104, (byte) 183, (byte) 185, (byte) 233, (byte) 26, (byte) 235, (byte) 107, (byte) 105, (byte) 223, (byte) 4, (byte) 104, (byte) 211, (byte) 209, (byte) 103, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D plotArea, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      this.getInsets().trim(plotArea);
      Rectangle2D area1 = (Rectangle2D) ((RectangularShape) plotArea).clone();
      if (info != null)
      {
        info.setPlotArea(plotArea);
        info.setDataArea(plotArea);
      }
      this.drawBackground(g2, plotArea);
      Shape clip1 = ((Graphics) g2).getClip();
      g2.clip((Shape) plotArea);
      double interiorGap = this.getInteriorGap();
      double num1 = 0.0;
      if (this.getLabelGenerator() != null)
        num1 = this.getLabelGap() + this.getMaximumLabelWidth();
      double num2 = ((RectangularShape) plotArea).getWidth() * (interiorGap + num1) * 2.0;
      double num3 = ((RectangularShape) plotArea).getHeight() * interiorGap * 2.0;
      double num4 = ((RectangularShape) plotArea).getX() + num2 / 2.0;
      double num5 = ((RectangularShape) plotArea).getY() + num3 / 2.0;
      double num6 = ((RectangularShape) plotArea).getWidth() - num2;
      double num7 = ((RectangularShape) plotArea).getHeight() - num3;
      if (this.isCircular())
      {
        double num8 = Math.min(num6, num7) / 2.0;
        num4 = (num4 + num4 + num6) / 2.0 - num8;
        num5 = (num5 + num5 + num7) / 2.0 - num8;
        num6 = 2.0 * num8;
        num7 = 2.0 * num8;
      }
      PiePlotState state = this.initialise(g2, plotArea, (PiePlot) this, (Integer) null, info);
      Rectangle2D.Double double1 = new Rectangle2D.Double(num4, num5, num6, num7 * (1.0 - this.depthFactor));
      state.setLinkArea((Rectangle2D) double1);
      double num9 = num6 * this.getLabelLinkMargin();
      double num10 = num7 * this.getLabelLinkMargin();
      Rectangle2D.Double double2 = new Rectangle2D.Double(num4 + num9 / 2.0, num5 + num10 / 2.0, num6 - num9, num7 - num10);
      state.setExplodedPieArea((Rectangle2D) double2);
      double maximumExplodePercent = this.getMaximumExplodePercent();
      double num11 = maximumExplodePercent / (1.0 + maximumExplodePercent);
      double num12 = ((RectangularShape) double2).getWidth() * num11;
      double num13 = ((RectangularShape) double2).getHeight() * num11;
      Rectangle2D.Double double3 = new Rectangle2D.Double(((RectangularShape) double2).getX() + num12 / 2.0, ((RectangularShape) double2).getY() + num13 / 2.0, ((RectangularShape) double2).getWidth() - num12, ((RectangularShape) double2).getHeight() - num13);
      int num14 = ByteCodeHelper.d2i(((RectangularShape) double3).getHeight() * this.depthFactor);
      Rectangle2D.Double double4 = new Rectangle2D.Double(num4, num5, num6, num7 - (double) num14);
      state.setLinkArea((Rectangle2D) double4);
      state.setPieArea((Rectangle2D) double3);
      state.setPieCenterX(((RectangularShape) double3).getCenterX());
      state.setPieCenterY(((RectangularShape) double3).getCenterY() - (double) num14 / 2.0);
      state.setPieWRadius(((RectangularShape) double3).getWidth() / 2.0);
      state.setPieHRadius((((RectangularShape) double3).getHeight() - (double) num14) / 2.0);
      PieDataset dataset = this.getDataset();
      if (DatasetUtilities.isEmptyOrNull(this.getDataset()))
      {
        this.drawNoDataMessage(g2, plotArea);
        ((Graphics) g2).setClip(clip1);
        this.drawOutline(g2, plotArea);
      }
      else if ((double) dataset.getKeys().size() > ((RectangularShape) plotArea).getWidth())
      {
        string str = "Too many elements";
        Font font = new Font("dialog", 1, 10);
        ((Graphics) g2).setFont(font);
        int num8 = ((Graphics) g2).getFontMetrics(font).stringWidth(str);
        g2.drawString(str, ByteCodeHelper.d2i(((RectangularShape) plotArea).getX() + (((RectangularShape) plotArea).getWidth() - (double) num8) / 2.0), ByteCodeHelper.d2i(((RectangularShape) plotArea).getY() + ((RectangularShape) plotArea).getHeight() / 2.0));
      }
      else
      {
        if (this.isCircular())
        {
          double num8 = Math.min(((RectangularShape) plotArea).getWidth(), ((RectangularShape) plotArea).getHeight()) / 2.0;
          Rectangle2D.Double double5 = new Rectangle2D.Double(((RectangularShape) plotArea).getCenterX() - num8, ((RectangularShape) plotArea).getCenterY() - num8, 2.0 * num8, 2.0 * num8);
        }
        List keys1 = dataset.getKeys();
        if (keys1.size() == 0)
          return;
        double x = ((RectangularShape) double3).getX();
        double y = ((RectangularShape) double3).getY();
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
        double totalValue = DatasetUtilities.calculatePieDatasetTotal(dataset);
        double num15 = 0.0;
        if (num14 < 0)
          return;
        ArrayList arrayList = new ArrayList();
        Iterator iterator1 = keys1.iterator();
        while (iterator1.hasNext())
        {
          IComparable c = (IComparable) iterator1.next();
          Number number = dataset.getValue(c);
          if (number == null)
          {
            arrayList.add((object) null);
          }
          else
          {
            double num8 = number.doubleValue();
            if (num8 <= 0.0)
            {
              arrayList.add((object) null);
            }
            else
            {
              double startAngle = this.getStartAngle();
              double factor = this.getDirection().getFactor();
              double num16 = startAngle + factor * (num15 * 360.0) / totalValue;
              double num17 = startAngle + factor * (num15 + num8) * 360.0 / totalValue;
              if (Math.abs(num17 - num16) > this.getMinimumArcAngleToDraw())
                arrayList.add((object) new Arc2D.Double(x, y + (double) num14, ((RectangularShape) double3).getWidth(), ((RectangularShape) double3).getHeight() - (double) num14, num16, num17 - num16, 2));
              else
                arrayList.add((object) null);
              num15 += num8;
            }
          }
        }
        Shape clip2 = ((Graphics) g2).getClip();
        Ellipse2D.Double double6 = new Ellipse2D.Double(((RectangularShape) double3).getX(), ((RectangularShape) double3).getY(), ((RectangularShape) double3).getWidth(), ((RectangularShape) double3).getHeight() - (double) num14);
        Ellipse2D.Double double7 = new Ellipse2D.Double(((RectangularShape) double3).getX(), ((RectangularShape) double3).getY() + (double) num14, ((RectangularShape) double3).getWidth(), ((RectangularShape) double3).getHeight() - (double) num14);
        Rectangle2D.Double double8 = new Rectangle2D.Double(((RectangularShape) double6).getX(), ((RectangularShape) double6).getCenterY(), ((RectangularShape) double3).getWidth(), ((RectangularShape) double7).getMaxY() - ((RectangularShape) double6).getCenterY());
        Rectangle2D.Double double9 = new Rectangle2D.Double(((RectangularShape) double3).getX(), ((RectangularShape) double6).getY(), ((RectangularShape) double3).getWidth(), ((RectangularShape) double7).getCenterY() - ((RectangularShape) double6).getY());
        Area area2 = new Area((Shape) double6);
        area2.add(new Area((Shape) double8));
        Area area3 = new Area((Shape) double7);
        area3.add(new Area((Shape) double9));
        Area area4 = new Area((Shape) area2);
        area4.intersect(area3);
        Area front = new Area((Shape) area4);
        front.subtract(new Area((Shape) double6));
        Area back = new Area((Shape) area4);
        back.subtract(new Area((Shape) double7));
        Arc2D.Double double10 = new Arc2D.Double(x, y + (double) num14, ((RectangularShape) double3).getWidth(), ((RectangularShape) double3).getHeight() - (double) num14, 0.0, 360.0, 2);
        int num18 = arrayList.size();
        for (int section = 0; section < num18; ++section)
        {
          Arc2D.Double double5 = (Arc2D.Double) arrayList.get(section);
          if (double5 != null)
          {
            IComparable sectionKey = this.getSectionKey(section);
            Paint paint1 = this.lookupSectionPaint(sectionKey);
            Paint paint2 = this.lookupSectionOutlinePaint(sectionKey);
            Stroke stroke = this.lookupSectionOutlineStroke(sectionKey);
            g2.setPaint(paint1);
            g2.fill((Shape) double5);
            g2.setPaint(paint2);
            g2.setStroke(stroke);
            g2.draw((Shape) double5);
            g2.setPaint(paint1);
            Point2D startPoint = ((Arc2D) double5).getStartPoint();
            int[] numArray1 = new int[4];
            int index1 = 0;
            int num8 = ByteCodeHelper.d2i(((RectangularShape) double5).getCenterX());
            numArray1[index1] = num8;
            int index2 = 1;
            int num16 = ByteCodeHelper.d2i(((RectangularShape) double5).getCenterX());
            numArray1[index2] = num16;
            int index3 = 2;
            int num17 = ByteCodeHelper.d2i(startPoint.getX());
            numArray1[index3] = num17;
            int index4 = 3;
            int num19 = ByteCodeHelper.d2i(startPoint.getX());
            numArray1[index4] = num19;
            int[] numArray2 = numArray1;
            int[] numArray3 = new int[4];
            int index5 = 0;
            int num20 = ByteCodeHelper.d2i(((RectangularShape) double5).getCenterY());
            numArray3[index5] = num20;
            int index6 = 1;
            int num21 = ByteCodeHelper.d2i(((RectangularShape) double5).getCenterY()) - num14;
            numArray3[index6] = num21;
            int index7 = 2;
            int num22 = ByteCodeHelper.d2i(startPoint.getY()) - num14;
            numArray3[index7] = num22;
            int index8 = 3;
            int num23 = ByteCodeHelper.d2i(startPoint.getY());
            numArray3[index8] = num23;
            int[] numArray4 = numArray3;
            Polygon polygon = new Polygon(numArray2, numArray4, 4);
            g2.setPaint((Paint) Color.lightGray);
            g2.fill((Shape) polygon);
            g2.setPaint(paint2);
            g2.setStroke(stroke);
            g2.draw((Shape) polygon);
            g2.setPaint(paint1);
          }
        }
        g2.setPaint((Paint) Color.gray);
        g2.fill((Shape) back);
        g2.fill((Shape) front);
        int section1 = 0;
        Iterator iterator2 = arrayList.iterator();
        while (iterator2.hasNext())
        {
          Arc2D arc = (Arc2D) iterator2.next();
          if (arc != null)
          {
            IComparable sectionKey = this.getSectionKey(section1);
            Paint paint = this.lookupSectionPaint(sectionKey);
            Paint outlinePaint = this.lookupSectionOutlinePaint(sectionKey);
            Stroke outlineStroke = this.lookupSectionOutlineStroke(sectionKey);
            this.drawSide(g2, (Rectangle2D) double3, arc, front, back, paint, outlinePaint, outlineStroke, false, true);
          }
          ++section1;
        }
        int section2 = 0;
        Iterator iterator3 = arrayList.iterator();
        while (iterator3.hasNext())
        {
          Arc2D arc = (Arc2D) iterator3.next();
          if (arc != null)
          {
            IComparable sectionKey = this.getSectionKey(section2);
            Paint paint = this.lookupSectionPaint(sectionKey);
            Paint outlinePaint = this.lookupSectionOutlinePaint(sectionKey);
            Stroke outlineStroke = this.lookupSectionOutlineStroke(sectionKey);
            this.drawSide(g2, (Rectangle2D) double3, arc, front, back, paint, outlinePaint, outlineStroke, true, false);
          }
          ++section2;
        }
        ((Graphics) g2).setClip(clip2);
        for (int sectionIndex = 0; sectionIndex < num18; ++sectionIndex)
        {
          Arc2D.Double double5 = (Arc2D.Double) arrayList.get(sectionIndex);
          if (double5 != null)
          {
            Arc2D.Double double11 = new Arc2D.Double(x, y, ((RectangularShape) double3).getWidth(), ((RectangularShape) double3).getHeight() - (double) num14, double5.getAngleStart(), double5.getAngleExtent(), 2);
            IComparable comparable = (IComparable) keys1.get(sectionIndex);
            Paint paint1 = this.lookupSectionPaint(comparable, true);
            Paint paint2 = this.lookupSectionOutlinePaint(comparable);
            Stroke stroke = this.lookupSectionOutlineStroke(comparable);
            g2.setPaint(paint1);
            g2.fill((Shape) double11);
            g2.setStroke(stroke);
            g2.setPaint(paint2);
            g2.draw((Shape) double11);
            if (info != null)
            {
              EntityCollection entityCollection = info.getOwner().getEntityCollection();
              if (entityCollection != null)
              {
                string toolTipText = (string) null;
                PieToolTipGenerator toolTipGenerator = this.getToolTipGenerator();
                if (toolTipGenerator != null)
                  toolTipText = toolTipGenerator.generateToolTip(dataset, comparable);
                string urlText = (string) null;
                if (this.getURLGenerator() != null)
                  urlText = this.getURLGenerator().generateURL(dataset, comparable, this.getPieIndex());
                PieSectionEntity pieSectionEntity = new PieSectionEntity((Shape) double11, dataset, this.getPieIndex(), sectionIndex, comparable, toolTipText, urlText);
                entityCollection.add((ChartEntity) pieSectionEntity);
              }
            }
          }
        }
        List keys2 = dataset.getKeys();
        Rectangle2D.Double double12 = new Rectangle2D.Double(((RectangularShape) area1).getX(), ((RectangularShape) area1).getY(), ((RectangularShape) area1).getWidth(), ((RectangularShape) area1).getHeight() - (double) num14);
        if (this.getSimpleLabels())
          this.drawSimpleLabels(g2, keys2, totalValue, (Rectangle2D) double12, (Rectangle2D) double4, state);
        else
          this.drawLabels(g2, keys2, totalValue, (Rectangle2D) double12, (Rectangle2D) double4, state);
        ((Graphics) g2).setClip(clip1);
        g2.setComposite(composite);
        this.drawOutline(g2, area1);
      }
    }

    [LineNumberTable((ushort) 977)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return PiePlot.localizationResources.getString("Pie_3D_Plot");
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 132, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PiePlot3D))
        return false;
      PiePlot3D piePlot3D = (PiePlot3D) obj;
      if (this.depthFactor != piePlot3D.depthFactor || this.darkerSides != piePlot3D.darkerSides)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
