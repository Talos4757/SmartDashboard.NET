// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.TabbedApplet
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.beans;
using java.lang;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.tabbedui
{
  [Serializable]
  public class TabbedApplet : JApplet
  {
    private AbstractTabbedUI tabbedUI;

    [HideFromJava]
    static TabbedApplet()
    {
      JApplet.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TabbedApplet()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TabbedApplet([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    protected internal AbstractTabbedUI getTabbedUI()
    {
      return this.tabbedUI;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 103, (byte) 182, (byte) 102, (byte) 107, (byte) 108, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void init(AbstractTabbedUI tabbedUI)
    {
      this.tabbedUI = tabbedUI;
      ((Container) this.tabbedUI).addPropertyChangeListener("jMenuBar", (PropertyChangeListener) new TabbedApplet.MenuBarChangeListener(this));
      JPanel jpanel = new JPanel();
      ((Container) jpanel).setLayout((LayoutManager) new BorderLayout());
      ((Container) jpanel).add((Component) tabbedUI, (object) "Center");
      this.setContentPane((Container) jpanel);
      this.setJMenuBar(tabbedUI.getJMenuBar());
    }

    [InnerClass]
    [Implements(new string[] {"java.beans.PropertyChangeListener"})]
    [SourceFile("TabbedApplet.java")]
    [Modifiers]
    internal sealed class MenuBarChangeListener : Object, PropertyChangeListener, EventListener
    {
      [Modifiers]
      private TabbedApplet this\u00240;

      [LineNumberTable(new byte[] {(byte) 15, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public MenuBarChangeListener([In] TabbedApplet obj0)
      {
        base.\u002Ector();
        TabbedApplet.MenuBarChangeListener barChangeListener = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 25, (byte) 114, (byte) 157})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void propertyChange([In] PropertyChangeEvent obj0)
      {
        if (!String.instancehelper_equals(obj0.getPropertyName(), (object) "jMenuBar"))
          return;
        this.this\u00240.setJMenuBar(this.this\u00240.getTabbedUI().getJMenuBar());
      }
    }
  }
}
