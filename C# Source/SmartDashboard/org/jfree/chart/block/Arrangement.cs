// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.Arrangement
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using org.jfree.ui;

namespace org.jfree.chart.block
{
  public interface Arrangement
  {
    void add(Block b, object obj);

    Size2D arrange(BlockContainer bc, Graphics2D gd, RectangleConstraint rc);

    void clear();
  }
}
