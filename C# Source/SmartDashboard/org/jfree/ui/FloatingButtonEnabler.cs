// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FloatingButtonEnabler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.util;
using javax.swing;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  public sealed class FloatingButtonEnabler : MouseAdapter
  {
    private static FloatingButtonEnabler singleton;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private FloatingButtonEnabler()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FloatingButtonEnabler getInstance()
    {
      if (FloatingButtonEnabler.singleton == null)
        FloatingButtonEnabler.singleton = new FloatingButtonEnabler();
      return FloatingButtonEnabler.singleton;
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addButton(AbstractButton button)
    {
      ((Component) button).addMouseListener((MouseListener) this);
      button.setBorderPainted(false);
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeButton(AbstractButton button)
    {
      ((Component) button).addMouseListener((MouseListener) this);
      button.setBorderPainted(true);
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 109, (byte) 108, (byte) 104, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseEntered(MouseEvent e)
    {
      if (!(((EventObject) e).getSource() is AbstractButton))
        return;
      AbstractButton abstractButton = (AbstractButton) ((EventObject) e).getSource();
      if (!((Component) abstractButton).isEnabled())
        return;
      abstractButton.setBorderPainted(true);
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 109, (byte) 108, (byte) 103, (byte) 200, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseExited(MouseEvent e)
    {
      if (!(((EventObject) e).getSource() is AbstractButton))
        return;
      AbstractButton abstractButton = (AbstractButton) ((EventObject) e).getSource();
      abstractButton.setBorderPainted(false);
      if (((Component) abstractButton).getParent() == null)
        return;
      ((Component) ((Component) abstractButton).getParent()).repaint();
    }
  }
}
