// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.XYPlot
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
using org.jfree.chart.annotations;
using org.jfree.chart.axis;
using org.jfree.chart.renderer;
using org.jfree.chart.renderer.xy;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.plot.ValueAxisPlot", "org.jfree.chart.plot.Pannable", "org.jfree.chart.plot.Zoomable", "org.jfree.chart.event.RendererChangeListener", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYPlot : Plot, ValueAxisPlot, Pannable, Zoomable, RendererChangeListener, EventListener, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 7044148245716569264L;
    internal static Stroke __\u003C\u003EDEFAULT_GRIDLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    public const bool DEFAULT_CROSSHAIR_VISIBLE = false;
    internal static Stroke __\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
    protected internal static ResourceBundle localizationResources;
    private PlotOrientation orientation;
    private RectangleInsets axisOffset;
    private ObjectList domainAxes;
    private ObjectList domainAxisLocations;
    private ObjectList rangeAxes;
    private ObjectList rangeAxisLocations;
    private ObjectList datasets;
    private ObjectList renderers;
    private Map datasetToDomainAxesMap;
    private Map datasetToRangeAxesMap;
    [NonSerialized]
    private Point2D quadrantOrigin;
    [NonSerialized]
    private Paint[] quadrantPaint;
    private bool domainGridlinesVisible;
    [NonSerialized]
    private Stroke domainGridlineStroke;
    [NonSerialized]
    private Paint domainGridlinePaint;
    private bool rangeGridlinesVisible;
    [NonSerialized]
    private Stroke rangeGridlineStroke;
    [NonSerialized]
    private Paint rangeGridlinePaint;
    private bool domainMinorGridlinesVisible;
    [NonSerialized]
    private Stroke domainMinorGridlineStroke;
    [NonSerialized]
    private Paint domainMinorGridlinePaint;
    private bool rangeMinorGridlinesVisible;
    [NonSerialized]
    private Stroke rangeMinorGridlineStroke;
    [NonSerialized]
    private Paint rangeMinorGridlinePaint;
    private bool domainZeroBaselineVisible;
    [NonSerialized]
    private Stroke domainZeroBaselineStroke;
    [NonSerialized]
    private Paint domainZeroBaselinePaint;
    private bool rangeZeroBaselineVisible;
    [NonSerialized]
    private Stroke rangeZeroBaselineStroke;
    [NonSerialized]
    private Paint rangeZeroBaselinePaint;
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
    private Map foregroundDomainMarkers;
    private Map backgroundDomainMarkers;
    private Map foregroundRangeMarkers;
    private Map backgroundRangeMarkers;
    private List annotations;
    [NonSerialized]
    private Paint domainTickBandPaint;
    [NonSerialized]
    private Paint rangeTickBandPaint;
    private AxisSpace fixedDomainAxisSpace;
    private AxisSpace fixedRangeAxisSpace;
    private DatasetRenderingOrder datasetRenderingOrder;
    private SeriesRenderingOrder seriesRenderingOrder;
    private int weight;
    private LegendItemCollection fixedLegendItems;
    private bool domainPannable;
    private bool rangePannable;

    [Modifiers]
    public static Stroke DEFAULT_GRIDLINE_STROKE
    {
      [HideFromJava] get
      {
        return XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRIDLINE_PAINT
    {
      [HideFromJava] get
      {
        return XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_CROSSHAIR_STROKE
    {
      [HideFromJava] get
      {
        return XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_CROSSHAIR_PAINT
    {
      [HideFromJava] get
      {
        return XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 69, (byte) 255, (byte) 18, (byte) 69, (byte) 234, (byte) 70, (byte) 202, (byte) 170})]
    static XYPlot()
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
      XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE = (Stroke) new BasicStroke((float) num1, num2, num3, (float) num4, numArray, (float) num7);
      XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT = (Paint) Color.lightGray;
      XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT = (Paint) Color.blue;
      XYPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 238, (byte) 232, (byte) 159, (byte) 23, (byte) 181, (byte) 252, (byte) 160, (byte) 113, (byte) 231, (byte) 82, (byte) 231, (byte) 101, (byte) 235, (byte) 71, (byte) 235, (byte) 121, (byte) 107, (byte) 103, (byte) 171, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 107, (byte) 139, (byte) 107, (byte) 139, (byte) 139, (byte) 109, (byte) 99, (byte) 167, (byte) 110, (byte) 100, (byte) 104, (byte) 168, (byte) 109, (byte) 104, (byte) 99, (byte) 103, (byte) 135, (byte) 145, (byte) 109, (byte) 104, (byte) 99, (byte) 103, (byte) 135, (byte) 145, (byte) 102, (byte) 134, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 144, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 144, (byte) 103, (byte) 108, (byte) 107, (byte) 139, (byte) 103, (byte) 108, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPlot(XYDataset dataset, ValueAxis domainAxis, ValueAxis rangeAxis, XYItemRenderer renderer)
    {
      XYPlot xyPlot = this;
      this.quadrantOrigin = (Point2D) new Point2D.Double(0.0, 0.0);
      Paint[] paintArray = new Paint[4];
      int index1 = 0;
      // ISSUE: variable of the null type
      __Null local1 = null;
      paintArray[index1] = (Paint) local1;
      int index2 = 1;
      // ISSUE: variable of the null type
      __Null local2 = null;
      paintArray[index2] = (Paint) local2;
      int index3 = 2;
      // ISSUE: variable of the null type
      __Null local3 = null;
      paintArray[index3] = (Paint) local3;
      int index4 = 3;
      // ISSUE: variable of the null type
      __Null local4 = null;
      paintArray[index4] = (Paint) local4;
      this.quadrantPaint = paintArray;
      this.domainCrosshairLockedOnData = true;
      this.rangeCrosshairLockedOnData = true;
      this.datasetRenderingOrder = DatasetRenderingOrder.__\u003C\u003EREVERSE;
      this.seriesRenderingOrder = SeriesRenderingOrder.__\u003C\u003EREVERSE;
      this.orientation = PlotOrientation.__\u003C\u003EVERTICAL;
      this.weight = 1;
      this.axisOffset = RectangleInsets.__\u003C\u003EZERO_INSETS;
      this.domainAxes = new ObjectList();
      this.domainAxisLocations = new ObjectList();
      this.foregroundDomainMarkers = (Map) new HashMap();
      this.backgroundDomainMarkers = (Map) new HashMap();
      this.rangeAxes = new ObjectList();
      this.rangeAxisLocations = new ObjectList();
      this.foregroundRangeMarkers = (Map) new HashMap();
      this.backgroundRangeMarkers = (Map) new HashMap();
      this.datasets = new ObjectList();
      this.renderers = new ObjectList();
      this.datasetToDomainAxesMap = (Map) new TreeMap();
      this.datasetToRangeAxesMap = (Map) new TreeMap();
      this.annotations = (List) new ArrayList();
      this.datasets.set(0, (object) dataset);
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.renderers.set(0, (object) renderer);
      if (renderer != null)
      {
        renderer.setPlot(this);
        renderer.addChangeListener((RendererChangeListener) this);
      }
      this.domainAxes.set(0, (object) domainAxis);
      this.mapDatasetToDomainAxis(0, 0);
      if (domainAxis != null)
      {
        domainAxis.setPlot((Plot) this);
        domainAxis.addChangeListener((AxisChangeListener) this);
      }
      this.domainAxisLocations.set(0, (object) AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT);
      this.rangeAxes.set(0, (object) rangeAxis);
      this.mapDatasetToRangeAxis(0, 0);
      if (rangeAxis != null)
      {
        rangeAxis.setPlot((Plot) this);
        rangeAxis.addChangeListener((AxisChangeListener) this);
      }
      this.rangeAxisLocations.set(0, (object) AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT);
      this.configureDomainAxes();
      this.configureRangeAxes();
      this.domainGridlinesVisible = true;
      this.domainGridlineStroke = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.domainGridlinePaint = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      this.domainMinorGridlinesVisible = false;
      this.domainMinorGridlineStroke = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.domainMinorGridlinePaint = (Paint) Color.white;
      this.domainZeroBaselineVisible = false;
      this.domainZeroBaselinePaint = (Paint) Color.black;
      this.domainZeroBaselineStroke = (Stroke) new BasicStroke(0.5f);
      this.rangeGridlinesVisible = true;
      this.rangeGridlineStroke = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.rangeGridlinePaint = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      this.rangeMinorGridlinesVisible = false;
      this.rangeMinorGridlineStroke = XYPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.rangeMinorGridlinePaint = (Paint) Color.white;
      this.rangeZeroBaselineVisible = false;
      this.rangeZeroBaselinePaint = (Paint) Color.black;
      this.rangeZeroBaselineStroke = (Stroke) new BasicStroke(0.5f);
      this.domainCrosshairVisible = false;
      this.domainCrosshairValue = 0.0;
      this.domainCrosshairStroke = XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      this.domainCrosshairPaint = XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      this.rangeCrosshairVisible = false;
      this.rangeCrosshairValue = 0.0;
      this.rangeCrosshairStroke = XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      this.rangeCrosshairPaint = XYPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPlot()
      : this((XYDataset) null, (ValueAxis) null, (ValueAxis) null, (XYItemRenderer) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 200, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(XYItemRenderer renderer)
    {
      this.setRenderer(0, renderer);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 102, (byte) 99, (byte) 144, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOrientation(PlotOrientation orientation)
    {
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (orientation == this.orientation)
          return;
        this.orientation = orientation;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 190, (byte) 99, (byte) 199, (byte) 103, (byte) 99, (byte) 167, (byte) 109, (byte) 99, (byte) 102, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(ValueAxis axis)
    {
      if (axis != null)
        axis.setPlot((Plot) this);
      ValueAxis rangeAxis = this.getRangeAxis();
      if (rangeAxis != null)
        rangeAxis.removeChangeListener((AxisChangeListener) this);
      this.rangeAxes.set(0, (object) axis);
      if (axis != null)
      {
        axis.configure();
        axis.addChangeListener((AxisChangeListener) this);
      }
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 26, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.domainCrosshairVisible ? 1 : 0) == num)
        return;
      this.domainCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 243, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairVisible ? 1 : 0) == num)
        return;
      this.rangeCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 110, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainZeroBaselineVisible(bool visible)
    {
      this.domainZeroBaselineVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 88, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeZeroBaselineVisible(bool visible)
    {
      this.rangeZeroBaselineVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 131, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.axisOffset = offset;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 74, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainZeroBaselinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainZeroBaselinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 155, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeZeroBaselinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeZeroBaselinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 18, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.domainGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 139, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.rangeGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 221, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainCrosshairPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 122, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeCrosshairPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable((ushort) 932)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDomainAxisCount()
    {
      return this.domainAxes.size();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 162, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getDomainAxis(int index)
    {
      ValueAxis valueAxis = (ValueAxis) null;
      if (index < this.domainAxes.size())
        valueAxis = (ValueAxis) this.domainAxes.get(index);
      if (valueAxis == null)
      {
        Plot parent = this.getParent();
        if (parent is XYPlot)
          valueAxis = ((XYPlot) parent).getDomainAxis(index);
      }
      return valueAxis;
    }

    [LineNumberTable((ushort) 1230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRangeAxisCount()
    {
      return this.rangeAxes.size();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 14, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxis(int index)
    {
      ValueAxis valueAxis = (ValueAxis) null;
      if (index < this.rangeAxes.size())
        valueAxis = (ValueAxis) this.rangeAxes.get(index);
      if (valueAxis == null)
      {
        Plot parent = this.getParent();
        if (parent is XYPlot)
          valueAxis = ((XYPlot) parent).getRangeAxis(index);
      }
      return valueAxis;
    }

    [LineNumberTable((ushort) 1552)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRendererCount()
    {
      return this.renderers.size();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 182, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemRenderer getRenderer(int index)
    {
      XYItemRenderer xyItemRenderer = (XYItemRenderer) null;
      if (this.renderers.size() > index)
        xyItemRenderer = (XYItemRenderer) this.renderers.get(index);
      return xyItemRenderer;
    }

    [LineNumberTable((ushort) 3001)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotations()
    {
      return (List) new ArrayList((Collection) this.annotations);
    }

    public virtual PlotOrientation getOrientation()
    {
      return this.orientation;
    }

    [LineNumberTable((ushort) 880)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getDomainAxisLocation()
    {
      return (AxisLocation) this.domainAxisLocations.get(0);
    }

    [LineNumberTable((ushort) 1099)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getRangeAxisLocation()
    {
      return (AxisLocation) this.rangeAxisLocations.get(0);
    }

    [LineNumberTable((ushort) 1563)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemRenderer getRenderer()
    {
      return this.getRenderer(0);
    }

    [LineNumberTable((ushort) 775)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getDomainAxis()
    {
      return this.getDomainAxis(0);
    }

    [LineNumberTable((ushort) 1058)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxis()
    {
      return this.getRangeAxis(0);
    }

    [LineNumberTable((ushort) 920)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getDomainAxisEdge()
    {
      return Plot.resolveDomainAxisLocation(this.getDomainAxisLocation(), this.orientation);
    }

    [LineNumberTable((ushort) 1138)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getRangeAxisEdge()
    {
      return Plot.resolveRangeAxisLocation(this.getRangeAxisLocation(), this.orientation);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 56, (byte) 103, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToDomainAxis(int index, int axisIndex)
    {
      ArrayList arrayList = new ArrayList(1);
      ((List) arrayList).add((object) new Integer(axisIndex));
      this.mapDatasetToDomainAxes(index, (List) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 92, (byte) 103, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToRangeAxis(int index, int axisIndex)
    {
      ArrayList arrayList = new ArrayList(1);
      ((List) arrayList).add((object) new Integer(axisIndex));
      this.mapDatasetToRangeAxes(index, (List) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 74, (byte) 112, (byte) 114, (byte) 99, (byte) 230, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void configureDomainAxes()
    {
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis != null)
          valueAxis.configure();
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 118, (byte) 112, (byte) 114, (byte) 99, (byte) 230, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void configureRangeAxes()
    {
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
          valueAxis.configure();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 200, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(int index, ValueAxis axis)
    {
      this.setDomainAxis(index, axis, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 188, (byte) 66, (byte) 104, (byte) 99, (byte) 135, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 102, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(int index, ValueAxis axis, bool notify)
    {
      int num = notify ? 1 : 0;
      ValueAxis domainAxis = this.getDomainAxis(index);
      if (domainAxis != null)
        domainAxis.removeChangeListener((AxisChangeListener) this);
      if (axis != null)
        axis.setPlot((Plot) this);
      this.domainAxes.set(index, (object) axis);
      if (axis != null)
      {
        axis.configure();
        axis.addChangeListener((AxisChangeListener) this);
      }
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 144, (byte) 130, (byte) 102, (byte) 176, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(int index, AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      if (index == 0 && location == null)
      {
        string str = "Null 'location' for index 0 not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainAxisLocations.set(index, (object) location);
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 94, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getDomainAxisLocation(int index)
    {
      AxisLocation axisLocation = (AxisLocation) null;
      if (index < this.domainAxisLocations.size())
        axisLocation = (AxisLocation) this.domainAxisLocations.get(index);
      if (axisLocation == null)
        axisLocation = AxisLocation.getOpposite(this.getDomainAxisLocation());
      return axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 69, (byte) 98, (byte) 102, (byte) 176, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(int index, AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      if (index == 0 && location == null)
      {
        string str = "Null 'location' for index 0 not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeAxisLocations.set(index, (object) location);
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 101, (byte) 130, (byte) 104, (byte) 99, (byte) 135, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 102, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(int index, ValueAxis axis, bool notify)
    {
      int num = notify ? 1 : 0;
      ValueAxis rangeAxis = this.getRangeAxis(index);
      if (rangeAxis != null)
        rangeAxis.removeChangeListener((AxisChangeListener) this);
      if (axis != null)
        axis.setPlot((Plot) this);
      this.rangeAxes.set(index, (object) axis);
      if (axis != null)
      {
        axis.configure();
        axis.addChangeListener((AxisChangeListener) this);
      }
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 138, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getRangeAxisLocation(int index)
    {
      AxisLocation axisLocation = (AxisLocation) null;
      if (index < this.rangeAxisLocations.size())
        axisLocation = (AxisLocation) this.rangeAxisLocations.get(index);
      if (axisLocation == null)
        axisLocation = AxisLocation.getOpposite(this.getRangeAxisLocation());
      return axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 231, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataset getDataset(int index)
    {
      XYDataset xyDataset = (XYDataset) null;
      if (this.datasets.size() > index)
        xyDataset = (XYDataset) this.datasets.get(index);
      return xyDataset;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 4, (byte) 104, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 199, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(int index, XYDataset dataset)
    {
      XYDataset dataset1 = this.getDataset(index);
      if (dataset1 != null)
        dataset1.removeChangeListener((DatasetChangeListener) this);
      this.datasets.set(index, (object) dataset);
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 47, (byte) 102, (byte) 102, (byte) 104, (byte) 174, (byte) 103, (byte) 107, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void datasetChanged(DatasetChangeEvent @event)
    {
      this.configureDomainAxes();
      this.configureRangeAxes();
      if (this.getParent() != null)
      {
        this.getParent().datasetChanged(@event);
      }
      else
      {
        PlotChangeEvent event1 = new PlotChangeEvent((Plot) this);
        event1.setType(ChartChangeEventType.__\u003C\u003EDATASET_UPDATED);
        this.notifyListeners(event1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 72, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 147, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToDomainAxes(int index, List axisIndices)
    {
      if (index < 0)
      {
        string str = "Requires 'index' >= 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.checkAxisIndices(axisIndices);
        this.datasetToDomainAxesMap.put((object) new Integer(index), (object) new ArrayList((Collection) axisIndices));
        this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) this.getDataset(index)));
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 129, (byte) 99, (byte) 129, (byte) 103, (byte) 99, (byte) 144, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 176, (byte) 105, (byte) 144, (byte) 232, (byte) 55, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void checkAxisIndices([In] List obj0)
    {
      if (obj0 == null)
        return;
      int num = obj0.size();
      if (num == 0)
      {
        string str = "Empty list not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        HashSet hashSet = new HashSet();
        for (int index = 0; index < num; ++index)
        {
          object obj = obj0.get(index);
          if (!(obj is Integer))
          {
            string str = "Indices must be Integer instances.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
          else if (hashSet.contains(obj))
          {
            string str = "Indices must be unique.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
          else
            hashSet.add(obj);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 108, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 147, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToRangeAxes(int index, List axisIndices)
    {
      if (index < 0)
      {
        string str = "Requires 'index' >= 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.checkAxisIndices(axisIndices);
        this.datasetToRangeAxesMap.put((object) new Integer(index), (object) new ArrayList((Collection) axisIndices));
        this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) this.getDataset(index)));
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 213, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(int index, XYItemRenderer renderer)
    {
      this.setRenderer(index, renderer, true);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 249, (byte) 130, (byte) 104, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 103, (byte) 135, (byte) 102, (byte) 102, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(int index, XYItemRenderer renderer, bool notify)
    {
      int num = notify ? 1 : 0;
      XYItemRenderer renderer1 = this.getRenderer(index);
      if (renderer1 != null)
        renderer1.removeChangeListener((RendererChangeListener) this);
      this.renderers.set(index, (object) renderer);
      if (renderer != null)
      {
        renderer.setPlot(this);
        renderer.addChangeListener((RendererChangeListener) this);
      }
      this.configureDomainAxes();
      this.configureRangeAxes();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 47, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(Marker marker, Layer layer)
    {
      this.addDomainMarker(0, marker, layer);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 131, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(int index, Marker marker, Layer layer)
    {
      this.addDomainMarker(index, marker, layer, true);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 87, (byte) 103, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainMarkers(int index)
    {
      Integer integer = new Integer(index);
      if (this.backgroundDomainMarkers != null)
      {
        Collection collection = (Collection) this.backgroundDomainMarkers.get((object) integer);
        if (collection != null)
        {
          Iterator iterator = collection.iterator();
          while (iterator.hasNext())
            ((Marker) iterator.next()).removeChangeListener((MarkerChangeListener) this);
          collection.clear();
        }
      }
      if (this.foregroundRangeMarkers != null)
      {
        Collection collection = (Collection) this.foregroundDomainMarkers.get((object) integer);
        if (collection != null)
        {
          Iterator iterator = collection.iterator();
          while (iterator.hasNext())
            ((Marker) iterator.next()).removeChangeListener((MarkerChangeListener) this);
          collection.clear();
        }
      }
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 12, (byte) 99, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 107, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 159, (byte) 3, (byte) 104, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 157, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(int index, Marker marker, Layer layer, bool notify)
    {
      int num = notify ? 1 : 0;
      if (marker == null)
      {
        string str = "Null 'marker' not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (layer == null)
      {
        string str = "Null 'layer' not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (layer == Layer.__\u003C\u003EFOREGROUND)
        {
          object obj1 = (object) (Collection) this.foregroundDomainMarkers.get((object) new Integer(index));
          if ((Collection) obj1 == null)
          {
            obj1 = (object) new ArrayList();
            this.foregroundDomainMarkers.put((object) new Integer(index), (object) (ArrayList) obj1);
          }
          object obj2 = obj1;
          object obj3 = (object) marker;
          Collection collection1;
          if (obj2 != null)
          {
            Collection collection2 = obj2 as Collection;
            if (collection2 == null)
              throw new IncompatibleClassChangeError();
            collection1 = collection2;
          }
          else
            collection1 = (Collection) null;
          object obj4 = obj3;
          collection1.add(obj4);
        }
        else if (layer == Layer.__\u003C\u003EBACKGROUND)
        {
          object obj1 = (object) (Collection) this.backgroundDomainMarkers.get((object) new Integer(index));
          if ((Collection) obj1 == null)
          {
            obj1 = (object) new ArrayList();
            this.backgroundDomainMarkers.put((object) new Integer(index), (object) (ArrayList) obj1);
          }
          object obj2 = obj1;
          object obj3 = (object) marker;
          Collection collection1;
          if (obj2 != null)
          {
            Collection collection2 = obj2 as Collection;
            if (collection2 == null)
              throw new IncompatibleClassChangeError();
            collection1 = collection2;
          }
          else
            collection1 = (Collection) null;
          object obj4 = obj3;
          collection1.add(obj4);
        }
        marker.addChangeListener((MarkerChangeListener) this);
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable((ushort) 2628)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(Marker marker, Layer layer)
    {
      return (this.removeDomainMarker(0, marker, layer) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 2645)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(int index, Marker marker, Layer layer)
    {
      return (this.removeDomainMarker(index, marker, layer, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 244, (byte) 99, (byte) 104, (byte) 217, (byte) 183, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(int index, Marker marker, Layer layer, bool notify)
    {
      int num1 = notify ? 1 : 0;
      ArrayList arrayList = layer != Layer.__\u003C\u003EFOREGROUND ? (ArrayList) this.backgroundDomainMarkers.get((object) new Integer(index)) : (ArrayList) this.foregroundDomainMarkers.get((object) new Integer(index));
      if (arrayList == null)
        return false;
      int num2 = arrayList.remove((object) marker) ? 1 : 0;
      if (num2 != 0 && num1 != 0)
        this.fireChangeEvent();
      return num2 != 0;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 37, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(Marker marker, Layer layer)
    {
      this.addRangeMarker(0, marker, layer);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 83, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(int index, Marker marker, Layer layer)
    {
      this.addRangeMarker(index, marker, layer, true);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 134, (byte) 103, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearRangeMarkers(int index)
    {
      Integer integer = new Integer(index);
      if (this.backgroundRangeMarkers != null)
      {
        Collection collection = (Collection) this.backgroundRangeMarkers.get((object) integer);
        if (collection != null)
        {
          Iterator iterator = collection.iterator();
          while (iterator.hasNext())
            ((Marker) iterator.next()).removeChangeListener((MarkerChangeListener) this);
          collection.clear();
        }
      }
      if (this.foregroundRangeMarkers != null)
      {
        Collection collection = (Collection) this.foregroundRangeMarkers.get((object) integer);
        if (collection != null)
        {
          Iterator iterator = collection.iterator();
          while (iterator.hasNext())
            ((Marker) iterator.next()).removeChangeListener((MarkerChangeListener) this);
          collection.clear();
        }
      }
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 216, (byte) 99, (byte) 107, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 159, (byte) 3, (byte) 104, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 157, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(int index, Marker marker, Layer layer, bool notify)
    {
      int num = notify ? 1 : 0;
      if (layer == Layer.__\u003C\u003EFOREGROUND)
      {
        object obj1 = (object) (Collection) this.foregroundRangeMarkers.get((object) new Integer(index));
        if ((Collection) obj1 == null)
        {
          obj1 = (object) new ArrayList();
          this.foregroundRangeMarkers.put((object) new Integer(index), (object) (ArrayList) obj1);
        }
        object obj2 = obj1;
        object obj3 = (object) marker;
        Collection collection1;
        if (obj2 != null)
        {
          Collection collection2 = obj2 as Collection;
          if (collection2 == null)
            throw new IncompatibleClassChangeError();
          collection1 = collection2;
        }
        else
          collection1 = (Collection) null;
        object obj4 = obj3;
        collection1.add(obj4);
      }
      else if (layer == Layer.__\u003C\u003EBACKGROUND)
      {
        object obj1 = (object) (Collection) this.backgroundRangeMarkers.get((object) new Integer(index));
        if ((Collection) obj1 == null)
        {
          obj1 = (object) new ArrayList();
          this.backgroundRangeMarkers.put((object) new Integer(index), (object) (ArrayList) obj1);
        }
        object obj2 = obj1;
        object obj3 = (object) marker;
        Collection collection1;
        if (obj2 != null)
        {
          Collection collection2 = obj2 as Collection;
          if (collection2 == null)
            throw new IncompatibleClassChangeError();
          collection1 = collection2;
        }
        else
          collection1 = (Collection) null;
        object obj4 = obj3;
        collection1.add(obj4);
      }
      marker.addChangeListener((MarkerChangeListener) this);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 2864)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(Marker marker, Layer layer)
    {
      return (this.removeRangeMarker(0, marker, layer) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 2881)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(int index, Marker marker, Layer layer)
    {
      return (this.removeRangeMarker(index, marker, layer, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 185, (byte) 67, (byte) 99, (byte) 176, (byte) 104, (byte) 217, (byte) 183, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(int index, Marker marker, Layer layer, bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (marker == null)
      {
        string str = "Null 'marker' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ArrayList arrayList = layer != Layer.__\u003C\u003EFOREGROUND ? (ArrayList) this.backgroundRangeMarkers.get((object) new Integer(index)) : (ArrayList) this.foregroundRangeMarkers.get((object) new Integer(index));
        if (arrayList == null)
          return false;
        int num2 = arrayList.remove((object) marker) ? 1 : 0;
        if (num2 != 0 && num1 != 0)
          this.fireChangeEvent();
        return num2 != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 174, (byte) 98, (byte) 99, (byte) 144, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(XYAnnotation annotation, bool notify)
    {
      int num = notify ? 1 : 0;
      if (annotation == null)
      {
        string str = "Null 'annotation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.annotations.add((object) annotation);
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 165, (byte) 98, (byte) 99, (byte) 144, (byte) 109, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeAnnotation(XYAnnotation annotation, bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (annotation == null)
      {
        string str = "Null 'annotation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num2 = this.annotations.remove((object) annotation) ? 1 : 0;
        if (num2 != 0 && num1 != 0)
          this.fireChangeEvent();
        return num2 != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 162, (byte) 99, (byte) 199, (byte) 107, (byte) 109, (byte) 150, (byte) 187, (byte) 112, (byte) 150, (byte) 248, (byte) 70, (byte) 112, (byte) 114, (byte) 99, (byte) 104, (byte) 237, (byte) 60, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisSpace calculateRangeAxisSpace(Graphics2D g2, Rectangle2D plotArea, AxisSpace space)
    {
      if (space == null)
        space = new AxisSpace();
      if (this.fixedRangeAxisSpace != null)
      {
        if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          space.ensureAtLeast(this.fixedRangeAxisSpace.getTop(), RectangleEdge.__\u003C\u003ETOP);
          space.ensureAtLeast(this.fixedRangeAxisSpace.getBottom(), RectangleEdge.__\u003C\u003EBOTTOM);
        }
        else if (this.orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          space.ensureAtLeast(this.fixedRangeAxisSpace.getLeft(), RectangleEdge.__\u003C\u003ELEFT);
          space.ensureAtLeast(this.fixedRangeAxisSpace.getRight(), RectangleEdge.__\u003C\u003ERIGHT);
        }
      }
      else
      {
        for (int index = 0; index < this.rangeAxes.size(); ++index)
        {
          Axis axis = (Axis) this.rangeAxes.get(index);
          if (axis != null)
          {
            RectangleEdge rangeAxisEdge = this.getRangeAxisEdge(index);
            space = axis.reserveSpace(g2, (Plot) this, plotArea, rangeAxisEdge, space);
          }
        }
      }
      return space;
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 115, (byte) 99, (byte) 199, (byte) 107, (byte) 109, (byte) 150, (byte) 187, (byte) 112, (byte) 150, (byte) 248, (byte) 70, (byte) 112, (byte) 114, (byte) 99, (byte) 104, (byte) 237, (byte) 60, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisSpace calculateDomainAxisSpace(Graphics2D g2, Rectangle2D plotArea, AxisSpace space)
    {
      if (space == null)
        space = new AxisSpace();
      if (this.fixedDomainAxisSpace != null)
      {
        if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          space.ensureAtLeast(this.fixedDomainAxisSpace.getLeft(), RectangleEdge.__\u003C\u003ELEFT);
          space.ensureAtLeast(this.fixedDomainAxisSpace.getRight(), RectangleEdge.__\u003C\u003ERIGHT);
        }
        else if (this.orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          space.ensureAtLeast(this.fixedDomainAxisSpace.getTop(), RectangleEdge.__\u003C\u003ETOP);
          space.ensureAtLeast(this.fixedDomainAxisSpace.getBottom(), RectangleEdge.__\u003C\u003EBOTTOM);
        }
      }
      else
      {
        for (int index = 0; index < this.domainAxes.size(); ++index)
        {
          Axis axis = (Axis) this.domainAxes.get(index);
          if (axis != null)
          {
            RectangleEdge domainAxisEdge = this.getDomainAxisEdge(index);
            space = axis.reserveSpace(g2, (Plot) this, plotArea, domainAxisEdge, space);
          }
        }
      }
      return space;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 156, (byte) 104, (byte) 141, (byte) 99, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getDomainAxisEdge(int index)
    {
      return Plot.resolveDomainAxisLocation(this.getDomainAxisLocation(index), this.orientation) ?? RectangleEdge.opposite(this.getDomainAxisEdge());
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 200, (byte) 104, (byte) 141, (byte) 99, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getRangeAxisEdge(int index)
    {
      return Plot.resolveRangeAxisLocation(this.getRangeAxisLocation(index), this.orientation) ?? RectangleEdge.opposite(this.getRangeAxisEdge());
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 95, (byte) 102, (byte) 106, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisSpace calculateAxisSpace(Graphics2D g2, Rectangle2D plotArea)
    {
      AxisSpace space1 = new AxisSpace();
      AxisSpace space2 = this.calculateRangeAxisSpace(g2, plotArea, space1);
      Rectangle2D plotArea1 = space2.shrink(plotArea, (Rectangle2D) null);
      return this.calculateDomainAxisSpace(g2, plotArea1, space2);
    }

    [LineNumberTable(new byte[] {(byte) 172, (byte) 213, (byte) 110, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawBackground(Graphics2D g2, Rectangle2D area)
    {
      this.fillBackground(g2, area, this.orientation);
      this.drawQuadrants(g2, area);
      this.drawBackgroundImage(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 164, (byte) 166, (byte) 112, (byte) 114, (byte) 99, (byte) 238, (byte) 61, (byte) 230, (byte) 72, (byte) 112, (byte) 114, (byte) 99, (byte) 238, (byte) 61, (byte) 230, (byte) 71, (byte) 166, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 149, (byte) 106, (byte) 107, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 149, (byte) 106, (byte) 107, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 149, (byte) 106, (byte) 107, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 149, (byte) 106, (byte) 107, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Map drawAxes(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, PlotRenderingInfo plotState)
    {
      AxisCollection axisCollection = new AxisCollection();
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis != null)
          axisCollection.add((Axis) valueAxis, this.getDomainAxisEdge(index));
      }
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
          axisCollection.add((Axis) valueAxis, this.getRangeAxisEdge(index));
      }
      HashMap hashMap = new HashMap();
      double d1 = ((RectangularShape) dataArea).getMinY() - this.axisOffset.calculateTopOutset(((RectangularShape) dataArea).getHeight());
      Iterator iterator1 = axisCollection.getAxesAtTop().iterator();
      while (iterator1.hasNext())
      {
        ValueAxis valueAxis = (ValueAxis) iterator1.next();
        AxisState axisState = valueAxis.draw(g2, d1, plotArea, dataArea, RectangleEdge.__\u003C\u003ETOP, plotState);
        d1 = axisState.getCursor();
        ((Map) hashMap).put((object) valueAxis, (object) axisState);
      }
      double d2 = ((RectangularShape) dataArea).getMaxY() + this.axisOffset.calculateBottomOutset(((RectangularShape) dataArea).getHeight());
      Iterator iterator2 = axisCollection.getAxesAtBottom().iterator();
      while (iterator2.hasNext())
      {
        ValueAxis valueAxis = (ValueAxis) iterator2.next();
        AxisState axisState = valueAxis.draw(g2, d2, plotArea, dataArea, RectangleEdge.__\u003C\u003EBOTTOM, plotState);
        d2 = axisState.getCursor();
        ((Map) hashMap).put((object) valueAxis, (object) axisState);
      }
      double d3 = ((RectangularShape) dataArea).getMinX() - this.axisOffset.calculateLeftOutset(((RectangularShape) dataArea).getWidth());
      Iterator iterator3 = axisCollection.getAxesAtLeft().iterator();
      while (iterator3.hasNext())
      {
        ValueAxis valueAxis = (ValueAxis) iterator3.next();
        AxisState axisState = valueAxis.draw(g2, d3, plotArea, dataArea, RectangleEdge.__\u003C\u003ELEFT, plotState);
        d3 = axisState.getCursor();
        ((Map) hashMap).put((object) valueAxis, (object) axisState);
      }
      double d4 = ((RectangularShape) dataArea).getMaxX() + this.axisOffset.calculateRightOutset(((RectangularShape) dataArea).getWidth());
      Iterator iterator4 = axisCollection.getAxesAtRight().iterator();
      while (iterator4.hasNext())
      {
        ValueAxis valueAxis = (ValueAxis) iterator4.next();
        AxisState axisState = valueAxis.draw(g2, d4, plotArea, dataArea, RectangleEdge.__\u003C\u003ERIGHT, plotState);
        d4 = axisState.getCursor();
        ((Map) hashMap).put((object) valueAxis, (object) axisState);
      }
      return (Map) hashMap;
    }

    public virtual double getDomainCrosshairValue()
    {
      return this.domainCrosshairValue;
    }

    public virtual double getRangeCrosshairValue()
    {
      return this.rangeCrosshairValue;
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 89, (byte) 103, (byte) 102, (byte) 98, (byte) 103, (byte) 104, (byte) 104, (byte) 105, (byte) 110, (byte) 106, (byte) 99, (byte) 178, (byte) 99, (byte) 104, (byte) 98, (byte) 105, (byte) 99, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainTickBands(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (this.getDomainTickBandPaint() == null)
        return;
      int num = 0;
      ValueAxis domainAxis = this.getDomainAxis();
      double d1 = domainAxis.getLowerBound();
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        double d2 = ((ValueTick) iterator.next()).getValue();
        if (num != 0)
          this.getRenderer().fillDomainGridBand(g2, this, domainAxis, dataArea, d1, d2);
        d1 = d2;
        num = num != 0 ? 0 : 1;
      }
      double upperBound = domainAxis.getUpperBound();
      if (num == 0)
        return;
      this.getRenderer().fillDomainGridBand(g2, this, domainAxis, dataArea, d1, upperBound);
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 124, (byte) 103, (byte) 102, (byte) 98, (byte) 103, (byte) 104, (byte) 104, (byte) 105, (byte) 110, (byte) 106, (byte) 99, (byte) 178, (byte) 99, (byte) 104, (byte) 98, (byte) 105, (byte) 99, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeTickBands(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (this.getRangeTickBandPaint() == null)
        return;
      int num = 0;
      ValueAxis rangeAxis = this.getRangeAxis();
      double d1 = rangeAxis.getLowerBound();
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        double d2 = ((ValueTick) iterator.next()).getValue();
        if (num != 0)
          this.getRenderer().fillRangeGridBand(g2, this, rangeAxis, dataArea, d1, d2);
        d1 = d2;
        num = num != 0 ? 0 : 1;
      }
      double upperBound = rangeAxis.getUpperBound();
      if (num == 0)
        return;
      this.getRenderer().fillRangeGridBand(g2, this, rangeAxis, dataArea, d1, upperBound);
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 146, (byte) 104, (byte) 193, (byte) 115, (byte) 98, (byte) 98, (byte) 103, (byte) 98, (byte) 107, (byte) 98, (byte) 109, (byte) 118, (byte) 103, (byte) 103, (byte) 132, (byte) 118, (byte) 103, (byte) 103, (byte) 130, (byte) 104, (byte) 108, (byte) 222, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainGridlines(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (this.getRenderer() == null || !this.isDomainGridlinesVisible() && !this.isDomainMinorGridlinesVisible())
        return;
      Stroke stroke = (Stroke) null;
      Paint paint = (Paint) null;
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        int num = 0;
        ValueTick valueTick = (ValueTick) iterator.next();
        if (valueTick.getTickType() == TickType.__\u003C\u003EMINOR && this.isDomainMinorGridlinesVisible())
        {
          stroke = this.getDomainMinorGridlineStroke();
          paint = this.getDomainMinorGridlinePaint();
          num = 1;
        }
        else if (valueTick.getTickType() == TickType.__\u003C\u003EMAJOR && this.isDomainGridlinesVisible())
        {
          stroke = this.getDomainGridlineStroke();
          paint = this.getDomainGridlinePaint();
          num = 1;
        }
        XYItemRenderer renderer = this.getRenderer();
        if (renderer is AbstractXYItemRenderer && num != 0)
          ((AbstractXYItemRenderer) renderer).drawDomainLine(g2, this, this.getDomainAxis(), dataArea, valueTick.getValue(), paint, stroke);
      }
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 241, (byte) 104, (byte) 199, (byte) 104, (byte) 103, (byte) 255, (byte) 3, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawZeroDomainBaseline(Graphics2D g2, Rectangle2D area)
    {
      if (!this.isDomainZeroBaselineVisible())
        return;
      XYItemRenderer renderer = this.getRenderer();
      if (!(renderer is AbstractXYItemRenderer))
        return;
      ((AbstractXYItemRenderer) renderer).drawDomainLine(g2, this, this.getDomainAxis(), area, 0.0, this.domainZeroBaselinePaint, this.domainZeroBaselineStroke);
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 193, (byte) 104, (byte) 193, (byte) 115, (byte) 98, (byte) 98, (byte) 103, (byte) 102, (byte) 103, (byte) 98, (byte) 107, (byte) 99, (byte) 109, (byte) 150, (byte) 103, (byte) 103, (byte) 133, (byte) 150, (byte) 103, (byte) 103, (byte) 131, (byte) 154, (byte) 189, (byte) 165})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeGridlines(Graphics2D g2, Rectangle2D area, List ticks)
    {
      if (this.getRenderer() == null || !this.isRangeGridlinesVisible() && !this.isRangeMinorGridlinesVisible())
        return;
      Stroke s = (Stroke) null;
      Paint p = (Paint) null;
      if (this.getRangeAxis() == null)
        return;
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        int num = 0;
        ValueTick valueTick = (ValueTick) iterator.next();
        if (valueTick.getTickType() == TickType.__\u003C\u003EMINOR && this.isRangeMinorGridlinesVisible())
        {
          s = this.getRangeMinorGridlineStroke();
          p = this.getRangeMinorGridlinePaint();
          num = 1;
        }
        else if (valueTick.getTickType() == TickType.__\u003C\u003EMAJOR && this.isRangeGridlinesVisible())
        {
          s = this.getRangeGridlineStroke();
          p = this.getRangeGridlinePaint();
          num = 1;
        }
        if ((valueTick.getValue() != 0.0 || !this.isRangeZeroBaselineVisible()) && num != 0)
          this.getRenderer().drawRangeLine(g2, this, this.getRangeAxis(), area, valueTick.getValue(), p, s);
      }
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 8, (byte) 104, (byte) 191, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawZeroRangeBaseline(Graphics2D g2, Rectangle2D area)
    {
      if (!this.isRangeZeroBaselineVisible())
        return;
      this.getRenderer().drawRangeLine(g2, this, this.getRangeAxis(), area, 0.0, this.rangeZeroBaselinePaint, this.rangeZeroBaselineStroke);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 47, (byte) 104, (byte) 99, (byte) 193, (byte) 105, (byte) 129, (byte) 106, (byte) 104, (byte) 102, (byte) 103, (byte) 104, (byte) 109, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainMarkers(Graphics2D g2, Rectangle2D dataArea, int index, Layer layer)
    {
      XYItemRenderer renderer = this.getRenderer(index);
      if (renderer == null || index >= this.getDatasetCount())
        return;
      Collection domainMarkers = this.getDomainMarkers(index, layer);
      ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
      if (domainMarkers == null || domainAxisForDataset == null)
        return;
      Iterator iterator = domainMarkers.iterator();
      while (iterator.hasNext())
      {
        Marker m = (Marker) iterator.next();
        renderer.drawDomainMarker(g2, this, domainAxisForDataset, m, dataArea);
      }
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 80, (byte) 104, (byte) 99, (byte) 193, (byte) 105, (byte) 129, (byte) 106, (byte) 104, (byte) 102, (byte) 103, (byte) 104, (byte) 109, (byte) 108, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeMarkers(Graphics2D g2, Rectangle2D dataArea, int index, Layer layer)
    {
      XYItemRenderer renderer = this.getRenderer(index);
      if (renderer == null || index >= this.getDatasetCount())
        return;
      Collection rangeMarkers = this.getRangeMarkers(index, layer);
      ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index);
      if (rangeMarkers == null || rangeAxisForDataset == null)
        return;
      Iterator iterator = rangeMarkers.iterator();
      while (iterator.hasNext())
      {
        Marker m = (Marker) iterator.next();
        renderer.drawRangeMarker(g2, this, rangeAxisForDataset, m, dataArea);
      }
    }

    public virtual DatasetRenderingOrder getDatasetRenderingOrder()
    {
      return this.datasetRenderingOrder;
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 87, (byte) 114, (byte) 104, (byte) 191, (byte) 16, (byte) 98, (byte) 151, (byte) 131, (byte) 109, (byte) 109, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getDomainAxisForDataset(int index)
    {
      int num = Math.max(this.getDatasetCount(), this.getRendererCount());
      if (index < 0 || index >= num)
      {
        string str = new StringBuffer().append("Index ").append(index).append(" out of bounds.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        List list = (List) this.datasetToDomainAxesMap.get((object) new Integer(index));
        return list == null ? this.getDomainAxis(0) : this.getDomainAxis(((Integer) list.get(0)).intValue());
      }
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 114, (byte) 114, (byte) 104, (byte) 191, (byte) 16, (byte) 98, (byte) 151, (byte) 131, (byte) 109, (byte) 109, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxisForDataset(int index)
    {
      int num = Math.max(this.getDatasetCount(), this.getRendererCount());
      if (index < 0 || index >= num)
      {
        string str = new StringBuffer().append("Index ").append(index).append(" out of bounds.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        List list = (List) this.datasetToRangeAxesMap.get((object) new Integer(index));
        return list == null ? this.getRangeAxis(0) : this.getRangeAxis(((Integer) list.get(0)).intValue());
      }
    }

    [LineNumberTable((ushort) 1418)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDatasetCount()
    {
      return this.datasets.size();
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 254, (byte) 98, (byte) 104, (byte) 107, (byte) 98, (byte) 104, (byte) 104, (byte) 102, (byte) 130, (byte) 105, (byte) 100, (byte) 104, (byte) 100, (byte) 194, (byte) 143, (byte) 137, (byte) 104, (byte) 140, (byte) 108, (byte) 104, (byte) 110, (byte) 99, (byte) 108, (byte) 101, (byte) 133, (byte) 105, (byte) 182, (byte) 110, (byte) 143, (byte) 146, (byte) 106, (byte) 57, (byte) 232, (byte) 69, (byte) 242, (byte) 44, (byte) 11, (byte) 240, (byte) 93, (byte) 108, (byte) 104, (byte) 108, (byte) 99, (byte) 108, (byte) 105, (byte) 182, (byte) 110, (byte) 143, (byte) 146, (byte) 106, (byte) 57, (byte) 232, (byte) 69, (byte) 242, (byte) 47, (byte) 11, (byte) 235, (byte) 89})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool render(Graphics2D g2, Rectangle2D dataArea, int index, PlotRenderingInfo info, CrosshairState crosshairState)
    {
      int num1 = 0;
      XYDataset dataset = this.getDataset(index);
      if (!DatasetUtilities.isEmptyOrNull(dataset))
      {
        num1 = 1;
        ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
        ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index);
        if (domainAxisForDataset == null || rangeAxisForDataset == null)
          return num1 != 0;
        XYItemRenderer renderer = this.getRenderer(index);
        if (renderer == null)
        {
          renderer = this.getRenderer();
          if (renderer == null)
            return num1 != 0;
        }
        XYItemRendererState xyirs = renderer.initialise(g2, dataArea, this, dataset, info);
        int passCount = renderer.getPassCount();
        if (this.getSeriesRenderingOrder() == SeriesRenderingOrder.__\u003C\u003EREVERSE)
        {
          for (int index1 = 0; index1 < passCount; ++index1)
          {
            int num2 = dataset.getSeriesCount() - 1;
            while (num2 >= 0)
            {
              int firstItem = 0;
              int lastItem = dataset.getItemCount(num2) - 1;
              if (lastItem != -1)
              {
                if (xyirs.getProcessVisibleItemsOnly())
                {
                  int[] liveItems = RendererUtilities.findLiveItems(dataset, num2, domainAxisForDataset.getLowerBound(), domainAxisForDataset.getUpperBound());
                  firstItem = Math.max(liveItems[0] - 1, 0);
                  lastItem = Math.min(liveItems[1] + 1, lastItem);
                }
                xyirs.startSeriesPass(dataset, num2, firstItem, lastItem, index1, passCount);
                for (int i2 = firstItem; i2 <= lastItem; ++i2)
                  renderer.drawItem(g2, xyirs, dataArea, info, this, domainAxisForDataset, rangeAxisForDataset, dataset, num2, i2, crosshairState, index1);
                xyirs.endSeriesPass(dataset, num2, firstItem, lastItem, index1, passCount);
              }
              num2 += -1;
            }
          }
        }
        else
        {
          for (int index1 = 0; index1 < passCount; ++index1)
          {
            int seriesCount = dataset.getSeriesCount();
            for (int index2 = 0; index2 < seriesCount; ++index2)
            {
              int firstItem = 0;
              int lastItem = dataset.getItemCount(index2) - 1;
              if (xyirs.getProcessVisibleItemsOnly())
              {
                int[] liveItems = RendererUtilities.findLiveItems(dataset, index2, domainAxisForDataset.getLowerBound(), domainAxisForDataset.getUpperBound());
                firstItem = Math.max(liveItems[0] - 1, 0);
                lastItem = Math.min(liveItems[1] + 1, lastItem);
              }
              xyirs.startSeriesPass(dataset, index2, firstItem, lastItem, index1, passCount);
              for (int i2 = firstItem; i2 <= lastItem; ++i2)
                renderer.drawItem(g2, xyirs, dataArea, info, this, domainAxisForDataset, rangeAxisForDataset, dataset, index2, i2, crosshairState, index1);
              xyirs.endSeriesPass(dataset, index2, firstItem, lastItem, index1, passCount);
            }
          }
        }
      }
      return num1 != 0;
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 9, (byte) 98, (byte) 105, (byte) 107, (byte) 136})]
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

    public virtual Paint getDomainCrosshairPaint()
    {
      return this.domainCrosshairPaint;
    }

    public virtual Stroke getDomainCrosshairStroke()
    {
      return this.domainCrosshairStroke;
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 224, (byte) 116, (byte) 98, (byte) 104, (byte) 146, (byte) 148, (byte) 130, (byte) 146, (byte) 180, (byte) 104, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainCrosshair(Graphics2D g2, Rectangle2D dataArea, PlotOrientation orientation, double value, ValueAxis axis, Stroke stroke, Paint paint)
    {
      if (!axis.getRange().contains(value))
        return;
      Line2D.Double @double;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double num = axis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      }
      else
      {
        double num = axis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003ELEFT);
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      }
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 226, (byte) 130, (byte) 105, (byte) 107, (byte) 136})]
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

    public virtual Paint getRangeCrosshairPaint()
    {
      return this.rangeCrosshairPaint;
    }

    public virtual Stroke getRangeCrosshairStroke()
    {
      return this.rangeCrosshairStroke;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 34, (byte) 116, (byte) 98, (byte) 104, (byte) 146, (byte) 148, (byte) 130, (byte) 146, (byte) 180, (byte) 104, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeCrosshair(Graphics2D g2, Rectangle2D dataArea, PlotOrientation orientation, double value, ValueAxis axis, Stroke stroke, Paint paint)
    {
      if (!axis.getRange().contains(value))
        return;
      Line2D.Double @double;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num = axis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      }
      else
      {
        double num = axis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003ELEFT);
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      }
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 25, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 103, (byte) 109, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawAnnotations(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info)
    {
      Iterator iterator = this.annotations.iterator();
      while (iterator.hasNext())
      {
        XYAnnotation xyAnnotation = (XYAnnotation) iterator.next();
        ValueAxis domainAxis = this.getDomainAxis();
        ValueAxis rangeAxis = this.getRangeAxis();
        xyAnnotation.draw(g2, this, dataArea, domainAxis, rangeAxis, 0, info);
      }
    }

    [LineNumberTable(new byte[] {(byte) 172, (byte) 231, (byte) 130, (byte) 103, (byte) 99, (byte) 129, (byte) 120, (byte) 144, (byte) 104, (byte) 100, (byte) 129, (byte) 122, (byte) 147, (byte) 105, (byte) 146, (byte) 105, (byte) 146, (byte) 106, (byte) 147, (byte) 106, (byte) 147, (byte) 120, (byte) 109, (byte) 113, (byte) 109, (byte) 255, (byte) 16, (byte) 69, (byte) 223, (byte) 14, (byte) 162, (byte) 109, (byte) 113, (byte) 109, (byte) 255, (byte) 16, (byte) 69, (byte) 223, (byte) 14, (byte) 162, (byte) 109, (byte) 113, (byte) 109, (byte) 255, (byte) 16, (byte) 69, (byte) 223, (byte) 14, (byte) 162, (byte) 109, (byte) 113, (byte) 109, (byte) 255, (byte) 16, (byte) 69, (byte) 223, (byte) 14, (byte) 162, (byte) 102, (byte) 104, (byte) 146, (byte) 104, (byte) 114, (byte) 111, (byte) 235, (byte) 61, (byte) 232, (byte) 70, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawQuadrants(Graphics2D g2, Rectangle2D area)
    {
      int num1 = 0;
      ValueAxis domainAxis = this.getDomainAxis();
      if (domainAxis == null)
        return;
      double d1 = domainAxis.getRange().constrain(this.quadrantOrigin.getX());
      double num2 = domainAxis.valueToJava2D(d1, area, this.getDomainAxisEdge());
      ValueAxis rangeAxis = this.getRangeAxis();
      if (rangeAxis == null)
        return;
      double d2 = rangeAxis.getRange().constrain(this.quadrantOrigin.getY());
      double num3 = rangeAxis.valueToJava2D(d2, area, this.getRangeAxisEdge());
      double lowerBound1 = domainAxis.getLowerBound();
      double num4 = domainAxis.valueToJava2D(lowerBound1, area, this.getDomainAxisEdge());
      double upperBound1 = domainAxis.getUpperBound();
      double num5 = domainAxis.valueToJava2D(upperBound1, area, this.getDomainAxisEdge());
      double lowerBound2 = rangeAxis.getLowerBound();
      double num6 = rangeAxis.valueToJava2D(lowerBound2, area, this.getRangeAxisEdge());
      double upperBound2 = rangeAxis.getUpperBound();
      double num7 = rangeAxis.valueToJava2D(upperBound2, area, this.getRangeAxisEdge());
      Rectangle2D[] rectangle2DArray1 = new Rectangle2D[4];
      int index1 = 0;
      // ISSUE: variable of the null type
      __Null local1 = null;
      rectangle2DArray1[index1] = (Rectangle2D) local1;
      int index2 = 1;
      // ISSUE: variable of the null type
      __Null local2 = null;
      rectangle2DArray1[index2] = (Rectangle2D) local2;
      int index3 = 2;
      // ISSUE: variable of the null type
      __Null local3 = null;
      rectangle2DArray1[index3] = (Rectangle2D) local3;
      int index4 = 3;
      // ISSUE: variable of the null type
      __Null local4 = null;
      rectangle2DArray1[index4] = (Rectangle2D) local4;
      Rectangle2D[] rectangle2DArray2 = rectangle2DArray1;
      if (this.quadrantPaint[0] != null && d1 > lowerBound1 && d2 < upperBound2)
      {
        rectangle2DArray2[0] = this.orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (Rectangle2D) new Rectangle2D.Double(Math.min(num4, num2), Math.min(num7, num3), Math.abs(num2 - num4), Math.abs(num3 - num7)) : (Rectangle2D) new Rectangle2D.Double(Math.min(num7, num3), Math.min(num4, num2), Math.abs(num3 - num7), Math.abs(num2 - num4));
        num1 = 1;
      }
      if (this.quadrantPaint[1] != null && d1 < upperBound1 && d2 < upperBound2)
      {
        rectangle2DArray2[1] = this.orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (Rectangle2D) new Rectangle2D.Double(Math.min(num2, num5), Math.min(num7, num3), Math.abs(num2 - num5), Math.abs(num3 - num7)) : (Rectangle2D) new Rectangle2D.Double(Math.min(num7, num3), Math.min(num5, num2), Math.abs(num3 - num7), Math.abs(num2 - num5));
        num1 = 1;
      }
      if (this.quadrantPaint[2] != null && d1 > lowerBound1 && d2 > lowerBound2)
      {
        rectangle2DArray2[2] = this.orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (Rectangle2D) new Rectangle2D.Double(Math.min(num4, num2), Math.min(num6, num3), Math.abs(num2 - num4), Math.abs(num3 - num6)) : (Rectangle2D) new Rectangle2D.Double(Math.min(num6, num3), Math.min(num4, num2), Math.abs(num3 - num6), Math.abs(num2 - num4));
        num1 = 1;
      }
      if (this.quadrantPaint[3] != null && d1 < upperBound1 && d2 > lowerBound2)
      {
        rectangle2DArray2[3] = this.orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (Rectangle2D) new Rectangle2D.Double(Math.min(num2, num5), Math.min(num6, num3), Math.abs(num2 - num5), Math.abs(num3 - num6)) : (Rectangle2D) new Rectangle2D.Double(Math.min(num6, num3), Math.min(num5, num2), Math.abs(num3 - num6), Math.abs(num2 - num5));
        num1 = 1;
      }
      if (num1 == 0)
        return;
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getBackgroundAlpha()));
      for (int index5 = 0; index5 < 4; ++index5)
      {
        if (this.quadrantPaint[index5] != null && rectangle2DArray2[index5] != null)
        {
          g2.setPaint(this.quadrantPaint[index5]);
          g2.fill((Shape) rectangle2DArray2[index5]);
        }
      }
      g2.setComposite(composite);
    }

    public virtual Paint getDomainTickBandPaint()
    {
      return this.domainTickBandPaint;
    }

    public virtual Paint getRangeTickBandPaint()
    {
      return this.rangeTickBandPaint;
    }

    public virtual SeriesRenderingOrder getSeriesRenderingOrder()
    {
      return this.seriesRenderingOrder;
    }

    public virtual bool isDomainGridlinesVisible()
    {
      return this.domainGridlinesVisible;
    }

    public virtual bool isDomainMinorGridlinesVisible()
    {
      return this.domainMinorGridlinesVisible;
    }

    public virtual Stroke getDomainMinorGridlineStroke()
    {
      return this.domainMinorGridlineStroke;
    }

    public virtual Paint getDomainMinorGridlinePaint()
    {
      return this.domainMinorGridlinePaint;
    }

    public virtual Stroke getDomainGridlineStroke()
    {
      return this.domainGridlineStroke;
    }

    public virtual Paint getDomainGridlinePaint()
    {
      return this.domainGridlinePaint;
    }

    public virtual bool isRangeGridlinesVisible()
    {
      return this.rangeGridlinesVisible;
    }

    public virtual bool isRangeMinorGridlinesVisible()
    {
      return this.rangeMinorGridlinesVisible;
    }

    public virtual Stroke getRangeMinorGridlineStroke()
    {
      return this.rangeMinorGridlineStroke;
    }

    public virtual Paint getRangeMinorGridlinePaint()
    {
      return this.rangeMinorGridlinePaint;
    }

    public virtual Stroke getRangeGridlineStroke()
    {
      return this.rangeGridlineStroke;
    }

    public virtual Paint getRangeGridlinePaint()
    {
      return this.rangeGridlinePaint;
    }

    public virtual bool isRangeZeroBaselineVisible()
    {
      return this.rangeZeroBaselineVisible;
    }

    public virtual bool isDomainZeroBaselineVisible()
    {
      return this.domainZeroBaselineVisible;
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 138, (byte) 98, (byte) 103, (byte) 104, (byte) 148, (byte) 104, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getDomainMarkers(int index, Layer layer)
    {
      Collection collection = (Collection) null;
      Integer integer = new Integer(index);
      if (layer == Layer.__\u003C\u003EFOREGROUND)
        collection = (Collection) this.foregroundDomainMarkers.get((object) integer);
      else if (layer == Layer.__\u003C\u003EBACKGROUND)
        collection = (Collection) this.backgroundDomainMarkers.get((object) integer);
      if (collection != null)
        collection = Collections.unmodifiableCollection(collection);
      return collection;
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 164, (byte) 98, (byte) 103, (byte) 104, (byte) 148, (byte) 104, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getRangeMarkers(int index, Layer layer)
    {
      Collection collection = (Collection) null;
      Integer integer = new Integer(index);
      if (layer == Layer.__\u003C\u003EFOREGROUND)
        collection = (Collection) this.foregroundRangeMarkers.get((object) integer);
      else if (layer == Layer.__\u003C\u003EBACKGROUND)
        collection = (Collection) this.backgroundRangeMarkers.get((object) integer);
      if (collection != null)
        collection = Collections.unmodifiableCollection(collection);
      return collection;
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 149, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairValue(double value)
    {
      this.setDomainCrosshairValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 50, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairValue(double value)
    {
      this.setRangeCrosshairValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 154, (byte) 109, (byte) 132, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDomainAxisIndex(ValueAxis axis)
    {
      int num = this.domainAxes.indexOf((object) axis);
      if (num < 0)
      {
        Plot parent = this.getParent();
        if (parent is XYPlot)
          num = ((XYPlot) parent).getDomainAxisIndex(axis);
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 176, (byte) 109, (byte) 132, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRangeAxisIndex(ValueAxis axis)
    {
      int num = this.rangeAxes.indexOf((object) axis);
      if (num < 0)
      {
        Plot parent = this.getParent();
        if (parent is XYPlot)
          num = ((XYPlot) parent).getRangeAxisIndex(axis);
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 93, (byte) 99, (byte) 144, (byte) 102, (byte) 115, (byte) 151, (byte) 99, (byte) 109, (byte) 213, (byte) 105, (byte) 243, (byte) 54, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getDatasetsMappedToDomainAxis([In] Integer obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'axisIndex' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        for (int index = 0; index < this.datasets.size(); ++index)
        {
          List list = (List) this.datasetToDomainAxesMap.get((object) new Integer(index));
          if (list == null)
          {
            if (obj0.equals((object) Plot.__\u003C\u003EZERO))
              ((List) arrayList).add(this.datasets.get(index));
          }
          else if (list.contains((object) obj0))
            ((List) arrayList).add(this.datasets.get(index));
        }
        return (List) arrayList;
      }
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 123, (byte) 99, (byte) 144, (byte) 102, (byte) 115, (byte) 151, (byte) 99, (byte) 109, (byte) 213, (byte) 105, (byte) 243, (byte) 54, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getDatasetsMappedToRangeAxis([In] Integer obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'axisIndex' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        for (int index = 0; index < this.datasets.size(); ++index)
        {
          List list = (List) this.datasetToRangeAxesMap.get((object) new Integer(index));
          if (list == null)
          {
            if (obj0.equals((object) Plot.__\u003C\u003EZERO))
              ((List) arrayList).add(this.datasets.get(index));
          }
          else if (list.contains((object) obj0))
            ((List) arrayList).add(this.datasets.get(index));
        }
        return (List) arrayList;
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 81, (byte) 98, (byte) 112, (byte) 111, (byte) 114, (byte) 99, (byte) 233, (byte) 60, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemRenderer getRendererForDataset(XYDataset dataset)
    {
      XYItemRenderer xyItemRenderer = (XYItemRenderer) null;
      for (int index = 0; index < this.datasets.size(); ++index)
      {
        if (this.datasets.get(index) == dataset)
        {
          xyItemRenderer = (XYItemRenderer) this.renderers.get(index) ?? this.getRenderer();
          break;
        }
      }
      return xyItemRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 201, (byte) 130, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedDomainAxisSpace(AxisSpace space, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fixedDomainAxisSpace = space;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 191, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedRangeAxisSpace(AxisSpace space, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fixedRangeAxisSpace = space;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool isDomainPannable()
    {
      return this.domainPannable;
    }

    public virtual bool isRangePannable()
    {
      return this.rangePannable;
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 156, (byte) 131, (byte) 115, (byte) 114, (byte) 99, (byte) 163, (byte) 104, (byte) 109, (byte) 136, (byte) 150, (byte) 106, (byte) 130, (byte) 232, (byte) 49, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      int num = useAnchor ? 1 : 0;
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis != null)
        {
          if (num != 0)
          {
            double d = source.getX();
            if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              d = source.getY();
            double anchorValue = valueAxis.java2DToValue(d, info.getDataArea(), this.getDomainAxisEdge());
            valueAxis.resizeRange2(factor, anchorValue);
          }
          else
            valueAxis.resizeRange(factor);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 137, (byte) 163, (byte) 115, (byte) 114, (byte) 99, (byte) 163, (byte) 104, (byte) 109, (byte) 136, (byte) 150, (byte) 106, (byte) 130, (byte) 232, (byte) 49, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      int num = useAnchor ? 1 : 0;
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
        {
          if (num != 0)
          {
            double d = source.getY();
            if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              d = source.getX();
            double anchorValue = valueAxis.java2DToValue(d, info.getDataArea(), this.getRangeAxisEdge());
            valueAxis.resizeRange2(factor, anchorValue);
          }
          else
            valueAxis.resizeRange(factor);
        }
      }
    }

    [LineNumberTable((ushort) 1356)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataset getDataset()
    {
      return this.getDataset(0);
    }

    [LineNumberTable((ushort) 705)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return XYPlot.localizationResources.getString("XY_Plot");
    }

    public virtual RectangleInsets getAxisOffset()
    {
      return this.axisOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 186, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(ValueAxis axis)
    {
      this.setDomainAxis(0, axis);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 240, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxes(ValueAxis[] axes)
    {
      for (int index = 0; index < axes.Length; ++index)
        this.setDomainAxis(index, axes[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 11, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(AxisLocation location)
    {
      this.setDomainAxisLocation(0, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 172, (byte) 162, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      this.setDomainAxisLocation(0, location, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 60, (byte) 112, (byte) 114, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainAxes()
    {
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis != null)
          valueAxis.removeChangeListener((AxisChangeListener) this);
      }
      this.domainAxes.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 116, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(int index, AxisLocation location)
    {
      this.setDomainAxisLocation(index, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 230, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(AxisLocation location)
    {
      this.setRangeAxisLocation(0, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 117, (byte) 130, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      this.setRangeAxisLocation(0, location, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 38, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(int index, ValueAxis axis)
    {
      this.setRangeAxis(index, axis, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 78, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxes(ValueAxis[] axes)
    {
      for (int index = 0; index < axes.Length; ++index)
        this.setRangeAxis(index, axes[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 102, (byte) 112, (byte) 114, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearRangeAxes()
    {
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
          valueAxis.removeChangeListener((AxisChangeListener) this);
      }
      this.rangeAxes.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 159, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(int index, AxisLocation location)
    {
      this.setRangeAxisLocation(index, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 248, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(XYDataset dataset)
    {
      this.setDataset(0, dataset);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 36, (byte) 98, (byte) 112, (byte) 111, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(XYDataset dataset)
    {
      int num = -1;
      for (int index = 0; index < this.datasets.size(); ++index)
      {
        if (dataset == this.datasets.get(index))
        {
          num = index;
          break;
        }
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 251, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderers(XYItemRenderer[] renderers)
    {
      for (int index = 0; index < renderers.Length; ++index)
        this.setRenderer(index, renderers[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 23, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDatasetRenderingOrder(DatasetRenderingOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.datasetRenderingOrder = order;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 52, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesRenderingOrder(SeriesRenderingOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesRenderingOrder = order;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable((ushort) 1718)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndexOf(XYItemRenderer renderer)
    {
      return this.renderers.indexOf((object) renderer);
    }

    public virtual int getWeight()
    {
      return this.weight;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 115, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWeight(int weight)
    {
      this.weight = weight;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 206, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.domainGridlinesVisible ? 1 : 0) == num)
        return;
      this.domainGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 198, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainMinorGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.domainMinorGridlinesVisible ? 1 : 0) == num)
        return;
      this.domainMinorGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 207, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 243, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainMinorGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainMinorGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 53, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainMinorGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainMinorGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 157, (byte) 130, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.rangeGridlinesVisible ? 1 : 0) == num)
        return;
      this.rangeGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 111, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 134, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeMinorGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.rangeMinorGridlinesVisible ? 1 : 0) == num)
        return;
      this.rangeMinorGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 205, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeMinorGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeMinorGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 237, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeMinorGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeMinorGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getDomainZeroBaselineStroke()
    {
      return this.domainZeroBaselineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 42, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainZeroBaselineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainZeroBaselineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getDomainZeroBaselinePaint()
    {
      return this.domainZeroBaselinePaint;
    }

    public virtual Stroke getRangeZeroBaselineStroke()
    {
      return this.rangeZeroBaselineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 127, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeZeroBaselineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeZeroBaselineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getRangeZeroBaselinePaint()
    {
      return this.rangeZeroBaselinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 182, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainTickBandPaint(Paint paint)
    {
      this.domainTickBandPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 206, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeTickBandPaint(Paint paint)
    {
      this.rangeTickBandPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Point2D getQuadrantOrigin()
    {
      return this.quadrantOrigin;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 231, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setQuadrantOrigin(Point2D origin)
    {
      if (origin == null)
      {
        string str = "Null 'origin' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.quadrantOrigin = origin;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 248, (byte) 104, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getQuadrantPaint(int index)
    {
      if (index >= 0 && index <= 3)
        return this.quadrantPaint[index];
      string str = new StringBuffer().append("The index value (").append(index).append(") should be in the range 0 to 3.").toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 9, (byte) 104, (byte) 191, (byte) 16, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setQuadrantPaint(int index, Paint paint)
    {
      if (index < 0 || index > 3)
      {
        string str = new StringBuffer().append("The index value (").append(index).append(") should be in the range 0 to 3.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.quadrantPaint[index] = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 31, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(Marker marker)
    {
      this.addDomainMarker(marker, Layer.__\u003C\u003EFOREGROUND);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 57, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainMarkers()
    {
      if (this.backgroundDomainMarkers != null)
      {
        Iterator iterator = this.backgroundDomainMarkers.keySet().iterator();
        while (iterator.hasNext())
          this.clearDomainMarkers(((Integer) iterator.next()).intValue());
        this.backgroundDomainMarkers.clear();
      }
      if (this.foregroundDomainMarkers != null)
      {
        Iterator iterator = this.foregroundDomainMarkers.keySet().iterator();
        while (iterator.hasNext())
          this.clearDomainMarkers(((Integer) iterator.next()).intValue());
        this.foregroundDomainMarkers.clear();
      }
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 2612)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(Marker marker)
    {
      return (this.removeDomainMarker(marker, Layer.__\u003C\u003EFOREGROUND) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 21, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(Marker marker)
    {
      this.addRangeMarker(marker, Layer.__\u003C\u003EFOREGROUND);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 47, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearRangeMarkers()
    {
      if (this.backgroundRangeMarkers != null)
      {
        Iterator iterator = this.backgroundRangeMarkers.keySet().iterator();
        while (iterator.hasNext())
          this.clearRangeMarkers(((Integer) iterator.next()).intValue());
        this.backgroundRangeMarkers.clear();
      }
      if (this.foregroundRangeMarkers != null)
      {
        Iterator iterator = this.foregroundRangeMarkers.keySet().iterator();
        while (iterator.hasNext())
          this.clearRangeMarkers(((Integer) iterator.next()).intValue());
        this.foregroundRangeMarkers.clear();
      }
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 2848)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(Marker marker)
    {
      return (this.removeRangeMarker(marker, Layer.__\u003C\u003EFOREGROUND) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 2, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(XYAnnotation annotation)
    {
      this.addAnnotation(annotation, true);
    }

    [LineNumberTable((ushort) 2966)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeAnnotation(XYAnnotation annotation)
    {
      return (this.removeAnnotation(annotation, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 81, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearAnnotations()
    {
      this.annotations.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 211, (byte) 117, (byte) 117, (byte) 102, (byte) 193, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 105, (byte) 106, (byte) 109, (byte) 118, (byte) 100, (byte) 201, (byte) 105, (byte) 142, (byte) 200, (byte) 109, (byte) 131, (byte) 103, (byte) 112, (byte) 136, (byte) 112, (byte) 112, (byte) 102, (byte) 104, (byte) 132, (byte) 105, (byte) 218, (byte) 184, (byte) 137, (byte) 104, (byte) 132, (byte) 105, (byte) 218, (byte) 184, (byte) 169, (byte) 109, (byte) 109, (byte) 104, (byte) 136, (byte) 104, (byte) 178, (byte) 148, (byte) 100, (byte) 100, (byte) 249, (byte) 69, (byte) 116, (byte) 100, (byte) 100, (byte) 217, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 112, (byte) 137, (byte) 100, (byte) 112, (byte) 201, (byte) 114, (byte) 48, (byte) 168, (byte) 114, (byte) 48, (byte) 232, (byte) 69, (byte) 99, (byte) 104, (byte) 172, (byte) 109, (byte) 105, (byte) 106, (byte) 100, (byte) 106, (byte) 106, (byte) 245, (byte) 59, (byte) 232, (byte) 75, (byte) 109, (byte) 59, (byte) 232, (byte) 70, (byte) 105, (byte) 106, (byte) 100, (byte) 106, (byte) 106, (byte) 245, (byte) 59, (byte) 232, (byte) 74, (byte) 101, (byte) 172, (byte) 109, (byte) 107, (byte) 106, (byte) 106, (byte) 130, (byte) 100, (byte) 106, (byte) 106, (byte) 245, (byte) 56, (byte) 232, (byte) 77, (byte) 111, (byte) 59, (byte) 232, (byte) 70, (byte) 107, (byte) 106, (byte) 106, (byte) 130, (byte) 100, (byte) 106, (byte) 106, (byte) 245, (byte) 56, (byte) 232, (byte) 80, (byte) 105, (byte) 106, (byte) 106, (byte) 139, (byte) 105, (byte) 182, (byte) 148, (byte) 137, (byte) 110, (byte) 104, (byte) 105, (byte) 104, (byte) 104, (byte) 211, (byte) 105, (byte) 106, (byte) 106, (byte) 139, (byte) 105, (byte) 150, (byte) 148, (byte) 137, (byte) 110, (byte) 104, (byte) 105, (byte) 104, (byte) 104, (byte) 179, (byte) 100, (byte) 169, (byte) 114, (byte) 48, (byte) 168, (byte) 114, (byte) 48, (byte) 200, (byte) 107, (byte) 104, (byte) 136, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (((RectangularShape) area).getWidth() <= 10.0 || ((RectangularShape) area).getHeight() <= 10.0)
        return;
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      Rectangle2D rectangle2D = this.calculateAxisSpace(g2, area).shrink(area, (Rectangle2D) null);
      this.axisOffset.trim(rectangle2D);
      this.createAndAddEntity((Rectangle2D) ((RectangularShape) rectangle2D).clone(), info, (string) null, (string) null);
      if (info != null)
        info.setDataArea(rectangle2D);
      this.drawBackground(g2, rectangle2D);
      Map map = this.drawAxes(g2, area, rectangle2D, info);
      PlotOrientation orientation = this.getOrientation();
      if (anchor != null && !((RectangularShape) rectangle2D).contains(anchor))
        anchor = (Point2D) null;
      CrosshairState crosshairState = new CrosshairState();
      crosshairState.setCrosshairDistance(double.PositiveInfinity);
      crosshairState.setAnchor(anchor);
      crosshairState.setAnchorX(double.NaN);
      crosshairState.setAnchorY(double.NaN);
      if (anchor != null)
      {
        ValueAxis domainAxis = this.getDomainAxis();
        if (domainAxis != null)
        {
          double x = orientation != PlotOrientation.__\u003C\u003EVERTICAL ? domainAxis.java2DToValue(anchor.getY(), rectangle2D, this.getDomainAxisEdge()) : domainAxis.java2DToValue(anchor.getX(), rectangle2D, this.getDomainAxisEdge());
          crosshairState.setAnchorX(x);
        }
        ValueAxis rangeAxis = this.getRangeAxis();
        if (rangeAxis != null)
        {
          double y = orientation != PlotOrientation.__\u003C\u003EVERTICAL ? rangeAxis.java2DToValue(anchor.getX(), rectangle2D, this.getRangeAxisEdge()) : rangeAxis.java2DToValue(anchor.getY(), rectangle2D, this.getRangeAxisEdge());
          crosshairState.setAnchorY(y);
        }
      }
      crosshairState.setCrosshairX(this.getDomainCrosshairValue());
      crosshairState.setCrosshairY(this.getRangeCrosshairValue());
      Shape clip = ((Graphics) g2).getClip();
      Composite composite = g2.getComposite();
      g2.clip((Shape) rectangle2D);
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      AxisState axisState1 = (AxisState) map.get((object) this.getDomainAxis());
      if (axisState1 == null && parentState != null)
        axisState1 = (AxisState) parentState.getSharedAxisStates().get((object) this.getDomainAxis());
      AxisState axisState2 = (AxisState) map.get((object) this.getRangeAxis());
      if (axisState2 == null && parentState != null)
        axisState2 = (AxisState) parentState.getSharedAxisStates().get((object) this.getRangeAxis());
      if (axisState1 != null)
        this.drawDomainTickBands(g2, rectangle2D, axisState1.getTicks());
      if (axisState2 != null)
        this.drawRangeTickBands(g2, rectangle2D, axisState2.getTicks());
      if (axisState1 != null)
      {
        this.drawDomainGridlines(g2, rectangle2D, axisState1.getTicks());
        this.drawZeroDomainBaseline(g2, rectangle2D);
      }
      if (axisState2 != null)
      {
        this.drawRangeGridlines(g2, rectangle2D, axisState2.getTicks());
        this.drawZeroRangeBaseline(g2, rectangle2D);
      }
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawDomainMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EBACKGROUND);
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawRangeMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EBACKGROUND);
      int num1 = 0;
      DatasetRenderingOrder datasetRenderingOrder = this.getDatasetRenderingOrder();
      if (datasetRenderingOrder == DatasetRenderingOrder.__\u003C\u003EFORWARD)
      {
        int num2 = this.renderers.size();
        for (int index = 0; index < num2; ++index)
        {
          XYItemRenderer renderer = this.getRenderer(index);
          if (renderer != null)
          {
            ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
            ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index);
            renderer.drawAnnotations(g2, rectangle2D, domainAxisForDataset, rangeAxisForDataset, Layer.__\u003C\u003EBACKGROUND, info);
          }
        }
        for (int index = 0; index < this.getDatasetCount(); ++index)
          num1 = this.render(g2, rectangle2D, index, info, crosshairState) || num1 != 0 ? 1 : 0;
        for (int index = 0; index < num2; ++index)
        {
          XYItemRenderer renderer = this.getRenderer(index);
          if (renderer != null)
          {
            ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
            ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index);
            renderer.drawAnnotations(g2, rectangle2D, domainAxisForDataset, rangeAxisForDataset, Layer.__\u003C\u003EFOREGROUND, info);
          }
        }
      }
      else if (datasetRenderingOrder == DatasetRenderingOrder.__\u003C\u003EREVERSE)
      {
        int num2 = this.renderers.size();
        int index1 = num2 - 1;
        while (index1 >= 0)
        {
          XYItemRenderer renderer = this.getRenderer(index1);
          if (index1 < this.getDatasetCount() && renderer != null)
          {
            ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index1);
            ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index1);
            renderer.drawAnnotations(g2, rectangle2D, domainAxisForDataset, rangeAxisForDataset, Layer.__\u003C\u003EBACKGROUND, info);
          }
          index1 += -1;
        }
        int index2 = this.getDatasetCount() - 1;
        while (index2 >= 0)
        {
          num1 = this.render(g2, rectangle2D, index2, info, crosshairState) || num1 != 0 ? 1 : 0;
          index2 += -1;
        }
        int index3 = num2 - 1;
        while (index3 >= 0)
        {
          XYItemRenderer renderer = this.getRenderer(index3);
          if (index3 < this.getDatasetCount() && renderer != null)
          {
            ValueAxis domainAxisForDataset = this.getDomainAxisForDataset(index3);
            ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index3);
            renderer.drawAnnotations(g2, rectangle2D, domainAxisForDataset, rangeAxisForDataset, Layer.__\u003C\u003EFOREGROUND, info);
          }
          index3 += -1;
        }
      }
      int domainAxisIndex = crosshairState.getDomainAxisIndex();
      ValueAxis domainAxis1 = this.getDomainAxis(domainAxisIndex);
      RectangleEdge domainAxisEdge = this.getDomainAxisEdge(domainAxisIndex);
      if (!this.domainCrosshairLockedOnData && anchor != null)
      {
        double x = orientation != PlotOrientation.__\u003C\u003EVERTICAL ? domainAxis1.java2DToValue(anchor.getY(), rectangle2D, domainAxisEdge) : domainAxis1.java2DToValue(anchor.getX(), rectangle2D, domainAxisEdge);
        crosshairState.setCrosshairX(x);
      }
      this.setDomainCrosshairValue(crosshairState.getCrosshairX(), false);
      if (this.isDomainCrosshairVisible())
      {
        double domainCrosshairValue = this.getDomainCrosshairValue();
        Paint domainCrosshairPaint = this.getDomainCrosshairPaint();
        Stroke domainCrosshairStroke = this.getDomainCrosshairStroke();
        this.drawDomainCrosshair(g2, rectangle2D, orientation, domainCrosshairValue, domainAxis1, domainCrosshairStroke, domainCrosshairPaint);
      }
      int rangeAxisIndex = crosshairState.getRangeAxisIndex();
      ValueAxis rangeAxis1 = this.getRangeAxis(rangeAxisIndex);
      RectangleEdge rangeAxisEdge = this.getRangeAxisEdge(rangeAxisIndex);
      if (!this.rangeCrosshairLockedOnData && anchor != null)
      {
        double y = orientation != PlotOrientation.__\u003C\u003EVERTICAL ? rangeAxis1.java2DToValue(anchor.getX(), rectangle2D, rangeAxisEdge) : rangeAxis1.java2DToValue(anchor.getY(), rectangle2D, rangeAxisEdge);
        crosshairState.setCrosshairY(y);
      }
      this.setRangeCrosshairValue(crosshairState.getCrosshairY(), false);
      if (this.isRangeCrosshairVisible())
      {
        double rangeCrosshairValue = this.getRangeCrosshairValue();
        Paint rangeCrosshairPaint = this.getRangeCrosshairPaint();
        Stroke rangeCrosshairStroke = this.getRangeCrosshairStroke();
        this.drawRangeCrosshair(g2, rectangle2D, orientation, rangeCrosshairValue, rangeAxis1, rangeCrosshairStroke, rangeCrosshairPaint);
      }
      if (num1 == 0)
        this.drawNoDataMessage(g2, rectangle2D);
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawDomainMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EFOREGROUND);
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawRangeMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EFOREGROUND);
      this.drawAnnotations(g2, rectangle2D, info);
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      this.drawOutline(g2, rectangle2D);
    }

    [LineNumberTable((ushort) 4064)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getDomainMarkers(Layer layer)
    {
      return this.getDomainMarkers(0, layer);
    }

    [LineNumberTable((ushort) 4077)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getRangeMarkers(Layer layer)
    {
      return this.getRangeMarkers(0, layer);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 192, (byte) 103, (byte) 109, (byte) 135, (byte) 111, (byte) 112, (byte) 148, (byte) 104, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontalLine(Graphics2D g2, Rectangle2D dataArea, double value, Stroke stroke, Paint paint)
    {
      ValueAxis valueAxis = this.getRangeAxis();
      if (this.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        valueAxis = this.getDomainAxis();
      if (!valueAxis.getRange().contains(value))
        return;
      double num = valueAxis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003ELEFT);
      Line2D.Double @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 1, (byte) 103, (byte) 109, (byte) 135, (byte) 111, (byte) 144, (byte) 148, (byte) 104, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVerticalLine(Graphics2D g2, Rectangle2D dataArea, double value, Stroke stroke, Paint paint)
    {
      ValueAxis valueAxis = this.getDomainAxis();
      if (this.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        valueAxis = this.getRangeAxis();
      if (!valueAxis.getRange().contains(value))
        return;
      double num = valueAxis.valueToJava2D(value, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
      Line2D.Double @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 64, (byte) 103, (byte) 140, (byte) 103, (byte) 99, (byte) 150, (byte) 199, (byte) 103, (byte) 99, (byte) 151, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void handleClick(int x, int y, PlotRenderingInfo info)
    {
      if (!info.getDataArea().contains((double) x, (double) y))
        return;
      ValueAxis domainAxis = this.getDomainAxis();
      if (domainAxis != null)
        this.setDomainCrosshairValue(domainAxis.java2DToValue((double) x, info.getDataArea(), this.getDomainAxisEdge()));
      ValueAxis rangeAxis = this.getRangeAxis();
      if (rangeAxis == null)
        return;
      this.setRangeCrosshairValue(rangeAxis.java2DToValue((double) y, info.getDataArea(), this.getRangeAxisEdge()));
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 197, (byte) 98, (byte) 102, (byte) 102, (byte) 162, (byte) 105, (byte) 101, (byte) 98, (byte) 148, (byte) 132, (byte) 109, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 226, (byte) 69, (byte) 105, (byte) 101, (byte) 98, (byte) 148, (byte) 100, (byte) 109, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 226, (byte) 70, (byte) 104, (byte) 108, (byte) 110, (byte) 103, (byte) 106, (byte) 99, (byte) 100, (byte) 178, (byte) 240, (byte) 69, (byte) 100, (byte) 178, (byte) 238, (byte) 70, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 162, (byte) 133, (byte) 104, (byte) 105, (byte) 110, (byte) 105, (byte) 99, (byte) 176, (byte) 174, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDataRange(ValueAxis axis)
    {
      Range range1 = (Range) null;
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      int num = 1;
      int domainAxisIndex = this.getDomainAxisIndex(axis);
      if (domainAxisIndex >= 0)
      {
        num = 1;
        ((List) arrayList1).addAll((Collection) this.getDatasetsMappedToDomainAxis(new Integer(domainAxisIndex)));
        if (domainAxisIndex == 0)
        {
          Iterator iterator = this.annotations.iterator();
          while (iterator.hasNext())
          {
            XYAnnotation xyAnnotation = (XYAnnotation) iterator.next();
            if (xyAnnotation is XYAnnotationBoundsInfo)
              ((List) arrayList2).add((object) xyAnnotation);
          }
        }
      }
      int rangeAxisIndex = this.getRangeAxisIndex(axis);
      if (rangeAxisIndex >= 0)
      {
        num = 0;
        ((List) arrayList1).addAll((Collection) this.getDatasetsMappedToRangeAxis(new Integer(rangeAxisIndex)));
        if (rangeAxisIndex == 0)
        {
          Iterator iterator = this.annotations.iterator();
          while (iterator.hasNext())
          {
            XYAnnotation xyAnnotation = (XYAnnotation) iterator.next();
            if (xyAnnotation is XYAnnotationBoundsInfo)
              ((List) arrayList2).add((object) xyAnnotation);
          }
        }
      }
      Iterator iterator1 = ((List) arrayList1).iterator();
label_13:
      while (iterator1.hasNext())
      {
        XYDataset xyDataset = (XYDataset) iterator1.next();
        if (xyDataset != null)
        {
          XYItemRenderer rendererForDataset = this.getRendererForDataset(xyDataset);
          range1 = num == 0 ? (rendererForDataset == null ? Range.combine(range1, DatasetUtilities.findRangeBounds(xyDataset)) : Range.combine(range1, rendererForDataset.findRangeBounds(xyDataset))) : (rendererForDataset == null ? Range.combine(range1, DatasetUtilities.findDomainBounds(xyDataset)) : Range.combine(range1, rendererForDataset.findDomainBounds(xyDataset)));
          if (rendererForDataset is AbstractXYItemRenderer)
          {
            Iterator iterator2 = ((AbstractXYItemRenderer) rendererForDataset).getAnnotations().iterator();
            while (true)
            {
              XYAnnotation xyAnnotation;
              do
              {
                if (iterator2.hasNext())
                  xyAnnotation = (XYAnnotation) iterator2.next();
                else
                  goto label_13;
              }
              while (!(xyAnnotation is XYAnnotationBoundsInfo));
              ((List) arrayList2).add((object) xyAnnotation);
            }
          }
        }
      }
      Iterator iterator3 = ((List) arrayList2).iterator();
      while (iterator3.hasNext())
      {
        XYAnnotationBoundsInfo annotationBoundsInfo = (XYAnnotationBoundsInfo) iterator3.next();
        if (annotationBoundsInfo.getIncludeInDataBounds())
          range1 = num == 0 ? Range.combine(range1, annotationBoundsInfo.getYRange()) : Range.combine(range1, annotationBoundsInfo.getXRange());
      }
      return range1;
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 67, (byte) 104, (byte) 102, (byte) 134, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void rendererChanged(RendererChangeEvent @event)
    {
      if (@event.getSeriesVisibilityChanged())
      {
        this.configureDomainAxes();
        this.configureRangeAxes();
      }
      this.fireChangeEvent();
    }

    public virtual bool isDomainCrosshairLockedOnData()
    {
      return this.domainCrosshairLockedOnData;
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 19, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairLockedOnData(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.domainCrosshairLockedOnData ? 1 : 0) == num)
        return;
      this.domainCrosshairLockedOnData = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 192, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainCrosshairStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual bool isRangeCrosshairLockedOnData()
    {
      return this.rangeCrosshairLockedOnData;
    }

    [LineNumberTable(new byte[] {(byte) 154, (byte) 236, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairLockedOnData(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairLockedOnData ? 1 : 0) == num)
        return;
      this.rangeCrosshairLockedOnData = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 93, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeCrosshairStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual AxisSpace getFixedDomainAxisSpace()
    {
      return this.fixedDomainAxisSpace;
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 149, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedDomainAxisSpace(AxisSpace space)
    {
      this.setFixedDomainAxisSpace(space, true);
    }

    public virtual AxisSpace getFixedRangeAxisSpace()
    {
      return this.fixedRangeAxisSpace;
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 190, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedRangeAxisSpace(AxisSpace space)
    {
      this.setFixedRangeAxisSpace(space, true);
    }

    public virtual void setDomainPannable(bool pannable)
    {
      this.domainPannable = pannable;
    }

    public virtual void setRangePannable(bool pannable)
    {
      this.rangePannable = pannable;
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 14, (byte) 104, (byte) 129, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 130, (byte) 104, (byte) 133, (byte) 232, (byte) 56, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void panDomainAxes(double percent, PlotRenderingInfo info, Point2D source)
    {
      if (!this.isDomainPannable())
        return;
      int domainAxisCount = this.getDomainAxisCount();
      for (int index = 0; index < domainAxisCount; ++index)
      {
        ValueAxis domainAxis = this.getDomainAxis(index);
        if (domainAxis != null)
        {
          if (domainAxis.isInverted())
            percent = -percent;
          domainAxis.pan(percent);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 41, (byte) 104, (byte) 129, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 130, (byte) 104, (byte) 133, (byte) 232, (byte) 56, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void panRangeAxes(double percent, PlotRenderingInfo info, Point2D source)
    {
      if (!this.isRangePannable())
        return;
      int rangeAxisCount = this.getRangeAxisCount();
      for (int index = 0; index < rangeAxisCount; ++index)
      {
        ValueAxis rangeAxis = this.getRangeAxis(index);
        if (rangeAxis != null)
        {
          if (rangeAxis.isInverted())
            percent = -percent;
          rangeAxis.pan(percent);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source)
    {
      this.zoomDomainAxes(factor, info, source, false);
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 125, (byte) 112, (byte) 114, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo info, Point2D source)
    {
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis != null)
          valueAxis.zoomRange(lowerPercent, upperPercent);
      }
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 145, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo info, Point2D source)
    {
      this.zoomRangeAxes(factor, info, source, false);
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 198, (byte) 112, (byte) 114, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double lowerPercent, double upperPercent, PlotRenderingInfo info, Point2D source)
    {
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
          valueAxis.zoomRange(lowerPercent, upperPercent);
      }
    }

    public virtual bool isDomainZoomable()
    {
      return true;
    }

    public virtual bool isRangeZoomable()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 179, (byte) 237, (byte) 98, (byte) 103, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSeriesCount()
    {
      int num = 0;
      XYDataset dataset = this.getDataset();
      if (dataset != null)
        num = dataset.getSeriesCount();
      return num;
    }

    public virtual LegendItemCollection getFixedLegendItems()
    {
      return this.fixedLegendItems;
    }

    [LineNumberTable(new byte[] {(byte) 180, (byte) 10, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedLegendItems(LegendItemCollection items)
    {
      this.fixedLegendItems = items;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 180, (byte) 22, (byte) 104, (byte) 135, (byte) 102, (byte) 108, (byte) 105, (byte) 104, (byte) 102, (byte) 105, (byte) 100, (byte) 137, (byte) 103, (byte) 104, (byte) 105, (byte) 150, (byte) 140, (byte) 100, (byte) 232, (byte) 58, (byte) 232, (byte) 55, (byte) 233, (byte) 86})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      if (this.fixedLegendItems != null)
        return this.fixedLegendItems;
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      int num = this.datasets.size();
      for (int index1 = 0; index1 < num; ++index1)
      {
        XYDataset dataset = this.getDataset(index1);
        if (dataset != null)
        {
          XYItemRenderer xyItemRenderer = this.getRenderer(index1) ?? this.getRenderer(0);
          if (xyItemRenderer != null)
          {
            int seriesCount = dataset.getSeriesCount();
            for (int index2 = 0; index2 < seriesCount; ++index2)
            {
              if (xyItemRenderer.isSeriesVisible(index2) && xyItemRenderer.isSeriesVisibleInLegend(index2))
              {
                LegendItem legendItem = xyItemRenderer.getLegendItem(index1, index2);
                if (legendItem != null)
                  legendItemCollection.add(legendItem);
              }
            }
          }
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 180, (byte) 60, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 142, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 142, (byte) 130, (byte) 142, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 142, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 102, (byte) 151, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYPlot))
        return false;
      XYPlot xyPlot = (XYPlot) obj;
      if (this.weight != xyPlot.weight || this.orientation != xyPlot.orientation || (!this.domainAxes.equals((object) xyPlot.domainAxes) || !this.domainAxisLocations.equals((object) xyPlot.domainAxisLocations)) || (this.rangeCrosshairLockedOnData != xyPlot.rangeCrosshairLockedOnData || this.domainGridlinesVisible != xyPlot.domainGridlinesVisible || (this.rangeGridlinesVisible != xyPlot.rangeGridlinesVisible || this.domainMinorGridlinesVisible != xyPlot.domainMinorGridlinesVisible)) || (this.rangeMinorGridlinesVisible != xyPlot.rangeMinorGridlinesVisible || this.domainZeroBaselineVisible != xyPlot.domainZeroBaselineVisible || (this.rangeZeroBaselineVisible != xyPlot.rangeZeroBaselineVisible || this.domainCrosshairVisible != xyPlot.domainCrosshairVisible) || (this.domainCrosshairValue != xyPlot.domainCrosshairValue || this.domainCrosshairLockedOnData != xyPlot.domainCrosshairLockedOnData || (this.rangeCrosshairVisible != xyPlot.rangeCrosshairVisible || this.rangeCrosshairValue != xyPlot.rangeCrosshairValue))) || (!ObjectUtilities.equal((object) this.axisOffset, (object) xyPlot.axisOffset) || !ObjectUtilities.equal((object) this.renderers, (object) xyPlot.renderers) || (!ObjectUtilities.equal((object) this.rangeAxes, (object) xyPlot.rangeAxes) || !this.rangeAxisLocations.equals((object) xyPlot.rangeAxisLocations)) || (!ObjectUtilities.equal((object) this.datasetToDomainAxesMap, (object) xyPlot.datasetToDomainAxesMap) || !ObjectUtilities.equal((object) this.datasetToRangeAxesMap, (object) xyPlot.datasetToRangeAxesMap) || (!ObjectUtilities.equal((object) this.domainGridlineStroke, (object) xyPlot.domainGridlineStroke) || !PaintUtilities.equal(this.domainGridlinePaint, xyPlot.domainGridlinePaint))) || (!ObjectUtilities.equal((object) this.rangeGridlineStroke, (object) xyPlot.rangeGridlineStroke) || !PaintUtilities.equal(this.rangeGridlinePaint, xyPlot.rangeGridlinePaint) || (!ObjectUtilities.equal((object) this.domainMinorGridlineStroke, (object) xyPlot.domainMinorGridlineStroke) || !PaintUtilities.equal(this.domainMinorGridlinePaint, xyPlot.domainMinorGridlinePaint)) || (!ObjectUtilities.equal((object) this.rangeMinorGridlineStroke, (object) xyPlot.rangeMinorGridlineStroke) || !PaintUtilities.equal(this.rangeMinorGridlinePaint, xyPlot.rangeMinorGridlinePaint) || (!PaintUtilities.equal(this.domainZeroBaselinePaint, xyPlot.domainZeroBaselinePaint) || !ObjectUtilities.equal((object) this.domainZeroBaselineStroke, (object) xyPlot.domainZeroBaselineStroke))))) || (!PaintUtilities.equal(this.rangeZeroBaselinePaint, xyPlot.rangeZeroBaselinePaint) || !ObjectUtilities.equal((object) this.rangeZeroBaselineStroke, (object) xyPlot.rangeZeroBaselineStroke) || (!ObjectUtilities.equal((object) this.domainCrosshairStroke, (object) xyPlot.domainCrosshairStroke) || !PaintUtilities.equal(this.domainCrosshairPaint, xyPlot.domainCrosshairPaint)) || (!ObjectUtilities.equal((object) this.rangeCrosshairStroke, (object) xyPlot.rangeCrosshairStroke) || !PaintUtilities.equal(this.rangeCrosshairPaint, xyPlot.rangeCrosshairPaint) || (!ObjectUtilities.equal((object) this.foregroundDomainMarkers, (object) xyPlot.foregroundDomainMarkers) || !ObjectUtilities.equal((object) this.backgroundDomainMarkers, (object) xyPlot.backgroundDomainMarkers))) || (!ObjectUtilities.equal((object) this.foregroundRangeMarkers, (object) xyPlot.foregroundRangeMarkers) || !ObjectUtilities.equal((object) this.backgroundRangeMarkers, (object) xyPlot.backgroundRangeMarkers) || (!ObjectUtilities.equal((object) this.foregroundDomainMarkers, (object) xyPlot.foregroundDomainMarkers) || !ObjectUtilities.equal((object) this.backgroundDomainMarkers, (object) xyPlot.backgroundDomainMarkers)) || (!ObjectUtilities.equal((object) this.foregroundRangeMarkers, (object) xyPlot.foregroundRangeMarkers) || !ObjectUtilities.equal((object) this.backgroundRangeMarkers, (object) xyPlot.backgroundRangeMarkers) || (!ObjectUtilities.equal((object) this.annotations, (object) xyPlot.annotations) || !PaintUtilities.equal(this.domainTickBandPaint, xyPlot.domainTickBandPaint)))) || (!PaintUtilities.equal(this.rangeTickBandPaint, xyPlot.rangeTickBandPaint) || !this.quadrantOrigin.equals((object) xyPlot.quadrantOrigin))))
        return false;
      for (int index = 0; index < 4; ++index)
      {
        if (!PaintUtilities.equal(this.quadrantPaint[index], xyPlot.quadrantPaint[index]))
          return false;
      }
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 181, (byte) 12, (byte) 108, (byte) 118, (byte) 112, (byte) 114, (byte) 99, (byte) 108, (byte) 109, (byte) 103, (byte) 231, (byte) 58, (byte) 233, (byte) 73, (byte) 182, (byte) 118, (byte) 112, (byte) 114, (byte) 99, (byte) 108, (byte) 109, (byte) 103, (byte) 231, (byte) 58, (byte) 233, (byte) 73, (byte) 214, (byte) 118, (byte) 112, (byte) 105, (byte) 100, (byte) 232, (byte) 61, (byte) 230, (byte) 71, (byte) 107, (byte) 113, (byte) 107, (byte) 145, (byte) 118, (byte) 112, (byte) 115, (byte) 105, (byte) 105, (byte) 243, (byte) 60, (byte) 230, (byte) 71, (byte) 150, (byte) 150, (byte) 150, (byte) 150, (byte) 118, (byte) 104, (byte) 182, (byte) 104, (byte) 214, (byte) 150, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYPlot xyPlot = (XYPlot) base.clone();
      xyPlot.domainAxes = (ObjectList) ObjectUtilities.clone((object) this.domainAxes);
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        ValueAxis valueAxis1 = (ValueAxis) this.domainAxes.get(index);
        if (valueAxis1 != null)
        {
          ValueAxis valueAxis2 = (ValueAxis) valueAxis1.clone();
          xyPlot.domainAxes.set(index, (object) valueAxis2);
          valueAxis2.setPlot((Plot) xyPlot);
          valueAxis2.addChangeListener((AxisChangeListener) xyPlot);
        }
      }
      xyPlot.domainAxisLocations = (ObjectList) this.domainAxisLocations.clone();
      xyPlot.rangeAxes = (ObjectList) ObjectUtilities.clone((object) this.rangeAxes);
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis1 = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis1 != null)
        {
          ValueAxis valueAxis2 = (ValueAxis) valueAxis1.clone();
          xyPlot.rangeAxes.set(index, (object) valueAxis2);
          valueAxis2.setPlot((Plot) xyPlot);
          valueAxis2.addChangeListener((AxisChangeListener) xyPlot);
        }
      }
      xyPlot.rangeAxisLocations = (ObjectList) ObjectUtilities.clone((object) this.rangeAxisLocations);
      xyPlot.datasets = (ObjectList) ObjectUtilities.clone((object) this.datasets);
      for (int index = 0; index < xyPlot.datasets.size(); ++index)
      {
        XYDataset dataset = this.getDataset(index);
        if (dataset != null)
          dataset.addChangeListener((DatasetChangeListener) xyPlot);
      }
      xyPlot.datasetToDomainAxesMap = (Map) new TreeMap();
      xyPlot.datasetToDomainAxesMap.putAll(this.datasetToDomainAxesMap);
      xyPlot.datasetToRangeAxesMap = (Map) new TreeMap();
      xyPlot.datasetToRangeAxesMap.putAll(this.datasetToRangeAxesMap);
      xyPlot.renderers = (ObjectList) ObjectUtilities.clone((object) this.renderers);
      for (int index = 0; index < this.renderers.size(); ++index)
      {
        XYItemRenderer xyItemRenderer = (XYItemRenderer) this.renderers.get(index);
        if (xyItemRenderer is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) xyItemRenderer;
          xyPlot.renderers.set(index, publicCloneable.clone());
        }
      }
      xyPlot.foregroundDomainMarkers = (Map) ObjectUtilities.clone((object) this.foregroundDomainMarkers);
      xyPlot.backgroundDomainMarkers = (Map) ObjectUtilities.clone((object) this.backgroundDomainMarkers);
      xyPlot.foregroundRangeMarkers = (Map) ObjectUtilities.clone((object) this.foregroundRangeMarkers);
      xyPlot.backgroundRangeMarkers = (Map) ObjectUtilities.clone((object) this.backgroundRangeMarkers);
      xyPlot.annotations = (List) ObjectUtilities.deepClone((Collection) this.annotations);
      if (this.fixedDomainAxisSpace != null)
        xyPlot.fixedDomainAxisSpace = (AxisSpace) ObjectUtilities.clone((object) this.fixedDomainAxisSpace);
      if (this.fixedRangeAxisSpace != null)
        xyPlot.fixedRangeAxisSpace = (AxisSpace) ObjectUtilities.clone((object) this.fixedRangeAxisSpace);
      xyPlot.quadrantOrigin = (Point2D) ObjectUtilities.clone((object) this.quadrantOrigin);
      xyPlot.quadrantPaint = (Paint[]) this.quadrantPaint.Clone();
      return (object) xyPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 181, (byte) 94, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 46, (byte) 166, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.domainGridlineStroke, obj0);
      SerialUtilities.writePaint(this.domainGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeGridlineStroke, obj0);
      SerialUtilities.writePaint(this.rangeGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.domainMinorGridlineStroke, obj0);
      SerialUtilities.writePaint(this.domainMinorGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeMinorGridlineStroke, obj0);
      SerialUtilities.writePaint(this.rangeMinorGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeZeroBaselineStroke, obj0);
      SerialUtilities.writePaint(this.rangeZeroBaselinePaint, obj0);
      SerialUtilities.writeStroke(this.domainCrosshairStroke, obj0);
      SerialUtilities.writePaint(this.domainCrosshairPaint, obj0);
      SerialUtilities.writeStroke(this.rangeCrosshairStroke, obj0);
      SerialUtilities.writePaint(this.rangeCrosshairPaint, obj0);
      SerialUtilities.writePaint(this.domainTickBandPaint, obj0);
      SerialUtilities.writePaint(this.rangeTickBandPaint, obj0);
      SerialUtilities.writePoint2D(this.quadrantOrigin, obj0);
      for (int index = 0; index < 4; ++index)
        SerialUtilities.writePaint(this.quadrantPaint[index], obj0);
      SerialUtilities.writeStroke(this.domainZeroBaselineStroke, obj0);
      SerialUtilities.writePaint(this.domainZeroBaselinePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 181, (byte) 130, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 46, (byte) 198, (byte) 108, (byte) 204, (byte) 108, (byte) 102, (byte) 114, (byte) 99, (byte) 103, (byte) 231, (byte) 60, (byte) 230, (byte) 71, (byte) 108, (byte) 102, (byte) 115, (byte) 100, (byte) 104, (byte) 232, (byte) 60, (byte) 230, (byte) 71, (byte) 108, (byte) 104, (byte) 116, (byte) 100, (byte) 232, (byte) 61, (byte) 232, (byte) 70, (byte) 109, (byte) 105, (byte) 116, (byte) 100, (byte) 232, (byte) 61, (byte) 232, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.domainGridlineStroke = SerialUtilities.readStroke(obj0);
      this.domainGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeGridlineStroke = SerialUtilities.readStroke(obj0);
      this.rangeGridlinePaint = SerialUtilities.readPaint(obj0);
      this.domainMinorGridlineStroke = SerialUtilities.readStroke(obj0);
      this.domainMinorGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeMinorGridlineStroke = SerialUtilities.readStroke(obj0);
      this.rangeMinorGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeZeroBaselineStroke = SerialUtilities.readStroke(obj0);
      this.rangeZeroBaselinePaint = SerialUtilities.readPaint(obj0);
      this.domainCrosshairStroke = SerialUtilities.readStroke(obj0);
      this.domainCrosshairPaint = SerialUtilities.readPaint(obj0);
      this.rangeCrosshairStroke = SerialUtilities.readStroke(obj0);
      this.rangeCrosshairPaint = SerialUtilities.readPaint(obj0);
      this.domainTickBandPaint = SerialUtilities.readPaint(obj0);
      this.rangeTickBandPaint = SerialUtilities.readPaint(obj0);
      this.quadrantOrigin = SerialUtilities.readPoint2D(obj0);
      this.quadrantPaint = new Paint[4];
      for (int index = 0; index < 4; ++index)
        this.quadrantPaint[index] = SerialUtilities.readPaint(obj0);
      this.domainZeroBaselineStroke = SerialUtilities.readStroke(obj0);
      this.domainZeroBaselinePaint = SerialUtilities.readPaint(obj0);
      int num1 = this.domainAxes.size();
      for (int index = 0; index < num1; ++index)
      {
        Axis axis = (Axis) this.domainAxes.get(index);
        if (axis != null)
        {
          axis.setPlot((Plot) this);
          axis.addChangeListener((AxisChangeListener) this);
        }
      }
      int num2 = this.rangeAxes.size();
      for (int index = 0; index < num2; ++index)
      {
        Axis axis = (Axis) this.rangeAxes.get(index);
        if (axis != null)
        {
          axis.setPlot((Plot) this);
          axis.addChangeListener((AxisChangeListener) this);
        }
      }
      int num3 = this.datasets.size();
      for (int index = 0; index < num3; ++index)
      {
        Dataset dataset = (Dataset) this.datasets.get(index);
        if (dataset != null)
          dataset.addChangeListener((DatasetChangeListener) this);
      }
      int num4 = this.renderers.size();
      for (int index = 0; index < num4; ++index)
      {
        XYItemRenderer xyItemRenderer = (XYItemRenderer) this.renderers.get(index);
        if (xyItemRenderer != null)
          xyItemRenderer.addChangeListener((RendererChangeListener) this);
      }
    }
  }
}
