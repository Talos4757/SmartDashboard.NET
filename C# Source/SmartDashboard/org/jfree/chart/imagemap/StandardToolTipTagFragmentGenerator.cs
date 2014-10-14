// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.imagemap.StandardToolTipTagFragmentGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.imagemap
{
  [Implements(new string[] {"org.jfree.chart.imagemap.ToolTipTagFragmentGenerator"})]
  public class StandardToolTipTagFragmentGenerator : Object, ToolTipTagFragmentGenerator
  {
    [LineNumberTable(new byte[] {(byte) 4, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardToolTipTagFragmentGenerator()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTipFragment(string toolTipText)
    {
      return new StringBuffer().append(" title=\"").append(ImageMapUtilities.htmlEscape(toolTipText)).append("\" alt=\"\"").toString();
    }
  }
}
