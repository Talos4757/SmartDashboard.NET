// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.Property
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing.table;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  public abstract class Property : Object
  {
    [Modifiers]
    private PropertyHolder element;
    [Modifiers]
    private string name;
    private object defaultValue;
    private object value;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 104, (byte) 103, (byte) 135, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Property(PropertyHolder element, string name)
    {
      base.\u002Ector();
      Property property = this;
      this.element = element;
      this.name = name;
      element.getProperties().put((object) name, (object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 104, (byte) 103, (byte) 103, (byte) 135, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Property(PropertyHolder element, string name, object defaultValue)
    {
      base.\u002Ector();
      Property property = this;
      this.element = element;
      this.name = name;
      this.defaultValue = defaultValue;
      element.getProperties().put((object) name, (object) this);
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 105, (byte) 114, (byte) 103, (byte) 102, (byte) 108, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool setValue(object value)
    {
      value = this.transformValue(value);
      if (value == null || !this.element.validatePropertyChange(this, value))
        return false;
      this.value = value;
      this.valueChanged();
      this.element.propertyChanged(this);
      return true;
    }

    public virtual object getValue()
    {
      if (this.value == null)
        return this.defaultValue;
      else
        return this.value;
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isDefault()
    {
      return (this.value != null ? (Object.instancehelper_equals(this.value, this.defaultValue) ? 1 : 0) : (this.defaultValue == null ? 0 : 1)) != 0;
    }

    [LineNumberTable((ushort) 75)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getSaveValue()
    {
      return Object.instancehelper_toString(this.getValue());
    }

    public virtual string getName()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSaveValue(string value)
    {
      this._setValue((object) value);
    }

    public virtual bool hasDefault()
    {
      return this.defaultValue != null;
    }

    public virtual bool hasValue()
    {
      return this.value != null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 105, (byte) 99, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool setDefault(object value)
    {
      value = this.transformValue(value);
      if (value == null)
        return false;
      this.defaultValue = value;
      return true;
    }

    [LineNumberTable((ushort) 102)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getTableValue()
    {
      return this.getValue();
    }

    public virtual TableCellEditor getEditor(Component c)
    {
      return (TableCellEditor) null;
    }

    public abstract TableCellRenderer getRenderer();

    protected internal abstract object transformValue(object obj);

    protected internal virtual void valueChanged()
    {
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 105, (byte) 99, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void _setValue(object value)
    {
      value = this.transformValue(value);
      if (value == null)
        return;
      this.value = value;
      this.valueChanged();
    }

    public virtual object getDefault()
    {
      return this.defaultValue;
    }
  }
}
