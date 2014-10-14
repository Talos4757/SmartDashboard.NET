// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.OutgoingEntryReceiver
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2
{
  [SourceFile(null)]
  public interface OutgoingEntryReceiver
  {
    static readonly OutgoingEntryReceiver NULL = (OutgoingEntryReceiver) new OutgoingEntryReceiver\u00241();

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void __\u003Cclinit\u003E()
    {
    }

    void offerOutgoingAssignment(NetworkTableEntry nte);

    void offerOutgoingUpdate(NetworkTableEntry nte);

    [HideFromJava]
    static class __Fields
    {
      public static readonly OutgoingEntryReceiver NULL = OutgoingEntryReceiver.NULL;
    }
  }
}
