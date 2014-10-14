// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.AbstractPieItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class AbstractPieItemLabelGenerator : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7347703325267846275L;
    private string labelFormat;
    private NumberFormat numberFormat;
    private NumberFormat percentFormat;

    [LineNumberTable(new byte[] {(byte) 34, (byte) 136, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractPieItemLabelGenerator(string labelFormat, NumberFormat numberFormat, NumberFormat percentFormat)
    {
      base.\u002Ector();
      AbstractPieItemLabelGenerator itemLabelGenerator = this;
      if (labelFormat == null)
      {
        string str = "Null 'labelFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (numberFormat == null)
      {
        string str = "Null 'numberFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (percentFormat == null)
      {
        string str = "Null 'percentFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFormat = labelFormat;
        this.numberFormat = numberFormat;
        this.percentFormat = percentFormat;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractPieItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractPieItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 103, (byte) 104, (byte) 105, (byte) 104, (byte) 99, (byte) 177, (byte) 136, (byte) 102, (byte) 99, (byte) 105, (byte) 105, (byte) 166, (byte) 111, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(PieDataset dataset, IComparable key)
    {
      object[] objArray = new object[4];
      double num1 = DatasetUtilities.calculatePieDatasetTotal(dataset);
      objArray[0] = (object) Object.instancehelper_toString((object) key);
      Number number = dataset.getValue(key);
      objArray[1] = number == null ? (object) "null" : (object) ((Format) this.numberFormat).format((object) number);
      double num2 = 0.0;
      if (number != null)
      {
        double num3 = number.doubleValue();
        if (num3 > 0.0)
          num2 = num3 / num1;
      }
      objArray[2] = (object) this.percentFormat.format(num2);
      objArray[3] = (object) this.numberFormat.format(num1);
      return objArray;
    }

    public virtual string getLabelFormat()
    {
      return this.labelFormat;
    }

    public virtual NumberFormat getNumberFormat()
    {
      return this.numberFormat;
    }

    public virtual NumberFormat getPercentFormat()
    {
      return this.percentFormat;
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 98, (byte) 99, (byte) 105, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string generateSectionLabel(PieDataset dataset, IComparable key)
    {
      string str = (string) null;
      if (dataset != null)
        str = MessageFormat.format(this.labelFormat, this.createItemArray(dataset, key));
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractPieItemLabelGenerator))
        return false;
      AbstractPieItemLabelGenerator itemLabelGenerator = (AbstractPieItemLabelGenerator) obj;
      return String.instancehelper_equals(this.labelFormat, (object) itemLabelGenerator.labelFormat) && this.numberFormat.equals((object) itemLabelGenerator.numberFormat) && this.percentFormat.equals((object) itemLabelGenerator.percentFormat);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 99, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode((int) sbyte.MaxValue, this.labelFormat), (object) this.numberFormat), (object) this.percentFormat);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 140, (byte) 104, (byte) 150, (byte) 104, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractPieItemLabelGenerator itemLabelGenerator = (AbstractPieItemLabelGenerator) base.clone();
      if (this.numberFormat != null)
        itemLabelGenerator.numberFormat = (NumberFormat) this.numberFormat.clone();
      if (this.percentFormat != null)
        itemLabelGenerator.percentFormat = (NumberFormat) this.percentFormat.clone();
      return (object) itemLabelGenerator;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
