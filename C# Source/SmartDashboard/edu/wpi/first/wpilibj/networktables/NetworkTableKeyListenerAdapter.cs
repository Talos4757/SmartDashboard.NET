// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableKeyListenerAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [SourceFile(null)]
  public class NetworkTableKeyListenerAdapter : Object, ITableListener
  {
    [Modifiers]
    private ITableListener targetListener;
    [Modifiers]
    private NetworkTable targetSource;
    [Modifiers]
    private string relativeKey;
    [Modifiers]
    private string fullKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableKeyListenerAdapter(string str1, string str2, NetworkTable nt, ITableListener itl)
    {
      base.\u002Ector();
      NetworkTableKeyListenerAdapter keyListenerAdapter = this;
      this.relativeKey = str1;
      this.fullKey = str2;
      this.targetSource = nt;
      this.targetListener = itl;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable it, string str, object obj, bool b)
    {
      int num = b ? 1 : 0;
      if (!String.instancehelper_equals(str, (object) this.fullKey))
        return;
      this.targetListener.valueChanged((ITable) this.targetSource, this.relativeKey, obj, num != 0);
    }
  }
}
