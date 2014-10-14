// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.DigitalInputDisplay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [Serializable]
  public class DigitalInputDisplay : AbstractTableWidget, ITableListener
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal string __\u003C\u003EdefaultText;
    [Modifiers]
    private Widget.UneditableBooleanField display;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return DigitalInputDisplay.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    protected internal string defaultText
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EdefaultText;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EdefaultText = value;
      }
    }

    [LineNumberTable((ushort) 16)]
    static DigitalInputDisplay()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = DigitalInputType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      DigitalInputDisplay.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 200, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DigitalInputDisplay()
    {
      DigitalInputDisplay digitalInputDisplay = this;
      this.__\u003C\u003EdefaultText = " ---- ";
      this.display = new Widget.UneditableBooleanField();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DigitalInputDisplay([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 141, (byte) 118, (byte) 141, (byte) 112, (byte) 113, (byte) 141, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      ((Container) this).add((Component) this.nameTag);
      this.display.setText(" ---- ");
      this.setBooleanBinding("Value", (BooleanBindable) this.display);
      ((Container) this).add((Component) this.display);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
