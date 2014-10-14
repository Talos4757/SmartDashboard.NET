// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.TickUnits
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"org.jfree.chart.axis.TickUnitSource", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class TickUnits : Object, TickUnitSource, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1134174035901467545L;
    private List tickUnits;

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TickUnits()
    {
      base.\u002Ector();
      TickUnits tickUnits = this;
      this.tickUnits = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TickUnits([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TickUnits obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TickUnits obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 99, (byte) 144, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TickUnit unit)
    {
      if (unit == null)
      {
        string str = "Null 'unit' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.tickUnits.add((object) unit);
        Collections.sort(this.tickUnits);
      }
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 109, (byte) 100, (byte) 178, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getCeilingTickUnit(TickUnit unit)
    {
      int num = Collections.binarySearch(this.tickUnits, (object) unit);
      if (num >= 0)
        return (TickUnit) this.tickUnits.get(num);
      else
        return (TickUnit) this.tickUnits.get(Math.min(-(num + 1), this.tickUnits.size() - 1));
    }

    [LineNumberTable((ushort) 105)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int size()
    {
      return this.tickUnits.size();
    }

    [LineNumberTable((ushort) 118)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit get(int pos)
    {
      return (TickUnit) this.tickUnits.get(pos);
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 109, (byte) 100, (byte) 166, (byte) 163})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getLargerTickUnit(TickUnit unit)
    {
      int num = Collections.binarySearch(this.tickUnits, (object) unit);
      return (TickUnit) this.tickUnits.get(Math.min(num < 0 ? -num : num + 1, this.tickUnits.size() - 1));
    }

    [LineNumberTable((ushort) 174)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getCeilingTickUnit(double size)
    {
      return this.getCeilingTickUnit((TickUnit) new NumberTickUnit(size, NumberFormat.getInstance()));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      TickUnits tickUnits = (TickUnits) base.clone();
      tickUnits.tickUnits = (List) new ArrayList((Collection) this.tickUnits);
      return (object) tickUnits;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TickUnits))
        return false;
      return (Object.instancehelper_equals((object) ((TickUnits) obj).tickUnits, (object) this.tickUnits) ? 1 : 0) != 0;
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
