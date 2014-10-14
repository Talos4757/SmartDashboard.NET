// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.StandardEntityCollection
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

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"org.jfree.chart.entity.EntityCollection", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardEntityCollection : Object, EntityCollection, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5384773031184897047L;
    private List entities;

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardEntityCollection()
    {
      base.\u002Ector();
      StandardEntityCollection entityCollection = this;
      this.entities = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardEntityCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardEntityCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardEntityCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAll(EntityCollection collection)
    {
      this.entities.addAll(collection.getEntities());
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 99, (byte) 144, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(ChartEntity entity)
    {
      if (entity == null)
      {
        string str = "Null 'entity' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.entities.add((object) entity);
    }

    [LineNumberTable((ushort) 86)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getEntityCount()
    {
      return this.entities.size();
    }

    [LineNumberTable((ushort) 99)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ChartEntity getEntity(int index)
    {
      return (ChartEntity) this.entities.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.entities.clear();
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 108, (byte) 104, (byte) 114, (byte) 113, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ChartEntity getEntity(double x, double y)
    {
      int num = this.entities.size() - 1;
      while (num >= 0)
      {
        ChartEntity chartEntity = (ChartEntity) this.entities.get(num);
        if (chartEntity.getArea().contains(x, y))
          return chartEntity;
        num += -1;
      }
      return (ChartEntity) null;
    }

    [LineNumberTable((ushort) 157)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getEntities()
    {
      return Collections.unmodifiableCollection((Collection) this.entities);
    }

    [LineNumberTable((ushort) 166)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator iterator()
    {
      return this.entities.iterator();
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardEntityCollection))
        return false;
      return (ObjectUtilities.equal((object) this.entities, (object) ((StandardEntityCollection) obj).entities) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 140, (byte) 118, (byte) 112, (byte) 114, (byte) 18, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      StandardEntityCollection entityCollection = (StandardEntityCollection) base.clone();
      entityCollection.entities = (List) new ArrayList(this.entities.size());
      for (int index = 0; index < this.entities.size(); ++index)
      {
        ChartEntity chartEntity = (ChartEntity) this.entities.get(index);
        entityCollection.entities.add(chartEntity.clone());
      }
      return (object) entityCollection;
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
