// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.NumberProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("Ledu/wpi/first/smartdashboard/properties/TextInputProperty<Ljava/lang/Number;>;")]
  public class NumberProperty : TextInputProperty
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberProperty(PropertyHolder element, string name)
      : base((Class) ClassLiteral<Number>.Value, element, name)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberProperty(PropertyHolder element, string name, Number defaultValue)
      : base((Class) ClassLiteral<Number>.Value, element, name, (object) defaultValue)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 136, (byte) 127, (byte) 0, (byte) 129, (byte) 127, (byte) 0, (byte) 97, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Number transformValue(object value)
    {
      if (!(value is string))
      {
        // ISSUE: explicit non-virtual call
        return (Number) __nonvirtual (((GenericProperty) this).transformValue(value));
      }
      Integer integer;
      try
      {
        integer = Integer.valueOf(Integer.parseInt((string) value));
      }
      catch (NumberFormatException ex)
      {
        goto label_4;
      }
      return (Number) integer;
label_4:
      Double @double;
      try
      {
        @double = Double.valueOf(Double.parseDouble((string) value));
      }
      catch (NumberFormatException ex)
      {
        goto label_8;
      }
      return (Number) @double;
label_8:
      return (Number) null;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 7)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    object GenericProperty.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }
  }
}
