// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.model.MultipleFailureException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit.@internal.runners.model
{
  [Serializable]
  public class MultipleFailureException : Exception
  {
    private const long serialVersionUID = 1L;
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/lang/Throwable;>;")]
    private List fErrors;

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 152, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultipleFailureException(List errors)
    {
      base.\u002Ector();
      MultipleFailureException failureException = this;
      this.fErrors = errors;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MultipleFailureException([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [Signature("()Ljava/util/List<Ljava/lang/Throwable;>;")]
    public virtual List getFailures()
    {
      return this.fErrors;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 104, (byte) 97, (byte) 105, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEmpty(List errors)
    {
      if (errors.isEmpty())
        return;
      if (errors.size() == 1)
        throw Throwable.__\u003Cunmap\u003E((Exception) errors.get(0));
      List errors1 = errors;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new MultipleFailureException(errors1);
    }
  }
}
