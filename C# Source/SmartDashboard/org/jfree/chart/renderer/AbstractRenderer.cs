// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.AbstractRenderer
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
using java.util;
using javax.swing.@event;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractRenderer : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal static Double __\u003C\u003EZERO = new Double(0.0);
    internal static Paint __\u003C\u003EDEFAULT_PAINT = (Paint) Color.blue;
    internal static Paint __\u003C\u003EDEFAULT_OUTLINE_PAINT = (Paint) Color.gray;
    internal static Stroke __\u003C\u003EDEFAULT_STROKE = (Stroke) new BasicStroke(1f);
    internal static Stroke __\u003C\u003EDEFAULT_OUTLINE_STROKE = (Stroke) new BasicStroke(1f);
    internal static Shape __\u003C\u003EDEFAULT_SHAPE = (Shape) new Rectangle2D.Double(-3.0, -3.0, 6.0, 6.0);
    internal static Font __\u003C\u003EDEFAULT_VALUE_LABEL_FONT = new Font("SansSerif", 0, 10);
    internal static Paint __\u003C\u003EDEFAULT_VALUE_LABEL_PAINT = (Paint) Color.black;
    [Modifiers]
    private static double ADJ = Math.cos(Math.PI / 6.0);
    [Modifiers]
    private static double OPP = Math.sin(Math.PI / 6.0);
    private const long serialVersionUID = -828267569428206075L;
    private BooleanList seriesVisibleList;
    private bool baseSeriesVisible;
    private BooleanList seriesVisibleInLegendList;
    private bool baseSeriesVisibleInLegend;
    private PaintList paintList;
    private bool autoPopulateSeriesPaint;
    [NonSerialized]
    private Paint basePaint;
    private PaintList fillPaintList;
    private bool autoPopulateSeriesFillPaint;
    [NonSerialized]
    private Paint baseFillPaint;
    private PaintList outlinePaintList;
    private bool autoPopulateSeriesOutlinePaint;
    [NonSerialized]
    private Paint baseOutlinePaint;
    private StrokeList strokeList;
    private bool autoPopulateSeriesStroke;
    [NonSerialized]
    private Stroke baseStroke;
    private StrokeList outlineStrokeList;
    [NonSerialized]
    private Stroke baseOutlineStroke;
    private bool autoPopulateSeriesOutlineStroke;
    private ShapeList shapeList;
    private bool autoPopulateSeriesShape;
    [NonSerialized]
    private Shape baseShape;
    private BooleanList itemLabelsVisibleList;
    private Boolean baseItemLabelsVisible;
    private ObjectList itemLabelFontList;
    private Font baseItemLabelFont;
    private PaintList itemLabelPaintList;
    [NonSerialized]
    private Paint baseItemLabelPaint;
    private ObjectList positiveItemLabelPositionList;
    private ItemLabelPosition basePositiveItemLabelPosition;
    private ObjectList negativeItemLabelPositionList;
    private ItemLabelPosition baseNegativeItemLabelPosition;
    private double itemLabelAnchorOffset;
    private BooleanList createEntitiesList;
    private bool baseCreateEntities;
    private ShapeList legendShape;
    [NonSerialized]
    private Shape baseLegendShape;
    private ObjectList legendTextFont;
    private Font baseLegendTextFont;
    private PaintList legendTextPaint;
    [NonSerialized]
    private Paint baseLegendTextPaint;
    private bool dataBoundsIncludesVisibleSeriesOnly;
    private int defaultEntityRadius;
    [NonSerialized]
    private EventListenerList listenerList;
    [NonSerialized]
    private RendererChangeEvent @event;
    [Obsolete]
    private Boolean seriesVisible;
    [Obsolete]
    private Boolean seriesVisibleInLegend;
    [Obsolete]
    [NonSerialized]
    private Paint paint;
    [Obsolete]
    [NonSerialized]
    private Paint fillPaint;
    [Obsolete]
    [NonSerialized]
    private Paint outlinePaint;
    [Obsolete]
    [NonSerialized]
    private Stroke stroke;
    [Obsolete]
    [NonSerialized]
    private Stroke outlineStroke;
    [Obsolete]
    [NonSerialized]
    private Shape shape;
    [Obsolete]
    private Boolean itemLabelsVisible;
    [Obsolete]
    private Font itemLabelFont;
    [Obsolete]
    [NonSerialized]
    private Paint itemLabelPaint;
    [Obsolete]
    private ItemLabelPosition positiveItemLabelPosition;
    [Obsolete]
    private ItemLabelPosition negativeItemLabelPosition;
    [Obsolete]
    private Boolean createEntities;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static Double ZERO
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EZERO;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_PAINT
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_OUTLINE_PAINT
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_STROKE
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_STROKE;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_OUTLINE_STROKE
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
      }
    }

    [Modifiers]
    public static Shape DEFAULT_SHAPE
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_SHAPE;
      }
    }

    [Modifiers]
    public static Font DEFAULT_VALUE_LABEL_FONT
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_VALUE_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_VALUE_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return AbstractRenderer.__\u003C\u003EDEFAULT_VALUE_LABEL_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 175, (byte) 170, (byte) 170, (byte) 175, (byte) 175, (byte) 223, (byte) 15, (byte) 210, (byte) 234, (byte) 169, (byte) 250, (byte) 180})]
    static AbstractRenderer()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 232, (byte) 159, (byte) 177, (byte) 240, (byte) 160, (byte) 65, (byte) 231, (byte) 80, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 147, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 181, (byte) 103, (byte) 107, (byte) 181, (byte) 103, (byte) 107, (byte) 135, (byte) 135, (byte) 107, (byte) 135, (byte) 107, (byte) 135, (byte) 107, (byte) 135, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractRenderer()
    {
      base.\u002Ector();
      AbstractRenderer abstractRenderer = this;
      this.itemLabelAnchorOffset = 2.0;
      this.dataBoundsIncludesVisibleSeriesOnly = true;
      this.seriesVisible = (Boolean) null;
      this.seriesVisibleList = new BooleanList();
      this.baseSeriesVisible = true;
      this.seriesVisibleInLegend = (Boolean) null;
      this.seriesVisibleInLegendList = new BooleanList();
      this.baseSeriesVisibleInLegend = true;
      this.paint = (Paint) null;
      this.paintList = new PaintList();
      this.basePaint = AbstractRenderer.__\u003C\u003EDEFAULT_PAINT;
      this.autoPopulateSeriesPaint = true;
      this.fillPaint = (Paint) null;
      this.fillPaintList = new PaintList();
      this.baseFillPaint = (Paint) Color.white;
      this.autoPopulateSeriesFillPaint = false;
      this.outlinePaint = (Paint) null;
      this.outlinePaintList = new PaintList();
      this.baseOutlinePaint = AbstractRenderer.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
      this.autoPopulateSeriesOutlinePaint = false;
      this.stroke = (Stroke) null;
      this.strokeList = new StrokeList();
      this.baseStroke = AbstractRenderer.__\u003C\u003EDEFAULT_STROKE;
      this.autoPopulateSeriesStroke = true;
      this.outlineStroke = (Stroke) null;
      this.outlineStrokeList = new StrokeList();
      this.baseOutlineStroke = AbstractRenderer.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
      this.autoPopulateSeriesOutlineStroke = false;
      this.shape = (Shape) null;
      this.shapeList = new ShapeList();
      this.baseShape = AbstractRenderer.__\u003C\u003EDEFAULT_SHAPE;
      this.autoPopulateSeriesShape = true;
      this.itemLabelsVisible = (Boolean) null;
      this.itemLabelsVisibleList = new BooleanList();
      this.baseItemLabelsVisible = (Boolean) Boolean.FALSE;
      this.itemLabelFont = (Font) null;
      this.itemLabelFontList = new ObjectList();
      this.baseItemLabelFont = new Font("SansSerif", 0, 10);
      this.itemLabelPaint = (Paint) null;
      this.itemLabelPaintList = new PaintList();
      this.baseItemLabelPaint = (Paint) Color.black;
      this.positiveItemLabelPosition = (ItemLabelPosition) null;
      this.positiveItemLabelPositionList = new ObjectList();
      this.basePositiveItemLabelPosition = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE12, TextAnchor.__\u003C\u003EBOTTOM_CENTER);
      this.negativeItemLabelPosition = (ItemLabelPosition) null;
      this.negativeItemLabelPositionList = new ObjectList();
      this.baseNegativeItemLabelPosition = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE6, TextAnchor.__\u003C\u003ETOP_CENTER);
      this.createEntities = (Boolean) null;
      this.createEntitiesList = new BooleanList();
      this.baseCreateEntities = true;
      this.defaultEntityRadius = 3;
      this.legendShape = new ShapeList();
      this.baseLegendShape = (Shape) null;
      this.legendTextFont = new ObjectList();
      this.baseLegendTextFont = (Font) null;
      this.legendTextPaint = new PaintList();
      this.baseLegendTextPaint = (Paint) null;
      this.listenerList = new EventListenerList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractRenderer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 13, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBasePositiveItemLabelPosition(ItemLabelPosition position)
    {
      this.setBasePositiveItemLabelPosition(position, true);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 134, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseNegativeItemLabelPosition(ItemLabelPosition position)
    {
      this.setBaseNegativeItemLabelPosition(position, true);
    }

    public virtual bool getAutoPopulateSeriesPaint()
    {
      return this.autoPopulateSeriesPaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 196, (byte) 162, (byte) 107, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSeriesPaints(bool notify)
    {
      int num = notify ? 1 : 0;
      this.paintList.clear();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual bool getAutoPopulateSeriesStroke()
    {
      return this.autoPopulateSeriesStroke;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 69, (byte) 98, (byte) 107, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSeriesStrokes(bool notify)
    {
      int num = notify ? 1 : 0;
      this.strokeList.clear();
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 156, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPaint(int series, Paint paint)
    {
      this.setSeriesPaint(series, paint, true);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 179, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(RendererChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.listenerList.add(AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener != null ? AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener : (AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener = AbstractRenderer.class\u0024("org.jfree.chart.event.RendererChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 194, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(RendererChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.listenerList.remove(AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener != null ? AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener : (AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener = AbstractRenderer.class\u0024("org.jfree.chart.event.RendererChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 120, (byte) 103, (byte) 104, (byte) 174, (byte) 109, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSeriesVisible(int series)
    {
      int num = this.baseSeriesVisible ? 1 : 0;
      if (this.seriesVisible != null)
      {
        num = this.seriesVisible.booleanValue() ? 1 : 0;
      }
      else
      {
        Boolean boolean = this.seriesVisibleList.getBoolean(series);
        if (boolean != null)
          num = boolean.booleanValue() ? 1 : 0;
      }
      return num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 7, (byte) 98, (byte) 109, (byte) 227, (byte) 69, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisible(int series, Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.seriesVisibleList.setBoolean(series, visible);
      if (num == 0)
        return;
      this.notifyListeners(new RendererChangeEvent((object) this, true));
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 239, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void notifyListeners(RendererChangeEvent @event)
    {
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener != null ? AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener : (AbstractRenderer.class\u0024org\u0024jfree\u0024chart\u0024event\u0024RendererChangeListener = AbstractRenderer.class\u0024("org.jfree.chart.event.RendererChangeListener"))))
          ((RendererChangeListener) listenerList[index + 1]).rendererChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 252, (byte) 132, (byte) 103, (byte) 227, (byte) 69, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesVisible(bool visible, bool notify)
    {
      int num1 = visible ? 1 : 0;
      int num2 = notify ? 1 : 0;
      this.baseSeriesVisible = num1 != 0;
      if (num2 == 0)
        return;
      this.notifyListeners(new RendererChangeEvent((object) this, true));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 233, (byte) 162, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisibleInLegend(int series, Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.seriesVisibleInLegendList.setBoolean(series, visible);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 230, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fireChangeEvent()
    {
      this.notifyListeners(new RendererChangeEvent((object) this));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 223, (byte) 164, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesVisibleInLegend(bool visible, bool notify)
    {
      int num1 = visible ? 1 : 0;
      int num2 = notify ? 1 : 0;
      this.baseSeriesVisibleInLegend = num1 != 0;
      if (num2 == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 113, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint lookupSeriesPaint(int series)
    {
      if (this.paint != null)
        return this.paint;
      Paint paint = this.getSeriesPaint(series);
      if (paint == null && this.autoPopulateSeriesPaint)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          paint = drawingSupplier.getNextPaint();
          this.setSeriesPaint(series, paint, false);
        }
      }
      if (paint == null)
        paint = this.basePaint;
      return paint;
    }

    [LineNumberTable((ushort) 769)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesPaint(int series)
    {
      return this.paintList.getPaint(series);
    }

    public abstract DrawingSupplier getDrawingSupplier();

    [LineNumberTable(new byte[] {(byte) 158, (byte) 199, (byte) 66, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPaint(int series, Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.paintList.setPaint(series, paint);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 186, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBasePaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.basePaint = paint;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 32, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint lookupSeriesFillPaint(int series)
    {
      if (this.fillPaint != null)
        return this.fillPaint;
      Paint paint = this.getSeriesFillPaint(series);
      if (paint == null && this.autoPopulateSeriesFillPaint)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          paint = drawingSupplier.getNextFillPaint();
          this.setSeriesFillPaint(series, paint, false);
        }
      }
      if (paint == null)
        paint = this.baseFillPaint;
      return paint;
    }

    [LineNumberTable((ushort) 944)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesFillPaint(int series)
    {
      return this.fillPaintList.getPaint(series);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 156, (byte) 162, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesFillPaint(int series, Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fillPaintList.setPaint(series, paint);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 146, (byte) 162, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseFillPaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseFillPaint = paint;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 198, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint lookupSeriesOutlinePaint(int series)
    {
      if (this.outlinePaint != null)
        return this.outlinePaint;
      Paint paint = this.getSeriesOutlinePaint(series);
      if (paint == null && this.autoPopulateSeriesOutlinePaint)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          paint = drawingSupplier.getNextOutlinePaint();
          this.setSeriesOutlinePaint(series, paint, false);
        }
      }
      if (paint == null)
        paint = this.baseOutlinePaint;
      return paint;
    }

    [LineNumberTable((ushort) 1110)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesOutlinePaint(int series)
    {
      return this.outlinePaintList.getPaint(series);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 114, (byte) 98, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlinePaint(int series, Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.outlinePaintList.setPaint(series, paint);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 104, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseOutlinePaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseOutlinePaint = paint;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 107, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke lookupSeriesStroke(int series)
    {
      if (this.stroke != null)
        return this.stroke;
      Stroke stroke = this.getSeriesStroke(series);
      if (stroke == null && this.autoPopulateSeriesStroke)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          stroke = drawingSupplier.getNextStroke();
          this.setSeriesStroke(series, stroke, false);
        }
      }
      if (stroke == null)
        stroke = this.baseStroke;
      return stroke;
    }

    [LineNumberTable((ushort) 1275)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSeriesStroke(int series)
    {
      return this.strokeList.getStroke(series);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 73, (byte) 130, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesStroke(int series, Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      this.strokeList.setStroke(series, stroke);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 59, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseStroke(Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseStroke = stroke;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 29, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke lookupSeriesOutlineStroke(int series)
    {
      if (this.outlineStroke != null)
        return this.outlineStroke;
      Stroke stroke = this.getSeriesOutlineStroke(series);
      if (stroke == null && this.autoPopulateSeriesOutlineStroke)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          stroke = drawingSupplier.getNextOutlineStroke();
          this.setSeriesOutlineStroke(series, stroke, false);
        }
      }
      if (stroke == null)
        stroke = this.baseOutlineStroke;
      return stroke;
    }

    [LineNumberTable((ushort) 1453)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSeriesOutlineStroke(int series)
    {
      return this.outlineStrokeList.getStroke(series);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 28, (byte) 98, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlineStroke(int series, Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      this.outlineStrokeList.setStroke(series, stroke);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 18, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseOutlineStroke(Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseOutlineStroke = stroke;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 195, (byte) 104, (byte) 199, (byte) 104, (byte) 107, (byte) 103, (byte) 99, (byte) 103, (byte) 169, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape lookupSeriesShape(int series)
    {
      if (this.shape != null)
        return this.shape;
      Shape shape = this.getSeriesShape(series);
      if (shape == null && this.autoPopulateSeriesShape)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          shape = drawingSupplier.getNextShape();
          this.setSeriesShape(series, shape, false);
        }
      }
      if (shape == null)
        shape = this.baseShape;
      return shape;
    }

    [LineNumberTable((ushort) 1619)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getSeriesShape(int series)
    {
      return this.shapeList.getShape(series);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 243, (byte) 130, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShape(int series, Shape shape, bool notify)
    {
      int num = notify ? 1 : 0;
      this.shapeList.setShape(series, shape);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 233, (byte) 130, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShape(Shape shape, bool notify)
    {
      int num = notify ? 1 : 0;
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseShape = shape;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 99, (byte) 104, (byte) 206, (byte) 109, (byte) 99, (byte) 135, (byte) 99, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSeriesItemLabelsVisible(int series)
    {
      if (this.itemLabelsVisible != null)
        return (this.itemLabelsVisible.booleanValue() ? 1 : 0) != 0;
      else
        return (((this.itemLabelsVisibleList.getBoolean(series) ?? this.baseItemLabelsVisible) ?? (Boolean) Boolean.FALSE).booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 134, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelsVisible(int series, Boolean visible)
    {
      this.setSeriesItemLabelsVisible(series, visible, true);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 205, (byte) 130, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelsVisible(int series, Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelsVisibleList.setBoolean(series, visible);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 189, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelsVisible(Boolean visible)
    {
      this.setBaseItemLabelsVisible(visible, true);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 191, (byte) 130, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelsVisible(Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.baseItemLabelsVisible = visible;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 1891)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getSeriesItemLabelFont(int series)
    {
      return (Font) this.itemLabelFontList.get(series);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 175, (byte) 162, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelFont(int series, Font font, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelFontList.set(series, (object) font);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 164, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelFont(Font font, bool notify)
    {
      int num = notify ? 1 : 0;
      this.baseItemLabelFont = font;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 2000)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesItemLabelPaint(int series)
    {
      return this.itemLabelPaintList.getPaint(series);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 147, (byte) 98, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelPaint(int series, Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelPaintList.setPaint(series, paint);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 137, (byte) 130, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelPaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseItemLabelPaint = paint;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 201, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ItemLabelPosition getSeriesPositiveItemLabelPosition(int series)
    {
      if (this.positiveItemLabelPosition != null)
        return this.positiveItemLabelPosition;
      else
        return (ItemLabelPosition) this.positiveItemLabelPositionList.get(series) ?? this.basePositiveItemLabelPosition;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 117, (byte) 98, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPositiveItemLabelPosition(int series, ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      this.positiveItemLabelPositionList.set(series, (object) position);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 107, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBasePositiveItemLabelPosition(ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.basePositiveItemLabelPosition = position;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 66, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ItemLabelPosition getSeriesNegativeItemLabelPosition(int series)
    {
      if (this.negativeItemLabelPosition != null)
        return this.negativeItemLabelPosition;
      else
        return (ItemLabelPosition) this.negativeItemLabelPositionList.get(series) ?? this.baseNegativeItemLabelPosition;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 87, (byte) 130, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesNegativeItemLabelPosition(int series, ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      this.negativeItemLabelPositionList.set(series, (object) position);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 77, (byte) 130, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseNegativeItemLabelPosition(ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseNegativeItemLabelPosition = position;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable((ushort) 2377)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesCreateEntities(int series)
    {
      return this.createEntitiesList.getBoolean(series);
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 53, (byte) 130, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesCreateEntities(int series, Boolean create, bool notify)
    {
      int num = notify ? 1 : 0;
      this.createEntitiesList.setBoolean(series, create);
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 42, (byte) 68, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseCreateEntities(bool create, bool notify)
    {
      int num1 = create ? 1 : 0;
      int num2 = notify ? 1 : 0;
      this.baseCreateEntities = num1 != 0;
      if (num2 == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 2511)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getLegendShape(int series)
    {
      return this.legendShape.getShape(series);
    }

    [LineNumberTable((ushort) 2582)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getLegendTextFont(int series)
    {
      return (Font) this.legendTextFont.get(series);
    }

    [LineNumberTable((ushort) 2653)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getLegendTextPaint(int series)
    {
      return this.legendTextPaint.getPaint(series);
    }

    [LineNumberTable((ushort) 2856)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractRenderer.__\u003CGetCallerID\u003E());
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

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 156, (byte) 33, (byte) 66, (byte) 103, (byte) 227, (byte) 69, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisible(Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.seriesVisible = visible;
      if (num == 0)
        return;
      this.notifyListeners(new RendererChangeEvent((object) this, true));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 156, (byte) 17, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisibleInLegend(Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.seriesVisibleInLegend = visible;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 156, (byte) 9, (byte) 98, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.paint = paint;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 156, (byte) 1, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.fillPaint = paint;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 249, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.outlinePaint = paint;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 241, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      this.stroke = stroke;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 233, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke, bool notify)
    {
      int num = notify ? 1 : 0;
      this.outlineStroke = stroke;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 225, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShape(Shape shape, bool notify)
    {
      int num = notify ? 1 : 0;
      this.shape = shape;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelsVisible(Boolean visible)
    {
      this.setItemLabelsVisible(visible, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 213, (byte) 130, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelsVisible(Boolean visible, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelsVisible = visible;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 201, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelFont(Font font, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelFont = font;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 189, (byte) 162, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelPaint(Paint paint, bool notify)
    {
      int num = notify ? 1 : 0;
      this.itemLabelPaint = paint;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 174, (byte) 98, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveItemLabelPosition(ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      this.positiveItemLabelPosition = position;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 159, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeItemLabelPosition(ItemLabelPosition position, bool notify)
    {
      int num = notify ? 1 : 0;
      this.negativeItemLabelPosition = position;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 146, (byte) 130, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCreateEntities(Boolean create, bool notify)
    {
      int num = notify ? 1 : 0;
      this.createEntities = create;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 478)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemVisible(int series, int item)
    {
      return (this.isSeriesVisible(series) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 513)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesVisible(int series)
    {
      return this.seriesVisibleList.getBoolean(series);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 156, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisible(int series, Boolean visible)
    {
      this.setSeriesVisible(series, visible, true);
    }

    public virtual bool getBaseSeriesVisible()
    {
      return this.baseSeriesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 255, (byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesVisible(bool visible)
    {
      this.setBaseSeriesVisible(visible, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 238, (byte) 103, (byte) 104, (byte) 174, (byte) 109, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSeriesVisibleInLegend(int series)
    {
      int num = this.baseSeriesVisibleInLegend ? 1 : 0;
      if (this.seriesVisibleInLegend != null)
      {
        num = this.seriesVisibleInLegend.booleanValue() ? 1 : 0;
      }
      else
      {
        Boolean boolean = this.seriesVisibleInLegendList.getBoolean(series);
        if (boolean != null)
          num = boolean.booleanValue() ? 1 : 0;
      }
      return num != 0;
    }

    [LineNumberTable((ushort) 634)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesVisibleInLegend(int series)
    {
      return this.seriesVisibleInLegendList.getBoolean(series);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 21, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisibleInLegend(int series, Boolean visible)
    {
      this.setSeriesVisibleInLegend(series, visible, true);
    }

    public virtual bool getBaseSeriesVisibleInLegend()
    {
      return this.baseSeriesVisibleInLegend;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 226, (byte) 130, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesVisibleInLegend(bool visible)
    {
      this.setBaseSeriesVisibleInLegend(visible, true);
    }

    [LineNumberTable((ushort) 724)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getItemPaint(int row, int column)
    {
      return this.lookupSeriesPaint(row);
    }

    public virtual Paint getBasePaint()
    {
      return this.basePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 212, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBasePaint(Paint paint)
    {
      this.setBasePaint(paint, true);
    }

    public virtual void setAutoPopulateSeriesPaint(bool auto)
    {
      this.autoPopulateSeriesPaint = auto;
    }

    [LineNumberTable((ushort) 899)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getItemFillPaint(int row, int column)
    {
      return this.lookupSeriesFillPaint(row);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 75, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesFillPaint(int series, Paint paint)
    {
      this.setSeriesFillPaint(series, paint, true);
    }

    public virtual Paint getBaseFillPaint()
    {
      return this.baseFillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 116, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseFillPaint(Paint paint)
    {
      this.setBaseFillPaint(paint, true);
    }

    public virtual bool getAutoPopulateSeriesFillPaint()
    {
      return this.autoPopulateSeriesFillPaint;
    }

    public virtual void setAutoPopulateSeriesFillPaint(bool auto)
    {
      this.autoPopulateSeriesFillPaint = auto;
    }

    [LineNumberTable((ushort) 1065)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getItemOutlinePaint(int row, int column)
    {
      return this.lookupSeriesOutlinePaint(row);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 241, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlinePaint(int series, Paint paint)
    {
      this.setSeriesOutlinePaint(series, paint, true);
    }

    public virtual Paint getBaseOutlinePaint()
    {
      return this.baseOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 26, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseOutlinePaint(Paint paint)
    {
      this.setBaseOutlinePaint(paint, true);
    }

    public virtual bool getAutoPopulateSeriesOutlinePaint()
    {
      return this.autoPopulateSeriesOutlinePaint;
    }

    public virtual void setAutoPopulateSeriesOutlinePaint(bool auto)
    {
      this.autoPopulateSeriesOutlinePaint = auto;
    }

    [LineNumberTable((ushort) 1230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getItemStroke(int row, int column)
    {
      return this.lookupSeriesStroke(row);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 150, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesStroke(int series, Stroke stroke)
    {
      this.setSeriesStroke(series, stroke, true);
    }

    public virtual Stroke getBaseStroke()
    {
      return this.baseStroke;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 206, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseStroke(Stroke stroke)
    {
      this.setBaseStroke(stroke, true);
    }

    public virtual void setAutoPopulateSeriesStroke(bool auto)
    {
      this.autoPopulateSeriesStroke = auto;
    }

    [LineNumberTable((ushort) 1408)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getItemOutlineStroke(int row, int column)
    {
      return this.lookupSeriesOutlineStroke(row);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 72, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlineStroke(int series, Stroke stroke)
    {
      this.setSeriesOutlineStroke(series, stroke, true);
    }

    public virtual Stroke getBaseOutlineStroke()
    {
      return this.baseOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 113, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseOutlineStroke(Stroke stroke)
    {
      this.setBaseOutlineStroke(stroke, true);
    }

    public virtual bool getAutoPopulateSeriesOutlineStroke()
    {
      return this.autoPopulateSeriesOutlineStroke;
    }

    public virtual void setAutoPopulateSeriesOutlineStroke(bool auto)
    {
      this.autoPopulateSeriesOutlineStroke = auto;
    }

    [LineNumberTable((ushort) 1574)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getItemShape(int row, int column)
    {
      return this.lookupSeriesShape(row);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 238, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShape(int series, Shape shape)
    {
      this.setSeriesShape(series, shape, true);
    }

    public virtual Shape getBaseShape()
    {
      return this.baseShape;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 23, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShape(Shape shape)
    {
      this.setBaseShape(shape, true);
    }

    public virtual bool getAutoPopulateSeriesShape()
    {
      return this.autoPopulateSeriesShape;
    }

    public virtual void setAutoPopulateSeriesShape(bool auto)
    {
      this.autoPopulateSeriesShape = auto;
    }

    [LineNumberTable((ushort) 1735)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isItemLabelVisible(int row, int column)
    {
      return (this.isSeriesItemLabelsVisible(row) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 211, (byte) 98, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelsVisible(int series, bool visible)
    {
      int num = visible ? 1 : 0;
      this.setSeriesItemLabelsVisible(series, BooleanUtilities.valueOf(num != 0));
    }

    public virtual Boolean getBaseItemLabelsVisible()
    {
      return this.baseItemLabelsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 197, (byte) 66, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelsVisible(bool visible)
    {
      this.setBaseItemLabelsVisible(BooleanUtilities.valueOf(visible));
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 221, (byte) 103, (byte) 99, (byte) 104, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getItemLabelFont(int row, int column)
    {
      return this.itemLabelFont ?? this.getSeriesItemLabelFont(row) ?? this.baseItemLabelFont;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 254, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelFont(int series, Font font)
    {
      this.setSeriesItemLabelFont(series, font, true);
    }

    public virtual Font getBaseItemLabelFont()
    {
      return this.baseItemLabelFont;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 40, (byte) 99, (byte) 144, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.setBaseItemLabelFont(font, true);
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 74, (byte) 103, (byte) 99, (byte) 104, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getItemLabelPaint(int row, int column)
    {
      return this.itemLabelPaint ?? this.getSeriesItemLabelPaint(row) ?? this.baseItemLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelPaint(int series, Paint paint)
    {
      this.setSeriesItemLabelPaint(series, paint, true);
    }

    public virtual Paint getBaseItemLabelPaint()
    {
      return this.baseItemLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 150, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelPaint(Paint paint)
    {
      this.setBaseItemLabelPaint(paint, true);
    }

    [LineNumberTable((ushort) 2092)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ItemLabelPosition getPositiveItemLabelPosition(int row, int column)
    {
      return this.getSeriesPositiveItemLabelPosition(row);
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 226, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPositiveItemLabelPosition(int series, ItemLabelPosition position)
    {
      this.setSeriesPositiveItemLabelPosition(series, position, true);
    }

    public virtual ItemLabelPosition getBasePositiveItemLabelPosition()
    {
      return this.basePositiveItemLabelPosition;
    }

    [LineNumberTable((ushort) 2213)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ItemLabelPosition getNegativeItemLabelPosition(int row, int column)
    {
      return this.getSeriesNegativeItemLabelPosition(row);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 91, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesNegativeItemLabelPosition(int series, ItemLabelPosition position)
    {
      this.setSeriesNegativeItemLabelPosition(series, position, true);
    }

    public virtual ItemLabelPosition getBaseNegativeItemLabelPosition()
    {
      return this.baseNegativeItemLabelPosition;
    }

    public virtual double getItemLabelAnchorOffset()
    {
      return this.itemLabelAnchorOffset;
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 176, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelAnchorOffset(double offset)
    {
      this.itemLabelAnchorOffset = offset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 190, (byte) 104, (byte) 174, (byte) 104, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemCreateEntity(int series, int item)
    {
      if (this.createEntities != null)
      {
        return (this.createEntities.booleanValue() ? 1 : 0) != 0;
      }
      else
      {
        Boolean seriesCreateEntities = this.getSeriesCreateEntities(series);
        if (seriesCreateEntities == null)
          return this.baseCreateEntities;
        return (seriesCreateEntities.booleanValue() ? 1 : 0) != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 228, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesCreateEntities(int series, Boolean create)
    {
      this.setSeriesCreateEntities(series, create, true);
    }

    public virtual bool getBaseCreateEntities()
    {
      return this.baseCreateEntities;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 46, (byte) 130, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseCreateEntities(bool create)
    {
      this.setBaseCreateEntities(create, true);
    }

    public virtual int getDefaultEntityRadius()
    {
      return this.defaultEntityRadius;
    }

    public virtual void setDefaultEntityRadius(int radius)
    {
      this.defaultEntityRadius = radius;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 70, (byte) 104, (byte) 99, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape lookupLegendShape(int series)
    {
      return (this.getLegendShape(series) ?? this.baseLegendShape) ?? this.lookupSeriesShape(series);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 106, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendShape(int series, Shape shape)
    {
      this.legendShape.setShape(series, shape);
      this.fireChangeEvent();
    }

    public virtual Shape getBaseLegendShape()
    {
      return this.baseLegendShape;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseLegendShape(Shape shape)
    {
      this.baseLegendShape = shape;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 144, (byte) 104, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font lookupLegendTextFont(int series)
    {
      return this.getLegendTextFont(series) ?? this.baseLegendTextFont;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 177, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendTextFont(int series, Font font)
    {
      this.legendTextFont.set(series, (object) font);
      this.fireChangeEvent();
    }

    public virtual Font getBaseLegendTextFont()
    {
      return this.baseLegendTextFont;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 201, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseLegendTextFont(Font font)
    {
      this.baseLegendTextFont = font;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 215, (byte) 104, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint lookupLegendTextPaint(int series)
    {
      return this.getLegendTextPaint(series) ?? this.baseLegendTextPaint;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 248, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendTextPaint(int series, Paint paint)
    {
      this.legendTextPaint.setPaint(series, paint);
      this.fireChangeEvent();
    }

    public virtual Paint getBaseLegendTextPaint()
    {
      return this.baseLegendTextPaint;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 16, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseLegendTextPaint(Paint paint)
    {
      this.baseLegendTextPaint = paint;
      this.fireChangeEvent();
    }

    public virtual bool getDataBoundsIncludesVisibleSeriesOnly()
    {
      return this.dataBoundsIncludesVisibleSeriesOnly;
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 231, (byte) 66, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataBoundsIncludesVisibleSeriesOnly(bool visibleOnly)
    {
      this.dataBoundsIncludesVisibleSeriesOnly = visibleOnly;
      this.notifyListeners(new RendererChangeEvent((object) this, true));
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 64, (byte) 98, (byte) 104, (byte) 143, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 150, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 150, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 150, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 191, (byte) 10, (byte) 104, (byte) 150, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 223, (byte) 30, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 223, (byte) 27, (byte) 104, (byte) 223, (byte) 27, (byte) 104, (byte) 187})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point2D calculateLabelAnchorPoint(ItemLabelAnchor anchor, double x, double y, PlotOrientation orientation)
    {
      Point2D.Double @double = (Point2D.Double) null;
      if (anchor == ItemLabelAnchor.__\u003C\u003ECENTER)
        @double = new Point2D.Double(x, y);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE1)
        @double = new Point2D.Double(x + AbstractRenderer.OPP * this.itemLabelAnchorOffset, y - AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE2)
        @double = new Point2D.Double(x + AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y - AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE3)
        @double = new Point2D.Double(x + this.itemLabelAnchorOffset, y);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE4)
        @double = new Point2D.Double(x + AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y + AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE5)
        @double = new Point2D.Double(x + AbstractRenderer.OPP * this.itemLabelAnchorOffset, y + AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE6)
        @double = new Point2D.Double(x, y + this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE7)
        @double = new Point2D.Double(x - AbstractRenderer.OPP * this.itemLabelAnchorOffset, y + AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE8)
        @double = new Point2D.Double(x - AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y + AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE9)
        @double = new Point2D.Double(x - this.itemLabelAnchorOffset, y);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE10)
        @double = new Point2D.Double(x - AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y - AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE11)
        @double = new Point2D.Double(x - AbstractRenderer.OPP * this.itemLabelAnchorOffset, y - AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EINSIDE12)
        @double = new Point2D.Double(x, y - this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE1)
        @double = new Point2D.Double(x + 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset, y - 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE2)
        @double = new Point2D.Double(x + 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y - 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE3)
        @double = new Point2D.Double(x + 2.0 * this.itemLabelAnchorOffset, y);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE4)
        @double = new Point2D.Double(x + 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y + 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE5)
        @double = new Point2D.Double(x + 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset, y + 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE6)
        @double = new Point2D.Double(x, y + 2.0 * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE7)
        @double = new Point2D.Double(x - 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset, y + 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE8)
        @double = new Point2D.Double(x - 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y + 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE9)
        @double = new Point2D.Double(x - 2.0 * this.itemLabelAnchorOffset, y);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE10)
        @double = new Point2D.Double(x - 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset, y - 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE11)
        @double = new Point2D.Double(x - 2.0 * AbstractRenderer.OPP * this.itemLabelAnchorOffset, y - 2.0 * AbstractRenderer.ADJ * this.itemLabelAnchorOffset);
      else if (anchor == ItemLabelAnchor.__\u003C\u003EOUTSIDE12)
        @double = new Point2D.Double(x, y - 2.0 * this.itemLabelAnchorOffset);
      return (Point2D) @double;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 210, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasListener(EventListener listener)
    {
      return (Arrays.asList(this.listenerList.getListenerList()).contains((object) listener) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 255, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 142, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 179, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 162, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 162, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 162, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractRenderer))
        return false;
      AbstractRenderer abstractRenderer = (AbstractRenderer) obj;
      return this.dataBoundsIncludesVisibleSeriesOnly == abstractRenderer.dataBoundsIncludesVisibleSeriesOnly && this.defaultEntityRadius == abstractRenderer.defaultEntityRadius && (ObjectUtilities.equal((object) this.seriesVisible, (object) abstractRenderer.seriesVisible) && this.seriesVisibleList.equals((object) abstractRenderer.seriesVisibleList)) && (this.baseSeriesVisible == abstractRenderer.baseSeriesVisible && ObjectUtilities.equal((object) this.seriesVisibleInLegend, (object) abstractRenderer.seriesVisibleInLegend) && (this.seriesVisibleInLegendList.equals((object) abstractRenderer.seriesVisibleInLegendList) && this.baseSeriesVisibleInLegend == abstractRenderer.baseSeriesVisibleInLegend)) && (PaintUtilities.equal(this.paint, abstractRenderer.paint) && ObjectUtilities.equal((object) this.paintList, (object) abstractRenderer.paintList) && (PaintUtilities.equal(this.basePaint, abstractRenderer.basePaint) && PaintUtilities.equal(this.fillPaint, abstractRenderer.fillPaint)) && (ObjectUtilities.equal((object) this.fillPaintList, (object) abstractRenderer.fillPaintList) && PaintUtilities.equal(this.baseFillPaint, abstractRenderer.baseFillPaint) && (PaintUtilities.equal(this.outlinePaint, abstractRenderer.outlinePaint) && ObjectUtilities.equal((object) this.outlinePaintList, (object) abstractRenderer.outlinePaintList)))) && (PaintUtilities.equal(this.baseOutlinePaint, abstractRenderer.baseOutlinePaint) && ObjectUtilities.equal((object) this.stroke, (object) abstractRenderer.stroke) && (ObjectUtilities.equal((object) this.strokeList, (object) abstractRenderer.strokeList) && ObjectUtilities.equal((object) this.baseStroke, (object) abstractRenderer.baseStroke)) && (ObjectUtilities.equal((object) this.outlineStroke, (object) abstractRenderer.outlineStroke) && ObjectUtilities.equal((object) this.outlineStrokeList, (object) abstractRenderer.outlineStrokeList) && (ObjectUtilities.equal((object) this.baseOutlineStroke, (object) abstractRenderer.baseOutlineStroke) && ShapeUtilities.equal(this.shape, abstractRenderer.shape))) && (ObjectUtilities.equal((object) this.shapeList, (object) abstractRenderer.shapeList) && ShapeUtilities.equal(this.baseShape, abstractRenderer.baseShape) && (ObjectUtilities.equal((object) this.itemLabelsVisible, (object) abstractRenderer.itemLabelsVisible) && ObjectUtilities.equal((object) this.itemLabelsVisibleList, (object) abstractRenderer.itemLabelsVisibleList)) && (ObjectUtilities.equal((object) this.baseItemLabelsVisible, (object) abstractRenderer.baseItemLabelsVisible) && ObjectUtilities.equal((object) this.itemLabelFont, (object) abstractRenderer.itemLabelFont) && (ObjectUtilities.equal((object) this.itemLabelFontList, (object) abstractRenderer.itemLabelFontList) && ObjectUtilities.equal((object) this.baseItemLabelFont, (object) abstractRenderer.baseItemLabelFont))))) && (PaintUtilities.equal(this.itemLabelPaint, abstractRenderer.itemLabelPaint) && ObjectUtilities.equal((object) this.itemLabelPaintList, (object) abstractRenderer.itemLabelPaintList) && (PaintUtilities.equal(this.baseItemLabelPaint, abstractRenderer.baseItemLabelPaint) && ObjectUtilities.equal((object) this.positiveItemLabelPosition, (object) abstractRenderer.positiveItemLabelPosition)) && (ObjectUtilities.equal((object) this.positiveItemLabelPositionList, (object) abstractRenderer.positiveItemLabelPositionList) && ObjectUtilities.equal((object) this.basePositiveItemLabelPosition, (object) abstractRenderer.basePositiveItemLabelPosition) && (ObjectUtilities.equal((object) this.negativeItemLabelPosition, (object) abstractRenderer.negativeItemLabelPosition) && ObjectUtilities.equal((object) this.negativeItemLabelPositionList, (object) abstractRenderer.negativeItemLabelPositionList))) && (ObjectUtilities.equal((object) this.baseNegativeItemLabelPosition, (object) abstractRenderer.baseNegativeItemLabelPosition) && this.itemLabelAnchorOffset == abstractRenderer.itemLabelAnchorOffset && (ObjectUtilities.equal((object) this.createEntities, (object) abstractRenderer.createEntities) && ObjectUtilities.equal((object) this.createEntitiesList, (object) abstractRenderer.createEntitiesList)) && (this.baseCreateEntities == abstractRenderer.baseCreateEntities && ObjectUtilities.equal((object) this.legendShape, (object) abstractRenderer.legendShape) && (ShapeUtilities.equal(this.baseLegendShape, abstractRenderer.baseLegendShape) && ObjectUtilities.equal((object) this.legendTextFont, (object) abstractRenderer.legendTextFont)))) && (ObjectUtilities.equal((object) this.baseLegendTextFont, (object) abstractRenderer.baseLegendTextFont) && ObjectUtilities.equal((object) this.legendTextPaint, (object) abstractRenderer.legendTextPaint) && PaintUtilities.equal(this.baseLegendTextPaint, abstractRenderer.baseLegendTextPaint)));
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 197, (byte) 102, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 173, (byte) 109, (byte) 237, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(193, this.seriesVisibleList), this.baseSeriesVisible), this.seriesVisibleInLegendList), this.baseSeriesVisibleInLegend), this.paintList), this.basePaint), this.fillPaintList), this.baseFillPaint), this.outlinePaintList), this.baseOutlinePaint), this.strokeList), this.baseStroke), this.outlineStrokeList), this.baseOutlineStroke), this.itemLabelsVisibleList), (IComparable) this.baseItemLabelsVisible);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 171, (byte) 239, (byte) 140, (byte) 104, (byte) 214, (byte) 104, (byte) 246, (byte) 69, (byte) 104, (byte) 214, (byte) 104, (byte) 182, (byte) 104, (byte) 246, (byte) 69, (byte) 104, (byte) 246, (byte) 69, (byte) 104, (byte) 246, (byte) 69, (byte) 104, (byte) 145, (byte) 104, (byte) 150, (byte) 104, (byte) 209, (byte) 104, (byte) 246, (byte) 70, (byte) 104, (byte) 246, (byte) 70, (byte) 104, (byte) 246, (byte) 70, (byte) 104, (byte) 246, (byte) 70, (byte) 104, (byte) 246, (byte) 69, (byte) 104, (byte) 214, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object clone()
    {
      AbstractRenderer abstractRenderer = (AbstractRenderer) base.clone();
      if (this.seriesVisibleList != null)
        abstractRenderer.seriesVisibleList = (BooleanList) this.seriesVisibleList.clone();
      if (this.seriesVisibleInLegendList != null)
        abstractRenderer.seriesVisibleInLegendList = (BooleanList) this.seriesVisibleInLegendList.clone();
      if (this.paintList != null)
        abstractRenderer.paintList = (PaintList) this.paintList.clone();
      if (this.fillPaintList != null)
        abstractRenderer.fillPaintList = (PaintList) this.fillPaintList.clone();
      if (this.outlinePaintList != null)
        abstractRenderer.outlinePaintList = (PaintList) this.outlinePaintList.clone();
      if (this.strokeList != null)
        abstractRenderer.strokeList = (StrokeList) this.strokeList.clone();
      if (this.outlineStrokeList != null)
        abstractRenderer.outlineStrokeList = (StrokeList) this.outlineStrokeList.clone();
      if (this.shape != null)
        abstractRenderer.shape = ShapeUtilities.clone(this.shape);
      if (this.shapeList != null)
        abstractRenderer.shapeList = (ShapeList) this.shapeList.clone();
      if (this.baseShape != null)
        abstractRenderer.baseShape = ShapeUtilities.clone(this.baseShape);
      if (this.itemLabelsVisibleList != null)
        abstractRenderer.itemLabelsVisibleList = (BooleanList) this.itemLabelsVisibleList.clone();
      if (this.itemLabelFontList != null)
        abstractRenderer.itemLabelFontList = (ObjectList) this.itemLabelFontList.clone();
      if (this.itemLabelPaintList != null)
        abstractRenderer.itemLabelPaintList = (PaintList) this.itemLabelPaintList.clone();
      if (this.positiveItemLabelPositionList != null)
        abstractRenderer.positiveItemLabelPositionList = (ObjectList) this.positiveItemLabelPositionList.clone();
      if (this.negativeItemLabelPositionList != null)
        abstractRenderer.negativeItemLabelPositionList = (ObjectList) this.negativeItemLabelPositionList.clone();
      if (this.createEntitiesList != null)
        abstractRenderer.createEntitiesList = (BooleanList) this.createEntitiesList.clone();
      if (this.legendShape != null)
        abstractRenderer.legendShape = (ShapeList) this.legendShape.clone();
      if (this.legendTextFont != null)
        abstractRenderer.legendTextFont = (ObjectList) this.legendTextFont.clone();
      if (this.legendTextPaint != null)
        abstractRenderer.legendTextPaint = (PaintList) this.legendTextPaint.clone();
      abstractRenderer.listenerList = new EventListenerList();
      abstractRenderer.@event = (RendererChangeEvent) null;
      return (object) abstractRenderer;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 172, (byte) 96, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writePaint(this.basePaint, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
      SerialUtilities.writePaint(this.baseFillPaint, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.baseOutlinePaint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writeStroke(this.baseStroke, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writeStroke(this.baseOutlineStroke, obj0);
      SerialUtilities.writeShape(this.shape, obj0);
      SerialUtilities.writeShape(this.baseShape, obj0);
      SerialUtilities.writePaint(this.itemLabelPaint, obj0);
      SerialUtilities.writePaint(this.baseItemLabelPaint, obj0);
      SerialUtilities.writeShape(this.baseLegendShape, obj0);
      SerialUtilities.writePaint(this.baseLegendTextPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 172, (byte) 127, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 204, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.basePaint = SerialUtilities.readPaint(obj0);
      this.fillPaint = SerialUtilities.readPaint(obj0);
      this.baseFillPaint = SerialUtilities.readPaint(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.baseOutlinePaint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
      this.baseStroke = SerialUtilities.readStroke(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.baseOutlineStroke = SerialUtilities.readStroke(obj0);
      this.shape = SerialUtilities.readShape(obj0);
      this.baseShape = SerialUtilities.readShape(obj0);
      this.itemLabelPaint = SerialUtilities.readPaint(obj0);
      this.baseItemLabelPaint = SerialUtilities.readPaint(obj0);
      this.baseLegendShape = SerialUtilities.readShape(obj0);
      this.baseLegendTextPaint = SerialUtilities.readPaint(obj0);
      this.listenerList = new EventListenerList();
    }

    [Obsolete]
    public virtual Boolean getSeriesVisible()
    {
      return this.seriesVisible;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 47, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisible(Boolean visible)
    {
      this.setSeriesVisible(visible, true);
    }

    [Obsolete]
    public virtual Boolean getSeriesVisibleInLegend()
    {
      return this.seriesVisibleInLegend;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 110, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesVisibleInLegend(Boolean visible)
    {
      this.setSeriesVisibleInLegend(visible, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 148, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      this.setPaint(paint, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 179, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaint(Paint paint)
    {
      this.setFillPaint(paint, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 211, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      this.setOutlinePaint(paint, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 173, (byte) 243, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      this.setStroke(stroke, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 19, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke)
    {
      this.setOutlineStroke(stroke, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 51, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShape(Shape shape)
    {
      this.setShape(shape, true);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 155, (byte) 221, (byte) 66, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelsVisible(bool visible)
    {
      this.setItemLabelsVisible(BooleanUtilities.valueOf(visible));
    }

    [Obsolete]
    public virtual Font getItemLabelFont()
    {
      return this.itemLabelFont;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 149, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelFont(Font font)
    {
      this.setItemLabelFont(font, true);
    }

    [Obsolete]
    public virtual Paint getItemLabelPaint()
    {
      return this.itemLabelPaint;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 197, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelPaint(Paint paint)
    {
      this.setItemLabelPaint(paint, true);
    }

    [Obsolete]
    public virtual ItemLabelPosition getPositiveItemLabelPosition()
    {
      return this.positiveItemLabelPosition;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 174, (byte) 251, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveItemLabelPosition(ItemLabelPosition position)
    {
      this.setPositiveItemLabelPosition(position, true);
    }

    [Obsolete]
    public virtual ItemLabelPosition getNegativeItemLabelPosition()
    {
      return this.negativeItemLabelPosition;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 175, (byte) 53, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeItemLabelPosition(ItemLabelPosition position)
    {
      this.setNegativeItemLabelPosition(position, true);
    }

    [Obsolete]
    public virtual Boolean getCreateEntities()
    {
      return this.createEntities;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 175, (byte) 110, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCreateEntities(Boolean create)
    {
      this.setCreateEntities(create, true);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractRenderer.__\u003CcallerID\u003E == null)
        AbstractRenderer.__\u003CcallerID\u003E = (CallerID) new AbstractRenderer.__\u003CCallerID\u003E();
      return AbstractRenderer.__\u003CcallerID\u003E;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
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
