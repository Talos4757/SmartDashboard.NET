// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.SubSystem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using org.jfree.@base.modules;
using org.jfree.util;

namespace org.jfree.@base.modules
{
  public interface SubSystem
  {
    Configuration getGlobalConfig();

    ExtendedConfiguration getExtendedConfig();

    PackageManager getPackageManager();
  }
}
