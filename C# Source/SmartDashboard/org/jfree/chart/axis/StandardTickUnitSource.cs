// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.StandardTickUnitSource
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"org.jfree.chart.axis.TickUnitSource", "java.io.Serializable"})]
  [Serializable]
  public class StandardTickUnitSource : Object, TickUnitSource, Serializable.__Interface, ISerializable
  {
    [Modifiers]
    private static double LOG_10_VALUE = Math.log(10.0);

    [LineNumberTable((ushort) 56)]
    static StandardTickUnitSource()
    {
    }

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardTickUnitSource()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardTickUnitSource([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardTickUnitSource obj0)
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

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 110, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getLargerTickUnit(TickUnit unit)
    {
      return (TickUnit) new NumberTickUnit(Math.pow(10.0, Math.ceil(Math.log(unit.getSize()) / StandardTickUnitSource.LOG_10_VALUE)), (NumberFormat) new DecimalFormat("0.0E0"));
    }

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getCeilingTickUnit(TickUnit unit)
    {
      return this.getLargerTickUnit(unit);
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 111, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TickUnit getCeilingTickUnit(double size)
    {
      return (TickUnit) new NumberTickUnit(Math.pow(10.0, Math.ceil(Math.log(size) / StandardTickUnitSource.LOG_10_VALUE)), (NumberFormat) new DecimalFormat("0.0E0"));
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 100, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      else
        return obj is StandardTickUnitSource;
    }

    public virtual int hashCode()
    {
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
