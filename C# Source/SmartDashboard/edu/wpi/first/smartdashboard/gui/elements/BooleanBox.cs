// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.BooleanBox
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class BooleanBox : AbstractValueWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal ColorProperty __\u003C\u003EcolorOnTrue;
    internal ColorProperty __\u003C\u003EcolorOnFalse;
    private JPanel valueField;
    private bool value;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return BooleanBox.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public ColorProperty colorOnTrue
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EcolorOnTrue;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EcolorOnTrue = value;
      }
    }

    [Modifiers]
    public ColorProperty colorOnFalse
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EcolorOnFalse;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EcolorOnFalse = value;
      }
    }

    [LineNumberTable((ushort) 17)]
    static BooleanBox()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003EBOOLEAN;
      dataTypeArray[index] = dataType;
      BooleanBox.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 168, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanBox()
    {
      BooleanBox booleanBox = this;
      this.__\u003C\u003EcolorOnTrue = new ColorProperty((PropertyHolder) this, "Color to show when true", (Color) Color.GREEN);
      this.__\u003C\u003EcolorOnFalse = new ColorProperty((PropertyHolder) this, "Color to show when false", (Color) Color.RED);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BooleanBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 130, (byte) 103, (byte) 127, (byte) 17, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(bool value)
    {
      int num = value ? 1 : 0;
      this.value = num != 0;
      ((JComponent) this.valueField).setBackground(num == 0 ? (Color) this.__\u003C\u003EcolorOnFalse.getValue() : (Color) this.__\u003C\u003EcolorOnTrue.getValue());
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 141, (byte) 113, (byte) 107, (byte) 148, (byte) 109, (byte) 104, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel = new JLabel(this.getFieldName());
      this.valueField = new JPanel();
      ((JComponent) this.valueField).setPreferredSize(new Dimension(10, 10));
      ((Container) this).add((Component) this.valueField);
      ((Container) this).add((Component) jlabel);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      this.setValue(this.value);
    }
  }
}
