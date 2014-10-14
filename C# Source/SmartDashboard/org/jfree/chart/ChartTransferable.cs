// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartTransferable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.datatransfer;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.awt.datatransfer.Transferable"})]
  public class ChartTransferable : Object, Transferable
  {
    [Modifiers]
    internal DataFlavor imageFlavor;
    private JFreeChart chart;
    private int width;
    private int height;

    [LineNumberTable(new byte[] {(byte) 26, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartTransferable(JFreeChart chart, int width, int height)
      : this(chart, width, height, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 232, (byte) 32, (byte) 245, (byte) 102, (byte) 220, (byte) 2, (byte) 97, (byte) 135, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartTransferable(JFreeChart chart, int width, int height, bool cloneData)
    {
      base.\u002Ector();
      ChartTransferable chartTransferable = this;
      this.imageFlavor = new DataFlavor("image/x-java-image; class=java.awt.Image", "Image");
      try
      {
        this.chart = (JFreeChart) chart.clone();
        goto label_4;
      }
      catch (CloneNotSupportedException ex)
      {
      }
      this.chart = chart;
label_4:
      this.width = width;
      this.height = height;
    }

    [LineNumberTable((ushort) 111)]
    public virtual DataFlavor[] getTransferDataFlavors()
    {
      DataFlavor[] dataFlavorArray = new DataFlavor[1];
      int index = 0;
      DataFlavor dataFlavor = this.imageFlavor;
      dataFlavorArray[index] = dataFlavor;
      return dataFlavorArray;
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isDataFlavorSupported(DataFlavor flavor)
    {
      return (this.imageFlavor.equals(flavor) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.awt.datatransfer.UnsupportedFlavorException", "java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 88, (byte) 110, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getTransferData(DataFlavor flavor)
    {
      if (this.imageFlavor.equals(flavor))
      {
        return (object) this.chart.createBufferedImage(this.width, this.height);
      }
      else
      {
        DataFlavor dataFlavor = flavor;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnsupportedFlavorException(dataFlavor);
      }
    }
  }
}
