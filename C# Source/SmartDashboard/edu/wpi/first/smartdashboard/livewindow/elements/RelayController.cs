// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.RelayController
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
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [Implements(new string[] {"edu.wpi.first.smartdashboard.livewindow.elements.Controller"})]
  [Serializable]
  public class RelayController : AbstractTableWidget, Controller
  {
    internal static DataType[] __\u003C\u003ETYPES;
    [Modifiers]
    private string[] options;
    [Modifiers]
    private JComboBox controller;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return RelayController.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 25)]
    static RelayController()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[2];
      int index1 = 0;
      NamedDataType namedDataType1 = RelayType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = DoubleSolenoidType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      RelayController.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 200, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelayController()
    {
      RelayController relayController = this;
      string[] strArray = new string[3];
      int index1 = 0;
      string str1 = "Forward";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "Off";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "Reverse";
      strArray[index3] = str3;
      this.options = strArray;
      JComboBox.__\u003Cclinit\u003E();
      this.controller = new JComboBox((object[]) this.options);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RelayController([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 23)]
    internal static ITable access\u0024100([In] RelayController obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 23)]
    internal static JComboBox access\u0024000([In] RelayController obj0)
    {
      return obj0.controller;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 141, (byte) 118, (byte) 109, (byte) 108, (byte) 241, (byte) 69, (byte) 141, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      ((Container) this).add((Component) this.nameTag);
      this.controller.setSelectedIndex(1);
      this.controller.addActionListener((ActionListener) new RelayController\u00241(this));
      ((Container) this).add((Component) this.controller);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 117, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void reset()
    {
      this.table.putString("Value", "Off");
      this.controller.setSelectedIndex(1);
    }
  }
}
