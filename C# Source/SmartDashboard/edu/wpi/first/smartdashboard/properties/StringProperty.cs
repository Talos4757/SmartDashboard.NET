// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.StringProperty
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
  [Signature("Ledu/wpi/first/smartdashboard/properties/TextInputProperty<Ljava/lang/String;>;")]
  public class StringProperty : TextInputProperty
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringProperty(PropertyHolder element, string name, string defaultValue)
      : base((Class) ClassLiteral<String>.Value, element, name, (object) defaultValue)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringProperty(PropertyHolder element, string name)
      : base((Class) ClassLiteral<String>.Value, element, name)
    {
    }

    [LineNumberTable((ushort) 19)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string transformValue(object value)
    {
      return Object.instancehelper_toString(value);
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
