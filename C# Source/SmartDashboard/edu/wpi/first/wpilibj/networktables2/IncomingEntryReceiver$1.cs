// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver"})]
  [EnclosingMethod("edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver", null, null)]
  [SourceFile(null)]
  internal sealed class IncomingEntryReceiver\u00241 : Object, IncomingEntryReceiver
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal IncomingEntryReceiver\u00241()
    {
      base.\u002Ector();
    }

    public virtual void offerIncomingUpdate([In] NetworkTableEntry obj0, [In] char obj1, [In] object obj2)
    {
    }

    public virtual void offerIncomingAssignment([In] NetworkTableEntry obj0)
    {
    }
  }
}
