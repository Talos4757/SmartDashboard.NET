// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.MainPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public sealed class MainPanel : JPanel
  {
    [Signature("Ljava/util/HashMap<Ljava/lang/String;Ledu/wpi/first/smartdashboard/gui/DashboardPanel;>;")]
    internal static HashMap __\u003C\u003Epanels;
    private static DashboardPanel currentPanel;

    [Modifiers]
    public static HashMap panels
    {
      [HideFromJava] get
      {
        return MainPanel.__\u003C\u003Epanels;
      }
    }

    [LineNumberTable((ushort) 20)]
    static MainPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      MainPanel.__\u003C\u003Epanels = new HashMap();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 103, (byte) 111, (byte) 50, (byte) 134, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MainPanel(LayoutManager layout, DashboardPanel defaultPanel, params DashboardPanel[] panels)
    {
      base.\u002Ector(layout);
      DashboardPanel[] dashboardPanelArray = panels;
      int length = dashboardPanelArray.Length;
      for (int index = 0; index < length; ++index)
      {
        DashboardPanel dashboardPanel = dashboardPanelArray[index];
        MainPanel.__\u003C\u003Epanels.put((object) ((Component) dashboardPanel).getName(), (object) dashboardPanel);
      }
      MainPanel.currentPanel = defaultPanel;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MainPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DashboardPanel getPanel(string name)
    {
      return (DashboardPanel) MainPanel.__\u003C\u003Epanels.get((object) name);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 109, (byte) 104, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCurrentPanel(DashboardPanel panel)
    {
      if (MainPanel.__\u003C\u003Epanels.containsValue((object) panel))
      {
        MainPanel.currentPanel = panel;
      }
      else
      {
        string str = "Not a valid panel";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    public static DashboardPanel getCurrentPanel()
    {
      return MainPanel.currentPanel;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 109, (byte) 111, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPanel(string name, DashboardPanel panel)
    {
      if (!MainPanel.__\u003C\u003Epanels.containsValue((object) panel))
      {
        MainPanel.__\u003C\u003Epanels.put((object) name, (object) panel);
      }
      else
      {
        string str = "That panel already exists";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }
  }
}
