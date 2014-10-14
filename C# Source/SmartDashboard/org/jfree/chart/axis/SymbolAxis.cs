// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.SymbolAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class SymbolAxis : NumberAxis, Serializable.__Interface
  {
    private const long serialVersionUID = 7216330468770619716L;
    internal static Paint __\u003C\u003EDEFAULT_GRID_BAND_PAINT;
    internal static Paint __\u003C\u003EDEFAULT_GRID_BAND_ALTERNATE_PAINT;
    private List symbols;
    private bool gridBandsVisible;
    [NonSerialized]
    private Paint gridBandPaint;
    [NonSerialized]
    private Paint gridBandAlternatePaint;

    [Modifiers]
    public static Paint DEFAULT_GRID_BAND_PAINT
    {
      [HideFromJava] get
      {
        return SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRID_BAND_ALTERNATE_PAINT
    {
      [HideFromJava] get
      {
        return SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_ALTERNATE_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 112, (byte) 69, (byte) 254, (byte) 72})]
    static SymbolAxis()
    {
      NumberAxis.__\u003Cclinit\u003E();
      SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_PAINT = (Paint) new Color(232, 234, 232, 128);
      SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_ALTERNATE_PAINT = (Paint) new Color(0, 0, 0, 0);
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 105, (byte) 108, (byte) 103, (byte) 107, (byte) 107, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolAxis(string label, string[] sv)
      : base(label)
    {
      SymbolAxis symbolAxis = this;
      this.symbols = Arrays.asList((object[]) sv);
      this.gridBandsVisible = true;
      this.gridBandPaint = SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_PAINT;
      this.gridBandAlternatePaint = SymbolAxis.__\u003C\u003EDEFAULT_GRID_BAND_ALTERNATE_PAINT;
      this.setAutoTickUnitSelection(false, false);
      this.setAutoRangeStickyZero(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SymbolAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SymbolAxis obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.gridBandPaint = paint;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.gridBandAlternatePaint = paint;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 103, (byte) 103, (byte) 105, (byte) 142, (byte) 105, (byte) 140, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawGridBands(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, List ticks)
    {
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) dataArea);
      if (RectangleEdge.isTopOrBottom(edge))
        this.drawGridBandsHorizontal(g2, plotArea, dataArea, true, ticks);
      else if (RectangleEdge.isLeftOrRight(edge))
        this.drawGridBandsVertical(g2, plotArea, dataArea, true, ticks);
      ((Graphics) g2).setClip(clip);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 52, (byte) 131, (byte) 98, (byte) 232, (byte) 69, (byte) 109, (byte) 217, (byte) 166, (byte) 169, (byte) 108, (byte) 110, (byte) 159, (byte) 1, (byte) 159, (byte) 1, (byte) 99, (byte) 174, (byte) 140, (byte) 155, (byte) 104, (byte) 141, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawGridBandsHorizontal(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, bool firstGridBandIsDark, List ticks)
    {
      int num1 = firstGridBandIsDark ? 1 : 0;
      double y = ((RectangularShape) dataArea).getY();
      double num2 = this.getPlot().getOutlineStroke() == null ? 1.0 : (double) ((BasicStroke) this.getPlot().getOutlineStroke()).getLineWidth();
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        ValueTick valueTick = (ValueTick) iterator.next();
        double num3 = this.valueToJava2D(valueTick.getValue() - 0.5, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        double num4 = this.valueToJava2D(valueTick.getValue() + 0.5, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        if (num1 != 0)
          g2.setPaint(this.gridBandPaint);
        else
          g2.setPaint(this.gridBandAlternatePaint);
        Rectangle2D.Double @double = new Rectangle2D.Double(num3, y + num2, num4 - num3, ((RectangularShape) dataArea).getMaxY() - y - num2);
        g2.fill((Shape) @double);
        num1 = num1 != 0 ? 0 : 1;
      }
      ((Graphics) g2).setPaintMode();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 38, (byte) 163, (byte) 98, (byte) 232, (byte) 69, (byte) 108, (byte) 107, (byte) 176, (byte) 167, (byte) 169, (byte) 108, (byte) 110, (byte) 159, (byte) 1, (byte) 159, (byte) 1, (byte) 99, (byte) 174, (byte) 140, (byte) 157, (byte) 104, (byte) 141, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawGridBandsVertical(Graphics2D g2, Rectangle2D drawArea, Rectangle2D plotArea, bool firstGridBandIsDark, List ticks)
    {
      int num1 = firstGridBandIsDark ? 1 : 0;
      double x = ((RectangularShape) plotArea).getX();
      Stroke outlineStroke = this.getPlot().getOutlineStroke();
      double num2 = outlineStroke == null || !(outlineStroke is BasicStroke) ? 1.0 : (double) ((BasicStroke) outlineStroke).getLineWidth();
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        ValueTick valueTick = (ValueTick) iterator.next();
        double num3 = this.valueToJava2D(valueTick.getValue() + 0.5, plotArea, RectangleEdge.__\u003C\u003ELEFT);
        double num4 = this.valueToJava2D(valueTick.getValue() - 0.5, plotArea, RectangleEdge.__\u003C\u003ELEFT);
        if (num1 != 0)
          g2.setPaint(this.gridBandPaint);
        else
          g2.setPaint(this.gridBandAlternatePaint);
        Rectangle2D.Double @double = new Rectangle2D.Double(x + num2, num3, ((RectangularShape) plotArea).getMaxX() - x - num2, num4 - num3);
        g2.fill((Shape) @double);
        num1 = num1 != 0 ? 0 : 1;
      }
      ((Graphics) g2).setPaintMode();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 200, (byte) 134, (byte) 103, (byte) 135, (byte) 109, (byte) 103, (byte) 137, (byte) 103, (byte) 135, (byte) 107, (byte) 107, (byte) 107, (byte) 141, (byte) 104, (byte) 100, (byte) 173, (byte) 202, (byte) 144, (byte) 155, (byte) 99, (byte) 101, (byte) 146, (byte) 142, (byte) 163, (byte) 100, (byte) 201, (byte) 100, (byte) 164, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 167, (byte) 150, (byte) 233, (byte) 4, (byte) 235, (byte) 127})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      double size = this.getTickUnit().getSize();
      int num1 = this.calculateVisibleTickCount();
      double num2 = this.calculateLowestVisibleTickValue();
      double num3 = 0.0;
      double num4 = 0.0;
      if (num1 <= 500)
      {
        for (int index = 0; index < num1; ++index)
        {
          double num5 = num2 + (double) index * size;
          double num6 = this.valueToJava2D(num5, dataArea, edge);
          NumberFormat numberFormatOverride = this.getNumberFormatOverride();
          string str = numberFormatOverride == null ? this.valueToString(num5) : numberFormatOverride.format(num5);
          Rectangle2D textBounds = TextUtilities.getTextBounds(str, g2, ((Graphics) g2).getFontMetrics());
          double num7 = !this.isVerticalTickLabels() ? ((RectangularShape) textBounds).getWidth() : ((RectangularShape) textBounds).getHeight();
          int num8 = 0;
          if (index > 0)
          {
            double num9 = (num4 + num7) / 2.0;
            if (Math.abs(num6 - num3) < num9)
              num8 = 1;
          }
          if (num8 != 0)
          {
            str = "";
          }
          else
          {
            num3 = num6;
            num4 = num7;
          }
          double angle = 0.0;
          TextAnchor textAnchor;
          TextAnchor rotationAnchor;
          if (this.isVerticalTickLabels())
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            angle = edge != RectangleEdge.__\u003C\u003ETOP ? -1.0 * Math.PI / 2.0 : Math.PI / 2.0;
          }
          else if (edge == RectangleEdge.__\u003C\u003ETOP)
          {
            textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
          }
          else
          {
            textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
          }
          NumberTick numberTick = new NumberTick((Number) new Double(num5), str, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) numberTick);
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 38, (byte) 134, (byte) 103, (byte) 135, (byte) 109, (byte) 103, (byte) 137, (byte) 103, (byte) 135, (byte) 107, (byte) 107, (byte) 107, (byte) 141, (byte) 104, (byte) 100, (byte) 173, (byte) 202, (byte) 144, (byte) 155, (byte) 99, (byte) 101, (byte) 146, (byte) 142, (byte) 163, (byte) 100, (byte) 201, (byte) 100, (byte) 164, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 167, (byte) 150, (byte) 233, (byte) 4, (byte) 235, (byte) 127})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List refreshTicksVertical(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      double size = this.getTickUnit().getSize();
      int num1 = this.calculateVisibleTickCount();
      double num2 = this.calculateLowestVisibleTickValue();
      double num3 = 0.0;
      double num4 = 0.0;
      if (num1 <= 500)
      {
        for (int index = 0; index < num1; ++index)
        {
          double num5 = num2 + (double) index * size;
          double num6 = this.valueToJava2D(num5, dataArea, edge);
          NumberFormat numberFormatOverride = this.getNumberFormatOverride();
          string str = numberFormatOverride == null ? this.valueToString(num5) : numberFormatOverride.format(num5);
          Rectangle2D textBounds = TextUtilities.getTextBounds(str, g2, ((Graphics) g2).getFontMetrics());
          double num7 = !this.isVerticalTickLabels() ? ((RectangularShape) textBounds).getHeight() : ((RectangularShape) textBounds).getWidth();
          int num8 = 0;
          if (index > 0)
          {
            double num9 = (num4 + num7) / 2.0;
            if (Math.abs(num6 - num3) < num9)
              num8 = 1;
          }
          if (num8 != 0)
          {
            str = "";
          }
          else
          {
            num3 = num6;
            num4 = num7;
          }
          double angle = 0.0;
          TextAnchor textAnchor;
          TextAnchor rotationAnchor;
          if (this.isVerticalTickLabels())
          {
            textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            angle = edge != RectangleEdge.__\u003C\u003ELEFT ? Math.PI / 2.0 : -1.0 * Math.PI / 2.0;
          }
          else if (edge == RectangleEdge.__\u003C\u003ELEFT)
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
          }
          else
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
          }
          NumberTick numberTick = new NumberTick((Number) new Double(num5), str, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) numberTick);
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 128, (byte) 223, (byte) 14, (byte) 2, (byte) 97, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string valueToString(double value)
    {
      string str;
      try
      {
        str = (string) this.symbols.get(ByteCodeHelper.d2i(value));
        goto label_4;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<IndexOutOfBoundsException>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      str = "";
label_4:
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 113, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string[] getSymbols()
    {
      return (string[]) this.symbols.toArray((object[]) new string[this.symbols.size()]);
    }

    public virtual bool isGridBandsVisible()
    {
      return this.gridBandsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 162, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGridBandsVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.gridBandsVisible ? 1 : 0) == num)
        return;
      this.gridBandsVisible = num != 0;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual Paint getGridBandPaint()
    {
      return this.gridBandPaint;
    }

    public virtual Paint getGridBandAlternatePaint()
    {
      return this.gridBandAlternatePaint;
    }

    [LineNumberTable((ushort) 275)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void selectAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 187, (byte) 104, (byte) 104, (byte) 145, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      AxisState axisState = new AxisState(cursor);
      if (this.isVisible())
        axisState = base.draw(g2, cursor, plotArea, dataArea, edge, plotState);
      if (this.gridBandsVisible)
        this.drawGridBands(g2, plotArea, dataArea, edge, axisState.getTicks());
      return axisState;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 91, (byte) 103, (byte) 99, (byte) 161, (byte) 171, (byte) 111, (byte) 102, (byte) 165, (byte) 105, (byte) 101, (byte) 114, (byte) 210, (byte) 107, (byte) 139, (byte) 107, (byte) 104, (byte) 104, (byte) 168, (byte) 134, (byte) 104, (byte) 171, (byte) 203, (byte) 112, (byte) 213, (byte) 104, (byte) 104, (byte) 178, (byte) 136, (byte) 104, (byte) 178, (byte) 200, (byte) 102, (byte) 198, (byte) 209})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      double num1 = (double) (this.symbols.size() - 1);
      double num2 = 0.0;
      double num3 = num1 - num2;
      double rangeMinimumSize = this.getAutoRangeMinimumSize();
      if (num3 < rangeMinimumSize)
      {
        num1 = (num1 + num2 + rangeMinimumSize) / 2.0;
        num2 = (num1 + num2 - rangeMinimumSize) / 2.0;
      }
      double num4 = 0.5;
      double num5 = 0.5;
      double upper;
      double lower;
      if (this.getAutoRangeIncludesZero())
      {
        if (this.getAutoRangeStickyZero())
        {
          upper = num1 > 0.0 ? num1 + num4 : 0.0;
          lower = num2 < 0.0 ? num2 - num5 : 0.0;
        }
        else
        {
          upper = Math.max(0.0, num1 + num4);
          lower = Math.min(0.0, num2 - num5);
        }
      }
      else if (this.getAutoRangeStickyZero())
      {
        upper = num1 > 0.0 ? num1 + num4 * num3 : Math.min(0.0, num1 + num4);
        lower = num2 < 0.0 ? num2 - num5 : Math.max(0.0, num2 - num5);
      }
      else
      {
        upper = num1 + num4;
        lower = num2 - num5;
      }
      this.setRange(new Range(lower, upper), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 98, (byte) 105, (byte) 141, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List refreshTicks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      List list = (List) null;
      if (RectangleEdge.isTopOrBottom(edge))
        list = this.refreshTicksHorizontal(g2, dataArea, edge);
      else if (RectangleEdge.isLeftOrRight(edge))
        list = this.refreshTicksVertical(g2, dataArea, edge);
      return list;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 144, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SymbolAxis))
        return false;
      SymbolAxis symbolAxis = (SymbolAxis) obj;
      if (!Object.instancehelper_equals((object) this.symbols, (object) symbolAxis.symbols) || this.gridBandsVisible != symbolAxis.gridBandsVisible || (!PaintUtilities.equal(this.gridBandPaint, symbolAxis.gridBandPaint) || !PaintUtilities.equal(this.gridBandAlternatePaint, symbolAxis.gridBandAlternatePaint)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 175, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.gridBandPaint, obj0);
      SerialUtilities.writePaint(this.gridBandAlternatePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 190, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.gridBandPaint = SerialUtilities.readPaint(obj0);
      this.gridBandAlternatePaint = SerialUtilities.readPaint(obj0);
    }
  }
}
