// Decompiled with JetBrains decompiler
// Type: junit.framework.ComparisonFailure
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
  public class ComparisonFailure : AssertionFailedError
  {
    private const int MAX_CONTEXT_LENGTH = 20;
    private const long serialVersionUID = 1L;
    private string fExpected;
    private string fActual;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparisonFailure(string message, string expected, string actual)
      : base(message)
    {
      ComparisonFailure comparisonFailure = this;
      this.fExpected = expected;
      this.fActual = actual;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ComparisonFailure([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMessage()
    {
      return new ComparisonCompactor(20, this.fExpected, this.fActual).compact(((Throwable) this).getMessage());
    }

    public virtual string getActual()
    {
      return this.fActual;
    }

    public virtual string getExpected()
    {
      return this.fExpected;
    }
  }
}
