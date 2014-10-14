// Decompiled with JetBrains decompiler
// Type: org.jfree.util.DefaultConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.@base.config;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"org.jfree.base.config.ModifiableConfiguration"})]
  [Serializable]
  public class DefaultConfiguration : Properties, ModifiableConfiguration, Configuration, Serializable.__Interface, Cloneable.__Interface
  {
    [HideFromJava]
    static DefaultConfiguration()
    {
      Properties.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultConfiguration()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultConfiguration([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultConfiguration obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultConfiguration obj0)
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

    [LineNumberTable((ushort) 78)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key)
    {
      return this.getProperty(key);
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getConfigProperty(string key, string defaultValue)
    {
      return this.getProperty(key, defaultValue);
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 102, (byte) 103, (byte) 136, (byte) 108, (byte) 137, (byte) 137, (byte) 168, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Iterator findPropertyKeys(string prefix)
    {
      TreeSet treeSet = new TreeSet();
      Enumeration enumeration = ((Hashtable) this).keys();
      while (enumeration.hasMoreElements())
      {
        string str = (string) enumeration.nextElement();
        if (String.instancehelper_startsWith(str, prefix) && !treeSet.contains((object) str))
          treeSet.add((object) str);
      }
      return Collections.unmodifiableSet((Set) treeSet).iterator();
    }

    [LineNumberTable((ushort) 128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Enumeration getConfigProperties()
    {
      return ((Hashtable) this).keys();
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 131, (byte) 202, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setConfigProperty(string key, string value)
    {
      if (value == null)
        ((Hashtable) this).remove((object) key);
      else
        this.setProperty(key, value);
    }

    [HideFromJava]
    object Configuration.org\u002Ejfree\u002Eutil\u002EConfiguration\u002F\u0028\u0029Ljava\u002Elang\u002EObject\u003Bclone()
    {
      return ((Hashtable) this).clone();
    }
  }
}
