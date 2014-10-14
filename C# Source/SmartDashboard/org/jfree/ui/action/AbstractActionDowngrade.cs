// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.AbstractActionDowngrade
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.beans;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.action
{
  [Implements(new string[] {"org.jfree.ui.action.ActionDowngrade"})]
  [Serializable]
  public abstract class AbstractActionDowngrade : AbstractAction, ActionDowngrade, Action, ActionListener, EventListener
  {
    public const string ACCELERATOR_KEY = "AcceleratorKey";
    public const string MNEMONIC_KEY = "MnemonicKey";

    [LineNumberTable(new byte[] {(byte) 23, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractActionDowngrade()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractActionDowngrade([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    void Action.javax\u002Eswing\u002EAction\u002F\u0028Ljava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VremovePropertyChangeListener([In] PropertyChangeListener obj0)
    {
      this.removePropertyChangeListener(obj0);
    }

    [HideFromJava]
    void Action.javax\u002Eswing\u002EAction\u002F\u0028Ljava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VaddPropertyChangeListener([In] PropertyChangeListener obj0)
    {
      this.addPropertyChangeListener(obj0);
    }

    [HideFromJava]
    object Action.javax\u002Eswing\u002EAction\u002F\u0028Ljava\u002Elang\u002EString\u003B\u0029Ljava\u002Elang\u002EObject\u003BgetValue([In] string obj0)
    {
      return this.getValue(obj0);
    }

    [HideFromJava]
    void Action.javax\u002Eswing\u002EAction\u002F\u0028Z\u0029VsetEnabled([In] bool obj0)
    {
      this.setEnabled(obj0);
    }

    [HideFromJava]
    void Action.javax\u002Eswing\u002EAction\u002F\u0028Ljava\u002Elang\u002EString\u003BLjava\u002Elang\u002EObject\u003B\u0029VputValue([In] string obj0, [In] object obj1)
    {
      this.putValue(obj0, obj1);
    }

    [HideFromJava]
    bool Action.javax\u002Eswing\u002EAction\u002F\u0028\u0029ZisEnabled()
    {
      return this.isEnabled();
    }

    [HideFromJava]
    void ActionListener.java\u002Eawt\u002Eevent\u002EActionListener\u002F\u0028Ljava\u002Eawt\u002Eevent\u002EActionEvent\u003B\u0029VactionPerformed([In] ActionEvent obj0)
    {
      this.actionPerformed(obj0);
    }
  }
}
