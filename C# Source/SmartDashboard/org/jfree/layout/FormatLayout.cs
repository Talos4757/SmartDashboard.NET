// Decompiled with JetBrains decompiler
// Type: org.jfree.layout.FormatLayout
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
  public class FormatLayout : Object, LayoutManager, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2866692886323930722L;
    public const int C = 1;
    public const int LC = 2;
    public const int LCB = 3;
    public const int LCLC = 4;
    public const int LCLCB = 5;
    public const int LCBLC = 6;
    public const int LCBLCB = 7;
    private int[] rowFormats;
    private int rowGap;
    private int[] columnGaps;
    private int[] rowHeights;
    private int totalHeight;
    private int[] columnWidths;
    private int totalWidth;
    private int columns1and2Width;
    private int columns4and5Width;
    private int columns1to4Width;
    private int columns1to5Width;
    private int columns0to5Width;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 136, (byte) 103, (byte) 103, (byte) 108, (byte) 106, (byte) 105, (byte) 105, (byte) 106, (byte) 169, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FormatLayout(int rowCount, int[] rowFormats)
    {
      base.\u002Ector();
      FormatLayout formatLayout = this;
      this.rowFormats = rowFormats;
      this.rowGap = 2;
      this.columnGaps = new int[5];
      this.columnGaps[0] = 10;
      this.columnGaps[1] = 5;
      this.columnGaps[2] = 5;
      this.columnGaps[3] = 10;
      this.columnGaps[4] = 5;
      this.rowHeights = new int[rowCount];
      this.columnWidths = new int[6];
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FormatLayout([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FormatLayout obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 147, (byte) 110, (byte) 117, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateC(int rowIndex, Dimension d0)
    {
      this.rowHeights[rowIndex] = (int) d0.height;
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columns0to5Width = Math.max(this.columns0to5Width, (int) d0.width);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 162, (byte) 121, (byte) 117, (byte) 123, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLC(int rowIndex, Dimension d0, Dimension d1)
    {
      this.rowHeights[rowIndex] = Math.max((int) d0.height, (int) d1.height);
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columns1to5Width = Math.max(this.columns1to5Width, (int) d1.width);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 181, (byte) 159, (byte) 6, (byte) 117, (byte) 123, (byte) 119, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLCB(int rowIndex, Dimension d0, Dimension d1, Dimension d2)
    {
      this.rowHeights[rowIndex] = Math.max((int) d0.height, Math.max((int) d1.height, (int) d2.height));
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columns1to4Width = Math.max(this.columns1to4Width, (int) d1.width);
      this.columnWidths[5] = Math.max(this.columnWidths[5], (int) d2.width);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 203, (byte) 159, (byte) 18, (byte) 117, (byte) 123, (byte) 119, (byte) 124, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLCLC(int rowIndex, Dimension d0, Dimension d1, Dimension d2, Dimension d3)
    {
      this.rowHeights[rowIndex] = Math.max(Math.max((int) d0.height, (int) d1.height), Math.max((int) d2.height, (int) d3.height));
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columns1and2Width = Math.max(this.columns1and2Width, (int) d1.width);
      this.columnWidths[3] = Math.max(this.columnWidths[3], (int) d2.width);
      this.columns4and5Width = Math.max(this.columns4and5Width, (int) d3.width);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 226, (byte) 255, (byte) 30, (byte) 69, (byte) 117, (byte) 123, (byte) 123, (byte) 124, (byte) 124, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLCBLC(int rowIndex, Dimension d0, Dimension d1, Dimension d2, Dimension d3, Dimension d4)
    {
      this.rowHeights[rowIndex] = Math.max((int) d0.height, Math.max(Math.max((int) d1.height, (int) d2.height), Math.max((int) d3.height, (int) d4.height)));
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columnWidths[1] = Math.max(this.columnWidths[1], (int) d1.width);
      this.columnWidths[2] = Math.max(this.columnWidths[2], (int) d2.width);
      this.columnWidths[3] = Math.max(this.columnWidths[3], (int) d3.width);
      this.columns4and5Width = Math.max(this.columns4and5Width, (int) d4.width);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 254, (byte) 191, (byte) 30, (byte) 117, (byte) 123, (byte) 119, (byte) 124, (byte) 124, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLCLCB(int rowIndex, Dimension d0, Dimension d1, Dimension d2, Dimension d3, Dimension d4)
    {
      this.rowHeights[rowIndex] = Math.max((int) d0.height, Math.max(Math.max((int) d1.height, (int) d2.height), Math.max((int) d3.height, (int) d4.height)));
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columns1and2Width = Math.max(this.columns1and2Width, (int) d1.width);
      this.columnWidths[3] = Math.max(this.columnWidths[3], (int) d2.width);
      this.columnWidths[4] = Math.max(this.columnWidths[4], (int) d3.width);
      this.columnWidths[5] = Math.max(this.columnWidths[5], (int) d4.width);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 27, (byte) 255, (byte) 42, (byte) 69, (byte) 117, (byte) 123, (byte) 123, (byte) 124, (byte) 124, (byte) 124, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateLCBLCB(int rowIndex, Dimension d0, Dimension d1, Dimension d2, Dimension d3, Dimension d4, Dimension d5)
    {
      this.rowHeights[rowIndex] = Math.max(Math.max((int) d0.height, (int) d1.height), Math.max(Math.max((int) d2.height, (int) d3.height), Math.max((int) d4.height, (int) d5.height)));
      this.totalHeight = this.totalHeight + this.rowHeights[rowIndex];
      this.columnWidths[0] = Math.max(this.columnWidths[0], (int) d0.width);
      this.columnWidths[1] = Math.max(this.columnWidths[1], (int) d1.width);
      this.columnWidths[2] = Math.max(this.columnWidths[2], (int) d2.width);
      this.columnWidths[3] = Math.max(this.columnWidths[3], (int) d3.width);
      this.columnWidths[4] = Math.max(this.columnWidths[4], (int) d4.width);
      this.columnWidths[5] = Math.max(this.columnWidths[5], (int) d5.width);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 47, (byte) 255, (byte) 14, (byte) 69, (byte) 255, (byte) 160, (byte) 89, (byte) 82, (byte) 223, (byte) 14, (byte) 223, (byte) 14, (byte) 104, (byte) 100, (byte) 100, (byte) 114, (byte) 100, (byte) 130, (byte) 100, (byte) 114, (byte) 196, (byte) 146, (byte) 113, (byte) 110, (byte) 104, (byte) 100, (byte) 114, (byte) 148, (byte) 110, (byte) 130, (byte) 114, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void complete()
    {
      this.columnWidths[1] = Math.max(this.columnWidths[1], this.columns1and2Width - this.columnGaps[1] - this.columnWidths[2]);
      this.columnWidths[4] = Math.max(this.columnWidths[4], Math.max(this.columns4and5Width - this.columnGaps[4] - this.columnWidths[5], Math.max(this.columns1to4Width - this.columnGaps[1] - this.columnGaps[2] - this.columnGaps[3] - this.columnWidths[1] - this.columnWidths[2] - this.columnWidths[3], this.columns1to5Width - this.columnGaps[1] - this.columnGaps[2] - this.columnGaps[3] - this.columnWidths[1] - this.columnWidths[2] - this.columnWidths[3] - this.columnGaps[4])));
      int num1 = this.columnWidths[0] + this.columnGaps[0] + this.columnWidths[1] + this.columnGaps[1] + this.columnWidths[2];
      int num2 = this.columnWidths[3] + this.columnGaps[3] + this.columnWidths[4] + this.columnGaps[4] + this.columnWidths[5];
      if (this.splitLayout())
      {
        if (num1 > num2)
        {
          int num3 = num1 - num2;
          this.columnWidths[4] = this.columnWidths[4] + num3;
          num2 += num3;
        }
        else
        {
          int num3 = num2 - num1;
          this.columnWidths[1] = this.columnWidths[1] + num3;
          num1 += num3;
        }
      }
      this.totalWidth = num1 + this.columnGaps[2] + num2;
      if (this.columns0to5Width <= this.totalWidth)
        return;
      int num4 = this.columns0to5Width - this.totalWidth;
      if (this.splitLayout())
      {
        int num3 = num4 / 2;
        this.columnWidths[1] = this.columnWidths[1] + num3;
        this.columnWidths[4] = this.columnWidths[4] + num4 - num3;
        this.totalWidth = this.totalWidth + num4;
      }
      else
      {
        this.columnWidths[1] = this.columnWidths[1] + num4;
        this.totalWidth = this.totalWidth + num4;
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 117, (byte) 108, (byte) 107, (byte) 2, (byte) 230, (byte) 69})]
    private bool splitLayout()
    {
      for (int index = 0; index < this.rowFormats.Length; ++index)
      {
        if (this.rowFormats[index] > 3)
          return true;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 109, (byte) 103, (byte) 98, (byte) 104, (byte) 110, (byte) 42, (byte) 168, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 135, (byte) 103, (byte) 107, (byte) 156, (byte) 159, (byte) 11, (byte) 105, (byte) 111, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 150, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 221, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 5, (byte) 69, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 19, (byte) 71, (byte) 228, (byte) 159, (byte) 176, (byte) 235, (byte) 160, (byte) 84, (byte) 102, (byte) 191, (byte) 38})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_2 = 0;
        int local_3 = this.rowHeights.Length;
        for (int local_4 = 0; local_4 < this.columnWidths.Length; ++local_4)
          this.columnWidths[local_4] = 0;
        this.columns1and2Width = 0;
        this.columns4and5Width = 0;
        this.columns1to4Width = 0;
        this.columns1to5Width = 0;
        this.columns0to5Width = 0;
        this.totalHeight = 0;
        for (int local_4_1 = 0; local_4_1 < local_3; ++local_4_1)
        {
          int[] temp_56 = this.rowFormats;
          int temp_57 = local_4_1;
          int temp_60 = this.rowFormats.Length;
          int temp_61 = -1;
          int temp_62 = temp_60 != temp_61 ? temp_57 % temp_60 : 0;
          switch (temp_56[temp_62])
          {
            case 1:
              Component local_6 = parent.getComponent(local_2);
              this.updateC(local_4_1, local_6.getPreferredSize());
              ++local_2;
              break;
            case 2:
              Component local_6_1 = parent.getComponent(local_2);
              Component local_7 = parent.getComponent(local_2 + 1);
              this.updateLC(local_4_1, local_6_1.getPreferredSize(), local_7.getPreferredSize());
              local_2 += 2;
              break;
            case 3:
              Component local_6_2 = parent.getComponent(local_2);
              Component local_7_1 = parent.getComponent(local_2 + 1);
              Component local_8 = parent.getComponent(local_2 + 2);
              this.updateLCB(local_4_1, local_6_2.getPreferredSize(), local_7_1.getPreferredSize(), local_8.getPreferredSize());
              local_2 += 3;
              break;
            case 4:
              Component local_6_3 = parent.getComponent(local_2);
              Component local_7_2 = parent.getComponent(local_2 + 1);
              Component local_8_1 = parent.getComponent(local_2 + 2);
              Component local_9 = parent.getComponent(local_2 + 3);
              this.updateLCLC(local_4_1, local_6_3.getPreferredSize(), local_7_2.getPreferredSize(), local_8_1.getPreferredSize(), local_9.getPreferredSize());
              local_2 += 4;
              break;
            case 5:
              Component local_6_5 = parent.getComponent(local_2);
              Component local_7_4 = parent.getComponent(local_2 + 1);
              Component local_8_3 = parent.getComponent(local_2 + 2);
              Component local_9_2 = parent.getComponent(local_2 + 3);
              Component local_10_1 = parent.getComponent(local_2 + 4);
              this.updateLCLCB(local_4_1, local_6_5.getPreferredSize(), local_7_4.getPreferredSize(), local_8_3.getPreferredSize(), local_9_2.getPreferredSize(), local_10_1.getPreferredSize());
              local_2 += 5;
              break;
            case 6:
              Component local_6_4 = parent.getComponent(local_2);
              Component local_7_3 = parent.getComponent(local_2 + 1);
              Component local_8_2 = parent.getComponent(local_2 + 2);
              Component local_9_1 = parent.getComponent(local_2 + 3);
              Component local_10 = parent.getComponent(local_2 + 4);
              this.updateLCBLC(local_4_1, local_6_4.getPreferredSize(), local_7_3.getPreferredSize(), local_8_2.getPreferredSize(), local_9_1.getPreferredSize(), local_10.getPreferredSize());
              local_2 += 5;
              break;
            case 7:
              Component local_6_6 = parent.getComponent(local_2);
              Component local_7_5 = parent.getComponent(local_2 + 1);
              Component local_8_4 = parent.getComponent(local_2 + 2);
              Component local_9_3 = parent.getComponent(local_2 + 3);
              Component local_10_2 = parent.getComponent(local_2 + 4);
              Component local_11 = parent.getComponent(local_2 + 5);
              this.updateLCBLCB(local_4_1, local_6_6.getPreferredSize(), local_7_5.getPreferredSize(), local_8_4.getPreferredSize(), local_9_3.getPreferredSize(), local_10_2.getPreferredSize(), local_11.getPreferredSize());
              local_2 += 6;
              break;
          }
        }
        this.complete();
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(this.totalWidth + local_1.left + local_1.right, this.totalHeight + (local_3 - 1) * this.rowGap + local_1.top + local_1.bottom);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 207, (byte) 109, (byte) 103, (byte) 98, (byte) 104, (byte) 110, (byte) 42, (byte) 168, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 98, (byte) 139, (byte) 188, (byte) 159, (byte) 11, (byte) 105, (byte) 189, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 182, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 221, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 5, (byte) 69, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 19, (byte) 71, (byte) 228, (byte) 159, (byte) 171, (byte) 235, (byte) 160, (byte) 89, (byte) 102, (byte) 191, (byte) 33})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      Dimension dimension;
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_2 = 0;
        int local_3 = this.rowHeights.Length;
        for (int local_4 = 0; local_4 < this.columnWidths.Length; ++local_4)
          this.columnWidths[local_4] = 0;
        this.columns1and2Width = 0;
        this.columns4and5Width = 0;
        this.columns1to4Width = 0;
        this.columns1to5Width = 0;
        this.columns0to5Width = 0;
        for (int local_5 = 0; local_5 < local_3; ++local_5)
        {
          int[] temp_54 = this.rowFormats;
          int temp_55 = local_5;
          int temp_58 = this.rowFormats.Length;
          int temp_59 = -1;
          int temp_60 = temp_58 != temp_59 ? temp_55 % temp_58 : 0;
          switch (temp_54[temp_60])
          {
            case 1:
              this.columns0to5Width = Math.max(this.columns0to5Width, (int) parent.getComponent(local_2).getMinimumSize().width);
              ++local_2;
              break;
            case 2:
              Component local_7_1 = parent.getComponent(local_2);
              Component local_8 = parent.getComponent(local_2 + 1);
              this.updateLC(local_5, local_7_1.getMinimumSize(), local_8.getMinimumSize());
              local_2 += 2;
              break;
            case 3:
              Component local_7_2 = parent.getComponent(local_2);
              Component local_8_1 = parent.getComponent(local_2 + 1);
              Component local_9 = parent.getComponent(local_2 + 2);
              this.updateLCB(local_5, local_7_2.getMinimumSize(), local_8_1.getMinimumSize(), local_9.getMinimumSize());
              local_2 += 3;
              break;
            case 4:
              Component local_7_3 = parent.getComponent(local_2);
              Component local_8_2 = parent.getComponent(local_2 + 1);
              Component local_9_1 = parent.getComponent(local_2 + 2);
              Component local_10 = parent.getComponent(local_2 + 3);
              this.updateLCLC(local_5, local_7_3.getMinimumSize(), local_8_2.getMinimumSize(), local_9_1.getMinimumSize(), local_10.getMinimumSize());
              local_2 += 3;
              break;
            case 5:
              Component local_7_5 = parent.getComponent(local_2);
              Component local_8_4 = parent.getComponent(local_2 + 1);
              Component local_9_3 = parent.getComponent(local_2 + 2);
              Component local_10_2 = parent.getComponent(local_2 + 3);
              Component local_11_1 = parent.getComponent(local_2 + 4);
              this.updateLCLCB(local_5, local_7_5.getMinimumSize(), local_8_4.getMinimumSize(), local_9_3.getMinimumSize(), local_10_2.getMinimumSize(), local_11_1.getMinimumSize());
              local_2 += 4;
              break;
            case 6:
              Component local_7_4 = parent.getComponent(local_2);
              Component local_8_3 = parent.getComponent(local_2 + 1);
              Component local_9_2 = parent.getComponent(local_2 + 2);
              Component local_10_1 = parent.getComponent(local_2 + 3);
              Component local_11 = parent.getComponent(local_2 + 4);
              this.updateLCBLC(local_5, local_7_4.getMinimumSize(), local_8_3.getMinimumSize(), local_9_2.getMinimumSize(), local_10_1.getMinimumSize(), local_11.getMinimumSize());
              local_2 += 4;
              break;
            case 7:
              Component local_7_6 = parent.getComponent(local_2);
              Component local_8_5 = parent.getComponent(local_2 + 1);
              Component local_9_4 = parent.getComponent(local_2 + 2);
              Component local_10_3 = parent.getComponent(local_2 + 3);
              Component local_11_2 = parent.getComponent(local_2 + 4);
              Component local_12 = parent.getComponent(local_2 + 5);
              this.updateLCBLCB(local_5, local_7_6.getMinimumSize(), local_8_5.getMinimumSize(), local_9_4.getMinimumSize(), local_10_3.getMinimumSize(), local_11_2.getMinimumSize(), local_12.getMinimumSize());
              local_2 += 5;
              break;
          }
        }
        this.complete();
        Dimension.__\u003Cclinit\u003E();
        dimension = new Dimension(this.totalWidth + local_1.left + local_1.right, 0 + (local_3 - 1) * this.rowGap + local_1.top + local_1.bottom);
      }
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 68, (byte) 109, (byte) 103, (byte) 98, (byte) 104, (byte) 110, (byte) 42, (byte) 168, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 191, (byte) 0, (byte) 103, (byte) 107, (byte) 156, (byte) 159, (byte) 11, (byte) 105, (byte) 111, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 150, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 221, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 5, (byte) 69, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 12, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 255, (byte) 19, (byte) 71, (byte) 228, (byte) 159, (byte) 176, (byte) 235, (byte) 160, (byte) 84, (byte) 134, (byte) 98, (byte) 104, (byte) 104, (byte) 106, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 156, (byte) 156, (byte) 159, (byte) 9, (byte) 118, (byte) 118, (byte) 107, (byte) 188, (byte) 159, (byte) 11, (byte) 105, (byte) 155, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 21, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 100, (byte) 133, (byte) 105, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 107, (byte) 255, (byte) 27, (byte) 70, (byte) 164, (byte) 245, (byte) 159, (byte) 51, (byte) 235, (byte) 160, (byte) 207, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      lock (((Component) parent).getTreeLock())
      {
        Insets local_1 = parent.getInsets();
        int local_2 = 0;
        int local_3 = this.rowHeights.Length;
        for (int local_4 = 0; local_4 < this.columnWidths.Length; ++local_4)
          this.columnWidths[local_4] = 0;
        this.columns1and2Width = 0;
        this.columns4and5Width = 0;
        this.columns1to4Width = 0;
        this.columns1to5Width = 0;
        this.columns0to5Width = (int) (((Component) parent).getBounds().width - local_1.left - local_1.right);
        this.totalHeight = 0;
        for (int local_4_1 = 0; local_4_1 < local_3; ++local_4_1)
        {
          int[] temp_925 = this.rowFormats;
          int temp_926 = local_4_1;
          int temp_929 = this.rowFormats.Length;
          int temp_930 = -1;
          int temp_931 = temp_929 != temp_930 ? temp_926 % temp_929 : 0;
          switch (temp_925[temp_931])
          {
            case 1:
              Component local_6 = parent.getComponent(local_2);
              this.updateC(local_4_1, local_6.getPreferredSize());
              ++local_2;
              break;
            case 2:
              Component local_6_1 = parent.getComponent(local_2);
              Component local_7 = parent.getComponent(local_2 + 1);
              this.updateLC(local_4_1, local_6_1.getPreferredSize(), local_7.getPreferredSize());
              local_2 += 2;
              break;
            case 3:
              Component local_6_2 = parent.getComponent(local_2);
              Component local_7_1 = parent.getComponent(local_2 + 1);
              Component local_8 = parent.getComponent(local_2 + 2);
              this.updateLCB(local_4_1, local_6_2.getPreferredSize(), local_7_1.getPreferredSize(), local_8.getPreferredSize());
              local_2 += 3;
              break;
            case 4:
              Component local_6_3 = parent.getComponent(local_2);
              Component local_7_2 = parent.getComponent(local_2 + 1);
              Component local_8_1 = parent.getComponent(local_2 + 2);
              Component local_9 = parent.getComponent(local_2 + 3);
              this.updateLCLC(local_4_1, local_6_3.getPreferredSize(), local_7_2.getPreferredSize(), local_8_1.getPreferredSize(), local_9.getPreferredSize());
              local_2 += 4;
              break;
            case 5:
              Component local_6_5 = parent.getComponent(local_2);
              Component local_7_4 = parent.getComponent(local_2 + 1);
              Component local_8_3 = parent.getComponent(local_2 + 2);
              Component local_9_2 = parent.getComponent(local_2 + 3);
              Component local_10_1 = parent.getComponent(local_2 + 4);
              this.updateLCLCB(local_4_1, local_6_5.getPreferredSize(), local_7_4.getPreferredSize(), local_8_3.getPreferredSize(), local_9_2.getPreferredSize(), local_10_1.getPreferredSize());
              local_2 += 5;
              break;
            case 6:
              Component local_6_4 = parent.getComponent(local_2);
              Component local_7_3 = parent.getComponent(local_2 + 1);
              Component local_8_2 = parent.getComponent(local_2 + 2);
              Component local_9_1 = parent.getComponent(local_2 + 3);
              Component local_10 = parent.getComponent(local_2 + 4);
              this.updateLCBLC(local_4_1, local_6_4.getPreferredSize(), local_7_3.getPreferredSize(), local_8_2.getPreferredSize(), local_9_1.getPreferredSize(), local_10.getPreferredSize());
              local_2 += 5;
              break;
            case 7:
              Component local_6_6 = parent.getComponent(local_2);
              Component local_7_5 = parent.getComponent(local_2 + 1);
              Component local_8_4 = parent.getComponent(local_2 + 2);
              Component local_9_3 = parent.getComponent(local_2 + 3);
              Component local_10_2 = parent.getComponent(local_2 + 4);
              Component local_11 = parent.getComponent(local_2 + 5);
              this.updateLCBLCB(local_4_1, local_6_6.getPreferredSize(), local_7_5.getPreferredSize(), local_8_4.getPreferredSize(), local_9_3.getPreferredSize(), local_10_2.getPreferredSize(), local_11.getPreferredSize());
              local_2 += 6;
              break;
          }
        }
        this.complete();
        int local_2_1 = 0;
        int local_4_2 = (int) local_1.top;
        int[] local_12 = new int[6];
        local_12[0] = (int) local_1.left;
        local_12[1] = local_12[0] + this.columnWidths[0] + this.columnGaps[0];
        local_12[2] = local_12[1] + this.columnWidths[1] + this.columnGaps[1];
        local_12[3] = local_12[2] + this.columnWidths[2] + this.columnGaps[2];
        local_12[4] = local_12[3] + this.columnWidths[3] + this.columnGaps[3];
        local_12[5] = local_12[4] + this.columnWidths[4] + this.columnGaps[4];
        int local_13 = this.columnWidths[1] + this.columnGaps[1] + this.columnWidths[2];
        int local_14 = this.columnWidths[4] + this.columnGaps[4] + this.columnWidths[5];
        int local_15 = local_13 + this.columnGaps[2] + this.columnWidths[3] + this.columnGaps[3] + this.columnWidths[4];
        int local_16 = local_15 + this.columnGaps[4] + this.columnWidths[5];
        int local_17 = local_16 + this.columnWidths[0] + this.columnGaps[0];
        for (int local_18 = 0; local_18 < local_3; ++local_18)
        {
          int[] temp_197 = this.rowFormats;
          int temp_198 = local_18;
          int temp_201 = this.rowFormats.Length;
          int temp_202 = -1;
          int temp_203 = temp_201 != temp_202 ? temp_198 % temp_201 : 0;
          switch (temp_197[temp_203])
          {
            case 1:
              Component local_6_7 = parent.getComponent(local_2_1);
              local_6_7.setBounds(local_12[0], local_4_2, local_17, (int) local_6_7.getPreferredSize().height);
              ++local_2_1;
              break;
            case 2:
              Component local_6_8 = parent.getComponent(local_2_1);
              local_6_8.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_8.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_8.getPreferredSize().height);
              Component local_7_6 = parent.getComponent(local_2_1 + 1);
              local_7_6.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_6.getPreferredSize().height) / 2, local_16, (int) local_7_6.getPreferredSize().height);
              local_2_1 += 2;
              break;
            case 3:
              Component local_6_9 = parent.getComponent(local_2_1);
              local_6_9.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_9.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_9.getPreferredSize().height);
              Component local_7_7 = parent.getComponent(local_2_1 + 1);
              local_7_7.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_7.getPreferredSize().height) / 2, local_15, (int) local_7_7.getPreferredSize().height);
              Component local_8_5 = parent.getComponent(local_2_1 + 2);
              local_8_5.setBounds(local_12[5], local_4_2 + (this.rowHeights[local_18] - local_8_5.getPreferredSize().height) / 2, this.columnWidths[5], (int) local_8_5.getPreferredSize().height);
              local_2_1 += 3;
              break;
            case 4:
              Component local_6_10 = parent.getComponent(local_2_1);
              local_6_10.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_10.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_10.getPreferredSize().height);
              Component local_7_8 = parent.getComponent(local_2_1 + 1);
              local_7_8.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_8.getPreferredSize().height) / 2, local_13, (int) local_7_8.getPreferredSize().height);
              Component local_8_6 = parent.getComponent(local_2_1 + 2);
              local_8_6.setBounds(local_12[3], local_4_2 + (this.rowHeights[local_18] - local_8_6.getPreferredSize().height) / 2, this.columnWidths[3], (int) local_8_6.getPreferredSize().height);
              Component local_9_4 = parent.getComponent(local_2_1 + 3);
              local_9_4.setBounds(local_12[4], local_4_2 + (this.rowHeights[local_18] - local_9_4.getPreferredSize().height) / 2, local_14, (int) local_9_4.getPreferredSize().height);
              local_2_1 += 4;
              break;
            case 5:
              Component local_6_12 = parent.getComponent(local_2_1);
              local_6_12.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_12.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_12.getPreferredSize().height);
              Component local_7_10 = parent.getComponent(local_2_1 + 1);
              local_7_10.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_10.getPreferredSize().height) / 2, local_13, (int) local_7_10.getPreferredSize().height);
              Component local_8_8 = parent.getComponent(local_2_1 + 2);
              local_8_8.setBounds(local_12[3], local_4_2 + (this.rowHeights[local_18] - local_8_8.getPreferredSize().height) / 2, this.columnWidths[3], (int) local_8_8.getPreferredSize().height);
              Component local_9_6 = parent.getComponent(local_2_1 + 3);
              local_9_6.setBounds(local_12[4], local_4_2 + (this.rowHeights[local_18] - local_9_6.getPreferredSize().height) / 2, this.columnWidths[4], (int) local_9_6.getPreferredSize().height);
              Component local_10_4 = parent.getComponent(local_2_1 + 4);
              local_10_4.setBounds(local_12[5], local_4_2 + (this.rowHeights[local_18] - local_10_4.getPreferredSize().height) / 2, this.columnWidths[5], (int) local_10_4.getPreferredSize().height);
              local_2_1 += 5;
              break;
            case 6:
              Component local_6_11 = parent.getComponent(local_2_1);
              local_6_11.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_11.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_11.getPreferredSize().height);
              Component local_7_9 = parent.getComponent(local_2_1 + 1);
              local_7_9.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_9.getPreferredSize().height) / 2, this.columnWidths[1], (int) local_7_9.getPreferredSize().height);
              Component local_8_7 = parent.getComponent(local_2_1 + 2);
              local_8_7.setBounds(local_12[2], local_4_2 + (this.rowHeights[local_18] - local_8_7.getPreferredSize().height) / 2, this.columnWidths[2], (int) local_8_7.getPreferredSize().height);
              Component local_9_5 = parent.getComponent(local_2_1 + 3);
              local_9_5.setBounds(local_12[3], local_4_2 + (this.rowHeights[local_18] - local_9_5.getPreferredSize().height) / 2, this.columnWidths[3], (int) local_9_5.getPreferredSize().height);
              Component local_10_3 = parent.getComponent(local_2_1 + 4);
              local_10_3.setBounds(local_12[4], local_4_2 + (this.rowHeights[local_18] - local_10_3.getPreferredSize().height) / 2, local_14, (int) local_10_3.getPreferredSize().height);
              local_2_1 += 5;
              break;
            case 7:
              Component local_6_13 = parent.getComponent(local_2_1);
              local_6_13.setBounds(local_12[0], local_4_2 + (this.rowHeights[local_18] - local_6_13.getPreferredSize().height) / 2, this.columnWidths[0], (int) local_6_13.getPreferredSize().height);
              Component local_7_11 = parent.getComponent(local_2_1 + 1);
              local_7_11.setBounds(local_12[1], local_4_2 + (this.rowHeights[local_18] - local_7_11.getPreferredSize().height) / 2, this.columnWidths[1], (int) local_7_11.getPreferredSize().height);
              Component local_8_9 = parent.getComponent(local_2_1 + 2);
              local_8_9.setBounds(local_12[2], local_4_2 + (this.rowHeights[local_18] - local_8_9.getPreferredSize().height) / 2, this.columnWidths[2], (int) local_8_9.getPreferredSize().height);
              Component local_9_7 = parent.getComponent(local_2_1 + 3);
              local_9_7.setBounds(local_12[3], local_4_2 + (this.rowHeights[local_18] - local_9_7.getPreferredSize().height) / 2, this.columnWidths[3], (int) local_9_7.getPreferredSize().height);
              Component local_10_5 = parent.getComponent(local_2_1 + 4);
              local_10_5.setBounds(local_12[4], local_4_2 + (this.rowHeights[local_18] - local_10_5.getPreferredSize().height) / 2, this.columnWidths[4], (int) local_10_5.getPreferredSize().height);
              Component local_11_1 = parent.getComponent(local_2_1 + 5);
              local_11_1.setBounds(local_12[5], local_4_2 + (this.rowHeights[local_18] - local_11_1.getPreferredSize().height) / 2, this.columnWidths[5], (int) local_11_1.getPreferredSize().height);
              local_2_1 += 6;
              break;
          }
          local_4_2 = local_4_2 + this.rowHeights[local_18] + this.rowGap;
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
