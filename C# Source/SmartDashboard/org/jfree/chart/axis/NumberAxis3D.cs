// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.NumberAxis3D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.util;
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class NumberAxis3D : NumberAxis, Serializable.__Interface
  {
    private const long serialVersionUID = -1790205852569123512L;

    [HideFromJava]
    static NumberAxis3D()
    {
      NumberAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberAxis3D(string label)
      : base(label)
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberAxis3D()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NumberAxis3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] NumberAxis3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 79, (byte) 104, (byte) 168, (byte) 109, (byte) 103, (byte) 194, (byte) 102, (byte) 102, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 201, (byte) 106, (byte) 106, (byte) 108, (byte) 140, (byte) 114, (byte) 137, (byte) 114, (byte) 135, (byte) 207, (byte) 208, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (!this.isVisible())
      {
        AxisState state = new AxisState(cursor);
        List ticks = this.refreshTicks(g2, state, dataArea, edge);
        state.setTicks(ticks);
        return state;
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        Plot plot = this.getPlot();
        if (plot is CategoryPlot)
        {
          CategoryItemRenderer renderer = ((CategoryPlot) plot).getRenderer();
          if (renderer is Effect3D)
          {
            Effect3D effect3D = (Effect3D) renderer;
            num1 = effect3D.getXOffset();
            num2 = effect3D.getYOffset();
          }
        }
        double minX = ((RectangularShape) dataArea).getMinX();
        double minY = ((RectangularShape) dataArea).getMinY();
        double num3 = ((RectangularShape) dataArea).getWidth() - num1;
        double num4 = ((RectangularShape) dataArea).getHeight() - num2;
        if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003EBOTTOM)
          minY += num2;
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT || edge == RectangleEdge.__\u003C\u003ETOP)
          minX += num1;
        Rectangle2D.Double @double = new Rectangle2D.Double(minX, minY, num3, num4);
        AxisState state = this.drawTickMarksAndLabels(g2, cursor, plotArea, (Rectangle2D) @double, edge);
        return this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state);
      }
    }
  }
}
