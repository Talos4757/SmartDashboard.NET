// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedValueComparatorType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.data
{
  public sealed class KeyedValueComparatorType : Object
  {
    internal static KeyedValueComparatorType __\u003C\u003EBY_KEY = new KeyedValueComparatorType("KeyedValueComparatorType.BY_KEY");
    internal static KeyedValueComparatorType __\u003C\u003EBY_VALUE = new KeyedValueComparatorType("KeyedValueComparatorType.BY_VALUE");
    private string name;

    [Modifiers]
    public static KeyedValueComparatorType BY_KEY
    {
      [HideFromJava] get
      {
        return KeyedValueComparatorType.__\u003C\u003EBY_KEY;
      }
    }

    [Modifiers]
    public static KeyedValueComparatorType BY_VALUE
    {
      [HideFromJava] get
      {
        return KeyedValueComparatorType.__\u003C\u003EBY_VALUE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 207})]
    static KeyedValueComparatorType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private KeyedValueComparatorType([In] string obj0)
    {
      base.\u002Ector();
      KeyedValueComparatorType valueComparatorType = this;
      this.name = obj0;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is KeyedValueComparatorType && String.instancehelper_equals(this.name, (object) ((KeyedValueComparatorType) o).name);
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }
  }
}
