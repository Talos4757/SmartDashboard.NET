// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.WaferMapPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.renderer;
using org.jfree.chart.util;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.event.RendererChangeListener", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class WaferMapPlot : Plot, RendererChangeListener, EventListener, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 4668320403707308155L;
    internal static Stroke __\u003C\u003EDEFAULT_GRIDLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    public const bool DEFAULT_CROSSHAIR_VISIBLE = false;
    internal static Stroke __\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
    protected internal static ResourceBundle localizationResources;
    private PlotOrientation orientation;
    private WaferMapDataset dataset;
    private WaferMapRenderer renderer;

    [Modifiers]
    public static Stroke DEFAULT_GRIDLINE_STROKE
    {
      [HideFromJava] get
      {
        return WaferMapPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRIDLINE_PAINT
    {
      [HideFromJava] get
      {
        return WaferMapPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_CROSSHAIR_STROKE
    {
      [HideFromJava] get
      {
        return WaferMapPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_CROSSHAIR_PAINT
    {
      [HideFromJava] get
      {
        return WaferMapPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 165, (byte) 255, (byte) 18, (byte) 72, (byte) 234, (byte) 70, (byte) 202, (byte) 170})]
    static WaferMapPlot()
    {
      Plot.__\u003Cclinit\u003E();
      double num1 = 0.5;
      int num2 = 0;
      int num3 = 2;
      double num4 = 0.0;
      float[] numArray = new float[2];
      int index1 = 0;
      double num5 = 2.0;
      numArray[index1] = (float) num5;
      int index2 = 1;
      double num6 = 2.0;
      numArray[index2] = (float) num6;
      double num7 = 0.0;
      WaferMapPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE = (Stroke) new BasicStroke((float) num1, num2, num3, (float) num4, numArray, (float) num7);
      WaferMapPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT = (Paint) Color.lightGray;
      WaferMapPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE = WaferMapPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      WaferMapPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT = (Paint) Color.blue;
      WaferMapPlot.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapPlot(WaferMapDataset dataset)
      : this(dataset, (WaferMapRenderer) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 136, (byte) 139, (byte) 103, (byte) 99, (byte) 167, (byte) 103, (byte) 99, (byte) 103, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapPlot(WaferMapDataset dataset, WaferMapRenderer renderer)
    {
      WaferMapPlot waferMapPlot = this;
      this.orientation = PlotOrientation.__\u003C\u003EVERTICAL;
      this.dataset = dataset;
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.renderer = renderer;
      if (renderer == null)
        return;
      renderer.setPlot(this);
      renderer.addChangeListener((RendererChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapPlot()
      : this((WaferMapDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WaferMapPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] WaferMapPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] WaferMapPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 104, (byte) 140, (byte) 103, (byte) 99, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(WaferMapRenderer renderer)
    {
      if (this.renderer != null)
        this.renderer.removeChangeListener((RendererChangeListener) this);
      this.renderer = renderer;
      if (renderer != null)
        renderer.setPlot(this);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 103, (byte) 109, (byte) 102, (byte) 99, (byte) 99, (byte) 103, (byte) 104, (byte) 110, (byte) 110, (byte) 142, (byte) 105, (byte) 105, (byte) 103, (byte) 103, (byte) 113, (byte) 102, (byte) 102, (byte) 110, (byte) 105, (byte) 171, (byte) 105, (byte) 169, (byte) 106, (byte) 117, (byte) 152, (byte) 218, (byte) 117, (byte) 152, (byte) 248, (byte) 69, (byte) 107, (byte) 152, (byte) 107, (byte) 152, (byte) 110, (byte) 107, (byte) 119, (byte) 255, (byte) 7, (byte) 70, (byte) 103, (byte) 107, (byte) 231, (byte) 50, (byte) 235, (byte) 61, (byte) 235, (byte) 84, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawChipGrid(Graphics2D g2, Rectangle2D plotArea)
    {
      Shape clip = ((Graphics) g2).getClip();
      ((Graphics) g2).setClip((Shape) this.getWaferEdge(plotArea));
      Rectangle2D.Double @double = new Rectangle2D.Double();
      int num1 = 35;
      int num2 = 20;
      double num3 = 1.0;
      if (this.dataset != null)
      {
        num1 = this.dataset.getMaxChipX() + 2;
        num2 = this.dataset.getMaxChipY() + 2;
        num3 = this.dataset.getChipSpace();
      }
      double x = ((RectangularShape) plotArea).getX();
      double y = ((RectangularShape) plotArea).getY();
      double num4 = 1.0;
      double num5 = 1.0;
      if (((RectangularShape) plotArea).getWidth() != ((RectangularShape) plotArea).getHeight())
      {
        double num6;
        double num7;
        if (((RectangularShape) plotArea).getWidth() > ((RectangularShape) plotArea).getHeight())
        {
          num6 = ((RectangularShape) plotArea).getWidth();
          num7 = ((RectangularShape) plotArea).getHeight();
        }
        else
        {
          num6 = ((RectangularShape) plotArea).getHeight();
          num7 = ((RectangularShape) plotArea).getWidth();
        }
        if (((RectangularShape) plotArea).getWidth() == num7)
        {
          y += (num6 - num7) / 2.0;
          num4 = (((RectangularShape) plotArea).getWidth() - (num3 * (double) num1 - 1.0)) / (double) num1;
          num5 = (((RectangularShape) plotArea).getWidth() - (num3 * (double) num2 - 1.0)) / (double) num2;
        }
        else
        {
          x += (num6 - num7) / 2.0;
          num4 = (((RectangularShape) plotArea).getHeight() - (num3 * (double) num1 - 1.0)) / (double) num1;
          num5 = (((RectangularShape) plotArea).getHeight() - (num3 * (double) num2 - 1.0)) / (double) num2;
        }
      }
      for (int index1 = 1; index1 <= num1; ++index1)
      {
        double num6 = x - num4 + num4 * (double) index1 + num3 * (double) (index1 - 1);
        for (int index2 = 1; index2 <= num2; ++index2)
        {
          double num7 = y - num5 + num5 * (double) index2 + num3 * (double) (index2 - 1);
          ((Rectangle2D) @double).setFrame(num6, num7, num4, num5);
          ((Graphics) g2).setColor((Color) Color.white);
          if (this.dataset.getChipValue(index1 - 1, num2 - index2 - 1) != null)
            g2.setPaint(this.renderer.getChipColor(this.dataset.getChipValue(index1 - 1, num2 - index2 - 1)));
          g2.fill((Shape) @double);
          ((Graphics) g2).setColor((Color) Color.lightGray);
          g2.draw((Shape) @double);
        }
      }
      ((Graphics) g2).setClip(clip);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 104, (byte) 107, (byte) 199, (byte) 98, (byte) 103, (byte) 114, (byte) 112, (byte) 255, (byte) 37, (byte) 71, (byte) 123, (byte) 130, (byte) 255, (byte) 37, (byte) 71, (byte) 151, (byte) 107, (byte) 104, (byte) 107, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawWaferEdge(Graphics2D g2, Rectangle2D plotArea)
    {
      Ellipse2D waferEdge = this.getWaferEdge(plotArea);
      ((Graphics) g2).setColor((Color) Color.black);
      g2.draw((Shape) waferEdge);
      Rectangle2D frame = ((RectangularShape) waferEdge).getFrame();
      double num = ((RectangularShape) frame).getWidth() * 0.04;
      Arc2D.Double @double = this.orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? new Arc2D.Double((Rectangle2D) new Rectangle2D.Double(((RectangularShape) frame).getX() + ((RectangularShape) frame).getWidth() / 2.0 - num / 2.0, ((RectangularShape) frame).getY() + ((RectangularShape) frame).getHeight() - num / 2.0, num, num), 0.0, 180.0, 0) : new Arc2D.Double((Rectangle2D) new Rectangle2D.Double(((RectangularShape) frame).getX() + ((RectangularShape) frame).getWidth() - num / 2.0, ((RectangularShape) frame).getY() + ((RectangularShape) frame).getHeight() / 2.0 - num / 2.0, num, num), 90.0, 180.0, 0);
      ((Graphics) g2).setColor((Color) Color.white);
      g2.fill((Shape) @double);
      ((Graphics) g2).setColor((Color) Color.black);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 102, (byte) 104, (byte) 104, (byte) 136, (byte) 113, (byte) 102, (byte) 102, (byte) 110, (byte) 105, (byte) 171, (byte) 105, (byte) 169, (byte) 131, (byte) 106, (byte) 186, (byte) 184, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Ellipse2D getWaferEdge(Rectangle2D plotArea)
    {
      Ellipse2D.Double @double = new Ellipse2D.Double();
      double num1 = ((RectangularShape) plotArea).getWidth();
      double num2 = ((RectangularShape) plotArea).getX();
      double num3 = ((RectangularShape) plotArea).getY();
      if (((RectangularShape) plotArea).getWidth() != ((RectangularShape) plotArea).getHeight())
      {
        double num4;
        double num5;
        if (((RectangularShape) plotArea).getWidth() > ((RectangularShape) plotArea).getHeight())
        {
          num4 = ((RectangularShape) plotArea).getWidth();
          num5 = ((RectangularShape) plotArea).getHeight();
        }
        else
        {
          num4 = ((RectangularShape) plotArea).getHeight();
          num5 = ((RectangularShape) plotArea).getWidth();
        }
        num1 = num5;
        if (((RectangularShape) plotArea).getWidth() == num5)
          num3 = ((RectangularShape) plotArea).getY() + (num4 - num5) / 2.0;
        else
          num2 = ((RectangularShape) plotArea).getX() + (num4 - num5) / 2.0;
      }
      ((RectangularShape) @double).setFrame(num2, num3, num1, num1);
      return (Ellipse2D) @double;
    }

    public override string getPlotType()
    {
      return "WMAP_Plot";
    }

    public virtual WaferMapDataset getDataset()
    {
      return this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 104, (byte) 204, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(WaferMapDataset dataset)
    {
      if (this.dataset != null)
        this.dataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 117, (byte) 117, (byte) 102, (byte) 193, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState state, PlotRenderingInfo info)
    {
      if (((RectangularShape) area).getWidth() <= 10.0 || ((RectangularShape) area).getHeight() <= 10.0)
        return;
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      this.drawChipGrid(g2, area);
      this.drawWaferEdge(g2, area);
    }

    [LineNumberTable((ushort) 420)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      return this.renderer.getLegendCollection();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 59, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void rendererChanged(RendererChangeEvent @event)
    {
      this.fireChangeEvent();
    }
  }
}
