// Decompiled with JetBrains decompiler
// Type: org.junit.internal.ArrayComparisonFailure
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit.@internal
{
  [Serializable]
  public class ArrayComparisonFailure : AssertionError
  {
    private const long serialVersionUID = 1L;
    [Signature("Ljava/util/List<Ljava/lang/Integer;>;")]
    private List fIndices;
    [Modifiers]
    private string fMessage;
    [Modifiers]
    private AssertionError fCause;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 232, (byte) 53, (byte) 235, (byte) 76, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayComparisonFailure(string message, AssertionError cause, int index)
    {
      base.\u002Ector();
      ArrayComparisonFailure comparisonFailure = this;
      this.fIndices = (List) new ArrayList();
      this.fMessage = message;
      this.fCause = cause;
      this.addDimension(index);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ArrayComparisonFailure([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDimension(int index)
    {
      this.fIndices.add(0, (object) Integer.valueOf(index));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 102, (byte) 104, (byte) 109, (byte) 108, (byte) 127, (byte) 6, (byte) 108, (byte) 104, (byte) 142, (byte) 108, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMessage()
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (this.fMessage != null)
        stringBuilder.append(this.fMessage);
      stringBuilder.append("arrays first differed at element ");
      Iterator iterator = this.fIndices.iterator();
      while (iterator.hasNext())
      {
        int num = ((Integer) iterator.next()).intValue();
        stringBuilder.append("[");
        stringBuilder.append(num);
        stringBuilder.append("]");
      }
      stringBuilder.append("; ");
      stringBuilder.append(Throwable.instancehelper_getMessage((Exception) this.fCause));
      return stringBuilder.toString();
    }

    [LineNumberTable((ushort) 57)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return this.getMessage();
    }
  }
}
