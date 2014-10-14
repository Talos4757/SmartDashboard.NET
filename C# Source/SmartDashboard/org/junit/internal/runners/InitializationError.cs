// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.InitializationError
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal.runners;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  [Serializable]
  public class InitializationError : Exception
  {
    private const long serialVersionUID = 1L;
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/lang/Throwable;>;")]
    private List fErrors;

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitializationError(List errors)
    {
      base.\u002Ector();
      InitializationError initializationError = this;
      this.fErrors = errors;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitializationError(params Exception[] errors)
      : this(Arrays.asList((object[]) errors))
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitializationError(string @string)
    {
      Exception[] exceptionArray = new Exception[1];
      int index = 0;
      Exception exception = new Exception(@string);
      exceptionArray[index] = (Exception) exception;
      // ISSUE: explicit constructor call
      this.\u002Ector(exceptionArray);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected InitializationError([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [Signature("()Ljava/util/List<Ljava/lang/Throwable;>;")]
    public virtual List getCauses()
    {
      return this.fErrors;
    }
  }
}
