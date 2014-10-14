// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FloatDimension
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
  public class FloatDimension : Dimension2D, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5367882923248086744L;
    private float width;
    private float height;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatDimension()
    {
      base.\u002Ector();
      FloatDimension floatDimension = this;
      this.width = 0.0f;
      this.height = 0.0f;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatDimension(FloatDimension fd)
    {
      base.\u002Ector();
      FloatDimension floatDimension = this;
      this.width = fd.width;
      this.height = fd.height;
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 104, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatDimension(float width, float height)
    {
      base.\u002Ector();
      FloatDimension floatDimension = this;
      this.width = width;
      this.height = height;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FloatDimension([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FloatDimension obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual void setHeight(double height)
    {
      this.height = (float) height;
    }

    public virtual void setWidth(double width)
    {
      this.width = (float) width;
    }

    public virtual double getWidth()
    {
      return (double) this.width;
    }

    public virtual double getHeight()
    {
      return (double) this.height;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 106, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSize(double width, double height)
    {
      this.setHeight(height);
      this.setWidth(width);
    }

    [LineNumberTable((ushort) 152)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable((ushort) 166)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(Object.instancehelper_getClass((object) this).getName()).append(":={width=").append(this.getWidth()).append(", height=").append(this.getHeight()).append("}").toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 110, (byte) 130, (byte) 110, (byte) 162})]
    public virtual bool equals(object o)
    {
      if (this == o)
        return true;
      if (!(o is FloatDimension))
        return false;
      FloatDimension floatDimension = (FloatDimension) o;
      return (double) this.height == (double) floatDimension.height && (double) this.width == (double) floatDimension.width;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Float.floatToIntBits(this.width) + Float.floatToIntBits(this.height);
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
