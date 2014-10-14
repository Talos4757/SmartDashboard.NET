// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ExtendedConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;

namespace org.jfree.util
{
  [Implements(new string[] {"org.jfree.util.Configuration"})]
  public interface ExtendedConfiguration : Configuration, Serializable.__Interface, Cloneable.__Interface
  {
    bool isPropertySet(string str);

    int getIntProperty(string str);

    int getIntProperty(string str, int i);

    bool getBoolProperty(string str);

    bool getBoolProperty(string str, bool b);
  }
}
