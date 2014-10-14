// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.JTextObserver
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing.text;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.FocusListener"})]
  public sealed class JTextObserver : Object, FocusListener, EventListener
  {
    private static JTextObserver singleton;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JTextObserver()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JTextObserver getInstance()
    {
      if (JTextObserver.singleton == null)
        JTextObserver.singleton = new JTextObserver();
      return JTextObserver.singleton;
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 109, (byte) 108, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void focusGained(FocusEvent e)
    {
      if (!(((EventObject) e).getSource() is JTextComponent))
        return;
      ((JTextComponent) ((EventObject) e).getSource()).selectAll();
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 109, (byte) 108, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void focusLost(FocusEvent e)
    {
      if (!(((EventObject) e).getSource() is JTextComponent))
        return;
      ((JTextComponent) ((EventObject) e).getSource()).select(0, 0);
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 103, (byte) 138, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void addTextComponent(JTextComponent t)
    {
      if (JTextObserver.singleton == null)
        JTextObserver.singleton = new JTextObserver();
      ((Component) t).addFocusListener((FocusListener) JTextObserver.singleton);
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 103, (byte) 138, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void removeTextComponent(JTextComponent t)
    {
      if (JTextObserver.singleton == null)
        JTextObserver.singleton = new JTextObserver();
      ((Component) t).removeFocusListener((FocusListener) JTextObserver.singleton);
    }
  }
}
