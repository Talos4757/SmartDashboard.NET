// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.HighLowItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
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
  [Implements(new string[] {"org.jfree.chart.labels.XYItemLabelGenerator", "org.jfree.chart.labels.XYToolTipGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class HighLowItemLabelGenerator : Object, XYItemLabelGenerator, XYToolTipGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5617111754832211830L;
    private DateFormat dateFormatter;
    private NumberFormat numberFormatter;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HighLowItemLabelGenerator()
      : this(DateFormat.getInstance(), NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 104, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HighLowItemLabelGenerator(DateFormat dateFormatter, NumberFormat numberFormatter)
    {
      base.\u002Ector();
      HighLowItemLabelGenerator itemLabelGenerator = this;
      if (dateFormatter == null)
      {
        string str = "Null 'dateFormatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (numberFormatter == null)
      {
        string str = "Null 'numberFormatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dateFormatter = dateFormatter;
        this.numberFormatter = numberFormatter;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HighLowItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HighLowItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HighLowItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 130, (byte) 107, (byte) 103, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 138, (byte) 141, (byte) 103, (byte) 115, (byte) 127, (byte) 14, (byte) 99, (byte) 191, (byte) 18, (byte) 99, (byte) 191, (byte) 18, (byte) 100, (byte) 191, (byte) 19, (byte) 100, (byte) 255, (byte) 19, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(XYDataset dataset, int series, int item)
    {
      string str = (string) null;
      if (dataset is OHLCDataset)
      {
        OHLCDataset ohlcDataset = (OHLCDataset) dataset;
        Number high = ohlcDataset.getHigh(series, item);
        Number low = ohlcDataset.getLow(series, item);
        Number open = ohlcDataset.getOpen(series, item);
        Number close = ohlcDataset.getClose(series, item);
        Number x = ohlcDataset.getX(series, item);
        str = Object.instancehelper_toString((object) ohlcDataset.getSeriesKey(series));
        if (x != null)
        {
          Date.__\u003Cclinit\u003E();
          Date date = new Date(x.longValue());
          str = new StringBuffer().append(str).append("--> Date=").append(this.dateFormatter.format(date)).toString();
          if (high != null)
            str = new StringBuffer().append(str).append(" High=").append(this.numberFormatter.format(high.doubleValue())).toString();
          if (low != null)
            str = new StringBuffer().append(str).append(" Low=").append(this.numberFormatter.format(low.doubleValue())).toString();
          if (open != null)
            str = new StringBuffer().append(str).append(" Open=").append(this.numberFormatter.format(open.doubleValue())).toString();
          if (close != null)
            str = new StringBuffer().append(str).append(" Close=").append(this.numberFormatter.format(close.doubleValue())).toString();
        }
      }
      return str;
    }

    public virtual string generateLabel(XYDataset dataset, int series, int category)
    {
      return (string) null;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 172, (byte) 104, (byte) 150, (byte) 104, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      HighLowItemLabelGenerator itemLabelGenerator = (HighLowItemLabelGenerator) base.clone();
      if (this.dateFormatter != null)
        itemLabelGenerator.dateFormatter = (DateFormat) this.dateFormatter.clone();
      if (this.numberFormatter != null)
        itemLabelGenerator.numberFormatter = (NumberFormat) this.numberFormatter.clone();
      return (object) itemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is HighLowItemLabelGenerator))
        return false;
      HighLowItemLabelGenerator itemLabelGenerator = (HighLowItemLabelGenerator) obj;
      return this.dateFormatter.equals((object) itemLabelGenerator.dateFormatter) && this.numberFormatter.equals((object) itemLabelGenerator.numberFormatter);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 99, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode((int) sbyte.MaxValue, (object) this.dateFormatter), (object) this.numberFormatter);
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
