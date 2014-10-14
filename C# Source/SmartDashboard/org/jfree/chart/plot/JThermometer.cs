// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.JThermometer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.text;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.title;
using org.jfree.data.general;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class JThermometer : JPanel, Serializable.__Interface
  {
    private const long serialVersionUID = 1079905665515589820L;
    private DefaultValueDataset data;
    private JFreeChart chart;
    private ChartPanel panel;
    private ThermometerPlot plot;

    [HideFromJava]
    static JThermometer()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 237, (byte) 58, (byte) 235, (byte) 71, (byte) 127, (byte) 21, (byte) 107, (byte) 113, (byte) 157, (byte) 118, (byte) 113, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JThermometer()
    {
      base.\u002Ector((LayoutManager) new CardLayout());
      JThermometer jthermometer = this;
      this.plot = new ThermometerPlot();
      this.plot.setInsets(new RectangleInsets(5.0, 5.0, 5.0, 5.0));
      this.data = new DefaultValueDataset();
      this.plot.setDataset((ValueDataset) this.data);
      JFreeChart.__\u003Cclinit\u003E();
      this.chart = new JFreeChart((string) null, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) this.plot, false);
      ChartPanel.__\u003Cclinit\u003E();
      this.panel = new ChartPanel(this.chart);
      ((Container) this).add((Component) this.panel, (object) "Panel");
      this.setBackground(((Component) this).getBackground());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JThermometer([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] JThermometer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 103, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackground(Color bg)
    {
      ((JComponent) this).setBackground(bg);
      if (this.plot != null)
        this.plot.setBackgroundPaint((Paint) bg);
      if (this.chart != null)
        this.chart.setBackgroundPaint((Paint) bg);
      if (this.panel == null)
        return;
      ((JComponent) this.panel).setBackground(bg);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(Number value)
    {
      if (this.data == null)
        return;
      this.data.setValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 187, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getTickLabelFont()
    {
      return this.plot.getRangeAxis().getTickLabelFont();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 108, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFont(Font font)
    {
      this.plot.getRangeAxis().setTickLabelFont(font);
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtitle(Title subtitle)
    {
      this.chart.addSubtitle(subtitle);
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtitle(string subtitle)
    {
      this.chart.addSubtitle((Title) new TextTitle(subtitle));
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtitle(string subtitle, Font font)
    {
      this.chart.addSubtitle((Title) new TextTitle(subtitle, font));
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueFormat(DecimalFormat df)
    {
      this.plot.setValueFormat((NumberFormat) df);
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(double lower, double upper)
    {
      this.plot.setRange(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubrangeInfo(int range, double displayLow, double displayHigh)
    {
      this.plot.setSubrangeInfo(range, displayLow, displayHigh);
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubrangeInfo(int range, double rangeLow, double rangeHigh, double displayLow, double displayHigh)
    {
      this.plot.setSubrangeInfo(range, rangeLow, rangeHigh, displayLow, displayHigh);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueLocation(int loc)
    {
      this.plot.setValueLocation(loc);
      ((Component) this.panel).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValuePaint(Paint paint)
    {
      this.plot.setValuePaint(paint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue()
    {
      if (this.data == null)
        return (Number) null;
      return this.data.getValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value)
    {
      this.setValue((Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUnits(int i)
    {
      if (this.plot == null)
        return;
      this.plot.setUnits(i);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint p)
    {
      if (this.plot == null)
        return;
      this.plot.setOutlinePaint(p);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 103, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setForeground(Color fg)
    {
      ((JComponent) this).setForeground(fg);
      if (this.plot == null)
        return;
      this.plot.setThermometerPaint((Paint) fg);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueFont(Font f)
    {
      if (this.plot == null)
        return;
      this.plot.setValueFont(f);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 207, (byte) 103, (byte) 103, (byte) 122, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void changeTickFontSize(int delta)
    {
      Font tickLabelFont = this.getTickLabelFont();
      string fontName = tickLabelFont.getFontName();
      Font.__\u003Cclinit\u003E();
      this.setTickLabelFont(new Font(fontName, tickLabelFont.getStyle(), tickLabelFont.getSize() + delta));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 103, (byte) 103, (byte) 115, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickFontStyle(int style)
    {
      Font tickLabelFont = this.getTickLabelFont();
      string fontName = tickLabelFont.getFontName();
      Font.__\u003Cclinit\u003E();
      this.setTickLabelFont(new Font(fontName, style, tickLabelFont.getSize()));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFollowDataInSubranges(bool flag)
    {
      this.plot.setFollowDataInSubranges(flag);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 54, (byte) 162, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShowValueLines(bool b)
    {
      this.plot.setShowValueLines(b);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShowAxisLocation(int location)
    {
      this.plot.setAxisLocation(location);
    }

    [LineNumberTable((ushort) 373)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getShowAxisLocation()
    {
      return this.plot.getAxisLocation();
    }
  }
}
