// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedValues2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System;

namespace org.jfree.data
{
  [Implements(new string[] {"org.jfree.data.Values2D"})]
  public interface KeyedValues2D : Values2D
  {
    int getColumnIndex(IComparable c);

    int getRowIndex(IComparable c);

    IComparable getRowKey(int i);

    IComparable getColumnKey(int i);

    List getColumnKeys();

    List getRowKeys();

    Number getValue(IComparable c1, IComparable c2);
  }
}
