// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.IntegerListProperty
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing.table;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.properties
{
  public class IntegerListProperty : Property
  {
    private string valueSplit;
    private string delimiter;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 235, (byte) 56, (byte) 107, (byte) 235, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegerListProperty(PropertyHolder parent, string name, int[] value)
      : base(parent, name, (object) value)
    {
      IntegerListProperty integerListProperty = this;
      this.valueSplit = ", ";
      this.delimiter = ",";
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 234, (byte) 60, (byte) 107, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegerListProperty(PropertyHolder parent, string name)
      : base(parent, name)
    {
      IntegerListProperty integerListProperty = this;
      this.valueSplit = ", ";
      this.delimiter = ",";
    }

    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] getValue()
    {
      // ISSUE: explicit non-virtual call
      return (int[]) __nonvirtual (((Property) this).getValue());
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 102, (byte) 103, (byte) 103, (byte) 100, (byte) 156, (byte) 249, (byte) 60, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getSaveValue()
    {
      string str = "";
      int[] numArray = this.getValue();
      for (int index = 0; index < numArray.Length; ++index)
      {
        if (index > 0)
          str = new StringBuilder().append(str).append(this.valueSplit).toString();
        str = new StringBuilder().append(str).append(numArray[index]).toString();
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 107, (byte) 135, (byte) 109, (byte) 136, (byte) 135, (byte) 187, (byte) 2, (byte) 97, (byte) 226, (byte) 60, (byte) 230, (byte) 71, (byte) 98, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int[] transformValue(object value)
    {
      if (value is string)
      {
        string[] strArray = String.instancehelper_split((string) value, this.delimiter);
        int[] numArray = new int[strArray.Length];
        for (int index = 0; index < strArray.Length; ++index)
        {
          try
          {
            numArray[index] = Integer.parseInt(String.instancehelper_trim(strArray[index]));
            continue;
          }
          catch (NumberFormatException ex)
          {
          }
          return (int[]) null;
        }
        return numArray;
      }
      else if (value is int[])
        return (int[]) value;
      else
        return (int[]) null;
    }

    protected internal virtual void setValueSplit(string split)
    {
      this.valueSplit = split;
    }

    protected internal virtual void setDelimeter(string delimiter)
    {
      this.delimiter = delimiter;
    }

    [LineNumberTable((ushort) 54)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object getTableValue()
    {
      return (object) this.getSaveValue();
    }

    public override TableCellRenderer getRenderer()
    {
      return (TableCellRenderer) null;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    object Property.\u003Cbridge\u003EtransformValue(object x0)
    {
      return (object) this.transformValue(x0);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object \u003Cbridge\u003EgetValue()
    {
      return (object) this.getValue();
    }
  }
}
