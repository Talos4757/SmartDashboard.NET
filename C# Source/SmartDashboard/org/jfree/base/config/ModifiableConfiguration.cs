// Decompiled with JetBrains decompiler
// Type: org.jfree.base.config.ModifiableConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.util;

namespace org.jfree.@base.config
{
  [Implements(new string[] {"org.jfree.util.Configuration"})]
  public interface ModifiableConfiguration : Configuration, Serializable.__Interface, Cloneable.__Interface
  {
    void setConfigProperty(string str1, string str2);

    Enumeration getConfigProperties();

    Iterator findPropertyKeys(string str);
  }
}
