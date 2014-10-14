// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.SingleNumberDisplay
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
  public class SingleNumberDisplay : AbstractTableWidget, ITableListener
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal string __\u003C\u003EdefaultText;
    [Modifiers]
    private Widget.UneditableNumberField display;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return SingleNumberDisplay.__\u003C\u003ETYPES;
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

    [LineNumberTable((ushort) 23)]
    static SingleNumberDisplay()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[5];
      int index1 = 0;
      NamedDataType namedDataType1 = AnalogInputType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = UltrasonicType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      int index3 = 2;
      NamedDataType namedDataType3 = AccelerometerType.get();
      dataTypeArray[index3] = (DataType) namedDataType3;
      int index4 = 3;
      NamedDataType namedDataType4 = GearToothSensorType.get();
      dataTypeArray[index4] = (DataType) namedDataType4;
      int index5 = 4;
      NamedDataType namedDataType5 = CounterType.get();
      dataTypeArray[index5] = (DataType) namedDataType5;
      SingleNumberDisplay.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 232, (byte) 72, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SingleNumberDisplay()
    {
      SingleNumberDisplay singleNumberDisplay = this;
      this.__\u003C\u003EdefaultText = " ---- ";
      this.display = new Widget.UneditableNumberField();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SingleNumberDisplay([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 141, (byte) 118, (byte) 141, (byte) 108, (byte) 112, (byte) 113, (byte) 109, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      ((Container) this).add((Component) this.nameTag);
      ((Component) this.display).setFocusable(false);
      this.display.setText(" ---- ");
      this.setNumberBinding("Value", (NumberBindable) this.display);
      ((Container) this).add((Component) this.display);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
