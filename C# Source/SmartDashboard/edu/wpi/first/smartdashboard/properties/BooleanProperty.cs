// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.BooleanProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using javax.swing.table;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("Ledu/wpi/first/smartdashboard/properties/TextInputProperty<Ljava/lang/Boolean;>;")]
  public class BooleanProperty : TextInputProperty
  {
    private JCheckBox box;
    private DefaultCellEditor checkbox;
    private TableCellRenderer renderer;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 162, (byte) 245, (byte) 50, (byte) 107, (byte) 113, (byte) 236, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanProperty(PropertyHolder element, string name, bool defaultValue)
    {
      int num = defaultValue ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector((Class) ClassLiteral<Boolean>.Value, element, name, (object) Boolean.valueOf(num != 0));
      BooleanProperty booleanProperty = this;
      this.box = new JCheckBox();
      this.checkbox = new DefaultCellEditor(this.box);
      this.renderer = (TableCellRenderer) new BooleanProperty\u00241(this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 239, (byte) 54, (byte) 107, (byte) 113, (byte) 236, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanProperty(PropertyHolder element, string name)
      : base((Class) ClassLiteral<Boolean>.Value, element, name)
    {
      BooleanProperty booleanProperty = this;
      this.box = new JCheckBox();
      this.checkbox = new DefaultCellEditor(this.box);
      this.renderer = (TableCellRenderer) new BooleanProperty\u00241(this);
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static JCheckBox access\u0024000([In] BooleanProperty obj0)
    {
      return obj0.box;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 104, (byte) 114, (byte) 105, (byte) 114, (byte) 137, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Boolean transformValue(object value)
    {
      if (!(value is string))
      {
        // ISSUE: explicit non-virtual call
        return (Boolean) __nonvirtual (((GenericProperty) this).transformValue(value));
      }
      if (String.instancehelper_equalsIgnoreCase("true", (string) value))
      {
        return Boolean.valueOf(true);
      }
      else
      {
        if (!String.instancehelper_equalsIgnoreCase("false", (string) value))
          return (Boolean) null;
        return Boolean.valueOf(false);
      }
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TableCellRenderer getRenderer()
    {
      ((AbstractButton) this.box).setSelected(((Boolean) this.getValue()).booleanValue());
      return this.renderer;
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TableCellEditor getEditor(Component c)
    {
      ((AbstractButton) this.box).setSelected(((Boolean) this.getValue()).booleanValue());
      return (TableCellEditor) this.checkbox;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    object GenericProperty.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }
  }
}
