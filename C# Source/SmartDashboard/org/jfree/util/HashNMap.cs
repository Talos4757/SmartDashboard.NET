// Decompiled with JetBrains decompiler
// Type: org.jfree.util.HashNMap
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public class HashNMap : Object, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    [Modifiers]
    private static Iterator EMPTY_ITERATOR = (Iterator) new HashNMap.EmptyIterator((HashNMap.\u0031) null);
    [Modifiers]
    private static object[] EMPTY_ARRAY = new object[0];
    private const long serialVersionUID = -670924844536074826L;
    private HashMap table;

    [LineNumberTable(new byte[] {(byte) 77, (byte) 235, (byte) 74})]
    static HashNMap()
    {
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashNMap()
    {
      base.\u002Ector();
      HashNMap hashNmap = this;
      this.table = new HashMap();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HashNMap([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HashNMap obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HashNMap obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 152)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List createList()
    {
      return (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 114, (byte) 99, (byte) 103, (byte) 104, (byte) 110, (byte) 162, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool put(object key, object val)
    {
      List list1 = (List) this.table.get(key);
      if (list1 == null)
      {
        List list2 = this.createList();
        list2.add(val);
        this.table.put(key, (object) list2);
        return true;
      }
      else
      {
        list1.clear();
        return (list1.add(val) ? 1 : 0) != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 114, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object get(object key, int n)
    {
      List list = (List) this.table.get(key);
      if (list == null)
        return (object) null;
      return list.get(n);
    }

    [LineNumberTable((ushort) 303)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsKey(object key)
    {
      return (this.table.containsKey(key) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 113, (byte) 98, (byte) 107, (byte) 108, (byte) 104, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsValue(object value)
    {
      Iterator iterator = this.table.values().iterator();
      int num = 0;
      while (iterator.hasNext() && num == 0)
        num = ((List) iterator.next()).contains(value) ? 1 : 0;
      return num != 0;
    }

    [LineNumberTable((ushort) 245)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator keys()
    {
      return this.table.keySet().iterator();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 114, (byte) 99, (byte) 105, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool add(object key, object val)
    {
      List list = (List) this.table.get(key);
      if (list == null)
      {
        this.put(key, val);
        return true;
      }
      else
        return (list.add(val) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getFirst(object key)
    {
      return this.get(key, 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 114, (byte) 99, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator getAll(object key)
    {
      List list = (List) this.table.get(key);
      if (list == null)
        return HashNMap.EMPTY_ITERATOR;
      return list.iterator();
    }

    [LineNumberTable((ushort) 254)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Set keySet()
    {
      return this.table.keySet();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 114, (byte) 99, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool remove(object key, object value)
    {
      List list = (List) this.table.get(key);
      if (list == null || !list.remove(value))
        return false;
      if (list.size() == 0)
        this.table.remove(key);
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAll(object key)
    {
      this.table.remove(key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.table.clear();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 114, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsValue(object key, object value)
    {
      List list = (List) this.table.get(key);
      if (list == null)
        return false;
      return (list.contains(value) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool contains(object value)
    {
      if (this.containsKey(value))
        return true;
      return (this.containsValue(value) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 108, (byte) 107, (byte) 103, (byte) 104, (byte) 103, (byte) 114, (byte) 99, (byte) 147, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      HashNMap hashNmap = (HashNMap) base.clone();
      hashNmap.table = new HashMap();
      Iterator iterator = this.keys();
      while (iterator.hasNext())
      {
        object obj = iterator.next();
        List list = (List) hashNmap.table.get(obj);
        if (list != null)
          hashNmap.table.put(obj, ObjectUtilities.clone((object) list));
      }
      return (object) hashNmap;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 99, (byte) 144, (byte) 114, (byte) 99, (byte) 138, (byte) 101, (byte) 132})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] toArray(object key, object[] data)
    {
      if (key == null)
      {
        string str = "Key must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        List list = (List) this.table.get(key);
        if (list != null)
        {
          return list.toArray(data);
        }
        else
        {
          if (data.Length > 0)
            data[0] = (object) null;
          return data;
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 30, (byte) 99, (byte) 144, (byte) 114, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] toArray(object key)
    {
      if (key == null)
      {
        string str = "Key must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        List list = (List) this.table.get(key);
        if (list == null)
          return HashNMap.EMPTY_ARRAY;
        return list.toArray();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 99, (byte) 144, (byte) 114, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getValueCount(object key)
    {
      if (key == null)
      {
        string str = "Key must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        List list = (List) this.table.get(key);
        if (list == null)
          return 0;
        return list.size();
      }
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [InnerClass]
    [SourceFile("HashNMap.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.util.Iterator"})]
    [SourceFile("HashNMap.java")]
    internal sealed class EmptyIterator : Object, Iterator
    {
      [LineNumberTable((ushort) 74)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal EmptyIterator([In] HashNMap.\u0031 obj0)
        : this()
      {
      }

      [LineNumberTable(new byte[] {(byte) 30, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private EmptyIterator()
      {
        base.\u002Ector();
      }

      public virtual bool hasNext()
      {
        return false;
      }

      [LineNumberTable((ushort) 101)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object next()
      {
        string str = "This iterator is empty.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NoSuchElementException(str);
      }

      [LineNumberTable((ushort) 119)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void remove()
      {
        string str = "This iterator is empty, no remove supported.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnsupportedOperationException(str);
      }
    }
  }
}
