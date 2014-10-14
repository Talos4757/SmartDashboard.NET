// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.OverlayLayout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.LayoutManager"})]
  public sealed class OverlayLayout : Object, LayoutManager
  {
    private bool ignoreInvisible;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 98, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverlayLayout(bool ignoreInvisible)
    {
      int num = ignoreInvisible ? 1 : 0;
      base.\u002Ector();
      OverlayLayout overlayLayout = this;
      this.ignoreInvisible = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverlayLayout()
    {
      base.\u002Ector();
    }

    public virtual void addLayoutComponent(string name, Component comp)
    {
    }

    public virtual void removeLayoutComponent(Component comp)
    {
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 109, (byte) 135, (byte) 103, (byte) 117, (byte) 150, (byte) 136, (byte) 106, (byte) 103, (byte) 116, (byte) 130, (byte) 246, (byte) 59, (byte) 232, (byte) 71, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        Rectangle local_2 = ((Component) parent).getBounds();
        int local_3 = (int) (local_2.width - local_1.left - local_1.right);
        int local_4 = (int) (local_2.height - local_1.top - local_1.bottom);
        Component[] local_5 = parent.getComponents();
        for (int local_6 = 0; local_6 < local_5.Length; ++local_6)
        {
          Component local_7 = local_5[local_6];
          if (local_5[local_6].isVisible() || !this.ignoreInvisible)
            local_7.setBounds((int) local_1.left, (int) local_1.top, local_3, local_4);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 109, (byte) 103, (byte) 103, (byte) 98, (byte) 99, (byte) 108, (byte) 115, (byte) 162, (byte) 107, (byte) 106, (byte) 136, (byte) 107, (byte) 233, (byte) 54, (byte) 235, (byte) 77, (byte) 159, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        Component[] local_2 = parent.getComponents();
        int local_3 = 0;
        int local_4 = 0;
        for (int local_5 = 0; local_5 < local_2.Length; ++local_5)
        {
          if (local_2[local_5].isVisible() || !this.ignoreInvisible)
          {
            Dimension local_6 = local_2[local_5].getMinimumSize();
            if (local_6.height > local_3)
              local_3 = (int) local_6.height;
            if (local_6.width > local_4)
              local_4 = (int) local_6.width;
          }
        }
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_4 + local_1.left + local_1.right, local_3 + local_1.top + local_1.bottom);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 109, (byte) 103, (byte) 103, (byte) 98, (byte) 99, (byte) 108, (byte) 115, (byte) 162, (byte) 107, (byte) 106, (byte) 136, (byte) 107, (byte) 233, (byte) 54, (byte) 235, (byte) 77, (byte) 159, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        Component[] local_2 = parent.getComponents();
        int local_3 = 0;
        int local_4 = 0;
        for (int local_5 = 0; local_5 < local_2.Length; ++local_5)
        {
          if (local_2[local_5].isVisible() || !this.ignoreInvisible)
          {
            Dimension local_6 = local_2[local_5].getPreferredSize();
            if (local_6.height > local_3)
              local_3 = (int) local_6.height;
            if (local_6.width > local_4)
              local_4 = (int) local_6.width;
          }
        }
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_4 + local_1.left + local_1.right, local_3 + local_1.top + local_1.bottom);
      }
      return dimension;
    }
  }
}
