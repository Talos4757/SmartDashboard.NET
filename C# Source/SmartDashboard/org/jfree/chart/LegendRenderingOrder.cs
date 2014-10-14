// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.LegendRenderingOrder
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

namespace org.jfree.chart
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class LegendRenderingOrder : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static LegendRenderingOrder __\u003C\u003ESTANDARD = new LegendRenderingOrder("LegendRenderingOrder.STANDARD");
    internal static LegendRenderingOrder __\u003C\u003EREVERSE = new LegendRenderingOrder("LegendRenderingOrder.REVERSE");
    private const long serialVersionUID = -3832486612685808616L;
    private string name;

    [Modifiers]
    public static LegendRenderingOrder STANDARD
    {
      [HideFromJava] get
      {
        return LegendRenderingOrder.__\u003C\u003ESTANDARD;
      }
    }

    [Modifiers]
    public static LegendRenderingOrder REVERSE
    {
      [HideFromJava] get
      {
        return LegendRenderingOrder.__\u003C\u003EREVERSE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 207})]
    static LegendRenderingOrder()
    {
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private LegendRenderingOrder([In] string obj0)
    {
      base.\u002Ector();
      LegendRenderingOrder legendRenderingOrder = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendRenderingOrder([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LegendRenderingOrder obj0)
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

    [LineNumberTable(new byte[] {(byte) 42, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is LegendRenderingOrder && String.instancehelper_equals(this.name, (object) ((LegendRenderingOrder) obj).toString());
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 63, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) LegendRenderingOrder.__\u003C\u003ESTANDARD))
        return (object) LegendRenderingOrder.__\u003C\u003ESTANDARD;
      if (this.equals((object) LegendRenderingOrder.__\u003C\u003EREVERSE))
        return (object) LegendRenderingOrder.__\u003C\u003EREVERSE;
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
