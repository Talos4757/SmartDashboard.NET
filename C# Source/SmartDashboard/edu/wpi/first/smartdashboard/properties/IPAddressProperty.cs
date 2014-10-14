// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.IPAddressProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  public class IPAddressProperty : IntegerListProperty
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 138, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPAddressProperty(PropertyHolder parent, string name)
      : base(parent, name)
    {
      IPAddressProperty ipAddressProperty = this;
      this.setDelimeter("\\.");
      this.setValueSplit(".");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 139, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPAddressProperty(PropertyHolder parent, string name, int[] value)
      : base(parent, name, value)
    {
      IPAddressProperty ipAddressProperty = this;
      this.setDelimeter("\\.");
      this.setValueSplit(".");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 104, (byte) 104, (byte) 130, (byte) 112, (byte) 110, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override int[] transformValue(object value)
    {
      int[] numArray1 = base.transformValue(value);
      if (numArray1 == null || numArray1.Length != 4)
        return (int[]) null;
      int[] numArray2 = numArray1;
      int length = numArray2.Length;
      for (int index = 0; index < length; ++index)
      {
        int num = numArray2[index];
        if (num < 0 || num > (int) byte.MaxValue)
          return (int[]) null;
      }
      return numArray1;
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
