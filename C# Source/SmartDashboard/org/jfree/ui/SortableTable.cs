// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.SortableTable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
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
  public class SortableTable : JTable
  {
    private SortableTableHeaderListener headerListener;

    [HideFromJava]
    static SortableTable()
    {
      JTable.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 137, (byte) 102, (byte) 103, (byte) 107, (byte) 45, (byte) 198, (byte) 104, (byte) 109, (byte) 109, (byte) 141, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortableTable(SortableTableModel model)
    {
      base.\u002Ector((TableModel) model);
      SortableTable sortableTable = this;
      SortButtonRenderer renderer = new SortButtonRenderer();
      TableColumnModel columnModel = this.getColumnModel();
      for (int index = 0; index < columnModel.getColumnCount(); ++index)
        columnModel.getColumn(index).setHeaderRenderer((TableCellRenderer) renderer);
      JTableHeader tableHeader = this.getTableHeader();
      this.headerListener = new SortableTableHeaderListener(model, renderer);
      ((Component) tableHeader).addMouseListener((MouseListener) this.headerListener);
      ((Component) tableHeader).addMouseMotionListener((MouseMotionListener) this.headerListener);
      model.sortByColumn(0, true);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SortableTable([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 103, (byte) 108, (byte) 102, (byte) 103, (byte) 107, (byte) 45, (byte) 166, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSortableModel(SortableTableModel model)
    {
      this.setModel((TableModel) model);
      this.headerListener.setTableModel(model);
      SortButtonRenderer sortButtonRenderer = new SortButtonRenderer();
      TableColumnModel columnModel = this.getColumnModel();
      for (int index = 0; index < columnModel.getColumnCount(); ++index)
        columnModel.getColumn(index).setHeaderRenderer((TableCellRenderer) sortButtonRenderer);
      model.sortByColumn(0, true);
    }
  }
}
