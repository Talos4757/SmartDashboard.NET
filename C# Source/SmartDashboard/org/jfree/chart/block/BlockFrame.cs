﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BlockFrame
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using java.awt.geom;
using org.jfree.ui;

namespace org.jfree.chart.block
{
  public interface BlockFrame
  {
    RectangleInsets getInsets();

    void draw(Graphics2D gd, Rectangle2D rd);
  }
}
