// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.IntervalXYItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYItemLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class IntervalXYItemLabelGenerator : AbstractXYItemLabelGenerator, XYItemLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    public const string DEFAULT_ITEM_LABEL_FORMAT = "{5} - {6}";

    [LineNumberTable(new byte[] {(byte) 37, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYItemLabelGenerator(string formatString, NumberFormat xFormat, NumberFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYItemLabelGenerator()
      : this("{5} - {6}", NumberFormat.getNumberInstance(), NumberFormat.getNumberInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYItemLabelGenerator(string formatString, DateFormat xFormat, NumberFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYItemLabelGenerator(string formatString, NumberFormat xFormat, DateFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYItemLabelGenerator(string formatString, DateFormat xFormat, DateFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntervalXYItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] IntervalXYItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] IntervalXYItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 98, (byte) 104, (byte) 135, (byte) 103, (byte) 143, (byte) 106, (byte) 98, (byte) 99, (byte) 107, (byte) 100, (byte) 100, (byte) 99, (byte) 106, (byte) 107, (byte) 107, (byte) 171, (byte) 104, (byte) 100, (byte) 117, (byte) 117, (byte) 184, (byte) 104, (byte) 107, (byte) 107, (byte) 172, (byte) 104, (byte) 104, (byte) 115, (byte) 171, (byte) 100, (byte) 184, (byte) 172, (byte) 147, (byte) 171, (byte) 100, (byte) 184, (byte) 172, (byte) 147, (byte) 171, (byte) 100, (byte) 184, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object[] createItemArray(XYDataset dataset, int series, int item)
    {
      IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) null;
      if (dataset is IntervalXYDataset)
        ntervalXyDataset = (IntervalXYDataset) dataset;
      object[] objArray = new object[7];
      objArray[0] = (object) Object.instancehelper_toString((object) dataset.getSeriesKey(series));
      double xvalue = dataset.getXValue(series, item);
      double num1 = xvalue;
      double num2 = xvalue;
      double yvalue = dataset.getYValue(series, item);
      double num3 = yvalue;
      double num4 = yvalue;
      if (ntervalXyDataset != null)
      {
        num1 = ntervalXyDataset.getStartXValue(series, item);
        num2 = ntervalXyDataset.getEndXValue(series, item);
        num3 = ntervalXyDataset.getStartYValue(series, item);
        num4 = ntervalXyDataset.getEndYValue(series, item);
      }
      DateFormat xdateFormat = this.getXDateFormat();
      if (xdateFormat != null)
      {
        objArray[1] = (object) xdateFormat.format(new Date(ByteCodeHelper.d2l(xvalue)));
        objArray[2] = (object) xdateFormat.format(new Date(ByteCodeHelper.d2l(num1)));
        objArray[3] = (object) xdateFormat.format(new Date(ByteCodeHelper.d2l(num2)));
      }
      else
      {
        NumberFormat xformat = this.getXFormat();
        objArray[1] = (object) xformat.format(xvalue);
        objArray[2] = (object) xformat.format(num1);
        objArray[3] = (object) xformat.format(num2);
      }
      NumberFormat yformat = this.getYFormat();
      DateFormat ydateFormat = this.getYDateFormat();
      objArray[4] = !Double.isNaN(yvalue) || dataset.getY(series, item) != null ? (ydateFormat == null ? (object) yformat.format(yvalue) : (object) ydateFormat.format(new Date(ByteCodeHelper.d2l(yvalue)))) : (object) this.getNullYString();
      objArray[5] = !Double.isNaN(num3) || ntervalXyDataset.getStartY(series, item) != null ? (ydateFormat == null ? (object) yformat.format(num3) : (object) ydateFormat.format(new Date(ByteCodeHelper.d2l(num3)))) : (object) this.getNullYString();
      objArray[6] = !Double.isNaN(num4) || ntervalXyDataset.getEndY(series, item) != null ? (ydateFormat == null ? (object) yformat.format(num4) : (object) ydateFormat.format(new Date(ByteCodeHelper.d2l(num4)))) : (object) this.getNullYString();
      return objArray;
    }

    [LineNumberTable((ushort) 237)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(XYDataset dataset, int series, int item)
    {
      return this.generateLabelString(dataset, series, item);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 248)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is IntervalXYItemLabelGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
