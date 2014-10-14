// Decompiled with JetBrains decompiler
// Type: org.jfree.util.Configuration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace org.jfree.util
{
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable"})]
  public interface Configuration : Serializable.__Interface, Cloneable.__Interface
  {
    string getConfigProperty(string str);

    string getConfigProperty(string str1, string str2);

    Iterator findPropertyKeys(string str);

    Enumeration getConfigProperties();

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    object clone();
  }
}
