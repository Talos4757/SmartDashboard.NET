// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimePeriodAnchor
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

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class TimePeriodAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static TimePeriodAnchor __\u003C\u003ESTART = new TimePeriodAnchor("TimePeriodAnchor.START");
    internal static TimePeriodAnchor __\u003C\u003EMIDDLE = new TimePeriodAnchor("TimePeriodAnchor.MIDDLE");
    internal static TimePeriodAnchor __\u003C\u003EEND = new TimePeriodAnchor("TimePeriodAnchor.END");
    private const long serialVersionUID = 2011955697457548862L;
    private string name;

    [Modifiers]
    public static TimePeriodAnchor START
    {
      [HideFromJava] get
      {
        return TimePeriodAnchor.__\u003C\u003ESTART;
      }
    }

    [Modifiers]
    public static TimePeriodAnchor MIDDLE
    {
      [HideFromJava] get
      {
        return TimePeriodAnchor.__\u003C\u003EMIDDLE;
      }
    }

    [Modifiers]
    public static TimePeriodAnchor END
    {
      [HideFromJava] get
      {
        return TimePeriodAnchor.__\u003C\u003EEND;
      }
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 207, (byte) 207})]
    static TimePeriodAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TimePeriodAnchor([In] string obj0)
    {
      base.\u002Ector();
      TimePeriodAnchor timePeriodAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimePeriodAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimePeriodAnchor obj0)
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

    [LineNumberTable(new byte[] {(byte) 49, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is TimePeriodAnchor && String.instancehelper_equals(this.name, (object) ((TimePeriodAnchor) obj).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 81, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) TimePeriodAnchor.__\u003C\u003ESTART))
        return (object) TimePeriodAnchor.__\u003C\u003ESTART;
      if (this.equals((object) TimePeriodAnchor.__\u003C\u003EMIDDLE))
        return (object) TimePeriodAnchor.__\u003C\u003EMIDDLE;
      if (this.equals((object) TimePeriodAnchor.__\u003C\u003EEND))
        return (object) TimePeriodAnchor.__\u003C\u003EEND;
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
      return this.readResolve();
    }
  }
}
