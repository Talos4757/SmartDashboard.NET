// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.FormattedField
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
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
  public class FormattedField : Widget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal ColorProperty __\u003C\u003Eforeground;
    internal ColorProperty __\u003C\u003Ebackground;
    internal IntegerProperty __\u003C\u003EfontSize;
    protected internal JFormattedTextField valueField;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return FormattedField.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public ColorProperty foreground
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eforeground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eforeground = value;
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

    [Modifiers]
    public IntegerProperty fontSize
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EfontSize;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EfontSize = value;
      }
    }

    [LineNumberTable((ushort) 17)]
    static FormattedField()
    {
      Widget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003EBASIC;
      dataTypeArray[index] = dataType;
      FormattedField.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 232, (byte) 69, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FormattedField()
    {
      FormattedField formattedField = this;
      this.__\u003C\u003Eforeground = new ColorProperty((PropertyHolder) this, "Foreground");
      this.__\u003C\u003Ebackground = new ColorProperty((PropertyHolder) this, "Background");
      this.__\u003C\u003EfontSize = new IntegerProperty((PropertyHolder) this, "Font Size", 12);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FormattedField([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 139, (byte) 113, (byte) 139, (byte) 119, (byte) 119, (byte) 159, (byte) 2, (byte) 108, (byte) 141, (byte) 108, (byte) 113, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel = new JLabel(this.getFieldName());
      this.valueField = new JFormattedTextField();
      this.update((Property) this.__\u003C\u003Eforeground, (object) ((Component) this.valueField).getForeground());
      this.update((Property) this.__\u003C\u003Ebackground, (object) ((Component) this.valueField).getBackground());
      this.update((Property) this.__\u003C\u003EfontSize, (object) Integer.valueOf(((Component) this.valueField).getFont().getSize()));
      ((JTextComponent) this.valueField).setEditable(false);
      ((JTextField) this.valueField).setColumns(10);
      ((Container) this).add((Component) jlabel, (object) "Before");
      ((Container) this).add((Component) this.valueField, (object) "Center");
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(object value)
    {
      this.valueField.setValue(value);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 105, (byte) 127, (byte) 1, (byte) 105, (byte) 125, (byte) 105, (byte) 159, (byte) 40})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Eforeground)
        ((JComponent) this.valueField).setForeground((Color) this.__\u003C\u003Eforeground.getValue());
      else if (property == this.__\u003C\u003Ebackground)
      {
        ((JComponent) this.valueField).setBackground((Color) this.__\u003C\u003Ebackground.getValue());
      }
      else
      {
        if (property != this.__\u003C\u003EfontSize)
          return;
        JFormattedTextField jformattedTextField = this.valueField;
        Font.__\u003Cclinit\u003E();
        Font font = new Font(((Component) this.valueField).getFont().getName(), ((Component) this.valueField).getFont().getStyle(), this.__\u003C\u003EfontSize.getValue().intValue());
        ((JTextField) jformattedTextField).setFont(font);
      }
    }
  }
}
