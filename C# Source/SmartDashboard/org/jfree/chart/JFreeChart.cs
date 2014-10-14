// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.JFreeChart
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
using javax.swing;
using javax.swing.@event;
using org.jfree.chart.@event;
using org.jfree.chart.block;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.chart.title;
using org.jfree.data;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.ui.about;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"org.jfree.ui.Drawable", "org.jfree.chart.event.TitleChangeListener", "org.jfree.chart.event.PlotChangeListener", "java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public class JFreeChart : Object, Drawable, TitleChangeListener, EventListener, PlotChangeListener, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    internal static ProjectInfo __\u003C\u003EINFO = (ProjectInfo) new JFreeChartInfo();
    internal static Font __\u003C\u003EDEFAULT_TITLE_FONT = new Font("SansSerif", 1, 18);
    internal static Paint __\u003C\u003EDEFAULT_BACKGROUND_PAINT = (Paint) UIManager.getColor((object) "Panel.background");
    internal static Image __\u003C\u003EDEFAULT_BACKGROUND_IMAGE = (Image) null;
    private const long serialVersionUID = -3470703747817429120L;
    public const int DEFAULT_BACKGROUND_IMAGE_ALIGNMENT = 15;
    public const float DEFAULT_BACKGROUND_IMAGE_ALPHA = 0.5f;
    [NonSerialized]
    private RenderingHints renderingHints;
    private bool borderVisible;
    [NonSerialized]
    private Stroke borderStroke;
    [NonSerialized]
    private Paint borderPaint;
    private RectangleInsets padding;
    private TextTitle title;
    private List subtitles;
    private Plot plot;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Image backgroundImage;
    private int backgroundImageAlignment;
    private float backgroundImageAlpha;
    [NonSerialized]
    private EventListenerList changeListeners;
    [NonSerialized]
    private EventListenerList progressListeners;
    private bool notify;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static ProjectInfo INFO
    {
      [HideFromJava] get
      {
        return JFreeChart.__\u003C\u003EINFO;
      }
    }

    [Modifiers]
    public static Font DEFAULT_TITLE_FONT
    {
      [HideFromJava] get
      {
        return JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_BACKGROUND_PAINT
    {
      [HideFromJava] get
      {
        return JFreeChart.__\u003C\u003EDEFAULT_BACKGROUND_PAINT;
      }
    }

    [Modifiers]
    public static Image DEFAULT_BACKGROUND_IMAGE
    {
      [HideFromJava] get
      {
        return JFreeChart.__\u003C\u003EDEFAULT_BACKGROUND_IMAGE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 170, (byte) 210, (byte) 207})]
    static JFreeChart()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 48, (byte) 67, (byte) 232, (byte) 159, (byte) 190, (byte) 168, (byte) 235, (byte) 160, (byte) 65, (byte) 99, (byte) 208, (byte) 107, (byte) 107, (byte) 167, (byte) 218, (byte) 103, (byte) 112, (byte) 139, (byte) 139, (byte) 103, (byte) 135, (byte) 171, (byte) 99, (byte) 113, (byte) 127, (byte) 0, (byte) 107, (byte) 107, (byte) 107, (byte) 109, (byte) 199, (byte) 99, (byte) 99, (byte) 135, (byte) 109, (byte) 172, (byte) 139, (byte) 107, (byte) 104, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JFreeChart(string title, Font titleFont, Plot plot, bool createLegend)
    {
      int num = createLegend ? 1 : 0;
      base.\u002Ector();
      JFreeChart jfreeChart = this;
      this.backgroundImageAlignment = 15;
      this.backgroundImageAlpha = 0.5f;
      if (plot == null)
      {
        string str = "Null 'plot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.progressListeners = new EventListenerList();
        this.changeListeners = new EventListenerList();
        this.notify = true;
        RenderingHints.__\u003Cclinit\u003E();
        this.renderingHints = new RenderingHints((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_ON);
        this.borderVisible = false;
        this.borderStroke = (Stroke) new BasicStroke(1f);
        this.borderPaint = (Paint) Color.black;
        this.padding = RectangleInsets.__\u003C\u003EZERO_INSETS;
        this.plot = plot;
        plot.addChangeListener((PlotChangeListener) this);
        this.subtitles = (List) new ArrayList();
        if (num != 0)
        {
          LegendTitle.__\u003Cclinit\u003E();
          LegendTitle legendTitle = new LegendTitle((LegendItemSource) this.plot);
          legendTitle.setMargin(new RectangleInsets(1.0, 1.0, 1.0, 1.0));
          legendTitle.setFrame((BlockFrame) new LineBorder());
          legendTitle.setBackgroundPaint((Paint) Color.white);
          legendTitle.setPosition(RectangleEdge.__\u003C\u003EBOTTOM);
          this.subtitles.add((object) legendTitle);
          legendTitle.addChangeListener((TitleChangeListener) this);
        }
        if (title != null)
        {
          if (titleFont == null)
            titleFont = JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT;
          this.title = new TextTitle(title, titleFont);
          this.title.addChangeListener((TitleChangeListener) this);
        }
        this.backgroundPaint = JFreeChart.__\u003C\u003EDEFAULT_BACKGROUND_PAINT;
        this.backgroundImage = JFreeChart.__\u003C\u003EDEFAULT_BACKGROUND_IMAGE;
        this.backgroundImageAlignment = 15;
        this.backgroundImageAlpha = 0.5f;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JFreeChart(Plot plot)
      : this((string) null, (Font) null, plot, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JFreeChart(string title, Plot plot)
      : this(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, plot, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JFreeChart([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] JFreeChart obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] JFreeChart obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 126, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtitle(Title subtitle)
    {
      if (subtitle == null)
      {
        string str = "Null 'subtitle' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subtitles.add((object) subtitle);
        subtitle.addChangeListener((TitleChangeListener) this);
        this.fireChartChanged();
      }
    }

    public virtual Plot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 213, (byte) 104, (byte) 140, (byte) 103, (byte) 99, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTitle(TextTitle title)
    {
      if (this.title != null)
        this.title.removeChangeListener((TitleChangeListener) this);
      this.title = title;
      if (title != null)
        title.addChangeListener((TitleChangeListener) this);
      this.fireChartChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 50, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeLegend()
    {
      this.removeSubtitle((Title) this.getLegend());
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 89, (byte) 104, (byte) 110, (byte) 103, (byte) 200, (byte) 99, (byte) 103, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      if (this.backgroundPaint != null)
      {
        if (Object.instancehelper_equals((object) this.backgroundPaint, (object) paint))
          return;
        this.backgroundPaint = paint;
        this.fireChartChanged();
      }
      else
      {
        if (paint == null)
          return;
        this.backgroundPaint = paint;
        this.fireChartChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 96, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(ChartChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.changeListeners.remove(JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 150, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeProgressListener(ChartProgressListener listener)
    {
      this.progressListeners.remove(JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartProgressListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 82, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(ChartChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.changeListeners.add(JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 139, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addProgressListener(ChartProgressListener listener)
    {
      this.progressListeners.add(JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartProgressListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 10, (byte) 175, (byte) 130, (byte) 100, (byte) 103, (byte) 104, (byte) 136, (byte) 99, (byte) 247, (byte) 69, (byte) 103, (byte) 135, (byte) 172, (byte) 104, (byte) 108, (byte) 167, (byte) 107, (byte) 103, (byte) 146, (byte) 191, (byte) 11, (byte) 109, (byte) 191, (byte) 27, (byte) 167, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 223, (byte) 12, (byte) 104, (byte) 104, (byte) 232, (byte) 69, (byte) 103, (byte) 104, (byte) 141, (byte) 104, (byte) 152, (byte) 100, (byte) 200, (byte) 109, (byte) 105, (byte) 110, (byte) 105, (byte) 148, (byte) 100, (byte) 168, (byte) 130, (byte) 164, (byte) 99, (byte) 100, (byte) 137, (byte) 146, (byte) 135, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D chartArea, Point2D anchor, ChartRenderingInfo info)
    {
      this.notifyListeners(new ChartProgressEvent((object) this, this, 1, 0));
      EntityCollection entityCollection = (EntityCollection) null;
      if (info != null)
      {
        info.clear();
        info.setChartArea(chartArea);
        entityCollection = info.getEntityCollection();
      }
      if (entityCollection != null)
        entityCollection.add((ChartEntity) new JFreeChartEntity((Shape) ((RectangularShape) chartArea).clone(), this));
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) chartArea);
      g2.addRenderingHints((Map) this.renderingHints);
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) chartArea);
      }
      if (this.backgroundImage != null)
      {
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, this.backgroundImageAlpha));
        Rectangle2D.Double @double = new Rectangle2D.Double(0.0, 0.0, (double) this.backgroundImage.getWidth((ImageObserver) null), (double) this.backgroundImage.getHeight((ImageObserver) null));
        Align.align((Rectangle2D) @double, chartArea, this.backgroundImageAlignment);
        ((Graphics) g2).drawImage(this.backgroundImage, ByteCodeHelper.d2i(((RectangularShape) @double).getX()), ByteCodeHelper.d2i(((RectangularShape) @double).getY()), ByteCodeHelper.d2i(((RectangularShape) @double).getWidth()), ByteCodeHelper.d2i(((RectangularShape) @double).getHeight()), (ImageObserver) null);
        g2.setComposite(composite);
      }
      if (this.isBorderVisible())
      {
        Paint borderPaint = this.getBorderPaint();
        Stroke borderStroke = this.getBorderStroke();
        if (borderPaint != null && borderStroke != null)
        {
          Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) chartArea).getX(), ((RectangularShape) chartArea).getY(), ((RectangularShape) chartArea).getWidth() - 1.0, ((RectangularShape) chartArea).getHeight() - 1.0);
          g2.setPaint(borderPaint);
          g2.setStroke(borderStroke);
          g2.draw((Shape) @double);
        }
      }
      Rectangle2D.Double double1 = new Rectangle2D.Double();
      ((Rectangle2D) double1).setRect(chartArea);
      this.padding.trim((Rectangle2D) double1);
      if (this.title != null)
      {
        EntityCollection ec = this.drawTitle((Title) this.title, g2, (Rectangle2D) double1, entityCollection != null);
        if (ec != null)
          entityCollection.addAll(ec);
      }
      Iterator iterator = this.subtitles.iterator();
      while (iterator.hasNext())
      {
        Title t = (Title) iterator.next();
        if (t.isVisible())
        {
          EntityCollection ec = this.drawTitle(t, g2, (Rectangle2D) double1, entityCollection != null);
          if (ec != null)
            entityCollection.addAll(ec);
        }
      }
      Rectangle2D.Double double2 = double1;
      PlotRenderingInfo pri = (PlotRenderingInfo) null;
      if (info != null)
        pri = info.getPlotInfo();
      this.plot.draw(g2, (Rectangle2D) double2, anchor, (PlotState) null, pri);
      ((Graphics) g2).setClip(clip);
      this.notifyListeners(new ChartProgressEvent((object) this, this, 2, 100));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 123, (byte) 66, (byte) 135, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNotify(bool notify)
    {
      int num = notify ? 1 : 0;
      this.notify = num != 0;
      if (num == 0)
        return;
      this.notifyListeners(new ChartChangeEvent((object) this));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 59, (byte) 140, (byte) 246, (byte) 69, (byte) 104, (byte) 118, (byte) 172, (byte) 107, (byte) 107, (byte) 114, (byte) 109, (byte) 231, (byte) 61, (byte) 230, (byte) 70, (byte) 104, (byte) 118, (byte) 172, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      JFreeChart jfreeChart = (JFreeChart) base.clone();
      jfreeChart.renderingHints = (RenderingHints) this.renderingHints.clone();
      if (this.title != null)
      {
        jfreeChart.title = (TextTitle) this.title.clone();
        jfreeChart.title.addChangeListener((TitleChangeListener) jfreeChart);
      }
      jfreeChart.subtitles = (List) new ArrayList();
      for (int index = 0; index < this.getSubtitleCount(); ++index)
      {
        Title title = (Title) this.getSubtitle(index).clone();
        jfreeChart.subtitles.add((object) title);
        title.addChangeListener((TitleChangeListener) jfreeChart);
      }
      if (this.plot != null)
      {
        jfreeChart.plot = (Plot) this.plot.clone();
        jfreeChart.plot.addChangeListener((PlotChangeListener) jfreeChart);
      }
      jfreeChart.progressListeners = new EventListenerList();
      jfreeChart.changeListeners = new EventListenerList();
      return (object) jfreeChart;
    }

    [LineNumberTable((ushort) 1374)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage createBufferedImage(int width, int height)
    {
      return this.createBufferedImage(width, height, (ChartRenderingInfo) null);
    }

    [LineNumberTable((ushort) 1389)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage createBufferedImage(int width, int height, ChartRenderingInfo info)
    {
      return this.createBufferedImage(width, height, 2, info);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 13, (byte) 105, (byte) 103, (byte) 125, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage createBufferedImage(int width, int height, int imageType, ChartRenderingInfo info)
    {
      BufferedImage bufferedImage = new BufferedImage(width, height, imageType);
      Graphics2D graphics = bufferedImage.createGraphics();
      this.draw(graphics, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, (double) width, (double) height), (Point2D) null, info);
      ((Graphics) graphics).dispose();
      return bufferedImage;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 108, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireChartChanged()
    {
      this.notifyListeners(new ChartChangeEvent((object) this));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 119, (byte) 104, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(ChartChangeEvent @event)
    {
      if (!this.notify)
        return;
      object[] listenerList = this.changeListeners.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartChangeListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartChangeListener"))))
          ((ChartChangeListener) listenerList[index + 1]).chartChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 27, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 100, (byte) 167, (byte) 164, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendTitle getLegend(int index)
    {
      int num = 0;
      Iterator iterator = this.subtitles.iterator();
      while (iterator.hasNext())
      {
        Title title = (Title) iterator.next();
        if (title is LegendTitle)
        {
          if (num == index)
            return (LegendTitle) title;
          ++num;
        }
      }
      return (LegendTitle) null;
    }

    [LineNumberTable((ushort) 640)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendTitle getLegend()
    {
      return this.getLegend(0);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 181, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSubtitle(Title title)
    {
      this.subtitles.remove((object) title);
      this.fireChartChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 163, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearSubtitles()
    {
      Iterator iterator = this.subtitles.iterator();
      while (iterator.hasNext())
        ((Title) iterator.next()).removeChangeListener((TitleChangeListener) this);
      this.subtitles.clear();
      this.fireChartChanged();
    }

    [LineNumberTable((ushort) 724)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubtitleCount()
    {
      return this.subtitles.size();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 64, (byte) 114, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTextAntiAlias(object val)
    {
      this.renderingHints.put((object) RenderingHints.KEY_TEXT_ANTIALIASING, val);
      this.notifyListeners(new ChartChangeEvent((object) this));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 161, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(ChartProgressEvent @event)
    {
      object[] listenerList = this.progressListeners.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener != null ? JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener : (JFreeChart.class\u0024org\u0024jfree\u0024chart\u0024event\u0024ChartProgressListener = JFreeChart.class\u0024("org.jfree.chart.event.ChartProgressListener"))))
          ((ChartProgressListener) listenerList[index + 1]).chartProgress(@event);
        index += -2;
      }
    }

    public virtual bool isBorderVisible()
    {
      return this.borderVisible;
    }

    public virtual Paint getBorderPaint()
    {
      return this.borderPaint;
    }

    public virtual Stroke getBorderStroke()
    {
      return this.borderStroke;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 74, (byte) 131, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 130, (byte) 104, (byte) 104, (byte) 130, (byte) 191, (byte) 15, (byte) 98, (byte) 103, (byte) 104, (byte) 107, (byte) 107, (byte) 150, (byte) 109, (byte) 191, (byte) 36, (byte) 101, (byte) 104, (byte) 107, (byte) 150, (byte) 109, (byte) 159, (byte) 7, (byte) 101, (byte) 104, (byte) 107, (byte) 150, (byte) 109, (byte) 159, (byte) 7, (byte) 133, (byte) 104, (byte) 107, (byte) 150, (byte) 109, (byte) 159, (byte) 15, (byte) 130, (byte) 144, (byte) 99, (byte) 105, (byte) 105, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual EntityCollection drawTitle(Title t, Graphics2D g2, Rectangle2D area, bool entities)
    {
      int num = entities ? 1 : 0;
      if (t == null)
      {
        string str = "Null 't' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (area == null)
      {
        string str = "Null 'area' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Rectangle2D.Double @double = new Rectangle2D.Double();
        RectangleEdge position = t.getPosition();
        double width = ((RectangularShape) area).getWidth();
        if (width <= 0.0)
          return (EntityCollection) null;
        double height = ((RectangularShape) area).getHeight();
        if (height <= 0.0)
          return (EntityCollection) null;
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint constraint = new RectangleConstraint(width, new Range(0.0, width), LengthConstraintType.__\u003C\u003ERANGE, height, new Range(0.0, height), LengthConstraintType.__\u003C\u003ERANGE);
        BlockParams blockParams = new BlockParams();
        blockParams.setGenerateEntities(num != 0);
        object obj;
        if (position == RectangleEdge.__\u003C\u003ETOP)
        {
          Size2D size2D = t.arrange(g2, constraint);
          Rectangle2D alignedRectangle2D = this.createAlignedRectangle2D(size2D, area, t.getHorizontalAlignment(), VerticalAlignment.__\u003C\u003ETOP);
          obj = t.draw(g2, alignedRectangle2D, (object) blockParams);
          area.setRect(((RectangularShape) area).getX(), Math.min(((RectangularShape) area).getY() + size2D.height, ((RectangularShape) area).getMaxY()), ((RectangularShape) area).getWidth(), Math.max(((RectangularShape) area).getHeight() - size2D.height, 0.0));
        }
        else if (position == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          Size2D size2D = t.arrange(g2, constraint);
          Rectangle2D alignedRectangle2D = this.createAlignedRectangle2D(size2D, area, t.getHorizontalAlignment(), VerticalAlignment.__\u003C\u003EBOTTOM);
          obj = t.draw(g2, alignedRectangle2D, (object) blockParams);
          area.setRect(((RectangularShape) area).getX(), ((RectangularShape) area).getY(), ((RectangularShape) area).getWidth(), ((RectangularShape) area).getHeight() - size2D.height);
        }
        else if (position == RectangleEdge.__\u003C\u003ERIGHT)
        {
          Size2D size2D = t.arrange(g2, constraint);
          Rectangle2D alignedRectangle2D = this.createAlignedRectangle2D(size2D, area, HorizontalAlignment.__\u003C\u003ERIGHT, t.getVerticalAlignment());
          obj = t.draw(g2, alignedRectangle2D, (object) blockParams);
          area.setRect(((RectangularShape) area).getX(), ((RectangularShape) area).getY(), ((RectangularShape) area).getWidth() - size2D.width, ((RectangularShape) area).getHeight());
        }
        else if (position == RectangleEdge.__\u003C\u003ELEFT)
        {
          Size2D size2D = t.arrange(g2, constraint);
          Rectangle2D alignedRectangle2D = this.createAlignedRectangle2D(size2D, area, HorizontalAlignment.__\u003C\u003ELEFT, t.getVerticalAlignment());
          obj = t.draw(g2, alignedRectangle2D, (object) blockParams);
          area.setRect(((RectangularShape) area).getX() + size2D.width, ((RectangularShape) area).getY(), ((RectangularShape) area).getWidth() - size2D.width, ((RectangularShape) area).getHeight());
        }
        else
        {
          string str = "Unrecognised title position.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        EntityCollection entityCollection = (EntityCollection) null;
        if (obj is EntityBlockResult)
          entityCollection = ((EntityBlockResult) obj).getEntityCollection();
        return entityCollection;
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 118, (byte) 106, (byte) 106, (byte) 104, (byte) 138, (byte) 104, (byte) 155, (byte) 104, (byte) 143, (byte) 105, (byte) 138, (byte) 105, (byte) 155, (byte) 105, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rectangle2D createAlignedRectangle2D([In] Size2D obj0, [In] Rectangle2D obj1, [In] HorizontalAlignment obj2, [In] VerticalAlignment obj3)
    {
      double num1 = double.NaN;
      double num2 = double.NaN;
      if (obj2 == HorizontalAlignment.__\u003C\u003ELEFT)
        num1 = ((RectangularShape) obj1).getX();
      else if (obj2 == HorizontalAlignment.__\u003C\u003ECENTER)
        num1 = ((RectangularShape) obj1).getCenterX() - obj0.width / 2.0;
      else if (obj2 == HorizontalAlignment.__\u003C\u003ERIGHT)
        num1 = ((RectangularShape) obj1).getMaxX() - obj0.width;
      if (obj3 == VerticalAlignment.__\u003C\u003ETOP)
        num2 = ((RectangularShape) obj1).getY();
      else if (obj3 == VerticalAlignment.__\u003C\u003ECENTER)
        num2 = ((RectangularShape) obj1).getCenterY() - obj0.height / 2.0;
      else if (obj3 == VerticalAlignment.__\u003C\u003EBOTTOM)
        num2 = ((RectangularShape) obj1).getMaxY() - obj0.height;
      return (Rectangle2D) new Rectangle2D.Double(num1, num2, obj0.width, obj0.height);
    }

    [LineNumberTable((ushort) 1479)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, JFreeChart.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 111, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Title getSubtitle(int index)
    {
      if (index >= 0 && index < this.getSubtitleCount())
        return (Title) this.subtitles.get(index);
      string str = "Index out of range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    public virtual RenderingHints getRenderingHints()
    {
      return this.renderingHints;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 83, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderingHints(RenderingHints renderingHints)
    {
      if (renderingHints == null)
      {
        string str = "RenderingHints given are null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.renderingHints = renderingHints;
        this.fireChartChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 22, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBorderVisible(bool visible)
    {
      this.borderVisible = visible;
      this.fireChartChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 134, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBorderStroke(Stroke stroke)
    {
      this.borderStroke = stroke;
      this.fireChartChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 157, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBorderPaint(Paint paint)
    {
      this.borderPaint = paint;
      this.fireChartChanged();
    }

    public virtual RectangleInsets getPadding()
    {
      return this.padding;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 181, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.padding = padding;
        this.notifyListeners(new ChartChangeEvent((object) this));
      }
    }

    public virtual TextTitle getTitle()
    {
      return this.title;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 236, (byte) 99, (byte) 104, (byte) 184, (byte) 206, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTitle(string text)
    {
      if (text != null)
      {
        if (this.title == null)
        {
          TextTitle.__\u003Cclinit\u003E();
          this.setTitle(new TextTitle(text, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT));
        }
        else
          this.title.setText(text);
      }
      else
        this.setTitle((TextTitle) null);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLegend(LegendTitle legend)
    {
      this.addSubtitle((Title) legend);
    }

    [LineNumberTable((ushort) 687)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSubtitles()
    {
      return (List) new ArrayList((Collection) this.subtitles);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 75, (byte) 99, (byte) 144, (byte) 103, (byte) 102, (byte) 103, (byte) 104, (byte) 108, (byte) 99, (byte) 135, (byte) 98, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubtitles(List subtitles)
    {
      if (subtitles == null)
      {
        string str = "Null 'subtitles' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.setNotify(false);
        this.clearSubtitles();
        Iterator iterator = subtitles.iterator();
        while (iterator.hasNext())
        {
          Title subtitle = (Title) iterator.next();
          if (subtitle != null)
            this.addSubtitle(subtitle);
        }
        this.setNotify(true);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 144, (byte) 109, (byte) 176, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubtitle(int index, Title subtitle)
    {
      if (index < 0 || index > this.getSubtitleCount())
      {
        string str = "The 'index' argument is out of range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (subtitle == null)
      {
        string str = "Null 'subtitle' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subtitles.add(index, (object) subtitle);
        subtitle.addChangeListener((TitleChangeListener) this);
        this.fireChartChanged();
      }
    }

    [LineNumberTable((ushort) 833)]
    public virtual CategoryPlot getCategoryPlot()
    {
      return (CategoryPlot) this.plot;
    }

    [LineNumberTable((ushort) 847)]
    public virtual XYPlot getXYPlot()
    {
      return (XYPlot) this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 233, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getAntiAlias()
    {
      object obj = this.renderingHints.get((object) RenderingHints.KEY_ANTIALIASING);
      return (Object.instancehelper_equals((object) RenderingHints.VALUE_ANTIALIAS_ON, obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 180, (byte) 162, (byte) 113, (byte) 99, (byte) 134, (byte) 191, (byte) 1, (byte) 129, (byte) 99, (byte) 216, (byte) 182, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAntiAlias(bool flag)
    {
      int num = flag ? 1 : 0;
      object obj = this.renderingHints.get((object) RenderingHints.KEY_ANTIALIASING) ?? (object) RenderingHints.VALUE_ANTIALIAS_DEFAULT;
      if (num == 0 && Object.instancehelper_equals((object) RenderingHints.VALUE_ANTIALIAS_OFF, obj) || num != 0 && Object.instancehelper_equals((object) RenderingHints.VALUE_ANTIALIAS_ON, obj))
        return;
      if (num != 0)
        this.renderingHints.put((object) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_ON);
      else
        this.renderingHints.put((object) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_OFF);
      this.fireChartChanged();
    }

    [LineNumberTable((ushort) 907)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getTextAntiAlias()
    {
      return this.renderingHints.get((object) RenderingHints.KEY_TEXT_ANTIALIASING);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 167, (byte) 98, (byte) 99, (byte) 173, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTextAntiAlias(bool flag)
    {
      if (flag)
        this.setTextAntiAlias((object) RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
      else
        this.setTextAntiAlias((object) RenderingHints.VALUE_TEXT_ANTIALIAS_OFF);
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    public virtual Image getBackgroundImage()
    {
      return this.backgroundImage;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 126, (byte) 104, (byte) 110, (byte) 103, (byte) 200, (byte) 99, (byte) 103, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImage(Image image)
    {
      if (this.backgroundImage != null)
      {
        if (Object.instancehelper_equals((object) this.backgroundImage, (object) image))
          return;
        this.backgroundImage = image;
        this.fireChartChanged();
      }
      else
      {
        if (image == null)
          return;
        this.backgroundImage = image;
        this.fireChartChanged();
      }
    }

    public virtual int getBackgroundImageAlignment()
    {
      return this.backgroundImageAlignment;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 163, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImageAlignment(int alignment)
    {
      if (this.backgroundImageAlignment == alignment)
        return;
      this.backgroundImageAlignment = alignment;
      this.fireChartChanged();
    }

    public virtual float getBackgroundImageAlpha()
    {
      return this.backgroundImageAlpha;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 190, (byte) 106, (byte) 104, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundImageAlpha(float alpha)
    {
      if ((double) this.backgroundImageAlpha == (double) alpha)
        return;
      this.backgroundImageAlpha = alpha;
      this.fireChartChanged();
    }

    public virtual bool isNotify()
    {
      return this.notify;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 235, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (Point2D) null, (ChartRenderingInfo) null);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 247, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area, ChartRenderingInfo info)
    {
      this.draw(g2, area, (Point2D) null, info);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 40, (byte) 137, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 104, (byte) 158, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage createBufferedImage(int imageWidth, int imageHeight, double drawWidth, double drawHeight, ChartRenderingInfo info)
    {
      BufferedImage bufferedImage = new BufferedImage(imageWidth, imageHeight, 2);
      Graphics2D graphics = bufferedImage.createGraphics();
      AffineTransform scaleInstance = AffineTransform.getScaleInstance((double) imageWidth / drawWidth, (double) imageHeight / drawHeight);
      graphics.transform(scaleInstance);
      this.draw(graphics, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, drawWidth, drawHeight), (Point2D) null, info);
      ((Graphics) graphics).dispose();
      return bufferedImage;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 70, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void handleClick(int x, int y, ChartRenderingInfo info)
    {
      this.plot.handleClick(x, y, info.getPlotInfo());
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 177, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void titleChanged(TitleChangeEvent @event)
    {
      @event.setChart(this);
      this.notifyListeners((ChartChangeEvent) @event);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 188, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void plotChanged(PlotChangeEvent @event)
    {
      @event.setChart(this);
      this.notifyListeners((ChartChangeEvent) @event);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 200, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is JFreeChart))
        return false;
      JFreeChart jfreeChart = (JFreeChart) obj;
      return this.renderingHints.equals((object) jfreeChart.renderingHints) && this.borderVisible == jfreeChart.borderVisible && (ObjectUtilities.equal((object) this.borderStroke, (object) jfreeChart.borderStroke) && PaintUtilities.equal(this.borderPaint, jfreeChart.borderPaint)) && (this.padding.equals((object) jfreeChart.padding) && ObjectUtilities.equal((object) this.title, (object) jfreeChart.title) && (ObjectUtilities.equal((object) this.subtitles, (object) jfreeChart.subtitles) && ObjectUtilities.equal((object) this.plot, (object) jfreeChart.plot))) && (PaintUtilities.equal(this.backgroundPaint, jfreeChart.backgroundPaint) && ObjectUtilities.equal((object) this.backgroundImage, (object) jfreeChart.backgroundImage) && (this.backgroundImageAlignment == jfreeChart.backgroundImageAlignment && (double) this.backgroundImageAlpha == (double) jfreeChart.backgroundImageAlpha) && this.notify == jfreeChart.notify);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 4, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.borderStroke, obj0);
      SerialUtilities.writePaint(this.borderPaint, obj0);
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 20, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 107, (byte) 107, (byte) 250, (byte) 69, (byte) 104, (byte) 172, (byte) 107, (byte) 45, (byte) 166, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.borderStroke = SerialUtilities.readStroke(obj0);
      this.borderPaint = SerialUtilities.readPaint(obj0);
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.progressListeners = new EventListenerList();
      this.changeListeners = new EventListenerList();
      RenderingHints.__\u003Cclinit\u003E();
      this.renderingHints = new RenderingHints((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_ON);
      if (this.title != null)
        this.title.addChangeListener((TitleChangeListener) this);
      for (int index = 0; index < this.getSubtitleCount(); ++index)
        this.getSubtitle(index).addChangeListener((TitleChangeListener) this);
      this.plot.addChangeListener((PlotChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 47, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      System.get_out().println(JFreeChart.__\u003C\u003EINFO.toString());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JFreeChart.__\u003CcallerID\u003E == null)
        JFreeChart.__\u003CcallerID\u003E = (CallerID) new JFreeChart.__\u003CCallerID\u003E();
      return JFreeChart.__\u003CcallerID\u003E;
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
