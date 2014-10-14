// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.Module
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.@base.modules;

namespace org.jfree.@base.modules
{
  [Implements(new string[] {"org.jfree.base.modules.ModuleInfo"})]
  public interface Module : ModuleInfo
  {
    ModuleInfo[] getRequiredModules();

    ModuleInfo[] getOptionalModules();

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    void initialize(SubSystem ss);

    void configure(SubSystem ss);

    string getDescription();

    string getProducer();

    string getName();

    string getSubSystem();
  }
}
