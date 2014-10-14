// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.GenericProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("<T:Ljava/lang/Object;>Ledu/wpi/first/smartdashboard/properties/Property;")]
  public abstract class GenericProperty : Property
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<TT;>;")]
    private Class clazz;

    [Signature("(Ljava/lang/Class<TT;>;Ledu/wpi/first/smartdashboard/properties/PropertyHolder;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 138, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GenericProperty(Class clazz, PropertyHolder element, string name)
      : base(element, name)
    {
      GenericProperty genericProperty = this;
      this.clazz = clazz;
    }

    [Signature("(Ljava/lang/Class<TT;>;Ledu/wpi/first/smartdashboard/properties/PropertyHolder;Ljava/lang/String;TT;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 140, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GenericProperty(Class clazz, PropertyHolder element, string name, object defaultValue)
      : base(element, name, defaultValue)
    {
      GenericProperty genericProperty = this;
      this.clazz = clazz;
    }

    [Signature("()TT;")]
    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object getValue()
    {
      return this.clazz.cast(base.getValue());
    }

    [Signature("(Ljava/lang/Object;)TT;")]
    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object transformValue(object value)
    {
      if (this.clazz.isInstance(value))
        return this.clazz.cast(value);
      else
        return (object) null;
    }

    [Signature("()TT;")]
    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object getDefault()
    {
      return this.clazz.cast(base.getDefault());
    }
  }
}
