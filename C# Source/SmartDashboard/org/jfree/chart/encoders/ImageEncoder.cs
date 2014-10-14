// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.ImageEncoder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.image;
using java.io;

namespace org.jfree.chart.encoders
{
  public interface ImageEncoder
  {
    [Throws(new string[] {"java.io.IOException"})]
    byte[] encode(BufferedImage bi);

    [Throws(new string[] {"java.io.IOException"})]
    void encode(BufferedImage bi, OutputStream os);

    float getQuality();

    void setQuality(float f);

    bool isEncodingAlpha();

    void setEncodingAlpha(bool b);
  }
}
