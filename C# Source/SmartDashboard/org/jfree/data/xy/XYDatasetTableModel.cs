// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYDatasetTableModel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using javax.swing.@event;
using javax.swing.table;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"javax.swing.table.TableModel", "org.jfree.data.general.DatasetChangeListener"})]
  [Serializable]
  public class XYDatasetTableModel : AbstractTableModel, TableModel, DatasetChangeListener, EventListener
  {
    internal TableXYDataset model;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 232, (byte) 58, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDatasetTableModel()
    {
      base.\u002Ector();
      XYDatasetTableModel datasetTableModel = this;
      this.model = (TableXYDataset) null;
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 104, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDatasetTableModel(TableXYDataset dataset)
      : this()
    {
      XYDatasetTableModel datasetTableModel = this;
      this.model = dataset;
      this.model.addChangeListener((DatasetChangeListener) this);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYDatasetTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    public virtual bool isCellEditable(int row, int column)
    {
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 103, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setModel(TableXYDataset dataset)
    {
      this.model = dataset;
      this.model.addChangeListener((DatasetChangeListener) this);
      this.fireTableDataChanged();
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      if (this.model == null)
        return 0;
      return this.model.getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      if (this.model == null)
        return 0;
      else
        return this.model.getSeriesCount() + 1;
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 104, (byte) 138, (byte) 100, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getColumnName(int column)
    {
      if (this.model == null)
      {
        return base.getColumnName(column);
      }
      else
      {
        if (column < 1)
          return "X Value";
        return Object.instancehelper_toString((object) this.model.getSeriesKey(column - 1));
      }
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 104, (byte) 130, (byte) 100, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValueAt(int row, int column)
    {
      if (this.model == null)
        return (object) null;
      if (column < 1)
        return (object) this.model.getX(0, row);
      else
        return (object) this.model.getY(column - 1, row);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent @event)
    {
      this.fireTableDataChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueAt(object value, int row, int column)
    {
      if (this.isCellEditable(row, column))
        ;
    }

    [HideFromJava]
    Class TableModel.javax\u002Eswing\u002Etable\u002ETableModel\u002F\u0028I\u0029Ljava\u002Elang\u002EClass\u003BgetColumnClass([In] int obj0)
    {
      return this.getColumnClass(obj0);
    }

    [HideFromJava]
    void TableModel.javax\u002Eswing\u002Etable\u002ETableModel\u002F\u0028Ljavax\u002Eswing\u002Eevent\u002ETableModelListener\u003B\u0029VaddTableModelListener([In] TableModelListener obj0)
    {
      this.addTableModelListener(obj0);
    }

    [HideFromJava]
    void TableModel.javax\u002Eswing\u002Etable\u002ETableModel\u002F\u0028Ljavax\u002Eswing\u002Eevent\u002ETableModelListener\u003B\u0029VremoveTableModelListener([In] TableModelListener obj0)
    {
      this.removeTableModelListener(obj0);
    }
  }
}
