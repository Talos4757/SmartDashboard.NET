// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.RectangleEdge
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt.geom;
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
  public sealed class RectangleEdge : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static RectangleEdge __\u003C\u003ETOP = new RectangleEdge("RectangleEdge.TOP");
    internal static RectangleEdge __\u003C\u003EBOTTOM = new RectangleEdge("RectangleEdge.BOTTOM");
    internal static RectangleEdge __\u003C\u003ELEFT = new RectangleEdge("RectangleEdge.LEFT");
    internal static RectangleEdge __\u003C\u003ERIGHT = new RectangleEdge("RectangleEdge.RIGHT");
    private const long serialVersionUID = -7400988293691093548L;
    private string name;

    [Modifiers]
    public static RectangleEdge TOP
    {
      [HideFromJava] get
      {
        return RectangleEdge.__\u003C\u003ETOP;
      }
    }

    [Modifiers]
    public static RectangleEdge BOTTOM
    {
      [HideFromJava] get
      {
        return RectangleEdge.__\u003C\u003EBOTTOM;
      }
    }

    [Modifiers]
    public static RectangleEdge LEFT
    {
      [HideFromJava] get
      {
        return RectangleEdge.__\u003C\u003ELEFT;
      }
    }

    [Modifiers]
    public static RectangleEdge RIGHT
    {
      [HideFromJava] get
      {
        return RectangleEdge.__\u003C\u003ERIGHT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 207, (byte) 207})]
    static RectangleEdge()
    {
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RectangleEdge([In] string obj0)
    {
      base.\u002Ector();
      RectangleEdge rectangleEdge = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RectangleEdge([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RectangleEdge obj0)
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

    [LineNumberTable(new byte[] {(byte) 56, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is RectangleEdge && String.instancehelper_equals(this.name, (object) ((RectangleEdge) o).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    public static bool isTopOrBottom(RectangleEdge edge)
    {
      return edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM;
    }

    public static bool isLeftOrRight(RectangleEdge edge)
    {
      return edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT;
    }

    public static RectangleEdge opposite(RectangleEdge edge)
    {
      RectangleEdge rectangleEdge = (RectangleEdge) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
      return rectangleEdge;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 102, (byte) 104, (byte) 138, (byte) 104, (byte) 138, (byte) 104, (byte) 138, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double coordinate(Rectangle2D rectangle, RectangleEdge edge)
    {
      double num = 0.0;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        num = ((RectangularShape) rectangle).getMinY();
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        num = ((RectangularShape) rectangle).getMaxY();
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        num = ((RectangularShape) rectangle).getMinX();
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        num = ((RectangularShape) rectangle).getMaxX();
      return num;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      RectangleEdge rectangleEdge = (RectangleEdge) null;
      if (this.equals((object) RectangleEdge.__\u003C\u003ETOP))
        rectangleEdge = RectangleEdge.__\u003C\u003ETOP;
      else if (this.equals((object) RectangleEdge.__\u003C\u003EBOTTOM))
        rectangleEdge = RectangleEdge.__\u003C\u003EBOTTOM;
      else if (this.equals((object) RectangleEdge.__\u003C\u003ELEFT))
        rectangleEdge = RectangleEdge.__\u003C\u003ELEFT;
      else if (this.equals((object) RectangleEdge.__\u003C\u003ERIGHT))
        rectangleEdge = RectangleEdge.__\u003C\u003ERIGHT;
      return (object) rectangleEdge;
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
