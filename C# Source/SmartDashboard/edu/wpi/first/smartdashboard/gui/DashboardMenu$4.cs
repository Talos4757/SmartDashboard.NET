// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$4
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.filechooser;
using org.jfree.ui;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.MainPanel;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u00244 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal DashboardFrame val\u0024frame;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u00244([In] DashboardMenu obj0, [In] DashboardFrame obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 107, (byte) 117, (byte) 107, (byte) 139, (byte) 103, (byte) 135, (byte) 110, (byte) 108, (byte) 109, (byte) 155, (byte) 108, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      JFileChooser jfileChooser = new JFileChooser(".");
      jfileChooser.addChoosableFileFilter((FileFilter) new ExtensionFileFilter("XML File", ".xml"));
      jfileChooser.setApproveButtonText("Save");
      jfileChooser.setDialogTitle("Save As...");
      jfileChooser.setMultiSelectionEnabled(false);
      jfileChooser.setFileSelectionMode(0);
      if (jfileChooser.showOpenDialog((Component) this.val\u0024frame) != 0)
        return;
      string path = jfileChooser.getSelectedFile().getAbsolutePath();
      if (!String.instancehelper_endsWith(path, ".xml"))
        path = new StringBuilder().append(path).append(".xml").toString();
      this.val\u0024frame.save(path);
      this.val\u0024frame.getPrefs().__\u003C\u003EsaveFile.setValue((object) path);
    }
  }
}
