// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.DialShape
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

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class DialShape : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static DialShape __\u003C\u003ECIRCLE = new DialShape("DialShape.CIRCLE");
    internal static DialShape __\u003C\u003ECHORD = new DialShape("DialShape.CHORD");
    internal static DialShape __\u003C\u003EPIE = new DialShape("DialShape.PIE");
    private const long serialVersionUID = -3471933055190251131L;
    private string name;

    [Modifiers]
    public static DialShape CIRCLE
    {
      [HideFromJava] get
      {
        return DialShape.__\u003C\u003ECIRCLE;
      }
    }

    [Modifiers]
    public static DialShape CHORD
    {
      [HideFromJava] get
      {
        return DialShape.__\u003C\u003ECHORD;
      }
    }

    [Modifiers]
    public static DialShape PIE
    {
      [HideFromJava] get
      {
        return DialShape.__\u003C\u003EPIE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 175, (byte) 175})]
    static DialShape()
    {
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DialShape([In] string obj0)
    {
      base.\u002Ector();
      DialShape dialShape = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialShape([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DialShape obj0)
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

    [LineNumberTable(new byte[] {(byte) 45, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is DialShape && String.instancehelper_equals(this.name, (object) ((DialShape) obj).toString());
    }

    [LineNumberTable((ushort) 114)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 75, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) DialShape.__\u003C\u003ECIRCLE))
        return (object) DialShape.__\u003C\u003ECIRCLE;
      if (this.equals((object) DialShape.__\u003C\u003ECHORD))
        return (object) DialShape.__\u003C\u003ECHORD;
      if (this.equals((object) DialShape.__\u003C\u003EPIE))
        return (object) DialShape.__\u003C\u003EPIE;
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
