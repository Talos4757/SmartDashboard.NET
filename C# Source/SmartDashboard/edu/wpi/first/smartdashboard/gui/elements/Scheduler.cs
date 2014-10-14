// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Scheduler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.wpilibj.networktables2.type;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class Scheduler : Widget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    private const string NO_COMMAND_CARD = "No Command";
    private const string COMMAND_CARD = "Commands";
    private int count;
    private JLabel noCommands;
    private JPanel commandLabels;
    private JPanel cancelButtons;
    private JPanel commandPanel;
    [Signature("Ljava/util/List<Ljavax/swing/JLabel;>;")]
    private List labels;
    [Signature("Ljava/util/List<Ljavax/swing/JButton;>;")]
    private List buttons;
    private ITable table;
    private GridLayout commandLayout;
    private GridLayout cancelLayout;
    private CardLayout cardLayout;
    private StringArray commands;
    private NumberArray ids;
    private NumberArray toCancel;
    private ITableListener listener;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Scheduler.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 24)]
    static Scheduler()
    {
      Widget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = SchedulerType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      Scheduler.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 232, (byte) 69, (byte) 231, (byte) 76, (byte) 107, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Scheduler()
    {
      Scheduler scheduler = this;
      this.count = 0;
      this.commands = new StringArray();
      this.ids = new NumberArray();
      this.toCancel = new NumberArray();
      this.listener = (ITableListener) new Scheduler\u00241(this);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Scheduler([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static ITable access\u0024000([In] Scheduler obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static NumberArray access\u0024500([In] Scheduler obj0)
    {
      return obj0.toCancel;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static NumberArray access\u0024200([In] Scheduler obj0)
    {
      return obj0.ids;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static StringArray access\u0024100([In] Scheduler obj0)
    {
      return obj0.commands;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static List access\u0024300([In] Scheduler obj0)
    {
      return obj0.labels;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static List access\u0024400([In] Scheduler obj0)
    {
      return obj0.buttons;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static int access\u0024600([In] Scheduler obj0)
    {
      return obj0.count;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static JPanel access\u0024700([In] Scheduler obj0)
    {
      return obj0.commandLabels;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static JPanel access\u0024800([In] Scheduler obj0)
    {
      return obj0.cancelButtons;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static int access\u0024602([In] Scheduler obj0, [In] int obj1)
    {
      Scheduler scheduler1 = obj0;
      int num1 = obj1;
      Scheduler scheduler2 = scheduler1;
      int num2 = num1;
      scheduler2.count = num1;
      return num2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static CardLayout access\u0024900([In] Scheduler obj0)
    {
      return obj0.cardLayout;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 104, (byte) 145, (byte) 108, (byte) 146, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(object value)
    {
      if (this.table != null)
        this.table.removeTableListener(this.listener);
      this.table = (ITable) value;
      this.table.addTableListener(this.listener, true);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 150, (byte) 107, (byte) 139, (byte) 107, (byte) 146, (byte) 107, (byte) 139, (byte) 118, (byte) 150, (byte) 109, (byte) 141, (byte) 113, (byte) 145, (byte) 145, (byte) 112, (byte) 108, (byte) 145, (byte) 145, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      Scheduler scheduler = this;
      CardLayout cardLayout1 = new CardLayout();
      CardLayout cardLayout2 = cardLayout1;
      this.cardLayout = cardLayout1;
      ((Container) this).setLayout((LayoutManager) cardLayout2);
      this.labels = (List) new ArrayList();
      this.buttons = (List) new ArrayList();
      this.commandPanel = new JPanel();
      ((Container) this.commandPanel).setLayout((LayoutManager) new GridLayout(0, 2));
      this.commandLabels = new JPanel();
      this.cancelButtons = new JPanel();
      ((Container) this.commandPanel).add((Component) this.commandLabels, (object) "West");
      ((Container) this.commandPanel).add((Component) this.cancelButtons, (object) "Center");
      this.commandLayout = new GridLayout(0, 1);
      this.cancelLayout = new GridLayout(0, 1);
      ((Container) this.commandLabels).setLayout((LayoutManager) this.commandLayout);
      ((Container) this.cancelButtons).setLayout((LayoutManager) this.cancelLayout);
      ((Container) this).add((Component) this.commandPanel, (object) "Commands");
      this.noCommands = new JLabel("No commands running.");
      this.noCommands.setHorizontalAlignment(0);
      ((Container) this).add((Component) this.noCommands, (object) "No Command");
      this.cardLayout.show((Container) this, "No Command");
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
