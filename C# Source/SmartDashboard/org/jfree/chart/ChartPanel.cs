// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.awt.datatransfer;
using java.awt.geom;
using java.awt.image;
using java.awt.print;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using javax.swing;
using javax.swing.@event;
using javax.swing.filechooser;
using org.jfree.chart.@event;
using org.jfree.chart.editor;
using org.jfree.chart.entity;
using org.jfree.chart.panel;
using org.jfree.chart.plot;
using org.jfree.chart.util;
using org.jfree.io;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"org.jfree.chart.event.ChartChangeListener", "org.jfree.chart.event.ChartProgressListener", "java.awt.event.ActionListener", "java.awt.event.MouseListener", "java.awt.event.MouseMotionListener", "org.jfree.chart.event.OverlayChangeListener", "java.awt.print.Printable", "java.io.Serializable"})]
  [Serializable]
  public class ChartPanel : JPanel, ChartChangeListener, EventListener, ChartProgressListener, ActionListener, MouseListener, MouseMotionListener, OverlayChangeListener, Printable, Serializable.__Interface
  {
    private const long serialVersionUID = 6046366297214274674L;
    public const bool DEFAULT_BUFFER_USED = true;
    public const int DEFAULT_WIDTH = 680;
    public const int DEFAULT_HEIGHT = 420;
    public const int DEFAULT_MINIMUM_DRAW_WIDTH = 300;
    public const int DEFAULT_MINIMUM_DRAW_HEIGHT = 200;
    public const int DEFAULT_MAXIMUM_DRAW_WIDTH = 1024;
    public const int DEFAULT_MAXIMUM_DRAW_HEIGHT = 768;
    public const int DEFAULT_ZOOM_TRIGGER_DISTANCE = 10;
    public const string PROPERTIES_COMMAND = "PROPERTIES";
    public const string COPY_COMMAND = "COPY";
    public const string SAVE_COMMAND = "SAVE";
    public const string PRINT_COMMAND = "PRINT";
    public const string ZOOM_IN_BOTH_COMMAND = "ZOOM_IN_BOTH";
    public const string ZOOM_IN_DOMAIN_COMMAND = "ZOOM_IN_DOMAIN";
    public const string ZOOM_IN_RANGE_COMMAND = "ZOOM_IN_RANGE";
    public const string ZOOM_OUT_BOTH_COMMAND = "ZOOM_OUT_BOTH";
    public const string ZOOM_OUT_DOMAIN_COMMAND = "ZOOM_DOMAIN_BOTH";
    public const string ZOOM_OUT_RANGE_COMMAND = "ZOOM_RANGE_BOTH";
    public const string ZOOM_RESET_BOTH_COMMAND = "ZOOM_RESET_BOTH";
    public const string ZOOM_RESET_DOMAIN_COMMAND = "ZOOM_RESET_DOMAIN";
    public const string ZOOM_RESET_RANGE_COMMAND = "ZOOM_RESET_RANGE";
    private JFreeChart chart;
    [NonSerialized]
    private EventListenerList chartMouseListeners;
    private bool useBuffer;
    private bool refreshBuffer;
    [NonSerialized]
    private Image chartBuffer;
    private int chartBufferHeight;
    private int chartBufferWidth;
    private int minimumDrawWidth;
    private int minimumDrawHeight;
    private int maximumDrawWidth;
    private int maximumDrawHeight;
    private JPopupMenu popup;
    private ChartRenderingInfo info;
    private Point2D anchor;
    private double scaleX;
    private double scaleY;
    private PlotOrientation orientation;
    private bool domainZoomable;
    private bool rangeZoomable;
    private Point2D zoomPoint;
    [NonSerialized]
    private Rectangle2D zoomRectangle;
    private bool fillZoomRectangle;
    private int zoomTriggerDistance;
    private bool horizontalAxisTrace;
    private bool verticalAxisTrace;
    [NonSerialized]
    private Line2D verticalTraceLine;
    [NonSerialized]
    private Line2D horizontalTraceLine;
    private JMenuItem zoomInBothMenuItem;
    private JMenuItem zoomInDomainMenuItem;
    private JMenuItem zoomInRangeMenuItem;
    private JMenuItem zoomOutBothMenuItem;
    private JMenuItem zoomOutDomainMenuItem;
    private JMenuItem zoomOutRangeMenuItem;
    private JMenuItem zoomResetBothMenuItem;
    private JMenuItem zoomResetDomainMenuItem;
    private JMenuItem zoomResetRangeMenuItem;
    private File defaultDirectoryForSaveAs;
    private bool enforceFileExtensions;
    private bool ownToolTipDelaysActive;
    private int originalToolTipInitialDelay;
    private int originalToolTipReshowDelay;
    private int originalToolTipDismissDelay;
    private int ownToolTipInitialDelay;
    private int ownToolTipReshowDelay;
    private int ownToolTipDismissDelay;
    private double zoomInFactor;
    private double zoomOutFactor;
    private bool zoomAroundAnchor;
    [NonSerialized]
    private Paint zoomOutlinePaint;
    [NonSerialized]
    private Paint zoomFillPaint;
    protected internal static ResourceBundle localizationResources;
    private double panW;
    private double panH;
    private Point panLast;
    private int panMask;
    private List overlays;
    private object mouseWheelHandler;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024ChartPanel;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 508)]
    static ChartPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      ChartPanel.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 172, (byte) 255, (byte) 14, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartPanel(JFreeChart chart)
      : this(chart, 680, 420, 300, 200, 1024, 768, true, true, true, true, true, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 234, (byte) 148, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartPanel(JFreeChart chart, int width, int height, int minimumDrawWidth, int minimumDrawHeight, int maximumDrawWidth, int maximumDrawHeight, bool useBuffer, bool properties, bool save, bool print, bool zoom, bool tooltips)
    {
      int num1 = useBuffer ? 1 : 0;
      int num2 = properties ? 1 : 0;
      int num3 = save ? 1 : 0;
      int num4 = print ? 1 : 0;
      int num5 = zoom ? 1 : 0;
      int num6 = tooltips ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(chart, width, height, minimumDrawWidth, minimumDrawHeight, maximumDrawWidth, maximumDrawHeight, num1 != 0, num2 != 0, true, num3 != 0, num4 != 0, num5 != 0, num6 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 225, (byte) 184, (byte) 233, (byte) 158, (byte) 202, (byte) 171, (byte) 167, (byte) 231, (byte) 71, (byte) 167, (byte) 167, (byte) 231, (byte) 70, (byte) 167, (byte) 231, (byte) 160, (byte) 67, (byte) 176, (byte) 240, (byte) 107, (byte) 231, (byte) 160, (byte) 171, (byte) 103, (byte) 107, (byte) 107, (byte) 109, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 168, (byte) 103, (byte) 113, (byte) 179, (byte) 105, (byte) 105, (byte) 104, (byte) 103, (byte) 135, (byte) 103, (byte) 199, (byte) 103, (byte) 109, (byte) 109, (byte) 141, (byte) 103, (byte) 107, (byte) 148, (byte) 167, (byte) 113, (byte) 110, (byte) 167, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartPanel(JFreeChart chart, int width, int height, int minimumDrawWidth, int minimumDrawHeight, int maximumDrawWidth, int maximumDrawHeight, bool useBuffer, bool properties, bool copy, bool save, bool print, bool zoom, bool tooltips)
    {
      int num1 = useBuffer ? 1 : 0;
      int num2 = properties ? 1 : 0;
      int num3 = copy ? 1 : 0;
      int num4 = save ? 1 : 0;
      int num5 = print ? 1 : 0;
      int num6 = zoom ? 1 : 0;
      int num7 = tooltips ? 1 : 0;
      base.\u002Ector();
      ChartPanel chartPanel = this;
      this.orientation = PlotOrientation.__\u003C\u003EVERTICAL;
      this.domainZoomable = false;
      this.rangeZoomable = false;
      this.zoomPoint = (Point2D) null;
      this.zoomRectangle = (Rectangle2D) null;
      this.fillZoomRectangle = true;
      this.horizontalAxisTrace = false;
      this.verticalAxisTrace = false;
      this.zoomInFactor = 0.5;
      this.zoomOutFactor = 2.0;
      this.panMask = 2;
      this.setChart(chart);
      this.chartMouseListeners = new EventListenerList();
      this.info = new ChartRenderingInfo();
      ((JComponent) this).setPreferredSize(new Dimension(width, height));
      this.useBuffer = num1 != 0;
      this.refreshBuffer = false;
      this.minimumDrawWidth = minimumDrawWidth;
      this.minimumDrawHeight = minimumDrawHeight;
      this.maximumDrawWidth = maximumDrawWidth;
      this.maximumDrawHeight = maximumDrawHeight;
      this.zoomTriggerDistance = 10;
      this.popup = (JPopupMenu) null;
      if (num2 != 0 || num3 != 0 || (num4 != 0 || num5 != 0) || num6 != 0)
        this.popup = this.createPopupMenu(num2 != 0, num3 != 0, num4 != 0, num5 != 0, num6 != 0);
      ((Component) this).enableEvents(16L);
      ((Component) this).enableEvents(32L);
      this.setDisplayToolTips(num7 != 0);
      ((Component) this).addMouseListener((MouseListener) this);
      ((Component) this).addMouseMotionListener((MouseMotionListener) this);
      this.defaultDirectoryForSaveAs = (File) null;
      this.enforceFileExtensions = true;
      ToolTipManager toolTipManager = ToolTipManager.sharedInstance();
      this.ownToolTipInitialDelay = toolTipManager.getInitialDelay();
      this.ownToolTipDismissDelay = toolTipManager.getDismissDelay();
      this.ownToolTipReshowDelay = toolTipManager.getReshowDelay();
      this.zoomAroundAnchor = false;
      this.zoomOutlinePaint = (Paint) Color.blue;
      this.zoomFillPaint = (Paint) new Color(0, 0, (int) byte.MaxValue, 63);
      this.panMask = 2;
      if (String.instancehelper_startsWith(String.instancehelper_toLowerCase(System.getProperty("os.name")), "mac os x"))
        this.panMask = 8;
      this.overlays = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 254, (byte) 130, (byte) 255, (byte) 14, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartPanel(JFreeChart chart, bool useBuffer)
    {
      int num = useBuffer ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(chart, 680, 420, 300, 200, 1024, 768, num != 0, true, true, true, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 245, (byte) 78, (byte) 255, (byte) 15, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartPanel(JFreeChart chart, bool properties, bool save, bool print, bool zoom, bool tooltips)
    {
      int num1 = properties ? 1 : 0;
      int num2 = save ? 1 : 0;
      int num3 = print ? 1 : 0;
      int num4 = zoom ? 1 : 0;
      int num5 = tooltips ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(chart, 680, 420, 300, 200, 1024, 768, true, num1 != 0, num2 != 0, num3 != 0, num4 != 0, num5 != 0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ChartPanel obj0)
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 137, (byte) 104, (byte) 108, (byte) 204, (byte) 103, (byte) 102, (byte) 108, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 103, (byte) 108, (byte) 108, (byte) 140, (byte) 130, (byte) 103, (byte) 135, (byte) 104, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChart(JFreeChart chart)
    {
      if (this.chart != null)
      {
        this.chart.removeChangeListener((ChartChangeListener) this);
        this.chart.removeProgressListener((ChartProgressListener) this);
      }
      this.chart = chart;
      if (chart != null)
      {
        this.chart.addChangeListener((ChartChangeListener) this);
        this.chart.addProgressListener((ChartProgressListener) this);
        Plot plot = chart.getPlot();
        this.domainZoomable = false;
        this.rangeZoomable = false;
        if (plot is Zoomable)
        {
          Zoomable zoomable = (Zoomable) plot;
          this.domainZoomable = zoomable.isDomainZoomable();
          this.rangeZoomable = zoomable.isRangeZoomable();
          this.orientation = zoomable.getOrientation();
        }
      }
      else
      {
        this.domainZoomable = false;
        this.rangeZoomable = false;
      }
      if (this.useBuffer)
        this.refreshBuffer = true;
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 156, (byte) 195, (byte) 173, (byte) 108, (byte) 131, (byte) 99, (byte) 155, (byte) 108, (byte) 104, (byte) 106, (byte) 163, (byte) 99, (byte) 100, (byte) 103, (byte) 130, (byte) 155, (byte) 108, (byte) 104, (byte) 106, (byte) 169, (byte) 99, (byte) 100, (byte) 103, (byte) 130, (byte) 155, (byte) 108, (byte) 104, (byte) 106, (byte) 163, (byte) 99, (byte) 100, (byte) 103, (byte) 130, (byte) 155, (byte) 108, (byte) 104, (byte) 106, (byte) 163, (byte) 103, (byte) 100, (byte) 103, (byte) 162, (byte) 187, (byte) 159, (byte) 0, (byte) 112, (byte) 108, (byte) 142, (byte) 135, (byte) 159, (byte) 0, (byte) 112, (byte) 108, (byte) 142, (byte) 159, (byte) 0, (byte) 112, (byte) 108, (byte) 142, (byte) 138, (byte) 187, (byte) 159, (byte) 0, (byte) 112, (byte) 108, (byte) 142, (byte) 135, (byte) 159, (byte) 0, (byte) 144, (byte) 108, (byte) 142, (byte) 159, (byte) 0, (byte) 112, (byte) 108, (byte) 142, (byte) 138, (byte) 187, (byte) 159, (byte) 0, (byte) 144, (byte) 108, (byte) 142, (byte) 103, (byte) 159, (byte) 0, (byte) 144, (byte) 108, (byte) 142, (byte) 159, (byte) 0, (byte) 144, (byte) 108, (byte) 142, (byte) 103, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JPopupMenu createPopupMenu(bool properties, bool copy, bool save, bool print, bool zoom)
    {
      int num1 = properties ? 1 : 0;
      int num2 = copy ? 1 : 0;
      int num3 = save ? 1 : 0;
      int num4 = print ? 1 : 0;
      int num5 = zoom ? 1 : 0;
      JPopupMenu jpopupMenu = new JPopupMenu("Chart:");
      int num6 = 0;
      if (num1 != 0)
      {
        JMenuItem.__\u003Cclinit\u003E();
        JMenuItem jmenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Properties..."));
        ((AbstractButton) jmenuItem).setActionCommand("PROPERTIES");
        ((AbstractButton) jmenuItem).addActionListener((ActionListener) this);
        jpopupMenu.add(jmenuItem);
        num6 = 1;
      }
      if (num2 != 0)
      {
        if (num6 != 0)
          jpopupMenu.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        JMenuItem jmenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Copy"));
        ((AbstractButton) jmenuItem).setActionCommand("COPY");
        ((AbstractButton) jmenuItem).addActionListener((ActionListener) this);
        jpopupMenu.add(jmenuItem);
        num6 = num3 != 0 ? 0 : 1;
      }
      if (num3 != 0)
      {
        if (num6 != 0)
          jpopupMenu.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        JMenuItem jmenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Save_as..."));
        ((AbstractButton) jmenuItem).setActionCommand("SAVE");
        ((AbstractButton) jmenuItem).addActionListener((ActionListener) this);
        jpopupMenu.add(jmenuItem);
        num6 = 1;
      }
      if (num4 != 0)
      {
        if (num6 != 0)
          jpopupMenu.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        JMenuItem jmenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Print..."));
        ((AbstractButton) jmenuItem).setActionCommand("PRINT");
        ((AbstractButton) jmenuItem).addActionListener((ActionListener) this);
        jpopupMenu.add(jmenuItem);
        num6 = 1;
      }
      if (num5 != 0)
      {
        if (num6 != 0)
          jpopupMenu.addSeparator();
        JMenu.__\u003Cclinit\u003E();
        JMenu jmenu1 = new JMenu(ChartPanel.localizationResources.getString("Zoom_In"));
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomInBothMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("All_Axes"));
        ((AbstractButton) this.zoomInBothMenuItem).setActionCommand("ZOOM_IN_BOTH");
        ((AbstractButton) this.zoomInBothMenuItem).addActionListener((ActionListener) this);
        jmenu1.add(this.zoomInBothMenuItem);
        jmenu1.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomInDomainMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Domain_Axis"));
        ((AbstractButton) this.zoomInDomainMenuItem).setActionCommand("ZOOM_IN_DOMAIN");
        ((AbstractButton) this.zoomInDomainMenuItem).addActionListener((ActionListener) this);
        jmenu1.add(this.zoomInDomainMenuItem);
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomInRangeMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Range_Axis"));
        ((AbstractButton) this.zoomInRangeMenuItem).setActionCommand("ZOOM_IN_RANGE");
        ((AbstractButton) this.zoomInRangeMenuItem).addActionListener((ActionListener) this);
        jmenu1.add(this.zoomInRangeMenuItem);
        jpopupMenu.add((JMenuItem) jmenu1);
        JMenu.__\u003Cclinit\u003E();
        JMenu jmenu2 = new JMenu(ChartPanel.localizationResources.getString("Zoom_Out"));
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomOutBothMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("All_Axes"));
        ((AbstractButton) this.zoomOutBothMenuItem).setActionCommand("ZOOM_OUT_BOTH");
        ((AbstractButton) this.zoomOutBothMenuItem).addActionListener((ActionListener) this);
        jmenu2.add(this.zoomOutBothMenuItem);
        jmenu2.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomOutDomainMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Domain_Axis"));
        ((AbstractButton) this.zoomOutDomainMenuItem).setActionCommand("ZOOM_DOMAIN_BOTH");
        ((AbstractButton) this.zoomOutDomainMenuItem).addActionListener((ActionListener) this);
        jmenu2.add(this.zoomOutDomainMenuItem);
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomOutRangeMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Range_Axis"));
        ((AbstractButton) this.zoomOutRangeMenuItem).setActionCommand("ZOOM_RANGE_BOTH");
        ((AbstractButton) this.zoomOutRangeMenuItem).addActionListener((ActionListener) this);
        jmenu2.add(this.zoomOutRangeMenuItem);
        jpopupMenu.add((JMenuItem) jmenu2);
        JMenu.__\u003Cclinit\u003E();
        JMenu jmenu3 = new JMenu(ChartPanel.localizationResources.getString("Auto_Range"));
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomResetBothMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("All_Axes"));
        ((AbstractButton) this.zoomResetBothMenuItem).setActionCommand("ZOOM_RESET_BOTH");
        ((AbstractButton) this.zoomResetBothMenuItem).addActionListener((ActionListener) this);
        jmenu3.add(this.zoomResetBothMenuItem);
        jmenu3.addSeparator();
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomResetDomainMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Domain_Axis"));
        ((AbstractButton) this.zoomResetDomainMenuItem).setActionCommand("ZOOM_RESET_DOMAIN");
        ((AbstractButton) this.zoomResetDomainMenuItem).addActionListener((ActionListener) this);
        jmenu3.add(this.zoomResetDomainMenuItem);
        JMenuItem.__\u003Cclinit\u003E();
        this.zoomResetRangeMenuItem = new JMenuItem(ChartPanel.localizationResources.getString("Range_Axis"));
        ((AbstractButton) this.zoomResetRangeMenuItem).setActionCommand("ZOOM_RESET_RANGE");
        ((AbstractButton) this.zoomResetRangeMenuItem).addActionListener((ActionListener) this);
        jmenu3.add(this.zoomResetRangeMenuItem);
        jpopupMenu.addSeparator();
        jpopupMenu.add((JMenuItem) jmenu3);
      }
      return jpopupMenu;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 36, (byte) 66, (byte) 99, (byte) 173, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDisplayToolTips(bool flag)
    {
      if (flag)
        ToolTipManager.sharedInstance().registerComponent((JComponent) this);
      else
        ToolTipManager.sharedInstance().unregisterComponent((JComponent) this);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 154, (byte) 132, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMouseZoomable(bool flag, bool fillRectangle)
    {
      int num1 = flag ? 1 : 0;
      int num2 = fillRectangle ? 1 : 0;
      this.setDomainZoomable(num1 != 0);
      this.setRangeZoomable(num1 != 0);
      this.setFillZoomRectangle(num2 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 148, (byte) 98, (byte) 99, (byte) 108, (byte) 104, (byte) 103, (byte) 149, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainZoomable(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num != 0)
      {
        Plot plot = this.chart.getPlot();
        if (!(plot is Zoomable))
          return;
        Zoomable zoomable = (Zoomable) plot;
        this.domainZoomable = num != 0 && zoomable.isDomainZoomable();
      }
      else
        this.domainZoomable = false;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 141, (byte) 98, (byte) 99, (byte) 108, (byte) 104, (byte) 103, (byte) 149, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeZoomable(bool flag)
    {
      int num = flag ? 1 : 0;
      if (num != 0)
      {
        Plot plot = this.chart.getPlot();
        if (!(plot is Zoomable))
          return;
        Zoomable zoomable = (Zoomable) plot;
        this.rangeZoomable = num != 0 && zoomable.isRangeZoomable();
      }
      else
        this.rangeZoomable = false;
    }

    public virtual void setFillZoomRectangle(bool flag)
    {
      this.fillZoomRectangle = flag;
    }

    [LineNumberTable((ushort) 1333)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, ChartPanel.__\u003CGetCallerID\u003E());
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

    public virtual double getScaleX()
    {
      return this.scaleX;
    }

    public virtual double getScaleY()
    {
      return this.scaleY;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 3, (byte) 66, (byte) 104, (byte) 131, (byte) 139, (byte) 104, (byte) 108, (byte) 174, (byte) 108, (byte) 140, (byte) 131, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawZoomRectangle([In] Graphics2D obj0, [In] bool obj1)
    {
      int num = obj1 ? 1 : 0;
      if (this.zoomRectangle == null)
        return;
      if (num != 0)
        ((Graphics) obj0).setXORMode((Color) Color.gray);
      if (this.fillZoomRectangle)
      {
        obj0.setPaint(this.zoomFillPaint);
        obj0.fill((Shape) this.zoomRectangle);
      }
      else
      {
        obj0.setPaint(this.zoomOutlinePaint);
        obj0.draw((Shape) this.zoomRectangle);
      }
      if (num == 0)
        return;
      ((Graphics) obj0).setPaintMode();
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 19, (byte) 108, (byte) 185, (byte) 99, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void doEditChartProperties()
    {
      ChartEditor chartEditor = ChartEditorManager.getChartEditor(this.chart);
      if (JOptionPane.showConfirmDialog((Component) this, (object) chartEditor, ChartPanel.localizationResources.getString("Chart_Properties"), 2, -1) != 0)
        return;
      chartEditor.updateChart(this.chart);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 35, (byte) 139, (byte) 152, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void doCopy()
    {
      Toolkit.getDefaultToolkit().getSystemClipboard().setContents((Transferable) new ChartTransferable(this.chart, ((JComponent) this).getWidth(), ((JComponent) this).getHeight()), (ClipboardOwner) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 170, (byte) 50, (byte) 102, (byte) 108, (byte) 154, (byte) 135, (byte) 104, (byte) 99, (byte) 108, (byte) 104, (byte) 109, (byte) 187, (byte) 223, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void doSaveAs()
    {
      JFileChooser jfileChooser = new JFileChooser();
      jfileChooser.setCurrentDirectory(this.defaultDirectoryForSaveAs);
      ExtensionFileFilter extensionFileFilter = new ExtensionFileFilter(ChartPanel.localizationResources.getString("PNG_Image_Files"), ".png");
      jfileChooser.addChoosableFileFilter((FileFilter) extensionFileFilter);
      if (jfileChooser.showSaveDialog((Component) this) != 0)
        return;
      string str = jfileChooser.getSelectedFile().getPath();
      if (this.isEnforceFileExtensions() && !String.instancehelper_endsWith(str, ".png"))
        str = new StringBuffer().append(str).append(".png").toString();
      ChartUtilities.saveChartAsPNG(new File(str), this.chart, ((JComponent) this).getWidth(), ((JComponent) this).getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 75, (byte) 102, (byte) 103, (byte) 104, (byte) 100, (byte) 104, (byte) 136, (byte) 216, (byte) 2, (byte) 98, (byte) 232, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void createChartPrintJob()
    {
      PrinterJob printerJob = PrinterJob.getPrinterJob();
      PageFormat pageFormat1 = printerJob.defaultPage();
      PageFormat pageFormat2 = printerJob.pageDialog(pageFormat1);
      if (pageFormat2 == pageFormat1)
        return;
      printerJob.setPrintable((Printable) this, pageFormat2);
      if (!printerJob.printDialog())
        return;
      PrinterException printerException;
      try
      {
        printerJob.print();
        return;
      }
      catch (PrinterException ex)
      {
        int num = 1;
        printerException = (PrinterException) ByteCodeHelper.MapException<PrinterException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      JOptionPane.showMessageDialog((Component) this, (object) printerException);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 35, (byte) 108, (byte) 99, (byte) 225, (byte) 69, (byte) 103, (byte) 103, (byte) 106, (byte) 106, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomInBoth(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (plot == null)
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      this.zoomInDomain(x, y);
      this.zoomInRange(x, y);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 58, (byte) 108, (byte) 200, (byte) 103, (byte) 103, (byte) 103, (byte) 191, (byte) 23, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomInDomain(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (!(plot is Zoomable))
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      ((Zoomable) plot).zoomDomainAxes(this.zoomInFactor, this.info.getPlotInfo(), this.translateScreenToJava2D(new Point(ByteCodeHelper.d2i(x), ByteCodeHelper.d2i(y))), this.zoomAroundAnchor);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 82, (byte) 108, (byte) 200, (byte) 103, (byte) 103, (byte) 103, (byte) 191, (byte) 23, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomInRange(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (!(plot is Zoomable))
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      ((Zoomable) plot).zoomRangeAxes(this.zoomInFactor, this.info.getPlotInfo(), this.translateScreenToJava2D(new Point(ByteCodeHelper.d2i(x), ByteCodeHelper.d2i(y))), this.zoomAroundAnchor);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 104, (byte) 108, (byte) 99, (byte) 225, (byte) 69, (byte) 103, (byte) 103, (byte) 106, (byte) 106, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomOutBoth(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (plot == null)
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      this.zoomOutDomain(x, y);
      this.zoomOutRange(x, y);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 127, (byte) 108, (byte) 200, (byte) 103, (byte) 103, (byte) 103, (byte) 191, (byte) 23, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomOutDomain(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (!(plot is Zoomable))
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      ((Zoomable) plot).zoomDomainAxes(this.zoomOutFactor, this.info.getPlotInfo(), this.translateScreenToJava2D(new Point(ByteCodeHelper.d2i(x), ByteCodeHelper.d2i(y))), this.zoomAroundAnchor);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 151, (byte) 108, (byte) 200, (byte) 103, (byte) 103, (byte) 103, (byte) 191, (byte) 23, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomOutRange(double x, double y)
    {
      Plot plot = this.chart.getPlot();
      if (!(plot is Zoomable))
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      ((Zoomable) plot).zoomRangeAxes(this.zoomOutFactor, this.info.getPlotInfo(), this.translateScreenToJava2D(new Point(ByteCodeHelper.d2i(x), ByteCodeHelper.d2i(y))), this.zoomAroundAnchor);
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 219, (byte) 108, (byte) 99, (byte) 225, (byte) 69, (byte) 103, (byte) 103, (byte) 102, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void restoreAutoBounds()
    {
      Plot plot = this.chart.getPlot();
      if (plot == null)
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      this.restoreAutoDomainBounds();
      this.restoreAutoRangeBounds();
      plot.setNotify(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 237, (byte) 108, (byte) 104, (byte) 199, (byte) 103, (byte) 135, (byte) 150, (byte) 119, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void restoreAutoDomainBounds()
    {
      // ISSUE: unable to decompile the method.
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 1, (byte) 108, (byte) 104, (byte) 199, (byte) 103, (byte) 135, (byte) 150, (byte) 119, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void restoreAutoRangeBounds()
    {
      // ISSUE: unable to decompile the method.
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 43, (byte) 140, (byte) 104, (byte) 233, (byte) 69, (byte) 110, (byte) 104, (byte) 100, (byte) 130, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D getScreenDataArea(int x, int y)
    {
      PlotRenderingInfo plotInfo = this.info.getPlotInfo();
      Rectangle2D rectangle2D;
      if (plotInfo.getSubplotCount() == 0)
      {
        rectangle2D = this.getScreenDataArea();
      }
      else
      {
        Point2D source = this.translateScreenToJava2D(new Point(x, y));
        int subplotIndex = plotInfo.getSubplotIndex(source);
        if (subplotIndex == -1)
          return (Rectangle2D) null;
        rectangle2D = this.scale(plotInfo.getSubplotInfo(subplotIndex).getDataArea());
      }
      return rectangle2D;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 253, (byte) 122, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Point2D getPointInRectangle([In] int obj0, [In] int obj1, [In] Rectangle2D obj2)
    {
      return (Point2D) new Point2D.Double(Math.max(((RectangularShape) obj2).getMinX(), Math.min((double) obj0, ((RectangularShape) obj2).getMaxX())), Math.max(((RectangularShape) obj2).getMinY(), Math.min((double) obj1, ((RectangularShape) obj2).getMaxY())));
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 84, (byte) 203, (byte) 108, (byte) 98, (byte) 98, (byte) 104, (byte) 103, (byte) 103, (byte) 167, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 172, (byte) 104, (byte) 140, (byte) 104, (byte) 172, (byte) 104, (byte) 172, (byte) 104, (byte) 181, (byte) 104, (byte) 181, (byte) 104, (byte) 213, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void displayPopupMenu(int x, int y)
    {
      if (this.popup == null)
        return;
      Plot plot = this.chart.getPlot();
      int num1 = 0;
      int num2 = 0;
      if (plot is Zoomable)
      {
        Zoomable zoomable = (Zoomable) plot;
        num1 = zoomable.isDomainZoomable() ? 1 : 0;
        num2 = zoomable.isRangeZoomable() ? 1 : 0;
      }
      if (this.zoomInDomainMenuItem != null)
        this.zoomInDomainMenuItem.setEnabled(num1 != 0);
      if (this.zoomOutDomainMenuItem != null)
        this.zoomOutDomainMenuItem.setEnabled(num1 != 0);
      if (this.zoomResetDomainMenuItem != null)
        this.zoomResetDomainMenuItem.setEnabled(num1 != 0);
      if (this.zoomInRangeMenuItem != null)
        this.zoomInRangeMenuItem.setEnabled(num2 != 0);
      if (this.zoomOutRangeMenuItem != null)
        this.zoomOutRangeMenuItem.setEnabled(num2 != 0);
      if (this.zoomResetRangeMenuItem != null)
        this.zoomResetRangeMenuItem.setEnabled(num2 != 0);
      if (this.zoomInBothMenuItem != null)
        this.zoomInBothMenuItem.setEnabled(num1 != 0 && num2 != 0);
      if (this.zoomOutBothMenuItem != null)
        this.zoomOutBothMenuItem.setEnabled(num1 != 0 && num2 != 0);
      if (this.zoomResetBothMenuItem != null)
        this.zoomResetBothMenuItem.setEnabled(num1 != 0 && num2 != 0);
      this.popup.show((Component) this, x, y);
    }

    [LineNumberTable(new byte[] {(byte) 168, (byte) 175, (byte) 191, (byte) 13, (byte) 108, (byte) 157, (byte) 159, (byte) 1, (byte) 150, (byte) 151, (byte) 151, (byte) 183, (byte) 109, (byte) 204, (byte) 105, (byte) 104, (byte) 105, (byte) 110, (byte) 109, (byte) 174, (byte) 108, (byte) 141, (byte) 235, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoom(Rectangle2D selection)
    {
      Point2D pd = this.translateScreenToJava2D(new Point(ByteCodeHelper.d2i(Math.ceil(((RectangularShape) selection).getX())), ByteCodeHelper.d2i(Math.ceil(((RectangularShape) selection).getY()))));
      PlotRenderingInfo plotInfo = this.info.getPlotInfo();
      Rectangle2D screenDataArea = this.getScreenDataArea(ByteCodeHelper.d2i(((RectangularShape) selection).getCenterX()), ByteCodeHelper.d2i(((RectangularShape) selection).getCenterY()));
      if (((RectangularShape) selection).getHeight() <= 0.0 || ((RectangularShape) selection).getWidth() <= 0.0)
        return;
      double d1_1 = (((RectangularShape) selection).getMinX() - ((RectangularShape) screenDataArea).getMinX()) / ((RectangularShape) screenDataArea).getWidth();
      double d2_1 = (((RectangularShape) selection).getMaxX() - ((RectangularShape) screenDataArea).getMinX()) / ((RectangularShape) screenDataArea).getWidth();
      double d1_2 = (((RectangularShape) screenDataArea).getMaxY() - ((RectangularShape) selection).getMaxY()) / ((RectangularShape) screenDataArea).getHeight();
      double d2_2 = (((RectangularShape) screenDataArea).getMaxY() - ((RectangularShape) selection).getMinY()) / ((RectangularShape) screenDataArea).getHeight();
      Plot plot = this.chart.getPlot();
      if (!(plot is Zoomable))
        return;
      int num = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      Zoomable zoomable = (Zoomable) plot;
      if (zoomable.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        zoomable.zoomDomainAxes(d1_2, d2_2, plotInfo, pd);
        zoomable.zoomRangeAxes(d1_1, d2_1, plotInfo, pd);
      }
      else
      {
        zoomable.zoomDomainAxes(d1_1, d2_1, plotInfo, pd);
        zoomable.zoomRangeAxes(d1_2, d2_2, plotInfo, pd);
      }
      plot.setNotify(num != 0);
    }

    public virtual JFreeChart getChart()
    {
      return this.chart;
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 215, (byte) 135, (byte) 107, (byte) 159, (byte) 3, (byte) 104, (byte) 108, (byte) 223, (byte) 10, (byte) 191, (byte) 8, (byte) 204, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawHorizontalAxisTrace([In] Graphics2D obj0, [In] int obj1)
    {
      Rectangle2D screenDataArea = this.getScreenDataArea();
      ((Graphics) obj0).setXORMode((Color) Color.orange);
      if (ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinX()) < obj1 && obj1 < ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxX()))
      {
        if (this.verticalTraceLine != null)
        {
          obj0.draw((Shape) this.verticalTraceLine);
          this.verticalTraceLine.setLine((double) obj1, (double) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinY()), (double) obj1, (double) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxY()));
        }
        else
          this.verticalTraceLine = (Line2D) new Line2D.Float((float) obj1, (float) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinY()), (float) obj1, (float) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxY()));
        obj0.draw((Shape) this.verticalTraceLine);
      }
      ((Graphics) obj0).setPaintMode();
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 245, (byte) 135, (byte) 107, (byte) 159, (byte) 3, (byte) 104, (byte) 108, (byte) 223, (byte) 10, (byte) 223, (byte) 8, (byte) 204, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawVerticalAxisTrace([In] Graphics2D obj0, [In] int obj1)
    {
      Rectangle2D screenDataArea = this.getScreenDataArea();
      ((Graphics) obj0).setXORMode((Color) Color.orange);
      if (ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinY()) < obj1 && obj1 < ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxY()))
      {
        if (this.horizontalTraceLine != null)
        {
          obj0.draw((Shape) this.horizontalTraceLine);
          this.horizontalTraceLine.setLine((double) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinX()), (double) obj1, (double) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxX()), (double) obj1);
        }
        else
          this.horizontalTraceLine = (Line2D) new Line2D.Float((float) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMinX()), (float) obj1, (float) ByteCodeHelper.d2i(((RectangularShape) screenDataArea).getMaxX()), (float) obj1);
        obj0.draw((Shape) this.horizontalTraceLine);
      }
      ((Graphics) obj0).setPaintMode();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 111, (byte) 103, (byte) 119, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Point2D translateScreenToJava2D(Point screenPoint)
    {
      Insets insets = ((JComponent) this).getInsets();
      return (Point2D) new Point2D.Double((screenPoint.getX() - (double) insets.left) / this.scaleX, (screenPoint.getY() - (double) insets.top) / this.scaleY);
    }

    [LineNumberTable(new byte[] {(byte) 169, (byte) 24, (byte) 113, (byte) 103, (byte) 119, (byte) 119, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D getScreenDataArea()
    {
      Rectangle2D dataArea = this.info.getPlotInfo().getDataArea();
      Insets insets = ((JComponent) this).getInsets();
      return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) dataArea).getX() * this.scaleX + (double) insets.left, ((RectangularShape) dataArea).getY() * this.scaleY + (double) insets.top, ((RectangularShape) dataArea).getWidth() * this.scaleX, ((RectangularShape) dataArea).getHeight() * this.scaleY);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 126, (byte) 103, (byte) 119, (byte) 119, (byte) 111, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D scale(Rectangle2D rect)
    {
      Insets insets = ((JComponent) this).getInsets();
      return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) rect).getX() * this.getScaleX() + (double) insets.left, ((RectangularShape) rect).getY() * this.getScaleY() + (double) insets.top, ((RectangularShape) rect).getWidth() * this.getScaleX(), ((RectangularShape) rect).getHeight() * this.getScaleY());
    }

    public virtual bool isEnforceFileExtensions()
    {
      return this.enforceFileExtensions;
    }

    public virtual int getMinimumDrawWidth()
    {
      return this.minimumDrawWidth;
    }

    public virtual void setMinimumDrawWidth(int width)
    {
      this.minimumDrawWidth = width;
    }

    public virtual int getMaximumDrawWidth()
    {
      return this.maximumDrawWidth;
    }

    public virtual void setMaximumDrawWidth(int width)
    {
      this.maximumDrawWidth = width;
    }

    public virtual int getMinimumDrawHeight()
    {
      return this.minimumDrawHeight;
    }

    public virtual void setMinimumDrawHeight(int height)
    {
      this.minimumDrawHeight = height;
    }

    public virtual int getMaximumDrawHeight()
    {
      return this.maximumDrawHeight;
    }

    public virtual void setMaximumDrawHeight(int height)
    {
      this.maximumDrawHeight = height;
    }

    public virtual Point2D getAnchor()
    {
      return this.anchor;
    }

    protected internal virtual void setAnchor(Point2D anchor)
    {
      this.anchor = anchor;
    }

    public virtual JPopupMenu getPopupMenu()
    {
      return this.popup;
    }

    public virtual void setPopupMenu(JPopupMenu popup)
    {
      this.popup = popup;
    }

    public virtual ChartRenderingInfo getChartRenderingInfo()
    {
      return this.info;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 157, (byte) 162, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMouseZoomable(bool flag)
    {
      this.setMouseZoomable(flag, true);
    }

    public virtual bool isDomainZoomable()
    {
      return this.domainZoomable;
    }

    public virtual bool isRangeZoomable()
    {
      return this.rangeZoomable;
    }

    public virtual bool getFillZoomRectangle()
    {
      return this.fillZoomRectangle;
    }

    public virtual int getZoomTriggerDistance()
    {
      return this.zoomTriggerDistance;
    }

    public virtual void setZoomTriggerDistance(int distance)
    {
      this.zoomTriggerDistance = distance;
    }

    public virtual bool getHorizontalAxisTrace()
    {
      return this.horizontalAxisTrace;
    }

    public virtual void setHorizontalAxisTrace(bool flag)
    {
      this.horizontalAxisTrace = flag;
    }

    protected internal virtual Line2D getHorizontalTraceLine()
    {
      return this.horizontalTraceLine;
    }

    protected internal virtual void setHorizontalTraceLine(Line2D line)
    {
      this.horizontalTraceLine = line;
    }

    public virtual bool getVerticalAxisTrace()
    {
      return this.verticalAxisTrace;
    }

    public virtual void setVerticalAxisTrace(bool flag)
    {
      this.verticalAxisTrace = flag;
    }

    protected internal virtual Line2D getVerticalTraceLine()
    {
      return this.verticalTraceLine;
    }

    protected internal virtual void setVerticalTraceLine(Line2D line)
    {
      this.verticalTraceLine = line;
    }

    public virtual File getDefaultDirectoryForSaveAs()
    {
      return this.defaultDirectoryForSaveAs;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 39, (byte) 99, (byte) 104, (byte) 208, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDefaultDirectoryForSaveAs(File directory)
    {
      if (directory != null && !directory.isDirectory())
      {
        string str = "The 'directory' argument is not a directory.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.defaultDirectoryForSaveAs = directory;
    }

    public virtual void setEnforceFileExtensions(bool enforce)
    {
      this.enforceFileExtensions = enforce;
    }

    public virtual bool getZoomAroundAnchor()
    {
      return this.zoomAroundAnchor;
    }

    public virtual void setZoomAroundAnchor(bool zoomAroundAnchor)
    {
      this.zoomAroundAnchor = zoomAroundAnchor;
    }

    public virtual Paint getZoomFillPaint()
    {
      return this.zoomFillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 124, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setZoomFillPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.zoomFillPaint = paint;
    }

    public virtual Paint getZoomOutlinePaint()
    {
      return this.zoomOutlinePaint;
    }

    public virtual void setZoomOutlinePaint(Paint paint)
    {
      this.zoomOutlinePaint = paint;
    }

    public virtual bool isMouseWheelEnabled()
    {
      return this.mouseWheelHandler != null;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 67, (byte) 130, (byte) 241, (byte) 69, (byte) 112, (byte) 159, (byte) 20, (byte) 118, (byte) 255, (byte) 71, (byte) 87, (byte) 229, (byte) 43, (byte) 225, (byte) 85, (byte) 229, (byte) 47, (byte) 98, (byte) 231, (byte) 80, (byte) 229, (byte) 50, (byte) 98, (byte) 231, (byte) 77, (byte) 229, (byte) 53, (byte) 98, (byte) 231, (byte) 74, (byte) 229, (byte) 56, (byte) 98, (byte) 231, (byte) 71, (byte) 229, (byte) 59, (byte) 98, (byte) 199, (byte) 5, (byte) 98, (byte) 103, (byte) 197, (byte) 171, (byte) 144, (byte) 127, (byte) 1, (byte) 157, (byte) 255, (byte) 79, (byte) 83, (byte) 226, (byte) 47, (byte) 225, (byte) 81, (byte) 226, (byte) 50, (byte) 98, (byte) 231, (byte) 77, (byte) 226, (byte) 53, (byte) 98, (byte) 231, (byte) 74, (byte) 226, (byte) 56, (byte) 98, (byte) 231, (byte) 71, (byte) 226, (byte) 59, (byte) 98, (byte) 199, (byte) 2, (byte) 98, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMouseWheelEnabled(bool flag)
    {
      if (flag)
      {
        if (this.mouseWheelHandler == null)
        {
          SecurityException securityException;
          NoSuchMethodException suchMethodException;
          IllegalArgumentException argumentException;
          InstantiationException instantiationException;
          IllegalAccessException illegalAccessException;
          InvocationTargetException invocationTargetException;
          try
          {
            try
            {
              try
              {
                try
                {
                  try
                  {
                    try
                    {
                      try
                      {
                        Class class1 = Class.forName("org.jfree.chart.MouseWheelHandler", ChartPanel.__\u003CGetCallerID\u003E());
                        Class[] classArray = new Class[1];
                        int index1 = 0;
                        Class class2 = ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel = ChartPanel.class\u0024("org.jfree.chart.ChartPanel"));
                        classArray[index1] = class2;
                        CallerID callerId1 = ChartPanel.__\u003CGetCallerID\u003E();
                        Constructor constructor = class1.getConstructor(classArray, callerId1);
                        object[] objArray = new object[1];
                        int index2 = 0;
                        objArray[index2] = (object) this;
                        CallerID callerId2 = ChartPanel.__\u003CGetCallerID\u003E();
                        this.mouseWheelHandler = constructor.newInstance(objArray, callerId2);
                      }
                      catch (ClassNotFoundException ex)
                      {
                      }
                    }
                    catch (SecurityException ex)
                    {
                      int num = 1;
                      securityException = (SecurityException) ByteCodeHelper.MapException<SecurityException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
                      goto label_11;
                    }
                  }
                  catch (NoSuchMethodException ex)
                  {
                    int num = 1;
                    suchMethodException = (NoSuchMethodException) ByteCodeHelper.MapException<NoSuchMethodException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
                    goto label_12;
                  }
                }
                catch (IllegalArgumentException ex)
                {
                  int num = 1;
                  argumentException = (IllegalArgumentException) ByteCodeHelper.MapException<IllegalArgumentException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
                  goto label_13;
                }
              }
              catch (InstantiationException ex)
              {
                int num = 1;
                instantiationException = (InstantiationException) ByteCodeHelper.MapException<InstantiationException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
                goto label_14;
              }
            }
            catch (IllegalAccessException ex)
            {
              int num = 1;
              illegalAccessException = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
              goto label_15;
            }
          }
          catch (InvocationTargetException ex)
          {
            int num = 1;
            invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
            goto label_16;
          }
          return;
label_11:
          Throwable.instancehelper_printStackTrace((Exception) securityException);
          return;
label_12:
          Throwable.instancehelper_printStackTrace((Exception) suchMethodException);
          return;
label_13:
          Throwable.instancehelper_printStackTrace((Exception) argumentException);
          return;
label_14:
          Throwable.instancehelper_printStackTrace((Exception) instantiationException);
          return;
label_15:
          Throwable.instancehelper_printStackTrace((Exception) illegalAccessException);
          return;
label_16:
          Throwable.instancehelper_printStackTrace((Exception) invocationTargetException);
          return;
        }
      }
      if (this.mouseWheelHandler == null)
        return;
      SecurityException securityException1;
      NoSuchMethodException suchMethodException1;
      IllegalArgumentException argumentException1;
      IllegalAccessException illegalAccessException1;
      InvocationTargetException invocationTargetException1;
      try
      {
        try
        {
          try
          {
            try
            {
              try
              {
                try
                {
                  Class class1 = Class.forName("java.awt.event.MouseWheelListener", ChartPanel.__\u003CGetCallerID\u003E());
                  Class class2 = ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartPanel = ChartPanel.class\u0024("org.jfree.chart.ChartPanel"));
                  string str = "removeMouseWheelListener";
                  Class[] classArray = new Class[1];
                  int index1 = 0;
                  Class class3 = class1;
                  classArray[index1] = class3;
                  CallerID callerId1 = ChartPanel.__\u003CGetCallerID\u003E();
                  Method method = class2.getMethod(str, classArray, callerId1);
                  object[] objArray = new object[1];
                  int index2 = 0;
                  object obj = this.mouseWheelHandler;
                  objArray[index2] = obj;
                  CallerID callerId2 = ChartPanel.__\u003CGetCallerID\u003E();
                  method.invoke((object) this, objArray, callerId2);
                }
                catch (ClassNotFoundException ex)
                {
                }
              }
              catch (SecurityException ex)
              {
                int num = 1;
                securityException1 = (SecurityException) ByteCodeHelper.MapException<SecurityException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
                goto label_26;
              }
            }
            catch (NoSuchMethodException ex)
            {
              int num = 1;
              suchMethodException1 = (NoSuchMethodException) ByteCodeHelper.MapException<NoSuchMethodException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
              goto label_27;
            }
          }
          catch (IllegalArgumentException ex)
          {
            int num = 1;
            argumentException1 = (IllegalArgumentException) ByteCodeHelper.MapException<IllegalArgumentException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
            goto label_28;
          }
        }
        catch (IllegalAccessException ex)
        {
          int num = 1;
          illegalAccessException1 = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_29;
        }
      }
      catch (InvocationTargetException ex)
      {
        int num = 1;
        invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_30;
      }
      return;
label_26:
      Throwable.instancehelper_printStackTrace((Exception) securityException1);
      return;
label_27:
      Throwable.instancehelper_printStackTrace((Exception) suchMethodException1);
      return;
label_28:
      Throwable.instancehelper_printStackTrace((Exception) argumentException1);
      return;
label_29:
      Throwable.instancehelper_printStackTrace((Exception) illegalAccessException1);
      return;
label_30:
      Throwable.instancehelper_printStackTrace((Exception) invocationTargetException1);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 8, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addOverlay(Overlay overlay)
    {
      if (overlay == null)
      {
        string str = "Null 'overlay' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.overlays.add((object) overlay);
        overlay.addChangeListener((OverlayChangeListener) this);
        ((Component) this).repaint();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 24, (byte) 99, (byte) 144, (byte) 109, (byte) 99, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeOverlay(Overlay overlay)
    {
      if (overlay == null)
      {
        string str = "Null 'overlay' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.overlays.remove((object) overlay))
          return;
        overlay.removeChangeListener((OverlayChangeListener) this);
        ((Component) this).repaint();
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 42, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void overlayChanged(OverlayChangeEvent @event)
    {
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 71, (byte) 98, (byte) 107, (byte) 108, (byte) 99, (byte) 103, (byte) 191, (byte) 30, (byte) 99, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getToolTipText(MouseEvent e)
    {
      string str = (string) null;
      if (this.info != null)
      {
        EntityCollection entityCollection = this.info.getEntityCollection();
        if (entityCollection != null)
        {
          Insets insets = ((JComponent) this).getInsets();
          ChartEntity entity = entityCollection.getEntity((double) ByteCodeHelper.d2i((double) (e.getX() - insets.left) / this.scaleX), (double) ByteCodeHelper.d2i((double) (e.getY() - insets.top) / this.scaleY));
          if (entity != null)
            str = entity.getToolTipText();
        }
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 96, (byte) 103, (byte) 123, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Point translateJava2DToScreen(Point2D java2DPoint)
    {
      Insets insets = ((JComponent) this).getInsets();
      return new Point(ByteCodeHelper.d2i(java2DPoint.getX() * this.scaleX + (double) insets.left), ByteCodeHelper.d2i(java2DPoint.getY() * this.scaleY + (double) insets.top));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 147, (byte) 98, (byte) 104, (byte) 103, (byte) 114, (byte) 114, (byte) 109, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ChartEntity getEntityForPoint(int viewX, int viewY)
    {
      ChartEntity chartEntity = (ChartEntity) null;
      if (this.info != null)
      {
        Insets insets = ((JComponent) this).getInsets();
        double d1 = (double) (viewX - insets.left) / this.scaleX;
        double d2 = (double) (viewY - insets.top) / this.scaleY;
        EntityCollection entityCollection = this.info.getEntityCollection();
        chartEntity = entityCollection == null ? (ChartEntity) null : entityCollection.getEntity(d1, d2);
      }
      return chartEntity;
    }

    public virtual bool getRefreshBuffer()
    {
      return this.refreshBuffer;
    }

    public virtual void setRefreshBuffer(bool flag)
    {
      this.refreshBuffer = flag;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 189, (byte) 103, (byte) 104, (byte) 129, (byte) 172, (byte) 103, (byte) 103, (byte) 255, (byte) 33, (byte) 69, (byte) 99, (byte) 105, (byte) 105, (byte) 108, (byte) 140, (byte) 107, (byte) 113, (byte) 105, (byte) 133, (byte) 107, (byte) 113, (byte) 105, (byte) 163, (byte) 107, (byte) 113, (byte) 105, (byte) 133, (byte) 107, (byte) 113, (byte) 105, (byte) 163, (byte) 213, (byte) 171, (byte) 191, (byte) 7, (byte) 113, (byte) 113, (byte) 104, (byte) 186, (byte) 199, (byte) 139, (byte) 135, (byte) 191, (byte) 0, (byte) 146, (byte) 154, (byte) 109, (byte) 105, (byte) 100, (byte) 105, (byte) 147, (byte) 105, (byte) 155, (byte) 105, (byte) 130, (byte) 251, (byte) 71, (byte) 255, (byte) 0, (byte) 71, (byte) 104, (byte) 114, (byte) 100, (byte) 147, (byte) 136, (byte) 122, (byte) 200, (byte) 109, (byte) 105, (byte) 110, (byte) 105, (byte) 226, (byte) 69, (byte) 147, (byte) 134, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintComponent(Graphics g)
    {
      ((JComponent) this).paintComponent(g);
      if (this.chart == null)
        return;
      Graphics2D graphics2D = (Graphics2D) g.create();
      Dimension size = ((Component) this).getSize();
      Insets insets = ((JComponent) this).getInsets();
      Rectangle2D.Double double1 = new Rectangle2D.Double((double) insets.left, (double) insets.top, size.getWidth() - (double) insets.left - (double) insets.right, size.getHeight() - (double) insets.top - (double) insets.bottom);
      int num1 = 0;
      double num2 = ((RectangularShape) double1).getWidth();
      double num3 = ((RectangularShape) double1).getHeight();
      this.scaleX = 1.0;
      this.scaleY = 1.0;
      if (num2 < (double) this.minimumDrawWidth)
      {
        this.scaleX = num2 / (double) this.minimumDrawWidth;
        num2 = (double) this.minimumDrawWidth;
        num1 = 1;
      }
      else if (num2 > (double) this.maximumDrawWidth)
      {
        this.scaleX = num2 / (double) this.maximumDrawWidth;
        num2 = (double) this.maximumDrawWidth;
        num1 = 1;
      }
      if (num3 < (double) this.minimumDrawHeight)
      {
        this.scaleY = num3 / (double) this.minimumDrawHeight;
        num3 = (double) this.minimumDrawHeight;
        num1 = 1;
      }
      else if (num3 > (double) this.maximumDrawHeight)
      {
        this.scaleY = num3 / (double) this.maximumDrawHeight;
        num3 = (double) this.maximumDrawHeight;
        num1 = 1;
      }
      Rectangle2D.Double double2 = new Rectangle2D.Double(0.0, 0.0, num2, num3);
      if (this.useBuffer)
      {
        if (this.chartBuffer == null || (double) this.chartBufferWidth != ((RectangularShape) double1).getWidth() || (double) this.chartBufferHeight != ((RectangularShape) double1).getHeight())
        {
          this.chartBufferWidth = ByteCodeHelper.d2i(((RectangularShape) double1).getWidth());
          this.chartBufferHeight = ByteCodeHelper.d2i(((RectangularShape) double1).getHeight());
          this.chartBuffer = (Image) graphics2D.getDeviceConfiguration().createCompatibleImage(this.chartBufferWidth, this.chartBufferHeight, 3);
          this.refreshBuffer = true;
        }
        if (this.refreshBuffer)
        {
          this.refreshBuffer = false;
          Rectangle2D.Double double3 = new Rectangle2D.Double(0.0, 0.0, (double) this.chartBufferWidth, (double) this.chartBufferHeight);
          Graphics2D g2 = (Graphics2D) this.chartBuffer.getGraphics();
          Rectangle.__\u003Cclinit\u003E();
          Rectangle rectangle = new Rectangle(0, 0, this.chartBufferWidth, this.chartBufferHeight);
          g2.setPaint((Paint) ((Component) this).getBackground());
          g2.fill((Shape) rectangle);
          if (num1 != 0)
          {
            AffineTransform transform = g2.getTransform();
            AffineTransform scaleInstance = AffineTransform.getScaleInstance(this.scaleX, this.scaleY);
            g2.transform(scaleInstance);
            this.chart.draw(g2, (Rectangle2D) double2, this.anchor, this.info);
            g2.setTransform(transform);
          }
          else
            this.chart.draw(g2, (Rectangle2D) double3, this.anchor, this.info);
        }
        ((Graphics) graphics2D).drawImage(this.chartBuffer, (int) insets.left, (int) insets.top, (ImageObserver) this);
      }
      else
      {
        AffineTransform transform = graphics2D.getTransform();
        graphics2D.translate((int) insets.left, (int) insets.top);
        if (num1 != 0)
        {
          AffineTransform scaleInstance = AffineTransform.getScaleInstance(this.scaleX, this.scaleY);
          graphics2D.transform(scaleInstance);
        }
        this.chart.draw(graphics2D, (Rectangle2D) double2, this.anchor, this.info);
        graphics2D.setTransform(transform);
      }
      Iterator iterator = this.overlays.iterator();
      while (iterator.hasNext())
        ((Overlay) iterator.next()).paintOverlay(graphics2D, this);
      this.drawZoomRectangle(graphics2D, !this.useBuffer);
      ((Graphics) graphics2D).dispose();
      this.anchor = (Point2D) null;
      this.verticalTraceLine = (Line2D) null;
      this.horizontalTraceLine = (Line2D) null;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 69, (byte) 103, (byte) 108, (byte) 104, (byte) 103, (byte) 140, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void chartChanged(ChartChangeEvent @event)
    {
      this.refreshBuffer = true;
      Plot plot = this.chart.getPlot();
      if (plot is Zoomable)
        this.orientation = ((Zoomable) plot).getOrientation();
      ((Component) this).repaint();
    }

    public virtual void chartProgress(ChartProgressEvent @event)
    {
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 94, (byte) 231, (byte) 69, (byte) 106, (byte) 106, (byte) 104, (byte) 109, (byte) 173, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 141, (byte) 216, (byte) 5, (byte) 98, (byte) 103, (byte) 133, (byte) 109, (byte) 139, (byte) 109, (byte) 141, (byte) 109, (byte) 141, (byte) 109, (byte) 141, (byte) 109, (byte) 141, (byte) 109, (byte) 138, (byte) 109, (byte) 138, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent @event)
    {
      string actionCommand = @event.getActionCommand();
      double x = -1.0;
      double y = -1.0;
      if (this.zoomPoint != null)
      {
        x = this.zoomPoint.getX();
        y = this.zoomPoint.getY();
      }
      if (String.instancehelper_equals(actionCommand, (object) "PROPERTIES"))
        this.doEditChartProperties();
      else if (String.instancehelper_equals(actionCommand, (object) "COPY"))
        this.doCopy();
      else if (String.instancehelper_equals(actionCommand, (object) "SAVE"))
      {
        IOException ioException;
        try
        {
          this.doSaveAs();
          return;
        }
        catch (IOException ex)
        {
          int num = 1;
          ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        Throwable.instancehelper_printStackTrace((Exception) ioException);
      }
      else if (String.instancehelper_equals(actionCommand, (object) "PRINT"))
        this.createChartPrintJob();
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_IN_BOTH"))
        this.zoomInBoth(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_IN_DOMAIN"))
        this.zoomInDomain(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_IN_RANGE"))
        this.zoomInRange(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_OUT_BOTH"))
        this.zoomOutBoth(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_DOMAIN_BOTH"))
        this.zoomOutDomain(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_RANGE_BOTH"))
        this.zoomOutRange(x, y);
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_RESET_BOTH"))
        this.restoreAutoBounds();
      else if (String.instancehelper_equals(actionCommand, (object) "ZOOM_RESET_DOMAIN"))
      {
        this.restoreAutoDomainBounds();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "ZOOM_RESET_RANGE"))
          return;
        this.restoreAutoRangeBounds();
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 161, (byte) 104, (byte) 134, (byte) 108, (byte) 140, (byte) 108, (byte) 140, (byte) 108, (byte) 140, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseEntered(MouseEvent e)
    {
      if (this.ownToolTipDelaysActive)
        return;
      ToolTipManager toolTipManager = ToolTipManager.sharedInstance();
      this.originalToolTipInitialDelay = toolTipManager.getInitialDelay();
      toolTipManager.setInitialDelay(this.ownToolTipInitialDelay);
      this.originalToolTipReshowDelay = toolTipManager.getReshowDelay();
      toolTipManager.setReshowDelay(this.ownToolTipReshowDelay);
      this.originalToolTipDismissDelay = toolTipManager.getDismissDelay();
      toolTipManager.setDismissDelay(this.ownToolTipDismissDelay);
      this.ownToolTipDelaysActive = true;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 185, (byte) 136, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseExited(MouseEvent e)
    {
      if (!this.ownToolTipDelaysActive)
        return;
      ToolTipManager toolTipManager = ToolTipManager.sharedInstance();
      toolTipManager.setInitialDelay(this.originalToolTipInitialDelay);
      toolTipManager.setReshowDelay(this.originalToolTipReshowDelay);
      toolTipManager.setDismissDelay(this.originalToolTipDismissDelay);
      this.ownToolTipDelaysActive = false;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 204, (byte) 108, (byte) 103, (byte) 147, (byte) 107, (byte) 103, (byte) 112, (byte) 147, (byte) 145, (byte) 109, (byte) 109, (byte) 108, (byte) 237, (byte) 69, (byte) 130, (byte) 104, (byte) 116, (byte) 100, (byte) 220, (byte) 135, (byte) 104, (byte) 104, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mousePressed(MouseEvent e)
    {
      Plot plot = this.chart.getPlot();
      if ((((InputEvent) e).getModifiers() & this.panMask) == this.panMask)
      {
        if (!(plot is Pannable))
          return;
        Pannable pannable = (Pannable) plot;
        if (!pannable.isDomainPannable() && !pannable.isRangePannable())
          return;
        Rectangle2D screenDataArea = this.getScreenDataArea(e.getX(), e.getY());
        if (screenDataArea == null || !((RectangularShape) screenDataArea).contains((Point2D) e.getPoint()))
          return;
        this.panW = ((RectangularShape) screenDataArea).getWidth();
        this.panH = ((RectangularShape) screenDataArea).getHeight();
        this.panLast = e.getPoint();
        ((Component) this).setCursor(Cursor.getPredefinedCursor(13));
      }
      else
      {
        if (this.zoomRectangle != null)
          return;
        Rectangle2D screenDataArea = this.getScreenDataArea(e.getX(), e.getY());
        this.zoomPoint = screenDataArea == null ? (Point2D) null : this.getPointInRectangle(e.getX(), e.getY(), screenDataArea);
        if (!e.isPopupTrigger() || this.popup == null)
          return;
        this.displayPopupMenu(e.getX(), e.getY());
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 10, (byte) 117, (byte) 193, (byte) 107, (byte) 117, (byte) 117, (byte) 112, (byte) 129, (byte) 107, (byte) 106, (byte) 114, (byte) 113, (byte) 114, (byte) 110, (byte) 153, (byte) 219, (byte) 153, (byte) 185, (byte) 108, (byte) 116, (byte) 193, (byte) 104, (byte) 129, (byte) 237, (byte) 70, (byte) 104, (byte) 169, (byte) 98, (byte) 98, (byte) 109, (byte) 104, (byte) 170, (byte) 104, (byte) 136, (byte) 159, (byte) 9, (byte) 139, (byte) 117, (byte) 117, (byte) 191, (byte) 28, (byte) 101, (byte) 100, (byte) 117, (byte) 191, (byte) 18, (byte) 98, (byte) 100, (byte) 117, (byte) 255, (byte) 18, (byte) 70, (byte) 104, (byte) 232, (byte) 69, (byte) 137, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseDragged(MouseEvent e)
    {
      if (this.popup != null && ((Component) this.popup).isShowing())
        return;
      if (this.panLast != null)
      {
        double num1 = (double) e.getX() - this.panLast.getX();
        double num2 = (double) e.getY() - this.panLast.getY();
        if (num1 == 0.0 && num2 == 0.0)
          return;
        double d1 = -num1 / this.panW;
        double d2 = num2 / this.panH;
        int num3 = this.chart.getPlot().isNotify() ? 1 : 0;
        this.chart.getPlot().setNotify(false);
        Pannable pannable = (Pannable) this.chart.getPlot();
        if (pannable.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          pannable.panDomainAxes(d1, this.info.getPlotInfo(), (Point2D) this.panLast);
          pannable.panRangeAxes(d2, this.info.getPlotInfo(), (Point2D) this.panLast);
        }
        else
        {
          pannable.panDomainAxes(d2, this.info.getPlotInfo(), (Point2D) this.panLast);
          pannable.panRangeAxes(d1, this.info.getPlotInfo(), (Point2D) this.panLast);
        }
        this.panLast = e.getPoint();
        this.chart.getPlot().setNotify(num3 != 0);
      }
      else
      {
        if (this.zoomPoint == null)
          return;
        Graphics2D graphics2D = (Graphics2D) ((JComponent) this).getGraphics();
        if (!this.useBuffer)
          this.drawZoomRectangle(graphics2D, true);
        int num1;
        int num2;
        if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          num1 = this.rangeZoomable ? 1 : 0;
          num2 = this.domainZoomable ? 1 : 0;
        }
        else
        {
          num1 = this.domainZoomable ? 1 : 0;
          num2 = this.rangeZoomable ? 1 : 0;
        }
        Rectangle2D screenDataArea = this.getScreenDataArea(ByteCodeHelper.d2i(this.zoomPoint.getX()), ByteCodeHelper.d2i(this.zoomPoint.getY()));
        if (num1 != 0 && num2 != 0)
          this.zoomRectangle = (Rectangle2D) new Rectangle2D.Double(this.zoomPoint.getX(), this.zoomPoint.getY(), Math.min((double) e.getX(), ((RectangularShape) screenDataArea).getMaxX()) - this.zoomPoint.getX(), Math.min((double) e.getY(), ((RectangularShape) screenDataArea).getMaxY()) - this.zoomPoint.getY());
        else if (num1 != 0)
        {
          double num3 = Math.min((double) e.getX(), ((RectangularShape) screenDataArea).getMaxX());
          this.zoomRectangle = (Rectangle2D) new Rectangle2D.Double(this.zoomPoint.getX(), ((RectangularShape) screenDataArea).getMinY(), num3 - this.zoomPoint.getX(), ((RectangularShape) screenDataArea).getHeight());
        }
        else if (num2 != 0)
        {
          double num3 = Math.min((double) e.getY(), ((RectangularShape) screenDataArea).getMaxY());
          this.zoomRectangle = (Rectangle2D) new Rectangle2D.Double(((RectangularShape) screenDataArea).getMinX(), this.zoomPoint.getY(), ((RectangularShape) screenDataArea).getWidth(), num3 - this.zoomPoint.getY());
        }
        if (this.useBuffer)
          ((Component) this).repaint();
        else
          this.drawZoomRectangle(graphics2D, true);
        ((Graphics) graphics2D).dispose();
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 114, (byte) 104, (byte) 103, (byte) 176, (byte) 107, (byte) 98, (byte) 98, (byte) 109, (byte) 103, (byte) 169, (byte) 103, (byte) 167, (byte) 159, (byte) 10, (byte) 159, (byte) 10, (byte) 105, (byte) 159, (byte) 15, (byte) 203, (byte) 191, (byte) 9, (byte) 106, (byte) 202, (byte) 99, (byte) 110, (byte) 106, (byte) 159, (byte) 2, (byte) 143, (byte) 99, (byte) 106, (byte) 110, (byte) 106, (byte) 223, (byte) 4, (byte) 110, (byte) 110, (byte) 159, (byte) 2, (byte) 191, (byte) 2, (byte) 111, (byte) 136, (byte) 103, (byte) 201, (byte) 109, (byte) 104, (byte) 168, (byte) 137, (byte) 103, (byte) 103, (byte) 167, (byte) 130, (byte) 104, (byte) 104, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseReleased(MouseEvent e)
    {
      if (this.panLast != null)
      {
        this.panLast = (Point) null;
        ((Component) this).setCursor(Cursor.getDefaultCursor());
      }
      else if (this.zoomRectangle != null)
      {
        int num1;
        int num2;
        if (this.orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          num1 = this.rangeZoomable ? 1 : 0;
          num2 = this.domainZoomable ? 1 : 0;
        }
        else
        {
          num1 = this.domainZoomable ? 1 : 0;
          num2 = this.rangeZoomable ? 1 : 0;
        }
        if ((num1 == 0 || Math.abs((double) e.getX() - this.zoomPoint.getX()) < (double) this.zoomTriggerDistance ? 0 : 1) != 0 || (num2 == 0 || Math.abs((double) e.getY() - this.zoomPoint.getY()) < (double) this.zoomTriggerDistance ? 0 : 1) != 0)
        {
          if (num1 != 0 && (double) e.getX() < this.zoomPoint.getX() || num2 != 0 && (double) e.getY() < this.zoomPoint.getY())
          {
            this.restoreAutoBounds();
          }
          else
          {
            Rectangle2D screenDataArea = this.getScreenDataArea(ByteCodeHelper.d2i(this.zoomPoint.getX()), ByteCodeHelper.d2i(this.zoomPoint.getY()));
            double maxX = ((RectangularShape) screenDataArea).getMaxX();
            double maxY = ((RectangularShape) screenDataArea).getMaxY();
            double num3;
            double num4;
            double num5;
            double num6;
            if (num2 == 0)
            {
              num3 = this.zoomPoint.getX();
              num4 = ((RectangularShape) screenDataArea).getMinY();
              num5 = Math.min(((RectangularShape) this.zoomRectangle).getWidth(), maxX - this.zoomPoint.getX());
              num6 = ((RectangularShape) screenDataArea).getHeight();
            }
            else if (num1 == 0)
            {
              num3 = ((RectangularShape) screenDataArea).getMinX();
              num4 = this.zoomPoint.getY();
              num5 = ((RectangularShape) screenDataArea).getWidth();
              num6 = Math.min(((RectangularShape) this.zoomRectangle).getHeight(), maxY - this.zoomPoint.getY());
            }
            else
            {
              num3 = this.zoomPoint.getX();
              num4 = this.zoomPoint.getY();
              num5 = Math.min(((RectangularShape) this.zoomRectangle).getWidth(), maxX - this.zoomPoint.getX());
              num6 = Math.min(((RectangularShape) this.zoomRectangle).getHeight(), maxY - this.zoomPoint.getY());
            }
            this.zoom((Rectangle2D) new Rectangle2D.Double(num3, num4, num5, num6));
          }
          this.zoomPoint = (Point2D) null;
          this.zoomRectangle = (Rectangle2D) null;
        }
        else
        {
          Graphics2D graphics2D = (Graphics2D) ((JComponent) this).getGraphics();
          if (this.useBuffer)
            ((Component) this).repaint();
          else
            this.drawZoomRectangle(graphics2D, true);
          ((Graphics) graphics2D).dispose();
          this.zoomPoint = (Point2D) null;
          this.zoomRectangle = (Rectangle2D) null;
        }
      }
      else
      {
        if (!e.isPopupTrigger() || this.popup == null)
          return;
        this.displayPopupMenu(e.getX(), e.getY());
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 210, (byte) 103, (byte) 123, (byte) 155, (byte) 111, (byte) 104, (byte) 129, (byte) 140, (byte) 159, (byte) 11, (byte) 100, (byte) 161, (byte) 99, (byte) 104, (byte) 109, (byte) 100, (byte) 173, (byte) 144, (byte) 107, (byte) 48, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseClicked(MouseEvent @event)
    {
      Insets insets = ((JComponent) this).getInsets();
      int num1 = ByteCodeHelper.d2i((double) (@event.getX() - insets.left) / this.scaleX);
      int num2 = ByteCodeHelper.d2i((double) (@event.getY() - insets.top) / this.scaleY);
      this.anchor = (Point2D) new Point2D.Double((double) num1, (double) num2);
      if (this.chart == null)
        return;
      this.chart.setNotify(true);
      EventListener[] listeners = this.chartMouseListeners.getListeners(ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener = ChartPanel.class\u0024("org.jfree.chart.ChartMouseListener")));
      if (listeners.Length == 0)
        return;
      ChartEntity entity = (ChartEntity) null;
      if (this.info != null)
      {
        EntityCollection entityCollection = this.info.getEntityCollection();
        if (entityCollection != null)
          entity = entityCollection.getEntity((double) num1, (double) num2);
      }
      ChartMouseEvent cme = new ChartMouseEvent(this.getChart(), @event, entity);
      int index = listeners.Length - 1;
      while (index >= 0)
      {
        ((ChartMouseListener) listeners[index]).chartMouseClicked(cme);
        index += -1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 247, (byte) 108, (byte) 104, (byte) 141, (byte) 104, (byte) 141, (byte) 134, (byte) 159, (byte) 11, (byte) 100, (byte) 129, (byte) 103, (byte) 123, (byte) 156, (byte) 99, (byte) 104, (byte) 109, (byte) 100, (byte) 238, (byte) 70, (byte) 104, (byte) 112, (byte) 107, (byte) 48, (byte) 232, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseMoved(MouseEvent e)
    {
      Graphics2D graphics2D = (Graphics2D) ((JComponent) this).getGraphics();
      if (this.horizontalAxisTrace)
        this.drawHorizontalAxisTrace(graphics2D, e.getX());
      if (this.verticalAxisTrace)
        this.drawVerticalAxisTrace(graphics2D, e.getY());
      ((Graphics) graphics2D).dispose();
      EventListener[] listeners = this.chartMouseListeners.getListeners(ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener = ChartPanel.class\u0024("org.jfree.chart.ChartMouseListener")));
      if (listeners.Length == 0)
        return;
      Insets insets = ((JComponent) this).getInsets();
      int num1 = ByteCodeHelper.d2i((double) (e.getX() - insets.left) / this.scaleX);
      int num2 = ByteCodeHelper.d2i((double) (e.getY() - insets.top) / this.scaleY);
      ChartEntity entity = (ChartEntity) null;
      if (this.info != null)
      {
        EntityCollection entityCollection = this.info.getEntityCollection();
        if (entityCollection != null)
          entity = entityCollection.getEntity((double) num1, (double) num2);
      }
      if (this.chart == null)
        return;
      ChartMouseEvent cme = new ChartMouseEvent(this.getChart(), e, entity);
      int index = listeners.Length - 1;
      while (index >= 0)
      {
        ((ChartMouseListener) listeners[index]).chartMouseMoved(cme);
        index += -1;
      }
    }

    public virtual int getInitialDelay()
    {
      return this.ownToolTipInitialDelay;
    }

    public virtual int getReshowDelay()
    {
      return this.ownToolTipReshowDelay;
    }

    public virtual int getDismissDelay()
    {
      return this.ownToolTipDismissDelay;
    }

    public virtual void setInitialDelay(int delay)
    {
      this.ownToolTipInitialDelay = delay;
    }

    public virtual void setReshowDelay(int delay)
    {
      this.ownToolTipReshowDelay = delay;
    }

    public virtual void setDismissDelay(int delay)
    {
      this.ownToolTipDismissDelay = delay;
    }

    public virtual double getZoomInFactor()
    {
      return this.zoomInFactor;
    }

    public virtual void setZoomInFactor(double factor)
    {
      this.zoomInFactor = factor;
    }

    public virtual double getZoomOutFactor()
    {
      return this.zoomOutFactor;
    }

    public virtual void setZoomOutFactor(double factor)
    {
      this.zoomOutFactor = factor;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 104, (byte) 99, (byte) 130, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int print(Graphics g, PageFormat pf, int pageIndex)
    {
      if (pageIndex != 0)
        return 1;
      this.chart.draw((Graphics2D) g, (Rectangle2D) new Rectangle2D.Double(pf.getImageableX(), pf.getImageableY(), pf.getImageableWidth(), pf.getImageableHeight()), this.anchor, (ChartRenderingInfo) null);
      return 0;
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 124, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChartMouseListener(ChartMouseListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.chartMouseListeners.add(ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener = ChartPanel.class\u0024("org.jfree.chart.ChartMouseListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 137, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChartMouseListener(ChartMouseListener listener)
    {
      this.chartMouseListeners.remove(ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener = ChartPanel.class\u0024("org.jfree.chart.ChartMouseListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 170, (byte) 149, (byte) 159, (byte) 2, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual EventListener[] getListeners(Class listenerType)
    {
      if (listenerType == (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener != null ? ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener : (ChartPanel.class\u0024org\u0024jfree\u0024chart\u0024ChartMouseListener = ChartPanel.class\u0024("org.jfree.chart.ChartMouseListener"))))
        return this.chartMouseListeners.getListeners(listenerType);
      else
        return ((JComponent) this).getListeners(listenerType);
    }

    [LineNumberTable((ushort) 2844)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JPopupMenu createPopupMenu(bool properties, bool save, bool print, bool zoom)
    {
      return this.createPopupMenu(properties, false, save, print, zoom);
    }

    [LineNumberTable(new byte[] {(byte) 171, (byte) 142, (byte) 104, (byte) 139, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateUI()
    {
      if (this.popup != null)
        SwingUtilities.updateComponentTreeUI((Component) this.popup);
      base.updateUI();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 171, (byte) 156, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.zoomFillPaint, obj0);
      SerialUtilities.writePaint(this.zoomOutlinePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 171, (byte) 171, (byte) 102, (byte) 108, (byte) 172, (byte) 171, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.zoomFillPaint = SerialUtilities.readPaint(obj0);
      this.zoomOutlinePaint = SerialUtilities.readPaint(obj0);
      this.chartMouseListeners = new EventListenerList();
      if (this.chart == null)
        return;
      this.chart.addChangeListener((ChartChangeListener) this);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ChartPanel.__\u003CcallerID\u003E == null)
        ChartPanel.__\u003CcallerID\u003E = (CallerID) new ChartPanel.__\u003CCallerID\u003E();
      return ChartPanel.__\u003CcallerID\u003E;
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
