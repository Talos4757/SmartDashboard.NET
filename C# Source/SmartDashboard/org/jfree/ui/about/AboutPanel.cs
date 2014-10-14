// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.AboutPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class AboutPanel : JPanel
  {
    [HideFromJava]
    static AboutPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 136, (byte) 139, (byte) 148, (byte) 102, (byte) 110, (byte) 110, (byte) 104, (byte) 137, (byte) 103, (byte) 111, (byte) 111, (byte) 104, (byte) 138, (byte) 103, (byte) 111, (byte) 104, (byte) 138, (byte) 103, (byte) 112, (byte) 104, (byte) 138, (byte) 104, (byte) 105, (byte) 105, (byte) 137, (byte) 136, (byte) 100, (byte) 113, (byte) 121, (byte) 113, (byte) 113, (byte) 110, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AboutPanel(string application, string version, string copyright, string info, Image logo)
    {
      base.\u002Ector();
      AboutPanel aboutPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new GridLayout(4, 1, 0, 4));
      JPanel jpanel2 = new JPanel();
      Font font1 = new Font("Dialog", 1, 14);
      JLabel jlabel1 = RefineryUtilities.createJLabel(application, font1, (Color) Color.black);
      jlabel1.setHorizontalTextPosition(0);
      ((Container) jpanel2).add((Component) jlabel1);
      JPanel jpanel3 = new JPanel();
      Font font2 = new Font("Dialog", 0, 12);
      JLabel jlabel2 = RefineryUtilities.createJLabel(version, font2, (Color) Color.black);
      jlabel2.setHorizontalTextPosition(0);
      ((Container) jpanel3).add((Component) jlabel2);
      JPanel jpanel4 = new JPanel();
      JLabel jlabel3 = RefineryUtilities.createJLabel(copyright, font2, (Color) Color.black);
      jlabel3.setHorizontalTextPosition(0);
      ((Container) jpanel4).add((Component) jlabel3);
      JPanel jpanel5 = new JPanel();
      JLabel jlabel4 = RefineryUtilities.createJLabel(info, font2, (Color) Color.black);
      jlabel4.setHorizontalTextPosition(0);
      ((Container) jpanel5).add((Component) jlabel4);
      ((Container) jpanel1).add((Component) jpanel2);
      ((Container) jpanel1).add((Component) jpanel3);
      ((Container) jpanel1).add((Component) jpanel4);
      ((Container) jpanel1).add((Component) jpanel5);
      ((Container) this).add((Component) jpanel1);
      if (logo == null)
        return;
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel6 = new JPanel((LayoutManager) new BorderLayout());
      JPanel jpanel7 = jpanel6;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel5 = new JLabel((Icon) new ImageIcon(logo));
      ((Container) jpanel7).add((Component) jlabel5);
      ((JComponent) jpanel6).setBorder(BorderFactory.createLineBorder((Color) Color.black));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel8 = new JPanel((LayoutManager) new BorderLayout());
      ((Container) jpanel8).add((Component) jpanel6, (object) "North");
      ((Container) this).add((Component) jpanel8, (object) "West");
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AboutPanel(string application, string version, string copyright, string info)
      : this(application, version, copyright, info, (Image) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AboutPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
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
