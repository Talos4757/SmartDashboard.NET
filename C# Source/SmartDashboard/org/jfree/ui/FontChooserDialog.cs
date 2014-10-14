// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FontChooserDialog
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
  public class FontChooserDialog : StandardDialog
  {
    private FontChooserPanel fontChooserPanel;

    [HideFromJava]
    static FontChooserDialog()
    {
      StandardDialog.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 66, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FontChooserDialog(Dialog owner, string title, bool modal, Font font)
    {
      int num = modal ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(owner, title, num != 0);
      FontChooserDialog fontChooserDialog = this;
      this.setContentPane((Container) this.createContent(font));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 121, (byte) 98, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FontChooserDialog(Frame owner, string title, bool modal, Font font)
    {
      int num = modal ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(owner, title, num != 0);
      FontChooserDialog fontChooserDialog = this;
      this.setContentPane((Container) this.createContent(font));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FontChooserDialog([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 112, (byte) 111, (byte) 99, (byte) 143, (byte) 108, (byte) 141, (byte) 103, (byte) 111, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel createContent([In] Font obj0)
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel).setBorder(BorderFactory.createEmptyBorder(4, 4, 4, 4));
      if (obj0 == null)
        obj0 = new Font("Dialog", 10, 0);
      this.fontChooserPanel = new FontChooserPanel(obj0);
      ((Container) jpanel).add((Component) this.fontChooserPanel);
      JPanel buttonPanel = this.createButtonPanel();
      ((JComponent) buttonPanel).setBorder(BorderFactory.createEmptyBorder(4, 0, 0, 0));
      ((Container) jpanel).add((Component) buttonPanel, (object) "South");
      return jpanel;
    }

    [LineNumberTable((ushort) 95)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getSelectedFont()
    {
      return this.fontChooserPanel.getSelectedFont();
    }
  }
}
