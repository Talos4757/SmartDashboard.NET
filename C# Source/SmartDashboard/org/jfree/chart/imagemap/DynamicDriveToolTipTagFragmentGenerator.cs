// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.imagemap.DynamicDriveToolTipTagFragmentGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.imagemap
{
  [Implements(new string[] {"org.jfree.chart.imagemap.ToolTipTagFragmentGenerator"})]
  public class DynamicDriveToolTipTagFragmentGenerator : Object, ToolTipTagFragmentGenerator
  {
    protected internal string title;
    protected internal int style;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 232, (byte) 55, (byte) 171, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicDriveToolTipTagFragmentGenerator()
    {
      base.\u002Ector();
      DynamicDriveToolTipTagFragmentGenerator fragmentGenerator = this;
      this.title = "";
      this.style = 1;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 232, (byte) 44, (byte) 171, (byte) 231, (byte) 82, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicDriveToolTipTagFragmentGenerator(string title, int style)
    {
      base.\u002Ector();
      DynamicDriveToolTipTagFragmentGenerator fragmentGenerator = this;
      this.title = "";
      this.style = 1;
      this.title = title;
      this.style = style;
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTipFragment(string toolTipText)
    {
      return new StringBuffer().append(" onMouseOver=\"return stm(['").append(ImageMapUtilities.javascriptEscape(this.title)).append("','").append(ImageMapUtilities.javascriptEscape(toolTipText)).append("'],Style[").append(this.style).append("]);\"").append(" onMouseOut=\"return htm();\"").toString();
    }
  }
}
