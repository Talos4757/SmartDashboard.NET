// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.WizardDialog
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
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [Serializable]
  public class WizardDialog : JDialog, ActionListener, EventListener
  {
    private object result;
    private int step;
    private WizardPanel currentPanel;
    private List panels;
    private JButton previousButton;
    private JButton nextButton;
    private JButton finishButton;
    private JButton helpButton;

    [HideFromJava]
    static WizardDialog()
    {
      JDialog.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 162, (byte) 127, (byte) 5, (byte) 103, (byte) 104, (byte) 103, (byte) 107, (byte) 110, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WizardDialog(JDialog owner, bool modal, string title, WizardPanel firstPanel)
    {
      int num = modal ? 1 : 0;
      base.\u002Ector((Dialog) owner, new StringBuffer().append(title).append(" : step 1").toString(), num != 0);
      WizardDialog wizardDialog = this;
      this.result = (object) null;
      this.currentPanel = firstPanel;
      this.step = 0;
      this.panels = (List) new ArrayList();
      this.panels.add((object) firstPanel);
      this.setContentPane((Container) this.createContent());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 109, (byte) 66, (byte) 127, (byte) 5, (byte) 103, (byte) 104, (byte) 103, (byte) 107, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WizardDialog(JFrame owner, bool modal, string title, WizardPanel firstPanel)
    {
      int num = modal ? 1 : 0;
      base.\u002Ector((Frame) owner, new StringBuffer().append(title).append(" : step 1").toString(), num != 0);
      WizardDialog wizardDialog = this;
      this.result = (object) null;
      this.currentPanel = firstPanel;
      this.step = 0;
      this.panels = (List) new ArrayList();
      this.panels.add((object) firstPanel);
      this.setContentPane((Container) this.createContent());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WizardDialog([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 112, (byte) 111, (byte) 120, (byte) 154, (byte) 108, (byte) 140, (byte) 108, (byte) 112, (byte) 108, (byte) 140, (byte) 108, (byte) 112, (byte) 108, (byte) 140, (byte) 108, (byte) 112, (byte) 108, (byte) 140, (byte) 111, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JPanel createContent()
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel).setBorder(BorderFactory.createEmptyBorder(4, 4, 4, 4));
      ((Container) jpanel).add((Component) this.panels.get(0));
      L1R3ButtonPanel l1R3ButtonPanel = new L1R3ButtonPanel("Help", "Previous", "Next", "Finish");
      this.helpButton = l1R3ButtonPanel.getLeftButton();
      ((AbstractButton) this.helpButton).setEnabled(false);
      this.previousButton = l1R3ButtonPanel.getRightButton1();
      ((AbstractButton) this.previousButton).setActionCommand("previousButton");
      ((AbstractButton) this.previousButton).addActionListener((ActionListener) this);
      ((AbstractButton) this.previousButton).setEnabled(false);
      this.nextButton = l1R3ButtonPanel.getRightButton2();
      ((AbstractButton) this.nextButton).setActionCommand("nextButton");
      ((AbstractButton) this.nextButton).addActionListener((ActionListener) this);
      ((AbstractButton) this.nextButton).setEnabled(true);
      this.finishButton = l1R3ButtonPanel.getRightButton3();
      ((AbstractButton) this.finishButton).setActionCommand("finishButton");
      ((AbstractButton) this.finishButton).addActionListener((ActionListener) this);
      ((AbstractButton) this.finishButton).setEnabled(false);
      ((JComponent) l1R3ButtonPanel).setBorder(BorderFactory.createEmptyBorder(4, 0, 0, 0));
      ((Container) jpanel).add((Component) l1R3ButtonPanel, (object) "South");
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 111, (byte) 99, (byte) 109, (byte) 206, (byte) 172, (byte) 110, (byte) 115, (byte) 181, (byte) 173, (byte) 103, (byte) 108, (byte) 136, (byte) 103, (byte) 127, (byte) 8, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void next()
    {
      WizardPanel wizardPanel = this.getWizardPanel(this.step + 1);
      if (wizardPanel != null)
      {
        if (!this.currentPanel.canRedisplayNextPanel())
          wizardPanel = this.currentPanel.getNextPanel();
      }
      else
        wizardPanel = this.currentPanel.getNextPanel();
      this.step = this.step + 1;
      if (this.step < this.panels.size())
        this.panels.set(this.step, (object) wizardPanel);
      else
        this.panels.add((object) wizardPanel);
      Container contentPane = this.getContentPane();
      contentPane.remove((Component) this.currentPanel);
      contentPane.add((Component) wizardPanel);
      this.currentPanel = wizardPanel;
      ((Dialog) this).setTitle(new StringBuffer().append("Step ").append(this.step + 1).toString());
      this.enableButtons();
      ((Window) this).pack();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 108, (byte) 143, (byte) 102, (byte) 103, (byte) 108, (byte) 104, (byte) 110, (byte) 103, (byte) 127, (byte) 8, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void previous()
    {
      if (this.step <= 0)
        return;
      WizardPanel wizardPanel = this.getWizardPanel(this.step - 1);
      wizardPanel.returnFromLaterStep();
      Container contentPane = this.getContentPane();
      contentPane.remove((Component) this.currentPanel);
      contentPane.add((Component) wizardPanel);
      this.step = this.step - 1;
      this.currentPanel = wizardPanel;
      ((Dialog) this).setTitle(new StringBuffer().append("Step ").append(this.step + 1).toString());
      this.enableButtons();
      ((Window) this).pack();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 113, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void finish()
    {
      this.result = this.currentPanel.getResult();
      ((Dialog) this).setVisible(false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 110, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WizardPanel getWizardPanel(int step)
    {
      if (step < this.panels.size())
        return (WizardPanel) this.panels.get(step);
      else
        return (WizardPanel) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 116, (byte) 113, (byte) 113, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void enableButtons()
    {
      ((AbstractButton) this.previousButton).setEnabled(this.step > 0);
      ((AbstractButton) this.nextButton).setEnabled(this.canDoNextPanel());
      ((AbstractButton) this.finishButton).setEnabled(this.canFinish());
      ((AbstractButton) this.helpButton).setEnabled(false);
    }

    [LineNumberTable((ushort) 176)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool canDoNextPanel()
    {
      return (this.currentPanel.hasNextPanel() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 186)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool canFinish()
    {
      return (this.currentPanel.canFinish() ? 1 : 0) != 0;
    }

    public virtual object getResult()
    {
      return this.result;
    }

    public virtual int getStepCount()
    {
      return 0;
    }

    public virtual bool canDoPreviousPanel()
    {
      return this.step > 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 103, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent @event)
    {
      string actionCommand = @event.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "nextButton"))
        this.next();
      else if (String.instancehelper_equals(actionCommand, (object) "previousButton"))
      {
        this.previous();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "finishButton"))
          return;
        this.finish();
      }
    }

    public virtual bool isCancelled()
    {
      return false;
    }
  }
}
