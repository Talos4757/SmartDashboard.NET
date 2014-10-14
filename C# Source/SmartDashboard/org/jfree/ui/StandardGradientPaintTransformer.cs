// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.StandardGradientPaintTransformer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"org.jfree.ui.GradientPaintTransformer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardGradientPaintTransformer : Object, GradientPaintTransformer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -8155025776964678320L;
    private GradientPaintTransformType type;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardGradientPaintTransformer(GradientPaintTransformType type)
    {
      base.\u002Ector();
      StandardGradientPaintTransformer paintTransformer = this;
      if (type == null)
      {
        string str = "Null 'type' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.type = type;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardGradientPaintTransformer()
      : this(GradientPaintTransformType.__\u003C\u003EVERTICAL)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardGradientPaintTransformer([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardGradientPaintTransformer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardGradientPaintTransformer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual GradientPaintTransformType getType()
    {
      return this.type;
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 98, (byte) 135, (byte) 114, (byte) 255, (byte) 20, (byte) 69, (byte) 114, (byte) 255, (byte) 20, (byte) 69, (byte) 146, (byte) 255, (byte) 18, (byte) 69, (byte) 114, (byte) 255, (byte) 16, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual GradientPaint transform(GradientPaint paint, Shape target)
    {
      GradientPaint gradientPaint = paint;
      Rectangle2D bounds2D = target.getBounds2D();
      if (this.type.equals((object) GradientPaintTransformType.__\u003C\u003EVERTICAL))
        gradientPaint = new GradientPaint((float) ((RectangularShape) bounds2D).getCenterX(), (float) ((RectangularShape) bounds2D).getMinY(), paint.getColor1(), (float) ((RectangularShape) bounds2D).getCenterX(), (float) ((RectangularShape) bounds2D).getMaxY(), paint.getColor2());
      else if (this.type.equals((object) GradientPaintTransformType.__\u003C\u003EHORIZONTAL))
        gradientPaint = new GradientPaint((float) ((RectangularShape) bounds2D).getMinX(), (float) ((RectangularShape) bounds2D).getCenterY(), paint.getColor1(), (float) ((RectangularShape) bounds2D).getMaxX(), (float) ((RectangularShape) bounds2D).getCenterY(), paint.getColor2());
      else if (this.type.equals((object) GradientPaintTransformType.__\u003C\u003ECENTER_HORIZONTAL))
        gradientPaint = new GradientPaint((float) ((RectangularShape) bounds2D).getCenterX(), (float) ((RectangularShape) bounds2D).getCenterY(), paint.getColor2(), (float) ((RectangularShape) bounds2D).getMaxX(), (float) ((RectangularShape) bounds2D).getCenterY(), paint.getColor1(), true);
      else if (this.type.equals((object) GradientPaintTransformType.__\u003C\u003ECENTER_VERTICAL))
        gradientPaint = new GradientPaint((float) ((RectangularShape) bounds2D).getCenterX(), (float) ((RectangularShape) bounds2D).getMinY(), paint.getColor1(), (float) ((RectangularShape) bounds2D).getCenterX(), (float) ((RectangularShape) bounds2D).getCenterY(), paint.getColor2(), true);
      return gradientPaint;
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is StandardGradientPaintTransformer && this.type == ((StandardGradientPaintTransformer) obj).type;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 177)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable((ushort) 186)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.type != null)
        return this.type.hashCode();
      else
        return 0;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
