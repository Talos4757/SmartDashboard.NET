// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.ActionDowngrade
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.util;
using javax.swing;

namespace org.jfree.ui.action
{
  [Implements(new string[] {"javax.swing.Action"})]
  public interface ActionDowngrade : Action, ActionListener, EventListener
  {
    const string ACCELERATOR_KEY = "AcceleratorKey";
    const string MNEMONIC_KEY = "MnemonicKey";

    [HideFromJava]
    static class __Fields
    {
      public const string ACCELERATOR_KEY = "AcceleratorKey";
      public const string MNEMONIC_KEY = "MnemonicKey";
    }
  }
}
