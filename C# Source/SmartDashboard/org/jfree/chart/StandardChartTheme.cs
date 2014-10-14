// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.StandardChartTheme
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.annotations;
using org.jfree.chart.axis;
using org.jfree.chart.block;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.chart.renderer.category;
using org.jfree.chart.renderer.xy;
using org.jfree.chart.title;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"org.jfree.chart.ChartTheme", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardChartTheme : Object, ChartTheme, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private string name;
    private Font extraLargeFont;
    private Font largeFont;
    private Font regularFont;
    private Font smallFont;
    [NonSerialized]
    private Paint titlePaint;
    [NonSerialized]
    private Paint subtitlePaint;
    [NonSerialized]
    private Paint chartBackgroundPaint;
    [NonSerialized]
    private Paint legendBackgroundPaint;
    [NonSerialized]
    private Paint legendItemPaint;
    private DrawingSupplier drawingSupplier;
    [NonSerialized]
    private Paint plotBackgroundPaint;
    [NonSerialized]
    private Paint plotOutlinePaint;
    private PieLabelLinkStyle labelLinkStyle;
    [NonSerialized]
    private Paint labelLinkPaint;
    [NonSerialized]
    private Paint domainGridlinePaint;
    [NonSerialized]
    private Paint rangeGridlinePaint;
    [NonSerialized]
    private Paint baselinePaint;
    [NonSerialized]
    private Paint crosshairPaint;
    private RectangleInsets axisOffset;
    [NonSerialized]
    private Paint axisLabelPaint;
    [NonSerialized]
    private Paint tickLabelPaint;
    [NonSerialized]
    private Paint itemLabelPaint;
    private bool shadowVisible;
    [NonSerialized]
    private Paint shadowPaint;
    private BarPainter barPainter;
    private XYBarPainter xyBarPainter;
    [NonSerialized]
    private Paint thermometerPaint;
    [NonSerialized]
    private Paint wallPaint;
    [NonSerialized]
    private Paint errorIndicatorPaint;
    [NonSerialized]
    private Paint gridBandPaint;
    [NonSerialized]
    private Paint gridBandAlternatePaint;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 232, (byte) 159, (byte) 180, (byte) 171, (byte) 235, (byte) 160, (byte) 74, (byte) 99, (byte) 144, (byte) 103, (byte) 115, (byte) 115, (byte) 115, (byte) 115, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 127, (byte) 16, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardChartTheme(string name)
    {
      base.\u002Ector();
      StandardChartTheme standardChartTheme = this;
      this.gridBandPaint = SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_PAINT;
      this.gridBandAlternatePaint = SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_ALTERNATE_PAINT;
      if (name == null)
      {
        string str = "Null 'name' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.name = name;
        this.extraLargeFont = new Font("Tahoma", 1, 20);
        this.largeFont = new Font("Tahoma", 1, 14);
        this.regularFont = new Font("Tahoma", 0, 12);
        this.smallFont = new Font("Tahoma", 0, 10);
        this.titlePaint = (Paint) Color.black;
        this.subtitlePaint = (Paint) Color.black;
        this.legendBackgroundPaint = (Paint) Color.white;
        this.legendItemPaint = (Paint) Color.darkGray;
        this.chartBackgroundPaint = (Paint) Color.white;
        this.drawingSupplier = (DrawingSupplier) new DefaultDrawingSupplier();
        this.plotBackgroundPaint = (Paint) Color.lightGray;
        this.plotOutlinePaint = (Paint) Color.black;
        this.labelLinkPaint = (Paint) Color.black;
        this.labelLinkStyle = PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE;
        this.axisOffset = new RectangleInsets(4.0, 4.0, 4.0, 4.0);
        this.domainGridlinePaint = (Paint) Color.white;
        this.rangeGridlinePaint = (Paint) Color.white;
        this.baselinePaint = (Paint) Color.black;
        this.crosshairPaint = (Paint) Color.blue;
        this.axisLabelPaint = (Paint) Color.darkGray;
        this.tickLabelPaint = (Paint) Color.darkGray;
        this.barPainter = (BarPainter) new GradientBarPainter();
        this.xyBarPainter = (XYBarPainter) new GradientXYBarPainter();
        this.shadowVisible = true;
        this.shadowPaint = (Paint) Color.gray;
        this.itemLabelPaint = (Paint) Color.black;
        this.thermometerPaint = (Paint) Color.white;
        this.wallPaint = BarRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT;
        this.errorIndicatorPaint = (Paint) Color.black;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardChartTheme([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardChartTheme obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardChartTheme obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual string getName()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 25, (byte) 104, (byte) 103, (byte) 108, (byte) 108, (byte) 101, (byte) 104, (byte) 103, (byte) 104, (byte) 140, (byte) 108, (byte) 108, (byte) 104, (byte) 140, (byte) 101, (byte) 104, (byte) 103, (byte) 108, (byte) 103, (byte) 99, (byte) 135, (byte) 101, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 110, (byte) 105, (byte) 141, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToTitle(Title title)
    {
      if (title is TextTitle)
      {
        TextTitle textTitle = (TextTitle) title;
        textTitle.setFont(this.largeFont);
        textTitle.setPaint(this.subtitlePaint);
      }
      else if (title is LegendTitle)
      {
        LegendTitle legendTitle = (LegendTitle) title;
        if (legendTitle.getBackgroundPaint() != null)
          legendTitle.setBackgroundPaint(this.legendBackgroundPaint);
        legendTitle.setItemFont(this.regularFont);
        legendTitle.setItemPaint(this.legendItemPaint);
        if (legendTitle.getWrapper() == null)
          return;
        this.applyToBlockContainer(legendTitle.getWrapper());
      }
      else if (title is PaintScaleLegend)
      {
        PaintScaleLegend paintScaleLegend = (PaintScaleLegend) title;
        paintScaleLegend.setBackgroundPaint(this.legendBackgroundPaint);
        ValueAxis axis = paintScaleLegend.getAxis();
        if (axis == null)
          return;
        this.applyToValueAxis(axis);
      }
      else
      {
        if (!(title is CompositeTitle))
          return;
        Iterator iterator = ((CompositeTitle) title).getContainer().getBlocks().iterator();
        while (iterator.hasNext())
        {
          Block block = (Block) iterator.next();
          if (block is Title)
            this.applyToTitle((Title) block);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 98, (byte) 99, (byte) 144, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 236, (byte) 70, (byte) 104, (byte) 145, (byte) 104, (byte) 145, (byte) 104, (byte) 145, (byte) 104, (byte) 145, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToPlot(Plot plot)
    {
      if (plot == null)
      {
        string str = "Null 'plot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (plot.getDrawingSupplier() != null)
          plot.setDrawingSupplier(this.getDrawingSupplier());
        if (plot.getBackgroundPaint() != null)
          plot.setBackgroundPaint(this.plotBackgroundPaint);
        plot.setOutlinePaint(this.plotOutlinePaint);
        if (plot is PiePlot)
          this.applyToPiePlot((PiePlot) plot);
        else if (plot is MultiplePiePlot)
          this.applyToMultiplePiePlot((MultiplePiePlot) plot);
        else if (plot is CategoryPlot)
          this.applyToCategoryPlot((CategoryPlot) plot);
        else if (plot is XYPlot)
          this.applyToXYPlot((XYPlot) plot);
        else if (plot is FastScatterPlot)
          this.applyToFastScatterPlot((FastScatterPlot) plot);
        else if (plot is MeterPlot)
          this.applyToMeterPlot((MeterPlot) plot);
        else if (plot is ThermometerPlot)
          this.applyToThermometerPlot((ThermometerPlot) plot);
        else if (plot is SpiderWebPlot)
        {
          this.applyToSpiderWebPlot((SpiderWebPlot) plot);
        }
        else
        {
          if (!(plot is PolarPlot))
            return;
          this.applyToPolarPlot((PolarPlot) plot);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 69, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToBlockContainer(BlockContainer bc)
    {
      Iterator iterator = bc.getBlocks().iterator();
      while (iterator.hasNext())
        this.applyToBlock((Block) iterator.next());
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 148, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 104, (byte) 140, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToValueAxis(ValueAxis axis)
    {
      axis.setLabelFont(this.largeFont);
      axis.setLabelPaint(this.axisLabelPaint);
      axis.setTickLabelFont(this.regularFont);
      axis.setTickLabelPaint(this.tickLabelPaint);
      if (axis is SymbolAxis)
        this.applyToSymbolAxis((SymbolAxis) axis);
      if (!(axis is PeriodAxis))
        return;
      this.applyToPeriodAxis((PeriodAxis) axis);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 82, (byte) 104, (byte) 142, (byte) 104, (byte) 103, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToBlock(Block b)
    {
      if (b is Title)
      {
        this.applyToTitle((Title) b);
      }
      else
      {
        if (!(b is LabelBlock))
          return;
        LabelBlock labelBlock = (LabelBlock) b;
        labelBlock.setFont(this.regularFont);
        labelBlock.setPaint(this.legendItemPaint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 219, (byte) 98, (byte) 109, (byte) 140, (byte) 222, (byte) 2, (byte) 97, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DrawingSupplier getDrawingSupplier()
    {
      DrawingSupplier drawingSupplier = (DrawingSupplier) null;
      if (this.drawingSupplier is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.drawingSupplier;
        CloneNotSupportedException supportedException;
        try
        {
          drawingSupplier = (DrawingSupplier) publicCloneable.clone();
          goto label_5;
        }
        catch (CloneNotSupportedException ex)
        {
          int num = 1;
          supportedException = (CloneNotSupportedException) ByteCodeHelper.MapException<CloneNotSupportedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        Throwable.instancehelper_printStackTrace((Exception) supportedException);
      }
label_5:
      return drawingSupplier;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 150, (byte) 108, (byte) 108, (byte) 204, (byte) 104, (byte) 135, (byte) 104, (byte) 135, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToPiePlot(PiePlot plot)
    {
      plot.setLabelLinkPaint(this.labelLinkPaint);
      plot.setLabelLinkStyle(this.labelLinkStyle);
      plot.setLabelFont(this.regularFont);
      if (plot.getAutoPopulateSectionPaint())
        plot.clearSectionPaints(false);
      if (plot.getAutoPopulateSectionOutlinePaint())
        plot.clearSectionOutlinePaints(false);
      if (!plot.getAutoPopulateSectionOutlineStroke())
        return;
      plot.clearSectionOutlineStrokes(false);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 173, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToMultiplePiePlot(MultiplePiePlot plot)
    {
      this.apply(plot.getPieChart());
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 182, (byte) 108, (byte) 108, (byte) 108, (byte) 172, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 72, (byte) 103, (byte) 102, (byte) 105, (byte) 100, (byte) 232, (byte) 61, (byte) 230, (byte) 72, (byte) 103, (byte) 104, (byte) 106, (byte) 100, (byte) 232, (byte) 61, (byte) 232, (byte) 71, (byte) 104, (byte) 104, (byte) 110, (byte) 105, (byte) 110, (byte) 100, (byte) 136, (byte) 130, (byte) 104, (byte) 104, (byte) 110, (byte) 105, (byte) 110, (byte) 100, (byte) 136, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToCategoryPlot(CategoryPlot plot)
    {
      plot.setAxisOffset(this.axisOffset);
      plot.setDomainGridlinePaint(this.domainGridlinePaint);
      plot.setRangeGridlinePaint(this.rangeGridlinePaint);
      plot.setRangeZeroBaselinePaint(this.baselinePaint);
      int domainAxisCount = plot.getDomainAxisCount();
      for (int index = 0; index < domainAxisCount; ++index)
      {
        CategoryAxis domainAxis = plot.getDomainAxis(index);
        if (domainAxis != null)
          this.applyToCategoryAxis(domainAxis);
      }
      int rangeAxisCount = plot.getRangeAxisCount();
      for (int index = 0; index < rangeAxisCount; ++index)
      {
        ValueAxis rangeAxis = plot.getRangeAxis(index);
        if (rangeAxis != null)
          this.applyToValueAxis(rangeAxis);
      }
      int rendererCount = plot.getRendererCount();
      for (int index = 0; index < rendererCount; ++index)
      {
        CategoryItemRenderer renderer = plot.getRenderer(index);
        if (renderer != null)
          this.applyToCategoryItemRenderer(renderer);
      }
      if (plot is CombinedDomainCategoryPlot)
      {
        Iterator iterator = ((CombinedDomainCategoryPlot) plot).getSubplots().iterator();
        while (iterator.hasNext())
        {
          CategoryPlot categoryPlot = (CategoryPlot) iterator.next();
          if (categoryPlot != null)
            this.applyToPlot((Plot) categoryPlot);
        }
      }
      if (!(plot is CombinedRangeCategoryPlot))
        return;
      Iterator iterator1 = ((CombinedRangeCategoryPlot) plot).getSubplots().iterator();
      while (iterator1.hasNext())
      {
        CategoryPlot categoryPlot = (CategoryPlot) iterator1.next();
        if (categoryPlot != null)
          this.applyToPlot((Plot) categoryPlot);
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 242, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 72, (byte) 103, (byte) 102, (byte) 105, (byte) 100, (byte) 232, (byte) 61, (byte) 230, (byte) 72, (byte) 103, (byte) 104, (byte) 106, (byte) 100, (byte) 232, (byte) 61, (byte) 232, (byte) 72, (byte) 109, (byte) 105, (byte) 110, (byte) 104, (byte) 130, (byte) 104, (byte) 104, (byte) 110, (byte) 105, (byte) 110, (byte) 100, (byte) 136, (byte) 130, (byte) 104, (byte) 104, (byte) 110, (byte) 105, (byte) 110, (byte) 100, (byte) 136, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToXYPlot(XYPlot plot)
    {
      plot.setAxisOffset(this.axisOffset);
      plot.setDomainZeroBaselinePaint(this.baselinePaint);
      plot.setRangeZeroBaselinePaint(this.baselinePaint);
      plot.setDomainGridlinePaint(this.domainGridlinePaint);
      plot.setRangeGridlinePaint(this.rangeGridlinePaint);
      plot.setDomainCrosshairPaint(this.crosshairPaint);
      plot.setRangeCrosshairPaint(this.crosshairPaint);
      int domainAxisCount = plot.getDomainAxisCount();
      for (int index = 0; index < domainAxisCount; ++index)
      {
        ValueAxis domainAxis = plot.getDomainAxis(index);
        if (domainAxis != null)
          this.applyToValueAxis(domainAxis);
      }
      int rangeAxisCount = plot.getRangeAxisCount();
      for (int index = 0; index < rangeAxisCount; ++index)
      {
        ValueAxis rangeAxis = plot.getRangeAxis(index);
        if (rangeAxis != null)
          this.applyToValueAxis(rangeAxis);
      }
      int rendererCount = plot.getRendererCount();
      for (int index = 0; index < rendererCount; ++index)
      {
        XYItemRenderer renderer = plot.getRenderer(index);
        if (renderer != null)
          this.applyToXYItemRenderer(renderer);
      }
      Iterator iterator1 = plot.getAnnotations().iterator();
      while (iterator1.hasNext())
        this.applyToXYAnnotation((XYAnnotation) iterator1.next());
      if (plot is CombinedDomainXYPlot)
      {
        Iterator iterator2 = ((CombinedDomainXYPlot) plot).getSubplots().iterator();
        while (iterator2.hasNext())
        {
          XYPlot xyPlot = (XYPlot) iterator2.next();
          if (xyPlot != null)
            this.applyToPlot((Plot) xyPlot);
        }
      }
      if (!(plot is CombinedRangeXYPlot))
        return;
      Iterator iterator3 = ((CombinedRangeXYPlot) plot).getSubplots().iterator();
      while (iterator3.hasNext())
      {
        XYPlot xyPlot = (XYPlot) iterator3.next();
        if (xyPlot != null)
          this.applyToPlot((Plot) xyPlot);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 54, (byte) 108, (byte) 108, (byte) 103, (byte) 99, (byte) 135, (byte) 103, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToFastScatterPlot(FastScatterPlot plot)
    {
      plot.setDomainGridlinePaint(this.domainGridlinePaint);
      plot.setRangeGridlinePaint(this.rangeGridlinePaint);
      ValueAxis domainAxis = plot.getDomainAxis();
      if (domainAxis != null)
        this.applyToValueAxis(domainAxis);
      ValueAxis rangeAxis = plot.getRangeAxis();
      if (rangeAxis == null)
        return;
      this.applyToValueAxis(rangeAxis);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 101, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToMeterPlot(MeterPlot plot)
    {
      plot.setDialBackgroundPaint(this.plotBackgroundPaint);
      plot.setValueFont(this.largeFont);
      plot.setValuePaint(this.axisLabelPaint);
      plot.setDialOutlinePaint(this.plotOutlinePaint);
      plot.setNeedlePaint(this.thermometerPaint);
      plot.setTickLabelFont(this.regularFont);
      plot.setTickLabelPaint(this.tickLabelPaint);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 117, (byte) 108, (byte) 108, (byte) 103, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToThermometerPlot(ThermometerPlot plot)
    {
      plot.setValueFont(this.largeFont);
      plot.setThermometerPaint(this.thermometerPaint);
      ValueAxis rangeAxis = plot.getRangeAxis();
      if (rangeAxis == null)
        return;
      this.applyToValueAxis(rangeAxis);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 90, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToSpiderWebPlot(SpiderWebPlot plot)
    {
      plot.setLabelFont(this.regularFont);
      plot.setLabelPaint(this.axisLabelPaint);
      plot.setAxisLinePaint(this.axisLabelPaint);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 74, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 103, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToPolarPlot(PolarPlot plot)
    {
      plot.setAngleLabelFont(this.regularFont);
      plot.setAngleLabelPaint(this.tickLabelPaint);
      plot.setAngleGridlinePaint(this.domainGridlinePaint);
      plot.setRadiusGridlinePaint(this.rangeGridlinePaint);
      ValueAxis axis = plot.getAxis();
      if (axis == null)
        return;
      this.applyToValueAxis(axis);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 252, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 108, (byte) 172, (byte) 103, (byte) 102, (byte) 45, (byte) 198, (byte) 172, (byte) 103, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void apply(JFreeChart chart)
    {
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TextTitle title = chart.getTitle();
        if (title != null)
        {
          title.setFont(this.extraLargeFont);
          title.setPaint(this.titlePaint);
        }
        int subtitleCount = chart.getSubtitleCount();
        for (int index = 0; index < subtitleCount; ++index)
          this.applyToTitle(chart.getSubtitle(index));
        chart.setBackgroundPaint(this.chartBackgroundPaint);
        Plot plot = chart.getPlot();
        if (plot == null)
          return;
        this.applyToPlot(plot);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 131, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 104, (byte) 103, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToCategoryAxis(CategoryAxis axis)
    {
      axis.setLabelFont(this.largeFont);
      axis.setLabelPaint(this.axisLabelPaint);
      ((Axis) axis).setTickLabelFont(this.regularFont);
      ((Axis) axis).setTickLabelPaint(this.tickLabelPaint);
      if (!(axis is SubCategoryAxis))
        return;
      SubCategoryAxis subCategoryAxis = (SubCategoryAxis) axis;
      subCategoryAxis.setSubLabelFont(this.regularFont);
      subCategoryAxis.setSubLabelPaint(this.tickLabelPaint);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 208, (byte) 99, (byte) 176, (byte) 104, (byte) 172, (byte) 108, (byte) 236, (byte) 69, (byte) 104, (byte) 103, (byte) 108, (byte) 108, (byte) 204, (byte) 104, (byte) 103, (byte) 204, (byte) 104, (byte) 103, (byte) 204, (byte) 104, (byte) 103, (byte) 204, (byte) 104, (byte) 104, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToCategoryItemRenderer(CategoryItemRenderer renderer)
    {
      if (renderer == null)
      {
        string str = "Null 'renderer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (renderer is AbstractRenderer)
          this.applyToAbstractRenderer((AbstractRenderer) renderer);
        renderer.setBaseItemLabelFont(this.regularFont);
        renderer.setBaseItemLabelPaint(this.itemLabelPaint);
        if (renderer is BarRenderer)
        {
          BarRenderer barRenderer = (BarRenderer) renderer;
          barRenderer.setBarPainter(this.barPainter);
          barRenderer.setShadowVisible(this.shadowVisible);
          barRenderer.setShadowPaint(this.shadowPaint);
        }
        if (renderer is BarRenderer3D)
          ((BarRenderer3D) renderer).setWallPaint(this.wallPaint);
        if (renderer is LineRenderer3D)
          ((LineRenderer3D) renderer).setWallPaint(this.wallPaint);
        if (renderer is StatisticalBarRenderer)
          ((StatisticalBarRenderer) renderer).setErrorIndicatorPaint(this.errorIndicatorPaint);
        if (!(renderer is MinMaxCategoryRenderer))
          return;
        ((MinMaxCategoryRenderer) renderer).setGroupPaint(this.errorIndicatorPaint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 4, (byte) 99, (byte) 144, (byte) 104, (byte) 140, (byte) 108, (byte) 108, (byte) 104, (byte) 103, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToXYItemRenderer(XYItemRenderer renderer)
    {
      if (renderer == null)
      {
        string str = "Null 'renderer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (renderer is AbstractRenderer)
          this.applyToAbstractRenderer((AbstractRenderer) renderer);
        renderer.setBaseItemLabelFont(this.regularFont);
        renderer.setBaseItemLabelPaint(this.itemLabelPaint);
        if (!(renderer is XYBarRenderer))
          return;
        XYBarRenderer xyBarRenderer = (XYBarRenderer) renderer;
        xyBarRenderer.setBarPainter(this.xyBarPainter);
        xyBarRenderer.setShadowVisible(this.shadowVisible);
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 25, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToXYAnnotation(XYAnnotation annotation)
    {
      if (annotation == null)
      {
        string str = "Null 'annotation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!(annotation is XYTextAnnotation))
          return;
        XYTextAnnotation xyTextAnnotation = (XYTextAnnotation) annotation;
        xyTextAnnotation.setFont(this.smallFont);
        xyTextAnnotation.setPaint(this.itemLabelPaint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 166, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToSymbolAxis(SymbolAxis axis)
    {
      axis.setGridBandPaint(this.gridBandPaint);
      axis.setGridBandAlternatePaint(this.gridBandAlternatePaint);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 176, (byte) 103, (byte) 103, (byte) 100, (byte) 223, (byte) 28, (byte) 228, (byte) 58, (byte) 233, (byte) 72, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToPeriodAxis(PeriodAxis axis)
    {
      PeriodAxisLabelInfo[] labelInfo = axis.getLabelInfo();
      for (int index = 0; index < labelInfo.Length; ++index)
      {
        PeriodAxisLabelInfo periodAxisLabelInfo1 = labelInfo[index];
        PeriodAxisLabelInfo.__\u003Cclinit\u003E();
        PeriodAxisLabelInfo periodAxisLabelInfo2 = new PeriodAxisLabelInfo(periodAxisLabelInfo1.getPeriodClass(), periodAxisLabelInfo1.getDateFormat(), periodAxisLabelInfo1.getPadding(), this.regularFont, this.tickLabelPaint, periodAxisLabelInfo1.getDrawDividers(), periodAxisLabelInfo1.getDividerStroke(), periodAxisLabelInfo1.getDividerPaint());
        labelInfo[index] = periodAxisLabelInfo2;
      }
      axis.setLabelInfo(labelInfo);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 194, (byte) 104, (byte) 135, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void applyToAbstractRenderer(AbstractRenderer renderer)
    {
      if (renderer.getAutoPopulateSeriesPaint())
        renderer.clearSeriesPaints(false);
      if (!renderer.getAutoPopulateSeriesStroke())
        return;
      renderer.clearSeriesStrokes(false);
    }

    [LineNumberTable((ushort) 239)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ChartTheme createJFreeTheme()
    {
      return (ChartTheme) new StandardChartTheme("JFree");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 160, (byte) 148, (byte) 76, (byte) 107, (byte) 107, (byte) 124, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ChartTheme createDarknessTheme()
    {
      StandardChartTheme standardChartTheme1 = new StandardChartTheme("Darkness");
      standardChartTheme1.titlePaint = (Paint) Color.white;
      standardChartTheme1.subtitlePaint = (Paint) Color.white;
      standardChartTheme1.legendBackgroundPaint = (Paint) Color.black;
      standardChartTheme1.legendItemPaint = (Paint) Color.white;
      standardChartTheme1.chartBackgroundPaint = (Paint) Color.black;
      standardChartTheme1.plotBackgroundPaint = (Paint) Color.black;
      standardChartTheme1.plotOutlinePaint = (Paint) Color.yellow;
      standardChartTheme1.baselinePaint = (Paint) Color.white;
      standardChartTheme1.crosshairPaint = (Paint) Color.red;
      standardChartTheme1.labelLinkPaint = (Paint) Color.lightGray;
      standardChartTheme1.tickLabelPaint = (Paint) Color.white;
      standardChartTheme1.axisLabelPaint = (Paint) Color.white;
      standardChartTheme1.shadowPaint = (Paint) Color.darkGray;
      standardChartTheme1.itemLabelPaint = (Paint) Color.white;
      StandardChartTheme standardChartTheme2 = standardChartTheme1;
      DefaultDrawingSupplier.__\u003Cclinit\u003E();
      Paint[] paintSequence = new Paint[11];
      int index1 = 0;
      Color color1 = Color.decode("0xFFFF00");
      paintSequence[index1] = (Paint) color1;
      int index2 = 1;
      Color color2 = Color.decode("0x0036CC");
      paintSequence[index2] = (Paint) color2;
      int index3 = 2;
      Color color3 = Color.decode("0xFF0000");
      paintSequence[index3] = (Paint) color3;
      int index4 = 3;
      Color color4 = Color.decode("0xFFFF7F");
      paintSequence[index4] = (Paint) color4;
      int index5 = 4;
      Color color5 = Color.decode("0x6681CC");
      paintSequence[index5] = (Paint) color5;
      int index6 = 5;
      Color color6 = Color.decode("0xFF7F7F");
      paintSequence[index6] = (Paint) color6;
      int index7 = 6;
      Color color7 = Color.decode("0xFFFFBF");
      paintSequence[index7] = (Paint) color7;
      int index8 = 7;
      Color color8 = Color.decode("0x99A6CC");
      paintSequence[index8] = (Paint) color8;
      int index9 = 8;
      Color color9 = Color.decode("0xFFBFBF");
      paintSequence[index9] = (Paint) color9;
      int index10 = 9;
      Color color10 = Color.decode("0xA9A938");
      paintSequence[index10] = (Paint) color10;
      int index11 = 10;
      Color color11 = Color.decode("0x2D4587");
      paintSequence[index11] = (Paint) color11;
      Paint[] outlinePaintSequence = new Paint[2];
      int index12 = 0;
      Color color12 = Color.decode("0xFFFF00");
      outlinePaintSequence[index12] = (Paint) color12;
      int index13 = 1;
      Color color13 = Color.decode("0x0036CC");
      outlinePaintSequence[index13] = (Paint) color13;
      Stroke[] strokeSequence = new Stroke[1];
      int index14 = 0;
      BasicStroke basicStroke1 = new BasicStroke(2f);
      strokeSequence[index14] = (Stroke) basicStroke1;
      Stroke[] outlineStrokeSequence = new Stroke[1];
      int index15 = 0;
      BasicStroke basicStroke2 = new BasicStroke(0.5f);
      outlineStrokeSequence[index15] = (Stroke) basicStroke2;
      Shape[] shapeSequence = DefaultDrawingSupplier.__\u003C\u003EDEFAULT_SHAPE_SEQUENCE;
      DefaultDrawingSupplier defaultDrawingSupplier = new DefaultDrawingSupplier(paintSequence, outlinePaintSequence, strokeSequence, outlineStrokeSequence, shapeSequence);
      standardChartTheme2.drawingSupplier = (DrawingSupplier) defaultDrawingSupplier;
      standardChartTheme1.wallPaint = (Paint) Color.darkGray;
      standardChartTheme1.errorIndicatorPaint = (Paint) Color.lightGray;
      standardChartTheme1.gridBandPaint = (Paint) new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 20);
      standardChartTheme1.gridBandAlternatePaint = (Paint) new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 40);
      return (ChartTheme) standardChartTheme1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 235, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ChartTheme createLegacyTheme()
    {
      return (ChartTheme) new StandardChartTheme\u00241("Legacy");
    }

    public virtual Font getExtraLargeFont()
    {
      return this.extraLargeFont;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExtraLargeFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.extraLargeFont = font;
    }

    public virtual Font getLargeFont()
    {
      return this.largeFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLargeFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.largeFont = font;
    }

    public virtual Font getRegularFont()
    {
      return this.regularFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRegularFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.regularFont = font;
    }

    public virtual Font getSmallFont()
    {
      return this.smallFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSmallFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.smallFont = font;
    }

    public virtual Paint getTitlePaint()
    {
      return this.titlePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTitlePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.titlePaint = paint;
    }

    public virtual Paint getSubtitlePaint()
    {
      return this.subtitlePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 117, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubtitlePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.subtitlePaint = paint;
    }

    public virtual Paint getChartBackgroundPaint()
    {
      return this.chartBackgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 142, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChartBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.chartBackgroundPaint = paint;
    }

    public virtual Paint getLegendBackgroundPaint()
    {
      return this.legendBackgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 167, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.legendBackgroundPaint = paint;
    }

    public virtual Paint getLegendItemPaint()
    {
      return this.legendItemPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 192, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.legendItemPaint = paint;
    }

    public virtual Paint getPlotBackgroundPaint()
    {
      return this.plotBackgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 217, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.plotBackgroundPaint = paint;
    }

    public virtual Paint getPlotOutlinePaint()
    {
      return this.plotOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 242, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.plotOutlinePaint = paint;
    }

    public virtual PieLabelLinkStyle getLabelLinkStyle()
    {
      return this.labelLinkStyle;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 11, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelLinkStyle(PieLabelLinkStyle style)
    {
      if (style == null)
      {
        string str = "Null 'style' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.labelLinkStyle = style;
    }

    public virtual Paint getLabelLinkPaint()
    {
      return this.labelLinkPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 36, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelLinkPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.labelLinkPaint = paint;
    }

    public virtual Paint getDomainGridlinePaint()
    {
      return this.domainGridlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 61, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.domainGridlinePaint = paint;
    }

    public virtual Paint getRangeGridlinePaint()
    {
      return this.rangeGridlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 86, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.rangeGridlinePaint = paint;
    }

    public virtual Paint getBaselinePaint()
    {
      return this.baselinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 111, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaselinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.baselinePaint = paint;
    }

    public virtual Paint getCrosshairPaint()
    {
      return this.crosshairPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 132, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCrosshairPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.crosshairPaint = paint;
    }

    public virtual RectangleInsets getAxisOffset()
    {
      return this.axisOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 157, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisOffset(RectangleInsets offset)
    {
      if (offset == null)
      {
        string str = "Null 'offset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.axisOffset = offset;
    }

    public virtual Paint getAxisLabelPaint()
    {
      return this.axisLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 182, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.axisLabelPaint = paint;
    }

    public virtual Paint getTickLabelPaint()
    {
      return this.tickLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 207, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.tickLabelPaint = paint;
    }

    public virtual Paint getItemLabelPaint()
    {
      return this.itemLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 232, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.itemLabelPaint = paint;
    }

    public virtual bool isShadowVisible()
    {
      return this.shadowVisible;
    }

    public virtual void setShadowVisible(bool visible)
    {
      this.shadowVisible = visible;
    }

    public virtual Paint getShadowPaint()
    {
      return this.shadowPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 23, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.shadowPaint = paint;
    }

    public virtual BarPainter getBarPainter()
    {
      return this.barPainter;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 48, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBarPainter(BarPainter painter)
    {
      if (painter == null)
      {
        string str = "Null 'painter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.barPainter = painter;
    }

    public virtual XYBarPainter getXYBarPainter()
    {
      return this.xyBarPainter;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 73, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXYBarPainter(XYBarPainter painter)
    {
      if (painter == null)
      {
        string str = "Null 'painter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.xyBarPainter = painter;
    }

    public virtual Paint getThermometerPaint()
    {
      return this.thermometerPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 98, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setThermometerPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.thermometerPaint = paint;
    }

    public virtual Paint getWallPaint()
    {
      return this.wallPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 123, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWallPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.wallPaint = paint;
    }

    public virtual Paint getErrorIndicatorPaint()
    {
      return this.errorIndicatorPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 148, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorIndicatorPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.errorIndicatorPaint = paint;
    }

    public virtual Paint getGridBandPaint()
    {
      return this.gridBandPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 173, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGridBandPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.gridBandPaint = paint;
    }

    public virtual Paint getGridBandAlternatePaint()
    {
      return this.gridBandAlternatePaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 198, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGridBandAlternatePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.gridBandAlternatePaint = paint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 240, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawingSupplier(DrawingSupplier supplier)
    {
      if (supplier == null)
      {
        string str = "Null 'supplier' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.drawingSupplier = supplier;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 43, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardChartTheme))
        return false;
      StandardChartTheme standardChartTheme = (StandardChartTheme) obj;
      return String.instancehelper_equals(this.name, (object) standardChartTheme.name) && this.extraLargeFont.equals((object) standardChartTheme.extraLargeFont) && (this.largeFont.equals((object) standardChartTheme.largeFont) && this.regularFont.equals((object) standardChartTheme.regularFont)) && (this.smallFont.equals((object) standardChartTheme.smallFont) && PaintUtilities.equal(this.titlePaint, standardChartTheme.titlePaint) && (PaintUtilities.equal(this.subtitlePaint, standardChartTheme.subtitlePaint) && PaintUtilities.equal(this.chartBackgroundPaint, standardChartTheme.chartBackgroundPaint))) && (PaintUtilities.equal(this.legendBackgroundPaint, standardChartTheme.legendBackgroundPaint) && PaintUtilities.equal(this.legendItemPaint, standardChartTheme.legendItemPaint) && (Object.instancehelper_equals((object) this.drawingSupplier, (object) standardChartTheme.drawingSupplier) && PaintUtilities.equal(this.plotBackgroundPaint, standardChartTheme.plotBackgroundPaint)) && (PaintUtilities.equal(this.plotOutlinePaint, standardChartTheme.plotOutlinePaint) && this.labelLinkStyle.equals((object) standardChartTheme.labelLinkStyle) && (PaintUtilities.equal(this.labelLinkPaint, standardChartTheme.labelLinkPaint) && PaintUtilities.equal(this.domainGridlinePaint, standardChartTheme.domainGridlinePaint)))) && (PaintUtilities.equal(this.rangeGridlinePaint, standardChartTheme.rangeGridlinePaint) && PaintUtilities.equal(this.crosshairPaint, standardChartTheme.crosshairPaint) && (this.axisOffset.equals((object) standardChartTheme.axisOffset) && PaintUtilities.equal(this.axisLabelPaint, standardChartTheme.axisLabelPaint)) && (PaintUtilities.equal(this.tickLabelPaint, standardChartTheme.tickLabelPaint) && PaintUtilities.equal(this.itemLabelPaint, standardChartTheme.itemLabelPaint) && (this.shadowVisible == standardChartTheme.shadowVisible && PaintUtilities.equal(this.shadowPaint, standardChartTheme.shadowPaint))) && (Object.instancehelper_equals((object) this.barPainter, (object) standardChartTheme.barPainter) && Object.instancehelper_equals((object) this.xyBarPainter, (object) standardChartTheme.xyBarPainter) && (PaintUtilities.equal(this.thermometerPaint, standardChartTheme.thermometerPaint) && PaintUtilities.equal(this.wallPaint, standardChartTheme.wallPaint)) && (PaintUtilities.equal(this.errorIndicatorPaint, standardChartTheme.errorIndicatorPaint) && PaintUtilities.equal(this.gridBandPaint, standardChartTheme.gridBandPaint) && PaintUtilities.equal(this.gridBandAlternatePaint, standardChartTheme.gridBandAlternatePaint))));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 1813)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 174, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.titlePaint, obj0);
      SerialUtilities.writePaint(this.subtitlePaint, obj0);
      SerialUtilities.writePaint(this.chartBackgroundPaint, obj0);
      SerialUtilities.writePaint(this.legendBackgroundPaint, obj0);
      SerialUtilities.writePaint(this.legendItemPaint, obj0);
      SerialUtilities.writePaint(this.plotBackgroundPaint, obj0);
      SerialUtilities.writePaint(this.plotOutlinePaint, obj0);
      SerialUtilities.writePaint(this.labelLinkPaint, obj0);
      SerialUtilities.writePaint(this.baselinePaint, obj0);
      SerialUtilities.writePaint(this.domainGridlinePaint, obj0);
      SerialUtilities.writePaint(this.rangeGridlinePaint, obj0);
      SerialUtilities.writePaint(this.crosshairPaint, obj0);
      SerialUtilities.writePaint(this.axisLabelPaint, obj0);
      SerialUtilities.writePaint(this.tickLabelPaint, obj0);
      SerialUtilities.writePaint(this.itemLabelPaint, obj0);
      SerialUtilities.writePaint(this.shadowPaint, obj0);
      SerialUtilities.writePaint(this.thermometerPaint, obj0);
      SerialUtilities.writePaint(this.wallPaint, obj0);
      SerialUtilities.writePaint(this.errorIndicatorPaint, obj0);
      SerialUtilities.writePaint(this.gridBandPaint, obj0);
      SerialUtilities.writePaint(this.gridBandAlternatePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 208, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.titlePaint = SerialUtilities.readPaint(obj0);
      this.subtitlePaint = SerialUtilities.readPaint(obj0);
      this.chartBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.legendBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.legendItemPaint = SerialUtilities.readPaint(obj0);
      this.plotBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.plotOutlinePaint = SerialUtilities.readPaint(obj0);
      this.labelLinkPaint = SerialUtilities.readPaint(obj0);
      this.baselinePaint = SerialUtilities.readPaint(obj0);
      this.domainGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeGridlinePaint = SerialUtilities.readPaint(obj0);
      this.crosshairPaint = SerialUtilities.readPaint(obj0);
      this.axisLabelPaint = SerialUtilities.readPaint(obj0);
      this.tickLabelPaint = SerialUtilities.readPaint(obj0);
      this.itemLabelPaint = SerialUtilities.readPaint(obj0);
      this.shadowPaint = SerialUtilities.readPaint(obj0);
      this.thermometerPaint = SerialUtilities.readPaint(obj0);
      this.wallPaint = SerialUtilities.readPaint(obj0);
      this.errorIndicatorPaint = SerialUtilities.readPaint(obj0);
      this.gridBandPaint = SerialUtilities.readPaint(obj0);
      this.gridBandAlternatePaint = SerialUtilities.readPaint(obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
