// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.imagemap.StandardURLTagFragmentGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.imagemap
{
  [Implements(new string[] {"org.jfree.chart.imagemap.URLTagFragmentGenerator"})]
  public class StandardURLTagFragmentGenerator : Object, URLTagFragmentGenerator
  {
    [LineNumberTable(new byte[] {(byte) 5, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardURLTagFragmentGenerator()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 67)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateURLFragment(string urlText)
    {
      return new StringBuffer().append(" href=\"").append(urlText).append("\"").toString();
    }
  }
}
