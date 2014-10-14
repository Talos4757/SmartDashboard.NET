// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.ColorProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using javax.swing.border;
using javax.swing.table;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("Ledu/wpi/first/smartdashboard/properties/GenericProperty<Ljava/awt/Color;>;")]
  public class ColorProperty : GenericProperty
  {
    private ColorProperty.ColorTableCellRenderer renderer;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorProperty(PropertyHolder parent, string name, Color defaultValue)
      : base((Class) ClassLiteral<Color>.Value, parent, name, (object) defaultValue)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorProperty(PropertyHolder parent, string name)
      : base((Class) ClassLiteral<Color>.Value, parent, name)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 139, (byte) 103, (byte) 105, (byte) 110, (byte) 106, (byte) 105, (byte) 110, (byte) 106, (byte) 105, (byte) 111, (byte) 112, (byte) 127, (byte) 8, (byte) 97, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Color transformValue(object value)
    {
      if (!(value is string))
      {
        // ISSUE: explicit non-virtual call
        return (Color) __nonvirtual (((GenericProperty) this).transformValue(value));
      }
      Color color;
      try
      {
        string str1 = (string) value;
        int num1 = String.instancehelper_indexOf(str1, 46);
        int num2 = Integer.parseInt(String.instancehelper_substring(str1, 0, num1));
        string str2 = String.instancehelper_substring(str1, num1 + 1);
        int num3 = String.instancehelper_indexOf(str2, 46);
        int num4 = Integer.parseInt(String.instancehelper_substring(str2, 0, num3));
        string str3 = String.instancehelper_substring(str2, num3 + 1);
        int num5 = String.instancehelper_indexOf(str3, 46);
        int num6 = Integer.parseInt(String.instancehelper_substring(str3, 0, num5));
        int num7 = Integer.parseInt(String.instancehelper_substring(str3, num5 + 1));
        color = new Color(num2, num4, num6, num7);
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_5;
      }
      return color;
label_5:
      return (Color) null;
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getSaveValue()
    {
      Color color = (Color) this.getValue();
      return new StringBuilder().append(color.getRed()).append(".").append(color.getGreen()).append(".").append(color.getBlue()).append(".").append(color.getAlpha()).toString();
    }

    [LineNumberTable((ushort) 64)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TableCellEditor getEditor(Component c)
    {
      return (TableCellEditor) new ColorProperty.ColorTableCellEditor(this, c);
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TableCellRenderer getRenderer()
    {
      if (this.renderer == null)
        this.renderer = new ColorProperty.ColorTableCellRenderer(this);
      return (TableCellRenderer) this.renderer;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 23)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    object GenericProperty.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }

    [InnerClass]
    [Implements(new string[] {"javax.swing.table.TableCellEditor"})]
    [SourceFile("ColorProperty.java")]
    [Modifiers]
    [Serializable]
    internal sealed class ColorTableCellEditor : AbstractCellEditor, TableCellEditor, CellEditor
    {
      private JColorChooser colorChooser;
      private JDialog colorDialog;
      private JPanel panel;
      [Modifiers]
      internal ColorProperty this\u00240;

      [LineNumberTable(new byte[] {(byte) 32, (byte) 111, (byte) 107, (byte) 107, (byte) 255, (byte) 7, (byte) 76, (byte) 244, (byte) 71})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ColorTableCellEditor([In] ColorProperty obj0, [In] Component obj1)
      {
        base.\u002Ector();
        ColorProperty.ColorTableCellEditor colorTableCellEditor = this;
        this.panel = new JPanel();
        this.colorChooser = new JColorChooser();
        this.colorDialog = JColorChooser.createDialog(obj1, "Color editor", true, this.colorChooser, (ActionListener) new ColorProperty\u0024ColorTableCellEditor\u00241(this, obj0), (ActionListener) new ColorProperty\u0024ColorTableCellEditor\u00242(this, obj0));
        ((Window) this.colorDialog).addWindowListener((WindowListener) new ColorProperty\u0024ColorTableCellEditor\u00243(this, obj0));
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ColorTableCellEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 73, (byte) 108, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool stopCellEditing()
      {
        ((Dialog) this.colorDialog).setVisible(false);
        base.stopCellEditing();
        return true;
      }

      [LineNumberTable(new byte[] {(byte) 66, (byte) 108, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void cancelCellEditing()
      {
        ((Dialog) this.colorDialog).setVisible(false);
        base.cancelCellEditing();
      }

      [LineNumberTable(new byte[] {(byte) 59, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool shouldSelectCell([In] EventObject obj0)
      {
        ((Dialog) this.colorDialog).setVisible(true);
        return true;
      }

      [LineNumberTable((ushort) 129)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getCellEditorValue()
      {
        return (object) this.colorChooser.getColor();
      }

      [LineNumberTable(new byte[] {(byte) 85, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Component getTableCellEditorComponent([In] JTable obj0, [In] object obj1, [In] bool obj2, [In] int obj3, [In] int obj4)
      {
        this.colorChooser.setColor((Color) obj1);
        return (Component) this.panel;
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
      bool CellEditor.javax\u002Eswing\u002ECellEditor\u002F\u0028Ljava\u002Eutil\u002EEventObject\u003B\u0029ZisCellEditable([In] EventObject obj0)
      {
        return this.isCellEditable(obj0);
      }
    }

    [InnerClass]
    [Implements(new string[] {"javax.swing.table.TableCellRenderer"})]
    [SourceFile("ColorProperty.java")]
    [Modifiers]
    [Serializable]
    internal sealed class ColorTableCellRenderer : JPanel, TableCellRenderer
    {
      [Modifiers]
      internal ColorProperty this\u00240;

      [HideFromJava]
      static ColorTableCellRenderer()
      {
        JPanel.__\u003Cclinit\u003E();
      }

      [LineNumberTable((ushort) 140)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ColorTableCellRenderer([In] ColorProperty obj0)
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ColorTableCellRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 163, (byte) 108, (byte) 99, (byte) 146, (byte) 135})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Component getTableCellRendererComponent([In] JTable obj0, [In] object obj1, [In] bool obj2, [In] bool obj3, [In] int obj4, [In] int obj5)
      {
        int num = obj3 ? 1 : 0;
        ((JComponent) this).setBackground((Color) obj1);
        if (num != 0)
          ((JComponent) this).setBorder(UIManager.getBorder((object) "Table.focusCellHighlightBorder"));
        else
          ((JComponent) this).setBorder((Border) null);
        return (Component) this;
      }
    }
  }
}
