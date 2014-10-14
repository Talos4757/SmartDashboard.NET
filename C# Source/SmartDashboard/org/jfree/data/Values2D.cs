// Decompiled with JetBrains decompiler
// Type: org.jfree.data.Values2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.lang;

namespace org.jfree.data
{
  public interface Values2D
  {
    int getColumnCount();

    int getRowCount();

    Number getValue(int i1, int i2);
  }
}
