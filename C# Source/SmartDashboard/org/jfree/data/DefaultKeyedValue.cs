// Decompiled with JetBrains decompiler
// Type: org.jfree.data.DefaultKeyedValue
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
  [Implements(new string[] {"org.jfree.data.KeyedValue", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultKeyedValue : Object, KeyedValue, Value, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -7388924517460437712L;
    private IComparable key;
    private Number value;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValue(IComparable key, Number value)
    {
      base.\u002Ector();
      DefaultKeyedValue defaultKeyedValue = this;
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.key = key;
        this.value = value;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultKeyedValue([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultKeyedValue obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultKeyedValue obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    public virtual Number getValue()
    {
      return this.value;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual void setValue(Number value)
    {
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 159, (byte) 6, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultKeyedValue))
        return false;
      DefaultKeyedValue defaultKeyedValue = (DefaultKeyedValue) obj;
      if (!Object.instancehelper_equals((object) this.key, (object) defaultKeyedValue.key))
        return false;
      if (this.value != null)
      {
        if (Object.instancehelper_equals((object) this.value, (object) defaultKeyedValue.value))
          goto label_10;
      }
      else if (defaultKeyedValue.value == null)
        goto label_10;
      return false;
label_10:
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 119, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (this.key == null ? 0 : Object.instancehelper_hashCode((object) this.key)) + (this.value == null ? 0 : Object.instancehelper_hashCode((object) this.value));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 112, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (DefaultKeyedValue) base.clone();
    }

    [LineNumberTable((ushort) 173)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("(").append(Object.instancehelper_toString((object) this.key)).append(", ").append(Object.instancehelper_toString((object) this.value)).append(")").toString();
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
