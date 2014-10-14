// Decompiled with JetBrains decompiler
// Type: org.jfree.util.BooleanList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Serializable]
  public class BooleanList : AbstractObjectList
  {
    private const long serialVersionUID = -8543170333219422042L;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanList()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BooleanList([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getBoolean(int index)
    {
      return (Boolean) this.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBoolean(int index, Boolean b)
    {
      this.set(index, (object) b);
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object o)
    {
      if (!(o is BooleanList))
        return false;
      return (base.equals(o) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 108)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }
  }
}
