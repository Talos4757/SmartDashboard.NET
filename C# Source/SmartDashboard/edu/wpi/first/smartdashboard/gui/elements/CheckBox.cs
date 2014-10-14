// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.CheckBox
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using java.awt;
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
  public class CheckBox : AbstractValueWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal BooleanProperty __\u003C\u003Eeditable;
    private AbstractValueWidget.EditableBooleanValueCheckBox valueField;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return CheckBox.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public BooleanProperty editable
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eeditable;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eeditable = value;
      }
    }

    [LineNumberTable((ushort) 15)]
    static CheckBox()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003EBOOLEAN;
      dataTypeArray[index] = dataType;
      CheckBox.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CheckBox()
    {
      CheckBox checkBox = this;
      this.__\u003C\u003Eeditable = new BooleanProperty((PropertyHolder) this, "Editable", true);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 135, (byte) 141, (byte) 151, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.setResizable(false);
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      AbstractValueWidget.EditableBooleanValueCheckBox.__\u003Cclinit\u003E();
      this.valueField = new AbstractValueWidget.EditableBooleanValueCheckBox((AbstractValueWidget) this, this.getFieldName());
      ((Container) this).add((Component) this.valueField);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 105, (byte) 159, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property != this.__\u003C\u003Eeditable)
        return;
      ((AbstractButton) this.valueField).setEnabled(((Boolean) this.__\u003C\u003Eeditable.getValue()).booleanValue());
    }
  }
}
