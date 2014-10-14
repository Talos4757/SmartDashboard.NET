// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultChartEditorFactory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.chart;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.editor
{
  [Implements(new string[] {"org.jfree.chart.editor.ChartEditorFactory"})]
  public class DefaultChartEditorFactory : Object, ChartEditorFactory
  {
    [LineNumberTable(new byte[] {(byte) 3, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultChartEditorFactory()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 64)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ChartEditor createEditor(JFreeChart chart)
    {
      return (ChartEditor) new DefaultChartEditor(chart);
    }
  }
}
