// Decompiled with JetBrains decompiler
// Type: org.jfree.util.PublicCloneable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;

namespace org.jfree.util
{
  [Implements(new string[] {"java.lang.Cloneable"})]
  public interface PublicCloneable : Cloneable.__Interface
  {
    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    object clone();
  }
}
