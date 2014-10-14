// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.VerticalLayout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.tabbedui
{
  [Implements(new string[] {"java.awt.LayoutManager"})]
  public class VerticalLayout : Object, LayoutManager
  {
    [Modifiers]
    private bool useSizeFromParent;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 66, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VerticalLayout(bool useParent)
    {
      int num = useParent ? 1 : 0;
      base.\u002Ector();
      VerticalLayout verticalLayout = this;
      this.useSizeFromParent = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VerticalLayout()
      : this(true)
    {
    }

    public virtual bool isUseSizeFromParent()
    {
      return this.useSizeFromParent;
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 109, (byte) 103, (byte) 103, (byte) 110, (byte) 111, (byte) 105, (byte) 107, (byte) 130, (byte) 107, (byte) 106, (byte) 107, (byte) 233, (byte) 57, (byte) 232, (byte) 75, (byte) 159, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        Component[] local_2 = parent.getComponents();
        int local_3 = (int) (local_1.top + local_1.bottom);
        int local_4 = (int) (local_1.left + local_1.right);
        for (int local_5 = 0; local_5 < local_2.Length; ++local_5)
        {
          if (local_2[local_5].isVisible())
          {
            Dimension local_6 = local_2[local_5].getPreferredSize();
            local_3 += (int) local_6.height;
            if (local_6.width > local_4)
              local_4 = (int) local_6.width;
          }
        }
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_4 + local_1.left + local_1.right, local_3 + local_1.top + local_1.bottom);
      }
      return dimension;
    }

    public virtual void addLayoutComponent(string name, Component comp)
    {
    }

    public virtual void removeLayoutComponent(Component comp)
    {
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 109, (byte) 103, (byte) 103, (byte) 110, (byte) 111, (byte) 105, (byte) 107, (byte) 130, (byte) 107, (byte) 106, (byte) 107, (byte) 233, (byte) 57, (byte) 232, (byte) 74, (byte) 159, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        Component[] local_2 = parent.getComponents();
        int local_3 = (int) (local_1.top + local_1.bottom);
        int local_4 = (int) (local_1.left + local_1.right);
        for (int local_5 = 0; local_5 < local_2.Length; ++local_5)
        {
          if (local_2[local_5].isVisible())
          {
            Dimension local_6 = local_2[local_5].getMinimumSize();
            local_3 += (int) local_6.height;
            if (local_6.width > local_4)
              local_4 = (int) local_6.width;
          }
        }
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_4 + local_1.left + local_1.right, local_3 + local_1.top + local_1.bottom);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 109, (byte) 103, (byte) 174, (byte) 104, (byte) 103, (byte) 106, (byte) 130, (byte) 144, (byte) 136, (byte) 104, (byte) 106, (byte) 103, (byte) 105, (byte) 130, (byte) 105, (byte) 120, (byte) 236, (byte) 57, (byte) 232, (byte) 73, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_2 = (int) (local_1.left + local_1.right);
        int local_4 = !this.isUseSizeFromParent() ? this.preferredLayoutSize(parent).width - local_2 : ((Component) parent).getBounds().width - local_2;
        Component[] local_5 = parent.getComponents();
        int local_6 = (int) local_1.top;
        for (int local_7 = 0; local_7 < local_5.Length; ++local_7)
        {
          Component local_8 = local_5[local_7];
          if (local_8.isVisible())
          {
            Dimension local_9 = local_8.getPreferredSize();
            local_8.setBounds((int) local_1.left, local_6, local_4, (int) local_9.height);
            local_6 += (int) local_9.height;
          }
        }
      }
    }
  }
}
