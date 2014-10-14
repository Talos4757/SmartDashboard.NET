// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.TimeSeriesURLGenerator
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
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.urls
{
  [Implements(new string[] {"org.jfree.chart.urls.XYURLGenerator", "java.io.Serializable"})]
  [Serializable]
  public class TimeSeriesURLGenerator : Object, XYURLGenerator, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -9122773175671182445L;
    private DateFormat dateFormat;
    private string prefix;
    private string seriesParameterName;
    private string itemParameterName;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 232, (byte) 49, (byte) 171, (byte) 171, (byte) 171, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesURLGenerator()
    {
      base.\u002Ector();
      TimeSeriesURLGenerator seriesUrlGenerator = this;
      this.dateFormat = DateFormat.getInstance();
      this.prefix = "index.html";
      this.seriesParameterName = "series";
      this.itemParameterName = "item";
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 232, (byte) 34, (byte) 171, (byte) 171, (byte) 171, (byte) 235, (byte) 87, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 100, (byte) 208, (byte) 113, (byte) 103, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesURLGenerator(DateFormat dateFormat, string prefix, string seriesParameterName, string itemParameterName)
    {
      base.\u002Ector();
      TimeSeriesURLGenerator seriesUrlGenerator = this;
      this.dateFormat = DateFormat.getInstance();
      this.prefix = "index.html";
      this.seriesParameterName = "series";
      this.itemParameterName = "item";
      if (dateFormat == null)
      {
        string str = "Null 'dateFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (seriesParameterName == null)
      {
        string str = "Null 'seriesParameterName' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (itemParameterName == null)
      {
        string str = "Null 'itemParameterName' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dateFormat = (DateFormat) dateFormat.clone();
        this.prefix = prefix;
        this.seriesParameterName = seriesParameterName;
        this.itemParameterName = itemParameterName;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeriesURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimeSeriesURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DateFormat getDateFormat()
    {
      return (DateFormat) this.dateFormat.clone();
    }

    public virtual string getPrefix()
    {
      return this.prefix;
    }

    public virtual string getSeriesParameterName()
    {
      return this.seriesParameterName;
    }

    public virtual string getItemParameterName()
    {
      return this.itemParameterName;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 103, (byte) 111, (byte) 104, (byte) 102, (byte) 127, (byte) 6, (byte) 159, (byte) 28, (byte) 162, (byte) 110, (byte) 115, (byte) 127, (byte) 6, (byte) 191, (byte) 24})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(XYDataset dataset, int series, int item)
    {
      string str = this.prefix;
      int num = String.instancehelper_indexOf(str, "?") == -1 ? 1 : 0;
      IComparable seriesKey = dataset.getSeriesKey(series);
      if (seriesKey != null)
      {
        str = new StringBuffer().append(new StringBuffer().append(str).append(num == 0 ? "&amp;" : "?").toString()).append(this.seriesParameterName).append("=").append(URLUtilities.encode(Object.instancehelper_toString((object) seriesKey), "UTF-8")).toString();
        num = 0;
      }
      string s = this.dateFormat.format(new Date(ByteCodeHelper.d2l(dataset.getXValue(series, item))));
      return new StringBuffer().append(new StringBuffer().append(str).append(num == 0 ? "&amp;" : "?").toString()).append(this.itemParameterName).append("=").append(URLUtilities.encode(s, "UTF-8")).toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimeSeriesURLGenerator))
        return false;
      TimeSeriesURLGenerator seriesUrlGenerator = (TimeSeriesURLGenerator) obj;
      return this.dateFormat.equals((object) seriesUrlGenerator.dateFormat) && String.instancehelper_equals(this.itemParameterName, (object) seriesUrlGenerator.itemParameterName) && (String.instancehelper_equals(this.prefix, (object) seriesUrlGenerator.prefix) && String.instancehelper_equals(this.seriesParameterName, (object) seriesUrlGenerator.seriesParameterName));
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
