// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.StandardPieURLGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.urls
{
  [Implements(new string[] {"org.jfree.chart.urls.PieURLGenerator", "java.io.Serializable"})]
  [Serializable]
  public class StandardPieURLGenerator : Object, PieURLGenerator, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1626966402065883419L;
    private string prefix;
    private string categoryParameterName;
    private string indexParameterName;

    [LineNumberTable(new byte[] {(byte) 29, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieURLGenerator()
      : this("index.html")
    {
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieURLGenerator(string prefix)
      : this(prefix, "category")
    {
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieURLGenerator(string prefix, string categoryParameterName)
      : this(prefix, categoryParameterName, "pieIndex")
    {
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 232, (byte) 17, (byte) 171, (byte) 171, (byte) 235, (byte) 106, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieURLGenerator(string prefix, string categoryParameterName, string indexParameterName)
    {
      base.\u002Ector();
      StandardPieURLGenerator standardPieUrlGenerator = this;
      this.prefix = "index.html";
      this.categoryParameterName = "category";
      this.indexParameterName = "pieIndex";
      if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (categoryParameterName == null)
      {
        string str = "Null 'categoryParameterName' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.prefix = prefix;
        this.categoryParameterName = categoryParameterName;
        this.indexParameterName = indexParameterName;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardPieURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardPieURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 103, (byte) 110, (byte) 223, (byte) 40, (byte) 191, (byte) 38, (byte) 104, (byte) 191, (byte) 28})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(PieDataset dataset, IComparable key, int pieIndex)
    {
      string str1 = this.prefix;
      string str2 = String.instancehelper_indexOf(str1, "?") <= -1 ? new StringBuffer().append(str1).append("?").append(this.categoryParameterName).append("=").append(URLUtilities.encode(Object.instancehelper_toString((object) key), "UTF-8")).toString() : new StringBuffer().append(str1).append("&amp;").append(this.categoryParameterName).append("=").append(URLUtilities.encode(Object.instancehelper_toString((object) key), "UTF-8")).toString();
      if (this.indexParameterName != null)
        str2 = new StringBuffer().append(str2).append("&amp;").append(this.indexParameterName).append("=").append(String.valueOf(pieIndex)).toString();
      return str2;
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardPieURLGenerator))
        return false;
      StandardPieURLGenerator standardPieUrlGenerator = (StandardPieURLGenerator) obj;
      return String.instancehelper_equals(this.prefix, (object) standardPieUrlGenerator.prefix) && String.instancehelper_equals(this.categoryParameterName, (object) standardPieUrlGenerator.categoryParameterName) && ObjectUtilities.equal((object) this.indexParameterName, (object) standardPieUrlGenerator.indexParameterName);
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
