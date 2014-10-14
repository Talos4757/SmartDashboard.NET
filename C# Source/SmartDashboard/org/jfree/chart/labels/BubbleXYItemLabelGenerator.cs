// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.BubbleXYItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYItemLabelGenerator", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class BubbleXYItemLabelGenerator : AbstractXYItemLabelGenerator, XYItemLabelGenerator, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    internal const long serialVersionUID = -8458568928021240922L;
    public const string DEFAULT_FORMAT_STRING = "{3}";
    private NumberFormat zFormat;
    private DateFormat zDateFormat;

    [LineNumberTable(new byte[] {(byte) 60, (byte) 107, (byte) 100, (byte) 144, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BubbleXYItemLabelGenerator(string formatString, NumberFormat xFormat, NumberFormat yFormat, NumberFormat zFormat)
      : base(formatString, xFormat, yFormat)
    {
      BubbleXYItemLabelGenerator itemLabelGenerator = this;
      if (zFormat == null)
      {
        string str = "Null 'zFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.zFormat = zFormat;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BubbleXYItemLabelGenerator()
      : this("{3}", NumberFormat.getNumberInstance(), NumberFormat.getNumberInstance(), NumberFormat.getNumberInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 107, (byte) 100, (byte) 144, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BubbleXYItemLabelGenerator(string formatString, DateFormat xFormat, DateFormat yFormat, DateFormat zFormat)
      : base(formatString, xFormat, yFormat)
    {
      BubbleXYItemLabelGenerator itemLabelGenerator = this;
      if (zFormat == null)
      {
        string str = "Null 'zFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.zDateFormat = zFormat;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BubbleXYItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BubbleXYItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BubbleXYItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 98, (byte) 98, (byte) 104, (byte) 177, (byte) 138, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string generateLabelString(XYDataset dataset, int series, int item)
    {
      return MessageFormat.format(this.getFormatString(), !(dataset is XYZDataset) ? base.createItemArray(dataset, series, item) : this.createItemArray((XYZDataset) dataset, series, item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 103, (byte) 143, (byte) 105, (byte) 103, (byte) 99, (byte) 172, (byte) 175, (byte) 105, (byte) 104, (byte) 100, (byte) 173, (byte) 175, (byte) 106, (byte) 104, (byte) 178, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[] createItemArray(XYZDataset dataset, int series, int item)
    {
      object[] objArray = new object[4];
      objArray[0] = (object) Object.instancehelper_toString((object) dataset.getSeriesKey(series));
      Number x = dataset.getX(series, item);
      DateFormat xdateFormat = this.getXDateFormat();
      objArray[1] = xdateFormat == null ? (object) ((Format) this.getXFormat()).format((object) x) : (object) ((Format) xdateFormat).format((object) x);
      Number y = dataset.getY(series, item);
      DateFormat ydateFormat = this.getYDateFormat();
      objArray[2] = ydateFormat == null ? (object) ((Format) this.getYFormat()).format((object) y) : (object) ((Format) ydateFormat).format((object) y);
      Number z = dataset.getZ(series, item);
      objArray[3] = this.zDateFormat == null ? (object) ((Format) this.zFormat).format((object) z) : (object) ((Format) this.zDateFormat).format((object) z);
      return objArray;
    }

    public virtual NumberFormat getZFormat()
    {
      return this.zFormat;
    }

    public virtual DateFormat getZDateFormat()
    {
      return this.zDateFormat;
    }

    [LineNumberTable((ushort) 166)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(XYDataset dataset, int series, int item)
    {
      return this.generateLabelString(dataset, series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BubbleXYItemLabelGenerator) || !base.equals(obj))
        return false;
      BubbleXYItemLabelGenerator itemLabelGenerator = (BubbleXYItemLabelGenerator) obj;
      return ObjectUtilities.equal((object) this.zFormat, (object) itemLabelGenerator.zFormat) && ObjectUtilities.equal((object) this.zDateFormat, (object) itemLabelGenerator.zDateFormat);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 103, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(base.hashCode(), (object) this.zFormat), (object) this.zDateFormat);
    }
  }
}
