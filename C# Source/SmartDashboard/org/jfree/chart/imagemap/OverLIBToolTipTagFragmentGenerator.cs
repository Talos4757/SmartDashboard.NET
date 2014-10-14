// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.imagemap.OverLIBToolTipTagFragmentGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.imagemap
{
  [Implements(new string[] {"org.jfree.chart.imagemap.ToolTipTagFragmentGenerator"})]
  public class OverLIBToolTipTagFragmentGenerator : Object, ToolTipTagFragmentGenerator
  {
    [LineNumberTable(new byte[] {(byte) 7, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverLIBToolTipTagFragmentGenerator()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 68)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTipFragment(string toolTipText)
    {
      return new StringBuffer().append(" onMouseOver=\"return overlib('").append(ImageMapUtilities.javascriptEscape(toolTipText)).append("');\" onMouseOut=\"return nd();\"").toString();
    }
  }
}
