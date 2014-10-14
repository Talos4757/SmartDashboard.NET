// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.CustomPieURLGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
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
  [Implements(new string[] {"org.jfree.chart.urls.PieURLGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class CustomPieURLGenerator : Object, PieURLGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7100607670144900503L;
    private ArrayList urls;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomPieURLGenerator()
    {
      base.\u002Ector();
      CustomPieURLGenerator customPieUrlGenerator = this;
      this.urls = new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CustomPieURLGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CustomPieURLGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CustomPieURLGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 98, (byte) 105, (byte) 114, (byte) 99, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getURL(IComparable key, int mapIndex)
    {
      string str = (string) null;
      if (mapIndex < this.getListCount())
      {
        Map map = (Map) this.urls.get(mapIndex);
        if (map != null)
          str = (string) map.get((object) key);
      }
      return str;
    }

    [LineNumberTable((ushort) 101)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getListCount()
    {
      return this.urls.size();
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getURLCount(int list)
    {
      int num = 0;
      Map map = (Map) this.urls.get(list);
      if (map != null)
        num = map.size();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addURLs(Map urlMap)
    {
      this.urls.add((object) urlMap);
    }

    [LineNumberTable((ushort) 90)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURL(PieDataset dataset, IComparable key, int pieIndex)
    {
      return this.getURL(key, pieIndex);
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 100, (byte) 162, (byte) 107, (byte) 103, (byte) 110, (byte) 162, (byte) 110, (byte) 112, (byte) 130, (byte) 151, (byte) 111, (byte) 109, (byte) 153, (byte) 226, (byte) 54, (byte) 233, (byte) 78, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (o == this)
        return true;
      if (!(o is CustomPieURLGenerator))
        return false;
      CustomPieURLGenerator customPieUrlGenerator = (CustomPieURLGenerator) o;
      if (this.getListCount() != customPieUrlGenerator.getListCount())
        return false;
      for (int index = 0; index < this.getListCount(); ++index)
      {
        if (this.getURLCount(index) != customPieUrlGenerator.getURLCount(index))
          return false;
        Iterator iterator = ((HashMap) this.urls.get(index)).keySet().iterator();
        while (iterator.hasNext())
        {
          string str = (string) iterator.next();
          if (!String.instancehelper_equals(this.getURL((IComparable) str, index), (object) customPieUrlGenerator.getURL((IComparable) str, index)))
            return false;
        }
      }
      return true;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 230, (byte) 69, (byte) 119, (byte) 140, (byte) 102, (byte) 118, (byte) 110, (byte) 179, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      CustomPieURLGenerator customPieUrlGenerator = new CustomPieURLGenerator();
      Iterator iterator1 = this.urls.iterator();
      while (iterator1.hasNext())
      {
        Map map = (Map) iterator1.next();
        HashMap hashMap = new HashMap();
        Iterator iterator2 = map.keySet().iterator();
        while (iterator2.hasNext())
        {
          string str = (string) iterator2.next();
          ((Map) hashMap).put((object) str, map.get((object) str));
        }
        customPieUrlGenerator.addURLs((Map) hashMap);
      }
      return (object) customPieUrlGenerator;
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
