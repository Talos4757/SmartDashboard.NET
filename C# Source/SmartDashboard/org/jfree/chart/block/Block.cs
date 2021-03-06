﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.Block
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using org.jfree.ui;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.ui.Drawable"})]
  public interface Block : Drawable
  {
    object draw(Graphics2D gd, Rectangle2D rd, object obj);

    string getID();

    void setID(string str);

    Size2D arrange(Graphics2D gd);

    Size2D arrange(Graphics2D gd, RectangleConstraint rc);

    Rectangle2D getBounds();

    void setBounds(Rectangle2D rd);
  }
}
