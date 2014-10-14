// Decompiled with JetBrains decompiler
// Type: org.jfree.base.config.HierarchicalConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.@base.config;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.@base.config
{
  [Implements(new string[] {"org.jfree.base.config.ModifiableConfiguration", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class HierarchicalConfiguration : Object, ModifiableConfiguration, Configuration, Serializable.__Interface, Cloneable.__Interface, PublicCloneable, ISerializable
  {
    private Properties configuration;
    [NonSerialized]
    private Configuration parentConfiguration;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HierarchicalConfiguration()
    {
      base.\u002Ector();
      HierarchicalConfiguration hierarchicalConfiguration = this;
      this.configuration = new Properties();
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HierarchicalConfiguration(Configuration parentConfiguration)
      : this()
    {
      HierarchicalConfiguration hierarchicalConfiguration = this;
      this.parentConfiguration = parentConfiguration;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HierarchicalConfiguration([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HierarchicalConfiguration obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HierarchicalConfiguration obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 108, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertConfiguration(HierarchicalConfiguration config)
    {
      config.setParentConfig(this.getParentConfig());
      this.setParentConfig((Configuration) config);
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 109, (byte) 131, (byte) 136, (byte) 196, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key, string defaultValue)
    {
      return this.configuration.getProperty(key) ?? (!this.isRootConfig() ? this.parentConfiguration.getConfigProperty(key, defaultValue) : defaultValue);
    }

    private bool isRootConfig()
    {
      return this.parentConfiguration == null;
    }

    protected internal virtual Configuration getParentConfig()
    {
      return this.parentConfiguration;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 137, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setParentConfig(Configuration config)
    {
      if (this.parentConfiguration == this)
      {
        string str = "Cannot add myself as parent configuration.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.parentConfiguration = config;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 103, (byte) 136, (byte) 108, (byte) 137, (byte) 137, (byte) 168, (byte) 130, (byte) 136, (byte) 103, (byte) 136, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void collectPropertyKeys([In] string obj0, [In] Configuration obj1, [In] TreeSet obj2)
    {
      Enumeration configProperties = obj1.getConfigProperties();
      while (configProperties.hasMoreElements())
      {
        string str = (string) configProperties.nextElement();
        if (String.instancehelper_startsWith(str, obj0) && !obj2.contains((object) str))
          obj2.add((object) str);
      }
      if (!(obj1 is HierarchicalConfiguration))
        return;
      HierarchicalConfiguration hierarchicalConfiguration = (HierarchicalConfiguration) obj1;
      if (hierarchicalConfiguration.parentConfiguration == null)
        return;
      this.collectPropertyKeys(obj0, hierarchicalConfiguration.parentConfiguration, obj2);
    }

    protected internal virtual bool isParentSaved()
    {
      return true;
    }

    protected internal virtual void configurationLoaded()
    {
    }

    [LineNumberTable((ushort) 105)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key)
    {
      return this.getConfigProperty(key, (string) null);
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 131, (byte) 171, (byte) 131, (byte) 207, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setConfigProperty(string key, string value)
    {
      if (key == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else if (value == null)
        ((Hashtable) this.configuration).remove((object) key);
      else
        this.configuration.setProperty(key, value);
    }

    [LineNumberTable((ushort) 178)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isLocallyDefined(string key)
    {
      return (((Hashtable) this.configuration).containsKey((object) key) ? 1 : 0) != 0;
    }

    protected internal virtual Properties getConfiguration()
    {
      return this.configuration;
    }

    [LineNumberTable((ushort) 241)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Enumeration getConfigProperties()
    {
      return ((Hashtable) this.configuration).keys();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator findPropertyKeys(string prefix)
    {
      TreeSet treeSet = new TreeSet();
      this.collectPropertyKeys(prefix, (Configuration) this, treeSet);
      return Collections.unmodifiableSet((Set) treeSet).iterator();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 102, (byte) 136, (byte) 201, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      if (!this.isParentSaved())
      {
        obj0.writeBoolean(false);
      }
      else
      {
        obj0.writeBoolean(true);
        obj0.writeObject((object) this.parentConfiguration);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 102, (byte) 103, (byte) 131, (byte) 211, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.parentConfiguration = !obj0.readBoolean() ? (Configuration) null : (Configuration) obj0.readObject();
      this.configurationLoaded();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      HierarchicalConfiguration hierarchicalConfiguration = (HierarchicalConfiguration) base.clone();
      hierarchicalConfiguration.configuration = (Properties) ((Hashtable) this.configuration).clone();
      return (object) hierarchicalConfiguration;
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
