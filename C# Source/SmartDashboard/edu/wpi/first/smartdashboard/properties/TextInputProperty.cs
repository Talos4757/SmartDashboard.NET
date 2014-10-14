// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.TextInputProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing.table;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [Signature("<T:Ljava/lang/Object;>Ledu/wpi/first/smartdashboard/properties/GenericProperty<TT;>;")]
  public abstract class TextInputProperty : GenericProperty
  {
    [Signature("(Ljava/lang/Class<TT;>;Ledu/wpi/first/smartdashboard/properties/PropertyHolder;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal TextInputProperty(Class clazz, PropertyHolder element, string name)
      : base(clazz, element, name)
    {
    }

    [Signature("(Ljava/lang/Class<TT;>;Ledu/wpi/first/smartdashboard/properties/PropertyHolder;Ljava/lang/String;TT;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal TextInputProperty(Class clazz, PropertyHolder element, string name, object defaultValue)
      : base(clazz, element, name, defaultValue)
    {
    }

    public override TableCellRenderer getRenderer()
    {
      return (TableCellRenderer) null;
    }
  }
}
