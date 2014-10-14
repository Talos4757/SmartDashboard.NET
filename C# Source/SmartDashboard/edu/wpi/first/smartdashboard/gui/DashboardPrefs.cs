// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardPrefs
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.robot;
using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using java.util.prefs;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [Implements(new string[] {"edu.wpi.first.smartdashboard.properties.PropertyHolder"})]
  public class DashboardPrefs : Object, PropertyHolder
  {
    [Modifiers]
    private static File USER_HOME;
    [Modifiers]
    private static File USER_SMARTDASHBOARD_HOME;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    private Map properties;
    internal IntegerProperty __\u003C\u003Eteam;
    internal BooleanProperty __\u003C\u003EhideMenu;
    internal BooleanProperty __\u003C\u003EautoShowWidgets;
    internal IntegerListProperty __\u003C\u003Egrid_widths;
    internal IntegerListProperty __\u003C\u003Egrid_heights;
    internal IntegerProperty __\u003C\u003Ex;
    internal IntegerProperty __\u003C\u003Ey;
    internal IntegerProperty __\u003C\u003Ewidth;
    internal IntegerProperty __\u003C\u003Eheight;
    internal FileProperty __\u003C\u003EsaveFile;
    internal BooleanProperty __\u003C\u003ElogToCSV;
    internal FileProperty __\u003C\u003EcsvFile;
    private Preferences node;
    [Modifiers]
    private DashboardFrame frame;

    [Modifiers]
    public IntegerProperty team
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eteam;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eteam = value;
      }
    }

    [Modifiers]
    public BooleanProperty hideMenu
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EhideMenu;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EhideMenu = value;
      }
    }

    [Modifiers]
    public BooleanProperty autoShowWidgets
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EautoShowWidgets;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EautoShowWidgets = value;
      }
    }

    [Modifiers]
    public IntegerListProperty grid_widths
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Egrid_widths;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Egrid_widths = value;
      }
    }

    [Modifiers]
    public IntegerListProperty grid_heights
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Egrid_heights;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Egrid_heights = value;
      }
    }

    [Modifiers]
    public IntegerProperty x
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ex;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ex = value;
      }
    }

    [Modifiers]
    public IntegerProperty y
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ey;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ey = value;
      }
    }

    [Modifiers]
    public IntegerProperty width
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ewidth;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ewidth = value;
      }
    }

    [Modifiers]
    public IntegerProperty height
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eheight;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eheight = value;
      }
    }

    [Modifiers]
    public FileProperty saveFile
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EsaveFile;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EsaveFile = value;
      }
    }

    [Modifiers]
    public BooleanProperty logToCSV
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003ElogToCSV;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003ElogToCSV = value;
      }
    }

    [Modifiers]
    public FileProperty csvFile
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EcsvFile;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EcsvFile = value;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 121, (byte) 153, (byte) 108, (byte) 139})]
    static DashboardPrefs()
    {
      File.__\u003Cclinit\u003E();
      DashboardPrefs.USER_HOME = new File(System.getProperty("user.home"));
      File.__\u003Cclinit\u003E();
      DashboardPrefs.USER_SMARTDASHBOARD_HOME = new File(DashboardPrefs.USER_HOME, "SmartDashboard");
      if (DashboardPrefs.USER_SMARTDASHBOARD_HOME.exists())
        return;
      DashboardPrefs.USER_SMARTDASHBOARD_HOME.mkdirs();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 232, (byte) 43, (byte) 107, (byte) 114, (byte) 114, (byte) 114, (byte) 124, (byte) 124, (byte) 114, (byte) 114, (byte) 118, (byte) 118, (byte) 127, (byte) 11, (byte) 114, (byte) 255, (byte) 11, (byte) 74, (byte) 103, (byte) 144, (byte) 127, (byte) 6, (byte) 105, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DashboardPrefs(DashboardFrame frame)
    {
      base.\u002Ector();
      DashboardPrefs dashboardPrefs = this;
      this.properties = (Map) new LinkedHashMap();
      this.__\u003C\u003Eteam = new IntegerProperty((PropertyHolder) this, "Team Number", 0);
      this.__\u003C\u003EhideMenu = new BooleanProperty((PropertyHolder) this, "Hide Menu", false);
      this.__\u003C\u003EautoShowWidgets = new BooleanProperty((PropertyHolder) this, "Automatically Show Widgets", true);
      string name1 = "Grid Cell Width(s)";
      int[] numArray1 = new int[1];
      int index1 = 0;
      int num1 = 16;
      numArray1[index1] = num1;
      this.__\u003C\u003Egrid_widths = new IntegerListProperty((PropertyHolder) this, name1, numArray1);
      string name2 = "Grid Cell Height(s)";
      int[] numArray2 = new int[1];
      int index2 = 0;
      int num2 = 16;
      numArray2[index2] = num2;
      this.__\u003C\u003Egrid_heights = new IntegerListProperty((PropertyHolder) this, name2, numArray2);
      this.__\u003C\u003Ex = new IntegerProperty((PropertyHolder) this, "Window X Position", 0);
      this.__\u003C\u003Ey = new IntegerProperty((PropertyHolder) this, "Window Y Position", 0);
      this.__\u003C\u003Ewidth = new IntegerProperty((PropertyHolder) this, "Window Width", 640);
      this.__\u003C\u003Eheight = new IntegerProperty((PropertyHolder) this, "Window Height", 480);
      string name3 = "Save File";
      File.__\u003Cclinit\u003E();
      string absolutePath1 = new File(DashboardPrefs.USER_SMARTDASHBOARD_HOME, "save.xml").getAbsolutePath();
      this.__\u003C\u003EsaveFile = new FileProperty((PropertyHolder) this, name3, absolutePath1);
      this.__\u003C\u003ElogToCSV = new BooleanProperty((PropertyHolder) this, "Log to CSV", false);
      string name4 = "CSV File";
      File.__\u003Cclinit\u003E();
      string absolutePath2 = new File(DashboardPrefs.USER_SMARTDASHBOARD_HOME, "csv.txt").getAbsolutePath();
      this.__\u003C\u003EcsvFile = new FileProperty((PropertyHolder) this, name4, absolutePath2);
      this.frame = frame;
      this.node = Preferences.userNodeForPackage((Class) ClassLiteral<main>.Value);
      Iterator iterator = this.properties.values().iterator();
      while (iterator.hasNext())
      {
        Property property = (Property) iterator.next();
        if (property != this.__\u003C\u003ElogToCSV)
          this.load(property);
      }
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Signature("()Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    public virtual Map getProperties()
    {
      return this.properties;
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void load([In] Property obj0)
    {
      obj0.setSaveValue(this.node.get(obj0.getName(), obj0.getSaveValue()));
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DashboardPrefs getInstance()
    {
      return DashboardFrame.getInstance().getPrefs();
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 123, (byte) 111, (byte) 114, (byte) 140, (byte) 100, (byte) 130, (byte) 112, (byte) 101, (byte) 2, (byte) 230, (byte) 69, (byte) 130, (byte) 105, (byte) 109, (byte) 156, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool validatePropertyChange(Property property, object value)
    {
      if (property == this.__\u003C\u003Eteam || property == this.__\u003C\u003Ewidth || property == this.__\u003C\u003Eheight)
        return ((Integer) value).intValue() > 0;
      if (property == this.__\u003C\u003Egrid_widths || property == this.__\u003C\u003Egrid_heights)
      {
        int[] numArray1 = (int[]) value;
        if (numArray1.Length == 0)
          return false;
        int[] numArray2 = numArray1;
        int length = numArray2.Length;
        for (int index = 0; index < length; ++index)
        {
          if (numArray2[index] <= 0)
            return false;
        }
        return true;
      }
      else
        return property != this.__\u003C\u003ElogToCSV || !((Boolean) value).booleanValue() || JOptionPane.showOptionDialog((Component) null, (object) "Should SmartDashboard start logging to the CSV file? (This will override the existing file)", "Warning", 0, 2, (Icon) null, (object[]) null, (object) Boolean.valueOf(false)) == 0;
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 151, (byte) 105, (byte) 127, (byte) 12, (byte) 105, (byte) 127, (byte) 12, (byte) 105, (byte) 127, (byte) 12, (byte) 105, (byte) 127, (byte) 12, (byte) 105, (byte) 117, (byte) 127, (byte) 21, (byte) 105, (byte) 127, (byte) 3, (byte) 105, (byte) 119, (byte) 159, (byte) 3, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void propertyChanged(Property property)
    {
      this.node.put(property.getName(), property.getSaveValue());
      if (property == this.__\u003C\u003Ex)
        ((Window) this.frame).setLocation(this.__\u003C\u003Ex.getValue().intValue(), ((Component) this.frame).getY());
      else if (property == this.__\u003C\u003Ey)
        ((Window) this.frame).setLocation(((Component) this.frame).getX(), this.__\u003C\u003Ey.getValue().intValue());
      else if (property == this.__\u003C\u003Ewidth)
        ((Window) this.frame).setSize(this.__\u003C\u003Ewidth.getValue().intValue(), ((Component) this.frame).getHeight());
      else if (property == this.__\u003C\u003Eheight)
        ((Window) this.frame).setSize(((Component) this.frame).getWidth(), this.__\u003C\u003Eheight.getValue().intValue());
      else if (property == this.__\u003C\u003Eteam)
      {
        Robot.setTeam(this.__\u003C\u003Eteam.getValue().intValue());
        ((Frame) this.frame).setTitle(new StringBuilder().append("SmartDashboard - ").append((object) this.__\u003C\u003Eteam.getValue()).toString());
      }
      else if (property == this.__\u003C\u003EhideMenu)
      {
        this.frame.setShouldHideMenu(((Boolean) this.__\u003C\u003EhideMenu.getValue()).booleanValue());
      }
      else
      {
        if (property != this.__\u003C\u003ElogToCSV)
          return;
        if (((Boolean) this.__\u003C\u003ElogToCSV.getValue()).booleanValue())
          this.frame.getLogger().start((string) this.__\u003C\u003EcsvFile.getValue());
        else
          this.frame.getLogger().stop();
      }
    }
  }
}
