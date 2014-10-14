// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.PropertyEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.properties;
using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.table;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public class PropertyEditor : JDialog
  {
    private JTable table;
    private PropertyEditor.PropTableModel tableModel;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    private Map values;
    private string[] names;

    [HideFromJava]
    static PropertyEditor()
    {
      JDialog.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 106, (byte) 108, (byte) 119, (byte) 112, (byte) 108, (byte) 113, (byte) 116, (byte) 112, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyEditor(JFrame frame)
    {
      base.\u002Ector((Frame) frame, true);
      PropertyEditor propertyEditor = this;
      this.tableModel = new PropertyEditor.PropTableModel(this);
      PropertyEditor.PropertiesTable.__\u003Cclinit\u003E();
      this.table = (JTable) new PropertyEditor.PropertiesTable(this, (AbstractTableModel) this.tableModel);
      this.table.setGridColor((Color) Color.LIGHT_GRAY);
      this.table.setRowSelectionAllowed(false);
      JScrollPane.__\u003Cclinit\u003E();
      JScrollPane jscrollPane = new JScrollPane((Component) this.table);
      ((Window) this).setBounds(100, 100, 300, 400);
      this.getContentPane().setLayout((LayoutManager) new BorderLayout());
      this.getContentPane().add((Component) jscrollPane, (object) "Center");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PropertyEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 109, (byte) 145, (byte) 104, (byte) 147, (byte) 139, (byte) 108, (byte) 127, (byte) 12, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void setPropertyHolder([In] PropertyHolder obj0)
    {
      if (this.table.isEditing())
        ((CellEditor) this.table.getCellEditor()).stopCellEditing();
      if (obj0 is Widget)
        ((Dialog) this).setTitle(((Widget) obj0).getFieldName());
      else
        ((Dialog) this).setTitle("Edit Properties");
      this.values = obj0.getProperties();
      this.names = (string[]) this.values.keySet().toArray((object[]) new string[this.values.size()]);
      this.tableModel.fireTableDataChanged();
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Map access\u0024100([In] PropertyEditor obj0)
    {
      return obj0.values;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static string[] access\u0024000([In] PropertyEditor obj0)
    {
      return obj0.names;
    }

    [InnerClass]
    [SourceFile("PropertyEditor.java")]
    [Modifiers]
    [Serializable]
    internal sealed class PropTableModel : AbstractTableModel
    {
      [Modifiers]
      internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<PropertyEditor>.Value).desiredAssertionStatus();
      [Modifiers]
      internal PropertyEditor this\u00240;

      [LineNumberTable((ushort) 73)]
      static PropTableModel()
      {
      }

      [LineNumberTable((ushort) 73)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal PropTableModel([In] PropertyEditor obj0)
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PropTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable((ushort) 76)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getRowCount()
      {
        return PropertyEditor.access\u0024100(this.this\u00240).size();
      }

      public virtual int getColumnCount()
      {
        return 2;
      }

      public virtual string getColumnName([In] int obj0)
      {
        if (obj0 == 0)
          return "Property";
        return obj0 == 1 ? "Value" : "Error";
      }

      public virtual bool isCellEditable([In] int obj0, [In] int obj1)
      {
        return obj1 == 1;
      }

      [LineNumberTable(new byte[] {(byte) 51, (byte) 146, (byte) 142, (byte) 159, (byte) 11, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getValueAt([In] int obj0, [In] int obj1)
      {
        int num1 = obj1;
        int num2 = 0;
        if (num1 == num2)
          return (object) PropertyEditor.access\u0024000(this.this\u00240)[obj0];
        int num3 = 1;
        if (num1 == num3)
        {
          return ((Property) PropertyEditor.access\u0024100(this.this\u00240).get((object) PropertyEditor.access\u0024000(this.this\u00240)[obj0])).getTableValue();
        }
        else
        {
          if (PropertyEditor.PropTableModel.\u0024assertionsDisabled)
            return (object) "Bad row, col";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
      }

      [LineNumberTable(new byte[] {(byte) 64, (byte) 118, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setValueAt([In] object obj0, [In] int obj1, [In] int obj2)
      {
        if (!PropertyEditor.PropTableModel.\u0024assertionsDisabled && obj2 != 1)
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
        else
          ((Property) PropertyEditor.access\u0024100(this.this\u00240).get((object) PropertyEditor.access\u0024000(this.this\u00240)[obj1])).setValue(obj0);
      }
    }

    [InnerClass]
    [SourceFile("PropertyEditor.java")]
    [Modifiers]
    [Serializable]
    internal sealed class PropertiesTable : JTable
    {
      internal AbstractTableModel model;
      [Modifiers]
      internal PropertyEditor this\u00240;

      [HideFromJava]
      static PropertiesTable()
      {
        JTable.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 2, (byte) 103, (byte) 105, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal PropertiesTable([In] PropertyEditor obj0, [In] AbstractTableModel obj1)
      {
        base.\u002Ector((TableModel) obj1);
        PropertyEditor.PropertiesTable propertiesTable = this;
        this.model = obj1;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PropertiesTable([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 9, (byte) 127, (byte) 15})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual TableCellEditor getCellEditor([In] int obj0, [In] int obj1)
      {
        return ((Property) PropertyEditor.access\u0024100(this.this\u00240).get((object) PropertyEditor.access\u0024000(this.this\u00240)[obj0])).getEditor((Component) this.this\u00240) ?? base.getCellEditor(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 15, (byte) 99, (byte) 139, (byte) 127, (byte) 9})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual TableCellRenderer getCellRenderer([In] int obj0, [In] int obj1)
      {
        if (obj1 != 0)
          return ((Property) PropertyEditor.access\u0024100(this.this\u00240).get((object) PropertyEditor.access\u0024000(this.this\u00240)[obj0])).getRenderer() ?? base.getCellRenderer(obj0, obj1);
        return base.getCellRenderer(obj0, obj1);
      }
    }
  }
}
