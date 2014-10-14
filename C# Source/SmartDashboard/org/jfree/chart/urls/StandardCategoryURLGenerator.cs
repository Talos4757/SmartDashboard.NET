// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.StandardCategoryURLGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data.category;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.urls
{
  [Implements(new string[] {"org.jfree.chart.urls.CategoryURLGenerator", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardCategoryURLGenerator : Object, CategoryURLGenerator, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2276668053074881909L;
    private string prefix;
    private string seriesParameterName;
    private string categoryParameterName;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 232, (byte) 52, (byte) 171, (byte) 171, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryURLGenerator()
    {
      base.\u002Ector();
      StandardCategoryURLGenerator categoryUrlGenerator = this;
      this.prefix = "index.html";
      this.seriesParameterName = "series";
      this.categoryParameterName = "category";
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 232, (byte) 44, (byte) 171, (byte) 171, (byte) 235, (byte) 79, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryURLGenerator(string prefix)
    {
      base.\u002Ector();
      StandardCategoryURLGenerator categoryUrlGenerator = this;
      this.prefix = "index.html";
      this.seriesParameterName = "series";
      this.categoryParameterName = "category";
      if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.prefix = prefix;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 232, (byte) 26, (byte) 171, (byte) 171, (byte) 235, (byte) 98, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryURLGenerator(string prefix, string seriesParameterName, string categoryParameterName)
    {
      base.\u002Ector();
      StandardCategoryURLGenerator categoryUrlGenerator = this;
      this.prefix = "index.html";
      this.seriesParameterName = "series";
      this.categoryParameterName = "category";
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
      else if (categoryParameterName == null)
      {
        string str = "Null 'categoryParameterName' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.prefix = prefix;
        this.seriesParameterName = seriesParameterName;
        this.categoryParameterName = categoryParameterName;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardCategoryURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardCategoryURLGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardCategoryURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 103, (byte) 104, (byte) 104, (byte) 111, (byte) 127, (byte) 6, (byte) 159, (byte) 28, (byte) 159, (byte) 38})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(CategoryDataset dataset, int series, int category)
    {
      string str = this.prefix;
      IComparable rowKey = dataset.getRowKey(series);
      IComparable columnKey = dataset.getColumnKey(category);
      int num = String.instancehelper_indexOf(str, "?") == -1 ? 1 : 0;
      return new StringBuffer().append(new StringBuffer().append(new StringBuffer().append(str).append(num == 0 ? "&amp;" : "?").toString()).append(this.seriesParameterName).append("=").append(URLUtilities.encode(Object.instancehelper_toString((object) rowKey), "UTF-8")).toString()).append("&amp;").append(this.categoryParameterName).append("=").append(URLUtilities.encode(Object.instancehelper_toString((object) columnKey), "UTF-8")).toString();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 165)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 162, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardCategoryURLGenerator))
        return false;
      StandardCategoryURLGenerator categoryUrlGenerator = (StandardCategoryURLGenerator) obj;
      return ObjectUtilities.equal((object) this.prefix, (object) categoryUrlGenerator.prefix) && ObjectUtilities.equal((object) this.seriesParameterName, (object) categoryUrlGenerator.seriesParameterName) && ObjectUtilities.equal((object) this.categoryParameterName, (object) categoryUrlGenerator.categoryParameterName);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 119, (byte) 188, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * (this.prefix == null ? 0 : String.instancehelper_hashCode(this.prefix)) + (this.seriesParameterName == null ? 0 : String.instancehelper_hashCode(this.seriesParameterName))) + (this.categoryParameterName == null ? 0 : String.instancehelper_hashCode(this.categoryParameterName));
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
