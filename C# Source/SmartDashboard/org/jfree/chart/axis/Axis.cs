// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.Axis
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
using org.jfree.chart.@event;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class Axis : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal static Font __\u003C\u003EDEFAULT_AXIS_LABEL_FONT = new Font("SansSerif", 0, 12);
    internal static Paint __\u003C\u003EDEFAULT_AXIS_LABEL_PAINT = (Paint) Color.black;
    internal static RectangleInsets __\u003C\u003EDEFAULT_AXIS_LABEL_INSETS = new RectangleInsets(3.0, 3.0, 3.0, 3.0);
    internal static Paint __\u003C\u003EDEFAULT_AXIS_LINE_PAINT = (Paint) Color.gray;
    internal static Stroke __\u003C\u003EDEFAULT_AXIS_LINE_STROKE = (Stroke) new BasicStroke(1f);
    internal static Font __\u003C\u003EDEFAULT_TICK_LABEL_FONT = new Font("SansSerif", 0, 10);
    internal static Paint __\u003C\u003EDEFAULT_TICK_LABEL_PAINT = (Paint) Color.black;
    internal static RectangleInsets __\u003C\u003EDEFAULT_TICK_LABEL_INSETS = new RectangleInsets(2.0, 4.0, 2.0, 4.0);
    internal static Stroke __\u003C\u003EDEFAULT_TICK_MARK_STROKE = (Stroke) new BasicStroke(1f);
    internal static Paint __\u003C\u003EDEFAULT_TICK_MARK_PAINT = (Paint) Color.gray;
    private const long serialVersionUID = 7719289504573298271L;
    public const bool DEFAULT_AXIS_VISIBLE = true;
    public const bool DEFAULT_TICK_LABELS_VISIBLE = true;
    public const bool DEFAULT_TICK_MARKS_VISIBLE = true;
    public const float DEFAULT_TICK_MARK_INSIDE_LENGTH = 0.0f;
    public const float DEFAULT_TICK_MARK_OUTSIDE_LENGTH = 2f;
    private bool visible;
    private string label;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    private RectangleInsets labelInsets;
    private double labelAngle;
    private bool axisLineVisible;
    [NonSerialized]
    private Stroke axisLineStroke;
    [NonSerialized]
    private Paint axisLinePaint;
    private bool tickLabelsVisible;
    private Font tickLabelFont;
    [NonSerialized]
    private Paint tickLabelPaint;
    private RectangleInsets tickLabelInsets;
    private bool tickMarksVisible;
    private float tickMarkInsideLength;
    private float tickMarkOutsideLength;
    private bool minorTickMarksVisible;
    private float minorTickMarkInsideLength;
    private float minorTickMarkOutsideLength;
    [NonSerialized]
    private Stroke tickMarkStroke;
    [NonSerialized]
    private Paint tickMarkPaint;
    private double fixedDimension;
    [NonSerialized]
    private Plot plot;
    [NonSerialized]
    private EventListenerList listenerList;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static Font DEFAULT_AXIS_LABEL_FONT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_AXIS_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_PAINT;
      }
    }

    [Modifiers]
    public static RectangleInsets DEFAULT_AXIS_LABEL_INSETS
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_INSETS;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_AXIS_LINE_PAINT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_AXIS_LINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_AXIS_LINE_STROKE
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_AXIS_LINE_STROKE;
      }
    }

    [Modifiers]
    public static Font DEFAULT_TICK_LABEL_FONT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_TICK_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_TICK_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_TICK_LABEL_PAINT;
      }
    }

    [Modifiers]
    public static RectangleInsets DEFAULT_TICK_LABEL_INSETS
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_TICK_LABEL_INSETS;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_TICK_MARK_STROKE
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_TICK_MARK_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_TICK_MARK_PAINT
    {
      [HideFromJava] get
      {
        return Axis.__\u003C\u003EDEFAULT_TICK_MARK_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 210, (byte) 170, (byte) 223, (byte) 15, (byte) 170, (byte) 239, (byte) 70, (byte) 210, (byte) 170, (byte) 255, (byte) 15, (byte) 71, (byte) 175})]
    static Axis()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 136, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 140, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 135, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Axis(string label)
    {
      base.\u002Ector();
      Axis axis = this;
      this.label = label;
      this.visible = true;
      this.labelFont = Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_FONT;
      this.labelPaint = Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_PAINT;
      this.labelInsets = Axis.__\u003C\u003EDEFAULT_AXIS_LABEL_INSETS;
      this.labelAngle = 0.0;
      this.axisLineVisible = true;
      this.axisLinePaint = Axis.__\u003C\u003EDEFAULT_AXIS_LINE_PAINT;
      this.axisLineStroke = Axis.__\u003C\u003EDEFAULT_AXIS_LINE_STROKE;
      this.tickLabelsVisible = true;
      this.tickLabelFont = Axis.__\u003C\u003EDEFAULT_TICK_LABEL_FONT;
      this.tickLabelPaint = Axis.__\u003C\u003EDEFAULT_TICK_LABEL_PAINT;
      this.tickLabelInsets = Axis.__\u003C\u003EDEFAULT_TICK_LABEL_INSETS;
      this.tickMarksVisible = true;
      this.tickMarkStroke = Axis.__\u003C\u003EDEFAULT_TICK_MARK_STROKE;
      this.tickMarkPaint = Axis.__\u003C\u003EDEFAULT_TICK_MARK_PAINT;
      this.tickMarkInsideLength = 0.0f;
      this.tickMarkOutsideLength = 2f;
      this.minorTickMarksVisible = false;
      this.minorTickMarkInsideLength = 0.0f;
      this.minorTickMarkOutsideLength = 2f;
      this.plot = (Plot) null;
      this.listenerList = new EventListenerList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Axis([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Axis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Axis obj0)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 7, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLineVisible(bool visible)
    {
      this.axisLineVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 205, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarksVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num == (this.tickMarksVisible ? 1 : 0))
        return;
      this.tickMarksVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 116, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelInsets(RectangleInsets insets)
    {
      if (insets == null)
      {
        string str = "Null 'insets' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.tickLabelInsets.equals((object) insets))
          return;
        this.tickLabelInsets = insets;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 41, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
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
        if (this.labelFont.equals((object) font))
          return;
        this.labelFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 58, (byte) 99, (byte) 176, (byte) 110, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.tickLabelFont.equals((object) font))
          return;
        this.tickLabelFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 89, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
      {
        this.tickLabelPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 21, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fireChangeEvent()
    {
      this.notifyListeners(new AxisChangeEvent(this));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 22, (byte) 98, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelInsets(RectangleInsets insets, bool notify)
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
        if (insets.equals((object) this.labelInsets))
          return;
        this.labelInsets = insets;
        if (num == 0)
          return;
        this.fireChangeEvent();
      }
    }

    public abstract void configure();

    [LineNumberTable((ushort) 1110)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, Axis.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 7, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(AxisChangeEvent @event)
    {
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener != null ? Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener : (Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener = Axis.class\u0024("org.jfree.chart.event.AxisChangeListener"))))
          ((AxisChangeListener) listenerList[index + 1]).axisChanged(@event);
        index += -2;
      }
    }

    public virtual string getLabel()
    {
      return this.label;
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    public virtual RectangleInsets getLabelInsets()
    {
      return this.labelInsets;
    }

    public virtual double getLabelAngle()
    {
      return this.labelAngle;
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    public virtual bool isVisible()
    {
      return this.visible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num == (this.visible ? 1 : 0))
        return;
      this.visible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 103, (byte) 99, (byte) 105, (byte) 103, (byte) 200, (byte) 99, (byte) 103, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabel(string label)
    {
      string str = this.label;
      if (str != null)
      {
        if (String.instancehelper_equals(str, (object) label))
          return;
        this.label = label;
        this.fireChangeEvent();
      }
      else
      {
        if (label == null)
          return;
        this.label = label;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelInsets(RectangleInsets insets)
    {
      this.setLabelInsets(insets, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 142, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelAngle(double angle)
    {
      this.labelAngle = angle;
      this.fireChangeEvent();
    }

    public virtual bool isAxisLineVisible()
    {
      return this.axisLineVisible;
    }

    public virtual Paint getAxisLinePaint()
    {
      return this.axisLinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 194, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axisLinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getAxisLineStroke()
    {
      return this.axisLineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 221, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axisLineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual bool isTickLabelsVisible()
    {
      return this.tickLabelsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 242, (byte) 66, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelsVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num == (this.tickLabelsVisible ? 1 : 0))
        return;
      this.tickLabelsVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual bool isMinorTickMarksVisible()
    {
      return this.minorTickMarksVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 234, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickMarksVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num == (this.minorTickMarksVisible ? 1 : 0))
        return;
      this.minorTickMarksVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual Font getTickLabelFont()
    {
      return this.tickLabelFont;
    }

    public virtual Paint getTickLabelPaint()
    {
      return this.tickLabelPaint;
    }

    public virtual RectangleInsets getTickLabelInsets()
    {
      return this.tickLabelInsets;
    }

    public virtual bool isTickMarksVisible()
    {
      return this.tickMarksVisible;
    }

    public virtual float getTickMarkInsideLength()
    {
      return this.tickMarkInsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 174, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarkInsideLength(float length)
    {
      this.tickMarkInsideLength = length;
      this.fireChangeEvent();
    }

    public virtual float getTickMarkOutsideLength()
    {
      return this.tickMarkOutsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 199, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarkOutsideLength(float length)
    {
      this.tickMarkOutsideLength = length;
      this.fireChangeEvent();
    }

    public virtual Stroke getTickMarkStroke()
    {
      return this.tickMarkStroke;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 223, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarkStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (Object.instancehelper_equals((object) this.tickMarkStroke, (object) stroke))
          return;
        this.tickMarkStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getTickMarkPaint()
    {
      return this.tickMarkPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 252, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarkPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickMarkPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual float getMinorTickMarkInsideLength()
    {
      return this.minorTickMarkInsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 28, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickMarkInsideLength(float length)
    {
      this.minorTickMarkInsideLength = length;
      this.fireChangeEvent();
    }

    public virtual float getMinorTickMarkOutsideLength()
    {
      return this.minorTickMarkOutsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 57, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickMarkOutsideLength(float length)
    {
      this.minorTickMarkOutsideLength = length;
      this.fireChangeEvent();
    }

    public virtual Plot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 84, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlot(Plot plot)
    {
      this.plot = plot;
      this.configure();
    }

    public virtual double getFixedDimension()
    {
      return this.fixedDimension;
    }

    public virtual void setFixedDimension(double dimension)
    {
      this.fixedDimension = dimension;
    }

    public abstract AxisSpace reserveSpace(Graphics2D gd, Plot p, Rectangle2D rd, RectangleEdge re, AxisSpace @as);

    public abstract AxisState draw(Graphics2D gd, double d, Rectangle2D rd1, Rectangle2D rd2, RectangleEdge re, PlotRenderingInfo pri);

    public abstract List refreshTicks(Graphics2D gd, AxisState @as, Rectangle2D rd, RectangleEdge re);

    [LineNumberTable(new byte[] {(byte) 163, (byte) 192, (byte) 109, (byte) 129, (byte) 98, (byte) 110, (byte) 223, (byte) 7, (byte) 110, (byte) 191, (byte) 0, (byte) 110, (byte) 223, (byte) 4, (byte) 110, (byte) 189, (byte) 109, (byte) 99, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void createAndAddEntity(double cursor, AxisState state, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (plotState == null || plotState.getOwner() == null)
        return;
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      if (edge.equals((object) RectangleEdge.__\u003C\u003ETOP))
        @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), state.getCursor(), ((RectangularShape) dataArea).getWidth(), cursor - state.getCursor());
      else if (edge.equals((object) RectangleEdge.__\u003C\u003EBOTTOM))
        @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), cursor, ((RectangularShape) dataArea).getWidth(), state.getCursor() - cursor);
      else if (edge.equals((object) RectangleEdge.__\u003C\u003ELEFT))
        @double = new Rectangle2D.Double(state.getCursor(), ((RectangularShape) dataArea).getY(), cursor - state.getCursor(), ((RectangularShape) dataArea).getHeight());
      else if (edge.equals((object) RectangleEdge.__\u003C\u003ERIGHT))
        @double = new Rectangle2D.Double(cursor, ((RectangularShape) dataArea).getY(), state.getCursor() - cursor, ((RectangularShape) dataArea).getHeight());
      EntityCollection entityCollection = plotState.getOwner().getEntityCollection();
      if (entityCollection == null)
        return;
      entityCollection.add((ChartEntity) new AxisEntity((Shape) @double, this));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 228, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(AxisChangeListener listener)
    {
      this.listenerList.add(Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener != null ? Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener : (Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener = Axis.class\u0024("org.jfree.chart.event.AxisChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 239, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(AxisChangeListener listener)
    {
      this.listenerList.remove(Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener != null ? Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener : (Axis.class\u0024org\u0024jfree\u0024chart\u0024event\u0024AxisChangeListener = Axis.class\u0024("org.jfree.chart.event.AxisChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 252, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasListener(EventListener listener)
    {
      return (Arrays.asList(this.listenerList.getListenerList()).contains((object) listener) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 35, (byte) 102, (byte) 103, (byte) 118, (byte) 109, (byte) 105, (byte) 104, (byte) 105, (byte) 105, (byte) 112, (byte) 143, (byte) 105, (byte) 105, (byte) 141, (byte) 106, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Rectangle2D getLabelEnclosure(Graphics2D g2, RectangleEdge edge)
    {
      Rectangle2D rectangle2D = (Rectangle2D) new Rectangle2D.Double();
      string label = this.getLabel();
      if (label != null && !String.instancehelper_equals(label, (object) ""))
      {
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getLabelFont());
        Rectangle2D outsetRectangle = this.getLabelInsets().createOutsetRectangle(TextUtilities.getTextBounds(label, g2, fontMetrics));
        double labelAngle = this.getLabelAngle();
        if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
          labelAngle -= Math.PI / 2.0;
        double centerX = ((RectangularShape) outsetRectangle).getCenterX();
        double centerY = ((RectangularShape) outsetRectangle).getCenterY();
        rectangle2D = AffineTransform.getRotateInstance(labelAngle, centerX, centerY).createTransformedShape((Shape) outsetRectangle).getBounds2D();
      }
      return rectangle2D;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 75, (byte) 100, (byte) 176, (byte) 112, (byte) 163, (byte) 103, (byte) 103, (byte) 103, (byte) 108, (byte) 103, (byte) 137, (byte) 108, (byte) 185, (byte) 106, (byte) 104, (byte) 106, (byte) 159, (byte) 3, (byte) 189, (byte) 155, (byte) 101, (byte) 108, (byte) 185, (byte) 106, (byte) 104, (byte) 106, (byte) 159, (byte) 3, (byte) 189, (byte) 155, (byte) 101, (byte) 108, (byte) 191, (byte) 4, (byte) 106, (byte) 104, (byte) 159, (byte) 3, (byte) 106, (byte) 191, (byte) 8, (byte) 155, (byte) 101, (byte) 140, (byte) 191, (byte) 4, (byte) 106, (byte) 104, (byte) 159, (byte) 3, (byte) 124, (byte) 191, (byte) 8, (byte) 251, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawLabel(string label, Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, AxisState state)
    {
      if (state == null)
      {
        string str = "Null 'state' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (label == null || String.instancehelper_equals(label, (object) ""))
          return state;
        Font labelFont = this.getLabelFont();
        RectangleInsets labelInsets = this.getLabelInsets();
        ((Graphics) g2).setFont(labelFont);
        g2.setPaint(this.getLabelPaint());
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
        Rectangle2D textBounds = TextUtilities.getTextBounds(label, g2, fontMetrics);
        if (edge == RectangleEdge.__\u003C\u003ETOP)
        {
          Rectangle2D bounds2D = AffineTransform.getRotateInstance(this.getLabelAngle(), ((RectangularShape) textBounds).getCenterX(), ((RectangularShape) textBounds).getCenterY()).createTransformedShape((Shape) textBounds).getBounds2D();
          double centerX = ((RectangularShape) dataArea).getCenterX();
          double num = state.getCursor() - labelInsets.getBottom() - ((RectangularShape) bounds2D).getHeight() / 2.0;
          TextUtilities.drawRotatedString(label, g2, (float) centerX, (float) num, TextAnchor.__\u003C\u003ECENTER, this.getLabelAngle(), TextAnchor.__\u003C\u003ECENTER);
          state.cursorUp(labelInsets.getTop() + ((RectangularShape) bounds2D).getHeight() + labelInsets.getBottom());
        }
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          Rectangle2D bounds2D = AffineTransform.getRotateInstance(this.getLabelAngle(), ((RectangularShape) textBounds).getCenterX(), ((RectangularShape) textBounds).getCenterY()).createTransformedShape((Shape) textBounds).getBounds2D();
          double centerX = ((RectangularShape) dataArea).getCenterX();
          double num = state.getCursor() + labelInsets.getTop() + ((RectangularShape) bounds2D).getHeight() / 2.0;
          TextUtilities.drawRotatedString(label, g2, (float) centerX, (float) num, TextAnchor.__\u003C\u003ECENTER, this.getLabelAngle(), TextAnchor.__\u003C\u003ECENTER);
          state.cursorDown(labelInsets.getTop() + ((RectangularShape) bounds2D).getHeight() + labelInsets.getBottom());
        }
        else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        {
          Rectangle2D bounds2D = AffineTransform.getRotateInstance(this.getLabelAngle() - Math.PI / 2.0, ((RectangularShape) textBounds).getCenterX(), ((RectangularShape) textBounds).getCenterY()).createTransformedShape((Shape) textBounds).getBounds2D();
          double num = state.getCursor() - labelInsets.getRight() - ((RectangularShape) bounds2D).getWidth() / 2.0;
          double centerY = ((RectangularShape) dataArea).getCenterY();
          TextUtilities.drawRotatedString(label, g2, (float) num, (float) centerY, TextAnchor.__\u003C\u003ECENTER, this.getLabelAngle() - Math.PI / 2.0, TextAnchor.__\u003C\u003ECENTER);
          state.cursorLeft(labelInsets.getLeft() + ((RectangularShape) bounds2D).getWidth() + labelInsets.getRight());
        }
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          Rectangle2D bounds2D = AffineTransform.getRotateInstance(this.getLabelAngle() + Math.PI / 2.0, ((RectangularShape) textBounds).getCenterX(), ((RectangularShape) textBounds).getCenterY()).createTransformedShape((Shape) textBounds).getBounds2D();
          double num1 = state.getCursor() + labelInsets.getLeft() + ((RectangularShape) bounds2D).getWidth() / 2.0;
          double num2 = ((RectangularShape) dataArea).getY() + ((RectangularShape) dataArea).getHeight() / 2.0;
          TextUtilities.drawRotatedString(label, g2, (float) num1, (float) num2, TextAnchor.__\u003C\u003ECENTER, this.getLabelAngle() + Math.PI / 2.0, TextAnchor.__\u003C\u003ECENTER);
          state.cursorRight(labelInsets.getLeft() + ((RectangularShape) bounds2D).getWidth() + labelInsets.getRight());
        }
        return state;
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 168, (byte) 98, (byte) 105, (byte) 184, (byte) 105, (byte) 184, (byte) 105, (byte) 184, (byte) 105, (byte) 182, (byte) 108, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawAxisLine(Graphics2D g2, double cursor, Rectangle2D dataArea, RectangleEdge edge)
    {
      Line2D.Double @double = (Line2D.Double) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        @double = new Line2D.Double(((RectangularShape) dataArea).getX(), cursor, ((RectangularShape) dataArea).getMaxX(), cursor);
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        @double = new Line2D.Double(((RectangularShape) dataArea).getX(), cursor, ((RectangularShape) dataArea).getMaxX(), cursor);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        @double = new Line2D.Double(cursor, ((RectangularShape) dataArea).getY(), cursor, ((RectangularShape) dataArea).getMaxY());
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        @double = new Line2D.Double(cursor, ((RectangularShape) dataArea).getY(), cursor, ((RectangularShape) dataArea).getMaxY());
      g2.setPaint(this.axisLinePaint);
      g2.setStroke(this.axisLineStroke);
      g2.draw((Shape) @double);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 200, (byte) 140, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      Axis axis = (Axis) base.clone();
      axis.plot = (Plot) null;
      axis.listenerList = new EventListenerList();
      return (object) axis;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 215, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Axis))
        return false;
      Axis axis = (Axis) obj;
      return this.visible == axis.visible && ObjectUtilities.equal((object) this.label, (object) axis.label) && (ObjectUtilities.equal((object) this.labelFont, (object) axis.labelFont) && PaintUtilities.equal(this.labelPaint, axis.labelPaint)) && (ObjectUtilities.equal((object) this.labelInsets, (object) axis.labelInsets) && this.labelAngle == axis.labelAngle && (this.axisLineVisible == axis.axisLineVisible && ObjectUtilities.equal((object) this.axisLineStroke, (object) axis.axisLineStroke))) && (PaintUtilities.equal(this.axisLinePaint, axis.axisLinePaint) && this.tickLabelsVisible == axis.tickLabelsVisible && (ObjectUtilities.equal((object) this.tickLabelFont, (object) axis.tickLabelFont) && PaintUtilities.equal(this.tickLabelPaint, axis.tickLabelPaint)) && (ObjectUtilities.equal((object) this.tickLabelInsets, (object) axis.tickLabelInsets) && this.tickMarksVisible == axis.tickMarksVisible && ((double) this.tickMarkInsideLength == (double) axis.tickMarkInsideLength && (double) this.tickMarkOutsideLength == (double) axis.tickMarkOutsideLength))) && (PaintUtilities.equal(this.tickMarkPaint, axis.tickMarkPaint) && ObjectUtilities.equal((object) this.tickMarkStroke, (object) axis.tickMarkStroke) && (this.minorTickMarksVisible == axis.minorTickMarksVisible && (double) this.minorTickMarkInsideLength == (double) axis.minorTickMarkInsideLength) && ((double) this.minorTickMarkOutsideLength == (double) axis.minorTickMarkOutsideLength && this.fixedDimension == axis.fixedDimension));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 45, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.labelPaint, obj0);
      SerialUtilities.writePaint(this.tickLabelPaint, obj0);
      SerialUtilities.writeStroke(this.axisLineStroke, obj0);
      SerialUtilities.writePaint(this.axisLinePaint, obj0);
      SerialUtilities.writeStroke(this.tickMarkStroke, obj0);
      SerialUtilities.writePaint(this.tickMarkPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 64, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.tickLabelPaint = SerialUtilities.readPaint(obj0);
      this.axisLineStroke = SerialUtilities.readStroke(obj0);
      this.axisLinePaint = SerialUtilities.readPaint(obj0);
      this.tickMarkStroke = SerialUtilities.readStroke(obj0);
      this.tickMarkPaint = SerialUtilities.readPaint(obj0);
      this.listenerList = new EventListenerList();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Axis.__\u003CcallerID\u003E == null)
        Axis.__\u003CcallerID\u003E = (CallerID) new Axis.__\u003CCallerID\u003E();
      return Axis.__\u003CcallerID\u003E;
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
