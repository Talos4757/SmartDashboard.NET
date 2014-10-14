// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.StandardDialog
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [Serializable]
  public class StandardDialog : JDialog, ActionListener, EventListener
  {
    private bool cancelled;
    internal static ResourceBundle __\u003C\u003ElocalizationResources;

    [Modifiers]
    protected internal static ResourceBundle localizationResources
    {
      [HideFromJava] get
      {
        return StandardDialog.__\u003C\u003ElocalizationResources;
      }
    }

    [LineNumberTable((ushort) 73)]
    static StandardDialog()
    {
      JDialog.__\u003Cclinit\u003E();
      StandardDialog.__\u003C\u003ElocalizationResources = ResourceBundleWrapper.getBundle("org.jfree.ui.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 121, (byte) 130, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialog(Frame owner, string title, bool modal)
    {
      int num = modal ? 1 : 0;
      base.\u002Ector(owner, title, num != 0);
      StandardDialog standardDialog = this;
      this.cancelled = false;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 162, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialog(Dialog owner, string title, bool modal)
    {
      int num = modal ? 1 : 0;
      base.\u002Ector(owner, title, num != 0);
      StandardDialog standardDialog = this;
      this.cancelled = false;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardDialog([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual bool isCancelled()
    {
      return this.cancelled;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 103, (byte) 175, (byte) 109, (byte) 103, (byte) 137, (byte) 109, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent @event)
    {
      string actionCommand = @event.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "helpButton"))
        return;
      if (String.instancehelper_equals(actionCommand, (object) "okButton"))
      {
        this.cancelled = false;
        ((Dialog) this).setVisible(false);
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "cancelButton"))
          return;
        this.cancelled = true;
        ((Dialog) this).setVisible(false);
      }
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 255, (byte) 25, (byte) 69, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 135, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JPanel createButtonPanel()
    {
      L1R2ButtonPanel.__\u003Cclinit\u003E();
      L1R2ButtonPanel l1R2ButtonPanel = new L1R2ButtonPanel(StandardDialog.__\u003C\u003ElocalizationResources.getString("Help"), StandardDialog.__\u003C\u003ElocalizationResources.getString("OK"), StandardDialog.__\u003C\u003ElocalizationResources.getString("Cancel"));
      JButton leftButton = l1R2ButtonPanel.getLeftButton();
      ((AbstractButton) leftButton).setActionCommand("helpButton");
      ((AbstractButton) leftButton).addActionListener((ActionListener) this);
      JButton rightButton1 = l1R2ButtonPanel.getRightButton1();
      ((AbstractButton) rightButton1).setActionCommand("okButton");
      ((AbstractButton) rightButton1).addActionListener((ActionListener) this);
      JButton rightButton2 = l1R2ButtonPanel.getRightButton2();
      ((AbstractButton) rightButton2).setActionCommand("cancelButton");
      ((AbstractButton) rightButton2).addActionListener((ActionListener) this);
      ((JComponent) l1R2ButtonPanel).setBorder(BorderFactory.createEmptyBorder(4, 0, 0, 0));
      return (JPanel) l1R2ButtonPanel;
    }
  }
}
