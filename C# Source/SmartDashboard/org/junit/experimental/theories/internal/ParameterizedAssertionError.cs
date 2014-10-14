// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.internal.ParameterizedAssertionError
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit.experimental.theories.@internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit.experimental.theories.@internal
{
  [Serializable]
  public class ParameterizedAssertionError : RuntimeException
  {
    private const long serialVersionUID = 1L;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 159, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParameterizedAssertionError(Exception targetException, string methodName, params object[] @params)
    {
      string str1 = "%s(%s)";
      object[] objArray = new object[2];
      int index1 = 0;
      string str2 = methodName;
      objArray[index1] = (object) str2;
      int index2 = 1;
      string str3 = ParameterizedAssertionError.join(", ", @params);
      objArray[index2] = (object) str3;
      base.\u002Ector(String.format(str1, objArray), targetException);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ParameterizedAssertionError([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string join(string delimiter, params object[] @params)
    {
      return ParameterizedAssertionError.join(delimiter, (Collection) Arrays.asList(@params));
    }

    [Signature("(Ljava/lang/String;Ljava/util/Collection<Ljava/lang/Object;>;)Ljava/lang/String;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 102, (byte) 103, (byte) 104, (byte) 103, (byte) 109, (byte) 104, (byte) 136, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string join(string delimiter, Collection values)
    {
      StringBuffer stringBuffer = new StringBuffer();
      Iterator iterator = values.iterator();
      while (iterator.hasNext())
      {
        object obj = iterator.next();
        stringBuffer.append(ParameterizedAssertionError.stringValueOf(obj));
        if (iterator.hasNext())
          stringBuffer.append(delimiter);
      }
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 123, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string stringValueOf([In] object obj0)
    {
      string str;
      try
      {
        str = String.valueOf(obj0);
      }
      catch (Exception ex)
      {
        int num = 2;
        ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return str;
label_3:
      return "[toString failed]";
    }

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return (String.instancehelper_equals(Throwable.instancehelper_toString((Exception) this), (object) Object.instancehelper_toString(obj)) ? 1 : 0) != 0;
    }
  }
}
