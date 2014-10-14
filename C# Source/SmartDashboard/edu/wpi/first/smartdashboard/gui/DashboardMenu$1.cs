// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.io;
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
  internal sealed class DashboardMenu\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal DashboardFrame val\u0024frame;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u00241([In] DashboardMenu obj0, [In] DashboardFrame obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 102, (byte) 127, (byte) 11, (byte) 117, (byte) 103, (byte) 103, (byte) 107, (byte) 139, (byte) 110, (byte) 140, (byte) 108, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      JFileChooser jfileChooser1 = new JFileChooser();
      JFileChooser jfileChooser2 = jfileChooser1;
      File.__\u003Cclinit\u003E();
      File file = new File((string) this.val\u0024frame.getPrefs().__\u003C\u003EsaveFile.getValue());
      jfileChooser2.setCurrentDirectory(file);
      jfileChooser1.addChoosableFileFilter((FileFilter) new ExtensionFileFilter("XML File", ".xml"));
      jfileChooser1.setMultiSelectionEnabled(false);
      jfileChooser1.setFileSelectionMode(0);
      jfileChooser1.setApproveButtonText("Open");
      jfileChooser1.setDialogTitle("Open");
      if (jfileChooser1.showOpenDialog((Component) this.val\u0024frame) != 0)
        return;
      string absolutePath = jfileChooser1.getSelectedFile().getAbsolutePath();
      this.val\u0024frame.load(absolutePath);
      this.val\u0024frame.getPrefs().__\u003C\u003EsaveFile.setValue((object) absolutePath);
    }
  }
}
