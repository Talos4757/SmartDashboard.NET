// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableSubListenerAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.util;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [SourceFile(null)]
  public class NetworkTableSubListenerAdapter : Object, ITableListener
  {
    [Modifiers]
    private ITableListener targetListener;
    [Modifiers]
    private NetworkTable targetSource;
    [Modifiers]
    private string prefix;
    [Modifiers]
    private Set notifiedTables;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableSubListenerAdapter(string str, NetworkTable nt, ITableListener itl)
    {
      base.\u002Ector();
      NetworkTableSubListenerAdapter subListenerAdapter = this;
      this.notifiedTables = new Set();
      this.prefix = str;
      this.targetSource = nt;
      this.targetListener = itl;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable it, string str, object obj, bool b)
    {
      if (!String.instancehelper_startsWith(str, this.prefix))
        return;
      string str1 = String.instancehelper_substring(str, String.instancehelper_length(this.prefix) + 1);
      int num = -1;
      for (int index = 0; index < String.instancehelper_length(str1); ++index)
      {
        if ((int) String.instancehelper_charAt(str1, index) == 47)
        {
          num = index;
          break;
        }
      }
      if (num == -1)
        return;
      string str2 = String.instancehelper_substring(str1, 0, num);
      if (this.notifiedTables.contains((object) str2))
        return;
      this.notifiedTables.add((object) str2);
      this.targetListener.valueChanged((ITable) this.targetSource, str2, (object) this.targetSource.getSubTable(str2), true);
    }
  }
}
