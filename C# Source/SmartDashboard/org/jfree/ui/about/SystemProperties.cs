// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.SystemProperties
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing.table;
using org.jfree.ui;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.about
{
  public class SystemProperties : Object
  {
    [LineNumberTable(new byte[] {(byte) 12, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private SystemProperties()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 102, (byte) 135, (byte) 103, (byte) 104, (byte) 107, (byte) 104, (byte) 139, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SortableTable createSystemPropertiesTable()
    {
      SortableTable sortableTable = new SortableTable((SortableTableModel) new SystemPropertiesTableModel());
      TableColumnModel columnModel = sortableTable.getColumnModel();
      columnModel.getColumn(0).setPreferredWidth(200);
      columnModel.getColumn(1).setPreferredWidth(350);
      sortableTable.setAutoResizeMode(2);
      return sortableTable;
    }
  }
}
