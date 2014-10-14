// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.IntegerProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  public class IntegerProperty : NumberProperty
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegerProperty(PropertyHolder element, string name, int defaultValue)
      : base(element, name, (Number) Integer.valueOf(defaultValue))
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegerProperty(PropertyHolder element, string name)
      : base(element, name)
    {
    }

    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Integer getValue()
    {
      // ISSUE: explicit non-virtual call
      return (Integer) __nonvirtual (((GenericProperty) this).getValue());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Integer transformValue(object value)
    {
      // ISSUE: explicit non-virtual call
      Number number = __nonvirtual (((NumberProperty) this).transformValue(value));
      return number != null ? Integer.valueOf(number.intValue()) : (Integer) null;
    }

    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getDefault()
    {
      // ISSUE: explicit non-virtual call
      return (Number) __nonvirtual (((GenericProperty) this).getDefault());
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Number NumberProperty.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (Number) this.transformValue(x0);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object \u003Cbridge\u003EgetDefault()
    {
      return (object) this.getDefault();
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object \u003Cbridge\u003EgetValue()
    {
      return (object) this.getValue();
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object \u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }
  }
}
