// Decompiled with JetBrains decompiler
// Type: org.jfree.util.Rotation
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

namespace org.jfree.util
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class Rotation : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static Rotation __\u003C\u003ECLOCKWISE = new Rotation("Rotation.CLOCKWISE", -1.0);
    internal static Rotation __\u003C\u003EANTICLOCKWISE = new Rotation("Rotation.ANTICLOCKWISE", 1.0);
    private const long serialVersionUID = -4662815260201591676L;
    private string name;
    private double factor;

    [Modifiers]
    public static Rotation CLOCKWISE
    {
      [HideFromJava] get
      {
        return Rotation.__\u003C\u003ECLOCKWISE;
      }
    }

    [Modifiers]
    public static Rotation ANTICLOCKWISE
    {
      [HideFromJava] get
      {
        return Rotation.__\u003C\u003EANTICLOCKWISE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 216})]
    static Rotation()
    {
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rotation([In] string obj0, [In] double obj1)
    {
      base.\u002Ector();
      Rotation rotation = this;
      this.name = obj0;
      this.factor = obj1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Rotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Rotation obj0)
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

    [LineNumberTable(new byte[] {(byte) 65, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 110, (byte) 162})]
    public virtual bool equals(object o)
    {
      return this == o || o is Rotation && this.factor == ((Rotation) o).factor;
    }

    public virtual string toString()
    {
      return this.name;
    }

    public virtual double getFactor()
    {
      return this.factor;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      long num = Double.doubleToLongBits(this.factor);
      return (int) (num ^ (long) ((ulong) num >> 32));
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 99, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) Rotation.__\u003C\u003ECLOCKWISE))
        return (object) Rotation.__\u003C\u003ECLOCKWISE;
      if (this.equals((object) Rotation.__\u003C\u003EANTICLOCKWISE))
        return (object) Rotation.__\u003C\u003EANTICLOCKWISE;
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
