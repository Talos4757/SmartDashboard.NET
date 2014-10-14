// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.AxisLocation
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class AxisLocation : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static AxisLocation __\u003C\u003ETOP_OR_LEFT = new AxisLocation("AxisLocation.TOP_OR_LEFT");
    internal static AxisLocation __\u003C\u003ETOP_OR_RIGHT = new AxisLocation("AxisLocation.TOP_OR_RIGHT");
    internal static AxisLocation __\u003C\u003EBOTTOM_OR_LEFT = new AxisLocation("AxisLocation.BOTTOM_OR_LEFT");
    internal static AxisLocation __\u003C\u003EBOTTOM_OR_RIGHT = new AxisLocation("AxisLocation.BOTTOM_OR_RIGHT");
    private const long serialVersionUID = -3276922179323563410L;
    private string name;

    [Modifiers]
    public static AxisLocation TOP_OR_LEFT
    {
      [HideFromJava] get
      {
        return AxisLocation.__\u003C\u003ETOP_OR_LEFT;
      }
    }

    [Modifiers]
    public static AxisLocation TOP_OR_RIGHT
    {
      [HideFromJava] get
      {
        return AxisLocation.__\u003C\u003ETOP_OR_RIGHT;
      }
    }

    [Modifiers]
    public static AxisLocation BOTTOM_OR_LEFT
    {
      [HideFromJava] get
      {
        return AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT;
      }
    }

    [Modifiers]
    public static AxisLocation BOTTOM_OR_RIGHT
    {
      [HideFromJava] get
      {
        return AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 207, (byte) 207, (byte) 207})]
    static AxisLocation()
    {
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private AxisLocation([In] string obj0)
    {
      base.\u002Ector();
      AxisLocation axisLocation = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AxisLocation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AxisLocation obj0)
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

    [LineNumberTable(new byte[] {(byte) 90, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 136, (byte) 104, (byte) 136, (byte) 104, (byte) 136, (byte) 104, (byte) 168, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AxisLocation getOpposite(AxisLocation location)
    {
      if (location == null)
      {
        string str = "Null 'location' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (location == AxisLocation.__\u003C\u003ETOP_OR_LEFT)
          return AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT;
        if (location == AxisLocation.__\u003C\u003ETOP_OR_RIGHT)
          return AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT;
        if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT)
          return AxisLocation.__\u003C\u003ETOP_OR_RIGHT;
        if (location == AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT)
          return AxisLocation.__\u003C\u003ETOP_OR_LEFT;
        string str = "AxisLocation not recognised.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is AxisLocation && String.instancehelper_equals(this.name, (object) ((AxisLocation) obj).toString());
    }

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisLocation getOpposite()
    {
      return AxisLocation.getOpposite(this);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 120, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) AxisLocation.__\u003C\u003ETOP_OR_RIGHT))
        return (object) AxisLocation.__\u003C\u003ETOP_OR_RIGHT;
      if (this.equals((object) AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT))
        return (object) AxisLocation.__\u003C\u003EBOTTOM_OR_RIGHT;
      if (this.equals((object) AxisLocation.__\u003C\u003ETOP_OR_LEFT))
        return (object) AxisLocation.__\u003C\u003ETOP_OR_LEFT;
      if (this.equals((object) AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT))
        return (object) AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT;
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
