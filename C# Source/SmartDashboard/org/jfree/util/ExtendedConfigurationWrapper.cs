// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ExtendedConfigurationWrapper
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
  [Implements(new string[] {"org.jfree.util.ExtendedConfiguration"})]
  [Serializable]
  public class ExtendedConfigurationWrapper : Object, ExtendedConfiguration, Configuration, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    private Configuration parent;

    [LineNumberTable(new byte[] {(byte) 15, (byte) 104, (byte) 131, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExtendedConfigurationWrapper(Configuration parent)
    {
      base.\u002Ector();
      ExtendedConfigurationWrapper configurationWrapper = this;
      if (parent == null)
      {
        string str = "Parent given must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.parent = parent;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ExtendedConfigurationWrapper([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ExtendedConfigurationWrapper obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ExtendedConfigurationWrapper obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 97)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getBoolProperty(string name, bool defaultValue)
    {
      int num = defaultValue ? 1 : 0;
      return (String.instancehelper_equals("true", (object) this.parent.getConfigProperty(name, String.valueOf(num != 0))) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 109, (byte) 131, (byte) 194, (byte) 159, (byte) 0, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIntProperty(string name, int defaultValue)
    {
      string configProperty = this.parent.getConfigProperty(name);
      if (configProperty == null)
        return defaultValue;
      int num1;
      try
      {
        num1 = Integer.parseInt(configProperty);
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
        else
          goto label_6;
      }
      return num1;
label_6:
      return defaultValue;
    }

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getBoolProperty(string name)
    {
      return (this.getBoolProperty(name, false) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIntProperty(string name)
    {
      return this.getIntProperty(name, 0);
    }

    [LineNumberTable((ushort) 146)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isPropertySet(string name)
    {
      return this.parent.getConfigProperty(name) != null;
    }

    [LineNumberTable((ushort) 157)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator findPropertyKeys(string prefix)
    {
      return this.parent.findPropertyKeys(prefix);
    }

    [LineNumberTable((ushort) 168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key)
    {
      return this.parent.getConfigProperty(key);
    }

    [LineNumberTable((ushort) 184)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key, string defaultValue)
    {
      return this.parent.getConfigProperty(key, defaultValue);
    }

    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Enumeration getConfigProperties()
    {
      return this.parent.getConfigProperties();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      ((ExtendedConfigurationWrapper) base.clone()).parent = (Configuration) this.parent.clone();
      return (object) this.parent;
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
