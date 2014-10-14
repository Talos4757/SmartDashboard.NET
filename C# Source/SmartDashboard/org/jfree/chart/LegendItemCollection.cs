// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.LegendItemCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class LegendItemCollection : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1365215565589815953L;
    private List items;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItemCollection()
    {
      base.\u002Ector();
      LegendItemCollection legendItemCollection = this;
      this.items = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendItemCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LegendItemCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LegendItemCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(LegendItem item)
    {
      this.items.add((object) item);
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAll(LegendItemCollection collection)
    {
      this.items.addAll((Collection) collection.items);
    }

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItem get(int index)
    {
      return (LegendItem) this.items.get(index);
    }

    [LineNumberTable((ushort) 107)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.items.size();
    }

    [LineNumberTable((ushort) 116)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator iterator()
    {
      return this.items.iterator();
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is LegendItemCollection && Object.instancehelper_equals((object) this.items, (object) ((LegendItemCollection) obj).items);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 99, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      LegendItemCollection legendItemCollection = (LegendItemCollection) base.clone();
      legendItemCollection.items = (List) ObjectUtilities.deepClone((Collection) this.items);
      return (object) legendItemCollection;
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
