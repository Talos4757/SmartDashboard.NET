﻿// Decompiled with JetBrains decompiler
// Type: junit.framework.AssertionFailedError
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

namespace junit.framework
{
  [Serializable]
  public class AssertionFailedError : AssertionError
  {
    private const long serialVersionUID = 1L;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssertionFailedError(string message)
    {
      base.\u002Ector((object) message);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssertionFailedError()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AssertionFailedError([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }
  }
}
