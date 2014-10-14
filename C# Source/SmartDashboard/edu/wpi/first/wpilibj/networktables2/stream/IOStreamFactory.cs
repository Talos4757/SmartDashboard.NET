// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.IOStreamFactory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [SourceFile(null)]
  public interface IOStreamFactory
  {
    [Throws(new string[] {"java.io.IOException"})]
    IOStream createStream();
  }
}
