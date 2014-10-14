// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public class DashboardMenu : JMenuBar
  {
    [HideFromJava]
    static DashboardMenu()
    {
      JMenuBar.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 104, (byte) 107, (byte) 107, (byte) 114, (byte) 237, (byte) 82, (byte) 136, (byte) 107, (byte) 114, (byte) 237, (byte) 69, (byte) 136, (byte) 108, (byte) 115, (byte) 238, (byte) 69, (byte) 137, (byte) 108, (byte) 115, (byte) 238, (byte) 84, (byte) 137, (byte) 108, (byte) 238, (byte) 72, (byte) 137, (byte) 108, (byte) 238, (byte) 69, (byte) 137, (byte) 108, (byte) 108, (byte) 237, (byte) 71, (byte) 115, (byte) 138, (byte) 108, (byte) 237, (byte) 69, (byte) 115, (byte) 103, (byte) 138, (byte) 108, (byte) 237, (byte) 76, (byte) 115, (byte) 255, (byte) 5, (byte) 85, (byte) 138, (byte) 108, (byte) 103, (byte) 127, (byte) 1, (byte) 115, (byte) 240, (byte) 75, (byte) 106, (byte) 130, (byte) 138, (byte) 140, (byte) 240, (byte) 90, (byte) 138, (byte) 108, (byte) 237, (byte) 70, (byte) 138, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu([In] DashboardFrame obj0, [In] MainPanel obj1)
    {
      base.\u002Ector();
      DashboardMenu dashboardMenu = this;
      JMenu jmenu1 = new JMenu("File");
      JMenuItem jmenuItem1 = new JMenuItem("Open...");
      jmenuItem1.setAccelerator(KeyStroke.getKeyStroke(79, 128));
      ((AbstractButton) jmenuItem1).addActionListener((ActionListener) new DashboardMenu\u00241(this, obj0));
      jmenu1.add(jmenuItem1);
      JMenuItem jmenuItem2 = new JMenuItem("New");
      jmenuItem2.setAccelerator(KeyStroke.getKeyStroke(78, 128));
      ((AbstractButton) jmenuItem2).addActionListener((ActionListener) new DashboardMenu\u00242(this, obj1));
      jmenu1.add(jmenuItem2);
      JMenuItem jmenuItem3 = new JMenuItem("Save");
      jmenuItem3.setAccelerator(KeyStroke.getKeyStroke(83, 128));
      ((AbstractButton) jmenuItem3).addActionListener((ActionListener) new DashboardMenu\u00243(this, obj0));
      jmenu1.add(jmenuItem3);
      JMenuItem jmenuItem4 = new JMenuItem("Save As...");
      jmenuItem4.setAccelerator(KeyStroke.getKeyStroke(83, 192));
      ((AbstractButton) jmenuItem4).addActionListener((ActionListener) new DashboardMenu\u00244(this, obj0));
      jmenu1.add(jmenuItem4);
      JMenuItem jmenuItem5 = new JMenuItem("Preferences");
      ((AbstractButton) jmenuItem5).addActionListener((ActionListener) new DashboardMenu\u00245(this, obj0));
      jmenu1.add(jmenuItem5);
      JMenuItem jmenuItem6 = new JMenuItem("Exit");
      ((AbstractButton) jmenuItem6).addActionListener((ActionListener) new DashboardMenu\u00246(this, obj0));
      jmenu1.add(jmenuItem6);
      JMenu jmenu2 = new JMenu("View");
      JCheckBoxMenuItem jcheckBoxMenuItem1 = new JCheckBoxMenuItem("Editable");
      ((AbstractButton) jcheckBoxMenuItem1).addActionListener((ActionListener) new DashboardMenu\u00247(this));
      ((JMenuItem) jcheckBoxMenuItem1).setAccelerator(KeyStroke.getKeyStroke(69, 128));
      jmenu2.add((JMenuItem) jcheckBoxMenuItem1);
      JCheckBoxMenuItem jcheckBoxMenuItem2 = new JCheckBoxMenuItem("Edit Subsystems");
      ((AbstractButton) jcheckBoxMenuItem2).addActionListener((ActionListener) new DashboardMenu\u00248(this));
      ((JMenuItem) jcheckBoxMenuItem2).setAccelerator(KeyStroke.getKeyStroke(69, 192));
      ((AbstractButton) jcheckBoxMenuItem2).doClick();
      jmenu2.add((JMenuItem) jcheckBoxMenuItem2);
      JMenuItem jmenuItem7 = new JMenuItem("Reset LiveWindow");
      ((AbstractButton) jmenuItem7).addActionListener((ActionListener) new DashboardMenu\u00249(this));
      jmenuItem7.setAccelerator(KeyStroke.getKeyStroke(82, 128));
      Robot.getLiveWindow().getSubTable("~STATUS~").addTableListener("LW Enabled", (ITableListener) new DashboardMenu\u002410(this, obj0, obj1, jmenuItem7), true);
      jmenu2.add(jmenuItem7);
      JMenu jmenu3 = new JMenu("Add...");
      Iterator iterator = DisplayElementRegistry.getStaticWidgets().iterator();
      while (iterator.hasNext())
      {
        Class clazz = (Class) iterator.next();
        JMenuItem.__\u003Cclinit\u003E();
        JMenuItem jmenuItem8 = new JMenuItem(DisplayElement.getName(clazz));
        ((AbstractButton) jmenuItem8).addActionListener((ActionListener) new DashboardMenu\u002411(this, clazz, obj1));
        jmenu3.add(jmenuItem8);
      }
      jmenu2.add((JMenuItem) jmenu3);
      JMenu jmenu4 = new JMenu("Reveal...");
      jmenu2.addMenuListener((MenuListener) new DashboardMenu\u002412(this, jmenu4, obj1));
      jmenu2.add((JMenuItem) jmenu4);
      JMenuItem jmenuItem9 = new JMenuItem("Remove Unused");
      ((AbstractButton) jmenuItem9).addActionListener((ActionListener) new DashboardMenu\u002413(this));
      jmenu2.add(jmenuItem9);
      this.add(jmenu1);
      this.add(jmenu2);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DashboardMenu([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }
  }
}
