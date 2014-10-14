// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.DigitalOutputController
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
  public class DigitalOutputController : AbstractTableWidget, Controller
  {
    internal static DataType[] __\u003C\u003ETYPES;
    [Modifiers]
    private JToggleButton controller;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return DigitalOutputController.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 24)]
    static DigitalOutputController()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[3];
      int index1 = 0;
      NamedDataType namedDataType1 = DigitalOutputType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = CompressorType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      int index3 = 2;
      NamedDataType namedDataType3 = SolenoidType.get();
      dataTypeArray[index3] = (DataType) namedDataType3;
      DigitalOutputController.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 232, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DigitalOutputController()
    {
      DigitalOutputController outputController = this;
      this.controller = new JToggleButton("Off");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DigitalOutputController([In] SerializationInfo obj0, [In] StreamingContext obj1)
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
    internal static JToggleButton access\u0024000([In] DigitalOutputController obj0)
    {
      return obj0.controller;
    }

    [Modifiers]
    [LineNumberTable((ushort) 22)]
    internal static ITable access\u0024100([In] DigitalOutputController obj0)
    {
      return obj0.table;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 141, (byte) 118, (byte) 141, (byte) 241, (byte) 71, (byte) 141, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      ((Container) this).add((Component) this.nameTag);
      ((AbstractButton) this.controller).addActionListener((ActionListener) new DigitalOutputController\u00241(this));
      ((Container) this).add((Component) this.controller);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void reset()
    {
      if (!((AbstractButton) this.controller).isSelected())
        return;
      ((AbstractButton) this.controller).doClick();
    }
  }
}
