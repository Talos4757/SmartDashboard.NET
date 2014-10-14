// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.DatasetRenderingOrder
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

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class DatasetRenderingOrder : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static DatasetRenderingOrder __\u003C\u003EFORWARD = new DatasetRenderingOrder("DatasetRenderingOrder.FORWARD");
    internal static DatasetRenderingOrder __\u003C\u003EREVERSE = new DatasetRenderingOrder("DatasetRenderingOrder.REVERSE");
    private const long serialVersionUID = -600593412366385072L;
    private string name;

    [Modifiers]
    public static DatasetRenderingOrder FORWARD
    {
      [HideFromJava] get
      {
        return DatasetRenderingOrder.__\u003C\u003EFORWARD;
      }
    }

    [Modifiers]
    public static DatasetRenderingOrder REVERSE
    {
      [HideFromJava] get
      {
        return DatasetRenderingOrder.__\u003C\u003EREVERSE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 12, (byte) 239, (byte) 71})]
    static DatasetRenderingOrder()
    {
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DatasetRenderingOrder([In] string obj0)
    {
      base.\u002Ector();
      DatasetRenderingOrder datasetRenderingOrder = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DatasetRenderingOrder([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DatasetRenderingOrder obj0)
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

    [LineNumberTable(new byte[] {(byte) 52, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is DatasetRenderingOrder && String.instancehelper_equals(this.name, (object) ((DatasetRenderingOrder) obj).toString());
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 82, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) DatasetRenderingOrder.__\u003C\u003EFORWARD))
        return (object) DatasetRenderingOrder.__\u003C\u003EFORWARD;
      if (this.equals((object) DatasetRenderingOrder.__\u003C\u003EREVERSE))
        return (object) DatasetRenderingOrder.__\u003C\u003EREVERSE;
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
