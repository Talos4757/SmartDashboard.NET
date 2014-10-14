// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ObjectList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Serializable]
  public class ObjectList : AbstractObjectList
  {
    [LineNumberTable(new byte[] {(byte) 11, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectList()
    {
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectList(int initialCapacity)
      : base(initialCapacity)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ObjectList([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object get(int index)
    {
      return base.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void set(int index, object @object)
    {
      base.set(index, @object);
    }

    [LineNumberTable((ushort) 108)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int indexOf(object @object)
    {
      return base.indexOf(@object);
    }
  }
}
