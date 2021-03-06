﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Button
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

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class Button : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Button.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 20)]
    static Button()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = ButtonType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      Button.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Button()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Button([In] SerializationInfo obj0, [In] StreamingContext obj1)
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
    internal static ITable access\u0024000([In] Button obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024100([In] Button obj0)
    {
      return obj0.table;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 145, (byte) 236, (byte) 76, (byte) 135, (byte) 139, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      JButton.__\u003Cclinit\u003E();
      JButton jbutton = new JButton(this.getFieldName());
      ((Component) jbutton).addMouseListener((MouseListener) new Button\u00241(this));
      ((Component) jbutton).setFocusable(false);
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      ((Container) this).add((Component) jbutton, (object) "Center");
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
