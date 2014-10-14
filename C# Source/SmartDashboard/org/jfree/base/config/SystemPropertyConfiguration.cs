// Decompiled with JetBrains decompiler
// Type: org.jfree.base.config.SystemPropertyConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.@base.config;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.@base.config
{
  [Serializable]
  public class SystemPropertyConfiguration : HierarchicalConfiguration
  {
    [LineNumberTable(new byte[] {(byte) 11, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SystemPropertyConfiguration()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SystemPropertyConfiguration([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 71)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setConfigProperty(string key, string value)
    {
      string str = "The SystemPropertyConfiguration is readOnly";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException(str);
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 103, (byte) 99, (byte) 244, (byte) 69, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getConfigProperty(string key, string defaultValue)
    {
      string str;
      try
      {
        string property = System.getProperty(key);
        if (property != null)
          str = property;
        else
          goto label_5;
      }
      catch (SecurityException ex)
      {
        goto label_4;
      }
      return str;
label_4:
label_5:
      return base.getConfigProperty(key, defaultValue);
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 154, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isLocallyDefined(string key)
    {
      int num;
      try
      {
        num = ((Hashtable) System.getProperties()).containsKey((object) key) ? 1 : 0;
      }
      catch (SecurityException ex)
      {
        goto label_3;
      }
      return num != 0;
label_3:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 153, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Enumeration getConfigProperties()
    {
      Enumeration enumeration;
      try
      {
        enumeration = ((Hashtable) System.getProperties()).keys();
      }
      catch (SecurityException ex)
      {
        goto label_3;
      }
      return enumeration;
label_3:
      return new Vector().elements();
    }
  }
}
