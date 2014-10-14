// Decompiled with JetBrains decompiler
// Type: org.jfree.layout.LCBLayout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.layout
{
  [Implements(new string[] {"java.awt.LayoutManager", "java.io.Serializable"})]
  [Serializable]
  public class LCBLayout : Object, LayoutManager, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2531780832406163833L;
    private const int COLUMNS = 3;
    private int[] colWidth;
    private int[] rowHeight;
    private int labelGap;
    private int buttonGap;
    private int vGap;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 104, (byte) 103, (byte) 103, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LCBLayout(int maxrows)
    {
      base.\u002Ector();
      LCBLayout lcbLayout = this;
      this.labelGap = 10;
      this.buttonGap = 6;
      this.vGap = 2;
      this.colWidth = new int[3];
      this.rowHeight = new int[maxrows];
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LCBLayout([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LCBLayout obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 109, (byte) 103, (byte) 103, (byte) 100, (byte) 107, (byte) 107, (byte) 143, (byte) 105, (byte) 114, (byte) 144, (byte) 114, (byte) 240, (byte) 56, (byte) 43, (byte) 235, (byte) 77, (byte) 108, (byte) 104, (byte) 46, (byte) 168, (byte) 159, (byte) 11, (byte) 255, (byte) 40, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_3 = parent.getComponentCount() / 3;
        for (int local_4 = 0; local_4 < 3; ++local_4)
        {
          for (int local_5 = 0; local_5 < local_3; ++local_5)
          {
            Dimension local_7 = parent.getComponent(local_5 * 3 + local_4).getPreferredSize();
            if (this.colWidth[local_4] < local_7.width)
              this.colWidth[local_4] = (int) local_7.width;
            if (this.rowHeight[local_5] < local_7.height)
              this.rowHeight[local_5] = (int) local_7.height;
          }
        }
        int local_4_1 = this.vGap * (local_3 - 1);
        for (int local_5_1 = 0; local_5_1 < local_3; ++local_5_1)
          local_4_1 += this.rowHeight[local_5_1];
        int local_5_2 = this.colWidth[0] + this.labelGap + this.colWidth[1] + this.buttonGap + this.colWidth[2];
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_1.left + local_1.right + local_5_2 + this.labelGap + this.buttonGap, local_1.top + local_1.bottom + local_4_1 + this.vGap);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 109, (byte) 103, (byte) 103, (byte) 100, (byte) 107, (byte) 107, (byte) 143, (byte) 105, (byte) 114, (byte) 144, (byte) 114, (byte) 240, (byte) 56, (byte) 43, (byte) 235, (byte) 77, (byte) 108, (byte) 104, (byte) 46, (byte) 168, (byte) 159, (byte) 11, (byte) 255, (byte) 40, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_3 = parent.getComponentCount() / 3;
        for (int local_4 = 0; local_4 < 3; ++local_4)
        {
          for (int local_5 = 0; local_5 < local_3; ++local_5)
          {
            Dimension local_7 = parent.getComponent(local_5 * 3 + local_4).getMinimumSize();
            if (this.colWidth[local_4] < local_7.width)
              this.colWidth[local_4] = (int) local_7.width;
            if (this.rowHeight[local_5] < local_7.height)
              this.rowHeight[local_5] = (int) local_7.height;
          }
        }
        int local_4_1 = this.vGap * (local_3 - 1);
        for (int local_5_1 = 0; local_5_1 < local_3; ++local_5_1)
          local_4_1 += this.rowHeight[local_5_1];
        int local_5_2 = this.colWidth[0] + this.labelGap + this.colWidth[1] + this.buttonGap + this.colWidth[2];
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(local_1.left + local_1.right + local_5_2 + this.labelGap + this.buttonGap, local_1.top + local_1.bottom + local_4_1 + this.vGap);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 109, (byte) 103, (byte) 103, (byte) 100, (byte) 107, (byte) 107, (byte) 143, (byte) 105, (byte) 114, (byte) 144, (byte) 114, (byte) 240, (byte) 56, (byte) 43, (byte) 235, (byte) 77, (byte) 108, (byte) 104, (byte) 46, (byte) 168, (byte) 220, (byte) 159, (byte) 5, (byte) 182, (byte) 104, (byte) 107, (byte) 104, (byte) 107, (byte) 105, (byte) 101, (byte) 106, (byte) 105, (byte) 105, (byte) 112, (byte) 191, (byte) 0, (byte) 245, (byte) 54, (byte) 235, (byte) 76, (byte) 110, (byte) 100, (byte) 139, (byte) 101, (byte) 235, (byte) 45, (byte) 235, (byte) 87, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_2 = parent.getComponentCount();
        int local_3 = local_2 / 3;
        for (int local_4 = 0; local_4 < 3; ++local_4)
        {
          for (int local_5 = 0; local_5 < local_3; ++local_5)
          {
            Dimension local_7 = parent.getComponent(local_5 * 3 + local_4).getPreferredSize();
            if (this.colWidth[local_4] < local_7.width)
              this.colWidth[local_4] = (int) local_7.width;
            if (this.rowHeight[local_5] < local_7.height)
              this.rowHeight[local_5] = (int) local_7.height;
          }
        }
        int local_4_1 = this.vGap * (local_3 - 1);
        for (int local_5_1 = 0; local_5_1 < local_3; ++local_5_1)
          local_4_1 += this.rowHeight[local_5_1];
        int local_5_2 = this.colWidth[0] + this.colWidth[1] + this.colWidth[2];
        this.colWidth[1] = this.colWidth[1] + (((Component) parent).getWidth() - local_1.left - local_1.right - this.labelGap - this.buttonGap - local_5_2);
        int local_9 = (int) local_1.left;
        for (int local_10 = 0; local_10 < 3; ++local_10)
        {
          int local_11 = (int) local_1.top;
          for (int local_12 = 0; local_12 < local_3; ++local_12)
          {
            int local_13 = local_12 * 3 + local_10;
            if (local_13 < local_2)
            {
              int local_16 = (int) parent.getComponent(local_13).getPreferredSize().height;
              int local_17 = (this.rowHeight[local_12] - local_16) / 2;
              parent.getComponent(local_13).setBounds(local_9, local_11 + local_17, this.colWidth[local_10], local_16);
            }
            local_11 = local_11 + this.rowHeight[local_12] + this.vGap;
          }
          local_9 += this.colWidth[local_10];
          if (local_10 == 0)
            local_9 += this.labelGap;
          if (local_10 == 1)
            local_9 += this.buttonGap;
        }
      }
    }

    public virtual void addLayoutComponent(Component comp)
    {
    }

    public virtual void removeLayoutComponent(Component comp)
    {
    }

    public virtual void addLayoutComponent(string name, Component comp)
    {
    }

    public virtual void removeLayoutComponent(string name, Component comp)
    {
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
