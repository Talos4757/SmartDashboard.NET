// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedObjects
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

namespace org.jfree.data
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class KeyedObjects : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1321582394193530984L;
    private List data;

    [LineNumberTable(new byte[] {(byte) 16, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedObjects()
    {
      base.\u002Ector();
      KeyedObjects keyedObjects = this;
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected KeyedObjects([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] KeyedObjects obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] KeyedObjects obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 99, (byte) 144, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 110, (byte) 130, (byte) 100, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndex(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = 0;
        Iterator iterator = this.data.iterator();
        while (iterator.hasNext())
        {
          if (Object.instancehelper_equals((object) ((KeyedObject) iterator.next()).getKey(), (object) key))
            return num;
          ++num;
        }
        return -1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getObject(int item)
    {
      object obj = (object) null;
      KeyedObject keyedObject = (KeyedObject) this.data.get(item);
      if (keyedObject != null)
        obj = keyedObject.getObject();
      return obj;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 104, (byte) 100, (byte) 114, (byte) 103, (byte) 130, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setObject(IComparable key, object @object)
    {
      int index = this.getIndex(key);
      if (index >= 0)
        ((KeyedObject) this.data.get(index)).setObject(@object);
      else
        this.data.add((object) new KeyedObject(key, @object));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(int index)
    {
      this.data.remove(index);
    }

    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getKey(int index)
    {
      IComparable comparable = (IComparable) null;
      KeyedObject keyedObject = (KeyedObject) this.data.get(index);
      if (keyedObject != null)
        comparable = keyedObject.getKey();
      return comparable;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getKeys()
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
      {
        KeyedObject keyedObject = (KeyedObject) iterator.next();
        ((List) arrayList).add((object) keyedObject.getKey());
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 104, (byte) 100, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getObject(IComparable key)
    {
      int index = this.getIndex(key);
      if (index < 0)
      {
        string message = new StringBuffer().append("The key (").append((object) key).append(") is not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
        return this.getObject(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addObject(IComparable key, object @object)
    {
      this.setObject(key, @object);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 114, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 100, (byte) 141, (byte) 104, (byte) 110, (byte) 175, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertValue(int position, IComparable key, object value)
    {
      if (position < 0 || position > this.data.size())
      {
        string str = "'position' out of bounds.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int index = this.getIndex(key);
        if (index >= 0)
          this.data.remove(index);
        KeyedObject keyedObject = new KeyedObject(key, value);
        if (position <= this.data.size())
          this.data.add(position, (object) keyedObject);
        else
          this.data.add((object) keyedObject);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 104, (byte) 100, (byte) 191, (byte) 21, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(IComparable key)
    {
      int index = this.getIndex(key);
      if (index < 0)
      {
        string message = new StringBuffer().append("The key (").append(Object.instancehelper_toString((object) key)).append(") is not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
        this.removeValue(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.data.clear();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 108, (byte) 107, (byte) 108, (byte) 104, (byte) 108, (byte) 114, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      KeyedObjects keyedObjects = (KeyedObjects) base.clone();
      keyedObjects.data = (List) new ArrayList();
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
      {
        KeyedObject keyedObject = (KeyedObject) iterator.next();
        keyedObjects.data.add(keyedObject.clone());
      }
      return (object) keyedObjects;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 103, (byte) 105, (byte) 162, (byte) 105, (byte) 104, (byte) 105, (byte) 106, (byte) 130, (byte) 105, (byte) 105, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 49, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyedObjects))
        return false;
      KeyedObjects keyedObjects = (KeyedObjects) obj;
      int itemCount = this.getItemCount();
      if (itemCount != keyedObjects.getItemCount())
        return false;
      for (int index = 0; index < itemCount; ++index)
      {
        if (!Object.instancehelper_equals((object) this.getKey(index), (object) keyedObjects.getKey(index)))
          return false;
        object object1 = this.getObject(index);
        object object2 = keyedObjects.getObject(index);
        if (object1 == null)
        {
          if (object2 != null)
            return false;
        }
        else if (!Object.instancehelper_equals(object1, object2))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 352)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.data != null)
        return Object.instancehelper_hashCode((object) this.data);
      else
        return 0;
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
