// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.AbstractTabbedUI
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.beans;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.tabbedui
{
  [Serializable]
  public abstract class AbstractTabbedUI : JComponent
  {
    public const string JMENUBAR_PROPERTY = "jMenuBar";
    public const string GLOBAL_MENU_PROPERTY = "globalMenu";
    private ArrayList rootEditors;
    private JTabbedPane tabbedPane;
    private int selectedRootEditor;
    private JComponent currentToolbar;
    private JPanel toolbarContainer;
    private Action closeAction;
    private JMenuBar jMenuBar;
    private bool globalMenu;

    [HideFromJava]
    static AbstractTabbedUI()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 104, (byte) 135, (byte) 107, (byte) 144, (byte) 108, (byte) 151, (byte) 139, (byte) 107, (byte) 113, (byte) 145, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractTabbedUI()
    {
      base.\u002Ector();
      AbstractTabbedUI abstractTabbedUi = this;
      this.selectedRootEditor = -1;
      this.toolbarContainer = new JPanel();
      ((Container) this.toolbarContainer).setLayout((LayoutManager) new BorderLayout());
      this.tabbedPane = new JTabbedPane(3);
      this.tabbedPane.addChangeListener((ChangeListener) new AbstractTabbedUI.TabChangeHandler(this, this.tabbedPane));
      this.rootEditors = new ArrayList();
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      ((Container) this).add((Component) this.toolbarContainer, (object) "North");
      ((Container) this).add((Component) this.tabbedPane, (object) "Center");
      this.closeAction = this.createCloseAction();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractTabbedUI([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    protected internal abstract void attempExit();

    [LineNumberTable((ushort) 265)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Action createCloseAction()
    {
      return (Action) new AbstractTabbedUI.ExitAction(this);
    }

    public virtual bool isGlobalMenu()
    {
      return this.globalMenu;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 103, (byte) 99, (byte) 168, (byte) 166, (byte) 109, (byte) 144, (byte) 114, (byte) 237, (byte) 61, (byte) 230, (byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JMenuBar updateGlobalMenubar()
    {
      JMenuBar jmenuBar = this.getJMenuBar();
      if (jmenuBar == null)
        jmenuBar = new JMenuBar();
      else
        ((Container) jmenuBar).removeAll();
      this.addMenus(jmenuBar, this.getPrefixMenus());
      for (int index = 0; index < this.rootEditors.size(); ++index)
      {
        RootEditor rootEditor = (RootEditor) this.rootEditors.get(index);
        this.addMenus(jmenuBar, rootEditor.getMenus());
      }
      this.addMenus(jmenuBar, this.getPostfixMenus());
      return jmenuBar;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setJMenuBar(JMenuBar menuBar)
    {
      JMenuBar jmenuBar = this.jMenuBar;
      this.jMenuBar = menuBar;
      ((Component) this).firePropertyChange("jMenuBar", (object) jmenuBar, (object) menuBar);
    }

    [LineNumberTable((ushort) 383)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRootEditorCount()
    {
      return this.rootEditors.size();
    }

    public virtual int getSelectedEditor()
    {
      return this.selectedRootEditor;
    }

    [LineNumberTable((ushort) 394)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RootEditor getRootEditor(int pos)
    {
      return (RootEditor) this.rootEditors.get(pos);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 103, (byte) 99, (byte) 168, (byte) 166, (byte) 109, (byte) 136, (byte) 144, (byte) 114, (byte) 237, (byte) 61, (byte) 232, (byte) 72, (byte) 141, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JMenuBar createEditorMenubar([In] RootEditor obj0)
    {
      JMenuBar jmenuBar = this.getJMenuBar();
      if (jmenuBar == null)
        jmenuBar = new JMenuBar();
      else
        ((Container) jmenuBar).removeAll();
      this.addMenus(jmenuBar, this.getPrefixMenus());
      if (this.isGlobalMenu())
      {
        for (int index = 0; index < this.rootEditors.size(); ++index)
        {
          RootEditor rootEditor = (RootEditor) this.rootEditors.get(index);
          this.addMenus(jmenuBar, rootEditor.getMenus());
        }
      }
      else
        this.addMenus(jmenuBar, obj0.getMenus());
      this.addMenus(jmenuBar, this.getPostfixMenus());
      return jmenuBar;
    }

    public virtual JMenuBar getJMenuBar()
    {
      return this.jMenuBar;
    }

    protected internal abstract JMenu[] getPrefixMenus();

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 103, (byte) 42, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addMenus([In] JMenuBar obj0, [In] JMenu[] obj1)
    {
      for (int index = 0; index < obj1.Length; ++index)
        obj0.add(obj1[index]);
    }

    protected internal abstract JMenu[] getPostfixMenus();

    [LineNumberTable(new byte[] {(byte) 161, (byte) 120, (byte) 103, (byte) 112, (byte) 109, (byte) 105, (byte) 111, (byte) 225, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateRootEditorEnabled(RootEditor editor)
    {
      int num = editor.isEnabled() ? 1 : 0;
      for (int index = 0; index < this.tabbedPane.getTabCount(); ++index)
      {
        if (this.tabbedPane.getComponentAt(index) == editor.getMainPanel())
        {
          this.tabbedPane.setEnabledAt(index, num != 0);
          break;
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 103, (byte) 132, (byte) 129, (byte) 231, (byte) 69, (byte) 112, (byte) 101, (byte) 146, (byte) 107, (byte) 231, (byte) 59, (byte) 230, (byte) 73, (byte) 104, (byte) 102, (byte) 107, (byte) 167, (byte) 115, (byte) 101, (byte) 146, (byte) 114, (byte) 103, (byte) 109, (byte) 108, (byte) 104, (byte) 150, (byte) 108, (byte) 174, (byte) 172, (byte) 235, (byte) 46, (byte) 233, (byte) 85})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSelectedEditor(int selectedEditor)
    {
      if (this.selectedRootEditor == selectedEditor)
        return;
      this.selectedRootEditor = selectedEditor;
      for (int index = 0; index < this.rootEditors.size(); ++index)
      {
        int num = index == selectedEditor ? 1 : 0;
        RootEditor rootEditor = (RootEditor) this.rootEditors.get(index);
        if (rootEditor.isActive() && num == 0)
          rootEditor.setActive(false);
      }
      if (this.currentToolbar != null)
      {
        this.closeToolbar();
        ((Container) this.toolbarContainer).removeAll();
        this.currentToolbar = (JComponent) null;
      }
      for (int index = 0; index < this.rootEditors.size(); ++index)
      {
        int num = index == selectedEditor ? 1 : 0;
        RootEditor rootEditor = (RootEditor) this.rootEditors.get(index);
        if (!rootEditor.isActive() && num == 1)
        {
          rootEditor.setActive(true);
          this.setJMenuBar(this.createEditorMenubar(rootEditor));
          this.currentToolbar = rootEditor.getToolbar();
          if (this.currentToolbar != null)
          {
            ((Container) this.toolbarContainer).add((Component) this.currentToolbar, (object) "Center");
            ((JComponent) this.toolbarContainer).setVisible(true);
            this.currentToolbar.setVisible(true);
          }
          else
            ((JComponent) this.toolbarContainer).setVisible(false);
          ((Component) this.getJMenuBar()).repaint();
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 94, (byte) 104, (byte) 179, (byte) 108, (byte) 99, (byte) 103, (byte) 166, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void closeToolbar()
    {
      if (this.currentToolbar == null)
        return;
      if (((Component) this.currentToolbar).getParent() != this.toolbarContainer)
      {
        Window window = SwingUtilities.windowForComponent((Component) this.currentToolbar);
        if (window != null)
        {
          window.setVisible(false);
          window.dispose();
        }
      }
      this.currentToolbar.setVisible(false);
    }

    protected internal virtual JTabbedPane getTabbedPane()
    {
      return this.tabbedPane;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 85, (byte) 66, (byte) 103, (byte) 104, (byte) 174, (byte) 105, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGlobalMenu(bool globalMenu)
    {
      this.globalMenu = globalMenu;
      if (this.isGlobalMenu())
      {
        this.setJMenuBar(this.updateGlobalMenubar());
      }
      else
      {
        if (this.getRootEditorCount() <= 0)
          return;
        this.setJMenuBar(this.createEditorMenubar(this.getRootEditor(this.getSelectedEditor())));
      }
    }

    public virtual Action getCloseAction()
    {
      return this.closeAction;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 109, (byte) 120, (byte) 113, (byte) 103, (byte) 105, (byte) 137, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRootEditor(RootEditor rootPanel)
    {
      this.rootEditors.add((object) rootPanel);
      this.tabbedPane.add(rootPanel.getEditorName(), (Component) rootPanel.getMainPanel());
      rootPanel.addPropertyChangeListener("enabled", (PropertyChangeListener) new AbstractTabbedUI.TabEnableChangeListener(this));
      this.updateRootEditorEnabled(rootPanel);
      if (this.getRootEditorCount() == 1)
      {
        this.setSelectedEditor(0);
      }
      else
      {
        if (!this.isGlobalMenu())
          return;
        this.setJMenuBar(this.updateGlobalMenubar());
      }
    }

    [InnerClass]
    [SourceFile("AbstractTabbedUI.java")]
    [Serializable]
    public class ExitAction : AbstractAction
    {
      [Modifiers]
      private AbstractTabbedUI this\u00240;

      [LineNumberTable(new byte[] {(byte) 38, (byte) 111, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ExitAction(AbstractTabbedUI atui)
      {
        base.\u002Ector();
        AbstractTabbedUI.ExitAction exitAction = this;
        this.this\u00240 = atui;
        this.putValue("Name", (object) "Exit");
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ExitAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 48, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed(ActionEvent e)
      {
        this.this\u00240.attempExit();
      }
    }

    [InnerClass]
    [Implements(new string[] {"javax.swing.event.ChangeListener"})]
    [SourceFile("AbstractTabbedUI.java")]
    [Modifiers]
    internal sealed class TabChangeHandler : Object, ChangeListener, EventListener
    {
      [Modifiers]
      private JTabbedPane pane;
      [Modifiers]
      private AbstractTabbedUI this\u00240;

      [LineNumberTable(new byte[] {(byte) 66, (byte) 111, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public TabChangeHandler([In] AbstractTabbedUI obj0, [In] JTabbedPane obj1)
      {
        base.\u002Ector();
        AbstractTabbedUI.TabChangeHandler tabChangeHandler = this;
        this.this\u00240 = obj0;
        this.pane = obj1;
      }

      [LineNumberTable(new byte[] {(byte) 76, (byte) 120})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void stateChanged([In] ChangeEvent obj0)
      {
        this.this\u00240.setSelectedEditor(this.pane.getSelectedIndex());
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.beans.PropertyChangeListener"})]
    [SourceFile("AbstractTabbedUI.java")]
    [Modifiers]
    internal sealed class TabEnableChangeListener : Object, PropertyChangeListener, EventListener
    {
      [Modifiers]
      private AbstractTabbedUI this\u00240;

      [LineNumberTable(new byte[] {(byte) 88, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public TabEnableChangeListener([In] AbstractTabbedUI obj0)
      {
        base.\u002Ector();
        AbstractTabbedUI.TabEnableChangeListener enableChangeListener = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 98, (byte) 114, (byte) 108, (byte) 129, (byte) 109, (byte) 108, (byte) 129, (byte) 108, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void propertyChange([In] PropertyChangeEvent obj0)
      {
        if (!String.instancehelper_equals(obj0.getPropertyName(), (object) "enabled"))
          Log.debug((object) "PropertyName");
        else if (!(((EventObject) obj0).getSource() is RootEditor))
          Log.debug((object) "Source");
        else
          this.this\u00240.updateRootEditorEnabled((RootEditor) ((EventObject) obj0).getSource());
      }
    }
  }
}
