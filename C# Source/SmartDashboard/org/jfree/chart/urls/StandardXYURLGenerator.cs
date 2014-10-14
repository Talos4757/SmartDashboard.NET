// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.StandardXYURLGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data.xy;
using org.jfree.util;
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
  public class StandardXYURLGenerator : Object, XYURLGenerator, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -1771624523496595382L;
    public const string DEFAULT_PREFIX = "index.html";
    public const string DEFAULT_SERIES_PARAMETER = "series";
    public const string DEFAULT_ITEM_PARAMETER = "item";
    private string prefix;
    private string seriesParameterName;
    private string itemParameterName;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYURLGenerator()
      : this("index.html", "series", "item")
    {
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYURLGenerator(string prefix, string seriesParameterName, string itemParameterName)
    {
      base.\u002Ector();
      StandardXYURLGenerator standardXyurlGenerator = this;
      if (prefix == null)
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
        this.prefix = prefix;
        this.seriesParameterName = seriesParameterName;
        this.itemParameterName = itemParameterName;
      }
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYURLGenerator(string prefix)
      : this(prefix, "series", "item")
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardXYURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardXYURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 103, (byte) 111, (byte) 127, (byte) 6, (byte) 159, (byte) 50})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(XYDataset dataset, int series, int item)
    {
      string str = this.prefix;
      int num = String.instancehelper_indexOf(str, "?") == -1 ? 1 : 0;
      return new StringBuffer().append(new StringBuffer().append(str).append(num == 0 ? "&amp;" : "?").toString()).append(this.seriesParameterName).append("=").append(series).append("&amp;").append(this.itemParameterName).append("=").append(item).toString();
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardXYURLGenerator))
        return false;
      StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) obj;
      return ObjectUtilities.equal((object) standardXyurlGenerator.prefix, (object) this.prefix) && ObjectUtilities.equal((object) standardXyurlGenerator.seriesParameterName, (object) this.seriesParameterName) && ObjectUtilities.equal((object) standardXyurlGenerator.itemParameterName, (object) this.itemParameterName);
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
