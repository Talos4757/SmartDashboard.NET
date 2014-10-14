// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.util.XYCoordinateType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.util
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class XYCoordinateType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static XYCoordinateType __\u003C\u003EDATA = new XYCoordinateType("XYCoordinateType.DATA");
    internal static XYCoordinateType __\u003C\u003ERELATIVE = new XYCoordinateType("XYCoordinateType.RELATIVE");
    internal static XYCoordinateType __\u003C\u003EINDEX = new XYCoordinateType("XYCoordinateType.INDEX");
    private string name;

    [Modifiers]
    public static XYCoordinateType DATA
    {
      [HideFromJava] get
      {
        return XYCoordinateType.__\u003C\u003EDATA;
      }
    }

    [Modifiers]
    public static XYCoordinateType RELATIVE
    {
      [HideFromJava] get
      {
        return XYCoordinateType.__\u003C\u003ERELATIVE;
      }
    }

    [Modifiers]
    public static XYCoordinateType INDEX
    {
      [HideFromJava] get
      {
        return XYCoordinateType.__\u003C\u003EINDEX;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 239, (byte) 71, (byte) 239, (byte) 71})]
    static XYCoordinateType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private XYCoordinateType([In] string obj0)
    {
      base.\u002Ector();
      XYCoordinateType xyCoordinateType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYCoordinateType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYCoordinateType obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is XYCoordinateType && String.instancehelper_equals(this.name, (object) ((XYCoordinateType) obj).toString());
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 73, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) XYCoordinateType.__\u003C\u003EDATA))
        return (object) XYCoordinateType.__\u003C\u003EDATA;
      if (this.equals((object) XYCoordinateType.__\u003C\u003ERELATIVE))
        return (object) XYCoordinateType.__\u003C\u003ERELATIVE;
      if (this.equals((object) XYCoordinateType.__\u003C\u003EINDEX))
        return (object) XYCoordinateType.__\u003C\u003EINDEX;
      else
        return (object) null;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    object IObjectReference.IObjectReference\u002EGetRealObject([In] StreamingContext obj0)
    {
      return this.readResolve();
    }
  }
}
