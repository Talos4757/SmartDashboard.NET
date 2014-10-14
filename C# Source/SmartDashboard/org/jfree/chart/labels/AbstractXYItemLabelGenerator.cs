// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.AbstractXYItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class AbstractXYItemLabelGenerator : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5869744396278660636L;
    private string formatString;
    private NumberFormat xFormat;
    private DateFormat xDateFormat;
    private NumberFormat yFormat;
    private DateFormat yDateFormat;
    private string nullYString;

    [LineNumberTable(new byte[] {(byte) 63, (byte) 232, (byte) 42, (byte) 235, (byte) 88, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemLabelGenerator(string formatString, NumberFormat xFormat, NumberFormat yFormat)
    {
      base.\u002Ector();
      AbstractXYItemLabelGenerator itemLabelGenerator = this;
      this.nullYString = "null";
      if (formatString == null)
      {
        string str = "Null 'formatString' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xFormat == null)
      {
        string str = "Null 'xFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (yFormat == null)
      {
        string str = "Null 'yFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.formatString = formatString;
        this.xFormat = xFormat;
        this.yFormat = yFormat;
      }
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemLabelGenerator()
      : this("{2}", NumberFormat.getNumberInstance(), NumberFormat.getNumberInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 111, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemLabelGenerator(string formatString, DateFormat xFormat, NumberFormat yFormat)
      : this(formatString, NumberFormat.getInstance(), yFormat)
    {
      AbstractXYItemLabelGenerator itemLabelGenerator = this;
      this.xDateFormat = xFormat;
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 111, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemLabelGenerator(string formatString, NumberFormat xFormat, DateFormat yFormat)
      : this(formatString, xFormat, NumberFormat.getInstance())
    {
      AbstractXYItemLabelGenerator itemLabelGenerator = this;
      this.yDateFormat = yFormat;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 147, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemLabelGenerator(string formatString, DateFormat xFormat, DateFormat yFormat)
      : this(formatString, NumberFormat.getInstance(), NumberFormat.getInstance())
    {
      AbstractXYItemLabelGenerator itemLabelGenerator = this;
      this.xDateFormat = xFormat;
      this.yDateFormat = yFormat;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractXYItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractXYItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractXYItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 103, (byte) 143, (byte) 106, (byte) 104, (byte) 187, (byte) 175, (byte) 106, (byte) 114, (byte) 171, (byte) 104, (byte) 187, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(XYDataset dataset, int series, int item)
    {
      object[] objArray = new object[3];
      objArray[0] = (object) Object.instancehelper_toString((object) dataset.getSeriesKey(series));
      double xvalue = dataset.getXValue(series, item);
      objArray[1] = this.xDateFormat == null ? (object) this.xFormat.format(xvalue) : (object) this.xDateFormat.format(new Date(ByteCodeHelper.d2l(xvalue)));
      double yvalue = dataset.getYValue(series, item);
      objArray[2] = !Double.isNaN(yvalue) || dataset.getY(series, item) != null ? (this.yDateFormat == null ? (object) this.yFormat.format(yvalue) : (object) this.yDateFormat.format(new Date(ByteCodeHelper.d2l(yvalue)))) : (object) this.nullYString;
      return objArray;
    }

    public virtual string getFormatString()
    {
      return this.formatString;
    }

    public virtual NumberFormat getXFormat()
    {
      return this.xFormat;
    }

    public virtual DateFormat getXDateFormat()
    {
      return this.xDateFormat;
    }

    public virtual NumberFormat getYFormat()
    {
      return this.yFormat;
    }

    public virtual DateFormat getYDateFormat()
    {
      return this.yDateFormat;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 98, (byte) 106, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabelString(XYDataset dataset, int series, int item)
    {
      return MessageFormat.format(this.formatString, this.createItemArray(dataset, series, item));
    }

    public virtual string getNullYString()
    {
      return this.nullYString;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractXYItemLabelGenerator))
        return false;
      AbstractXYItemLabelGenerator itemLabelGenerator = (AbstractXYItemLabelGenerator) obj;
      return String.instancehelper_equals(this.formatString, (object) itemLabelGenerator.formatString) && ObjectUtilities.equal((object) this.xFormat, (object) itemLabelGenerator.xFormat) && (ObjectUtilities.equal((object) this.xDateFormat, (object) itemLabelGenerator.xDateFormat) && ObjectUtilities.equal((object) this.yFormat, (object) itemLabelGenerator.yFormat)) && (ObjectUtilities.equal((object) this.yDateFormat, (object) itemLabelGenerator.yDateFormat) && String.instancehelper_equals(this.nullYString, (object) itemLabelGenerator.nullYString));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 99, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode((int) sbyte.MaxValue, this.formatString), (object) this.xFormat), (object) this.xDateFormat), (object) this.yFormat), (object) this.yDateFormat);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 140, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractXYItemLabelGenerator itemLabelGenerator = (AbstractXYItemLabelGenerator) base.clone();
      if (this.xFormat != null)
        itemLabelGenerator.xFormat = (NumberFormat) this.xFormat.clone();
      if (this.yFormat != null)
        itemLabelGenerator.yFormat = (NumberFormat) this.yFormat.clone();
      if (this.xDateFormat != null)
        itemLabelGenerator.xDateFormat = (DateFormat) this.xDateFormat.clone();
      if (this.yDateFormat != null)
        itemLabelGenerator.yDateFormat = (DateFormat) this.yDateFormat.clone();
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
