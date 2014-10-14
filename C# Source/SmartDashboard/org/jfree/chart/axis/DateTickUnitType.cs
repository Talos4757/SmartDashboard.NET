// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.DateTickUnitType
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class DateTickUnitType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static DateTickUnitType __\u003C\u003EYEAR = new DateTickUnitType("DateTickUnitType.YEAR", 1);
    internal static DateTickUnitType __\u003C\u003EMONTH = new DateTickUnitType("DateTickUnitType.MONTH", 2);
    internal static DateTickUnitType __\u003C\u003EDAY = new DateTickUnitType("DateTickUnitType.DAY", 5);
    internal static DateTickUnitType __\u003C\u003EHOUR = new DateTickUnitType("DateTickUnitType.HOUR", 11);
    internal static DateTickUnitType __\u003C\u003EMINUTE = new DateTickUnitType("DateTickUnitType.MINUTE", 12);
    internal static DateTickUnitType __\u003C\u003ESECOND = new DateTickUnitType("DateTickUnitType.SECOND", 13);
    internal static DateTickUnitType __\u003C\u003EMILLISECOND = new DateTickUnitType("DateTickUnitType.MILLISECOND", 14);
    private string name;
    private int calendarField;

    [Modifiers]
    public static DateTickUnitType YEAR
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EYEAR;
      }
    }

    [Modifiers]
    public static DateTickUnitType MONTH
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EMONTH;
      }
    }

    [Modifiers]
    public static DateTickUnitType DAY
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EDAY;
      }
    }

    [Modifiers]
    public static DateTickUnitType HOUR
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EHOUR;
      }
    }

    [Modifiers]
    public static DateTickUnitType MINUTE
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EMINUTE;
      }
    }

    [Modifiers]
    public static DateTickUnitType SECOND
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003ESECOND;
      }
    }

    [Modifiers]
    public static DateTickUnitType MILLISECOND
    {
      [HideFromJava] get
      {
        return DateTickUnitType.__\u003C\u003EMILLISECOND;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 208, (byte) 208, (byte) 240, (byte) 69, (byte) 241, (byte) 69, (byte) 209, (byte) 209})]
    static DateTickUnitType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateTickUnitType([In] string obj0, [In] int obj1)
    {
      base.\u002Ector();
      DateTickUnitType dateTickUnitType = this;
      this.name = obj0;
      this.calendarField = obj1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateTickUnitType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DateTickUnitType obj0)
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

    public virtual int getCalendarField()
    {
      return this.calendarField;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is DateTickUnitType && String.instancehelper_equals(this.name, (object) ((DateTickUnitType) obj).toString());
    }

    public virtual string toString()
    {
      return this.name;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 100, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) DateTickUnitType.__\u003C\u003EYEAR))
        return (object) DateTickUnitType.__\u003C\u003EYEAR;
      if (this.equals((object) DateTickUnitType.__\u003C\u003EMONTH))
        return (object) DateTickUnitType.__\u003C\u003EMONTH;
      if (this.equals((object) DateTickUnitType.__\u003C\u003EDAY))
        return (object) DateTickUnitType.__\u003C\u003EDAY;
      if (this.equals((object) DateTickUnitType.__\u003C\u003EHOUR))
        return (object) DateTickUnitType.__\u003C\u003EHOUR;
      if (this.equals((object) DateTickUnitType.__\u003C\u003EMINUTE))
        return (object) DateTickUnitType.__\u003C\u003EMINUTE;
      if (this.equals((object) DateTickUnitType.__\u003C\u003ESECOND))
        return (object) DateTickUnitType.__\u003C\u003ESECOND;
      if (this.equals((object) DateTickUnitType.__\u003C\u003EMILLISECOND))
        return (object) DateTickUnitType.__\u003C\u003EMILLISECOND;
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
      if (((object) this).GetType() != typeof (DateTickUnitType))
        return (object) this;
      else
        return this.readResolve();
    }
  }
}
