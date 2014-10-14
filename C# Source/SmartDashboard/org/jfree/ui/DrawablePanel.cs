// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.DrawablePanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class DrawablePanel : JPanel
  {
    private Drawable drawable;

    [HideFromJava]
    static DrawablePanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawablePanel()
    {
      base.\u002Ector();
      DrawablePanel drawablePanel = this;
      ((JComponent) this).setOpaque(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DrawablePanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual Drawable getDrawable()
    {
      return this.drawable;
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 103, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawable(Drawable drawable)
    {
      this.drawable = drawable;
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 141, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension getPreferredSize()
    {
      if (this.drawable is ExtendedDrawable)
        return ((ExtendedDrawable) this.drawable).getPreferredSize();
      else
        return ((JComponent) this).getPreferredSize();
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 141, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension getMinimumSize()
    {
      if (this.drawable is ExtendedDrawable)
        return ((ExtendedDrawable) this.drawable).getPreferredSize();
      else
        return ((JComponent) this).getMinimumSize();
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 136, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isOpaque()
    {
      if (this.drawable == null)
        return false;
      return (((JComponent) this).isOpaque() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 103, (byte) 136, (byte) 161, (byte) 186, (byte) 127, (byte) 10, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void paintComponent(Graphics g)
    {
      ((JComponent) this).paintComponent(g);
      if (this.drawable == null)
        return;
      Graphics2D gd = (Graphics2D) g.create(0, 0, ((JComponent) this).getWidth(), ((JComponent) this).getHeight());
      this.drawable.draw(gd, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, (double) ((JComponent) this).getWidth(), (double) ((JComponent) this).getHeight()));
      ((Graphics) gd).dispose();
    }
  }
}
