// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.CustomXYURLGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
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
  [Implements(new string[] {"org.jfree.chart.urls.XYURLGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class CustomXYURLGenerator : Object, XYURLGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -8565933356596551832L;
    private ArrayList urlSeries;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 232, (byte) 58, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomXYURLGenerator()
    {
      base.\u002Ector();
      CustomXYURLGenerator customXyurlGenerator = this;
      this.urlSeries = new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CustomXYURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CustomXYURLGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CustomXYURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getListCount()
    {
      return this.urlSeries.size();
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 98, (byte) 105, (byte) 114, (byte) 99, (byte) 105, (byte) 205})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getURL(int series, int item)
    {
      string str = (string) null;
      if (series < this.getListCount())
      {
        List list = (List) this.urlSeries.get(series);
        if (list != null && item < list.size())
          str = (string) list.get(item);
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getURLCount(int list)
    {
      int num = 0;
      List list1 = (List) this.urlSeries.get(list);
      if (list1 != null)
        num = list1.size();
      return num;
    }

    [LineNumberTable((ushort) 132)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(XYDataset dataset, int series, int item)
    {
      return this.getURL(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 98, (byte) 99, (byte) 135, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addURLSeries(List urls)
    {
      ArrayList arrayList = (ArrayList) null;
      if (urls != null)
        arrayList = new ArrayList((Collection) urls);
      this.urlSeries.add((object) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 103, (byte) 105, (byte) 162, (byte) 105, (byte) 104, (byte) 106, (byte) 162, (byte) 104, (byte) 107, (byte) 107, (byte) 100, (byte) 107, (byte) 194, (byte) 100, (byte) 226, (byte) 54, (byte) 232, (byte) 58, (byte) 233, (byte) 85})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CustomXYURLGenerator))
        return false;
      CustomXYURLGenerator customXyurlGenerator = (CustomXYURLGenerator) obj;
      int listCount = this.getListCount();
      if (listCount != customXyurlGenerator.getListCount())
        return false;
      for (int index1 = 0; index1 < listCount; ++index1)
      {
        int urlCount = this.getURLCount(index1);
        if (urlCount != customXyurlGenerator.getURLCount(index1))
          return false;
        for (int index2 = 0; index2 < urlCount; ++index2)
        {
          string url1 = this.getURL(index1, index2);
          string url2 = customXyurlGenerator.getURL(index1, index2);
          if (url1 != null)
          {
            if (!String.instancehelper_equals(url1, (object) url2))
              return false;
          }
          else if (url2 != null)
            return false;
        }
      }
      return true;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      CustomXYURLGenerator customXyurlGenerator = (CustomXYURLGenerator) base.clone();
      customXyurlGenerator.urlSeries = new ArrayList((Collection) this.urlSeries);
      return (object) customXyurlGenerator;
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
