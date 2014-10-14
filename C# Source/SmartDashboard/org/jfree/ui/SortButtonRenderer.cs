// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.SortButtonRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using javax.swing.border;
using javax.swing.table;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"javax.swing.table.TableCellRenderer"})]
  public class SortButtonRenderer : Object, TableCellRenderer
  {
    public const int NONE = 0;
    public const int DOWN = 1;
    public const int UP = 2;
    private int pressedColumn;
    private JButton normalButton;
    private JButton ascendingButton;
    private JButton descendingButton;
    private bool useLabels;
    private JLabel normalLabel;
    private JLabel ascendingLabel;
    private JLabel descendingLabel;

    [LineNumberTable(new byte[] {(byte) 81, (byte) 232, (byte) 22, (byte) 231, (byte) 108, (byte) 103, (byte) 154, (byte) 139, (byte) 107, (byte) 107, (byte) 141, (byte) 107, (byte) 109, (byte) 108, (byte) 147, (byte) 107, (byte) 109, (byte) 108, (byte) 147, (byte) 108, (byte) 108, (byte) 177, (byte) 107, (byte) 116, (byte) 141, (byte) 107, (byte) 116, (byte) 109, (byte) 108, (byte) 115, (byte) 147, (byte) 107, (byte) 116, (byte) 109, (byte) 108, (byte) 115, (byte) 147, (byte) 108, (byte) 108, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortButtonRenderer()
    {
      base.\u002Ector();
      SortButtonRenderer sortButtonRenderer = this;
      this.pressedColumn = -1;
      this.pressedColumn = -1;
      this.useLabels = String.instancehelper_equals(UIManager.getLookAndFeel().getID(), (object) "Aqua");
      Border border = UIManager.getBorder((object) "TableHeader.cellBorder");
      if (this.useLabels)
      {
        this.normalLabel = new JLabel();
        this.normalLabel.setHorizontalAlignment(10);
        this.ascendingLabel = new JLabel();
        this.ascendingLabel.setHorizontalAlignment(10);
        this.ascendingLabel.setHorizontalTextPosition(2);
        this.ascendingLabel.setIcon((Icon) new BevelArrowIcon(1, false, false));
        this.descendingLabel = new JLabel();
        this.descendingLabel.setHorizontalAlignment(10);
        this.descendingLabel.setHorizontalTextPosition(2);
        this.descendingLabel.setIcon((Icon) new BevelArrowIcon(0, false, false));
        ((JComponent) this.normalLabel).setBorder(border);
        ((JComponent) this.ascendingLabel).setBorder(border);
        ((JComponent) this.descendingLabel).setBorder(border);
      }
      else
      {
        this.normalButton = new JButton();
        ((AbstractButton) this.normalButton).setMargin(new Insets(0, 0, 0, 0));
        ((AbstractButton) this.normalButton).setHorizontalAlignment(10);
        this.ascendingButton = new JButton();
        ((AbstractButton) this.ascendingButton).setMargin(new Insets(0, 0, 0, 0));
        ((AbstractButton) this.ascendingButton).setHorizontalAlignment(10);
        ((AbstractButton) this.ascendingButton).setHorizontalTextPosition(2);
        ((AbstractButton) this.ascendingButton).setIcon((Icon) new BevelArrowIcon(1, false, false));
        ((AbstractButton) this.ascendingButton).setPressedIcon((Icon) new BevelArrowIcon(1, false, true));
        this.descendingButton = new JButton();
        ((AbstractButton) this.descendingButton).setMargin(new Insets(0, 0, 0, 0));
        ((AbstractButton) this.descendingButton).setHorizontalAlignment(10);
        ((AbstractButton) this.descendingButton).setHorizontalTextPosition(2);
        ((AbstractButton) this.descendingButton).setIcon((Icon) new BevelArrowIcon(0, false, false));
        ((AbstractButton) this.descendingButton).setPressedIcon((Icon) new BevelArrowIcon(0, false, true));
        ((JComponent) this.normalButton).setBorder(border);
        ((JComponent) this.ascendingButton).setBorder(border);
        ((JComponent) this.descendingButton).setBorder(border);
      }
    }

    private JLabel getRendererLabel([In] bool obj0, [In] bool obj1)
    {
      int num1 = obj0 ? 1 : 0;
      int num2 = obj1 ? 1 : 0;
      if (num1 == 0)
        return this.normalLabel;
      if (num2 != 0)
        return this.ascendingLabel;
      else
        return this.descendingLabel;
    }

    private JButton getRendererButton([In] bool obj0, [In] bool obj1)
    {
      int num1 = obj0 ? 1 : 0;
      int num2 = obj1 ? 1 : 0;
      if (num1 == 0)
        return this.normalButton;
      if (num2 != 0)
        return this.ascendingButton;
      else
        return this.descendingButton;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 99, (byte) 208, (byte) 108, (byte) 105, (byte) 106, (byte) 135, (byte) 104, (byte) 139, (byte) 104, (byte) 106, (byte) 119, (byte) 100, (byte) 130, (byte) 106, (byte) 119, (byte) 110, (byte) 110, (byte) 164, (byte) 100, (byte) 110, (byte) 110, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Component getTableCellRendererComponent(JTable table, object value, bool isSelected, bool hasFocus, int row, int column)
    {
      if (table == null)
      {
        string str = "Table must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        SortableTableModel sortableTableModel = (SortableTableModel) table.getModel();
        int num1 = table.convertColumnIndexToModel(column);
        int num2 = sortableTableModel.getSortingColumn() == num1 ? 1 : 0;
        int num3 = sortableTableModel.isAscending() ? 1 : 0;
        JTableHeader tableHeader = table.getTableHeader();
        int num4 = num1 == this.pressedColumn ? 1 : 0;
        JComponent jcomponent;
        if (this.useLabels)
        {
          JLabel rendererLabel = this.getRendererLabel(num2 != 0, num3 != 0);
          rendererLabel.setText(value != null ? Object.instancehelper_toString(value) : "");
          jcomponent = (JComponent) rendererLabel;
        }
        else
        {
          JButton rendererButton = this.getRendererButton(num2 != 0, num3 != 0);
          ((AbstractButton) rendererButton).setText(value != null ? Object.instancehelper_toString(value) : "");
          ((AbstractButton) rendererButton).getModel().setPressed(num4 != 0);
          ((AbstractButton) rendererButton).getModel().setArmed(num4 != 0);
          jcomponent = (JComponent) rendererButton;
        }
        if (tableHeader != null)
        {
          jcomponent.setForeground(((Component) tableHeader).getForeground());
          jcomponent.setBackground(((Component) tableHeader).getBackground());
          jcomponent.setFont(((Component) tableHeader).getFont());
        }
        return (Component) jcomponent;
      }
    }

    public virtual void setPressedColumn(int column)
    {
      this.pressedColumn = column;
    }
  }
}
