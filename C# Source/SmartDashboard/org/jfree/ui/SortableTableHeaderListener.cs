// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.SortableTableHeaderListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.table;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.MouseListener", "java.awt.event.MouseMotionListener"})]
  public class SortableTableHeaderListener : Object, MouseListener, EventListener, MouseMotionListener
  {
    private SortableTableModel model;
    private SortButtonRenderer renderer;
    private int sortColumnIndex;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortableTableHeaderListener(SortableTableModel model, SortButtonRenderer renderer)
    {
      base.\u002Ector();
      SortableTableHeaderListener tableHeaderListener = this;
      this.model = model;
      this.renderer = renderer;
    }

    public virtual void setTableModel(SortableTableModel model)
    {
      this.model = model;
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 140, (byte) 107, (byte) 108, (byte) 109, (byte) 141, (byte) 110, (byte) 114, (byte) 113, (byte) 102, (byte) 109, (byte) 211, (byte) 231, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mousePressed(MouseEvent e)
    {
      JTableHeader jtableHeader = (JTableHeader) ((ComponentEvent) e).getComponent();
      if (jtableHeader.getResizingColumn() != null || jtableHeader.getDraggedDistance() >= 1)
        return;
      int num = jtableHeader.columnAtPoint(e.getPoint());
      if (this.model.isSortable(jtableHeader.getTable().convertColumnIndexToModel(num)))
      {
        this.sortColumnIndex = jtableHeader.getTable().convertColumnIndexToModel(num);
        this.renderer.setPressedColumn(this.sortColumnIndex);
        ((Component) jtableHeader).repaint();
        if (!jtableHeader.getTable().isEditing())
          return;
        ((CellEditor) jtableHeader.getTable().getCellEditor()).stopCellEditing();
      }
      else
        this.sortColumnIndex = -1;
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 140, (byte) 113, (byte) 108, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseDragged(MouseEvent e)
    {
      JTableHeader jtableHeader = (JTableHeader) ((ComponentEvent) e).getComponent();
      if (jtableHeader.getDraggedDistance() <= 0 && jtableHeader.getResizingColumn() == null)
        return;
      this.renderer.setPressedColumn(-1);
      this.sortColumnIndex = -1;
    }

    public virtual void mouseEntered(MouseEvent e)
    {
    }

    public virtual void mouseClicked(MouseEvent e)
    {
    }

    public virtual void mouseMoved(MouseEvent e)
    {
    }

    public virtual void mouseExited(MouseEvent e)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 140, (byte) 104, (byte) 105, (byte) 113, (byte) 109, (byte) 103, (byte) 141, (byte) 108, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseReleased(MouseEvent e)
    {
      JTableHeader jtableHeader = (JTableHeader) ((ComponentEvent) e).getComponent();
      if (jtableHeader.getResizingColumn() != null || this.sortColumnIndex == -1)
        return;
      SortableTableModel sortableTableModel = (SortableTableModel) jtableHeader.getTable().getModel();
      int num = sortableTableModel.isAscending() ? 0 : 1;
      sortableTableModel.setAscending(num != 0);
      sortableTableModel.sortByColumn(this.sortColumnIndex, num != 0);
      this.renderer.setPressedColumn(-1);
      ((Component) jtableHeader).repaint();
    }
  }
}
