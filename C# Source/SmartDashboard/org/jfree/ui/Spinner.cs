// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.Spinner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.MouseListener"})]
  [Serializable]
  public class Spinner : JPanel, MouseListener, EventListener
  {
    private int value;
    private JTextField textField;
    private JPanel buttonPanel;
    private ArrowPanel upButton;
    private ArrowPanel downButton;

    [HideFromJava]
    static Spinner()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 109, (byte) 103, (byte) 123, (byte) 108, (byte) 109, (byte) 121, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 114, (byte) 114, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Spinner(int value)
    {
      base.\u002Ector((LayoutManager) new BorderLayout());
      Spinner spinner = this;
      this.value = value;
      JTextField.__\u003Cclinit\u003E();
      this.textField = new JTextField(Integer.toString(this.value));
      this.textField.setHorizontalAlignment(4);
      ((Container) this).add((Component) this.textField);
      JPanel.__\u003Cclinit\u003E();
      this.buttonPanel = new JPanel((LayoutManager) new GridLayout(2, 1, 0, 1));
      this.upButton = new ArrowPanel(0);
      ((Component) this.upButton).addMouseListener((MouseListener) this);
      this.downButton = new ArrowPanel(1);
      ((Component) this.downButton).addMouseListener((MouseListener) this);
      ((Container) this.buttonPanel).add((Component) this.upButton);
      ((Container) this.buttonPanel).add((Component) this.downButton);
      ((Container) this).add((Component) this.buttonPanel, (object) "East");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Spinner([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual int getValue()
    {
      return this.value;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 110, (byte) 110, (byte) 118, (byte) 155, (byte) 110, (byte) 110, (byte) 118, (byte) 155})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseClicked(MouseEvent e)
    {
      if (((EventObject) e).getSource() == this.upButton)
      {
        ++this.value;
        ((JTextComponent) this.textField).setText(Integer.toString(this.value));
        ((JComponent) this).firePropertyChange("value", this.value - 1, this.value);
      }
      else
      {
        if (((EventObject) e).getSource() != this.downButton)
          return;
        --this.value;
        ((JTextComponent) this.textField).setText(Integer.toString(this.value));
        ((JComponent) this).firePropertyChange("value", this.value + 1, this.value);
      }
    }

    public virtual void mouseEntered(MouseEvent e)
    {
    }

    public virtual void mouseExited(MouseEvent e)
    {
    }

    public virtual void mousePressed(MouseEvent e)
    {
    }

    public virtual void mouseReleased(MouseEvent e)
    {
    }
  }
}
