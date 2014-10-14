// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.DateCellRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.text;
using javax.swing;
using javax.swing.table;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class DateCellRenderer : DefaultTableCellRenderer
  {
    private DateFormat formatter;

    [HideFromJava]
    static DateCellRenderer()
    {
      DefaultTableCellRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateCellRenderer(DateFormat formatter)
    {
      base.\u002Ector();
      DateCellRenderer dateCellRenderer = this;
      this.formatter = formatter;
      ((JLabel) this).setHorizontalAlignment(0);
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateCellRenderer()
      : this(DateFormat.getDateTimeInstance())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateCellRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 98, (byte) 103, (byte) 99, (byte) 180, (byte) 139, (byte) 99, (byte) 174, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Component getTableCellRendererComponent(JTable table, object value, bool isSelected, bool hasFocus, int row, int column)
    {
      int num = isSelected ? 1 : 0;
      ((JComponent) this).setFont((Font) null);
      if (value != null)
        ((JLabel) this).setText(((Format) this.formatter).format(value));
      else
        ((JLabel) this).setText("");
      if (num != 0)
        this.setBackground(table.getSelectionBackground());
      else
        this.setBackground((Color) null);
      return (Component) this;
    }
  }
}
