// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.WizardPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public abstract class WizardPanel : JPanel
  {
    private WizardDialog owner;

    [HideFromJava]
    static WizardPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal WizardPanel(LayoutManager layout)
    {
      base.\u002Ector(layout);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WizardPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    public abstract bool hasNextPanel();

    public abstract bool canFinish();

    public abstract void returnFromLaterStep();

    public abstract bool canRedisplayNextPanel();

    public abstract WizardPanel getNextPanel();

    public virtual object getResult()
    {
      return (object) null;
    }

    public virtual WizardDialog getOwner()
    {
      return this.owner;
    }

    public virtual void setOwner(WizardDialog owner)
    {
      this.owner = owner;
    }
  }
}
