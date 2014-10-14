// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.TransactionDirtier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.OutgoingEntryReceiver"})]
  [SourceFile(null)]
  public class TransactionDirtier : Object, OutgoingEntryReceiver
  {
    [Modifiers]
    private OutgoingEntryReceiver continuingReceiver;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransactionDirtier(OutgoingEntryReceiver oer)
    {
      base.\u002Ector();
      TransactionDirtier transactionDirtier = this;
      this.continuingReceiver = oer;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingAssignment(NetworkTableEntry nte)
    {
      if (nte.isDirty())
        return;
      nte.makeDirty();
      this.continuingReceiver.offerOutgoingAssignment(nte);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingUpdate(NetworkTableEntry nte)
    {
      if (nte.isDirty())
        return;
      nte.makeDirty();
      this.continuingReceiver.offerOutgoingUpdate(nte);
    }
  }
}
