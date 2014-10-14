// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.DefaultEntryTypes$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.wpilibj.networktables2.type.DefaultEntryTypes", null, null)]
  [SourceFile(null)]
  internal sealed class DefaultEntryTypes\u00242 : NetworkTableEntryType
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DefaultEntryTypes\u00242([In] byte obj0, [In] string obj1)
      : base(obj0, obj1)
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void sendValue([In] object obj0, [In] DataOutputStream obj1)
    {
      if (obj0 is Double)
      {
        obj1.writeDouble(((Double) obj0).doubleValue());
      }
      else
      {
        string str = new StringBuilder().append("Cannot write ").append(obj0).append(" as ").append(this.__\u003C\u003Ename).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IOException(str);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object readValue([In] DataInputStream obj0)
    {
      Double.__\u003Cclinit\u003E();
      return (object) new Double(obj0.readDouble());
    }
  }
}
