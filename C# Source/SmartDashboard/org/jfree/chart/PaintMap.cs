// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.PaintMap
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.io;
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
  public class PaintMap : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -4639833772123069274L;
    [NonSerialized]
    private Map store;

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaintMap()
    {
      base.\u002Ector();
      PaintMap paintMap = this;
      this.store = (Map) new HashMap();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaintMap([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PaintMap obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PaintMap obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(IComparable key)
    {
      if (key != null)
        return (Paint) this.store.get((object) key);
      string str = "Null 'key' argument.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 111)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsKey(IComparable key)
    {
      return (this.store.containsKey((object) key) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 99, (byte) 144, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void put(IComparable key, Paint paint)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.store.put((object) key, (object) paint);
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.store.clear();
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 120, (byte) 130, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 105, (byte) 105, (byte) 107, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PaintMap))
        return false;
      PaintMap paintMap = (PaintMap) obj;
      if (this.store.size() != paintMap.store.size())
        return false;
      Iterator iterator = this.store.keySet().iterator();
      while (iterator.hasNext())
      {
        IComparable key = (IComparable) iterator.next();
        if (!PaintUtilities.equal(this.getPaint(key), paintMap.getPaint(key)))
          return false;
      }
      return true;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 102, (byte) 113, (byte) 108, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 104, (byte) 103, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      obj0.writeInt(this.store.size());
      Iterator iterator = this.store.keySet().iterator();
      while (iterator.hasNext())
      {
        IComparable key = (IComparable) iterator.next();
        obj0.writeObject((object) key);
        SerialUtilities.writePaint(this.getPaint(key), obj0);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 102, (byte) 107, (byte) 103, (byte) 102, (byte) 108, (byte) 103, (byte) 238, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.store = (Map) new HashMap();
      int num = obj0.readInt();
      for (int index = 0; index < num; ++index)
        this.store.put((object) (IComparable) obj0.readObject(), (object) SerialUtilities.readPaint(obj0));
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
