// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.RootPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.beans;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.tabbedui
{
  [Implements(new string[] {"org.jfree.ui.tabbedui.RootEditor"})]
  [Serializable]
  public abstract class RootPanel : JComponent, RootEditor
  {
    private bool active;

    [HideFromJava]
    static RootPanel()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RootPanel()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RootPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    protected internal virtual void panelActivated()
    {
    }

    protected internal virtual void panelDeactivated()
    {
    }

    public bool isActive()
    {
      return this.active;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 98, (byte) 105, (byte) 129, (byte) 103, (byte) 99, (byte) 168, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void setActive(bool active)
    {
      int num = active ? 1 : 0;
      if ((this.active ? 1 : 0) == num)
        return;
      this.active = num != 0;
      if (num != 0)
        this.panelActivated();
      else
        this.panelDeactivated();
    }

    public virtual JComponent getMainPanel()
    {
      return (JComponent) this;
    }

    public virtual JComponent getToolbar()
    {
      return (JComponent) null;
    }

    [HideFromReflection]
    public abstract string getEditorName();

    [HideFromReflection]
    public abstract JMenu[] getMenus();

    [HideFromJava]
    bool RootEditor.org\u002Ejfree\u002Eui\u002Etabbedui\u002ERootEditor\u002F\u0028\u0029ZisEnabled()
    {
      return ((Component) this).isEnabled();
    }

    [HideFromJava]
    void RootEditor.org\u002Ejfree\u002Eui\u002Etabbedui\u002ERootEditor\u002F\u0028Ljava\u002Elang\u002EString\u003BLjava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VaddPropertyChangeListener([In] string obj0, [In] PropertyChangeListener obj1)
    {
      ((Container) this).addPropertyChangeListener(obj0, obj1);
    }

    [HideFromJava]
    void RootEditor.org\u002Ejfree\u002Eui\u002Etabbedui\u002ERootEditor\u002F\u0028Ljava\u002Elang\u002EString\u003BLjava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VremovePropertyChangeListener([In] string obj0, [In] PropertyChangeListener obj1)
    {
      ((Component) this).removePropertyChangeListener(obj0, obj1);
    }

    [HideFromJava]
    void RootEditor.org\u002Ejfree\u002Eui\u002Etabbedui\u002ERootEditor\u002F\u0028Ljava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VaddPropertyChangeListener([In] PropertyChangeListener obj0)
    {
      ((Container) this).addPropertyChangeListener(obj0);
    }

    [HideFromJava]
    void RootEditor.org\u002Ejfree\u002Eui\u002Etabbedui\u002ERootEditor\u002F\u0028Ljava\u002Ebeans\u002EPropertyChangeListener\u003B\u0029VremovePropertyChangeListener([In] PropertyChangeListener obj0)
    {
      ((Component) this).removePropertyChangeListener(obj0);
    }
  }
}
