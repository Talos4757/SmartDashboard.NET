// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.Plot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.io;
using java.lang;
using java.util;
using javax.swing.@event;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.event.AxisChangeListener", "org.jfree.data.general.DatasetChangeListener", "org.jfree.chart.event.MarkerChangeListener", "org.jfree.chart.LegendItemSource", "org.jfree.util.PublicCloneable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class Plot : Object, AxisChangeListener, EventListener, DatasetChangeListener, MarkerChangeListener, LegendItemSource, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal static Number __\u003C\u003EZERO = (Number) new Integer(0);
    internal static RectangleInsets __\u003C\u003EDEFAULT_INSETS = new RectangleInsets(4.0, 8.0, 4.0, 8.0);
    internal static Stroke __\u003C\u003EDEFAULT_OUTLINE_STROKE = (Stroke) new BasicStroke(0.5f);
    internal static Paint __\u003C\u003EDEFAULT_OUTLINE_PAINT = (Paint) Color.gray;
    internal static Paint __\u003C\u003EDEFAULT_BACKGROUND_PAINT = (Paint) Color.white;
    internal static Shape __\u003C\u003EDEFAULT_LEGEND_ITEM_BOX = (Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0);
    internal static Shape __\u003C\u003EDEFAULT_LEGEND_ITEM_CIRCLE = (Shape) new Ellipse2D.Double(-4.0, -4.0, 8.0, 8.0);
    private const long serialVersionUID = -8831571430103671324L;
    public const float DEFAULT_FOREGROUND_ALPHA = 1f;
    public const float DEFAULT_BACKGROUND_ALPHA = 1f;
    public const int MINIMUM_WIDTH_TO_DRAW = 10;
    public const int MINIMUM_HEIGHT_TO_DRAW = 10;
    private Plot parent;
    private DatasetGroup datasetGroup;
    private string noDataMessage;
    private Font noDataMessageFont;
    [NonSerialized]
    private Paint noDataMessagePaint;
    private RectangleInsets insets;
    private bool outlineVisible;
    [NonSerialized]
    private Stroke outlineStroke;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Image backgroundImage;
    private int backgroundImageAlignment;
    private float backgroundImageAlpha;
    private float foregroundAlpha;
    private float backgroundAlpha;
    private DrawingSupplier drawingSupplier;
    [NonSerialized]
    private EventListenerList listenerList;
    private bool notify;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static Number ZERO
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EZERO;
      }
    }

    [Modifiers]
    public static RectangleInsets DEFAULT_INSETS
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_INSETS;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_OUTLINE_STROKE
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_OUTLINE_PAINT
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_BACKGROUND_PAINT
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_BACKGROUND_PAINT;
      }
    }

    [Modifiers]
    public static Shape DEFAULT_LEGEND_ITEM_BOX
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_LEGEND_ITEM_BOX;
      }
    }

    [Modifiers]
    public static Shape DEFAULT_LEGEND_ITEM_CIRCLE
    {
      [HideFromJava] get
      {
        return Plot.__\u003C\u003EDEFAULT_LEGEND_ITEM_CIRCLE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 171, (byte) 223, (byte) 15, (byte) 175, (byte) 234, (byte) 73, (byte) 234, (byte) 73, (byte) 223, (byte) 15})]
    static Plot()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 232, (byte) 35, (byte) 168, (byte) 235, (byte) 92, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 115, (byte) 139, (byte) 139, (byte) 103, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Plot()
    {
      base.\u002Ector();
      Plot plot = this;
      this.backgroundImageAlignment = 15;
      this.backgroundImageAlpha = 0.5f;
      this.parent = (Plot) null;
      this.insets = Plot.__\u003C\u003EDEFAULT_INSETS;
      this.backgroundPaint = Plot.__\u003C\u003EDEFAULT_BACKGROUND_PAINT;
      this.backgroundAlpha = 1f;
      this.backgroundImage = (Image) null;
      this.outlineVisible = true;
      this.outlineStroke = Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
      this.outlinePaint = Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
      this.foregroundAlpha = 1f;
      this.noDataMessage = (string) null;
      this.noDataMessageFont = new Font("SansSerif", 0, 12);
      this.noDataMessagePaint = (Paint) Color.black;
      this.drawingSupplier = (DrawingSupplier) new DefaultDrawingSupplier();
      this.notify = true;
      this.listenerList = new EventListenerList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Plot([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Plot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Plot obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 146, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInsets(RectangleInsets insets)
    {
      this.setInsets(insets, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 194, (byte) 99, (byte) 104, (byte) 103, (byte) 200, (byte) 104, (byte) 110, (byte) 161, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        if (this.backgroundPaint == null)
          return;
        this.backgroundPaint = (Paint) null;
        this.fireChangeEvent();
      }
      else
      {
        if (this.backgroundPaint != null && Object.instancehelper_equals((object) this.backgroundPaint, (object) paint))
          return;
        this.backgroundPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 182, (byte) 99, (byte) 104, (byte) 103, (byte) 200, (byte) 104, (byte) 110, (byte) 161, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        if (this.outlineStroke == null)
          return;
        this.outlineStroke = (Stroke) null;
        this.fireChangeEvent();
      }
      else
      {
        if (this.outlineStroke != null && Object.instancehelper_equals((object) this.outlineStroke, (object) stroke))
          return;
        this.outlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 1, (byte) 106, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setForegroundAlpha(float alpha)
    {
      if ((double) this.foregroundAlpha == (double) alpha)
        return;
      this.foregroundAlpha = alpha;
      this.fireChangeEvent();
    }

    public virtual bool isNotify()
    {
      return this.notify;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 167, (byte) 98, (byte) 135, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNotify(bool notify)
    {
      int num = notify ? 1 : 0;
      this.notify = num != 0;
      if (num == 0)
        return;
      this.notifyListeners(new PlotChangeEvent(this));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 58, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(PlotChangeListener listener)
    {
      this.listenerList.add(Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener != null ? Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener : (Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener = Plot.class\u0024("org.jfree.chart.event.PlotChangeListener")), (EventListener) listener);
    }

    public abstract void draw(Graphics2D gd, Rectangle2D rd, Point2D pd, PlotState ps, PlotRenderingInfo pri);

    public virtual void handleClick(int x, int y, PlotRenderingInfo info)
    {
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 217, (byte) 172, (byte) 104, (byte) 182, (byte) 150, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      Plot plot = (Plot) base.clone();
      if (this.datasetGroup != null)
        plot.datasetGroup = (DatasetGroup) ObjectUtilities.clone((object) this.datasetGroup);
      plot.drawingSupplier = (DrawingSupplier) ObjectUtilities.clone((object) this.drawingSupplier);
      plot.listenerList = new EventListenerList();
      return (object) plot;
    }

    public virtual void zoom(double percent)
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 246, (byte) 98, (byte) 103, (byte) 99, (byte) 169, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DrawingSupplier getDrawingSupplier()
    {
      Plot parent = this.getParent();
      return parent == null ? this.drawingSupplier : parent.getDrawingSupplier();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 14, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawingSupplier(DrawingSupplier supplier)
    {
      this.drawingSupplier = supplier;
      this.fireChangeEvent();
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 220, (byte) 99, (byte) 104, (byte) 103, (byte) 200, (byte) 104, (byte) 110, (byte) 161, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        if (this.outlinePaint == null)
          return;
        this.outlinePaint = (Paint) null;
        this.fireChangeEvent();
      }
      else
      {
        if (this.outlinePaint != null && Object.instancehelper_equals((object) this.outlinePaint, (object) paint))
          return;
        this.outlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 23, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 130, (byte) 104, (byte) 104, (byte) 139, (byte) 107, (byte) 171, (byte) 104, (byte) 104, (byte) 139, (byte) 107, (byte) 168, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 168, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 198, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RectangleEdge resolveDomainAxisLocation(AxisLocation location, PlotOrientation orientation)
    {
      if (location == null)
      {
        string str = "Null 'location' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        RectangleEdge rectangleEdge = (RectangleEdge) null;
        if (location == AxisLocation.__\u003C\u003ETOP_OR_RIGHT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
        }
        else if (location == AxisLocation.__\u003C\u003ETOP_OR_LEFT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
        }
        else if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
        }
        else if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
        }
        if (rectangleEdge != null)
          return rectangleEdge;
        string str = "resolveDomainAxisLocation()";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 83, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 130, (byte) 104, (byte) 104, (byte) 139, (byte) 107, (byte) 171, (byte) 104, (byte) 104, (byte) 139, (byte) 107, (byte) 168, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 168, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 230, (byte) 69, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RectangleEdge resolveRangeAxisLocation(AxisLocation location, PlotOrientation orientation)
    {
      if (location == null)
      {
        string str = "Null 'location' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        RectangleEdge rectangleEdge = (RectangleEdge) null;
        if (location == AxisLocation.__\u003C\u003ETOP_OR_RIGHT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
        }
        else if (location == AxisLocation.__\u003C\u003ETOP_OR_LEFT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
        }
        else if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
        }
        else if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT)
        {
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
        }
        if (rectangleEdge != null)
          return rectangleEdge;
        string str = "resolveRangeAxisLocation()";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNoDataMessage(string message)
    {
      this.noDataMessage = message;
      this.fireChangeEvent();
    }

    public virtual RectangleInsets getInsets()
    {
      return this.insets;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    public abstract string getPlotType();

    [LineNumberTable(new byte[] {(byte) 164, (byte) 148, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Plot))
        return false;
      Plot plot = (Plot) obj;
      return ObjectUtilities.equal((object) this.noDataMessage, (object) plot.noDataMessage) && ObjectUtilities.equal((object) this.noDataMessageFont, (object) plot.noDataMessageFont) && (PaintUtilities.equal(this.noDataMessagePaint, plot.noDataMessagePaint) && ObjectUtilities.equal((object) this.insets, (object) plot.insets)) && (this.outlineVisible == plot.outlineVisible && ObjectUtilities.equal((object) this.outlineStroke, (object) plot.outlineStroke) && (PaintUtilities.equal(this.outlinePaint, plot.outlinePaint) && PaintUtilities.equal(this.backgroundPaint, plot.backgroundPaint))) && (ObjectUtilities.equal((object) this.backgroundImage, (object) plot.backgroundImage) && this.backgroundImageAlignment == plot.backgroundImageAlignment && ((double) this.backgroundImageAlpha == (double) plot.backgroundImageAlpha && (double) this.foregroundAlpha == (double) plot.foregroundAlpha) && ((double) this.backgroundAlpha == (double) plot.backgroundAlpha && Object.instancehelper_equals((object) this.drawingSupplier, (object) plot.drawingSupplier) && this.notify == plot.notify));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 97, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fireChangeEvent()
    {
      this.notifyListeners(new PlotChangeEvent(this));
    }

    public virtual Plot getParent()
    {
      return this.parent;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 103, (byte) 99, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Plot getRootPlot()
    {
      Plot parent = this.getParent();
      if (parent == null)
        return this;
      return parent.getRootPlot();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 10, (byte) 162, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 99, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInsets(RectangleInsets insets, bool notify)
    {
      int num = notify ? 1 : 0;
      if (insets == null)
      {
        string str = "Null 'insets' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.insets.equals((object) insets))
          return;
        this.insets = insets;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 80, (byte) 104, (byte) 129, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void notifyListeners(PlotChangeEvent @event)
    {
      if (!this.notify)
        return;
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener != null ? Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener : (Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener = Plot.class\u0024("org.jfree.chart.event.PlotChangeListener"))))
          ((PlotChangeListener) listenerList[index + 1]).plotChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable((ushort) 940)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, Plot.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 148, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fillBackground(Graphics2D g2, Rectangle2D area)
    {
      this.fillBackground(g2, area, PlotOrientation.__\u003C\u003EVERTICAL);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 207, (byte) 107, (byte) 103, (byte) 146, (byte) 191, (byte) 11, (byte) 109, (byte) 191, (byte) 31, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawBackgroundImage(Graphics2D g2, Rectangle2D area)
    {
      if (this.backgroundImage == null)
        return;
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.backgroundImageAlpha));
      Rectangle2D.Double @double = new Rectangle2D.Double(0.0, 0.0, (double) this.backgroundImage.getWidth((ImageObserver) null), (double) this.backgroundImage.getHeight((ImageObserver) null));
      Align.align((Rectangle2D) @double, area, this.backgroundImageAlignment);
      ((Graphics) g2).drawImage(this.backgroundImage, ByteCodeHelper.d2i(((RectangularShape) @double).getX()), ByteCodeHelper.d2i(((RectangularShape) @double).getY()), ByteCodeHelper.d2i(((RectangularShape) @double).getWidth()) + 1, ByteCodeHelper.d2i(((RectangularShape) @double).getHeight()) + 1, (ImageObserver) null);
      g2.setComposite(composite);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 165, (byte) 99, (byte) 144, (byte) 104, (byte) 129, (byte) 103, (byte) 112, (byte) 108, (byte) 104, (byte) 255, (byte) 17, (byte) 69, (byte) 104, (byte) 255, (byte) 15, (byte) 70, (byte) 103, (byte) 146, (byte) 122, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fillBackground(Graphics2D g2, Rectangle2D area, PlotOrientation orientation)
    {
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.backgroundPaint == null)
          return;
        object obj1 = (object) this.backgroundPaint;
        if ((Paint) obj1 is GradientPaint)
        {
          GradientPaint gradientPaint = (GradientPaint) obj1;
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            obj1 = (object) new GradientPaint((float) ((RectangularShape) area).getCenterX(), (float) ((RectangularShape) area).getMaxY(), gradientPaint.getColor1(), (float) ((RectangularShape) area).getCenterX(), (float) ((RectangularShape) area).getMinY(), gradientPaint.getColor2());
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            obj1 = (object) new GradientPaint((float) ((RectangularShape) area).getMinX(), (float) ((RectangularShape) area).getCenterY(), gradientPaint.getColor1(), (float) ((RectangularShape) area).getMaxX(), (float) ((RectangularShape) area).getCenterY(), gradientPaint.getColor2());
        }
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, this.backgroundAlpha));
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
        g2.setComposite(composite);
      }
    }

    public virtual DatasetGroup getDatasetGroup()
    {
      return this.datasetGroup;
    }

    protected internal virtual void setDatasetGroup(DatasetGroup group)
    {
      this.datasetGroup = group;
    }

    public virtual string getNoDataMessage()
    {
      return this.noDataMessage;
    }

    public virtual Font getNoDataMessageFont()
    {
      return this.noDataMessageFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNoDataMessageFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.noDataMessageFont = font;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getNoDataMessagePaint()
    {
      return this.noDataMessagePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNoDataMessagePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.noDataMessagePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual void setParent(Plot parent)
    {
      this.parent = parent;
    }

    [LineNumberTable((ushort) 492)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSubplot()
    {
      return this.getParent() != null;
    }

    public virtual float getBackgroundAlpha()
    {
      return this.backgroundAlpha;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 232, (byte) 106, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundAlpha(float alpha)
    {
      if ((double) this.backgroundAlpha == (double) alpha)
        return;
      this.backgroundAlpha = alpha;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 233, (byte) 66, (byte) 103, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawingSupplier(DrawingSupplier supplier, bool notify)
    {
      int num = notify ? 1 : 0;
      this.drawingSupplier = supplier;
      if (num == 0)
        return;
      this.fireChangeEvent();
    }

    public virtual Image getBackgroundImage()
    {
      return this.backgroundImage;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 61, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImage(Image image)
    {
      this.backgroundImage = image;
      this.fireChangeEvent();
    }

    public virtual int getBackgroundImageAlignment()
    {
      return this.backgroundImageAlignment;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 89, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImageAlignment(int alignment)
    {
      if (this.backgroundImageAlignment == alignment)
        return;
      this.backgroundImageAlignment = alignment;
      this.fireChangeEvent();
    }

    public virtual float getBackgroundImageAlpha()
    {
      return this.backgroundImageAlpha;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 120, (byte) 114, (byte) 144, (byte) 106, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImageAlpha(float alpha)
    {
      if ((double) alpha < 0.0 || (double) alpha > 1.0)
      {
        string str = "The 'alpha' value must be in the range 0.0f to 1.0f.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if ((double) this.backgroundImageAlpha == (double) alpha)
          return;
        this.backgroundImageAlpha = alpha;
        this.fireChangeEvent();
      }
    }

    public virtual bool isOutlineVisible()
    {
      return this.outlineVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 203, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineVisible(bool visible)
    {
      this.outlineVisible = visible;
      this.fireChangeEvent();
    }

    public virtual float getForegroundAlpha()
    {
      return this.foregroundAlpha;
    }

    public virtual LegendItemCollection getLegendItems()
    {
      return (LegendItemCollection) null;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 69, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(PlotChangeListener listener)
    {
      this.listenerList.remove(Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener != null ? Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener : (Plot.class\u0024org\u0024jfree\u0024chart\u0024event\u0024PlotChangeListener = Plot.class\u0024("org.jfree.chart.event.PlotChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 133, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawBackground(Graphics2D g2, Rectangle2D area)
    {
      this.fillBackground(g2, area);
      this.drawBackgroundImage(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 232, (byte) 104, (byte) 129, (byte) 112, (byte) 108, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawOutline(Graphics2D g2, Rectangle2D area)
    {
      if (!this.outlineVisible || this.outlineStroke == null || this.outlinePaint == null)
        return;
      g2.setStroke(this.outlineStroke);
      g2.setPaint(this.outlinePaint);
      g2.draw((Shape) area);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 249, (byte) 103, (byte) 103, (byte) 103, (byte) 99, (byte) 108, (byte) 108, (byte) 223, (byte) 13, (byte) 186, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawNoDataMessage(Graphics2D g2, Rectangle2D area)
    {
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) area);
      if (this.noDataMessage != null)
      {
        ((Graphics) g2).setFont(this.noDataMessageFont);
        g2.setPaint(this.noDataMessagePaint);
        TextUtilities.createTextBlock(this.noDataMessage, this.noDataMessageFont, this.noDataMessagePaint, 0.9f * (float) ((RectangularShape) area).getWidth(), (TextMeasurer) new G2TextMeasurer(g2)).draw(g2, (float) ((RectangularShape) area).getCenterX(), (float) ((RectangularShape) area).getCenterY(), TextBlockAnchor.__\u003C\u003ECENTER);
      }
      ((Graphics) g2).setClip(clip);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 25, (byte) 107, (byte) 108, (byte) 99, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void createAndAddEntity(Rectangle2D dataArea, PlotRenderingInfo plotState, string toolTip, string urlText)
    {
      if (plotState == null || plotState.getOwner() == null)
        return;
      EntityCollection entityCollection = plotState.getOwner().getEntityCollection();
      if (entityCollection == null)
        return;
      entityCollection.add((ChartEntity) new PlotEntity((Shape) dataArea, this, toolTip, urlText));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 63, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void axisChanged(AxisChangeEvent @event)
    {
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 75, (byte) 103, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent @event)
    {
      PlotChangeEvent event1 = new PlotChangeEvent(this);
      event1.setType(ChartChangeEventType.__\u003C\u003EDATASET_UPDATED);
      this.notifyListeners(event1);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 89, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void markerChanged(MarkerChangeEvent @event)
    {
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 105, (byte) 99, (byte) 105, (byte) 136, (byte) 105, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double getRectX(double x, double w1, double w2, RectangleEdge edge)
    {
      double num = x;
      if (edge == RectangleEdge.__\u003C\u003ELEFT)
        num += w1;
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        num += w2;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 129, (byte) 99, (byte) 105, (byte) 136, (byte) 105, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double getRectY(double y, double h1, double h2, RectangleEdge edge)
    {
      double num = y;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        num += h1;
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        num += h2;
      return num;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 239, (byte) 102, (byte) 108, (byte) 108, (byte) 140, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.noDataMessagePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 1, (byte) 102, (byte) 108, (byte) 108, (byte) 140, (byte) 140, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.noDataMessagePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.listenerList = new EventListenerList();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Plot.__\u003CcallerID\u003E == null)
        Plot.__\u003CcallerID\u003E = (CallerID) new Plot.__\u003CCallerID\u003E();
      return Plot.__\u003CcallerID\u003E;
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
