// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CategoryPlot
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
using org.jfree.chart.renderer.category;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
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
  public class CategoryPlot : Plot, ValueAxisPlot, Pannable, Zoomable, RendererChangeListener, EventListener, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -3537691700434728188L;
    public const bool DEFAULT_DOMAIN_GRIDLINES_VISIBLE = false;
    public const bool DEFAULT_RANGE_GRIDLINES_VISIBLE = true;
    internal static Stroke __\u003C\u003EDEFAULT_GRIDLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    internal static Font __\u003C\u003EDEFAULT_VALUE_LABEL_FONT;
    public const bool DEFAULT_CROSSHAIR_VISIBLE = false;
    internal static Stroke __\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
    protected internal static ResourceBundle localizationResources;
    private PlotOrientation orientation;
    private RectangleInsets axisOffset;
    private ObjectList domainAxes;
    private ObjectList domainAxisLocations;
    private bool drawSharedDomainAxis;
    private ObjectList rangeAxes;
    private ObjectList rangeAxisLocations;
    private ObjectList datasets;
    private TreeMap datasetToDomainAxesMap;
    private TreeMap datasetToRangeAxesMap;
    private ObjectList renderers;
    private DatasetRenderingOrder renderingOrder;
    private SortOrder columnRenderingOrder;
    private SortOrder rowRenderingOrder;
    private bool domainGridlinesVisible;
    private CategoryAnchor domainGridlinePosition;
    [NonSerialized]
    private Stroke domainGridlineStroke;
    [NonSerialized]
    private Paint domainGridlinePaint;
    private bool rangeZeroBaselineVisible;
    [NonSerialized]
    private Stroke rangeZeroBaselineStroke;
    [NonSerialized]
    private Paint rangeZeroBaselinePaint;
    private bool rangeGridlinesVisible;
    [NonSerialized]
    private Stroke rangeGridlineStroke;
    [NonSerialized]
    private Paint rangeGridlinePaint;
    private bool rangeMinorGridlinesVisible;
    [NonSerialized]
    private Stroke rangeMinorGridlineStroke;
    [NonSerialized]
    private Paint rangeMinorGridlinePaint;
    private double anchorValue;
    private int crosshairDatasetIndex;
    private bool domainCrosshairVisible;
    private IComparable domainCrosshairRowKey;
    private IComparable domainCrosshairColumnKey;
    [NonSerialized]
    private Stroke domainCrosshairStroke;
    [NonSerialized]
    private Paint domainCrosshairPaint;
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
    private int weight;
    private AxisSpace fixedDomainAxisSpace;
    private AxisSpace fixedRangeAxisSpace;
    private LegendItemCollection fixedLegendItems;
    private bool rangePannable;

    [Modifiers]
    public static Stroke DEFAULT_GRIDLINE_STROKE
    {
      [HideFromJava] get
      {
        return CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRIDLINE_PAINT
    {
      [HideFromJava] get
      {
        return CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      }
    }

    [Modifiers]
    public static Font DEFAULT_VALUE_LABEL_FONT
    {
      [HideFromJava] get
      {
        return CategoryPlot.__\u003C\u003EDEFAULT_VALUE_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_CROSSHAIR_STROKE
    {
      [HideFromJava] get
      {
        return CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_CROSSHAIR_PAINT
    {
      [HideFromJava] get
      {
        return CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 75, (byte) 69, (byte) 255, (byte) 18, (byte) 69, (byte) 170, (byte) 242, (byte) 79, (byte) 234, (byte) 72, (byte) 170})]
    static CategoryPlot()
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
      CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE = (Stroke) new BasicStroke((float) num1, num2, num3, (float) num4, numArray, (float) num7);
      CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT = (Paint) Color.lightGray;
      CategoryPlot.__\u003C\u003EDEFAULT_VALUE_LABEL_FONT = new Font("SansSerif", 0, 10);
      CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT = (Paint) Color.blue;
      CategoryPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 232, (byte) 159, (byte) 40, (byte) 235, (byte) 71, (byte) 235, (byte) 70, (byte) 235, (byte) 160, (byte) 135, (byte) 231, (byte) 160, (byte) 70, (byte) 171, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 107, (byte) 139, (byte) 139, (byte) 107, (byte) 109, (byte) 99, (byte) 167, (byte) 139, (byte) 108, (byte) 140, (byte) 110, (byte) 100, (byte) 104, (byte) 168, (byte) 109, (byte) 104, (byte) 99, (byte) 103, (byte) 135, (byte) 135, (byte) 109, (byte) 104, (byte) 99, (byte) 103, (byte) 167, (byte) 102, (byte) 134, (byte) 103, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 144, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 140, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 108, (byte) 107, (byte) 139, (byte) 139, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryPlot(CategoryDataset dataset, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryItemRenderer renderer)
    {
      CategoryPlot categoryPlot = this;
      this.renderingOrder = DatasetRenderingOrder.__\u003C\u003EREVERSE;
      this.columnRenderingOrder = SortOrder.__\u003C\u003EASCENDING;
      this.rowRenderingOrder = SortOrder.__\u003C\u003EASCENDING;
      this.rangeCrosshairLockedOnData = true;
      this.orientation = PlotOrientation.__\u003C\u003EVERTICAL;
      this.domainAxes = new ObjectList();
      this.domainAxisLocations = new ObjectList();
      this.rangeAxes = new ObjectList();
      this.rangeAxisLocations = new ObjectList();
      this.datasetToDomainAxesMap = new TreeMap();
      this.datasetToRangeAxesMap = new TreeMap();
      this.renderers = new ObjectList();
      this.datasets = new ObjectList();
      this.datasets.set(0, (object) dataset);
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.axisOffset = RectangleInsets.__\u003C\u003EZERO_INSETS;
      this.setDomainAxisLocation(AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT, false);
      this.setRangeAxisLocation(AxisLocation.__\u003C\u003ETOP_OR_LEFT, false);
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
      this.drawSharedDomainAxis = false;
      this.rangeAxes.set(0, (object) rangeAxis);
      this.mapDatasetToRangeAxis(0, 0);
      if (rangeAxis != null)
      {
        rangeAxis.setPlot((Plot) this);
        rangeAxis.addChangeListener((AxisChangeListener) this);
      }
      this.configureDomainAxes();
      this.configureRangeAxes();
      this.domainGridlinesVisible = false;
      this.domainGridlinePosition = CategoryAnchor.__\u003C\u003EMIDDLE;
      this.domainGridlineStroke = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.domainGridlinePaint = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      this.rangeZeroBaselineVisible = false;
      this.rangeZeroBaselinePaint = (Paint) Color.black;
      this.rangeZeroBaselineStroke = (Stroke) new BasicStroke(0.5f);
      this.rangeGridlinesVisible = true;
      this.rangeGridlineStroke = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.rangeGridlinePaint = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      this.rangeMinorGridlinesVisible = false;
      this.rangeMinorGridlineStroke = CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.rangeMinorGridlinePaint = (Paint) Color.white;
      this.foregroundDomainMarkers = (Map) new HashMap();
      this.backgroundDomainMarkers = (Map) new HashMap();
      this.foregroundRangeMarkers = (Map) new HashMap();
      this.backgroundRangeMarkers = (Map) new HashMap();
      this.anchorValue = 0.0;
      this.domainCrosshairVisible = false;
      this.domainCrosshairStroke = CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      this.domainCrosshairPaint = CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      this.rangeCrosshairVisible = false;
      this.rangeCrosshairValue = 0.0;
      this.rangeCrosshairStroke = CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_STROKE;
      this.rangeCrosshairPaint = CategoryPlot.__\u003C\u003EDEFAULT_CROSSHAIR_PAINT;
      this.annotations = (List) new ArrayList();
      this.rangePannable = false;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 172, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryPlot()
      : this((CategoryDataset) null, (CategoryAxis) null, (ValueAxis) null, (CategoryItemRenderer) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 50, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
        this.orientation = orientation;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 131, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRowRenderingOrder(SortOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rowRenderingOrder = order;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 100, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColumnRenderingOrder(SortOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.columnRenderingOrder = order;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 35, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 169, (byte) 221, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(Marker marker, Layer layer)
    {
      this.addRangeMarker(0, marker, layer);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 77, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 166, (byte) 241, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 167, (byte) 159, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 167, (byte) 78, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable((ushort) 965)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDomainAxisCount()
    {
      return this.domainAxes.size();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 107, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryAxis getDomainAxis(int index)
    {
      CategoryAxis categoryAxis = (CategoryAxis) null;
      if (index < this.domainAxes.size())
        categoryAxis = (CategoryAxis) this.domainAxes.get(index);
      if (categoryAxis == null)
      {
        Plot parent = this.getParent();
        if (parent is CategoryPlot)
          categoryAxis = ((CategoryPlot) parent).getDomainAxis(index);
      }
      return categoryAxis;
    }

    [LineNumberTable((ushort) 1243)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRangeAxisCount()
    {
      return this.rangeAxes.size();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 132, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxis(int index)
    {
      ValueAxis valueAxis = (ValueAxis) null;
      if (index < this.rangeAxes.size())
        valueAxis = (ValueAxis) this.rangeAxes.get(index);
      if (valueAxis == null)
      {
        Plot parent = this.getParent();
        if (parent is CategoryPlot)
          valueAxis = ((CategoryPlot) parent).getRangeAxis(index);
      }
      return valueAxis;
    }

    [LineNumberTable((ushort) 1539)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRendererCount()
    {
      return this.renderers.size();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 169, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemRenderer getRenderer(int index)
    {
      CategoryItemRenderer categoryItemRenderer = (CategoryItemRenderer) null;
      if (this.renderers.size() > index)
        categoryItemRenderer = (CategoryItemRenderer) this.renderers.get(index);
      return categoryItemRenderer;
    }

    [LineNumberTable((ushort) 1281)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryDataset getDataset()
    {
      return this.getDataset(0);
    }

    public virtual PlotOrientation getOrientation()
    {
      return this.orientation;
    }

    [LineNumberTable((ushort) 841)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getDomainAxisLocation()
    {
      return this.getDomainAxisLocation(0);
    }

    [LineNumberTable((ushort) 1124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getRangeAxisLocation()
    {
      return this.getRangeAxisLocation(0);
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 206, (byte) 102, (byte) 109, (byte) 104, (byte) 103, (byte) 104, (byte) 141, (byte) 110, (byte) 107, (byte) 106, (byte) 233, (byte) 61, (byte) 232, (byte) 70, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getCategoriesForAxis(CategoryAxis axis)
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = this.datasetsMappedToDomainAxis(this.domainAxes.indexOf((object) axis)).iterator();
label_1:
      while (iterator.hasNext())
      {
        CategoryDataset categoryDataset = (CategoryDataset) iterator.next();
        int i = 0;
        while (true)
        {
          if (i < categoryDataset.getColumnCount())
          {
            IComparable columnKey = categoryDataset.getColumnKey(i);
            if (!((List) arrayList).contains((object) columnKey))
              ((List) arrayList).add((object) columnKey);
            ++i;
          }
          else
            goto label_1;
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable((ushort) 1550)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemRenderer getRenderer()
    {
      return this.getRenderer(0);
    }

    [LineNumberTable((ushort) 1003)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxis()
    {
      return this.getRangeAxis(0);
    }

    [LineNumberTable((ushort) 720)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryAxis getDomainAxis()
    {
      return this.getDomainAxis(0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 177, (byte) 162, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      this.setDomainAxisLocation(0, location, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 106, (byte) 162, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(AxisLocation location, bool notify)
    {
      int num = notify ? 1 : 0;
      this.setRangeAxisLocation(0, location, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 244, (byte) 103, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToDomainAxis(int index, int axisIndex)
    {
      ArrayList arrayList = new ArrayList(1);
      ((List) arrayList).add((object) new Integer(axisIndex));
      this.mapDatasetToDomainAxes(index, (List) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 83, (byte) 103, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToRangeAxis(int index, int axisIndex)
    {
      ArrayList arrayList = new ArrayList(1);
      ((List) arrayList).add((object) new Integer(axisIndex));
      this.mapDatasetToRangeAxes(index, (List) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 105, (byte) 112, (byte) 114, (byte) 99, (byte) 230, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void configureDomainAxes()
    {
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
        if (categoryAxis != null)
          categoryAxis.configure();
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 127, (byte) 112, (byte) 114, (byte) 99, (byte) 230, (byte) 61, (byte) 230, (byte) 70})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 143, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(int index, CategoryAxis axis)
    {
      this.setDomainAxis(index, axis, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 203, (byte) 98, (byte) 114, (byte) 99, (byte) 135, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 102, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(int index, CategoryAxis axis, bool notify)
    {
      int num = notify ? 1 : 0;
      CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
      if (categoryAxis != null)
        categoryAxis.removeChangeListener((AxisChangeListener) this);
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 228, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getDomainAxisLocation(int index)
    {
      AxisLocation axisLocation = (AxisLocation) null;
      if (index < this.domainAxisLocations.size())
        axisLocation = (AxisLocation) this.domainAxisLocations.get(index);
      if (axisLocation == null)
        axisLocation = AxisLocation.getOpposite(this.getDomainAxisLocation(0));
      return axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 168, (byte) 66, (byte) 102, (byte) 176, (byte) 109, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 66, (byte) 98, (byte) 104, (byte) 99, (byte) 175, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getDomainAxisEdge(int index)
    {
      AxisLocation domainAxisLocation = this.getDomainAxisLocation(index);
      return domainAxisLocation == null ? RectangleEdge.opposite(this.getDomainAxisEdge(0)) : Plot.resolveDomainAxisLocation(domainAxisLocation, this.orientation);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 164, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(int index, ValueAxis axis)
    {
      this.setRangeAxis(index, axis, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 134, (byte) 130, (byte) 114, (byte) 99, (byte) 135, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 102, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(int index, ValueAxis axis, bool notify)
    {
      int num = notify ? 1 : 0;
      ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
      if (valueAxis != null)
        valueAxis.removeChangeListener((AxisChangeListener) this);
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 222, (byte) 99, (byte) 144, (byte) 109, (byte) 100, (byte) 103, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRangeAxisIndex(ValueAxis axis)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = this.rangeAxes.indexOf((object) axis);
        if (num < 0)
        {
          Plot parent = this.getParent();
          if (parent is CategoryPlot)
            num = ((CategoryPlot) parent).getRangeAxisIndex(axis);
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 255, (byte) 98, (byte) 110, (byte) 146, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getRangeAxisLocation(int index)
    {
      AxisLocation axisLocation = (AxisLocation) null;
      if (index < this.rangeAxisLocations.size())
        axisLocation = (AxisLocation) this.rangeAxisLocations.get(index);
      if (axisLocation == null)
        axisLocation = AxisLocation.getOpposite(this.getRangeAxisLocation(0));
      return axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 98, (byte) 98, (byte) 102, (byte) 176, (byte) 109, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 90, (byte) 104, (byte) 141, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getRangeAxisEdge(int index)
    {
      return Plot.resolveRangeAxisLocation(this.getRangeAxisLocation(index), this.orientation) ?? RectangleEdge.opposite(this.getRangeAxisEdge(0));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 156, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryDataset getDataset(int index)
    {
      CategoryDataset categoryDataset = (CategoryDataset) null;
      if (this.datasets.size() > index)
        categoryDataset = (CategoryDataset) this.datasets.get(index);
      return categoryDataset;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 188, (byte) 114, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 199, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(int index, CategoryDataset dataset)
    {
      CategoryDataset categoryDataset = (CategoryDataset) this.datasets.get(index);
      if (categoryDataset != null)
        categoryDataset.removeChangeListener((DatasetChangeListener) this);
      this.datasets.set(index, (object) dataset);
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 128, (byte) 108, (byte) 102, (byte) 104, (byte) 99, (byte) 230, (byte) 61, (byte) 230, (byte) 70, (byte) 104, (byte) 174, (byte) 103, (byte) 107, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void datasetChanged(DatasetChangeEvent @event)
    {
      int num = this.rangeAxes.size();
      for (int index = 0; index < num; ++index)
      {
        ValueAxis rangeAxis = this.getRangeAxis(index);
        if (rangeAxis != null)
          rangeAxis.configure();
      }
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 4, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 147, (byte) 117})]
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 25, (byte) 99, (byte) 129, (byte) 103, (byte) 99, (byte) 144, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 176, (byte) 105, (byte) 144, (byte) 232, (byte) 55, (byte) 230, (byte) 75})]
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 99, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 147, (byte) 117})]
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

    [LineNumberTable(new byte[] {(byte) 157, (byte) 246, (byte) 66, (byte) 146, (byte) 99, (byte) 199, (byte) 109, (byte) 99, (byte) 103, (byte) 167, (byte) 102, (byte) 134, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(int index, CategoryItemRenderer renderer, bool notify)
    {
      int num = notify ? 1 : 0;
      CategoryItemRenderer categoryItemRenderer = (CategoryItemRenderer) this.renderers.get(index);
      if (categoryItemRenderer != null)
        categoryItemRenderer.removeChangeListener((RendererChangeListener) this);
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

    [LineNumberTable(new byte[] {(byte) 177, (byte) 229, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAnchorValue(double value)
    {
      this.setAnchorValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 252, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairValue(double value)
    {
      this.setRangeCrosshairValue(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 199, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(CategoryMarker marker, Layer layer)
    {
      this.addDomainMarker(0, marker, layer);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 216, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(int index, CategoryMarker marker, Layer layer)
    {
      this.addDomainMarker(index, marker, layer, true);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 55, (byte) 163, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 107, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 159, (byte) 3, (byte) 104, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 157, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(int index, CategoryMarker marker, Layer layer, bool notify)
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

    [LineNumberTable(new byte[] {(byte) 169, (byte) 83, (byte) 103, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104})]
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
      if (this.foregroundDomainMarkers != null)
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

    [LineNumberTable(new byte[] {(byte) 169, (byte) 61, (byte) 98, (byte) 103, (byte) 104, (byte) 148, (byte) 104, (byte) 146, (byte) 99, (byte) 135})]
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

    [LineNumberTable((ushort) 2557)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(Marker marker, Layer layer)
    {
      return (this.removeDomainMarker(0, marker, layer) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 2574)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(int index, Marker marker, Layer layer)
    {
      return (this.removeDomainMarker(index, marker, layer, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 6, (byte) 131, (byte) 104, (byte) 217, (byte) 183, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 134})]
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

    [LineNumberTable(new byte[] {(byte) 169, (byte) 238, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(int index, Marker marker, Layer layer)
    {
      this.addRangeMarker(index, marker, layer, true);
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 241, (byte) 131, (byte) 107, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 159, (byte) 3, (byte) 104, (byte) 151, (byte) 104, (byte) 102, (byte) 152, (byte) 157, (byte) 103, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 170, (byte) 101, (byte) 103, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104, (byte) 146, (byte) 99, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 166, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 170, (byte) 79, (byte) 98, (byte) 103, (byte) 104, (byte) 148, (byte) 104, (byte) 146, (byte) 99, (byte) 135})]
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

    [LineNumberTable((ushort) 2835)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(Marker marker, Layer layer)
    {
      return (this.removeRangeMarker(0, marker, layer) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 2854)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(int index, Marker marker, Layer layer)
    {
      return (this.removeRangeMarker(index, marker, layer, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 192, (byte) 163, (byte) 99, (byte) 176, (byte) 104, (byte) 217, (byte) 183, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 134})]
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

    [LineNumberTable(new byte[] {(byte) 156, (byte) 170, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairRowKey(IComparable key, bool notify)
    {
      int num = notify ? 1 : 0;
      this.domainCrosshairRowKey = key;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 160, (byte) 130, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairColumnKey(IComparable key, bool notify)
    {
      int num = notify ? 1 : 0;
      this.domainCrosshairColumnKey = key;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 150, (byte) 98, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCrosshairDatasetIndex(int index, bool notify)
    {
      int num = notify ? 1 : 0;
      this.crosshairDatasetIndex = index;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 111, (byte) 98, (byte) 105, (byte) 107, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 156, (byte) 86, (byte) 130, (byte) 99, (byte) 144, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(CategoryAnnotation annotation, bool notify)
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

    [LineNumberTable(new byte[] {(byte) 156, (byte) 77, (byte) 130, (byte) 99, (byte) 144, (byte) 109, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeAnnotation(CategoryAnnotation annotation, bool notify)
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

    [LineNumberTable(new byte[] {(byte) 172, (byte) 235, (byte) 99, (byte) 199, (byte) 107, (byte) 109, (byte) 150, (byte) 187, (byte) 112, (byte) 150, (byte) 248, (byte) 70, (byte) 112, (byte) 114, (byte) 99, (byte) 104, (byte) 237, (byte) 60, (byte) 230, (byte) 72})]
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

    [LineNumberTable(new byte[] {(byte) 172, (byte) 180, (byte) 99, (byte) 199, (byte) 107, (byte) 109, (byte) 150, (byte) 187, (byte) 112, (byte) 150, (byte) 251, (byte) 70, (byte) 146, (byte) 104, (byte) 242, (byte) 69, (byte) 112, (byte) 114, (byte) 99, (byte) 104, (byte) 237, (byte) 60, (byte) 230, (byte) 73})]
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
        RectangleEdge edge = Plot.resolveDomainAxisLocation(this.getDomainAxisLocation(), this.orientation);
        if (this.drawSharedDomainAxis)
          space = this.getDomainAxis().reserveSpace(g2, (Plot) this, plotArea, edge, space);
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

    [LineNumberTable(new byte[] {(byte) 173, (byte) 22, (byte) 102, (byte) 106, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisSpace calculateAxisSpace(Graphics2D g2, Rectangle2D plotArea)
    {
      AxisSpace space1 = new AxisSpace();
      AxisSpace space2 = this.calculateRangeAxisSpace(g2, plotArea, space1);
      return this.calculateDomainAxisSpace(g2, plotArea, space2);
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 245, (byte) 110, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawBackground(Graphics2D g2, Rectangle2D area)
    {
      this.fillBackground(g2, area, this.orientation);
      this.drawBackgroundImage(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 9, (byte) 166, (byte) 112, (byte) 114, (byte) 99, (byte) 238, (byte) 61, (byte) 230, (byte) 72, (byte) 112, (byte) 114, (byte) 99, (byte) 238, (byte) 61, (byte) 230, (byte) 71, (byte) 167, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 100, (byte) 149, (byte) 106, (byte) 140, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 100, (byte) 149, (byte) 106, (byte) 140, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 100, (byte) 149, (byte) 106, (byte) 140, (byte) 162, (byte) 155, (byte) 109, (byte) 105, (byte) 110, (byte) 100, (byte) 149, (byte) 106, (byte) 140, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Map drawAxes(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, PlotRenderingInfo plotState)
    {
      AxisCollection axisCollection = new AxisCollection();
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
        if (categoryAxis != null)
          axisCollection.add((Axis) categoryAxis, this.getDomainAxisEdge(index));
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
        Axis axis = (Axis) iterator1.next();
        if (axis != null)
        {
          AxisState axisState = axis.draw(g2, d1, plotArea, dataArea, RectangleEdge.__\u003C\u003ETOP, plotState);
          d1 = axisState.getCursor();
          ((Map) hashMap).put((object) axis, (object) axisState);
        }
      }
      double d2 = ((RectangularShape) dataArea).getMaxY() + this.axisOffset.calculateBottomOutset(((RectangularShape) dataArea).getHeight());
      Iterator iterator2 = axisCollection.getAxesAtBottom().iterator();
      while (iterator2.hasNext())
      {
        Axis axis = (Axis) iterator2.next();
        if (axis != null)
        {
          AxisState axisState = axis.draw(g2, d2, plotArea, dataArea, RectangleEdge.__\u003C\u003EBOTTOM, plotState);
          d2 = axisState.getCursor();
          ((Map) hashMap).put((object) axis, (object) axisState);
        }
      }
      double d3 = ((RectangularShape) dataArea).getMinX() - this.axisOffset.calculateLeftOutset(((RectangularShape) dataArea).getWidth());
      Iterator iterator3 = axisCollection.getAxesAtLeft().iterator();
      while (iterator3.hasNext())
      {
        Axis axis = (Axis) iterator3.next();
        if (axis != null)
        {
          AxisState axisState = axis.draw(g2, d3, plotArea, dataArea, RectangleEdge.__\u003C\u003ELEFT, plotState);
          d3 = axisState.getCursor();
          ((Map) hashMap).put((object) axis, (object) axisState);
        }
      }
      double d4 = ((RectangularShape) dataArea).getMaxX() + this.axisOffset.calculateRightOutset(((RectangularShape) dataArea).getWidth());
      Iterator iterator4 = axisCollection.getAxesAtRight().iterator();
      while (iterator4.hasNext())
      {
        Axis axis = (Axis) iterator4.next();
        if (axis != null)
        {
          AxisState axisState = axis.draw(g2, d4, plotArea, dataArea, RectangleEdge.__\u003C\u003ERIGHT, plotState);
          d4 = axisState.getCursor();
          ((Map) hashMap).put((object) axis, (object) axisState);
        }
      }
      return (Map) hashMap;
    }

    [LineNumberTable((ushort) 1217)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getRangeAxisEdge()
    {
      return this.getRangeAxisEdge(0);
    }

    public virtual IComparable getDomainCrosshairRowKey()
    {
      return this.domainCrosshairRowKey;
    }

    public virtual IComparable getDomainCrosshairColumnKey()
    {
      return this.domainCrosshairColumnKey;
    }

    public virtual double getRangeCrosshairValue()
    {
      return this.rangeCrosshairValue;
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 175, (byte) 104, (byte) 129, (byte) 103, (byte) 103, (byte) 103, (byte) 99, (byte) 129, (byte) 103, (byte) 99, (byte) 104, (byte) 105, (byte) 144, (byte) 104, (byte) 100, (byte) 236, (byte) 59, (byte) 232, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainGridlines(Graphics2D g2, Rectangle2D dataArea)
    {
      if (!this.isDomainGridlinesVisible())
        return;
      CategoryAnchor gridlinePosition = this.getDomainGridlinePosition();
      RectangleEdge domainAxisEdge = this.getDomainAxisEdge();
      CategoryDataset dataset = this.getDataset();
      if (dataset == null)
        return;
      CategoryAxis domainAxis = this.getDomainAxis();
      if (domainAxis == null)
        return;
      int columnCount = dataset.getColumnCount();
      for (int category = 0; category < columnCount; ++category)
      {
        double java2Dcoordinate = domainAxis.getCategoryJava2DCoordinate(gridlinePosition, category, columnCount, dataArea, domainAxisEdge);
        CategoryItemRenderer renderer = this.getRenderer();
        if (renderer != null)
          renderer.drawDomainGridline(g2, this, dataArea, java2Dcoordinate);
      }
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 210, (byte) 112, (byte) 161, (byte) 103, (byte) 99, (byte) 161, (byte) 103, (byte) 99, (byte) 161, (byte) 98, (byte) 98, (byte) 98, (byte) 104, (byte) 108, (byte) 99, (byte) 110, (byte) 150, (byte) 103, (byte) 103, (byte) 133, (byte) 150, (byte) 103, (byte) 103, (byte) 131, (byte) 218, (byte) 104, (byte) 136, (byte) 148, (byte) 194, (byte) 209, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeGridlines(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (!this.isRangeGridlinesVisible() && !this.isRangeMinorGridlinesVisible())
        return;
      ValueAxis rangeAxis = this.getRangeAxis();
      if (rangeAxis == null)
        return;
      CategoryItemRenderer renderer = this.getRenderer();
      if (renderer == null)
        return;
      Stroke stroke = (Stroke) null;
      Paint paint = (Paint) null;
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        int num = 0;
        ValueTick valueTick = (ValueTick) iterator.next();
        if (valueTick.getTickType() == TickType.__\u003C\u003EMINOR && this.isRangeMinorGridlinesVisible())
        {
          stroke = this.getRangeMinorGridlineStroke();
          paint = this.getRangeMinorGridlinePaint();
          num = 1;
        }
        else if (valueTick.getTickType() == TickType.__\u003C\u003EMAJOR && this.isRangeGridlinesVisible())
        {
          stroke = this.getRangeGridlineStroke();
          paint = this.getRangeGridlinePaint();
          num = 1;
        }
        if ((valueTick.getValue() != 0.0 || !this.isRangeZeroBaselineVisible()) && num != 0)
        {
          if (renderer is AbstractCategoryItemRenderer)
            ((AbstractCategoryItemRenderer) renderer).drawRangeLine(g2, this, rangeAxis, dataArea, valueTick.getValue(), paint, stroke);
          else
            renderer.drawRangeGridline(g2, this, rangeAxis, dataArea, valueTick.getValue());
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 18, (byte) 104, (byte) 129, (byte) 103, (byte) 104, (byte) 103, (byte) 159, (byte) 1, (byte) 130, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawZeroRangeBaseline(Graphics2D g2, Rectangle2D area)
    {
      if (!this.isRangeZeroBaselineVisible())
        return;
      CategoryItemRenderer renderer = this.getRenderer();
      if (renderer is AbstractCategoryItemRenderer)
        ((AbstractCategoryItemRenderer) renderer).drawRangeLine(g2, this, this.getRangeAxis(), area, 0.0, this.rangeZeroBaselinePaint, this.rangeZeroBaselineStroke);
      else
        renderer.drawRangeGridline(g2, this, this.getRangeAxis(), area, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 66, (byte) 104, (byte) 99, (byte) 161, (byte) 106, (byte) 104, (byte) 102, (byte) 103, (byte) 104, (byte) 109, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainMarkers(Graphics2D g2, Rectangle2D dataArea, int index, Layer layer)
    {
      CategoryItemRenderer renderer = this.getRenderer(index);
      if (renderer == null)
        return;
      Collection domainMarkers = this.getDomainMarkers(index, layer);
      CategoryAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
      if (domainMarkers == null || domainAxisForDataset == null)
        return;
      Iterator iterator = domainMarkers.iterator();
      while (iterator.hasNext())
      {
        CategoryMarker cm = (CategoryMarker) iterator.next();
        renderer.drawDomainMarker(g2, this, domainAxisForDataset, cm, dataArea);
      }
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 97, (byte) 104, (byte) 99, (byte) 161, (byte) 106, (byte) 104, (byte) 102, (byte) 103, (byte) 104, (byte) 109, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeMarkers(Graphics2D g2, Rectangle2D dataArea, int index, Layer layer)
    {
      CategoryItemRenderer renderer = this.getRenderer(index);
      if (renderer == null)
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
      return this.renderingOrder;
    }

    [LineNumberTable(new byte[] {(byte) 174, (byte) 107, (byte) 98, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 110, (byte) 141, (byte) 98, (byte) 142, (byte) 105, (byte) 104, (byte) 104, (byte) 104, (byte) 108, (byte) 112, (byte) 108, (byte) 109, (byte) 105, (byte) 53, (byte) 234, (byte) 71, (byte) 107, (byte) 53, (byte) 232, (byte) 55, (byte) 240, (byte) 82, (byte) 110, (byte) 109, (byte) 105, (byte) 53, (byte) 234, (byte) 71, (byte) 107, (byte) 53, (byte) 232, (byte) 55, (byte) 235, (byte) 44, (byte) 235, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool render(Graphics2D g2, Rectangle2D dataArea, int index, PlotRenderingInfo info, CategoryCrosshairState crosshairState)
    {
      int num = 0;
      CategoryDataset dataset = this.getDataset(index);
      CategoryItemRenderer renderer = this.getRenderer(index);
      CategoryAxis domainAxisForDataset = this.getDomainAxisForDataset(index);
      ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(index);
      if ((DatasetUtilities.isEmptyOrNull(dataset) ? 0 : 1) != 0 && renderer != null)
      {
        num = 1;
        CategoryItemRendererState cirs = renderer.initialise(g2, dataArea, this, index, info);
        cirs.setCrosshairState(crosshairState);
        int columnCount = dataset.getColumnCount();
        int rowCount = dataset.getRowCount();
        int passCount = renderer.getPassCount();
        for (int i3 = 0; i3 < passCount; ++i3)
        {
          if (this.columnRenderingOrder == SortOrder.__\u003C\u003EASCENDING)
          {
            for (int i2 = 0; i2 < columnCount; ++i2)
            {
              if (this.rowRenderingOrder == SortOrder.__\u003C\u003EASCENDING)
              {
                for (int i1 = 0; i1 < rowCount; ++i1)
                  renderer.drawItem(g2, cirs, dataArea, this, domainAxisForDataset, rangeAxisForDataset, dataset, i1, i2, i3);
              }
              else
              {
                int i1 = rowCount - 1;
                while (i1 >= 0)
                {
                  renderer.drawItem(g2, cirs, dataArea, this, domainAxisForDataset, rangeAxisForDataset, dataset, i1, i2, i3);
                  i1 += -1;
                }
              }
            }
          }
          else
          {
            int i2 = columnCount - 1;
            while (i2 >= 0)
            {
              if (this.rowRenderingOrder == SortOrder.__\u003C\u003EASCENDING)
              {
                for (int i1 = 0; i1 < rowCount; ++i1)
                  renderer.drawItem(g2, cirs, dataArea, this, domainAxisForDataset, rangeAxisForDataset, dataset, i1, i2, i3);
              }
              else
              {
                int i1 = rowCount - 1;
                while (i1 >= 0)
                {
                  renderer.drawItem(g2, cirs, dataArea, this, domainAxisForDataset, rangeAxisForDataset, dataset, i1, i2, i3);
                  i1 += -1;
                }
              }
              i2 += -1;
            }
          }
        }
      }
      return num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 40, (byte) 104, (byte) 108, (byte) 104, (byte) 140, (byte) 149, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawAnnotations(Graphics2D g2, Rectangle2D dataArea)
    {
      if (this.getAnnotations() == null)
        return;
      Iterator iterator = this.getAnnotations().iterator();
      while (iterator.hasNext())
        ((CategoryAnnotation) iterator.next()).draw(g2, this, dataArea, this.getDomainAxis(), this.getRangeAxis());
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

    [LineNumberTable(new byte[] {(byte) 175, (byte) 166, (byte) 105, (byte) 105, (byte) 105, (byte) 98, (byte) 104, (byte) 148, (byte) 149, (byte) 130, (byte) 148, (byte) 181, (byte) 104, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainCrosshair(Graphics2D g2, Rectangle2D dataArea, PlotOrientation orientation, int datasetIndex, IComparable rowKey, IComparable columnKey, Stroke stroke, Paint paint)
    {
      CategoryDataset dataset = this.getDataset(datasetIndex);
      CategoryAxis domainAxisForDataset = this.getDomainAxisForDataset(datasetIndex);
      CategoryItemRenderer renderer = this.getRenderer(datasetIndex);
      Line2D.Double @double;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double itemMiddle = renderer.getItemMiddle(rowKey, columnKey, dataset, domainAxisForDataset, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        @double = new Line2D.Double(itemMiddle, ((RectangularShape) dataArea).getMinY(), itemMiddle, ((RectangularShape) dataArea).getMaxY());
      }
      else
      {
        double itemMiddle = renderer.getItemMiddle(rowKey, columnKey, dataset, domainAxisForDataset, dataArea, RectangleEdge.__\u003C\u003ELEFT);
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), itemMiddle, ((RectangularShape) dataArea).getMaxX(), itemMiddle);
      }
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 120, (byte) 100, (byte) 144, (byte) 98, (byte) 151, (byte) 131, (byte) 109, (byte) 109, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueAxis getRangeAxisForDataset(int index)
    {
      if (index < 0)
      {
        string str = "Negative 'index'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        List list = (List) this.datasetToRangeAxesMap.get((object) new Integer(index));
        return list == null ? this.getRangeAxis(0) : this.getRangeAxis(((Integer) list.get(0)).intValue());
      }
    }

    public virtual Paint getRangeCrosshairPaint()
    {
      return this.rangeCrosshairPaint;
    }

    public virtual Stroke getRangeCrosshairStroke()
    {
      return this.rangeCrosshairStroke;
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 208, (byte) 113, (byte) 129, (byte) 98, (byte) 104, (byte) 146, (byte) 148, (byte) 130, (byte) 146, (byte) 180, (byte) 104, (byte) 104, (byte) 137})]
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 57, (byte) 100, (byte) 144, (byte) 98, (byte) 151, (byte) 131, (byte) 109, (byte) 109, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryAxis getDomainAxisForDataset(int index)
    {
      if (index < 0)
      {
        string str = "Negative 'index'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        List list = (List) this.datasetToDomainAxesMap.get((object) new Integer(index));
        return list == null ? this.getDomainAxis(0) : this.getDomainAxis(((Integer) list.get(0)).intValue());
      }
    }

    public virtual bool isDomainGridlinesVisible()
    {
      return this.domainGridlinesVisible;
    }

    public virtual CategoryAnchor getDomainGridlinePosition()
    {
      return this.domainGridlinePosition;
    }

    [LineNumberTable((ushort) 937)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleEdge getDomainAxisEdge()
    {
      return this.getDomainAxisEdge(0);
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

    public virtual List getAnnotations()
    {
      return this.annotations;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 54, (byte) 103, (byte) 102, (byte) 115, (byte) 151, (byte) 99, (byte) 109, (byte) 213, (byte) 105, (byte) 243, (byte) 54, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List datasetsMappedToRangeAxis([In] int obj0)
    {
      Integer integer = new Integer(obj0);
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < this.datasets.size(); ++index)
      {
        List list = (List) this.datasetToRangeAxesMap.get((object) new Integer(index));
        if (list == null)
        {
          if (integer.equals((object) Plot.__\u003C\u003EZERO))
            ((List) arrayList).add(this.datasets.get(index));
        }
        else if (list.contains((object) integer))
          ((List) arrayList).add(this.datasets.get(index));
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 25, (byte) 98, (byte) 112, (byte) 111, (byte) 114, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemRenderer getRendererForDataset(CategoryDataset dataset)
    {
      CategoryItemRenderer categoryItemRenderer = (CategoryItemRenderer) null;
      for (int index = 0; index < this.datasets.size(); ++index)
      {
        if (this.datasets.get(index) == dataset)
        {
          categoryItemRenderer = (CategoryItemRenderer) this.renderers.get(index);
          break;
        }
      }
      return categoryItemRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 81, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedDomainAxisSpace(AxisSpace space, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fixedDomainAxisSpace = space;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 70, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedRangeAxisSpace(AxisSpace space, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fixedRangeAxisSpace = space;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 21, (byte) 103, (byte) 102, (byte) 115, (byte) 151, (byte) 115, (byte) 99, (byte) 109, (byte) 100, (byte) 235, (byte) 69, (byte) 105, (byte) 100, (byte) 233, (byte) 50, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List datasetsMappedToDomainAxis([In] int obj0)
    {
      Integer integer = new Integer(obj0);
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < this.datasets.size(); ++index)
      {
        List list = (List) this.datasetToDomainAxesMap.get((object) new Integer(index));
        CategoryDataset categoryDataset = (CategoryDataset) this.datasets.get(index);
        if (list == null)
        {
          if (integer.equals((object) Plot.__\u003C\u003EZERO) && categoryDataset != null)
            ((List) arrayList).add((object) categoryDataset);
        }
        else if (list.contains((object) integer) && categoryDataset != null)
          ((List) arrayList).add((object) categoryDataset);
      }
      return (List) arrayList;
    }

    public virtual bool isRangePannable()
    {
      return this.rangePannable;
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 7, (byte) 67, (byte) 115, (byte) 114, (byte) 99, (byte) 163, (byte) 104, (byte) 109, (byte) 136, (byte) 150, (byte) 106, (byte) 130, (byte) 232, (byte) 49, (byte) 233, (byte) 83})]
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

    [LineNumberTable(new byte[] {(byte) 154, (byte) 245, (byte) 66, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAnchorValue(double value, bool notify)
    {
      int num = notify ? 1 : 0;
      this.anchorValue = value;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 179, (byte) 4, (byte) 102, (byte) 103, (byte) 103, (byte) 104, (byte) 103, (byte) 110, (byte) 105, (byte) 106, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Map cloneMarkerMap([In] Map obj0)
    {
      HashMap hashMap = new HashMap();
      Iterator iterator = obj0.keySet().iterator();
      while (iterator.hasNext())
      {
        object obj = iterator.next();
        Collection collection = ObjectUtilities.deepClone((Collection) obj0.get(obj));
        ((Map) hashMap).put(obj, (object) collection);
      }
      return (Map) hashMap;
    }

    [LineNumberTable((ushort) 653)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return CategoryPlot.localizationResources.getString("Category_Plot");
    }

    public virtual RectangleInsets getAxisOffset()
    {
      return this.axisOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 130, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(CategoryAxis axis)
    {
      this.setDomainAxis(0, axis);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 181, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxes(CategoryAxis[] axes)
    {
      for (int index = 0; index < axes.Length; ++index)
        this.setDomainAxis(index, axes[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 201, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDomainAxisIndex(CategoryAxis axis)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.domainAxes.indexOf((object) axis);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 249, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(AxisLocation location)
    {
      this.setDomainAxisLocation(0, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 20, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxisLocation(int index, AxisLocation location)
    {
      this.setDomainAxisLocation(index, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 91, (byte) 112, (byte) 114, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainAxes()
    {
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
        if (categoryAxis != null)
          categoryAxis.removeChangeListener((AxisChangeListener) this);
      }
      this.domainAxes.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 153, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(ValueAxis axis)
    {
      this.setRangeAxis(0, axis);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 202, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxes(ValueAxis[] axes)
    {
      for (int index = 0; index < axes.Length; ++index)
        this.setRangeAxis(index, axes[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 20, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(AxisLocation location)
    {
      this.setRangeAxisLocation(location, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 47, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxisLocation(int index, AxisLocation location)
    {
      this.setRangeAxisLocation(index, location, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 113, (byte) 112, (byte) 114, (byte) 99, (byte) 231, (byte) 61, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 175, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(CategoryDataset dataset)
    {
      this.setDataset(0, dataset);
    }

    [LineNumberTable((ushort) 1349)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDatasetCount()
    {
      return this.datasets.size();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 225, (byte) 98, (byte) 112, (byte) 111, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(CategoryDataset dataset)
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

    [LineNumberTable(new byte[] {(byte) 165, (byte) 186, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(CategoryItemRenderer renderer)
    {
      this.setRenderer(0, renderer, true);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 254, (byte) 98, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(CategoryItemRenderer renderer, bool notify)
    {
      int num = notify ? 1 : 0;
      this.setRenderer(0, renderer, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 221, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(int index, CategoryItemRenderer renderer)
    {
      this.setRenderer(index, renderer, true);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 10, (byte) 103, (byte) 43, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderers(CategoryItemRenderer[] renderers)
    {
      for (int index = 0; index < renderers.Length; ++index)
        this.setRenderer(index, renderers[index], false);
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 1694)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndexOf(CategoryItemRenderer renderer)
    {
      return this.renderers.indexOf((object) renderer);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 69, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
        this.renderingOrder = order;
        this.fireChangeEvent();
      }
    }

    public virtual SortOrder getColumnRenderingOrder()
    {
      return this.columnRenderingOrder;
    }

    public virtual SortOrder getRowRenderingOrder()
    {
      return this.rowRenderingOrder;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 202, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.domainGridlinesVisible ? 1 : 0) == num)
        return;
      this.domainGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 187, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinePosition(CategoryAnchor position)
    {
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainGridlinePosition = position;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getDomainGridlineStroke()
    {
      return this.domainGridlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 214, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getDomainGridlinePaint()
    {
      return this.domainGridlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 173, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeZeroBaselineVisible(bool visible)
    {
      this.rangeZeroBaselineVisible = visible;
      this.fireChangeEvent();
    }

    public virtual Stroke getRangeZeroBaselineStroke()
    {
      return this.rangeZeroBaselineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 46, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 157, (byte) 151, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.rangeGridlinesVisible ? 1 : 0) == num)
        return;
      this.rangeGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 132, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 157, (byte) 129, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeMinorGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.rangeMinorGridlinesVisible ? 1 : 0) == num)
        return;
      this.rangeMinorGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 225, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 168, (byte) 1, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    public virtual LegendItemCollection getFixedLegendItems()
    {
      return this.fixedLegendItems;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 29, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedLegendItems(LegendItemCollection items)
    {
      this.fixedLegendItems = items;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 41, (byte) 103, (byte) 102, (byte) 134, (byte) 108, (byte) 105, (byte) 104, (byte) 99, (byte) 105, (byte) 100, (byte) 104, (byte) 105, (byte) 140, (byte) 100, (byte) 232, (byte) 60, (byte) 232, (byte) 58, (byte) 233, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = this.fixedLegendItems;
      if (legendItemCollection == null)
      {
        legendItemCollection = new LegendItemCollection();
        int num = this.datasets.size();
        for (int index = 0; index < num; ++index)
        {
          CategoryDataset dataset = this.getDataset(index);
          if (dataset != null)
          {
            CategoryItemRenderer renderer = this.getRenderer(index);
            if (renderer != null)
            {
              int rowCount = dataset.getRowCount();
              for (int i2 = 0; i2 < rowCount; ++i2)
              {
                LegendItem legendItem = renderer.getLegendItem(index, i2);
                if (legendItem != null)
                  legendItemCollection.add(legendItem);
              }
            }
          }
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 76, (byte) 103, (byte) 143, (byte) 102, (byte) 109, (byte) 133, (byte) 109, (byte) 131, (byte) 146, (byte) 149, (byte) 103, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void handleClick(int x, int y, PlotRenderingInfo info)
    {
      if (!info.getDataArea().contains((double) x, (double) y))
        return;
      double d = 0.0;
      if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        d = (double) x;
      else if (this.orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        d = (double) y;
      RectangleEdge re = Plot.resolveRangeAxisLocation(this.getRangeAxisLocation(), this.orientation);
      double num = this.getRangeAxis().java2DToValue(d, info.getDataArea(), re);
      this.setAnchorValue(num);
      this.setRangeCrosshairValue(num);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 107, (byte) 105, (byte) 114, (byte) 102, (byte) 159, (byte) 16, (byte) 130, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoom(double percent)
    {
      if (percent > 0.0)
      {
        double num = this.getRangeAxis().getRange().getLength() * percent;
        this.getRangeAxis().setRange(this.anchorValue - num / 2.0, this.anchorValue + num / 2.0);
      }
      else
        this.getRangeAxis().setAutoRange(true);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 152, (byte) 103, (byte) 99, (byte) 104, (byte) 103, (byte) 103, (byte) 194, (byte) 240, (byte) 69, (byte) 102, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void rendererChanged(RendererChangeEvent @event)
    {
      Plot parent = this.getParent();
      if (parent != null)
      {
        if (parent is RendererChangeListener)
        {
          ((RendererChangeListener) parent).rendererChanged(@event);
        }
        else
        {
          string str = "The renderer has changed and I don't know what to do!";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else
      {
        this.configureRangeAxes();
        this.notifyListeners(new PlotChangeEvent((Plot) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 183, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainMarker(CategoryMarker marker)
    {
      this.addDomainMarker(marker, Layer.__\u003C\u003EFOREGROUND);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 19, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 98, (byte) 139, (byte) 104})]
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

    [LineNumberTable((ushort) 2466)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getDomainMarkers(Layer layer)
    {
      return this.getDomainMarkers(0, layer);
    }

    [LineNumberTable((ushort) 2541)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeDomainMarker(Marker marker)
    {
      return (this.removeDomainMarker(marker, Layer.__\u003C\u003EFOREGROUND) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 205, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeMarker(Marker marker)
    {
      this.addRangeMarker(marker, Layer.__\u003C\u003EFOREGROUND);
    }

    [LineNumberTable((ushort) 2740)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getRangeMarkers(Layer layer)
    {
      return this.getRangeMarkers(0, layer);
    }

    [LineNumberTable((ushort) 2817)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeRangeMarker(Marker marker)
    {
      return (this.removeRangeMarker(marker, Layer.__\u003C\u003EFOREGROUND) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 179, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.domainCrosshairVisible ? 1 : 0) == num)
        return;
      this.domainCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 20, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairRowKey(IComparable key)
    {
      this.setDomainCrosshairRowKey(key, true);
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 59, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainCrosshairColumnKey(IComparable key)
    {
      this.setDomainCrosshairColumnKey(key, true);
    }

    public virtual int getCrosshairDatasetIndex()
    {
      return this.crosshairDatasetIndex;
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCrosshairDatasetIndex(int index)
    {
      this.setCrosshairDatasetIndex(index, true);
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 141, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 171, (byte) 173, (byte) 99, (byte) 144, (byte) 103})]
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
        this.domainCrosshairStroke = stroke;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 128, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairVisible ? 1 : 0) == num)
        return;
      this.rangeCrosshairVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual bool isRangeCrosshairLockedOnData()
    {
      return this.rangeCrosshairLockedOnData;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 121, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeCrosshairLockedOnData(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.rangeCrosshairLockedOnData ? 1 : 0) == num)
        return;
      this.rangeCrosshairLockedOnData = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 172, (byte) 42, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 172, (byte) 71, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 172, (byte) 99, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(CategoryAnnotation annotation)
    {
      this.addAnnotation(annotation, true);
    }

    [LineNumberTable((ushort) 3318)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeAnnotation(CategoryAnnotation annotation)
    {
      return (this.removeAnnotation(annotation, true) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 172, (byte) 163, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearAnnotations()
    {
      this.annotations.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 173, (byte) 48, (byte) 117, (byte) 117, (byte) 102, (byte) 193, (byte) 196, (byte) 136, (byte) 168, (byte) 103, (byte) 167, (byte) 105, (byte) 106, (byte) 141, (byte) 105, (byte) 214, (byte) 104, (byte) 177, (byte) 169, (byte) 206, (byte) 109, (byte) 181, (byte) 103, (byte) 112, (byte) 232, (byte) 69, (byte) 112, (byte) 112, (byte) 99, (byte) 104, (byte) 132, (byte) 109, (byte) 218, (byte) 184, (byte) 169, (byte) 109, (byte) 109, (byte) 173, (byte) 104, (byte) 136, (byte) 137, (byte) 116, (byte) 100, (byte) 100, (byte) 217, (byte) 100, (byte) 112, (byte) 201, (byte) 114, (byte) 48, (byte) 168, (byte) 114, (byte) 48, (byte) 232, (byte) 69, (byte) 163, (byte) 104, (byte) 178, (byte) 104, (byte) 105, (byte) 114, (byte) 59, (byte) 234, (byte) 70, (byte) 116, (byte) 59, (byte) 232, (byte) 70, (byte) 114, (byte) 48, (byte) 168, (byte) 114, (byte) 48, (byte) 232, (byte) 69, (byte) 137, (byte) 104, (byte) 136, (byte) 100, (byte) 169, (byte) 105, (byte) 169, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 108, (byte) 104, (byte) 104, (byte) 249, (byte) 69, (byte) 106, (byte) 104, (byte) 139, (byte) 109, (byte) 182, (byte) 148, (byte) 137, (byte) 110, (byte) 104, (byte) 105, (byte) 104, (byte) 104, (byte) 247, (byte) 69, (byte) 104, (byte) 104, (byte) 177, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo state)
    {
      if (((RectangularShape) area).getWidth() <= 10.0 || ((RectangularShape) area).getHeight() <= 10.0)
        return;
      if (state == null)
        state = new PlotRenderingInfo((ChartRenderingInfo) null);
      state.setPlotArea(area);
      this.getInsets().trim(area);
      Rectangle2D rectangle2D = this.calculateAxisSpace(g2, area).shrink(area, (Rectangle2D) null);
      this.axisOffset.trim(rectangle2D);
      state.setDataArea(rectangle2D);
      this.createAndAddEntity((Rectangle2D) ((RectangularShape) rectangle2D).clone(), state, (string) null, (string) null);
      if (this.getRenderer() != null)
        this.getRenderer().drawBackground(g2, this, rectangle2D);
      else
        this.drawBackground(g2, rectangle2D);
      Map map = this.drawAxes(g2, area, rectangle2D, state);
      if (anchor != null && !((RectangularShape) rectangle2D).contains(anchor))
        anchor = ShapeUtilities.getPointInRectangle(anchor.getX(), anchor.getY(), rectangle2D);
      CategoryCrosshairState crosshairState = new CategoryCrosshairState();
      crosshairState.setCrosshairDistance(double.PositiveInfinity);
      crosshairState.setAnchor(anchor);
      crosshairState.setAnchorX(double.NaN);
      crosshairState.setAnchorY(double.NaN);
      if (anchor != null)
      {
        ValueAxis rangeAxis = this.getRangeAxis();
        if (rangeAxis != null)
        {
          double y = this.getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? rangeAxis.java2DToValue(anchor.getX(), rectangle2D, this.getRangeAxisEdge()) : rangeAxis.java2DToValue(anchor.getY(), rectangle2D, this.getRangeAxisEdge());
          crosshairState.setAnchorY(y);
        }
      }
      crosshairState.setRowKey(this.getDomainCrosshairRowKey());
      crosshairState.setColumnKey(this.getDomainCrosshairColumnKey());
      crosshairState.setCrosshairY(this.getRangeCrosshairValue());
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) rectangle2D);
      this.drawDomainGridlines(g2, rectangle2D);
      AxisState axisState = (AxisState) map.get((object) this.getRangeAxis());
      if (axisState == null && parentState != null)
        axisState = (AxisState) parentState.getSharedAxisStates().get((object) this.getRangeAxis());
      if (axisState != null)
      {
        this.drawRangeGridlines(g2, rectangle2D, axisState.getTicks());
        this.drawZeroRangeBaseline(g2, rectangle2D);
      }
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawDomainMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EBACKGROUND);
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawRangeMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EBACKGROUND);
      int num = 0;
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      if (this.getDatasetRenderingOrder() == DatasetRenderingOrder.__\u003C\u003EFORWARD)
      {
        for (int index = 0; index < this.datasets.size(); ++index)
          num = this.render(g2, rectangle2D, index, state, crosshairState) || num != 0 ? 1 : 0;
      }
      else
      {
        int index = this.datasets.size() - 1;
        while (index >= 0)
        {
          num = this.render(g2, rectangle2D, index, state, crosshairState) || num != 0 ? 1 : 0;
          index += -1;
        }
      }
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawDomainMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EFOREGROUND);
      for (int index = 0; index < this.renderers.size(); ++index)
        this.drawRangeMarkers(g2, rectangle2D, index, Layer.__\u003C\u003EFOREGROUND);
      this.drawAnnotations(g2, rectangle2D);
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      if (num == 0)
        this.drawNoDataMessage(g2, rectangle2D);
      int datasetIndex = crosshairState.getDatasetIndex();
      this.setCrosshairDatasetIndex(datasetIndex, false);
      IComparable rowKey = crosshairState.getRowKey();
      IComparable columnKey = crosshairState.getColumnKey();
      this.setDomainCrosshairRowKey(rowKey, false);
      this.setDomainCrosshairColumnKey(columnKey, false);
      if (this.isDomainCrosshairVisible() && columnKey != null)
      {
        Paint domainCrosshairPaint = this.getDomainCrosshairPaint();
        Stroke domainCrosshairStroke = this.getDomainCrosshairStroke();
        this.drawDomainCrosshair(g2, rectangle2D, this.orientation, datasetIndex, rowKey, columnKey, domainCrosshairStroke, domainCrosshairPaint);
      }
      ValueAxis rangeAxisForDataset = this.getRangeAxisForDataset(datasetIndex);
      RectangleEdge rangeAxisEdge = this.getRangeAxisEdge();
      if (!this.rangeCrosshairLockedOnData && anchor != null)
      {
        double y = this.getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? rangeAxisForDataset.java2DToValue(anchor.getX(), rectangle2D, rangeAxisEdge) : rangeAxisForDataset.java2DToValue(anchor.getY(), rectangle2D, rangeAxisEdge);
        crosshairState.setCrosshairY(y);
      }
      this.setRangeCrosshairValue(crosshairState.getCrosshairY(), false);
      if (this.isRangeCrosshairVisible())
      {
        double rangeCrosshairValue = this.getRangeCrosshairValue();
        Paint rangeCrosshairPaint = this.getRangeCrosshairPaint();
        Stroke rangeCrosshairStroke = this.getRangeCrosshairStroke();
        this.drawRangeCrosshair(g2, rectangle2D, this.getOrientation(), rangeCrosshairValue, rangeAxisForDataset, rangeCrosshairStroke, rangeCrosshairPaint);
      }
      if (!this.isOutlineVisible())
        return;
      if (this.getRenderer() != null)
        this.getRenderer().drawOutline(g2, this, rectangle2D);
      else
        this.drawOutline(g2, rectangle2D);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 127, (byte) 150, (byte) 98, (byte) 109, (byte) 182, (byte) 109, (byte) 180, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeLine(Graphics2D g2, Rectangle2D dataArea, double value, Stroke stroke, Paint paint)
    {
      double num = this.getRangeAxis().valueToJava2D(value, dataArea, this.getRangeAxisEdge());
      Line2D.Double @double = (Line2D.Double) null;
      if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      else if (this.orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      g2.setStroke(stroke);
      g2.setPaint(paint);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 175, (byte) 241, (byte) 98, (byte) 134, (byte) 109, (byte) 100, (byte) 144, (byte) 105, (byte) 238, (byte) 69, (byte) 103, (byte) 104, (byte) 109, (byte) 106, (byte) 100, (byte) 144, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDataRange(ValueAxis axis)
    {
      Range range1 = (Range) null;
      ArrayList arrayList = new ArrayList();
      int num = this.rangeAxes.indexOf((object) axis);
      if (num >= 0)
        ((List) arrayList).addAll((Collection) this.datasetsMappedToRangeAxis(num));
      else if (axis == this.getRangeAxis())
        ((List) arrayList).addAll((Collection) this.datasetsMappedToRangeAxis(0));
      Iterator iterator = ((List) arrayList).iterator();
      while (iterator.hasNext())
      {
        CategoryDataset categoryDataset = (CategoryDataset) iterator.next();
        CategoryItemRenderer rendererForDataset = this.getRendererForDataset(categoryDataset);
        if (rendererForDataset != null)
          range1 = Range.combine(range1, rendererForDataset.findRangeBounds(categoryDataset));
      }
      return range1;
    }

    public virtual int getWeight()
    {
      return this.weight;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 94, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWeight(int weight)
    {
      this.weight = weight;
      this.fireChangeEvent();
    }

    public virtual AxisSpace getFixedDomainAxisSpace()
    {
      return this.fixedDomainAxisSpace;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 118, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedDomainAxisSpace(AxisSpace space)
    {
      this.setFixedDomainAxisSpace(space, true);
    }

    public virtual AxisSpace getFixedRangeAxisSpace()
    {
      return this.fixedRangeAxisSpace;
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 159, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedRangeAxisSpace(AxisSpace space)
    {
      this.setFixedRangeAxisSpace(space, true);
    }

    [LineNumberTable(new byte[] {(byte) 176, (byte) 188, (byte) 98, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getCategories()
    {
      List list = (List) null;
      if (this.getDataset() != null)
        list = Collections.unmodifiableList(this.getDataset().getColumnKeys());
      return list;
    }

    public virtual bool getDrawSharedDomainAxis()
    {
      return this.drawSharedDomainAxis;
    }

    [LineNumberTable(new byte[] {(byte) 155, (byte) 53, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawSharedDomainAxis(bool draw)
    {
      this.drawSharedDomainAxis = draw;
      this.fireChangeEvent();
    }

    public virtual bool isDomainPannable()
    {
      return false;
    }

    public virtual void setRangePannable(bool pannable)
    {
      this.rangePannable = pannable;
    }

    public virtual void panDomainAxes(double percent, PlotRenderingInfo info, Point2D source)
    {
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 53, (byte) 104, (byte) 129, (byte) 103, (byte) 105, (byte) 104, (byte) 99, (byte) 130, (byte) 109, (byte) 103, (byte) 104, (byte) 133, (byte) 248, (byte) 54, (byte) 233, (byte) 77})]
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
          double length = rangeAxis.getRange().getLength();
          double num = percent * length;
          if (rangeAxis.isInverted())
            num = -num;
          rangeAxis.setRange(rangeAxis.getLowerBound() + num, rangeAxis.getUpperBound() + num);
        }
      }
    }

    public virtual bool isDomainZoomable()
    {
      return false;
    }

    public virtual bool isRangeZoomable()
    {
      return true;
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
    }

    public virtual void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 150, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
      this.zoomRangeAxes(factor, state, source, false);
    }

    [LineNumberTable(new byte[] {(byte) 177, (byte) 201, (byte) 112, (byte) 114, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
          valueAxis.zoomRange(lowerPercent, upperPercent);
      }
    }

    public virtual double getAnchorValue()
    {
      return this.anchorValue;
    }

    [LineNumberTable(new byte[] {(byte) 178, (byte) 1, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 142, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 142, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryPlot))
        return false;
      CategoryPlot categoryPlot = (CategoryPlot) obj;
      if (this.orientation != categoryPlot.orientation || !ObjectUtilities.equal((object) this.axisOffset, (object) categoryPlot.axisOffset) || (!this.domainAxes.equals((object) categoryPlot.domainAxes) || !this.domainAxisLocations.equals((object) categoryPlot.domainAxisLocations)) || (this.drawSharedDomainAxis != categoryPlot.drawSharedDomainAxis || !this.rangeAxes.equals((object) categoryPlot.rangeAxes) || (!this.rangeAxisLocations.equals((object) categoryPlot.rangeAxisLocations) || !ObjectUtilities.equal((object) this.datasetToDomainAxesMap, (object) categoryPlot.datasetToDomainAxesMap))) || (!ObjectUtilities.equal((object) this.datasetToRangeAxesMap, (object) categoryPlot.datasetToRangeAxesMap) || !ObjectUtilities.equal((object) this.renderers, (object) categoryPlot.renderers) || (this.renderingOrder != categoryPlot.renderingOrder || this.columnRenderingOrder != categoryPlot.columnRenderingOrder) || (this.rowRenderingOrder != categoryPlot.rowRenderingOrder || this.domainGridlinesVisible != categoryPlot.domainGridlinesVisible || (this.domainGridlinePosition != categoryPlot.domainGridlinePosition || !ObjectUtilities.equal((object) this.domainGridlineStroke, (object) categoryPlot.domainGridlineStroke)))) || (!PaintUtilities.equal(this.domainGridlinePaint, categoryPlot.domainGridlinePaint) || this.rangeGridlinesVisible != categoryPlot.rangeGridlinesVisible || (!ObjectUtilities.equal((object) this.rangeGridlineStroke, (object) categoryPlot.rangeGridlineStroke) || !PaintUtilities.equal(this.rangeGridlinePaint, categoryPlot.rangeGridlinePaint)) || (this.anchorValue != categoryPlot.anchorValue || this.rangeCrosshairVisible != categoryPlot.rangeCrosshairVisible || (this.rangeCrosshairValue != categoryPlot.rangeCrosshairValue || !ObjectUtilities.equal((object) this.rangeCrosshairStroke, (object) categoryPlot.rangeCrosshairStroke))) || (!PaintUtilities.equal(this.rangeCrosshairPaint, categoryPlot.rangeCrosshairPaint) || this.rangeCrosshairLockedOnData != categoryPlot.rangeCrosshairLockedOnData || (!ObjectUtilities.equal((object) this.foregroundDomainMarkers, (object) categoryPlot.foregroundDomainMarkers) || !ObjectUtilities.equal((object) this.backgroundDomainMarkers, (object) categoryPlot.backgroundDomainMarkers)) || (!ObjectUtilities.equal((object) this.foregroundRangeMarkers, (object) categoryPlot.foregroundRangeMarkers) || !ObjectUtilities.equal((object) this.backgroundRangeMarkers, (object) categoryPlot.backgroundRangeMarkers) || (!ObjectUtilities.equal((object) this.annotations, (object) categoryPlot.annotations) || this.weight != categoryPlot.weight)))) || (!ObjectUtilities.equal((object) this.fixedDomainAxisSpace, (object) categoryPlot.fixedDomainAxisSpace) || !ObjectUtilities.equal((object) this.fixedRangeAxisSpace, (object) categoryPlot.fixedRangeAxisSpace) || (!ObjectUtilities.equal((object) this.fixedLegendItems, (object) categoryPlot.fixedLegendItems) || this.domainCrosshairVisible != categoryPlot.domainCrosshairVisible) || (this.crosshairDatasetIndex != categoryPlot.crosshairDatasetIndex || !ObjectUtilities.equal((object) this.domainCrosshairColumnKey, (object) categoryPlot.domainCrosshairColumnKey) || (!ObjectUtilities.equal((object) this.domainCrosshairRowKey, (object) categoryPlot.domainCrosshairRowKey) || !PaintUtilities.equal(this.domainCrosshairPaint, categoryPlot.domainCrosshairPaint))) || (!ObjectUtilities.equal((object) this.domainCrosshairStroke, (object) categoryPlot.domainCrosshairStroke) || this.rangeMinorGridlinesVisible != categoryPlot.rangeMinorGridlinesVisible || (!PaintUtilities.equal(this.rangeMinorGridlinePaint, categoryPlot.rangeMinorGridlinePaint) || !ObjectUtilities.equal((object) this.rangeMinorGridlineStroke, (object) categoryPlot.rangeMinorGridlineStroke)) || (this.rangeZeroBaselineVisible != categoryPlot.rangeZeroBaselineVisible || !PaintUtilities.equal(this.rangeZeroBaselinePaint, categoryPlot.rangeZeroBaselinePaint) || !ObjectUtilities.equal((object) this.rangeZeroBaselineStroke, (object) categoryPlot.rangeZeroBaselineStroke)))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 178, (byte) 187, (byte) 140, (byte) 107, (byte) 112, (byte) 114, (byte) 99, (byte) 108, (byte) 232, (byte) 60, (byte) 230, (byte) 71, (byte) 182, (byte) 107, (byte) 112, (byte) 115, (byte) 100, (byte) 110, (byte) 233, (byte) 60, (byte) 230, (byte) 71, (byte) 150, (byte) 118, (byte) 112, (byte) 105, (byte) 100, (byte) 232, (byte) 61, (byte) 230, (byte) 70, (byte) 107, (byte) 113, (byte) 107, (byte) 145, (byte) 118, (byte) 104, (byte) 182, (byte) 104, (byte) 214, (byte) 118, (byte) 146, (byte) 146, (byte) 146, (byte) 146, (byte) 104, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CategoryPlot categoryPlot = (CategoryPlot) base.clone();
      categoryPlot.domainAxes = new ObjectList();
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
        if (categoryAxis != null)
        {
          CategoryAxis axis = (CategoryAxis) categoryAxis.clone();
          categoryPlot.setDomainAxis(index, axis);
        }
      }
      categoryPlot.domainAxisLocations = (ObjectList) this.domainAxisLocations.clone();
      categoryPlot.rangeAxes = new ObjectList();
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
        {
          ValueAxis axis = (ValueAxis) valueAxis.clone();
          categoryPlot.setRangeAxis(index, axis);
        }
      }
      categoryPlot.rangeAxisLocations = (ObjectList) this.rangeAxisLocations.clone();
      categoryPlot.datasets = (ObjectList) this.datasets.clone();
      for (int index = 0; index < categoryPlot.datasets.size(); ++index)
      {
        CategoryDataset dataset = categoryPlot.getDataset(index);
        if (dataset != null)
          dataset.addChangeListener((DatasetChangeListener) categoryPlot);
      }
      categoryPlot.datasetToDomainAxesMap = new TreeMap();
      categoryPlot.datasetToDomainAxesMap.putAll((Map) this.datasetToDomainAxesMap);
      categoryPlot.datasetToRangeAxesMap = new TreeMap();
      categoryPlot.datasetToRangeAxesMap.putAll((Map) this.datasetToRangeAxesMap);
      categoryPlot.renderers = (ObjectList) this.renderers.clone();
      if (this.fixedDomainAxisSpace != null)
        categoryPlot.fixedDomainAxisSpace = (AxisSpace) ObjectUtilities.clone((object) this.fixedDomainAxisSpace);
      if (this.fixedRangeAxisSpace != null)
        categoryPlot.fixedRangeAxisSpace = (AxisSpace) ObjectUtilities.clone((object) this.fixedRangeAxisSpace);
      categoryPlot.annotations = (List) ObjectUtilities.deepClone((Collection) this.annotations);
      categoryPlot.foregroundDomainMarkers = this.cloneMarkerMap(this.foregroundDomainMarkers);
      categoryPlot.backgroundDomainMarkers = this.cloneMarkerMap(this.backgroundDomainMarkers);
      categoryPlot.foregroundRangeMarkers = this.cloneMarkerMap(this.foregroundRangeMarkers);
      categoryPlot.backgroundRangeMarkers = this.cloneMarkerMap(this.backgroundRangeMarkers);
      if (this.fixedLegendItems != null)
        categoryPlot.fixedLegendItems = (LegendItemCollection) this.fixedLegendItems.clone();
      return (object) categoryPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 179, (byte) 24, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.domainGridlineStroke, obj0);
      SerialUtilities.writePaint(this.domainGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeGridlineStroke, obj0);
      SerialUtilities.writePaint(this.rangeGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeCrosshairStroke, obj0);
      SerialUtilities.writePaint(this.rangeCrosshairPaint, obj0);
      SerialUtilities.writeStroke(this.domainCrosshairStroke, obj0);
      SerialUtilities.writePaint(this.domainCrosshairPaint, obj0);
      SerialUtilities.writeStroke(this.rangeMinorGridlineStroke, obj0);
      SerialUtilities.writePaint(this.rangeMinorGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeZeroBaselineStroke, obj0);
      SerialUtilities.writePaint(this.rangeZeroBaselinePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 179, (byte) 50, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 112, (byte) 114, (byte) 99, (byte) 103, (byte) 231, (byte) 60, (byte) 230, (byte) 71, (byte) 112, (byte) 114, (byte) 99, (byte) 103, (byte) 231, (byte) 60, (byte) 230, (byte) 71, (byte) 108, (byte) 102, (byte) 115, (byte) 100, (byte) 232, (byte) 61, (byte) 230, (byte) 70, (byte) 108, (byte) 104, (byte) 148, (byte) 100, (byte) 232, (byte) 60, (byte) 232, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.domainGridlineStroke = SerialUtilities.readStroke(obj0);
      this.domainGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeGridlineStroke = SerialUtilities.readStroke(obj0);
      this.rangeGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeCrosshairStroke = SerialUtilities.readStroke(obj0);
      this.rangeCrosshairPaint = SerialUtilities.readPaint(obj0);
      this.domainCrosshairStroke = SerialUtilities.readStroke(obj0);
      this.domainCrosshairPaint = SerialUtilities.readPaint(obj0);
      this.rangeMinorGridlineStroke = SerialUtilities.readStroke(obj0);
      this.rangeMinorGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeZeroBaselineStroke = SerialUtilities.readStroke(obj0);
      this.rangeZeroBaselinePaint = SerialUtilities.readPaint(obj0);
      for (int index = 0; index < this.domainAxes.size(); ++index)
      {
        CategoryAxis categoryAxis = (CategoryAxis) this.domainAxes.get(index);
        if (categoryAxis != null)
        {
          categoryAxis.setPlot((Plot) this);
          categoryAxis.addChangeListener((AxisChangeListener) this);
        }
      }
      for (int index = 0; index < this.rangeAxes.size(); ++index)
      {
        ValueAxis valueAxis = (ValueAxis) this.rangeAxes.get(index);
        if (valueAxis != null)
        {
          valueAxis.setPlot((Plot) this);
          valueAxis.addChangeListener((AxisChangeListener) this);
        }
      }
      int num1 = this.datasets.size();
      for (int index = 0; index < num1; ++index)
      {
        Dataset dataset = (Dataset) this.datasets.get(index);
        if (dataset != null)
          dataset.addChangeListener((DatasetChangeListener) this);
      }
      int num2 = this.renderers.size();
      for (int index = 0; index < num2; ++index)
      {
        CategoryItemRenderer categoryItemRenderer = (CategoryItemRenderer) this.renderers.get(index);
        if (categoryItemRenderer != null)
          categoryItemRenderer.addChangeListener((RendererChangeListener) this);
      }
    }
  }
}
