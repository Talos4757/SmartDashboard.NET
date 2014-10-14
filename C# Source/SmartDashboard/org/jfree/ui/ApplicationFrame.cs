// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.ApplicationFrame
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.WindowListener"})]
  [Serializable]
  public class ApplicationFrame : JFrame, WindowListener, EventListener
  {
    [HideFromJava]
    static ApplicationFrame()
    {
      JFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ApplicationFrame(string title)
    {
      base.\u002Ector(title);
      ApplicationFrame applicationFrame = this;
      ((Window) this).addWindowListener((WindowListener) this);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ApplicationFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 105, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void windowClosing(WindowEvent @event)
    {
      if (@event.getWindow() != this)
        return;
      ((Window) this).dispose();
      System.exit(0);
    }

    public virtual void windowClosed(WindowEvent @event)
    {
    }

    public virtual void windowActivated(WindowEvent @event)
    {
    }

    public virtual void windowDeactivated(WindowEvent @event)
    {
    }

    public virtual void windowDeiconified(WindowEvent @event)
    {
    }

    public virtual void windowIconified(WindowEvent @event)
    {
    }

    public virtual void windowOpened(WindowEvent @event)
    {
    }
  }
}
