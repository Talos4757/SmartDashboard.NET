// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimePeriodValue
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class TimePeriodValue : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 3390443360845711275L;
    private TimePeriod period;
    private Number value;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValue(TimePeriod period, Number value)
    {
      base.\u002Ector();
      TimePeriodValue timePeriodValue = this;
      if (period == null)
      {
        string str = "Null 'period' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.period = period;
        this.value = value;
      }
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValue(TimePeriod period, double value)
      : this(period, (Number) new Double(value))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimePeriodValue([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TimePeriodValue obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimePeriodValue obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual TimePeriod getPeriod()
    {
      return this.period;
    }

    public virtual Number getValue()
    {
      return this.value;
    }

    public virtual void setValue(Number value)
    {
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 159, (byte) 6, (byte) 130, (byte) 159, (byte) 6, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is TimePeriodValue))
        return false;
      TimePeriodValue timePeriodValue = (TimePeriodValue) obj;
      if (this.period != null)
      {
        if (Object.instancehelper_equals((object) this.period, (object) timePeriodValue.period))
          goto label_8;
      }
      else if (timePeriodValue.period == null)
        goto label_8;
      return false;
label_8:
      if (this.value != null)
      {
        if (Object.instancehelper_equals((object) this.value, (object) timePeriodValue.value))
          goto label_12;
      }
      else if (timePeriodValue.value == null)
        goto label_12;
      return false;
label_12:
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 119, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (this.period == null ? 0 : Object.instancehelper_hashCode((object) this.period)) + (this.value == null ? 0 : Object.instancehelper_hashCode((object) this.value));
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 130, (byte) 217, (byte) 2, (byte) 97, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      object obj = (object) null;
      CloneNotSupportedException supportedException;
      try
      {
        obj = base.clone();
        goto label_4;
      }
      catch (CloneNotSupportedException ex)
      {
        int num = 1;
        supportedException = (CloneNotSupportedException) ByteCodeHelper.MapException<CloneNotSupportedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) supportedException);
label_4:
      return obj;
    }

    [LineNumberTable((ushort) 189)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("TimePeriodValue[").append((object) this.getPeriod()).append(",").append((object) this.getValue()).append("]").toString();
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
