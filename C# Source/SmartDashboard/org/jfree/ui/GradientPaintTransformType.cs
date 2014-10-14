// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.GradientPaintTransformType
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

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class GradientPaintTransformType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static GradientPaintTransformType __\u003C\u003EVERTICAL = new GradientPaintTransformType("GradientPaintTransformType.VERTICAL");
    internal static GradientPaintTransformType __\u003C\u003EHORIZONTAL = new GradientPaintTransformType("GradientPaintTransformType.HORIZONTAL");
    internal static GradientPaintTransformType __\u003C\u003ECENTER_VERTICAL = new GradientPaintTransformType("GradientPaintTransformType.CENTER_VERTICAL");
    internal static GradientPaintTransformType __\u003C\u003ECENTER_HORIZONTAL = new GradientPaintTransformType("GradientPaintTransformType.CENTER_HORIZONTAL");
    private const long serialVersionUID = 8331561784933982450L;
    private string name;

    [Modifiers]
    public static GradientPaintTransformType VERTICAL
    {
      [HideFromJava] get
      {
        return GradientPaintTransformType.__\u003C\u003EVERTICAL;
      }
    }

    [Modifiers]
    public static GradientPaintTransformType HORIZONTAL
    {
      [HideFromJava] get
      {
        return GradientPaintTransformType.__\u003C\u003EHORIZONTAL;
      }
    }

    [Modifiers]
    public static GradientPaintTransformType CENTER_VERTICAL
    {
      [HideFromJava] get
      {
        return GradientPaintTransformType.__\u003C\u003ECENTER_VERTICAL;
      }
    }

    [Modifiers]
    public static GradientPaintTransformType CENTER_HORIZONTAL
    {
      [HideFromJava] get
      {
        return GradientPaintTransformType.__\u003C\u003ECENTER_HORIZONTAL;
      }
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 207, (byte) 239, (byte) 69, (byte) 239, (byte) 69})]
    static GradientPaintTransformType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private GradientPaintTransformType([In] string obj0)
    {
      base.\u002Ector();
      GradientPaintTransformType paintTransformType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GradientPaintTransformType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GradientPaintTransformType obj0)
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

    [LineNumberTable(new byte[] {(byte) 58, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is GradientPaintTransformType && String.instancehelper_equals(this.name, (object) ((GradientPaintTransformType) o).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 90, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      GradientPaintTransformType paintTransformType = (GradientPaintTransformType) null;
      if (this.equals((object) GradientPaintTransformType.__\u003C\u003EHORIZONTAL))
        paintTransformType = GradientPaintTransformType.__\u003C\u003EHORIZONTAL;
      else if (this.equals((object) GradientPaintTransformType.__\u003C\u003EVERTICAL))
        paintTransformType = GradientPaintTransformType.__\u003C\u003EVERTICAL;
      else if (this.equals((object) GradientPaintTransformType.__\u003C\u003ECENTER_HORIZONTAL))
        paintTransformType = GradientPaintTransformType.__\u003C\u003ECENTER_HORIZONTAL;
      else if (this.equals((object) GradientPaintTransformType.__\u003C\u003ECENTER_VERTICAL))
        paintTransformType = GradientPaintTransformType.__\u003C\u003ECENTER_VERTICAL;
      return (object) paintTransformType;
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
