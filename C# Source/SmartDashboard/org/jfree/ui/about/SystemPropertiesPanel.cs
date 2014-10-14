// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.SystemPropertiesPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.awt.datatransfer;
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
  [Serializable]
  public class SystemPropertiesPanel : JPanel
  {
    private JTable table;
    private JPopupMenu copyPopupMenu;
    private JMenuItem copyMenuItem;
    private SystemPropertiesPanel.PopupListener copyPopupListener;

    [HideFromJava]
    static SystemPropertiesPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 136, (byte) 102, (byte) 171, (byte) 107, (byte) 107, (byte) 183, (byte) 139, (byte) 140, (byte) 145, (byte) 108, (byte) 108, (byte) 145, (byte) 241, (byte) 69, (byte) 178, (byte) 108, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SystemPropertiesPanel()
    {
      base.\u002Ector();
      SystemPropertiesPanel systemPropertiesPanel = this;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.table = (JTable) SystemProperties.createSystemPropertiesTable();
      JScrollPane.__\u003Cclinit\u003E();
      ((Container) this).add((Component) new JScrollPane((Component) this.table));
      this.copyPopupMenu = new JPopupMenu();
      string @string = bundle.getString("system-properties-panel.popup-menu.copy");
      KeyStroke keyStroke = (KeyStroke) bundle.getObject("system-properties-panel.popup-menu.copy.accelerator");
      this.copyMenuItem = new JMenuItem(@string);
      this.copyMenuItem.setAccelerator(keyStroke);
      this.copyMenuItem.getAccessibleContext().setAccessibleDescription(@string);
      ((AbstractButton) this.copyMenuItem).addActionListener((ActionListener) new SystemPropertiesPanel\u00241(this));
      this.copyPopupMenu.add(this.copyMenuItem);
      this.copyPopupListener = new SystemPropertiesPanel.PopupListener(this);
      ((Component) this.table).addMouseListener((MouseListener) this.copyPopupListener);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SystemPropertiesPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 102, (byte) 108, (byte) 103, (byte) 103, (byte) 110, (byte) 104, (byte) 114, (byte) 118, (byte) 101, (byte) 236, (byte) 61, (byte) 232, (byte) 70, (byte) 236, (byte) 57, (byte) 235, (byte) 74, (byte) 114, (byte) 108, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void copySystemPropertiesToClipboard()
    {
      StringBuffer stringBuffer = new StringBuffer();
      ListSelectionModel selectionModel = this.table.getSelectionModel();
      int minSelectionIndex = selectionModel.getMinSelectionIndex();
      int maxSelectionIndex = selectionModel.getMaxSelectionIndex();
      if (minSelectionIndex != -1 && maxSelectionIndex != -1)
      {
        for (int index1 = minSelectionIndex; index1 <= maxSelectionIndex; ++index1)
        {
          for (int index2 = 0; index2 < this.table.getColumnCount(); ++index2)
          {
            stringBuffer.append(this.table.getValueAt(index1, index2));
            if (index2 != 2)
              stringBuffer.append("\t");
          }
          stringBuffer.append("\n");
        }
      }
      StringSelection.__\u003Cclinit\u003E();
      StringSelection stringSelection = new StringSelection(stringBuffer.toString());
      Toolkit.getDefaultToolkit().getSystemClipboard().setContents((Transferable) stringSelection, (ClipboardOwner) stringSelection);
    }

    protected internal JPopupMenu getCopyPopupMenu()
    {
      return this.copyPopupMenu;
    }

    protected internal JTable getTable()
    {
      return this.table;
    }

    [InnerClass]
    [SourceFile("SystemPropertiesPanel.java")]
    [Modifiers]
    internal sealed class PopupListener : MouseAdapter
    {
      [Modifiers]
      private SystemPropertiesPanel this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PopupListener([In] SystemPropertiesPanel obj0)
      {
        base.\u002Ector();
        SystemPropertiesPanel.PopupListener popupListener = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 104, (byte) 223, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void maybeShowPopup([In] MouseEvent obj0)
      {
        if (!obj0.isPopupTrigger())
          return;
        this.this\u00240.getCopyPopupMenu().show((Component) this.this\u00240.getTable(), obj0.getX(), obj0.getY());
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mousePressed([In] MouseEvent obj0)
      {
        this.maybeShowPopup(obj0);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseReleased([In] MouseEvent obj0)
      {
        this.maybeShowPopup(obj0);
      }
    }
  }
}
