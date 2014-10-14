// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedValues
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System;

namespace org.jfree.data
{
  [Implements(new string[] {"org.jfree.data.Values"})]
  public interface KeyedValues : Values
  {
    List getKeys();

    Number getValue(IComparable c);

    int getIndex(IComparable c);

    IComparable getKey(int i);
  }
}
