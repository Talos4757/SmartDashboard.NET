// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.ChartEditorManager
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.chart;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.editor
{
  public class ChartEditorManager : Object
  {
    internal static ChartEditorFactory factory = (ChartEditorFactory) new DefaultChartEditorFactory();

    [LineNumberTable((ushort) 54)]
    static ChartEditorManager()
    {
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ChartEditorManager()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 92)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ChartEditor getChartEditor(JFreeChart chart)
    {
      return ChartEditorManager.factory.createEditor(chart);
    }

    public static ChartEditorFactory getChartEditorFactory()
    {
      return ChartEditorManager.factory;
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 99, (byte) 144, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setChartEditorFactory(ChartEditorFactory f)
    {
      if (f == null)
      {
        string str = "Null 'f' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        ChartEditorManager.factory = f;
    }
  }
}
