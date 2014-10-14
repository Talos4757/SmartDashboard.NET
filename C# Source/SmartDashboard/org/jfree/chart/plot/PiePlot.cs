// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PiePlot
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
using org.jfree.chart;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class PiePlot : Plot, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -795612466005590431L;
    public const double DEFAULT_INTERIOR_GAP = 0.08;
    public const double MAX_INTERIOR_GAP = 0.4;
    public const double DEFAULT_START_ANGLE = 90.0;
    internal static Font __\u003C\u003EDEFAULT_LABEL_FONT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_PAINT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT;
    internal static Stroke __\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT;
    public const double DEFAULT_MINIMUM_ARC_ANGLE_TO_DRAW = 1E-05;
    private PieDataset dataset;
    private int pieIndex;
    private double interiorGap;
    private bool circular;
    private double startAngle;
    private Rotation direction;
    private PaintMap sectionPaintMap;
    [NonSerialized]
    private Paint baseSectionPaint;
    private bool autoPopulateSectionPaint;
    private bool sectionOutlinesVisible;
    private PaintMap sectionOutlinePaintMap;
    [NonSerialized]
    private Paint baseSectionOutlinePaint;
    private bool autoPopulateSectionOutlinePaint;
    private StrokeMap sectionOutlineStrokeMap;
    [NonSerialized]
    private Stroke baseSectionOutlineStroke;
    private bool autoPopulateSectionOutlineStroke;
    [NonSerialized]
    private Paint shadowPaint;
    private double shadowXOffset;
    private double shadowYOffset;
    private Map explodePercentages;
    private PieSectionLabelGenerator labelGenerator;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    [NonSerialized]
    private Paint labelBackgroundPaint;
    [NonSerialized]
    private Paint labelOutlinePaint;
    [NonSerialized]
    private Stroke labelOutlineStroke;
    [NonSerialized]
    private Paint labelShadowPaint;
    private bool simpleLabels;
    private RectangleInsets labelPadding;
    private RectangleInsets simpleLabelOffset;
    private double maximumLabelWidth;
    private double labelGap;
    private bool labelLinksVisible;
    private PieLabelLinkStyle labelLinkStyle;
    private double labelLinkMargin;
    [NonSerialized]
    private Paint labelLinkPaint;
    [NonSerialized]
    private Stroke labelLinkStroke;
    private AbstractPieLabelDistributor labelDistributor;
    private PieToolTipGenerator toolTipGenerator;
    private PieURLGenerator urlGenerator;
    private PieSectionLabelGenerator legendLabelGenerator;
    private PieSectionLabelGenerator legendLabelToolTipGenerator;
    private PieURLGenerator legendLabelURLGenerator;
    private bool ignoreNullValues;
    private bool ignoreZeroValues;
    [NonSerialized]
    private Shape legendItemShape;
    private double minimumArcAngleToDraw;
    protected internal static ResourceBundle localizationResources;
    internal const bool DEBUG_DRAW_INTERIOR = false;
    internal const bool DEBUG_DRAW_LINK_AREA = false;
    internal const bool DEBUG_DRAW_PIE_AREA = false;
    [Obsolete]
    [NonSerialized]
    private Paint sectionPaint;
    [Obsolete]
    [NonSerialized]
    private Paint sectionOutlinePaint;
    [Obsolete]
    [NonSerialized]
    private Stroke sectionOutlineStroke;

    [Modifiers]
    public static Font DEFAULT_LABEL_FONT
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_BACKGROUND_PAINT
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_OUTLINE_PAINT
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_LABEL_OUTLINE_STROKE
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_SHADOW_PAINT
    {
      [HideFromJava] get
      {
        return PiePlot.__\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 76, (byte) 101, (byte) 210, (byte) 170, (byte) 217, (byte) 170, (byte) 207, (byte) 254, (byte) 160, (byte) 223})]
    static PiePlot()
    {
      Plot.__\u003Cclinit\u003E();
      PiePlot.__\u003C\u003EDEFAULT_LABEL_FONT = new Font("SansSerif", 0, 10);
      PiePlot.__\u003C\u003EDEFAULT_LABEL_PAINT = (Paint) Color.black;
      PiePlot.__\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT = (Paint) new Color((int) byte.MaxValue, (int) byte.MaxValue, 192);
      PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT = (Paint) Color.black;
      PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE = (Stroke) new BasicStroke(0.5f);
      PiePlot.__\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT = (Paint) new Color(151, 151, 151, 128);
      PiePlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 232, (byte) 159, (byte) 72, (byte) 171, (byte) 176, (byte) 240, (byte) 107, (byte) 231, (byte) 82, (byte) 240, (byte) 70, (byte) 240, (byte) 74, (byte) 171, (byte) 176, (byte) 171, (byte) 240, (byte) 160, (byte) 93, (byte) 103, (byte) 99, (byte) 135, (byte) 135, (byte) 112, (byte) 103, (byte) 112, (byte) 107, (byte) 144, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 139, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 103, (byte) 140, (byte) 103, (byte) 159, (byte) 26, (byte) 159, (byte) 16, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 139, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PiePlot(PieDataset dataset)
    {
      PiePlot piePlot = this;
      this.shadowPaint = (Paint) Color.gray;
      this.shadowXOffset = 4.0;
      this.shadowYOffset = 4.0;
      this.simpleLabels = true;
      this.maximumLabelWidth = 0.14;
      this.labelGap = 0.025;
      this.labelLinkStyle = PieLabelLinkStyle.__\u003C\u003ESTANDARD;
      this.labelLinkMargin = 0.025;
      this.labelLinkPaint = (Paint) Color.black;
      this.labelLinkStroke = (Stroke) new BasicStroke(0.5f);
      this.dataset = dataset;
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.pieIndex = 0;
      this.interiorGap = 0.08;
      this.circular = true;
      this.startAngle = 90.0;
      this.direction = Rotation.__\u003C\u003ECLOCKWISE;
      this.minimumArcAngleToDraw = 1E-05;
      this.sectionPaint = (Paint) null;
      this.sectionPaintMap = new PaintMap();
      this.baseSectionPaint = (Paint) Color.gray;
      this.autoPopulateSectionPaint = true;
      this.sectionOutlinesVisible = true;
      this.sectionOutlinePaint = (Paint) null;
      this.sectionOutlinePaintMap = new PaintMap();
      this.baseSectionOutlinePaint = Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
      this.autoPopulateSectionOutlinePaint = false;
      this.sectionOutlineStroke = (Stroke) null;
      this.sectionOutlineStrokeMap = new StrokeMap();
      this.baseSectionOutlineStroke = Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
      this.autoPopulateSectionOutlineStroke = false;
      this.explodePercentages = (Map) new TreeMap();
      this.labelGenerator = (PieSectionLabelGenerator) new StandardPieSectionLabelGenerator();
      this.labelFont = PiePlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      this.labelPaint = PiePlot.__\u003C\u003EDEFAULT_LABEL_PAINT;
      this.labelBackgroundPaint = PiePlot.__\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT;
      this.labelOutlinePaint = PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT;
      this.labelOutlineStroke = PiePlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE;
      this.labelShadowPaint = PiePlot.__\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT;
      this.labelLinksVisible = true;
      this.labelDistributor = (AbstractPieLabelDistributor) new PieLabelDistributor(0);
      this.simpleLabels = false;
      RectangleInsets.__\u003Cclinit\u003E();
      this.simpleLabelOffset = new RectangleInsets(UnitType.__\u003C\u003ERELATIVE, 0.18, 0.18, 0.18, 0.18);
      this.labelPadding = new RectangleInsets(2.0, 2.0, 2.0, 2.0);
      this.toolTipGenerator = (PieToolTipGenerator) null;
      this.urlGenerator = (PieURLGenerator) null;
      this.legendLabelGenerator = (PieSectionLabelGenerator) new StandardPieSectionLabelGenerator();
      this.legendLabelToolTipGenerator = (PieSectionLabelGenerator) null;
      this.legendLabelURLGenerator = (PieURLGenerator) null;
      this.legendItemShape = Plot.__\u003C\u003EDEFAULT_LEGEND_ITEM_CIRCLE;
      this.ignoreNullValues = false;
      this.ignoreZeroValues = false;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 164, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PiePlot()
      : this((PieDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PiePlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PiePlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PiePlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 166, (byte) 11, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelGenerator(PieSectionLabelGenerator generator)
    {
      this.labelGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 253, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setToolTipGenerator(PieToolTipGenerator generator)
    {
      this.toolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 21, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setURLGenerator(PieURLGenerator generator)
    {
      this.urlGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 135, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionPaint(IComparable key, Paint paint)
    {
      this.sectionPaintMap.put(key, paint);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 251, (byte) 103, (byte) 99, (byte) 199, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(PieDataset dataset)
    {
      PieDataset pieDataset = this.dataset;
      if (pieDataset != null)
        pieDataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 171, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.labelLinkPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 117, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.labelLinkStyle = style;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 240, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFont = font;
        this.fireChangeEvent();
      }
    }

    public virtual bool getAutoPopulateSectionPaint()
    {
      return this.autoPopulateSectionPaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 140, (byte) 130, (byte) 107, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSectionPaints(bool notify)
    {
      int num = notify ? 1 : 0;
      this.sectionPaintMap.clear();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool getAutoPopulateSectionOutlinePaint()
    {
      return this.autoPopulateSectionOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 86, (byte) 130, (byte) 107, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSectionOutlinePaints(bool notify)
    {
      int num = notify ? 1 : 0;
      this.sectionOutlinePaintMap.clear();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool getAutoPopulateSectionOutlineStroke()
    {
      return this.autoPopulateSectionOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 39, (byte) 162, (byte) 107, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSectionOutlineStrokes(bool notify)
    {
      int num = notify ? 1 : 0;
      this.sectionOutlineStrokeMap.clear();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 119, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlinesVisible(bool visible)
    {
      this.sectionOutlinesVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 194, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIgnoreNullValues(bool flag)
    {
      this.ignoreNullValues = flag;
      this.fireChangeEvent();
    }

    public virtual void setPieIndex(int index)
    {
      this.pieIndex = index;
    }

    [LineNumberTable((ushort) 998)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSectionPaint(IComparable key)
    {
      return this.sectionPaintMap.getPaint(key);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 201, (byte) 68, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCircular(bool circular, bool notify)
    {
      int num1 = circular ? 1 : 0;
      int num2 = notify ? 1 : 0;
      this.circular = num1 != 0;
      if (num2 == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 175, (byte) 130, (byte) 103, (byte) 99, (byte) 194, (byte) 109, (byte) 99, (byte) 194, (byte) 99, (byte) 103, (byte) 99, (byte) 103, (byte) 175, (byte) 135, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint lookupSectionPaint(IComparable key, bool autoPopulate)
    {
      int num = autoPopulate ? 1 : 0;
      Paint sectionPaint = this.getSectionPaint();
      if (sectionPaint != null)
        return sectionPaint;
      Paint paint1 = this.sectionPaintMap.getPaint(key);
      if (paint1 != null)
        return paint1;
      Paint paint2;
      if (num != 0)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          paint2 = drawingSupplier.getNextPaint();
          this.sectionPaintMap.put(key, paint2);
        }
        else
          paint2 = this.baseSectionPaint;
      }
      else
        paint2 = this.baseSectionPaint;
      return paint2;
    }

    [Obsolete]
    public virtual Paint getSectionPaint()
    {
      return this.sectionPaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 106, (byte) 66, (byte) 103, (byte) 99, (byte) 194, (byte) 109, (byte) 99, (byte) 194, (byte) 99, (byte) 103, (byte) 99, (byte) 103, (byte) 175, (byte) 135, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint lookupSectionOutlinePaint(IComparable key, bool autoPopulate)
    {
      int num = autoPopulate ? 1 : 0;
      Paint sectionOutlinePaint = this.getSectionOutlinePaint();
      if (sectionOutlinePaint != null)
        return sectionOutlinePaint;
      Paint paint1 = this.sectionOutlinePaintMap.getPaint(key);
      if (paint1 != null)
        return paint1;
      Paint paint2;
      if (num != 0)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          paint2 = drawingSupplier.getNextOutlinePaint();
          this.sectionOutlinePaintMap.put(key, paint2);
        }
        else
          paint2 = this.baseSectionOutlinePaint;
      }
      else
        paint2 = this.baseSectionOutlinePaint;
      return paint2;
    }

    [Obsolete]
    public virtual Paint getSectionOutlinePaint()
    {
      return this.sectionOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 59, (byte) 98, (byte) 103, (byte) 99, (byte) 194, (byte) 109, (byte) 99, (byte) 194, (byte) 99, (byte) 103, (byte) 99, (byte) 103, (byte) 175, (byte) 135, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Stroke lookupSectionOutlineStroke(IComparable key, bool autoPopulate)
    {
      int num = autoPopulate ? 1 : 0;
      Stroke sectionOutlineStroke = this.getSectionOutlineStroke();
      if (sectionOutlineStroke != null)
        return sectionOutlineStroke;
      Stroke stroke1 = this.sectionOutlineStrokeMap.getStroke(key);
      if (stroke1 != null)
        return stroke1;
      Stroke stroke2;
      if (num != 0)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          stroke2 = drawingSupplier.getNextOutlineStroke();
          this.sectionOutlineStrokeMap.put(key, stroke2);
        }
        else
          stroke2 = this.baseSectionOutlineStroke;
      }
      else
        stroke2 = this.baseSectionOutlineStroke;
      return stroke2;
    }

    [Obsolete]
    public virtual Stroke getSectionOutlineStroke()
    {
      return this.sectionOutlineStroke;
    }

    public virtual PieDataset getDataset()
    {
      return this.dataset;
    }

    public virtual double getStartAngle()
    {
      return this.startAngle;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 252, (byte) 172, (byte) 102, (byte) 112, (byte) 143, (byte) 155, (byte) 249, (byte) 80, (byte) 117, (byte) 117, (byte) 107, (byte) 171, (byte) 107, (byte) 118, (byte) 120, (byte) 120, (byte) 111, (byte) 239, (byte) 69, (byte) 143, (byte) 232, (byte) 77, (byte) 103, (byte) 104, (byte) 136, (byte) 119, (byte) 119, (byte) 191, (byte) 16, (byte) 232, (byte) 69, (byte) 105, (byte) 142, (byte) 109, (byte) 109, (byte) 255, (byte) 36, (byte) 72, (byte) 104, (byte) 109, (byte) 109, (byte) 119, (byte) 183, (byte) 159, (byte) 2, (byte) 109, (byte) 174, (byte) 104, (byte) 108, (byte) 103, (byte) 110, (byte) 111, (byte) 100, (byte) 106, (byte) 105, (byte) 104, (byte) 238, (byte) 58, (byte) 8, (byte) 235, (byte) 77, (byte) 104, (byte) 209, (byte) 175, (byte) 130, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawPie(Graphics2D g2, Rectangle2D plotArea, PlotRenderingInfo info)
    {
      PiePlotState state = this.initialise(g2, plotArea, this, (Integer) null, info);
      double num1 = 0.0;
      if (this.labelGenerator != null && !this.simpleLabels)
        num1 = this.labelGap + this.maximumLabelWidth;
      double num2 = ((RectangularShape) plotArea).getWidth() * (this.interiorGap + num1) * 2.0;
      double num3 = ((RectangularShape) plotArea).getHeight() * this.interiorGap * 2.0;
      double num4 = ((RectangularShape) plotArea).getX() + num2 / 2.0;
      double num5 = ((RectangularShape) plotArea).getY() + num3 / 2.0;
      double num6 = ((RectangularShape) plotArea).getWidth() - num2;
      double num7 = ((RectangularShape) plotArea).getHeight() - num3;
      if (this.circular)
      {
        double num8 = Math.min(num6, num7) / 2.0;
        num4 = (num4 + num4 + num6) / 2.0 - num8;
        num5 = (num5 + num5 + num7) / 2.0 - num8;
        num6 = 2.0 * num8;
        num7 = 2.0 * num8;
      }
      Rectangle2D.Double double1 = new Rectangle2D.Double(num4, num5, num6, num7);
      state.setLinkArea((Rectangle2D) double1);
      double num9 = 0.0;
      if (!this.simpleLabels)
        num9 = this.labelLinkMargin;
      double num10 = ((RectangularShape) double1).getWidth() * num9 * 2.0;
      double num11 = ((RectangularShape) double1).getHeight() * num9 * 2.0;
      Rectangle2D.Double double2 = new Rectangle2D.Double(num4 + num10 / 2.0, num5 + num11 / 2.0, num6 - num10, num7 - num11);
      state.setExplodedPieArea((Rectangle2D) double2);
      double maximumExplodePercent = this.getMaximumExplodePercent();
      double num12 = maximumExplodePercent / (1.0 + maximumExplodePercent);
      double num13 = ((RectangularShape) double2).getWidth() * num12;
      double num14 = ((RectangularShape) double2).getHeight() * num12;
      Rectangle2D.Double double3 = new Rectangle2D.Double(((RectangularShape) double2).getX() + num13 / 2.0, ((RectangularShape) double2).getY() + num14 / 2.0, ((RectangularShape) double2).getWidth() - num13, ((RectangularShape) double2).getHeight() - num14);
      state.setPieArea((Rectangle2D) double3);
      state.setPieCenterX(((RectangularShape) double3).getCenterX());
      state.setPieCenterY(((RectangularShape) double3).getCenterY());
      state.setPieWRadius(((RectangularShape) double3).getWidth() / 2.0);
      state.setPieHRadius(((RectangularShape) double3).getHeight() / 2.0);
      if (this.dataset != null && this.dataset.getKeys().size() > 0)
      {
        List keys = this.dataset.getKeys();
        double totalValue = DatasetUtilities.calculatePieDatasetTotal(this.dataset);
        int passesRequired = state.getPassesRequired();
        for (int currentPass = 0; currentPass < passesRequired; ++currentPass)
        {
          double num8 = 0.0;
          for (int index = 0; index < keys.size(); ++index)
          {
            Number number = this.dataset.getValue(index);
            if (number != null)
            {
              double num15 = number.doubleValue();
              if (num15 > 0.0)
              {
                num8 += num15;
                this.drawItem(g2, index, (Rectangle2D) double2, state, currentPass);
              }
            }
          }
        }
        if (this.simpleLabels)
          this.drawSimpleLabels(g2, keys, totalValue, plotArea, (Rectangle2D) double1, state);
        else
          this.drawLabels(g2, keys, totalValue, plotArea, (Rectangle2D) double1, state);
      }
      else
        this.drawNoDataMessage(g2, plotArea);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 184, (byte) 104, (byte) 103, (byte) 104, (byte) 177, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PiePlotState initialise(Graphics2D g2, Rectangle2D plotArea, PiePlot plot, Integer index, PlotRenderingInfo info)
    {
      PiePlotState piePlotState = new PiePlotState(info);
      piePlotState.setPassesRequired(2);
      if (this.dataset != null)
        piePlotState.setTotal(DatasetUtilities.calculatePieDatasetTotal(plot.getDataset()));
      piePlotState.setLatestAngle(plot.getStartAngle());
      return piePlotState;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 232, (byte) 104, (byte) 134, (byte) 102, (byte) 113, (byte) 104, (byte) 108, (byte) 114, (byte) 99, (byte) 142, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaximumExplodePercent()
    {
      if (this.dataset == null)
        return 0.0;
      double num = 0.0;
      Iterator iterator = this.dataset.getKeys().iterator();
      while (iterator.hasNext())
      {
        Number number = (Number) this.explodePercentages.get((object) (IComparable) iterator.next());
        if (number != null)
          num = Math.max(num, number.doubleValue());
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 132, (byte) 109, (byte) 99, (byte) 129, (byte) 104, (byte) 102, (byte) 134, (byte) 109, (byte) 105, (byte) 153, (byte) 109, (byte) 105, (byte) 185, (byte) 176, (byte) 102, (byte) 114, (byte) 103, (byte) 105, (byte) 105, (byte) 141, (byte) 155, (byte) 173, (byte) 100, (byte) 107, (byte) 185, (byte) 108, (byte) 104, (byte) 133, (byte) 104, (byte) 105, (byte) 106, (byte) 104, (byte) 136, (byte) 106, (byte) 106, (byte) 104, (byte) 104, (byte) 104, (byte) 232, (byte) 69, (byte) 108, (byte) 105, (byte) 103, (byte) 99, (byte) 104, (byte) 181, (byte) 99, (byte) 104, (byte) 187, (byte) 188, (byte) 233, (byte) 69, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItem(Graphics2D g2, int section, Rectangle2D dataArea, PiePlotState state, int currentPass)
    {
      Number number = this.dataset.getValue(section);
      if (number == null)
        return;
      double num = number.doubleValue();
      double latestAngle;
      double angle;
      if (this.direction == Rotation.__\u003C\u003ECLOCKWISE)
      {
        latestAngle = state.getLatestAngle();
        angle = latestAngle - num / state.getTotal() * 360.0;
      }
      else if (this.direction == Rotation.__\u003C\u003EANTICLOCKWISE)
      {
        latestAngle = state.getLatestAngle();
        angle = latestAngle + num / state.getTotal() * 360.0;
      }
      else
      {
        string str = "Rotation type not recognised.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
      double extent = angle - latestAngle;
      if (Math.abs(extent) > this.getMinimumArcAngleToDraw())
      {
        double explodePercent = 0.0;
        double maximumExplodePercent = this.getMaximumExplodePercent();
        if (maximumExplodePercent > 0.0)
          explodePercent = this.getExplodePercent(section) / maximumExplodePercent;
        Arc2D.Double @double = new Arc2D.Double(this.getArcBounds(state.getPieArea(), state.getExplodedPieArea(), latestAngle, extent, explodePercent), latestAngle, extent, 2);
        if (currentPass == 0)
        {
          if (this.shadowPaint != null)
          {
            Shape translatedShape = ShapeUtilities.createTranslatedShape((Shape) @double, this.shadowXOffset, this.shadowYOffset);
            g2.setPaint(this.shadowPaint);
            g2.fill(translatedShape);
          }
        }
        else if (currentPass == 1)
        {
          IComparable sectionKey = this.getSectionKey(section);
          Paint paint1 = this.lookupSectionPaint(sectionKey);
          g2.setPaint(paint1);
          g2.fill((Shape) @double);
          Paint paint2 = this.lookupSectionOutlinePaint(sectionKey);
          Stroke stroke = this.lookupSectionOutlineStroke(sectionKey);
          if (this.sectionOutlinesVisible)
          {
            g2.setPaint(paint2);
            g2.setStroke(stroke);
            g2.draw((Shape) @double);
          }
          if (state.getInfo() != null)
          {
            EntityCollection entityCollection = state.getEntityCollection();
            if (entityCollection != null)
            {
              string toolTipText = (string) null;
              if (this.toolTipGenerator != null)
                toolTipText = this.toolTipGenerator.generateToolTip(this.dataset, sectionKey);
              string urlText = (string) null;
              if (this.urlGenerator != null)
                urlText = this.urlGenerator.generateURL(this.dataset, sectionKey, this.pieIndex);
              PieSectionEntity pieSectionEntity = new PieSectionEntity((Shape) @double, this.dataset, this.pieIndex, section, sectionKey, toolTipText, urlText);
              entityCollection.add((ChartEntity) pieSectionEntity);
            }
          }
        }
      }
      state.setLatestAngle(angle);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 229, (byte) 103, (byte) 177, (byte) 159, (byte) 21, (byte) 105, (byte) 102, (byte) 104, (byte) 108, (byte) 110, (byte) 98, (byte) 103, (byte) 111, (byte) 100, (byte) 176, (byte) 106, (byte) 191, (byte) 7, (byte) 103, (byte) 166, (byte) 191, (byte) 18, (byte) 152, (byte) 115, (byte) 147, (byte) 104, (byte) 100, (byte) 133, (byte) 145, (byte) 100, (byte) 133, (byte) 108, (byte) 104, (byte) 108, (byte) 143, (byte) 159, (byte) 0, (byte) 104, (byte) 149, (byte) 108, (byte) 136, (byte) 104, (byte) 108, (byte) 136, (byte) 144, (byte) 108, (byte) 108, (byte) 168, (byte) 108, (byte) 108, (byte) 255, (byte) 6, (byte) 69, (byte) 133, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawSimpleLabels(Graphics2D g2, List keys, double totalValue, Rectangle2D plotArea, Rectangle2D pieArea, PiePlotState state)
    {
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, 1f));
      RectangleInsets.__\u003Cclinit\u003E();
      Rectangle2D insetRectangle = new RectangleInsets(UnitType.__\u003C\u003ERELATIVE, 0.18, 0.18, 0.18, 0.18).createInsetRectangle(pieArea);
      double num1 = 0.0;
      Iterator iterator = keys.iterator();
      while (iterator.hasNext())
      {
        IComparable c = (IComparable) iterator.next();
        double num2 = 0.0;
        Number number = this.getDataset().getValue(c);
        int num3;
        if (number == null)
        {
          num3 = this.getIgnoreNullValues() ? 0 : 1;
        }
        else
        {
          num2 = number.doubleValue();
          num3 = !this.getIgnoreZeroValues() ? (num2 < 0.0 ? 0 : 1) : (num2 <= 0.0 ? 0 : 1);
        }
        if (num3 != 0)
        {
          num1 += num2;
          double num4 = this.getStartAngle() + this.getDirection().getFactor() * ((num1 - num2 / 2.0) * 360.0) / totalValue;
          Arc2D.Double @double = new Arc2D.Double(insetRectangle, this.getStartAngle(), num4 - this.getStartAngle(), 0);
          int num5 = ByteCodeHelper.d2i(((Arc2D) @double).getEndPoint().getX());
          int num6 = ByteCodeHelper.d2i(((Arc2D) @double).getEndPoint().getY());
          PieSectionLabelGenerator labelGenerator = this.getLabelGenerator();
          if (labelGenerator != null)
          {
            string text = labelGenerator.generateSectionLabel(this.dataset, c);
            if (text != null)
            {
              ((Graphics) g2).setFont(this.labelFont);
              FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
              Rectangle2D textBounds = TextUtilities.getTextBounds(text, g2, fontMetrics);
              Shape translatedShape1 = ShapeUtilities.createTranslatedShape((Shape) this.labelPadding.createOutsetRectangle(textBounds), (double) num5 - ((RectangularShape) textBounds).getCenterX(), (double) num6 - ((RectangularShape) textBounds).getCenterY());
              if (this.labelShadowPaint != null)
              {
                Shape translatedShape2 = ShapeUtilities.createTranslatedShape(translatedShape1, this.shadowXOffset, this.shadowYOffset);
                g2.setPaint(this.labelShadowPaint);
                g2.fill(translatedShape2);
              }
              if (this.labelBackgroundPaint != null)
              {
                g2.setPaint(this.labelBackgroundPaint);
                g2.fill(translatedShape1);
              }
              if (this.labelOutlinePaint != null && this.labelOutlineStroke != null)
              {
                g2.setPaint(this.labelOutlinePaint);
                g2.setStroke(this.labelOutlineStroke);
                g2.draw(translatedShape1);
              }
              g2.setPaint(this.labelPaint);
              ((Graphics) g2).setFont(this.labelFont);
              TextUtilities.drawAlignedString(this.getLabelGenerator().generateSectionLabel(this.getDataset(), c), g2, (float) num5, (float) num6, TextAnchor.__\u003C\u003ECENTER);
            }
          }
        }
      }
      g2.setComposite(composite);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 67, (byte) 103, (byte) 209, (byte) 102, (byte) 134, (byte) 102, (byte) 104, (byte) 108, (byte) 110, (byte) 98, (byte) 103, (byte) 111, (byte) 100, (byte) 176, (byte) 106, (byte) 191, (byte) 7, (byte) 103, (byte) 166, (byte) 159, (byte) 18, (byte) 115, (byte) 177, (byte) 175, (byte) 133, (byte) 204, (byte) 153, (byte) 113, (byte) 112, (byte) 176, (byte) 104, (byte) 144, (byte) 176, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLabels(Graphics2D g2, List keys, double totalValue, Rectangle2D plotArea, Rectangle2D linkArea, PiePlotState state)
    {
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, 1f));
      DefaultKeyedValues defaultKeyedValues1 = new DefaultKeyedValues();
      DefaultKeyedValues defaultKeyedValues2 = new DefaultKeyedValues();
      double num1 = 0.0;
      Iterator iterator = keys.iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        double num2 = 0.0;
        Number number = this.dataset.getValue(comparable);
        int num3;
        if (number == null)
        {
          num3 = this.ignoreNullValues ? 0 : 1;
        }
        else
        {
          num2 = number.doubleValue();
          num3 = !this.ignoreZeroValues ? (num2 < 0.0 ? 0 : 1) : (num2 <= 0.0 ? 0 : 1);
        }
        if (num3 != 0)
        {
          num1 += num2;
          double num4 = this.startAngle + this.direction.getFactor() * ((num1 - num2 / 2.0) * 360.0) / totalValue;
          if (Math.cos(Math.toRadians(num4)) < 0.0)
            defaultKeyedValues1.addValue(comparable, (Number) new Double(num4));
          else
            defaultKeyedValues2.addValue(comparable, (Number) new Double(num4));
        }
      }
      ((Graphics) g2).setFont(this.getLabelFont());
      double num5 = ((RectangularShape) plotArea).getX() + this.interiorGap * ((RectangularShape) plotArea).getWidth();
      double num6 = ((RectangularShape) plotArea).getWidth() * this.labelGap;
      float maxLabelWidth = (float) this.labelPadding.trimWidth(((RectangularShape) linkArea).getX() - num6 - num5);
      if (this.labelGenerator != null)
      {
        this.drawLeftLabels((KeyedValues) defaultKeyedValues1, g2, plotArea, linkArea, maxLabelWidth, state);
        this.drawRightLabels((KeyedValues) defaultKeyedValues2, g2, plotArea, linkArea, maxLabelWidth, state);
      }
      g2.setComposite(composite);
    }

    public virtual double getMinimumArcAngleToDraw()
    {
      return this.minimumArcAngleToDraw;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 153, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getExplodePercent(int section)
    {
      return this.getExplodePercent(this.getSectionKey(section));
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 76, (byte) 106, (byte) 162, (byte) 151, (byte) 103, (byte) 151, (byte) 103, (byte) 116, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Rectangle2D getArcBounds(Rectangle2D unexploded, Rectangle2D exploded, double angle, double extent, double explodePercent)
    {
      if (explodePercent == 0.0)
        return unexploded;
      Point2D endPoint1 = ((Arc2D) new Arc2D.Double(unexploded, angle, extent / 2.0, 0)).getEndPoint();
      Point2D endPoint2 = ((Arc2D) new Arc2D.Double(exploded, angle, extent / 2.0, 0)).getEndPoint();
      double num1 = (endPoint1.getX() - endPoint2.getX()) * explodePercent;
      double num2 = (endPoint1.getY() - endPoint2.getY()) * explodePercent;
      return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) unexploded).getX() - num1, ((RectangularShape) unexploded).getY() - num2, ((RectangularShape) unexploded).getWidth(), ((RectangularShape) unexploded).getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 86, (byte) 98, (byte) 104, (byte) 114, (byte) 173, (byte) 104, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual IComparable getSectionKey(int section)
    {
      object obj1 = (object) null;
      if (this.dataset != null && section >= 0 && section < this.dataset.getItemCount())
        obj1 = (object) this.dataset.getKey(section);
      if ((IComparable) obj1 == null)
        obj1 = (object) new Integer(section);
      object obj2 = obj1;
      if (obj2 == null)
        return (IComparable) null;
      IComparable comparable = obj2 as IComparable;
      if (comparable != null)
        return comparable;
      else
        throw new IncompatibleClassChangeError();
    }

    [LineNumberTable((ushort) 865)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint lookupSectionPaint(IComparable key)
    {
      return this.lookupSectionPaint(key, this.getAutoPopulateSectionPaint());
    }

    [LineNumberTable((ushort) 1137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint lookupSectionOutlinePaint(IComparable key)
    {
      return this.lookupSectionOutlinePaint(key, this.getAutoPopulateSectionOutlinePaint());
    }

    [LineNumberTable((ushort) 1326)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Stroke lookupSectionOutlineStroke(IComparable key)
    {
      return this.lookupSectionOutlineStroke(key, this.getAutoPopulateSectionOutlineStroke());
    }

    public virtual bool getIgnoreNullValues()
    {
      return this.ignoreNullValues;
    }

    public virtual bool getIgnoreZeroValues()
    {
      return this.ignoreZeroValues;
    }

    public virtual Rotation getDirection()
    {
      return this.direction;
    }

    public virtual PieSectionLabelGenerator getLabelGenerator()
    {
      return this.labelGenerator;
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 142, (byte) 107, (byte) 111, (byte) 120, (byte) 110, (byte) 153, (byte) 102, (byte) 189, (byte) 105, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 148, (byte) 148, (byte) 139, (byte) 255, (byte) 58, (byte) 45, (byte) 233, (byte) 90, (byte) 105, (byte) 108, (byte) 159, (byte) 4, (byte) 114, (byte) 54, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLeftLabels(KeyedValues leftKeys, Graphics2D g2, Rectangle2D plotArea, Rectangle2D linkArea, float maxLabelWidth, PiePlotState state)
    {
      this.labelDistributor.clear();
      double num1 = ((RectangularShape) plotArea).getWidth() * this.labelGap;
      double num2 = ((RectangularShape) state.getLinkArea()).getHeight() / 2.0;
      for (int i = 0; i < leftKeys.getItemCount(); ++i)
      {
        string text = this.labelGenerator.generateSectionLabel(this.dataset, leftKeys.getKey(i));
        if (text != null)
        {
          TextBox label = new TextBox(TextUtilities.createTextBlock(text, this.labelFont, this.labelPaint, maxLabelWidth, (TextMeasurer) new G2TextMeasurer(g2)));
          label.setBackgroundPaint(this.labelBackgroundPaint);
          label.setOutlinePaint(this.labelOutlinePaint);
          label.setOutlineStroke(this.labelOutlineStroke);
          label.setShadowPaint(this.labelShadowPaint);
          label.setInteriorGap(this.labelPadding);
          double angle = Math.toRadians(leftKeys.getValue(i).doubleValue());
          double baseY = state.getPieCenterY() - Math.sin(angle) * num2;
          double height = label.getHeight(g2);
          this.labelDistributor.addPieLabelRecord(new PieLabelRecord(leftKeys.getKey(i), angle, baseY, label, height, num1 / 2.0 + num1 / 2.0 * -Math.cos(angle), 1.0 - this.getLabelLinkDepth() + this.getExplodePercent(leftKeys.getKey(i))));
        }
      }
      double height1 = ((RectangularShape) plotArea).getHeight();
      double num3 = height1 * this.getInteriorGap();
      this.labelDistributor.distributeLabels(((RectangularShape) plotArea).getMinY() + num3, height1 - 2.0 * num3);
      for (int index = 0; index < this.labelDistributor.getItemCount(); ++index)
        this.drawLeftLabel(g2, state, this.labelDistributor.getPieLabelRecord(index));
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 196, (byte) 107, (byte) 111, (byte) 152, (byte) 110, (byte) 185, (byte) 102, (byte) 189, (byte) 105, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 116, (byte) 148, (byte) 107, (byte) 255, (byte) 57, (byte) 46, (byte) 233, (byte) 89, (byte) 105, (byte) 108, (byte) 159, (byte) 4, (byte) 114, (byte) 54, (byte) 232, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRightLabels(KeyedValues keys, Graphics2D g2, Rectangle2D plotArea, Rectangle2D linkArea, float maxLabelWidth, PiePlotState state)
    {
      this.labelDistributor.clear();
      double num1 = ((RectangularShape) plotArea).getWidth() * this.labelGap;
      double num2 = ((RectangularShape) state.getLinkArea()).getHeight() / 2.0;
      for (int i = 0; i < keys.getItemCount(); ++i)
      {
        string text = this.labelGenerator.generateSectionLabel(this.dataset, keys.getKey(i));
        if (text != null)
        {
          TextBox label = new TextBox(TextUtilities.createTextBlock(text, this.labelFont, this.labelPaint, maxLabelWidth, (TextMeasurer) new G2TextMeasurer(g2)));
          label.setBackgroundPaint(this.labelBackgroundPaint);
          label.setOutlinePaint(this.labelOutlinePaint);
          label.setOutlineStroke(this.labelOutlineStroke);
          label.setShadowPaint(this.labelShadowPaint);
          label.setInteriorGap(this.labelPadding);
          double angle = Math.toRadians(keys.getValue(i).doubleValue());
          double baseY = state.getPieCenterY() - Math.sin(angle) * num2;
          double height = label.getHeight(g2);
          this.labelDistributor.addPieLabelRecord(new PieLabelRecord(keys.getKey(i), angle, baseY, label, height, num1 / 2.0 + num1 / 2.0 * Math.cos(angle), 1.0 - this.getLabelLinkDepth() + this.getExplodePercent(keys.getKey(i))));
        }
      }
      double height1 = ((RectangularShape) plotArea).getHeight();
      double num3 = height1 * this.getInteriorGap();
      this.labelDistributor.distributeLabels(((RectangularShape) plotArea).getMinY() + num3, height1 - 2.0 * num3);
      for (int index = 0; index < this.labelDistributor.getItemCount(); ++index)
        this.drawRightLabel(g2, state, this.labelDistributor.getPieLabelRecord(index));
    }

    protected internal virtual double getLabelLinkDepth()
    {
      return 0.1;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 194, (byte) 102, (byte) 104, (byte) 114, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getExplodePercent(IComparable key)
    {
      double num = 0.0;
      if (this.explodePercentages != null)
      {
        Number number = (Number) this.explodePercentages.get((object) key);
        if (number != null)
          num = number.doubleValue();
      }
      return num;
    }

    public virtual double getInteriorGap()
    {
      return this.interiorGap;
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 104, (byte) 109, (byte) 106, (byte) 136, (byte) 107, (byte) 104, (byte) 158, (byte) 158, (byte) 159, (byte) 7, (byte) 159, (byte) 7, (byte) 100, (byte) 108, (byte) 108, (byte) 104, (byte) 110, (byte) 115, (byte) 114, (byte) 149, (byte) 110, (byte) 103, (byte) 112, (byte) 104, (byte) 115, (byte) 98, (byte) 110, (byte) 103, (byte) 148, (byte) 168, (byte) 104, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLeftLabel(Graphics2D g2, PiePlotState state, PieLabelRecord record)
    {
      double minX = ((RectangularShape) state.getLinkArea()).getMinX();
      double num1 = minX - record.getGap();
      double allocatedY = record.getAllocatedY();
      if (this.labelLinksVisible)
      {
        double angle = record.getAngle();
        double num2 = state.getPieCenterX() + Math.cos(angle) * state.getPieWRadius() * record.getLinkPercent();
        double num3 = state.getPieCenterY() - Math.sin(angle) * state.getPieHRadius() * record.getLinkPercent();
        double num4 = state.getPieCenterX() + Math.cos(angle) * ((RectangularShape) state.getLinkArea()).getWidth() / 2.0;
        double num5 = state.getPieCenterY() - Math.sin(angle) * ((RectangularShape) state.getLinkArea()).getHeight() / 2.0;
        double num6 = num5;
        g2.setPaint(this.labelLinkPaint);
        g2.setStroke(this.labelLinkStroke);
        PieLabelLinkStyle labelLinkStyle = this.getLabelLinkStyle();
        if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003ESTANDARD))
        {
          g2.draw((Shape) new Line2D.Double(num2, num3, num4, num5));
          g2.draw((Shape) new Line2D.Double(minX, num6, num4, num5));
          g2.draw((Shape) new Line2D.Double(minX, num6, num1, allocatedY));
        }
        else if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003EQUAD_CURVE))
        {
          QuadCurve2D.Float @float = new QuadCurve2D.Float();
          ((QuadCurve2D) @float).setCurve(num1, allocatedY, minX, num6, num4, num5);
          g2.draw((Shape) @float);
          g2.draw((Shape) new Line2D.Double(num4, num5, num2, num3));
        }
        else if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE))
        {
          CubicCurve2D.Float @float = new CubicCurve2D.Float();
          ((CubicCurve2D) @float).setCurve(num1, allocatedY, minX, num6, num4, num5, num2, num3);
          g2.draw((Shape) @float);
        }
      }
      record.getLabel().draw(g2, (float) num1, (float) allocatedY, RectangleAnchor.__\u003C\u003ERIGHT);
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 155, (byte) 109, (byte) 106, (byte) 136, (byte) 107, (byte) 104, (byte) 158, (byte) 158, (byte) 159, (byte) 7, (byte) 159, (byte) 7, (byte) 100, (byte) 108, (byte) 108, (byte) 104, (byte) 110, (byte) 115, (byte) 114, (byte) 149, (byte) 110, (byte) 103, (byte) 112, (byte) 104, (byte) 115, (byte) 98, (byte) 110, (byte) 103, (byte) 148, (byte) 200, (byte) 104, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRightLabel(Graphics2D g2, PiePlotState state, PieLabelRecord record)
    {
      double maxX = ((RectangularShape) state.getLinkArea()).getMaxX();
      double num1 = maxX + record.getGap();
      double allocatedY = record.getAllocatedY();
      if (this.labelLinksVisible)
      {
        double angle = record.getAngle();
        double num2 = state.getPieCenterX() + Math.cos(angle) * state.getPieWRadius() * record.getLinkPercent();
        double num3 = state.getPieCenterY() - Math.sin(angle) * state.getPieHRadius() * record.getLinkPercent();
        double num4 = state.getPieCenterX() + Math.cos(angle) * ((RectangularShape) state.getLinkArea()).getWidth() / 2.0;
        double num5 = state.getPieCenterY() - Math.sin(angle) * ((RectangularShape) state.getLinkArea()).getHeight() / 2.0;
        double num6 = num5;
        g2.setPaint(this.labelLinkPaint);
        g2.setStroke(this.labelLinkStroke);
        PieLabelLinkStyle labelLinkStyle = this.getLabelLinkStyle();
        if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003ESTANDARD))
        {
          g2.draw((Shape) new Line2D.Double(num2, num3, num4, num5));
          g2.draw((Shape) new Line2D.Double(maxX, num6, num4, num5));
          g2.draw((Shape) new Line2D.Double(maxX, num6, num1, allocatedY));
        }
        else if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003EQUAD_CURVE))
        {
          QuadCurve2D.Float @float = new QuadCurve2D.Float();
          ((QuadCurve2D) @float).setCurve(num1, allocatedY, maxX, num6, num4, num5);
          g2.draw((Shape) @float);
          g2.draw((Shape) new Line2D.Double(num4, num5, num2, num3));
        }
        else if (labelLinkStyle.equals((object) PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE))
        {
          CubicCurve2D.Float @float = new CubicCurve2D.Float();
          ((CubicCurve2D) @float).setCurve(num1, allocatedY, maxX, num6, num4, num5, num2, num3);
          g2.draw((Shape) @float);
        }
      }
      record.getLabel().draw(g2, (float) num1, (float) allocatedY, RectangleAnchor.__\u003C\u003ELEFT);
    }

    public virtual Shape getLegendItemShape()
    {
      return this.legendItemShape;
    }

    public virtual PieLabelLinkStyle getLabelLinkStyle()
    {
      return this.labelLinkStyle;
    }

    [LineNumberTable((ushort) 1214)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSectionOutlinePaint(IComparable key)
    {
      return this.sectionOutlinePaintMap.getPaint(key);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 95, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlinePaint(IComparable key, Paint paint)
    {
      this.sectionOutlinePaintMap.put(key, paint);
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 1403)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSectionOutlineStroke(IComparable key)
    {
      return this.sectionOutlineStrokeMap.getStroke(key);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 28, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlineStroke(IComparable key, Stroke stroke)
    {
      this.sectionOutlineStrokeMap.put(key, stroke);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 216, (byte) 99, (byte) 144, (byte) 104, (byte) 139, (byte) 116, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExplodePercent(IComparable key, double percent)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.explodePercentages == null)
          this.explodePercentages = (Map) new TreeMap();
        this.explodePercentages.put((object) key, (object) new Double(percent));
        this.fireChangeEvent();
      }
    }

    public virtual int getPieIndex()
    {
      return this.pieIndex;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 59, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartAngle(double angle)
    {
      this.startAngle = angle;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 84, (byte) 99, (byte) 144, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDirection(Rotation direction)
    {
      if (direction == null)
      {
        string str = "Null 'direction' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.direction = direction;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 116, (byte) 118, (byte) 223, (byte) 17, (byte) 106, (byte) 105, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInteriorGap(double percent)
    {
      if (percent < 0.0 || percent > 0.4)
      {
        string str = new StringBuffer().append("Invalid 'percent' (").append(percent).append(") argument.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.interiorGap == percent)
          return;
        this.interiorGap = percent;
        this.fireChangeEvent();
      }
    }

    public virtual bool isCircular()
    {
      return this.circular;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 205, (byte) 162, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCircular(bool flag)
    {
      this.setCircular(flag, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 187, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIgnoreZeroValues(bool flag)
    {
      this.ignoreZeroValues = flag;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 67, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionPaint(Paint paint)
    {
      this.sectionPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Paint getBaseSectionPaint()
    {
      return this.baseSectionPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 179, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSectionPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSectionPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 126, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoPopulateSectionPaint(bool auto)
    {
      this.autoPopulateSectionPaint = auto;
      this.fireChangeEvent();
    }

    public virtual bool getSectionOutlinesVisible()
    {
      return this.sectionOutlinesVisible;
    }

    public virtual Paint getBaseSectionOutlinePaint()
    {
      return this.baseSectionOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 138, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSectionOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSectionOutlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 72, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoPopulateSectionOutlinePaint(bool auto)
    {
      this.autoPopulateSectionOutlinePaint = auto;
      this.fireChangeEvent();
    }

    public virtual Stroke getBaseSectionOutlineStroke()
    {
      return this.baseSectionOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 71, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSectionOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSectionOutlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 25, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoPopulateSectionOutlineStroke(bool auto)
    {
      this.autoPopulateSectionOutlineStroke = auto;
      this.fireChangeEvent();
    }

    public virtual Paint getShadowPaint()
    {
      return this.shadowPaint;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 125, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowPaint(Paint paint)
    {
      this.shadowPaint = paint;
      this.fireChangeEvent();
    }

    public virtual double getShadowXOffset()
    {
      return this.shadowXOffset;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 149, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowXOffset(double offset)
    {
      this.shadowXOffset = offset;
      this.fireChangeEvent();
    }

    public virtual double getShadowYOffset()
    {
      return this.shadowYOffset;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 173, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowYOffset(double offset)
    {
      this.shadowYOffset = offset;
      this.fireChangeEvent();
    }

    public virtual double getLabelGap()
    {
      return this.labelGap;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 37, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelGap(double gap)
    {
      this.labelGap = gap;
      this.fireChangeEvent();
    }

    public virtual double getMaximumLabelWidth()
    {
      return this.maximumLabelWidth;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 61, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumLabelWidth(double width)
    {
      this.maximumLabelWidth = width;
      this.fireChangeEvent();
    }

    public virtual bool getLabelLinksVisible()
    {
      return this.labelLinksVisible;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 220, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelLinksVisible(bool visible)
    {
      this.labelLinksVisible = visible;
      this.fireChangeEvent();
    }

    public virtual double getLabelLinkMargin()
    {
      return this.labelLinkMargin;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 145, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelLinkMargin(double margin)
    {
      this.labelLinkMargin = margin;
      this.fireChangeEvent();
    }

    public virtual Paint getLabelLinkPaint()
    {
      return this.labelLinkPaint;
    }

    public virtual Stroke getLabelLinkStroke()
    {
      return this.labelLinkStroke;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 198, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelLinkStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelLinkStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 11, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getLabelBackgroundPaint()
    {
      return this.labelBackgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 38, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelBackgroundPaint(Paint paint)
    {
      this.labelBackgroundPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Paint getLabelOutlinePaint()
    {
      return this.labelOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 62, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOutlinePaint(Paint paint)
    {
      this.labelOutlinePaint = paint;
      this.fireChangeEvent();
    }

    public virtual Stroke getLabelOutlineStroke()
    {
      return this.labelOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 86, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOutlineStroke(Stroke stroke)
    {
      this.labelOutlineStroke = stroke;
      this.fireChangeEvent();
    }

    public virtual Paint getLabelShadowPaint()
    {
      return this.labelShadowPaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 110, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelShadowPaint(Paint paint)
    {
      this.labelShadowPaint = paint;
      this.fireChangeEvent();
    }

    public virtual RectangleInsets getLabelPadding()
    {
      return this.labelPadding;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 138, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelPadding = padding;
        this.fireChangeEvent();
      }
    }

    public virtual bool getSimpleLabels()
    {
      return this.simpleLabels;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 136, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSimpleLabels(bool simple)
    {
      this.simpleLabels = simple;
      this.fireChangeEvent();
    }

    public virtual RectangleInsets getSimpleLabelOffset()
    {
      return this.simpleLabelOffset;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 195, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSimpleLabelOffset(RectangleInsets offset)
    {
      if (offset == null)
      {
        string str = "Null 'offset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.simpleLabelOffset = offset;
        this.fireChangeEvent();
      }
    }

    public virtual AbstractPieLabelDistributor getLabelDistributor()
    {
      return this.labelDistributor;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 223, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelDistributor(AbstractPieLabelDistributor distributor)
    {
      if (distributor == null)
      {
        string str = "Null 'distributor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelDistributor = distributor;
        this.fireChangeEvent();
      }
    }

    public virtual PieToolTipGenerator getToolTipGenerator()
    {
      return this.toolTipGenerator;
    }

    public virtual PieURLGenerator getURLGenerator()
    {
      return this.urlGenerator;
    }

    public virtual void setMinimumArcAngleToDraw(double angle)
    {
      this.minimumArcAngleToDraw = angle;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 79, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemShape(Shape shape)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemShape = shape;
        this.fireChangeEvent();
      }
    }

    public virtual PieSectionLabelGenerator getLegendLabelGenerator()
    {
      return this.legendLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 106, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendLabelGenerator(PieSectionLabelGenerator generator)
    {
      if (generator == null)
      {
        string str = "Null 'generator' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendLabelGenerator = generator;
        this.fireChangeEvent();
      }
    }

    public virtual PieSectionLabelGenerator getLegendLabelToolTipGenerator()
    {
      return this.legendLabelToolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 134, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendLabelToolTipGenerator(PieSectionLabelGenerator generator)
    {
      this.legendLabelToolTipGenerator = generator;
      this.fireChangeEvent();
    }

    public virtual PieURLGenerator getLegendLabelURLGenerator()
    {
      return this.legendLabelURLGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendLabelURLGenerator(PieURLGenerator generator)
    {
      this.legendLabelURLGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 210, (byte) 103, (byte) 135, (byte) 100, (byte) 104, (byte) 168, (byte) 104, (byte) 136, (byte) 103, (byte) 135, (byte) 103, (byte) 178, (byte) 109, (byte) 172, (byte) 168, (byte) 103, (byte) 135, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      this.getInsets().trim(area);
      if (info != null)
      {
        info.setPlotArea(area);
        info.setDataArea(area);
      }
      this.drawBackground(g2, area);
      this.drawOutline(g2, area);
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) area);
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      if (!DatasetUtilities.isEmptyOrNull(this.dataset))
        this.drawPie(g2, area, info);
      else
        this.drawNoDataMessage(g2, area);
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      this.drawOutline(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 243, (byte) 102, (byte) 104, (byte) 130, (byte) 108, (byte) 98, (byte) 103, (byte) 104, (byte) 108, (byte) 110, (byte) 111, (byte) 98, (byte) 100, (byte) 176, (byte) 106, (byte) 105, (byte) 176, (byte) 171, (byte) 103, (byte) 149, (byte) 103, (byte) 100, (byte) 99, (byte) 104, (byte) 181, (byte) 99, (byte) 104, (byte) 187, (byte) 106, (byte) 106, (byte) 106, (byte) 255, (byte) 15, (byte) 69, (byte) 109, (byte) 116, (byte) 105, (byte) 136, (byte) 100, (byte) 130, (byte) 132, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      if (this.dataset == null)
        return legendItemCollection;
      List keys = this.dataset.getKeys();
      int num1 = 0;
      Shape legendItemShape = this.getLegendItemShape();
      Iterator iterator = keys.iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        Number number = this.dataset.getValue(comparable);
        int num2;
        if (number == null)
        {
          num2 = this.ignoreNullValues ? 0 : 1;
        }
        else
        {
          double num3 = number.doubleValue();
          num2 = num3 != 0.0 ? (num3 > 0.0 ? 1 : 0) : (this.ignoreZeroValues ? 0 : 1);
        }
        if (num2 != 0)
        {
          string label = this.legendLabelGenerator.generateSectionLabel(this.dataset, comparable);
          if (label != null)
          {
            string description = label;
            string toolTipText = (string) null;
            if (this.legendLabelToolTipGenerator != null)
              toolTipText = this.legendLabelToolTipGenerator.generateSectionLabel(this.dataset, comparable);
            string urlText = (string) null;
            if (this.legendLabelURLGenerator != null)
              urlText = this.legendLabelURLGenerator.generateURL(this.dataset, comparable, this.pieIndex);
            Paint fillPaint = this.lookupSectionPaint(comparable);
            Paint outlinePaint = this.lookupSectionOutlinePaint(comparable);
            Stroke outlineStroke = this.lookupSectionOutlineStroke(comparable);
            LegendItem.__\u003Cclinit\u003E();
            LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, true, legendItemShape, true, fillPaint, true, outlinePaint, outlineStroke, false, (Shape) new Line2D.Float(), (Stroke) new BasicStroke(), (Paint) Color.black);
            legendItem.setDataset((Dataset) this.getDataset());
            legendItem.setSeriesIndex(this.dataset.getIndex(comparable));
            legendItem.setSeriesKey(comparable);
            legendItemCollection.add(legendItem);
          }
          ++num1;
        }
        else
          ++num1;
      }
      return legendItemCollection;
    }

    [LineNumberTable((ushort) 2984)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return PiePlot.localizationResources.getString("Pie_Plot");
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 206, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 179, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 179, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 142, (byte) 130, (byte) 142, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PiePlot) || !base.equals(obj))
        return false;
      PiePlot piePlot = (PiePlot) obj;
      return this.pieIndex == piePlot.pieIndex && this.interiorGap == piePlot.interiorGap && (this.circular == piePlot.circular && this.startAngle == piePlot.startAngle) && (this.direction == piePlot.direction && this.ignoreZeroValues == piePlot.ignoreZeroValues && (this.ignoreNullValues == piePlot.ignoreNullValues && PaintUtilities.equal(this.sectionPaint, piePlot.sectionPaint))) && (ObjectUtilities.equal((object) this.sectionPaintMap, (object) piePlot.sectionPaintMap) && PaintUtilities.equal(this.baseSectionPaint, piePlot.baseSectionPaint) && (this.sectionOutlinesVisible == piePlot.sectionOutlinesVisible && PaintUtilities.equal(this.sectionOutlinePaint, piePlot.sectionOutlinePaint)) && (ObjectUtilities.equal((object) this.sectionOutlinePaintMap, (object) piePlot.sectionOutlinePaintMap) && PaintUtilities.equal(this.baseSectionOutlinePaint, piePlot.baseSectionOutlinePaint) && (ObjectUtilities.equal((object) this.sectionOutlineStroke, (object) piePlot.sectionOutlineStroke) && ObjectUtilities.equal((object) this.sectionOutlineStrokeMap, (object) piePlot.sectionOutlineStrokeMap)))) && (ObjectUtilities.equal((object) this.baseSectionOutlineStroke, (object) piePlot.baseSectionOutlineStroke) && PaintUtilities.equal(this.shadowPaint, piePlot.shadowPaint) && (this.shadowXOffset == piePlot.shadowXOffset && this.shadowYOffset == piePlot.shadowYOffset) && (ObjectUtilities.equal((object) this.explodePercentages, (object) piePlot.explodePercentages) && ObjectUtilities.equal((object) this.labelGenerator, (object) piePlot.labelGenerator) && (ObjectUtilities.equal((object) this.labelFont, (object) piePlot.labelFont) && PaintUtilities.equal(this.labelPaint, piePlot.labelPaint))) && (PaintUtilities.equal(this.labelBackgroundPaint, piePlot.labelBackgroundPaint) && PaintUtilities.equal(this.labelOutlinePaint, piePlot.labelOutlinePaint) && (ObjectUtilities.equal((object) this.labelOutlineStroke, (object) piePlot.labelOutlineStroke) && PaintUtilities.equal(this.labelShadowPaint, piePlot.labelShadowPaint)) && (this.simpleLabels == piePlot.simpleLabels && this.simpleLabelOffset.equals((object) piePlot.simpleLabelOffset) && (this.labelPadding.equals((object) piePlot.labelPadding) && this.maximumLabelWidth == piePlot.maximumLabelWidth)))) && (this.labelGap == piePlot.labelGap && this.labelLinkMargin == piePlot.labelLinkMargin && (this.labelLinksVisible == piePlot.labelLinksVisible && this.labelLinkStyle.equals((object) piePlot.labelLinkStyle)) && (PaintUtilities.equal(this.labelLinkPaint, piePlot.labelLinkPaint) && ObjectUtilities.equal((object) this.labelLinkStroke, (object) piePlot.labelLinkStroke) && (ObjectUtilities.equal((object) this.toolTipGenerator, (object) piePlot.toolTipGenerator) && ObjectUtilities.equal((object) this.urlGenerator, (object) piePlot.urlGenerator))) && (this.minimumArcAngleToDraw == piePlot.minimumArcAngleToDraw && ShapeUtilities.equal(this.legendItemShape, piePlot.legendItemShape) && (ObjectUtilities.equal((object) this.legendLabelGenerator, (object) piePlot.legendLabelGenerator) && ObjectUtilities.equal((object) this.legendLabelToolTipGenerator, (object) piePlot.legendLabelToolTipGenerator)) && (ObjectUtilities.equal((object) this.legendLabelURLGenerator, (object) piePlot.legendLabelURLGenerator) && this.autoPopulateSectionPaint == piePlot.autoPopulateSectionPaint && (this.autoPopulateSectionOutlinePaint == piePlot.autoPopulateSectionOutlinePaint && this.autoPopulateSectionOutlineStroke == piePlot.autoPopulateSectionOutlineStroke))));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 172, (byte) 140, (byte) 108, (byte) 104, (byte) 140, (byte) 109, (byte) 182, (byte) 113, (byte) 104, (byte) 182, (byte) 104, (byte) 182, (byte) 109, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      PiePlot piePlot = (PiePlot) base.clone();
      if (piePlot.dataset != null)
        piePlot.dataset.addChangeListener((DatasetChangeListener) piePlot);
      if (this.urlGenerator is PublicCloneable)
        piePlot.urlGenerator = (PieURLGenerator) ObjectUtilities.clone((object) this.urlGenerator);
      piePlot.legendItemShape = ShapeUtilities.clone(this.legendItemShape);
      if (this.legendLabelGenerator != null)
        piePlot.legendLabelGenerator = (PieSectionLabelGenerator) ObjectUtilities.clone((object) this.legendLabelGenerator);
      if (this.legendLabelToolTipGenerator != null)
        piePlot.legendLabelToolTipGenerator = (PieSectionLabelGenerator) ObjectUtilities.clone((object) this.legendLabelToolTipGenerator);
      if (this.legendLabelURLGenerator is PublicCloneable)
        piePlot.legendLabelURLGenerator = (PieURLGenerator) ObjectUtilities.clone((object) this.legendLabelURLGenerator);
      return (object) piePlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 172, (byte) 172, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.sectionPaint, obj0);
      SerialUtilities.writePaint(this.baseSectionPaint, obj0);
      SerialUtilities.writePaint(this.sectionOutlinePaint, obj0);
      SerialUtilities.writePaint(this.baseSectionOutlinePaint, obj0);
      SerialUtilities.writeStroke(this.sectionOutlineStroke, obj0);
      SerialUtilities.writeStroke(this.baseSectionOutlineStroke, obj0);
      SerialUtilities.writePaint(this.shadowPaint, obj0);
      SerialUtilities.writePaint(this.labelPaint, obj0);
      SerialUtilities.writePaint(this.labelBackgroundPaint, obj0);
      SerialUtilities.writePaint(this.labelOutlinePaint, obj0);
      SerialUtilities.writeStroke(this.labelOutlineStroke, obj0);
      SerialUtilities.writePaint(this.labelShadowPaint, obj0);
      SerialUtilities.writePaint(this.labelLinkPaint, obj0);
      SerialUtilities.writeStroke(this.labelLinkStroke, obj0);
      SerialUtilities.writeShape(this.legendItemShape, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 172, (byte) 200, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.sectionPaint = SerialUtilities.readPaint(obj0);
      this.baseSectionPaint = SerialUtilities.readPaint(obj0);
      this.sectionOutlinePaint = SerialUtilities.readPaint(obj0);
      this.baseSectionOutlinePaint = SerialUtilities.readPaint(obj0);
      this.sectionOutlineStroke = SerialUtilities.readStroke(obj0);
      this.baseSectionOutlineStroke = SerialUtilities.readStroke(obj0);
      this.shadowPaint = SerialUtilities.readPaint(obj0);
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.labelBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.labelOutlinePaint = SerialUtilities.readPaint(obj0);
      this.labelOutlineStroke = SerialUtilities.readStroke(obj0);
      this.labelShadowPaint = SerialUtilities.readPaint(obj0);
      this.labelLinkPaint = SerialUtilities.readPaint(obj0);
      this.labelLinkStroke = SerialUtilities.readStroke(obj0);
      this.legendItemShape = SerialUtilities.readShape(obj0);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 1, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSectionPaint(int section)
    {
      return this.getSectionPaint(this.getSectionKey(section));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 15, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionPaint(int section, Paint paint)
    {
      this.setSectionPaint(this.getSectionKey(section), paint);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 48, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlinePaint(Paint paint)
    {
      this.sectionOutlinePaint = paint;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 62, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSectionOutlinePaint(int section)
    {
      return this.getSectionOutlinePaint(this.getSectionKey(section));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 77, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlinePaint(int section, Paint paint)
    {
      this.setSectionOutlinePaint(this.getSectionKey(section), paint);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 110, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlineStroke(Stroke stroke)
    {
      this.sectionOutlineStroke = stroke;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 124, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSectionOutlineStroke(int section)
    {
      return this.getSectionOutlineStroke(this.getSectionKey(section));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 139, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionOutlineStroke(int section, Stroke stroke)
    {
      this.setSectionOutlineStroke(this.getSectionKey(section), stroke);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 167, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExplodePercent(int section, double percent)
    {
      this.setExplodePercent(this.getSectionKey(section), percent);
    }
  }
}
