// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.SortableTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using javax.swing.table;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public abstract class SortableTableModel : AbstractTableModel
  {
    private int sortingColumn;
    private bool ascending;

    [LineNumberTable(new byte[] {(byte) 15, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortableTableModel()
    {
      base.\u002Ector();
      SortableTableModel sortableTableModel = this;
      this.sortingColumn = -1;
      this.ascending = true;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SortableTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    public virtual int getSortingColumn()
    {
      return this.sortingColumn;
    }

    public virtual bool isAscending()
    {
      return this.ascending;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 105, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortByColumn(int column, bool ascending)
    {
      if (!this.isSortable(column))
        return;
      this.sortingColumn = column;
    }

    public virtual bool isSortable(int column)
    {
      return false;
    }

    public virtual void setAscending(bool flag)
    {
      this.ascending = flag;
    }
  }
}
