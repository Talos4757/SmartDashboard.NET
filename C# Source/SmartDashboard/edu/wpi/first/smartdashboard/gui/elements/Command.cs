// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Command
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class Command : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    private const string START_CARD = "Start";
    private const string CANCEL_CARD = "Cancel";
    internal ColorProperty __\u003C\u003EstartBackground;
    internal ColorProperty __\u003C\u003EcancelBackground;
    private JLabel name;
    private JPanel buttonPanel;
    private CardLayout layout;
    private JButton start;
    private JButton cancel;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Command.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public ColorProperty startBackground
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EstartBackground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EstartBackground = value;
      }
    }

    [Modifiers]
    public ColorProperty cancelBackground
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EcancelBackground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EcancelBackground = value;
      }
    }

    [LineNumberTable((ushort) 20)]
    static Command()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = CommandType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      Command.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 232, (byte) 69, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Command()
    {
      Command command = this;
      this.__\u003C\u003EstartBackground = new ColorProperty((PropertyHolder) this, "Start Button Color", new Color(32, 134, 32));
      this.__\u003C\u003EcancelBackground = new ColorProperty((PropertyHolder) this, "Cancel Button Color", new Color(243, 32, 32));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Command([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024000([In] Command obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024100([In] Command obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static CardLayout access\u0024300([In] Command obj0)
    {
      return obj0.layout;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static JPanel access\u0024200([In] Command obj0)
    {
      return obj0.buttonPanel;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 135, (byte) 127, (byte) 1, (byte) 140, (byte) 112, (byte) 108, (byte) 241, (byte) 70, (byte) 155, (byte) 150, (byte) 112, (byte) 108, (byte) 241, (byte) 70, (byte) 155, (byte) 150, (byte) 118, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.setResizable(false);
      JPanel.__\u003Cclinit\u003E();
      Command command = this;
      CardLayout cardLayout1 = new CardLayout();
      CardLayout cardLayout2 = cardLayout1;
      this.layout = cardLayout1;
      this.buttonPanel = new JPanel((LayoutManager) cardLayout2);
      ((JComponent) this.buttonPanel).setOpaque(false);
      this.start = new JButton("start");
      ((JComponent) this.start).setOpaque(false);
      ((AbstractButton) this.start).addActionListener((ActionListener) new Command\u00241(this));
      ((JComponent) this.start).setForeground((Color) this.__\u003C\u003EstartBackground.getValue());
      ((Container) this.buttonPanel).add((Component) this.start, (object) "Start");
      this.cancel = new JButton("cancel");
      ((JComponent) this.cancel).setOpaque(false);
      ((AbstractButton) this.cancel).addActionListener((ActionListener) new Command\u00242(this));
      ((JComponent) this.cancel).setForeground((Color) this.__\u003C\u003EcancelBackground.getValue());
      ((Container) this.buttonPanel).add((Component) this.cancel, (object) "Cancel");
      JLabel.__\u003Cclinit\u003E();
      this.name = new JLabel(this.getFieldName());
      ((Container) this).add((Component) this.name);
      ((Container) this).add((Component) this.buttonPanel);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 125, (byte) 98, (byte) 109, (byte) 238, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void booleanChanged(ITable source, string key, bool value, bool isNew)
    {
      int num = value ? 1 : 0;
      if (!String.instancehelper_equals(key, (object) "running"))
        return;
      SwingUtilities.invokeLater((Runnable) new Command\u00243(this, num != 0));
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 105, (byte) 125, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003EstartBackground)
      {
        ((JComponent) this.start).setBackground((Color) this.__\u003C\u003EstartBackground.getValue());
      }
      else
      {
        if (property != this.__\u003C\u003EcancelBackground)
          return;
        ((JComponent) this.cancel).setBackground((Color) this.__\u003C\u003EcancelBackground.getValue());
      }
    }
  }
}
