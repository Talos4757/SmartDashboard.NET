// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.PotentialAssignment
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

namespace org.junit.experimental.theories
{
  public abstract class PotentialAssignment : Object
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 145, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PotentialAssignment()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PotentialAssignment forValue(string name, object value)
    {
      return (PotentialAssignment) new PotentialAssignment\u00241(value, name);
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    public abstract object getValue();

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    public abstract string getDescription();

    [InnerClass]
    [SourceFile("PotentialAssignment.java")]
    [Serializable]
    public class CouldNotGenerateValueException : Exception
    {
      private const long serialVersionUID = 1L;

      [LineNumberTable((ushort) 4)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CouldNotGenerateValueException()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CouldNotGenerateValueException([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }
    }
  }
}
