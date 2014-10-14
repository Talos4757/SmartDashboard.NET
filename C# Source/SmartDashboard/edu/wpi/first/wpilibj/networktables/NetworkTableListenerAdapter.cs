// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableListenerAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [SourceFile(null)]
  public class NetworkTableListenerAdapter : Object, ITableListener
  {
    [Modifiers]
    private ITableListener targetListener;
    [Modifiers]
    private ITable targetSource;
    [Modifiers]
    private string prefix;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableListenerAdapter(string str, ITable it, ITableListener itl)
    {
      base.\u002Ector();
      NetworkTableListenerAdapter tableListenerAdapter = this;
      this.prefix = str;
      this.targetSource = it;
      this.targetListener = itl;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool contains([In] string obj0, [In] char obj1)
    {
      int num = (int) obj1;
      for (int index = 0; index < String.instancehelper_length(obj0); ++index)
      {
        if ((int) String.instancehelper_charAt(obj0, index) == num)
          return true;
      }
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable it, string str, object obj, bool b)
    {
      int num = b ? 1 : 0;
      if (!String.instancehelper_startsWith(str, this.prefix))
        return;
      string str1 = String.instancehelper_substring(str, String.instancehelper_length(this.prefix));
      if (NetworkTableListenerAdapter.contains(str1, '/'))
        return;
      this.targetListener.valueChanged(this.targetSource, str1, obj, num != 0);
    }
  }
}
