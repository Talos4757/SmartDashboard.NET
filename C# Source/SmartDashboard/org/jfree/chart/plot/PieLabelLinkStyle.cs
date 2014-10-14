// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PieLabelLinkStyle
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
  public sealed class PieLabelLinkStyle : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static PieLabelLinkStyle __\u003C\u003ESTANDARD = new PieLabelLinkStyle("PieLabelLinkStyle.STANDARD");
    internal static PieLabelLinkStyle __\u003C\u003EQUAD_CURVE = new PieLabelLinkStyle("PieLabelLinkStyle.QUAD_CURVE");
    internal static PieLabelLinkStyle __\u003C\u003ECUBIC_CURVE = new PieLabelLinkStyle("PieLabelLinkStyle.CUBIC_CURVE");
    private string name;

    [Modifiers]
    public static PieLabelLinkStyle STANDARD
    {
      [HideFromJava] get
      {
        return PieLabelLinkStyle.__\u003C\u003ESTANDARD;
      }
    }

    [Modifiers]
    public static PieLabelLinkStyle QUAD_CURVE
    {
      [HideFromJava] get
      {
        return PieLabelLinkStyle.__\u003C\u003EQUAD_CURVE;
      }
    }

    [Modifiers]
    public static PieLabelLinkStyle CUBIC_CURVE
    {
      [HideFromJava] get
      {
        return PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 207, (byte) 207})]
    static PieLabelLinkStyle()
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PieLabelLinkStyle([In] string obj0)
    {
      base.\u002Ector();
      PieLabelLinkStyle pieLabelLinkStyle = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PieLabelLinkStyle([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PieLabelLinkStyle obj0)
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

    [LineNumberTable(new byte[] {(byte) 46, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is PieLabelLinkStyle && String.instancehelper_equals(this.name, (object) ((PieLabelLinkStyle) obj).toString());
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 76, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      PieLabelLinkStyle pieLabelLinkStyle = (PieLabelLinkStyle) null;
      if (this.equals((object) PieLabelLinkStyle.__\u003C\u003ESTANDARD))
        pieLabelLinkStyle = PieLabelLinkStyle.__\u003C\u003ESTANDARD;
      else if (this.equals((object) PieLabelLinkStyle.__\u003C\u003EQUAD_CURVE))
        pieLabelLinkStyle = PieLabelLinkStyle.__\u003C\u003EQUAD_CURVE;
      else if (this.equals((object) PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE))
        pieLabelLinkStyle = PieLabelLinkStyle.__\u003C\u003ECUBIC_CURVE;
      return (object) pieLabelLinkStyle;
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
