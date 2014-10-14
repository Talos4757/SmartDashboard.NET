// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.PropertyHolder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;

namespace edu.wpi.first.smartdashboard.properties
{
  public interface PropertyHolder
  {
    [Signature("()Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    Map getProperties();

    bool validatePropertyChange(Property p, object obj);

    void propertyChanged(Property p);
  }
}
