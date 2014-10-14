// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.ContourPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.beans;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.annotations;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.contour;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.plot.ContourValuePlot", "org.jfree.chart.plot.ValueAxisPlot", "java.beans.PropertyChangeListener", "java.io.Serializable", "java.lang.Cloneable"})]
  [Obsolete]
  [Serializable]
  public class ContourPlot : Plot, ContourValuePlot, ValueAxisPlot, PropertyChangeListener, EventListener, Serializable.__Interface, Cloneable.__Interface
  {
    private const long serialVersionUID = 7861072556590502247L;
    internal new static RectangleInsets __\u003C\u003EDEFAULT_INSETS;
    private ValueAxis domainAxis;
    private ValueAxis rangeAxis;
    private ContourDataset dataset;
    private ColorBar colorBar;
    private RectangleEdge colorBarLocation;
    private bool domainCrosshairVisible;
    private double domainCrosshairValue;
    [NonSerialized]
    private Stroke domainCrosshairStroke;
    [NonSerialized]
    private Paint domainCrosshairPaint;
    private bool domainCrosshairLockedOnData;
    private bool rangeCrosshairVisible;
    private double rangeCrosshairValue;
    [NonSerialized]
    private Stroke rangeCrosshairStroke;
    [NonSerialized]
    private Paint rangeCrosshairPaint;
    private bool rangeCrosshairLockedOnData;
    private double dataAreaRatio;
    private List domainMarkers;
    private List rangeMarkers;
    private List annotations;
    private ContourToolTipGenerator toolTipGenerator;
    private XYURLGenerator urlGenerator;
    private bool renderAsPoints;
    private double ptSizePct;
    [NonSerialized]
    private ClipPath clipPath;
    [NonSerialized]
    private Paint missingPaint;
    protected internal static ResourceBundle localizationResources;

    [Modifiers]
    protected internal new static RectangleInsets DEFAULT_INSETS
    {
      [HideFromJava] get
      {
        return ContourPlot.__\u003C\u003EDEFAULT_INSETS;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 69, (byte) 255, (byte) 15, (byte) 160, (byte) 99})]
    static ContourPlot()
    {
      Plot.__\u003Cclinit\u003E();
      ContourPlot.__\u003C\u003EDEFAULT_INSETS = new RectangleInsets(2.0, 2.0, 100.0, 10.0);
      ContourPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 232, (byte) 159, (byte) 146, (byte) 231, (byte) 85, (byte) 231, (byte) 82, (byte) 231, (byte) 75, (byte) 236, (byte) 85, (byte) 231, (byte) 70, (byte) 176, (byte) 167, (byte) 231, (byte) 93, (byte) 103, (byte) 99, (byte) 167, (byte) 103, (byte) 99, (byte) 103, (byte) 167, (byte) 103, (byte) 99, (byte) 103, (byte) 167, (byte) 104, (byte) 100, (byte) 109, (byte) 109, (byte) 136, (byte) 139, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContourPlot(ContourDataset dataset, ValueAxis domainAxis, ValueAxis rangeAxis, ColorBar colorBar)
    {
      ContourPlot contourPlot = this;
      this.colorBar = (ColorBar) null;
      this.domainCrosshairLockedOnData = true;
      this.rangeCrosshairLockedOnData = true;
      this.dataAreaRatio = 0.0;
      this.renderAsPoints = false;
      this.ptSizePct = 0.05;
      this.clipPath = (ClipPath) null;
      this.missingPaint = (Paint) null;
      this.dataset = dataset;
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.domainAxis = domainAxis;
      if (domainAxis != null)
      {
        domainAxis.setPlot((Plot) this);
        domainAxis.addChangeListener((AxisChangeListener) this);
      }
      this.rangeAxis = rangeAxis;
      if (rangeAxis != null)
      {
        rangeAxis.setPlot((Plot) this);
        rangeAxis.addChangeListener((AxisChangeListener) this);
      }
      this.colorBar = colorBar;
      if (colorBar != null)
      {
        colorBar.getAxis().setPlot((Plot) this);
        colorBar.getAxis().addChangeListener((AxisChangeListener) this);
        colorBar.configure(this);
      }
      this.colorBarLocation = RectangleEdge.__\u003C\u003ELEFT;
      this.toolTipGenerator = (ContourToolTipGenerator) new StandardContourToolTipGenerator();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContourPlot()
      : this((ContourDataset) null, (ValueAxis) null, (ValueAxis) null, (ColorBar) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ContourPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ContourPlot obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ContourPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual ContourDataset getDataset()
    {
      return this.dataset;
    }

    public virtual ColorBar getColorBar()
    {
      return this.colorBar;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 143, (byte) 104, (byte) 139, (byte) 104, (byte) 139, (byte) 104, (byte) 140, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void datasetChanged(DatasetChangeEvent @event)
    {
      if (this.domainAxis != null)
        this.domainAxis.configure();
      if (this.rangeAxis != null)
        this.rangeAxis.configure();
      if (this.colorBar != null)
        this.colorBar.configure(this);
      base.datasetChanged(@event);
    }

    public virtual bool isCompatibleDomainAxis(ValueAxis axis)
    {
      return true;
    }

    public virtual double getDataAreaRatio()
    {
      return this.dataAreaRatio;
    }

    public virtual ValueAxis getDomainAxis()
    {
      return this.domainAxis;
    }

    public virtual ValueAxis getRangeAxis()
    {
      return this.rangeAxis;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 96, (byte) 103, (byte) 134, (byte) 135, (byte) 104, (byte) 154, (byte) 109, (byte) 199, (byte) 104, (byte) 220, (byte) 250, (byte) 69, (byte) 110, (byte) 104, (byte) 250, (byte) 71, (byte) 110, (byte) 104, (byte) 250, (byte) 70, (byte) 98, (byte) 104, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void render(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, CrosshairState crosshairState)
    {
      ContourDataset dataset = this.getDataset();
      if (dataset != null)
      {
        ColorBar colorBar = this.getColorBar();
        if (this.clipPath != null)
        {
          GeneralPath generalPath = this.getClipPath().draw(g2, dataArea, this.domainAxis, this.rangeAxis);
          if (this.clipPath.isClip())
            g2.clip((Shape) generalPath);
        }
        if (this.renderAsPoints)
          this.pointRenderer(g2, dataArea, info, this, this.domainAxis, this.rangeAxis, colorBar, dataset, crosshairState);
        else
          this.contourRenderer(g2, dataArea, info, this, this.domainAxis, this.rangeAxis, colorBar, dataset, crosshairState);
        this.setDomainCrosshairValue(crosshairState.getCrosshairX(), false);
        if (this.isDomainCrosshairVisible())
          this.drawVerticalLine(g2, dataArea, this.getDomainCrosshairValue(), this.getDomainCrosshairStroke(), this.getDomainCrosshairPaint());
        this.setRangeCrosshairValue(crosshairState.getCrosshairY(), false);
        if (!this.isRangeCrosshairVisible())
          return;
        this.drawHorizontalLine(g2, dataArea, this.getRangeCrosshairValue(), this.getRangeCrosshairStroke(), this.getRangeCrosshairPaint());
      }
      else
      {
        if (this.clipPath == null)
          return;
        this.getClipPath().draw(g2, dataArea, this.domainAxis, this.rangeAxis);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 207, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 144, (byte) 151, (byte) 105, (byte) 105, (byte) 115, (byte) 115, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainMarker(Graphics2D g2, ContourPlot plot, ValueAxis domainAxis, Marker marker, Rectangle2D dataArea)
    {
      if (!(marker is ValueMarker))
        return;
      double d = ((ValueMarker) marker).getValue();
      if (!domainAxis.getRange().contains(d))
        return;
      double num = domainAxis.valueToJava2D(d, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
      Line2D.Double @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      Paint outlinePaint = marker.getOutlinePaint();
      Stroke outlineStroke = marker.getOutlineStroke();
      g2.setPaint(outlinePaint == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT : outlinePaint);
      g2.setStroke(outlineStroke == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE : outlineStroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 243, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 144, (byte) 151, (byte) 105, (byte) 105, (byte) 115, (byte) 115, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeMarker(Graphics2D g2, ContourPlot plot, ValueAxis rangeAxis, Marker marker, Rectangle2D dataArea)
    {
      if (!(marker is ValueMarker))
        return;
      double d = ((ValueMarker) marker).getValue();
      if (!rangeAxis.getRange().contains(d))
        return;
      double num = rangeAxis.valueToJava2D(d, dataArea, RectangleEdge.__\u003C\u003ELEFT);
      Line2D.Double @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      Paint outlinePaint = marker.getOutlinePaint();
      Stroke outlineStroke = marker.getOutlineStroke();
      g2.setPaint(outlinePaint == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT : outlinePaint);
      g2.setStroke(outlineStroke == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE : outlineStroke);
      g2.draw((Shape) @double);
    }

    public virtual ClipPath getClipPath()
    {
      return this.clipPath;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 121, (byte) 98, (byte) 98, (byte) 99, (byte) 236, (byte) 69, (byte) 198, (byte) 108, (byte) 240, (byte) 69, (byte) 104, (byte) 105, (byte) 137, (byte) 105, (byte) 138, (byte) 106, (byte) 111, (byte) 16, (byte) 232, (byte) 69, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 112, (byte) 141, (byte) 159, (byte) 3, (byte) 159, (byte) 3, (byte) 100, (byte) 132, (byte) 142, (byte) 103, (byte) 119, (byte) 137, (byte) 104, (byte) 108, (byte) 199, (byte) 163, (byte) 99, (byte) 99, (byte) 104, (byte) 145, (byte) 226, (byte) 70, (byte) 150, (byte) 105, (byte) 200, (byte) 105, (byte) 137, (byte) 252, (byte) 69, (byte) 203, (byte) 137, (byte) 233, (byte) 8, (byte) 235, (byte) 126, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void pointRenderer(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, ContourPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, ColorBar colorBar, ContourDataset data, CrosshairState crosshairState)
    {
      EntityCollection entityCollection = (EntityCollection) null;
      if (info != null)
        entityCollection = info.getOwner().getEntityCollection();
      Ellipse2D.Double double1 = new Ellipse2D.Double();
      object renderingHint = g2.getRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING);
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_OFF);
      Number[] xvalues = data.getXValues();
      Number[] yvalues = data.getYValues();
      Number[] zvalues = data.getZValues();
      double[] numArray1 = new double[xvalues.Length];
      double[] numArray2 = new double[yvalues.Length];
      for (int index = 0; index < numArray1.Length; ++index)
      {
        numArray1[index] = xvalues[index].doubleValue();
        numArray2[index] = yvalues[index].doubleValue();
      }
      double num1 = ((RectangularShape) dataArea).getWidth() * this.ptSizePct;
      for (int index = 0; index < numArray1.Length; ++index)
      {
        double num2 = domainAxis.valueToJava2D(numArray1[index], dataArea, RectangleEdge.__\u003C\u003EBOTTOM) - 0.5 * num1;
        double num3 = rangeAxis.valueToJava2D(numArray2[index], dataArea, RectangleEdge.__\u003C\u003ELEFT) - 0.5 * num1;
        double num4 = num1;
        double num5 = num1;
        ((RectangularShape) double1).setFrame(num2, num3, num4, num5);
        if (zvalues[index] != null)
        {
          g2.setPaint(colorBar.getPaint(zvalues[index].doubleValue()));
          g2.fill((Shape) double1);
        }
        else if (this.missingPaint != null)
        {
          g2.setPaint(this.missingPaint);
          g2.fill((Shape) double1);
        }
        Ellipse2D.Double double2 = double1;
        if (entityCollection != null)
        {
          string toolTipText = (string) null;
          if (this.getToolTipGenerator() != null)
            toolTipText = this.toolTipGenerator.generateToolTip(data, index);
          ContourEntity contourEntity = new ContourEntity((Shape) ((RectangularShape) double2).clone(), toolTipText, (string) null);
          contourEntity.setIndex(index);
          entityCollection.add((ChartEntity) contourEntity);
        }
        if (plot.isDomainCrosshairLockedOnData())
        {
          if (plot.isRangeCrosshairLockedOnData())
            crosshairState.updateCrosshairPoint(numArray1[index], numArray2[index], num2, num3, PlotOrientation.__\u003C\u003EVERTICAL);
          else
            crosshairState.updateCrosshairX(num2);
        }
        else if (plot.isRangeCrosshairLockedOnData())
          crosshairState.updateCrosshairY(num3);
      }
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, renderingHint);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 168, (byte) 98, (byte) 98, (byte) 99, (byte) 172, (byte) 98, (byte) 166, (byte) 108, (byte) 208, (byte) 104, (byte) 105, (byte) 137, (byte) 105, (byte) 138, (byte) 106, (byte) 111, (byte) 16, (byte) 232, (byte) 69, (byte) 105, (byte) 105, (byte) 110, (byte) 99, (byte) 105, (byte) 142, (byte) 103, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 102, (byte) 106, (byte) 109, (byte) 103, (byte) 108, (byte) 103, (byte) 149, (byte) 100, (byte) 154, (byte) 119, (byte) 156, (byte) 105, (byte) 149, (byte) 154, (byte) 100, (byte) 119, (byte) 185, (byte) 149, (byte) 154, (byte) 100, (byte) 183, (byte) 100, (byte) 170, (byte) 168, (byte) 136, (byte) 149, (byte) 100, (byte) 105, (byte) 133, (byte) 151, (byte) 119, (byte) 156, (byte) 191, (byte) 3, (byte) 149, (byte) 151, (byte) 100, (byte) 119, (byte) 185, (byte) 149, (byte) 151, (byte) 100, (byte) 151, (byte) 100, (byte) 170, (byte) 168, (byte) 136, (byte) 110, (byte) 103, (byte) 119, (byte) 137, (byte) 104, (byte) 108, (byte) 167, (byte) 163, (byte) 99, (byte) 103, (byte) 104, (byte) 209, (byte) 226, (byte) 70, (byte) 150, (byte) 105, (byte) 232, (byte) 69, (byte) 105, (byte) 137, (byte) 252, (byte) 69, (byte) 203, (byte) 137, (byte) 233, (byte) 159, (byte) 130, (byte) 235, (byte) 160, (byte) 131, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void contourRenderer(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, ContourPlot plot, ValueAxis horizontalAxis, ValueAxis verticalAxis, ColorBar colorBar, ContourDataset data, CrosshairState crosshairState)
    {
      EntityCollection entityCollection = (EntityCollection) null;
      if (info != null)
        entityCollection = info.getOwner().getEntityCollection();
      Rectangle2D.Double double1 = new Rectangle2D.Double();
      object renderingHint = g2.getRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING);
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_OFF);
      Number[] xvalues = data.getXValues();
      Number[] yvalues = data.getYValues();
      Number[] zvalues = data.getZValues();
      double[] numArray1 = new double[xvalues.Length];
      double[] numArray2 = new double[yvalues.Length];
      for (int index = 0; index < numArray1.Length; ++index)
      {
        numArray1[index] = xvalues[index].doubleValue();
        numArray2[index] = yvalues[index].doubleValue();
      }
      int[] numArray3 = data.indexX();
      int[] xindices = data.getXIndices();
      int num1 = verticalAxis.isInverted() ? 1 : 0;
      int num2 = 0;
      if (horizontalAxis is NumberAxis)
        num2 = horizontalAxis.isInverted() ? 1 : 0;
      double num3 = 0.0;
      double num4 = 0.0;
      double num5 = 0.0;
      double num6 = 0.0;
      int num7 = numArray3[numArray3.Length - 1];
      for (int index1 = 0; index1 < numArray1.Length; ++index1)
      {
        int index2 = numArray3[index1];
        double num8;
        double num9;
        if (xindices[index2] == index1)
        {
          double num10;
          double num11;
          if (index2 == 0)
          {
            num10 = horizontalAxis.valueToJava2D(numArray1[index1], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            double num12 = num10;
            double num13 = horizontalAxis.valueToJava2D(numArray1[xindices[index2 + 1]], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            num11 = Math.abs(0.5 * (num10 - num12));
            num4 = Math.abs(0.5 * (num10 - num13));
          }
          else if (index2 == num7)
          {
            num10 = horizontalAxis.valueToJava2D(numArray1[index1], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            double num12 = horizontalAxis.valueToJava2D(numArray1[xindices[index2 - 1]], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            double num13 = num10;
            num11 = Math.abs(0.5 * (num10 - num12));
            num4 = Math.abs(0.5 * (num10 - num13));
          }
          else
          {
            num10 = horizontalAxis.valueToJava2D(numArray1[index1], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            double num12 = horizontalAxis.valueToJava2D(numArray1[xindices[index2 + 1]], dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
            num11 = num4;
            num4 = Math.abs(0.5 * (num10 - num12));
          }
          num3 = num2 == 0 ? num10 - num11 : num10 - num4;
          num5 = num11 + num4;
          num8 = verticalAxis.valueToJava2D(numArray2[index1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
          double num14 = num8;
          if (index1 + 1 != numArray2.Length)
          {
            double num12 = verticalAxis.valueToJava2D(numArray2[index1 + 1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
            num9 = Math.abs(0.5 * (num8 - num14));
            num6 = Math.abs(0.5 * (num8 - num12));
          }
          else
            continue;
        }
        else if (index2 < xindices.Length - 1 && xindices[index2 + 1] - 1 == index1 || index1 == numArray1.Length - 1)
        {
          num8 = verticalAxis.valueToJava2D(numArray2[index1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
          double num10 = verticalAxis.valueToJava2D(numArray2[index1 - 1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
          double num11 = num8;
          num9 = Math.abs(0.5 * (num8 - num10));
          num6 = Math.abs(0.5 * (num8 - num11));
        }
        else
        {
          num8 = verticalAxis.valueToJava2D(numArray2[index1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
          double num10 = verticalAxis.valueToJava2D(numArray2[index1 + 1], dataArea, RectangleEdge.__\u003C\u003ELEFT);
          num9 = num6;
          num6 = Math.abs(0.5 * (num8 - num10));
        }
        double num15 = num1 == 0 ? num8 - num6 : num8 - num9;
        double num16 = num9 + num6;
        double1.setRect(num3, num15, num5, num16);
        if (zvalues[index1] != null)
        {
          g2.setPaint(colorBar.getPaint(zvalues[index1].doubleValue()));
          g2.fill((Shape) double1);
        }
        else if (this.missingPaint != null)
        {
          g2.setPaint(this.missingPaint);
          g2.fill((Shape) double1);
        }
        Rectangle2D.Double double2 = double1;
        if (entityCollection != null)
        {
          string toolTipText = "";
          if (this.getToolTipGenerator() != null)
            toolTipText = this.toolTipGenerator.generateToolTip(data, index1);
          ContourEntity contourEntity = new ContourEntity((Shape) ((RectangularShape) double2).clone(), toolTipText, (string) null);
          contourEntity.setIndex(index1);
          entityCollection.add((ChartEntity) contourEntity);
        }
        if (plot.isDomainCrosshairLockedOnData())
        {
          if (plot.isRangeCrosshairLockedOnData())
            crosshairState.updateCrosshairPoint(numArray1[index1], numArray2[index1], num3, num15, PlotOrientation.__\u003C\u003EVERTICAL);
          else
            crosshairState.updateCrosshairX(num3);
        }
        else if (plot.isRangeCrosshairLockedOnData())
          crosshairState.updateCrosshairY(num15);
      }
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, renderingHint);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 53, (byte) 66, (byte) 105, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairValue(double value, bool notify)
    {
      int num = notify ? 1 : 0;
      this.domainCrosshairValue = value;
      if (!this.isDomainCrosshairVisible() || num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool isDomainCrosshairVisible()
    {
      return this.domainCrosshairVisible;
    }

    public virtual double getDomainCrosshairValue()
    {
      return this.domainCrosshairValue;
    }

    public virtual Stroke getDomainCrosshairStroke()
    {
      return this.domainCrosshairStroke;
    }

    public virtual Paint getDomainCrosshairPaint()
    {
      return this.domainCrosshairPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 236, (byte) 149, (byte) 148, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVerticalLine(Graphics2D g2, Rectangle2D dataArea, double value, Stroke stroke, Paint paint)
    {
      double num = this.getDomainAxis().valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
      Line2D.Double @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 23, (byte) 130, (byte) 105, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairValue(double value, bool notify)
    {
      int num = notify ? 1 : 0;
      this.rangeCrosshairValue = value;
      if (!this.isRangeCrosshairVisible() || num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool isRangeCrosshairVisible()
    {
      return this.rangeCrosshairVisible;
    }

    public virtual double getRangeCrosshairValue()
    {
      return this.rangeCrosshairValue;
    }

    public virtual Stroke getRangeCrosshairStroke()
    {
      return this.rangeCrosshairStroke;
    }

    public virtual Paint getRangeCrosshairPaint()
    {
      return this.rangeCrosshairPaint;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 3, (byte) 149, (byte) 148, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontalLine(Graphics2D g2, Rectangle2D dataArea, double value, Stroke stroke, Paint paint)
    {
      double num = this.getRangeAxis().valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003ELEFT);
      Line2D.Double @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    public virtual ContourToolTipGenerator getToolTipGenerator()
    {
      return this.toolTipGenerator;
    }

    public virtual bool isDomainCrosshairLockedOnData()
    {
      return this.domainCrosshairLockedOnData;
    }

    public virtual bool isRangeCrosshairLockedOnData()
    {
      return this.rangeCrosshairLockedOnData;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 83, (byte) 98, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range visibleRange(ContourDataset data, Range x, Range y)
    {
      return data.getZValueRange(x, y);
    }

    public virtual RectangleEdge getColorBarLocation()
    {
      return this.colorBarLocation;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColorBarLocation(RectangleEdge edge)
    {
      this.colorBarLocation = edge;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 207, (byte) 103, (byte) 99, (byte) 199, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(ContourDataset dataset)
    {
      ContourDataset contourDataset = this.dataset;
      if (contourDataset != null)
        contourDataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 137, (byte) 99, (byte) 103, (byte) 199, (byte) 104, (byte) 172, (byte) 103, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(ValueAxis axis)
    {
      if (!this.isCompatibleDomainAxis(axis))
        return;
      if (axis != null)
      {
        axis.setPlot((Plot) this);
        axis.addChangeListener((AxisChangeListener) this);
      }
      if (this.domainAxis != null)
        this.domainAxis.removeChangeListener((AxisChangeListener) this);
      this.domainAxis = axis;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 32, (byte) 99, (byte) 103, (byte) 199, (byte) 104, (byte) 172, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(ValueAxis axis)
    {
      if (axis != null)
      {
        axis.setPlot((Plot) this);
        axis.addChangeListener((AxisChangeListener) this);
      }
      if (this.rangeAxis != null)
        this.rangeAxis.removeChangeListener((AxisChangeListener) this);
      this.rangeAxis = axis;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColorBarAxis(ColorBar axis)
    {
      this.colorBar = axis;
      this.fireChangeEvent();
    }

    public virtual void setDataAreaRatio(double ratio)
    {
      this.dataAreaRatio = ratio;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 87, (byte) 104, (byte) 139, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(Marker marker)
    {
      if (this.domainMarkers == null)
        this.domainMarkers = (List) new ArrayList();
      this.domainMarkers.add((object) marker);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 99, (byte) 104, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainMarkers()
    {
      if (this.domainMarkers == null)
        return;
      this.domainMarkers.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 115, (byte) 104, (byte) 139, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(Marker marker)
    {
      if (this.rangeMarkers == null)
        this.rangeMarkers = (List) new ArrayList();
      this.rangeMarkers.add((object) marker);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 127, (byte) 104, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearRangeMarkers()
    {
      if (this.rangeMarkers == null)
        return;
      this.rangeMarkers.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 140, (byte) 104, (byte) 139, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(XYAnnotation annotation)
    {
      if (this.annotations == null)
        this.annotations = (List) new ArrayList();
      this.annotations.add((object) annotation);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 152, (byte) 104, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearAnnotations()
    {
      if (this.annotations == null)
        return;
      this.annotations.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 193, (byte) 117, (byte) 117, (byte) 102, (byte) 193, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 134, (byte) 149, (byte) 181, (byte) 138, (byte) 103, (byte) 154, (byte) 139, (byte) 139, (byte) 176, (byte) 112, (byte) 105, (byte) 110, (byte) 106, (byte) 138, (byte) 105, (byte) 105, (byte) 173, (byte) 205, (byte) 111, (byte) 115, (byte) 115, (byte) 136, (byte) 136, (byte) 105, (byte) 170, (byte) 200, (byte) 223, (byte) 25, (byte) 100, (byte) 169, (byte) 103, (byte) 176, (byte) 137, (byte) 106, (byte) 104, (byte) 218, (byte) 104, (byte) 106, (byte) 218, (byte) 104, (byte) 103, (byte) 188, (byte) 104, (byte) 136, (byte) 104, (byte) 146, (byte) 141, (byte) 104, (byte) 109, (byte) 105, (byte) 110, (byte) 114, (byte) 162, (byte) 104, (byte) 109, (byte) 105, (byte) 110, (byte) 114, (byte) 226, (byte) 84, (byte) 104, (byte) 104, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (((RectangularShape) area).getWidth() <= 10.0 || ((RectangularShape) area).getHeight() <= 10.0)
        return;
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      AxisSpace space1 = new AxisSpace();
      AxisSpace space2 = this.domainAxis.reserveSpace(g2, (Plot) this, area, RectangleEdge.__\u003C\u003EBOTTOM, space1);
      AxisSpace axisSpace1 = this.rangeAxis.reserveSpace(g2, (Plot) this, area, RectangleEdge.__\u003C\u003ELEFT, space2);
      Rectangle2D dataArea = axisSpace1.shrink(area, (Rectangle2D) null);
      AxisSpace space3 = new AxisSpace();
      AxisSpace axisSpace2 = this.colorBar.reserveSpace(g2, (Plot) this, area, dataArea, this.colorBarLocation, space3);
      Rectangle2D rectangle2D1 = axisSpace2.shrink(area, (Rectangle2D) null);
      Rectangle2D rectangle2D2 = axisSpace1.shrink(rectangle2D1, (Rectangle2D) null);
      Rectangle2D reservedArea = axisSpace2.reserved(area, this.colorBarLocation);
      if (this.getDataAreaRatio() != 0.0)
      {
        double dataAreaRatio = this.getDataAreaRatio();
        Rectangle2D rectangle2D3 = (Rectangle2D) ((RectangularShape) rectangle2D2).clone();
        double num1 = ((RectangularShape) rectangle2D3).getHeight();
        double num2 = ((RectangularShape) rectangle2D3).getWidth();
        if (dataAreaRatio > 0.0)
        {
          if (num2 * dataAreaRatio <= num1)
            num1 = dataAreaRatio * num2;
          else
            num2 = num1 / dataAreaRatio;
        }
        else
        {
          double num3 = this.getRangeAxis().getRange().getLength() / this.getDomainAxis().getRange().getLength() * (dataAreaRatio * -1.0);
          if (num2 * num3 <= num1)
            num1 = num3 * num2;
          else
            num2 = num1 / num3;
        }
        rectangle2D2.setRect(((RectangularShape) rectangle2D3).getX() + ((RectangularShape) rectangle2D3).getWidth() / 2.0 - num2 / 2.0, ((RectangularShape) rectangle2D3).getY(), num2, num1);
      }
      if (info != null)
        info.setDataArea(rectangle2D2);
      CrosshairState crosshairState = new CrosshairState();
      crosshairState.setCrosshairDistance(double.PositiveInfinity);
      this.drawBackground(g2, rectangle2D2);
      double maxY = ((RectangularShape) rectangle2D2).getMaxY();
      if (this.domainAxis != null)
        this.domainAxis.draw(g2, maxY, rectangle2D1, rectangle2D2, RectangleEdge.__\u003C\u003EBOTTOM, info);
      if (this.rangeAxis != null)
      {
        double minX = ((RectangularShape) rectangle2D2).getMinX();
        this.rangeAxis.draw(g2, minX, rectangle2D1, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT, info);
      }
      if (this.colorBar != null)
      {
        double cursor = 0.0;
        this.colorBar.draw(g2, cursor, rectangle2D1, rectangle2D2, reservedArea, this.colorBarLocation);
      }
      Shape clip = ((Graphics) g2).getClip();
      Composite composite = g2.getComposite();
      g2.clip((Shape) rectangle2D2);
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      this.render(g2, rectangle2D2, info, crosshairState);
      if (this.domainMarkers != null)
      {
        Iterator iterator = this.domainMarkers.iterator();
        while (iterator.hasNext())
        {
          Marker marker = (Marker) iterator.next();
          this.drawDomainMarker(g2, this, this.getDomainAxis(), marker, rectangle2D2);
        }
      }
      if (this.rangeMarkers != null)
      {
        Iterator iterator = this.rangeMarkers.iterator();
        while (iterator.hasNext())
        {
          Marker marker = (Marker) iterator.next();
          this.drawRangeMarker(g2, this, this.getRangeAxis(), marker, rectangle2D2);
        }
      }
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      this.drawOutline(g2, rectangle2D2);
    }

    public override void handleClick(int x, int y, PlotRenderingInfo info)
    {
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 52, (byte) 235, (byte) 74, (byte) 108, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoom(double percent)
    {
      if (percent > 0.0)
        return;
      this.getRangeAxis().setAutoRange(true);
      this.getDomainAxis().setAutoRange(true);
    }

    [LineNumberTable((ushort) 1212)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return ContourPlot.localizationResources.getString("Contour_Plot");
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 86, (byte) 104, (byte) 162, (byte) 130, (byte) 105, (byte) 142, (byte) 105, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDataRange(ValueAxis axis)
    {
      if (this.dataset == null)
        return (Range) null;
      Range range = (Range) null;
      if (axis == this.getDomainAxis())
        range = DatasetUtilities.findDomainBounds((XYDataset) this.dataset);
      else if (axis == this.getRangeAxis())
        range = DatasetUtilities.findRangeBounds((XYDataset) this.dataset);
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 110, (byte) 130, (byte) 135, (byte) 99, (byte) 108, (byte) 108, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getContourDataRange()
    {
      Range range1 = (Range) null;
      ContourDataset dataset = this.getDataset();
      if (dataset != null)
      {
        Range range2 = this.getDomainAxis().getRange();
        Range range3 = this.getRangeAxis().getRange();
        range1 = this.visibleRange(dataset, range2, range3);
      }
      return range1;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 131, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void propertyChange(PropertyChangeEvent @event)
    {
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 69, (byte) 130, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.domainCrosshairVisible ? 1 : 0) == num)
        return;
      this.domainCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 63, (byte) 130, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairLockedOnData(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.domainCrosshairLockedOnData ? 1 : 0) == num)
        return;
      this.domainCrosshairLockedOnData = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 228, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairValue(double value)
    {
      this.setDomainCrosshairValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 8, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairStroke(Stroke stroke)
    {
      this.domainCrosshairStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 28, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairPaint(Paint paint)
    {
      this.domainCrosshairPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 38, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairVisible ? 1 : 0) == num)
        return;
      this.rangeCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 32, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairLockedOnData(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairLockedOnData ? 1 : 0) == num)
        return;
      this.rangeCrosshairLockedOnData = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 94, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairValue(double value)
    {
      this.setRangeCrosshairValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairStroke(Stroke stroke)
    {
      this.rangeCrosshairStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 150, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairPaint(Paint paint)
    {
      this.rangeCrosshairPaint = paint;
      this.fireChangeEvent();
    }

    public virtual void setToolTipGenerator(ContourToolTipGenerator generator)
    {
      this.toolTipGenerator = generator;
    }

    public virtual XYURLGenerator getURLGenerator()
    {
      return this.urlGenerator;
    }

    public virtual void setURLGenerator(XYURLGenerator urlGenerator)
    {
      this.urlGenerator = urlGenerator;
    }

    public virtual void setClipPath(ClipPath clipPath)
    {
      this.clipPath = clipPath;
    }

    public virtual double getPtSizePct()
    {
      return this.ptSizePct;
    }

    public virtual bool isRenderAsPoints()
    {
      return this.renderAsPoints;
    }

    public virtual void setPtSizePct(double ptSizePct)
    {
      this.ptSizePct = ptSizePct;
    }

    public virtual void setRenderAsPoints(bool renderAsPoints)
    {
      this.renderAsPoints = renderAsPoints;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 62, (byte) 103, (byte) 124, (byte) 103, (byte) 114, (byte) 203, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void axisChanged(AxisChangeEvent @event)
    {
      object source = @event.getSource();
      if (Object.instancehelper_equals(source, (object) this.rangeAxis) || Object.instancehelper_equals(source, (object) this.domainAxis))
      {
        ColorBar colorBar = this.colorBar;
        if (this.colorBar.getAxis().isAutoRange())
          colorBar.getAxis().configure();
      }
      base.axisChanged(@event);
    }

    public virtual Paint getMissingPaint()
    {
      return this.missingPaint;
    }

    public virtual void setMissingPaint(Paint paint)
    {
      this.missingPaint = paint;
    }

    public virtual void zoomDomainAxes(double x, double y, double factor)
    {
    }

    public virtual void zoomDomainAxes(double x, double y, double lowerPercent, double upperPercent)
    {
    }

    public virtual void zoomRangeAxes(double x, double y, double factor)
    {
    }

    public virtual void zoomRangeAxes(double x, double y, double lowerPercent, double upperPercent)
    {
    }

    public virtual bool isDomainZoomable()
    {
      return false;
    }

    public virtual bool isRangeZoomable()
    {
      return false;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 177, (byte) 140, (byte) 104, (byte) 118, (byte) 108, (byte) 140, (byte) 104, (byte) 118, (byte) 108, (byte) 172, (byte) 104, (byte) 172, (byte) 104, (byte) 182, (byte) 150, (byte) 150, (byte) 150, (byte) 104, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      ContourPlot contourPlot = (ContourPlot) base.clone();
      if (this.domainAxis != null)
      {
        contourPlot.domainAxis = (ValueAxis) this.domainAxis.clone();
        contourPlot.domainAxis.setPlot((Plot) contourPlot);
        contourPlot.domainAxis.addChangeListener((AxisChangeListener) contourPlot);
      }
      if (this.rangeAxis != null)
      {
        contourPlot.rangeAxis = (ValueAxis) this.rangeAxis.clone();
        contourPlot.rangeAxis.setPlot((Plot) contourPlot);
        contourPlot.rangeAxis.addChangeListener((AxisChangeListener) contourPlot);
      }
      if (contourPlot.dataset != null)
        contourPlot.dataset.addChangeListener((DatasetChangeListener) contourPlot);
      if (this.colorBar != null)
        contourPlot.colorBar = (ColorBar) this.colorBar.clone();
      contourPlot.domainMarkers = (List) ObjectUtilities.deepClone((Collection) this.domainMarkers);
      contourPlot.rangeMarkers = (List) ObjectUtilities.deepClone((Collection) this.rangeMarkers);
      contourPlot.annotations = (List) ObjectUtilities.deepClone((Collection) this.annotations);
      if (this.clipPath != null)
        contourPlot.clipPath = (ClipPath) this.clipPath.clone();
      return (object) contourPlot;
    }
  }
}
