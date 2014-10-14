// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Subsystem
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
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [Serializable]
  public class Subsystem : AbstractTableWidget, ITableListener
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal ColorProperty __\u003C\u003Ebackground;
    private Subsystem.SubsystemCommandField valueField;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Subsystem.__\u003C\u003ETYPES;
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

    [LineNumberTable((ushort) 17)]
    static Subsystem()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = SubsystemType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      Subsystem.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 200, (byte) 241, (byte) 85})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Subsystem()
    {
      Subsystem subsystem = this;
      this.__\u003C\u003Ebackground = new ColorProperty((PropertyHolder) this, "Background");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Subsystem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024200([In] Subsystem obj0, [In] string obj1, [In] StringBindable obj2, [In] string obj3)
    {
      obj0.setStringBinding(obj1, obj2, obj3);
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024300([In] Subsystem obj0, [In] string obj1, [In] BooleanBindable obj2)
    {
      obj0.setBooleanBinding(obj1, obj2);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 113, (byte) 140, (byte) 151, (byte) 141, (byte) 108, (byte) 141, (byte) 104, (byte) 109, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel = new JLabel(this.getFieldName());
      this.valueField = new Subsystem.SubsystemCommandField(this);
      this.update((Property) this.__\u003C\u003Ebackground, (object) ((Component) this.valueField).getBackground());
      ((Container) this).setLayout((LayoutManager) new BoxLayout((Container) this, 0));
      ((JTextComponent) this.valueField).setEditable(false);
      this.valueField.setColumns(10);
      ((Container) this).add((Component) jlabel);
      ((Container) this).add((Component) this.valueField);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property != this.__\u003C\u003Ebackground)
        return;
      ((JComponent) this.valueField).setBackground((Color) this.__\u003C\u003Ebackground.getValue());
    }

    [InnerClass]
    [SourceFile("Subsystem.java")]
    [Modifiers]
    [Serializable]
    internal sealed class SubsystemCommandField : Widget.BindableStringField
    {
      [Modifiers]
      internal Subsystem this\u00240 = obj0;
      private bool hasCommand;
      private string commandName;

      [HideFromJava]
      static SubsystemCommandField()
      {
        Widget.BindableStringField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 103, (byte) 237, (byte) 61, (byte) 103, (byte) 171, (byte) 247, (byte) 74, (byte) 244, (byte) 74})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubsystemCommandField([In] Subsystem obj0)
        : base(StringBindable.NULL)
      {
        Subsystem.SubsystemCommandField subsystemCommandField = this;
        this.hasCommand = false;
        this.commandName = "";
        Subsystem.access\u0024200(obj0, "command", (StringBindable) new Subsystem\u0024SubsystemCommandField\u00241(this, obj0), "---");
        Subsystem.access\u0024300(obj0, "hasCommand", (BooleanBindable) new Subsystem\u0024SubsystemCommandField\u00242(this, obj0));
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected SubsystemCommandField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [Modifiers]
      [LineNumberTable((ushort) 40)]
      internal static string access\u0024002([In] Subsystem.SubsystemCommandField obj0, [In] string obj1)
      {
        Subsystem.SubsystemCommandField subsystemCommandField1 = obj0;
        string str1 = obj1;
        Subsystem.SubsystemCommandField subsystemCommandField2 = subsystemCommandField1;
        string str2 = str1;
        subsystemCommandField2.commandName = str1;
        return str2;
      }

      [Modifiers]
      [LineNumberTable((ushort) 40)]
      internal static bool access\u0024100([In] Subsystem.SubsystemCommandField obj0)
      {
        return obj0.hasCommand;
      }

      [Modifiers]
      [LineNumberTable((ushort) 40)]
      internal static string access\u0024000([In] Subsystem.SubsystemCommandField obj0)
      {
        return obj0.commandName;
      }

      [Modifiers]
      [LineNumberTable((ushort) 40)]
      internal static bool access\u0024102([In] Subsystem.SubsystemCommandField obj0, [In] bool obj1)
      {
        int num1 = obj1 ? 1 : 0;
        Subsystem.SubsystemCommandField subsystemCommandField1 = obj0;
        int num2 = num1;
        Subsystem.SubsystemCommandField subsystemCommandField2 = subsystemCommandField1;
        int num3 = num2;
        subsystemCommandField2.hasCommand = num2 != 0;
        return num3 != 0;
      }
    }
  }
}
