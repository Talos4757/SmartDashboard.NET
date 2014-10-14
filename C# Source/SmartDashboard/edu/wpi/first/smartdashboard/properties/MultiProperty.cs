// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.MultiProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.table;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.properties
{
  public class MultiProperty : Property
  {
    private JComboBox comboBox;
    private DefaultCellEditor cellEditor;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/Object;>;")]
    private Map values;
    private TableCellRenderer renderer;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 170, (byte) 107, (byte) 113, (byte) 107, (byte) 236, (byte) 59})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiProperty(PropertyHolder holder, string name)
      : base(holder, name)
    {
      MultiProperty multiProperty = this;
      this.comboBox = new JComboBox();
      this.cellEditor = new DefaultCellEditor(this.comboBox);
      this.values = (Map) new HashMap();
      this.renderer = (TableCellRenderer) new MultiProperty\u00241(this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(string key, object value)
    {
      this.comboBox.addItem((object) key);
      this.values.put((object) key, value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 105, (byte) 104, (byte) 140, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool setDefault(object key)
    {
      if (!base.setDefault(key))
        return false;
      if (!this.hasValue())
        this.comboBox.setSelectedItem(key);
      return true;
    }

    [Modifiers]
    [LineNumberTable((ushort) 13)]
    internal static JComboBox access\u0024000([In] MultiProperty obj0)
    {
      return obj0.comboBox;
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 127, (byte) 6, (byte) 115, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getSaveValue()
    {
      Iterator iterator = this.values.entrySet().iterator();
      while (iterator.hasNext())
      {
        Map.Entry entry = (Map.Entry) iterator.next();
        if (Object.instancehelper_equals(entry.getValue(), this.getValue()))
          return (string) entry.getKey();
      }
      return (string) null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void valueChanged()
    {
      this.comboBox.setSelectedItem((object) this.getSaveValue());
    }

    public override TableCellEditor getEditor(Component c)
    {
      return (TableCellEditor) this.cellEditor;
    }

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object transformValue(object value)
    {
      return this.values.get(value);
    }

    public override TableCellRenderer getRenderer()
    {
      return this.renderer;
    }
  }
}
