// Decompiled with JetBrains decompiler
// Type: org.jfree.util.AbstractObjectList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
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
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class AbstractObjectList : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7789833772597351595L;
    public const int DEFAULT_INITIAL_CAPACITY = 8;
    [NonSerialized]
    private object[] objects;
    private int size;
    private int increment;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractObjectList(int initialCapacity)
      : this(initialCapacity, initialCapacity)
    {
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 232, (byte) 36, (byte) 167, (byte) 231, (byte) 90, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractObjectList(int initialCapacity, int increment)
    {
      base.\u002Ector();
      AbstractObjectList abstractObjectList = this;
      this.size = 0;
      this.increment = 8;
      this.objects = new object[initialCapacity];
      this.increment = increment;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractObjectList()
      : this(8)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractObjectList([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractObjectList obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractObjectList obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int size()
    {
      return this.size;
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 98, (byte) 109, (byte) 137})]
    protected internal virtual object get(int index)
    {
      object obj = (object) null;
      if (index >= 0 && index < this.size)
        obj = this.objects[index];
      return obj;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 100, (byte) 144, (byte) 106, (byte) 110, (byte) 117, (byte) 135, (byte) 105, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void set(int index, object @object)
    {
      if (index < 0)
      {
        string str = "Requires index >= 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (index >= this.objects.Length)
        {
          object[] objArray = new object[index + this.increment];
          ByteCodeHelper.arraycopy((object) this.objects, 0, (object) objArray, 0, this.objects.Length);
          this.objects = objArray;
        }
        this.objects[index] = @object;
        this.size = Math.max(this.size, index + 1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      Arrays.fill(this.objects, (object) null);
      this.size = 0;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 107, (byte) 107, (byte) 2, (byte) 230, (byte) 69})]
    protected internal virtual int indexOf(object @object)
    {
      for (int index = 0; index < this.size; ++index)
      {
        if (this.objects[index] == @object)
          return index;
      }
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 99, (byte) 162, (byte) 100, (byte) 162, (byte) 104, (byte) 162, (byte) 103, (byte) 103, (byte) 102, (byte) 117, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this)
        return true;
      if (!(obj is AbstractObjectList))
        return false;
      AbstractObjectList abstractObjectList = (AbstractObjectList) obj;
      int num = this.size();
      for (int index = 0; index < num; ++index)
      {
        if (!ObjectUtilities.equal(this.get(index), abstractObjectList.get(index)))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 209)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 108, (byte) 104, (byte) 114, (byte) 218})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractObjectList abstractObjectList = (AbstractObjectList) base.clone();
      if (this.objects != null)
      {
        abstractObjectList.objects = new object[this.objects.Length];
        ByteCodeHelper.arraycopy((object) this.objects, 0, (object) abstractObjectList.objects, 0, this.objects.Length);
      }
      return (object) abstractObjectList;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 102, (byte) 103, (byte) 103, (byte) 102, (byte) 104, (byte) 107, (byte) 103, (byte) 169, (byte) 231, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int num = this.size();
      obj0.writeInt(num);
      for (int index = 0; index < num; ++index)
      {
        object obj = this.get(index);
        if (obj != null && Serializable.IsInstance(obj))
        {
          obj0.writeInt(index);
          obj0.writeObject(obj);
        }
        else
          obj0.writeInt(-1);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 102, (byte) 113, (byte) 103, (byte) 102, (byte) 103, (byte) 100, (byte) 237, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.objects = new object[this.size];
      int num = obj0.readInt();
      for (int index1 = 0; index1 < num; ++index1)
      {
        int index2 = obj0.readInt();
        if (index2 != -1)
          this.set(index2, obj0.readObject());
      }
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
