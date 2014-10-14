// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.GrayPaintScale
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"org.jfree.chart.renderer.PaintScale", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class GrayPaintScale : Object, PaintScale, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private double lowerBound;
    private double upperBound;
    private int alpha;

    [LineNumberTable(new byte[] {(byte) 41, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrayPaintScale(double lowerBound, double upperBound)
      : this(lowerBound, upperBound, (int) byte.MaxValue)
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 104, (byte) 102, (byte) 176, (byte) 108, (byte) 208, (byte) 105, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrayPaintScale(double lowerBound, double upperBound, int alpha)
    {
      base.\u002Ector();
      GrayPaintScale grayPaintScale = this;
      if (lowerBound >= upperBound)
      {
        string str = "Requires lowerBound < upperBound.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (alpha < 0 || alpha > (int) byte.MaxValue)
      {
        string str = "Requires alpha in the range 0 to 255.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.alpha = alpha;
      }
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrayPaintScale()
      : this(0.0, 1.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GrayPaintScale([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] GrayPaintScale obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GrayPaintScale obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    public virtual int getAlpha()
    {
      return this.alpha;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 111, (byte) 110, (byte) 223, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(double value)
    {
      int num = ByteCodeHelper.d2i((Math.min(Math.max(value, this.lowerBound), this.upperBound) - this.lowerBound) / (this.upperBound - this.lowerBound) * (double) byte.MaxValue);
      Color.__\u003Cclinit\u003E();
      return (Paint) new Color(num, num, num, this.alpha);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is GrayPaintScale))
        return false;
      GrayPaintScale grayPaintScale = (GrayPaintScale) obj;
      return this.lowerBound == grayPaintScale.lowerBound && this.upperBound == grayPaintScale.upperBound && this.alpha == grayPaintScale.alpha;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 98, (byte) 109, (byte) 109, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 43 * HashUtilities.hashCode(HashUtilities.hashCode(7, this.lowerBound), this.upperBound) + this.alpha;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 228)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
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
