// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.AreaRendererEndType
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

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class AreaRendererEndType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static AreaRendererEndType __\u003C\u003ETAPER = new AreaRendererEndType("AreaRendererEndType.TAPER");
    internal static AreaRendererEndType __\u003C\u003ETRUNCATE = new AreaRendererEndType("AreaRendererEndType.TRUNCATE");
    internal static AreaRendererEndType __\u003C\u003ELEVEL = new AreaRendererEndType("AreaRendererEndType.LEVEL");
    private const long serialVersionUID = -1774146392916359839L;
    private string name;

    [Modifiers]
    public static AreaRendererEndType TAPER
    {
      [HideFromJava] get
      {
        return AreaRendererEndType.__\u003C\u003ETAPER;
      }
    }

    [Modifiers]
    public static AreaRendererEndType TRUNCATE
    {
      [HideFromJava] get
      {
        return AreaRendererEndType.__\u003C\u003ETRUNCATE;
      }
    }

    [Modifiers]
    public static AreaRendererEndType LEVEL
    {
      [HideFromJava] get
      {
        return AreaRendererEndType.__\u003C\u003ELEVEL;
      }
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 239, (byte) 70, (byte) 239, (byte) 70})]
    static AreaRendererEndType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private AreaRendererEndType([In] string obj0)
    {
      base.\u002Ector();
      AreaRendererEndType areaRendererEndType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AreaRendererEndType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AreaRendererEndType obj0)
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

    [LineNumberTable(new byte[] {(byte) 53, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is AreaRendererEndType && String.instancehelper_equals(this.name, (object) ((AreaRendererEndType) obj).toString());
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 77, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      AreaRendererEndType areaRendererEndType = (AreaRendererEndType) null;
      if (this.equals((object) AreaRendererEndType.__\u003C\u003ELEVEL))
        areaRendererEndType = AreaRendererEndType.__\u003C\u003ELEVEL;
      else if (this.equals((object) AreaRendererEndType.__\u003C\u003ETAPER))
        areaRendererEndType = AreaRendererEndType.__\u003C\u003ETAPER;
      else if (this.equals((object) AreaRendererEndType.__\u003C\u003ETRUNCATE))
        areaRendererEndType = AreaRendererEndType.__\u003C\u003ETRUNCATE;
      return (object) areaRendererEndType;
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
