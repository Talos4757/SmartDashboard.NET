// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.RectangleAnchor
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
  public sealed class RectangleAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static RectangleAnchor __\u003C\u003ECENTER = new RectangleAnchor("RectangleAnchor.CENTER");
    internal static RectangleAnchor __\u003C\u003ETOP = new RectangleAnchor("RectangleAnchor.TOP");
    internal static RectangleAnchor __\u003C\u003ETOP_LEFT = new RectangleAnchor("RectangleAnchor.TOP_LEFT");
    internal static RectangleAnchor __\u003C\u003ETOP_RIGHT = new RectangleAnchor("RectangleAnchor.TOP_RIGHT");
    internal static RectangleAnchor __\u003C\u003EBOTTOM = new RectangleAnchor("RectangleAnchor.BOTTOM");
    internal static RectangleAnchor __\u003C\u003EBOTTOM_LEFT = new RectangleAnchor("RectangleAnchor.BOTTOM_LEFT");
    internal static RectangleAnchor __\u003C\u003EBOTTOM_RIGHT = new RectangleAnchor("RectangleAnchor.BOTTOM_RIGHT");
    internal static RectangleAnchor __\u003C\u003ELEFT = new RectangleAnchor("RectangleAnchor.LEFT");
    internal static RectangleAnchor __\u003C\u003ERIGHT = new RectangleAnchor("RectangleAnchor.RIGHT");
    private const long serialVersionUID = -2457494205644416327L;
    private string name;

    [Modifiers]
    public static RectangleAnchor CENTER
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ECENTER;
      }
    }

    [Modifiers]
    public static RectangleAnchor TOP
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ETOP;
      }
    }

    [Modifiers]
    public static RectangleAnchor TOP_LEFT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ETOP_LEFT;
      }
    }

    [Modifiers]
    public static RectangleAnchor TOP_RIGHT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ETOP_RIGHT;
      }
    }

    [Modifiers]
    public static RectangleAnchor BOTTOM
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003EBOTTOM;
      }
    }

    [Modifiers]
    public static RectangleAnchor BOTTOM_LEFT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003EBOTTOM_LEFT;
      }
    }

    [Modifiers]
    public static RectangleAnchor BOTTOM_RIGHT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT;
      }
    }

    [Modifiers]
    public static RectangleAnchor LEFT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ELEFT;
      }
    }

    [Modifiers]
    public static RectangleAnchor RIGHT
    {
      [HideFromJava] get
      {
        return RectangleAnchor.__\u003C\u003ERIGHT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207})]
    static RectangleAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RectangleAnchor([In] string obj0)
    {
      base.\u002Ector();
      RectangleAnchor rectangleAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RectangleAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RectangleAnchor obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 96, (byte) 98, (byte) 104, (byte) 104, (byte) 104, (byte) 223, (byte) 10, (byte) 104, (byte) 223, (byte) 10, (byte) 104, (byte) 223, (byte) 10, (byte) 104, (byte) 221, (byte) 104, (byte) 223, (byte) 0, (byte) 104, (byte) 223, (byte) 10, (byte) 104, (byte) 223, (byte) 10, (byte) 104, (byte) 223, (byte) 7, (byte) 104, (byte) 223, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rectangle2D createRectangle(Size2D dimensions, double anchorX, double anchorY, RectangleAnchor anchor)
    {
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      double width = dimensions.getWidth();
      double height = dimensions.getHeight();
      if (anchor == RectangleAnchor.__\u003C\u003ECENTER)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003ELEFT)
        @double = new Rectangle2D.Double(anchorX, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003ERIGHT)
        @double = new Rectangle2D.Double(anchorX - width, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP_LEFT)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP_RIGHT)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM_LEFT)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT)
        @double = new Rectangle2D.Double(anchorX - width / 2.0, anchorY - height / 2.0, width, height);
      return (Rectangle2D) @double;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is RectangleAnchor && String.instancehelper_equals(this.name, (object) ((RectangleAnchor) obj).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 102, (byte) 104, (byte) 151, (byte) 104, (byte) 151, (byte) 104, (byte) 151, (byte) 104, (byte) 151, (byte) 104, (byte) 151, (byte) 104, (byte) 148, (byte) 104, (byte) 148, (byte) 104, (byte) 148, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Point2D coordinates(Rectangle2D rectangle, RectangleAnchor anchor)
    {
      Point2D.Double @double = new Point2D.Double();
      if (anchor == RectangleAnchor.__\u003C\u003ECENTER)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getCenterX(), ((RectangularShape) rectangle).getCenterY());
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getCenterX(), ((RectangularShape) rectangle).getMinY());
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getCenterX(), ((RectangularShape) rectangle).getMaxY());
      else if (anchor == RectangleAnchor.__\u003C\u003ELEFT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMinX(), ((RectangularShape) rectangle).getCenterY());
      else if (anchor == RectangleAnchor.__\u003C\u003ERIGHT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMaxX(), ((RectangularShape) rectangle).getCenterY());
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP_LEFT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMinX(), ((RectangularShape) rectangle).getMinY());
      else if (anchor == RectangleAnchor.__\u003C\u003ETOP_RIGHT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMaxX(), ((RectangularShape) rectangle).getMinY());
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM_LEFT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMinX(), ((RectangularShape) rectangle).getMaxY());
      else if (anchor == RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT)
        ((Point2D) @double).setLocation(((RectangularShape) rectangle).getMaxX(), ((RectangularShape) rectangle).getMaxY());
      return (Point2D) @double;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 98, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      RectangleAnchor rectangleAnchor = (RectangleAnchor) null;
      if (this.equals((object) RectangleAnchor.__\u003C\u003ECENTER))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ECENTER;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003ETOP))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003ELEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ELEFT;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003ERIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ERIGHT;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_LEFT;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_RIGHT;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_LEFT;
      else if (this.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT;
      return (object) rectangleAnchor;
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
