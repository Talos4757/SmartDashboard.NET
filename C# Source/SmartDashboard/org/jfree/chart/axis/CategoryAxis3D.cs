// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryAxis3D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.plot;
using org.jfree.chart.renderer.category;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryAxis3D : CategoryAxis, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 4114732251353700972L;

    [HideFromJava]
    static CategoryAxis3D()
    {
      CategoryAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryAxis3D(string label)
      : base(label)
    {
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryAxis3D()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryAxis3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryAxis3D obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryAxis3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 68, (byte) 104, (byte) 234, (byte) 70, (byte) 140, (byte) 102, (byte) 112, (byte) 108, (byte) 105, (byte) 106, (byte) 113, (byte) 145, (byte) 114, (byte) 142, (byte) 114, (byte) 138, (byte) 141, (byte) 130, (byte) 168, (byte) 104, (byte) 172, (byte) 105, (byte) 104, (byte) 142, (byte) 145, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (!this.isVisible())
      {
        return new AxisState(cursor);
      }
      else
      {
        CategoryPlot categoryPlot = (CategoryPlot) this.getPlot();
        Rectangle2D.Double @double = new Rectangle2D.Double();
        if (categoryPlot.getRenderer() is Effect3D)
        {
          Effect3D effect3D = (Effect3D) categoryPlot.getRenderer();
          double minX = ((RectangularShape) dataArea).getMinX();
          double minY = ((RectangularShape) dataArea).getMinY();
          double num1 = ((RectangularShape) dataArea).getWidth() - effect3D.getXOffset();
          double num2 = ((RectangularShape) dataArea).getHeight() - effect3D.getYOffset();
          if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003EBOTTOM)
            minY += effect3D.getYOffset();
          else if (edge == RectangleEdge.__\u003C\u003ERIGHT || edge == RectangleEdge.__\u003C\u003ETOP)
            minX += effect3D.getXOffset();
          ((Rectangle2D) @double).setRect(minX, minY, num1, num2);
        }
        else
          ((Rectangle2D) @double).setRect(dataArea);
        if (this.isAxisLineVisible())
          this.drawAxisLine(g2, cursor, (Rectangle2D) @double, edge);
        AxisState state1 = new AxisState(cursor);
        if (this.isTickMarksVisible())
          this.drawTickMarks(g2, cursor, (Rectangle2D) @double, edge, state1);
        AxisState state2 = this.drawCategoryLabels(g2, plotArea, (Rectangle2D) @double, edge, state1, plotState);
        return this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 102, (byte) 99, (byte) 108, (byte) 103, (byte) 107, (byte) 104, (byte) 106, (byte) 106, (byte) 114, (byte) 146, (byte) 114, (byte) 143, (byte) 114, (byte) 141, (byte) 206, (byte) 104, (byte) 175, (byte) 104, (byte) 175, (byte) 104, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getCategoryJava2DCoordinate(CategoryAnchor anchor, int category, int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = 0.0;
      Rectangle2D area1 = area;
      CategoryItemRenderer renderer = ((CategoryPlot) this.getPlot()).getRenderer();
      if (renderer is Effect3D)
      {
        Effect3D effect3D = (Effect3D) renderer;
        double minX = ((RectangularShape) area).getMinX();
        double minY = ((RectangularShape) area).getMinY();
        double num2 = ((RectangularShape) area).getWidth() - effect3D.getXOffset();
        double num3 = ((RectangularShape) area).getHeight() - effect3D.getYOffset();
        if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003EBOTTOM)
          minY += effect3D.getYOffset();
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT || edge == RectangleEdge.__\u003C\u003ETOP)
          minX += effect3D.getXOffset();
        area1 = (Rectangle2D) new Rectangle2D.Double(minX, minY, num2, num3);
      }
      if (anchor == CategoryAnchor.__\u003C\u003ESTART)
        num1 = this.getCategoryStart(category, categoryCount, area1, edge);
      else if (anchor == CategoryAnchor.__\u003C\u003EMIDDLE)
        num1 = this.getCategoryMiddle(category, categoryCount, area1, edge);
      else if (anchor == CategoryAnchor.__\u003C\u003EEND)
        num1 = this.getCategoryEnd(category, categoryCount, area1, edge);
      return num1;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 227)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
