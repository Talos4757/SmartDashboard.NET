// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYDataItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.lang.Cloneable", "java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class XYDataItem : Object, Cloneable.__Interface, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2751513470325494890L;
    private Number x;
    private Number y;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDataItem(Number x, Number y)
    {
      base.\u002Ector();
      XYDataItem xyDataItem = this;
      if (x == null)
      {
        string str = "Null 'x' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.x = x;
        this.y = y;
      }
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDataItem(double x, double y)
      : this((Number) new Double(x), (Number) new Double(y))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYDataItem obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYDataItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Number getX()
    {
      return this.x;
    }

    public virtual Number getY()
    {
      return this.y;
    }

    public virtual void setY(Number y)
    {
      this.y = y;
    }

    [LineNumberTable((ushort) 111)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXValue()
    {
      return this.x.doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      double num = double.NaN;
      if (this.y != null)
        num = this.y.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setY(double y)
    {
      this.setY((Number) new Double(y));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 104, (byte) 103, (byte) 153, (byte) 104, (byte) 164, (byte) 104, (byte) 164, (byte) 162, (byte) 226, (byte) 70, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object o1)
    {
      int num1;
      if (o1 is XYDataItem)
      {
        double num2 = this.x.doubleValue() - ((XYDataItem) o1).getX().doubleValue();
        num1 = num2 <= 0.0 ? (num2 >= 0.0 ? 0 : -1) : 1;
      }
      else
        num1 = 1;
      return num1;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYDataItem))
        return false;
      XYDataItem xyDataItem = (XYDataItem) obj;
      return Object.instancehelper_equals((object) this.x, (object) xyDataItem.x) && ObjectUtilities.equal((object) this.y, (object) xyDataItem.y);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 108, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.x) + (this.y == null ? 0 : Object.instancehelper_hashCode((object) this.y));
    }

    [LineNumberTable((ushort) 263)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("[").append(this.getXValue()).append(", ").append(this.getYValue()).append("]").toString();
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
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
