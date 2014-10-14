// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.FailedBefore
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

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Modifiers]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  [Serializable]
  internal sealed class FailedBefore : Exception
  {
    private const long serialVersionUID = 1L;

    [LineNumberTable((ushort) 12)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FailedBefore()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FailedBefore([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }
  }
}
