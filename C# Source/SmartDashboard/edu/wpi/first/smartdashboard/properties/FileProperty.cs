// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.FileProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using javax.swing.filechooser;
using javax.swing.table;
using org.jfree.ui;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("Ledu/wpi/first/smartdashboard/properties/GenericProperty<Ljava/lang/String;>;")]
  public class FileProperty : GenericProperty
  {
    protected internal JFileChooser chooser;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 144, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileProperty(PropertyHolder parent, string name, string defaultValue)
      : base((Class) ClassLiteral<String>.Value, parent, name, (object) defaultValue)
    {
      FileProperty fileProperty = this;
      JFileChooser.__\u003Cclinit\u003E();
      this.chooser = new JFileChooser((string) this.getValue());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 143, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileProperty(PropertyHolder parent, string name)
      : base((Class) ClassLiteral<String>.Value, parent, name)
    {
      FileProperty fileProperty = this;
      this.chooser = new JFileChooser();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 127, (byte) 30})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addExtensionFilter(string description, string extension)
    {
      this.chooser.addChoosableFileFilter((FileFilter) new ExtensionFileFilter(description, !String.instancehelper_startsWith(extension, ".") ? new StringBuilder().append(".").append(extension).toString() : extension));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 104, (byte) 103, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string transformValue(object value)
    {
      if (value is string)
        return (string) value;
      if (!(value is File))
        return (string) null;
      return ((File) value).getPath();
    }

    public override TableCellRenderer getRenderer()
    {
      return (TableCellRenderer) null;
    }

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TableCellEditor getEditor(Component c)
    {
      return (TableCellEditor) new FileProperty.FileTableCellEditor(this, c);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    object GenericProperty.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }

    [InnerClass]
    [Implements(new string[] {"javax.swing.table.TableCellEditor"})]
    [SourceFile("FileProperty.java")]
    [Modifiers]
    [Serializable]
    internal sealed class FileTableCellEditor : AbstractCellEditor, TableCellEditor, CellEditor
    {
      private Component c;
      private JLabel label;
      [Modifiers]
      internal FileProperty this\u00240;

      [LineNumberTable(new byte[] {(byte) 11, (byte) 111, (byte) 103, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public FileTableCellEditor([In] FileProperty obj0, [In] Component obj1)
      {
        base.\u002Ector();
        FileProperty.FileTableCellEditor fileTableCellEditor = this;
        this.c = obj1;
        this.label = new JLabel();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected FileTableCellEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable((ushort) 67)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getCellEditorValue()
      {
        return this.this\u00240.getValue();
      }

      [LineNumberTable(new byte[] {(byte) 21, (byte) 127, (byte) 11, (byte) 159, (byte) 17, (byte) 124, (byte) 226, (byte) 69, (byte) 127, (byte) 1})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Component getTableCellEditorComponent([In] JTable obj0, [In] object obj1, [In] bool obj2, [In] int obj3, [In] int obj4)
      {
        JFileChooser jfileChooser = this.this\u00240.chooser;
        File.__\u003Cclinit\u003E();
        File file = new File((string) this.this\u00240.getValue());
        jfileChooser.setSelectedFile(file);
        switch (this.this\u00240.chooser.showDialog(this.c, "Select"))
        {
          case 0:
            this.this\u00240.setValue((object) this.this\u00240.chooser.getSelectedFile());
            break;
        }
        this.label.setText(String.instancehelper_toString((string) this.this\u00240.getValue()));
        return (Component) this.label;
      }

      [HideFromJava]
      bool CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028\u0029ZstopCellEditing()
      {
        return this.stopCellEditing();
      }

      [HideFromJava]
      void CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028Ljavax\u002Eswing\u002Eevent\u002ECellEditorListener\u003B\u0029VremoveCellEditorListener([In] CellEditorListener obj0)
      {
        this.removeCellEditorListener(obj0);
      }

      [HideFromJava]
      void CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028Ljavax\u002Eswing\u002Eevent\u002ECellEditorListener\u003B\u0029VaddCellEditorListener([In] CellEditorListener obj0)
      {
        this.addCellEditorListener(obj0);
      }

      [HideFromJava]
      void CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028\u0029VcancelCellEditing()
      {
        this.cancelCellEditing();
      }

      [HideFromJava]
      bool CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028Ljava\u002Eutil\u002EEventObject\u003B\u0029ZisCellEditable([In] EventObject obj0)
      {
        return this.isCellEditable(obj0);
      }

      [HideFromJava]
      bool CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028Ljava\u002Eutil\u002EEventObject\u003B\u0029ZshouldSelectCell([In] EventObject obj0)
      {
        return this.shouldSelectCell(obj0);
      }
    }
  }
}
