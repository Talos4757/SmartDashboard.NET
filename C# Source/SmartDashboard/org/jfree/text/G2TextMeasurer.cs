// Decompiled with JetBrains decompiler
// Type: org.jfree.text.G2TextMeasurer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.text
{
  [Implements(new string[] {"org.jfree.text.TextMeasurer"})]
  public class G2TextMeasurer : Object, TextMeasurer
  {
    private Graphics2D g2;

    [LineNumberTable(new byte[] {(byte) 14, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public G2TextMeasurer(Graphics2D g2)
    {
      base.\u002Ector();
      G2TextMeasurer g2TextMeasurer = this;
      this.g2 = g2;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 108, (byte) 181, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual float getStringWidth(string text, int start, int end)
    {
      FontMetrics fontMetrics = ((Graphics) this.g2).getFontMetrics();
      return (float) ((RectangularShape) TextUtilities.getTextBounds(String.instancehelper_substring(text, start, end), this.g2, fontMetrics)).getWidth();
    }
  }
}
