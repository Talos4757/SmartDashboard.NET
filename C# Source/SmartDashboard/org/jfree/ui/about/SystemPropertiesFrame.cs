// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.SystemPropertiesFrame
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

namespace org.jfree.ui.about
{
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [Serializable]
  public class SystemPropertiesFrame : JFrame, ActionListener, EventListener
  {
    private const string COPY_COMMAND = "COPY";
    private const string CLOSE_COMMAND = "CLOSE";
    private SystemPropertiesPanel panel;

    [HideFromJava]
    static SystemPropertiesFrame()
    {
      JFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 98, (byte) 136, (byte) 102, (byte) 171, (byte) 108, (byte) 135, (byte) 135, (byte) 99, (byte) 173, (byte) 113, (byte) 107, (byte) 148, (byte) 146, (byte) 113, (byte) 144, (byte) 109, (byte) 146, (byte) 105, (byte) 142, (byte) 108, (byte) 136, (byte) 110, (byte) 142, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SystemPropertiesFrame(bool menu)
    {
      int num = menu ? 1 : 0;
      base.\u002Ector();
      SystemPropertiesFrame systemPropertiesFrame = this;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      ((Frame) this).setTitle(bundle.getString("system-frame.title"));
      this.setDefaultCloseOperation(2);
      if (num != 0)
        this.setJMenuBar(this.createMenuBar(bundle));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      this.panel = new SystemPropertiesPanel();
      ((JComponent) this.panel).setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));
      ((Container) jpanel1).add((Component) this.panel, (object) "Center");
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel2).setBorder(BorderFactory.createEmptyBorder(5, 0, 0, 0));
      string @string = bundle.getString("system-frame.button.close");
      Character character = (Character) bundle.getObject("system-frame.button.close.mnemonic");
      JButton jbutton = new JButton(@string);
      ((AbstractButton) jbutton).setMnemonic(character.charValue());
      ((AbstractButton) jbutton).setActionCommand("CLOSE");
      ((AbstractButton) jbutton).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) jbutton, (object) "East");
      ((Container) jpanel1).add((Component) jpanel2, (object) "South");
      this.setContentPane((Container) jpanel1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SystemPropertiesFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 134, (byte) 108, (byte) 145, (byte) 104, (byte) 140, (byte) 108, (byte) 145, (byte) 115, (byte) 140, (byte) 104, (byte) 137, (byte) 108, (byte) 145, (byte) 104, (byte) 141, (byte) 108, (byte) 145, (byte) 115, (byte) 108, (byte) 104, (byte) 138, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JMenuBar createMenuBar([In] ResourceBundle obj0)
    {
      JMenuBar jmenuBar = new JMenuBar();
      string string1 = obj0.getString("system-frame.menu.file");
      Character character1 = (Character) obj0.getObject("system-frame.menu.file.mnemonic");
      JMenu jmenu1 = new JMenu(string1, true);
      ((AbstractButton) jmenu1).setMnemonic(character1.charValue());
      string string2 = obj0.getString("system-frame.menu.file.close");
      Character character2 = (Character) obj0.getObject("system-frame.menu.file.close.mnemonic");
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem1 = new JMenuItem(string2, (int) character2.charValue());
      ((AbstractButton) jmenuItem1).setActionCommand("CLOSE");
      ((AbstractButton) jmenuItem1).addActionListener((ActionListener) this);
      jmenu1.add(jmenuItem1);
      string string3 = obj0.getString("system-frame.menu.edit");
      Character character3 = (Character) obj0.getObject("system-frame.menu.edit.mnemonic");
      JMenu jmenu2 = new JMenu(string3);
      ((AbstractButton) jmenu2).setMnemonic(character3.charValue());
      string string4 = obj0.getString("system-frame.menu.edit.copy");
      Character character4 = (Character) obj0.getObject("system-frame.menu.edit.copy.mnemonic");
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem2 = new JMenuItem(string4, (int) character4.charValue());
      ((AbstractButton) jmenuItem2).setActionCommand("COPY");
      ((AbstractButton) jmenuItem2).addActionListener((ActionListener) this);
      jmenu2.add(jmenuItem2);
      jmenuBar.add(jmenu1);
      jmenuBar.add(jmenu2);
      return jmenuBar;
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 103, (byte) 109, (byte) 136, (byte) 109, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent e)
    {
      string actionCommand = e.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "CLOSE"))
      {
        ((Window) this).dispose();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "COPY"))
          return;
        this.panel.copySystemPropertiesToClipboard();
      }
    }
  }
}
