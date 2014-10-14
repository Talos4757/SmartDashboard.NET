// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.AbstractCategoryItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.util.PublicCloneable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractCategoryItemLabelGenerator : Object, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -7108591260223293197L;
    private string labelFormat;
    private string nullValueString;
    private NumberFormat numberFormat;
    private DateFormat dateFormat;
    private NumberFormat percentFormat;

    [LineNumberTable(new byte[] {(byte) 72, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractCategoryItemLabelGenerator(string labelFormat, NumberFormat formatter, NumberFormat percentFormatter)
    {
      base.\u002Ector();
      AbstractCategoryItemLabelGenerator itemLabelGenerator = this;
      if (labelFormat == null)
      {
        string str = "Null 'labelFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (percentFormatter == null)
      {
        string str = "Null 'percentFormatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFormat = labelFormat;
        this.numberFormat = formatter;
        this.percentFormat = percentFormatter;
        this.dateFormat = (DateFormat) null;
        this.nullValueString = "-";
      }
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractCategoryItemLabelGenerator(string labelFormat, NumberFormat formatter)
      : this(labelFormat, formatter, NumberFormat.getPercentInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractCategoryItemLabelGenerator(string labelFormat, DateFormat formatter)
    {
      base.\u002Ector();
      AbstractCategoryItemLabelGenerator itemLabelGenerator = this;
      if (labelFormat == null)
      {
        string str = "Null 'labelFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFormat = labelFormat;
        this.numberFormat = (NumberFormat) null;
        this.percentFormat = NumberFormat.getPercentInstance();
        this.dateFormat = formatter;
        this.nullValueString = "-";
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractCategoryItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractCategoryItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractCategoryItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 103, (byte) 111, (byte) 111, (byte) 105, (byte) 99, (byte) 104, (byte) 145, (byte) 104, (byte) 209, (byte) 137, (byte) 99, (byte) 105, (byte) 106, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(CategoryDataset dataset, int row, int column)
    {
      object[] objArray = new object[4]
      {
        (object) Object.instancehelper_toString((object) dataset.getRowKey(row)),
        (object) Object.instancehelper_toString((object) dataset.getColumnKey(column)),
        null,
        null
      };
      Number number = dataset.getValue(row, column);
      if (number != null)
      {
        if (this.numberFormat != null)
          objArray[2] = (object) ((Format) this.numberFormat).format((object) number);
        else if (this.dateFormat != null)
          objArray[2] = (object) ((Format) this.dateFormat).format((object) number);
      }
      else
        objArray[2] = (object) this.nullValueString;
      if (number != null)
      {
        double num1 = DataUtilities.calculateColumnTotal((Values2D) dataset, column);
        double num2 = number.doubleValue() / num1;
        objArray[3] = (object) this.percentFormat.format(num2);
      }
      return objArray;
    }

    [LineNumberTable((ushort) 171)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateRowLabel(CategoryDataset dataset, int row)
    {
      return Object.instancehelper_toString((object) dataset.getRowKey(row));
    }

    [LineNumberTable((ushort) 183)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateColumnLabel(CategoryDataset dataset, int column)
    {
      return Object.instancehelper_toString((object) dataset.getColumnKey(column));
    }

    public virtual string getLabelFormat()
    {
      return this.labelFormat;
    }

    public virtual NumberFormat getNumberFormat()
    {
      return this.numberFormat;
    }

    public virtual DateFormat getDateFormat()
    {
      return this.dateFormat;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 99, (byte) 144, (byte) 98, (byte) 106, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string generateLabelString(CategoryDataset dataset, int row, int column)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return MessageFormat.format(this.labelFormat, this.createItemArray(dataset, row, column));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractCategoryItemLabelGenerator))
        return false;
      AbstractCategoryItemLabelGenerator itemLabelGenerator = (AbstractCategoryItemLabelGenerator) obj;
      return String.instancehelper_equals(this.labelFormat, (object) itemLabelGenerator.labelFormat) && ObjectUtilities.equal((object) this.dateFormat, (object) itemLabelGenerator.dateFormat) && ObjectUtilities.equal((object) this.numberFormat, (object) itemLabelGenerator.numberFormat);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 99, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode((int) sbyte.MaxValue, this.labelFormat), this.nullValueString), (object) this.dateFormat), (object) this.numberFormat), (object) this.percentFormat);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 140, (byte) 104, (byte) 150, (byte) 104, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractCategoryItemLabelGenerator itemLabelGenerator = (AbstractCategoryItemLabelGenerator) base.clone();
      if (this.numberFormat != null)
        itemLabelGenerator.numberFormat = (NumberFormat) this.numberFormat.clone();
      if (this.dateFormat != null)
        itemLabelGenerator.dateFormat = (DateFormat) this.dateFormat.clone();
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
