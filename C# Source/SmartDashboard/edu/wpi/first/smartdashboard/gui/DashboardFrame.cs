// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardFrame
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard;
using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.livewindow.elements;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.xml;
using edu.wpi.first.wpilibj.tables;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.io;
using java.lang;
using java.util;
using java.util.logging;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public class DashboardFrame : JFrame
  {
    private const int MENU_HEADER = 10;
    [Modifiers]
    private static Dimension NETBOOK_SIZE;
    [Modifiers]
    private static Dimension MINIMUM_SIZE;
    [Modifiers]
    private DashboardPrefs prefs;
    [Modifiers]
    private DashboardPanel smartDashboardPanel;
    [Modifiers]
    private DashboardPanel liveWindowPanel;
    [Modifiers]
    private MainPanel mainPanel;
    private DashboardFrame.DisplayMode displayMode;
    [Modifiers]
    private JMenuBar menuBar;
    [Modifiers]
    private PropertyEditor propEditor;
    private bool shouldHideMenu;
    [Modifiers]
    private static string LW_SAVE;
    [Modifiers]
    private LogToCSV logger;
    private static DashboardFrame INSTANCE;
    [Modifiers]
    internal static bool \u0024assertionsDisabled;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 133, (byte) 245, (byte) 73, (byte) 148, (byte) 244, (byte) 84, (byte) 223, (byte) 39})]
    static DashboardFrame()
    {
      JFrame.__\u003Cclinit\u003E();
      DashboardFrame.\u0024assertionsDisabled = !((Class) ClassLiteral<DashboardFrame>.Value).desiredAssertionStatus();
      DashboardFrame.NETBOOK_SIZE = new Dimension(1024, 400);
      DashboardFrame.MINIMUM_SIZE = new Dimension(300, 200);
      DashboardFrame.LW_SAVE = new StringBuilder().append("_").append(Robot.getLiveWindow().getSubTable("~STATUS~").getString("Robot", "LiveWindow")).append(".xml").toString();
      DashboardFrame.INSTANCE = (DashboardFrame) null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 98, (byte) 237, (byte) 35, (byte) 236, (byte) 69, (byte) 235, (byte) 70, (byte) 223, (byte) 1, (byte) 236, (byte) 80, (byte) 171, (byte) 118, (byte) 112, (byte) 118, (byte) 112, (byte) 127, (byte) 20, (byte) 123, (byte) 123, (byte) 107, (byte) 119, (byte) 140, (byte) 104, (byte) 145, (byte) 177, (byte) 231, (byte) 82, (byte) 108, (byte) 172, (byte) 99, (byte) 107, (byte) 103, (byte) 104, (byte) 137, (byte) 171, (byte) 135, (byte) 127, (byte) 27, (byte) 223, (byte) 17, (byte) 236, (byte) 73, (byte) 236, (byte) 83, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DashboardFrame(bool competition)
    {
      int num = competition ? 1 : 0;
      base.\u002Ector("SmartDashboard - ");
      DashboardFrame dashboardFrame = this;
      this.prefs = new DashboardPrefs(this);
      this.displayMode = DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard;
      this.shouldHideMenu = ((Boolean) this.prefs.__\u003C\u003EhideMenu.getValue()).booleanValue();
      this.logger = new LogToCSV(this);
      this.setLayout((LayoutManager) new BorderLayout());
      DashboardPanel.__\u003Cclinit\u003E();
      this.smartDashboardPanel = new DashboardPanel(this, Robot.getTable());
      ((Component) this.smartDashboardPanel).setName("SmartDashboard");
      DashboardPanel.__\u003Cclinit\u003E();
      this.liveWindowPanel = new DashboardPanel(this, Robot.getLiveWindow());
      ((Component) this.liveWindowPanel).setName("LiveWindow");
      MainPanel.__\u003Cclinit\u003E();
      CardLayout cardLayout = new CardLayout();
      DashboardPanel defaultPanel = this.smartDashboardPanel;
      DashboardPanel[] dashboardPanelArray = new DashboardPanel[2];
      int index1 = 0;
      DashboardPanel dashboardPanel1 = this.liveWindowPanel;
      dashboardPanelArray[index1] = dashboardPanel1;
      int index2 = 1;
      DashboardPanel dashboardPanel2 = this.smartDashboardPanel;
      dashboardPanelArray[index2] = dashboardPanel2;
      this.mainPanel = new MainPanel((LayoutManager) cardLayout, defaultPanel, dashboardPanelArray);
      ((Container) this.mainPanel).add((Component) this.smartDashboardPanel, (object) DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard.toString());
      ((Container) this.mainPanel).add((Component) this.liveWindowPanel, (object) DashboardFrame.DisplayMode.__\u003C\u003ELiveWindow.toString());
      this.setDisplayMode(DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard);
      DashboardMenu.__\u003Cclinit\u003E();
      this.menuBar = (JMenuBar) new DashboardMenu(this, this.mainPanel);
      this.propEditor = new PropertyEditor((JFrame) this);
      if (!this.shouldHideMenu)
        ((Container) this).add((Component) this.menuBar, (object) "North");
      ((Container) this).add((Component) this.mainPanel, (object) "Center");
      DashboardFrame\u00241 dashboardFrame1 = new DashboardFrame\u00241(this);
      this.smartDashboardPanel.addMouseListener((MouseListener) dashboardFrame1);
      this.smartDashboardPanel.addMouseMotionListener((MouseMotionListener) dashboardFrame1);
      if (num != 0)
      {
        ((Component) this).setPreferredSize(DashboardFrame.NETBOOK_SIZE);
        ((Frame) this).setUndecorated(true);
        ((Window) this).setLocation(0, 0);
        ((Frame) this).setResizable(false);
      }
      else
      {
        ((Window) this).setMinimumSize(DashboardFrame.MINIMUM_SIZE);
        this.setDefaultCloseOperation(0);
        Dimension.__\u003Cclinit\u003E();
        ((Component) this).setPreferredSize(new Dimension(this.prefs.__\u003C\u003Ewidth.getValue().intValue(), this.prefs.__\u003C\u003Eheight.getValue().intValue()));
        ((Window) this).setLocation(this.prefs.__\u003C\u003Ex.getValue().intValue(), this.prefs.__\u003C\u003Ey.getValue().intValue());
      }
      ((Window) this).addWindowListener((WindowListener) new DashboardFrame\u00242(this));
      ((Component) this).addComponentListener((ComponentListener) new DashboardFrame\u00243(this));
      DashboardFrame.INSTANCE = this;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DashboardFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual DashboardPrefs getPrefs()
    {
      return this.prefs;
    }

    [Modifiers]
    [LineNumberTable((ushort) 30)]
    internal static bool access\u0024000([In] DashboardFrame obj0)
    {
      return obj0.shouldHideMenu;
    }

    [Modifiers]
    [LineNumberTable((ushort) 30)]
    internal static JMenuBar access\u0024100([In] DashboardFrame obj0)
    {
      return obj0.menuBar;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 156, (byte) 146, (byte) 155, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void exit()
    {
      string[] strArray = new string[1];
      int index = 0;
      string str1 = "Do you wish to save this layout?";
      strArray[index] = str1;
      string str2 = "Save before quitting?";
      int num1 = 1;
      int num2 = 2;
      int num3 = JOptionPane.showConfirmDialog((Component) this, (object) strArray, str2, num1, num2);
      int num4 = 0;
      if (num3 == num4)
      {
        this.save((string) this.prefs.__\u003C\u003EsaveFile.getValue());
      }
      else
      {
        int num5 = 1;
        if (num3 != num5)
          return;
      }
      System.exit(0);
    }

    [Modifiers]
    [LineNumberTable((ushort) 30)]
    internal static DashboardPrefs access\u0024200([In] DashboardFrame obj0)
    {
      return obj0.prefs;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 103, (byte) 118, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void setDisplayMode(DashboardFrame.DisplayMode mode)
    {
      this.displayMode = mode;
      ((CardLayout) ((Container) this.mainPanel).getLayout()).show((Container) this.mainPanel, mode.toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 127, (byte) 4, (byte) 106, (byte) 125, (byte) 99, (byte) 159, (byte) 15, (byte) 145, (byte) 107, (byte) 127, (byte) 10, (byte) 127, (byte) 37, (byte) 127, (byte) 6, (byte) 109, (byte) 109, (byte) 109, (byte) 171, (byte) 140, (byte) 104, (byte) 106, (byte) 141, (byte) 106, (byte) 173, (byte) 127, (byte) 10, (byte) 115, (byte) 223, (byte) 6, (byte) 99, (byte) 136, (byte) 134, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void saveElements([In] SmartDashboardXMLWriter obj0, [In] DashboardPanel obj1)
    {
      Iterator iterator1 = obj1.getElements().iterator();
      while (iterator1.hasNext())
      {
        DisplayElement displayElement = (DisplayElement) iterator1.next();
        int num = displayElement is Widget ? 1 : 0;
        if (!DashboardFrame.\u0024assertionsDisabled && num == 0 && !(displayElement is StaticWidget))
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
        else
        {
          if (num != 0)
            obj0.beginWidget(((Widget) displayElement).getFieldName(), ((Widget) displayElement).getType().getName(), Object.instancehelper_getClass((object) displayElement).getName());
          else
            obj0.beginStaticWidget(Object.instancehelper_getClass((object) displayElement).getName());
          if (displayElement is LWSubsystem)
          {
            Iterator iterator2 = ((LWSubsystem) displayElement).getWidgets().iterator();
            while (iterator2.hasNext())
            {
              Widget widget = (Widget) iterator2.next();
              System.get_out().println(new StringBuilder().append("   Saving ").append(((Widget) displayElement).getFieldName()).append("|").append(widget.getFieldName()).toString());
              obj0.addSubWidget(widget.getFieldName(), widget.getType().getName(), Object.instancehelper_getClass((object) widget).getName());
              obj0.addSubWidgetLocation(((Component) widget).getLocation());
              obj0.addSubWudgetHeight(((JComponent) widget).getHeight());
              obj0.addSubWidgetWidth(((JComponent) widget).getWidth());
              obj0.endSubWidget();
            }
          }
          obj0.addLocation(((Component) displayElement).getLocation());
          Dimension savedSize = displayElement.getSavedSize();
          if (savedSize.width > 0)
            obj0.addWidth((int) savedSize.width);
          if (savedSize.height > 0)
            obj0.addHeight((int) savedSize.height);
          Iterator iterator3 = displayElement.getProperties().entrySet().iterator();
          while (iterator3.hasNext())
          {
            Map.Entry entry = (Map.Entry) iterator3.next();
            if (!((Property) entry.getValue()).isDefault())
              obj0.addProperty((string) entry.getKey(), ((Property) entry.getValue()).getSaveValue());
          }
          if (num != 0)
            obj0.endWidget();
          else
            obj0.endStaticWidget();
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 127, (byte) 5, (byte) 135, (byte) 102, (byte) 109, (byte) 134, (byte) 102, (byte) 109, (byte) 134, (byte) 127, (byte) 6, (byte) 169, (byte) 189, (byte) 2, (byte) 98, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void save(string path)
    {
      Exception exception1;
      try
      {
        System.get_out().println(new StringBuilder().append("Saving to:\t").append(path).toString());
        SmartDashboardXMLWriter dashboardXmlWriter = new SmartDashboardXMLWriter(path);
        dashboardXmlWriter.beginSmartDashboard();
        this.saveElements(dashboardXmlWriter, this.smartDashboardPanel);
        dashboardXmlWriter.endSmartDashboard();
        dashboardXmlWriter.beginLiveWindow();
        this.saveElements(dashboardXmlWriter, this.liveWindowPanel);
        dashboardXmlWriter.endLiveWindow();
        Iterator iterator = this.smartDashboardPanel.getHiddenFields().iterator();
        while (iterator.hasNext())
        {
          string field = (string) iterator.next();
          dashboardXmlWriter.addHiddenField(field);
        }
        dashboardXmlWriter.close();
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Exception exception2 = exception1;
      Logger.getLogger(((Class) ClassLiteral<DashboardFrame>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) exception2);
    }

    public static DashboardFrame getInstance()
    {
      return DashboardFrame.INSTANCE;
    }

    public virtual PropertyEditor getPropertyEditor()
    {
      return this.propEditor;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 66, (byte) 105, (byte) 103, (byte) 104, (byte) 142, (byte) 145, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShouldHideMenu(bool shouldHide)
    {
      int num = shouldHide ? 1 : 0;
      if ((this.shouldHideMenu ? 1 : 0) == num)
        return;
      this.shouldHideMenu = num != 0;
      if (this.shouldHideMenu)
        this.remove((Component) this.menuBar);
      else
        ((Container) this).add((Component) this.menuBar, (object) "North");
      ((Container) this).validate();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 135, (byte) 159, (byte) 5, (byte) 103, (byte) 110, (byte) 111, (byte) 111, (byte) 104, (byte) 108, (byte) 105, (byte) 98, (byte) 115, (byte) 115, (byte) 105, (byte) 112, (byte) 159, (byte) 0, (byte) 98, (byte) 159, (byte) 3, (byte) 107, (byte) 105, (byte) 243, (byte) 46, (byte) 233, (byte) 88, (byte) 98, (byte) 127, (byte) 13, (byte) 127, (byte) 21, (byte) 110, (byte) 100, (byte) 98, (byte) 115, (byte) 115, (byte) 105, (byte) 112, (byte) 159, (byte) 0, (byte) 98, (byte) 159, (byte) 4, (byte) 127, (byte) 15, (byte) 127, (byte) 21, (byte) 110, (byte) 98, (byte) 127, (byte) 0, (byte) 105, (byte) 105, (byte) 125, (byte) 110, (byte) 101, (byte) 165, (byte) 127, (byte) 5, (byte) 175, (byte) 109, (byte) 127, (byte) 10, (byte) 117, (byte) 111, (byte) 130, (byte) 177, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void load(string path)
    {
      try
      {
        SmartDashboardXMLReader dashboardXmlReader = new SmartDashboardXMLReader(path);
        System.get_out().println(new StringBuilder().append("\nLoading from \t").append(path).toString());
        List xmlWidgets = dashboardXmlReader.getXMLWidgets();
        int num = xmlWidgets.size();
        while (num > 0)
        {
          System.get_out().println("Loading SmartDashboard widgets....");
          XMLWidget xmlWidget = (XMLWidget) xmlWidgets.get(num - 1);
          DisplayElement element1 = xmlWidget.convertToDisplayElement();
          if (element1 is Widget)
          {
            Widget element2 = (Widget) element1;
            if (Robot.getTable().containsKey(element2.getFieldName()))
            {
              object obj = Robot.getTable().getValue(element2.getFieldName());
              DataType type = DataType.getType(obj);
              if (DisplayElementRegistry.supportsType(Object.instancehelper_getClass((object) element2), type))
                this.smartDashboardPanel.setField(element2.getFieldName(), element2, type, obj, element2.getSavedLocation());
            }
            else
              this.smartDashboardPanel.setField(element2.getFieldName(), element2, xmlWidget.getType(), (object) null, element2.getSavedLocation());
          }
          else if (element1 is StaticWidget)
            this.smartDashboardPanel.addElement(element1, xmlWidget.getLocation());
          num += -1;
        }
        Iterator iterator1 = dashboardXmlReader.getSubsystems().keySet().iterator();
label_11:
        while (iterator1.hasNext())
        {
          XMLWidget subsystem1 = (XMLWidget) iterator1.next();
          System.get_out().println(new StringBuilder().append("\nLoading \"").append(subsystem1.getField()).append("\"").toString());
          LWSubsystem lwSubsystem = (LWSubsystem) subsystem1.convertToDisplayElement();
          LWSubsystem subsystem2 = lwSubsystem;
          if (Robot.getLiveWindow().containsKey(lwSubsystem.getFieldName()))
          {
            object obj = Robot.getTable().getValue(lwSubsystem.getFieldName());
            DataType type = DataType.getType(obj);
            if (DisplayElementRegistry.supportsType(Object.instancehelper_getClass((object) lwSubsystem), type))
              this.liveWindowPanel.setField(lwSubsystem.getFieldName(), (Widget) lwSubsystem, type, obj, lwSubsystem.getSavedLocation());
          }
          else
            this.liveWindowPanel.setField(lwSubsystem.getFieldName(), (Widget) lwSubsystem, lwSubsystem.getType(), (object) null, lwSubsystem.getSavedLocation());
          Iterator iterator2 = dashboardXmlReader.getSubwidgetMap(subsystem1).values().iterator();
          while (true)
          {
            if (iterator2.hasNext())
            {
              XMLWidget xmlWidget = (XMLWidget) iterator2.next();
              System.get_out().println(new StringBuilder().append("Adding subcomponent \"").append(xmlWidget.getField()).append("\"").toString());
              AbstractTableWidget abstractTableWidget = (AbstractTableWidget) xmlWidget.convertToDisplayElement();
              ITable subTable = Robot.getLiveWindow().getSubTable(subsystem2.getFieldName()).getSubTable(abstractTableWidget.getFieldName());
              DataType type = DataType.getType((object) subTable);
              subsystem2.addWidget((Widget) abstractTableWidget);
              abstractTableWidget.setField(abstractTableWidget.getFieldName(), (Widget) abstractTableWidget, type, (object) subTable, subsystem2, abstractTableWidget.getSavedLocation());
              ((Component) subsystem2).setSize(((JComponent) subsystem2).getPreferredSize());
            }
            else
              goto label_11;
          }
        }
        Iterator iterator3 = dashboardXmlReader.getHiddenFields().iterator();
        while (iterator3.hasNext())
          this.smartDashboardPanel.removeField((string) iterator3.next());
        Map properties = this.prefs.getProperties();
        Iterator iterator4 = dashboardXmlReader.getProperties().entrySet().iterator();
        while (iterator4.hasNext())
        {
          Map.Entry entry = (Map.Entry) iterator4.next();
          ((Property) properties.get(entry.getKey())).setValue(entry.getValue());
        }
        ((Component) this).repaint();
      }
      catch (FileNotFoundException ex)
      {
      }
    }

    public virtual LogToCSV getLogger()
    {
      return this.logger;
    }

    [InnerClass]
    [Signature("Ljava/lang/Enum<Ledu/wpi/first/smartdashboard/gui/DashboardFrame$DisplayMode;>;")]
    [SourceFile("DashboardFrame.java")]
    [Modifiers]
    [Serializable]
    public sealed class DisplayMode : Enum
    {
      [Modifiers]
      internal static DashboardFrame.DisplayMode __\u003C\u003ESmartDashboard = new DashboardFrame.DisplayMode("SmartDashboard", 0);
      [Modifiers]
      internal static DashboardFrame.DisplayMode __\u003C\u003ELiveWindow = new DashboardFrame.DisplayMode("LiveWindow", 1);
      [Modifiers]
      private static DashboardFrame.DisplayMode[] \u0024VALUES;

      [Modifiers]
      public static DashboardFrame.DisplayMode SmartDashboard
      {
        [HideFromJava] get
        {
          return DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard;
        }
      }

      [Modifiers]
      public static DashboardFrame.DisplayMode LiveWindow
      {
        [HideFromJava] get
        {
          return DashboardFrame.DisplayMode.__\u003C\u003ELiveWindow;
        }
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 112, (byte) 16})]
      static DisplayMode()
      {
        DashboardFrame.DisplayMode[] displayModeArray = new DashboardFrame.DisplayMode[2];
        int index1 = 0;
        DashboardFrame.DisplayMode displayMode1 = DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard;
        displayModeArray[index1] = displayMode1;
        int index2 = 1;
        DashboardFrame.DisplayMode displayMode2 = DashboardFrame.DisplayMode.__\u003C\u003ELiveWindow;
        displayModeArray[index2] = displayMode2;
        DashboardFrame.DisplayMode.\u0024VALUES = displayModeArray;
      }

      [Signature("()V")]
      [LineNumberTable((ushort) 43)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private DisplayMode([In] string obj0, [In] int obj1)
      {
        base.\u002Ector(obj0, obj1);
        GC.KeepAlive((object) this);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable((ushort) 43)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static DashboardFrame.DisplayMode[] values()
      {
        return (DashboardFrame.DisplayMode[]) DashboardFrame.DisplayMode.\u0024VALUES.Clone();
      }

      [LineNumberTable((ushort) 43)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static DashboardFrame.DisplayMode valueOf(string name)
      {
        return (DashboardFrame.DisplayMode) Enum.valueOf((Class) ClassLiteral<DashboardFrame.DisplayMode>.Value, name);
      }

      [HideFromJava]
      [Serializable]
      public enum __Enum
      {
        SmartDashboard,
        LiveWindow,
      }
    }
  }
}
