// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.ChartChangeEventType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.chart.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.@event
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class ChartChangeEventType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static ChartChangeEventType __\u003C\u003EGENERAL = new ChartChangeEventType("ChartChangeEventType.GENERAL");
    internal static ChartChangeEventType __\u003C\u003ENEW_DATASET = new ChartChangeEventType("ChartChangeEventType.NEW_DATASET");
    internal static ChartChangeEventType __\u003C\u003EDATASET_UPDATED = new ChartChangeEventType("ChartChangeEventType.DATASET_UPDATED");
    private const long serialVersionUID = 5481917022435735602L;
    private string name;

    [Modifiers]
    public static ChartChangeEventType GENERAL
    {
      [HideFromJava] get
      {
        return ChartChangeEventType.__\u003C\u003EGENERAL;
      }
    }

    [Modifiers]
    public static ChartChangeEventType NEW_DATASET
    {
      [HideFromJava] get
      {
        return ChartChangeEventType.__\u003C\u003ENEW_DATASET;
      }
    }

    [Modifiers]
    public static ChartChangeEventType DATASET_UPDATED
    {
      [HideFromJava] get
      {
        return ChartChangeEventType.__\u003C\u003EDATASET_UPDATED;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 207, (byte) 207})]
    static ChartChangeEventType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ChartChangeEventType([In] string obj0)
    {
      base.\u002Ector();
      ChartChangeEventType chartChangeEventType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartChangeEventType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ChartChangeEventType obj0)
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

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is ChartChangeEventType && String.instancehelper_equals(this.name, (object) ((ChartChangeEventType) obj).toString());
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 76, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) ChartChangeEventType.__\u003C\u003EGENERAL))
        return (object) ChartChangeEventType.__\u003C\u003EGENERAL;
      if (this.equals((object) ChartChangeEventType.__\u003C\u003ENEW_DATASET))
        return (object) ChartChangeEventType.__\u003C\u003ENEW_DATASET;
      if (this.equals((object) ChartChangeEventType.__\u003C\u003EDATASET_UPDATED))
        return (object) ChartChangeEventType.__\u003C\u003EDATASET_UPDATED;
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
