// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.LengthAdjustmentType
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

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class LengthAdjustmentType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static LengthAdjustmentType __\u003C\u003ENO_CHANGE = new LengthAdjustmentType("NO_CHANGE");
    internal static LengthAdjustmentType __\u003C\u003EEXPAND = new LengthAdjustmentType("EXPAND");
    internal static LengthAdjustmentType __\u003C\u003ECONTRACT = new LengthAdjustmentType("CONTRACT");
    private const long serialVersionUID = -6097408511380545010L;
    private string name;

    [Modifiers]
    public static LengthAdjustmentType NO_CHANGE
    {
      [HideFromJava] get
      {
        return LengthAdjustmentType.__\u003C\u003ENO_CHANGE;
      }
    }

    [Modifiers]
    public static LengthAdjustmentType EXPAND
    {
      [HideFromJava] get
      {
        return LengthAdjustmentType.__\u003C\u003EEXPAND;
      }
    }

    [Modifiers]
    public static LengthAdjustmentType CONTRACT
    {
      [HideFromJava] get
      {
        return LengthAdjustmentType.__\u003C\u003ECONTRACT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 207})]
    static LengthAdjustmentType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private LengthAdjustmentType([In] string obj0)
    {
      base.\u002Ector();
      LengthAdjustmentType lengthAdjustmentType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LengthAdjustmentType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LengthAdjustmentType obj0)
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

    [LineNumberTable(new byte[] {(byte) 51, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is LengthAdjustmentType && String.instancehelper_equals(this.name, (object) ((LengthAdjustmentType) obj).name);
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
      if (this.equals((object) LengthAdjustmentType.__\u003C\u003ENO_CHANGE))
        return (object) LengthAdjustmentType.__\u003C\u003ENO_CHANGE;
      if (this.equals((object) LengthAdjustmentType.__\u003C\u003EEXPAND))
        return (object) LengthAdjustmentType.__\u003C\u003EEXPAND;
      if (this.equals((object) LengthAdjustmentType.__\u003C\u003ECONTRACT))
        return (object) LengthAdjustmentType.__\u003C\u003ECONTRACT;
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
