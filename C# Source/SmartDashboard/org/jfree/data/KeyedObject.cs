// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedObject
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
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class KeyedObject : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2677930479256885863L;
    private IComparable key;
    private object @object;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedObject(IComparable key, object @object)
    {
      base.\u002Ector();
      KeyedObject keyedObject = this;
      this.key = key;
      this.@object = @object;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected KeyedObject([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] KeyedObject obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] KeyedObject obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    public virtual object getObject()
    {
      return this.@object;
    }

    public virtual void setObject(object @object)
    {
      this.@object = @object;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 63, (byte) 108, (byte) 109, (byte) 108, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      KeyedObject keyedObject = (KeyedObject) base.clone();
      if (this.@object is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.@object;
        keyedObject.@object = publicCloneable.clone();
      }
      return (object) keyedObject;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 100, (byte) 162, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 162, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyedObject))
        return false;
      KeyedObject keyedObject = (KeyedObject) obj;
      return ObjectUtilities.equal((object) this.key, (object) keyedObject.key) && ObjectUtilities.equal(this.@object, keyedObject.@object);
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
