// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.TextBox
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
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class TextBox : AbstractValueWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    public const string NAME = "Text Box";
    internal BooleanProperty __\u003C\u003Eeditable;
    internal ColorProperty __\u003C\u003Ebackground;
    private JTextField valueField;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return TextBox.__\u003C\u003ETYPES;
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

    [Modifiers]
    public ColorProperty background
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ebackground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ebackground = value;
      }
    }

    [LineNumberTable((ushort) 16)]
    static TextBox()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003EBASIC;
      dataTypeArray[index] = dataType;
      TextBox.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 232, (byte) 69, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextBox()
    {
      TextBox textBox = this;
      this.__\u003C\u003Eeditable = new BooleanProperty((PropertyHolder) this, "Editable", true);
      this.__\u003C\u003Ebackground = new ColorProperty((PropertyHolder) this, "Background");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 141, (byte) 145, (byte) 114, (byte) 124, (byte) 114, (byte) 121, (byte) 114, (byte) 153, (byte) 107, (byte) 127, (byte) 11, (byte) 172, (byte) 151, (byte) 127, (byte) 1, (byte) 141, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel = new JLabel(this.getFieldName());
      if (this.getType().isChildOf(DataType.__\u003C\u003EBOOLEAN))
      {
        AbstractValueWidget.EditableBooleanValueField.__\u003Cclinit\u003E();
        this.valueField = (JTextField) new AbstractValueWidget.EditableBooleanValueField((AbstractValueWidget) this, this.getFieldName());
      }
      else if (this.getType().isChildOf(DataType.__\u003C\u003ENUMBER))
      {
        AbstractValueWidget.EditableNumberValueField.__\u003Cclinit\u003E();
        this.valueField = (JTextField) new AbstractValueWidget.EditableNumberValueField((AbstractValueWidget) this, this.getFieldName());
      }
      else if (this.getType().isChildOf(DataType.__\u003C\u003ESTRING))
      {
        AbstractValueWidget.EditableStringValueField.__\u003Cclinit\u003E();
        this.valueField = (JTextField) new AbstractValueWidget.EditableStringValueField((AbstractValueWidget) this, this.getFieldName());
      }
      else
      {
        this.valueField = new JTextField();
        ((JTextComponent) this.valueField).setText(new StringBuilder().append("Unupported basic data type: ").append((object) this.getType()).toString());
        ((JTextComponent) this.valueField).setEditable(false);
      }
      this.update((Property) this.__\u003C\u003Ebackground, (object) ((Component) this.valueField).getBackground());
      ((JTextComponent) this.valueField).setEditable(((Boolean) this.__\u003C\u003Eeditable.getValue()).booleanValue());
      this.valueField.setColumns(10);
      ((Container) this).add((Component) jlabel);
      ((Container) this).add((Component) this.valueField);
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 105, (byte) 125, (byte) 105, (byte) 159, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Ebackground)
      {
        ((JComponent) this.valueField).setBackground((Color) this.__\u003C\u003Ebackground.getValue());
      }
      else
      {
        if (property != this.__\u003C\u003Eeditable)
          return;
        ((JTextComponent) this.valueField).setEditable(((Boolean) this.__\u003C\u003Eeditable.getValue()).booleanValue());
      }
    }
  }
}
