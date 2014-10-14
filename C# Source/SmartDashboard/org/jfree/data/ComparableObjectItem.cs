// Decompiled with JetBrains decompiler
// Type: org.jfree.data.ComparableObjectItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"java.lang.Cloneable", "java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class ComparableObjectItem : Object, Cloneable.__Interface, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2751513470325494890L;
    private IComparable x;
    private object obj;

    [LineNumberTable(new byte[] {(byte) 21, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparableObjectItem(IComparable x, object y)
    {
      base.\u002Ector();
      ComparableObjectItem comparableObjectItem = this;
      if (x == null)
      {
        string str = "Null 'x' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.x = x;
        this.obj = y;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ComparableObjectItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ComparableObjectItem obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ComparableObjectItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    protected internal virtual IComparable getComparable()
    {
      return this.x;
    }

    protected internal virtual object getObject()
    {
      return this.obj;
    }

    protected internal virtual void setObject(object y)
    {
      this.obj = y;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 104, (byte) 103, (byte) 244, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object o1)
    {
      if (!(o1 is ComparableObjectItem))
        return 1;
      return Comparable.__Helper.compareTo(this.x, (object) ((ComparableObjectItem) o1).x);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 150)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ComparableObjectItem))
        return false;
      ComparableObjectItem comparableObjectItem = (ComparableObjectItem) obj;
      return Object.instancehelper_equals((object) this.x, (object) comparableObjectItem.x) && ObjectUtilities.equal(this.obj, comparableObjectItem.obj);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 108, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.x) + (this.obj == null ? 0 : Object.instancehelper_hashCode(this.obj));
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
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
