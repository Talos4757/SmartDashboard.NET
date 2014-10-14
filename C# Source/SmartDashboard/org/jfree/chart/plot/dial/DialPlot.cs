// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.plot;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayerChangeListener"})]
  [Serializable]
  public class DialPlot : Plot, DialLayerChangeListener, EventListener
  {
    private DialLayer background;
    private DialLayer cap;
    private DialFrame dialFrame;
    private ObjectList datasets;
    private ObjectList scales;
    private ObjectList datasetToScaleMap;
    private List layers;
    private List pointers;
    private double viewX;
    private double viewY;
    private double viewW;
    private double viewH;

    [HideFromJava]
    static DialPlot()
    {
      Plot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 104, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 99, (byte) 135, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialPlot(ValueDataset dataset)
    {
      DialPlot dialPlot = this;
      this.background = (DialLayer) null;
      this.cap = (DialLayer) null;
      this.dialFrame = (DialFrame) new ArcDialFrame();
      this.datasets = new ObjectList();
      if (dataset != null)
        this.setDataset(dataset);
      this.scales = new ObjectList();
      this.datasetToScaleMap = new ObjectList();
      this.layers = (List) new ArrayList();
      this.pointers = (List) new ArrayList();
      this.viewX = 0.0;
      this.viewY = 0.0;
      this.viewW = 1.0;
      this.viewH = 1.0;
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialPlot()
      : this((ValueDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 94, (byte) 99, (byte) 144, (byte) 104, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rectangle2D rectangleByRadius(Rectangle2D rect, double radiusW, double radiusH)
    {
      if (rect == null)
      {
        string str = "Null 'rect' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double centerX = ((RectangularShape) rect).getCenterX();
        double centerY = ((RectangularShape) rect).getCenterY();
        double num1 = ((RectangularShape) rect).getWidth() * radiusW;
        double num2 = ((RectangularShape) rect).getHeight() * radiusH;
        return (Rectangle2D) new Rectangle2D.Double(centerX - num1 / 2.0, centerY - num2 / 2.0, num1, num2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 119, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(ValueDataset dataset)
    {
      this.setDataset(0, dataset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getLayerIndex(DialLayer layer)
    {
      if (layer == null)
      {
        string str = "Null 'layer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.layers.indexOf((object) layer);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 114, (byte) 99, (byte) 135, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeLayer(int index)
    {
      DialLayer dialLayer = (DialLayer) this.layers.get(index);
      if (dialLayer != null)
        dialLayer.removeChangeListener((DialLayerChangeListener) this);
      this.layers.remove(index);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 35, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getPointerIndex(DialPointer pointer)
    {
      if (pointer == null)
      {
        string str = "Null 'pointer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.pointers.indexOf((object) pointer);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 104, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueDataset getDataset(int index)
    {
      ValueDataset valueDataset = (ValueDataset) null;
      if (this.datasets.size() > index)
        valueDataset = (ValueDataset) this.datasets.get(index);
      return valueDataset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 130, (byte) 114, (byte) 99, (byte) 135, (byte) 109, (byte) 99, (byte) 199, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(int index, ValueDataset dataset)
    {
      ValueDataset valueDataset = (ValueDataset) this.datasets.get(index);
      if (valueDataset != null)
        valueDataset.removeChangeListener((DatasetChangeListener) this);
      this.datasets.set(index, (object) dataset);
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 250, (byte) 111, (byte) 111, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rectangle2D viewToFrame([In] Rectangle2D obj0)
    {
      double num1 = ((RectangularShape) obj0).getWidth() / this.viewW;
      double num2 = ((RectangularShape) obj0).getHeight() / this.viewH;
      return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) obj0).getX() - num1 * this.viewX, ((RectangularShape) obj0).getY() - num2 * this.viewY, num1, num2);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeLayer(DialLayer layer)
    {
      this.removeLayer(this.getLayerIndex(layer));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 49, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DialScale getScale(int index)
    {
      DialScale dialScale = (DialScale) null;
      if (this.scales.size() > index)
        dialScale = (DialScale) this.scales.get(index);
      return dialScale;
    }

    public virtual DialLayer getBackground()
    {
      return this.background;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 104, (byte) 140, (byte) 103, (byte) 99, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackground(DialLayer background)
    {
      if (this.background != null)
        this.background.removeChangeListener((DialLayerChangeListener) this);
      this.background = background;
      if (background != null)
        background.addChangeListener((DialLayerChangeListener) this);
      this.fireChangeEvent();
    }

    public virtual DialLayer getCap()
    {
      return this.cap;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 104, (byte) 140, (byte) 103, (byte) 99, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCap(DialLayer cap)
    {
      if (this.cap != null)
        this.cap.removeChangeListener((DialLayerChangeListener) this);
      this.cap = cap;
      if (cap != null)
        cap.addChangeListener((DialLayerChangeListener) this);
      this.fireChangeEvent();
    }

    public virtual DialFrame getDialFrame()
    {
      return this.dialFrame;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 99, (byte) 144, (byte) 108, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDialFrame(DialFrame frame)
    {
      if (frame == null)
      {
        string str = "Null 'frame' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dialFrame.removeChangeListener((DialLayerChangeListener) this);
        this.dialFrame = frame;
        frame.addChangeListener((DialLayerChangeListener) this);
        this.fireChangeEvent();
      }
    }

    public virtual double getViewX()
    {
      return this.viewX;
    }

    public virtual double getViewY()
    {
      return this.viewY;
    }

    public virtual double getViewWidth()
    {
      return this.viewW;
    }

    public virtual double getViewHeight()
    {
      return this.viewH;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setView(double x, double y, double w, double h)
    {
      this.viewX = x;
      this.viewY = y;
      this.viewW = w;
      this.viewH = h;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLayer(DialLayer layer)
    {
      if (layer == null)
      {
        string str = "Null 'layer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.layers.add((object) layer);
        layer.addChangeListener((DialLayerChangeListener) this);
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 19, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPointer(DialPointer pointer)
    {
      if (pointer == null)
      {
        string str = "Null 'pointer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.pointers.add((object) pointer);
        pointer.addChangeListener((DialLayerChangeListener) this);
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 114, (byte) 99, (byte) 135, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePointer(int index)
    {
      DialPointer dialPointer = (DialPointer) this.pointers.get(index);
      if (dialPointer != null)
        dialPointer.removeChangeListener((DialLayerChangeListener) this);
      this.pointers.remove(index);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePointer(DialPointer pointer)
    {
      this.removeLayer(this.getPointerIndex(pointer));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DialPointer getPointerForDataset(int datasetIndex)
    {
      Iterator iterator = this.pointers.iterator();
      while (iterator.hasNext())
      {
        DialPointer dialPointer = (DialPointer) iterator.next();
        if (dialPointer.getDatasetIndex() == datasetIndex)
          return dialPointer;
      }
      return (DialPointer) null;
    }

    [LineNumberTable((ushort) 463)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ValueDataset getDataset()
    {
      return this.getDataset(0);
    }

    [LineNumberTable((ushort) 521)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDatasetCount()
    {
      return this.datasets.size();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 169, (byte) 103, (byte) 167, (byte) 168, (byte) 117, (byte) 109, (byte) 103, (byte) 114, (byte) 111, (byte) 103, (byte) 130, (byte) 207, (byte) 108, (byte) 107, (byte) 109, (byte) 105, (byte) 105, (byte) 104, (byte) 114, (byte) 107, (byte) 104, (byte) 130, (byte) 171, (byte) 165, (byte) 108, (byte) 107, (byte) 109, (byte) 105, (byte) 105, (byte) 104, (byte) 114, (byte) 107, (byte) 104, (byte) 130, (byte) 171, (byte) 165, (byte) 117, (byte) 109, (byte) 104, (byte) 114, (byte) 111, (byte) 104, (byte) 130, (byte) 207, (byte) 109, (byte) 175, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      Shape clip1 = ((Graphics) g2).getClip();
      ((Graphics) g2).setClip((Shape) area);
      Rectangle2D rectangle2D = this.viewToFrame(area);
      if (this.background != null && this.background.isVisible())
      {
        if (this.background.isClippedToWindow())
        {
          Shape clip2 = ((Graphics) g2).getClip();
          g2.clip(this.dialFrame.getWindow(rectangle2D));
          this.background.draw(g2, this, rectangle2D, area);
          ((Graphics) g2).setClip(clip2);
        }
        else
          this.background.draw(g2, this, rectangle2D, area);
      }
      Iterator iterator1 = this.layers.iterator();
      while (iterator1.hasNext())
      {
        DialLayer dialLayer = (DialLayer) iterator1.next();
        if (dialLayer.isVisible())
        {
          if (dialLayer.isClippedToWindow())
          {
            Shape clip2 = ((Graphics) g2).getClip();
            g2.clip(this.dialFrame.getWindow(rectangle2D));
            dialLayer.draw(g2, this, rectangle2D, area);
            ((Graphics) g2).setClip(clip2);
          }
          else
            dialLayer.draw(g2, this, rectangle2D, area);
        }
      }
      Iterator iterator2 = this.pointers.iterator();
      while (iterator2.hasNext())
      {
        DialPointer dialPointer = (DialPointer) iterator2.next();
        if (dialPointer.isVisible())
        {
          if (dialPointer.isClippedToWindow())
          {
            Shape clip2 = ((Graphics) g2).getClip();
            g2.clip(this.dialFrame.getWindow(rectangle2D));
            dialPointer.draw(g2, this, rectangle2D, area);
            ((Graphics) g2).setClip(clip2);
          }
          else
            dialPointer.draw(g2, this, rectangle2D, area);
        }
      }
      if (this.cap != null && this.cap.isVisible())
      {
        if (this.cap.isClippedToWindow())
        {
          Shape clip2 = ((Graphics) g2).getClip();
          g2.clip(this.dialFrame.getWindow(rectangle2D));
          this.cap.draw(g2, this, rectangle2D, area);
          ((Graphics) g2).setClip(clip2);
        }
        else
          this.cap.draw(g2, this, rectangle2D, area);
      }
      if (this.dialFrame.isVisible())
        this.dialFrame.draw(g2, this, rectangle2D, area);
      ((Graphics) g2).setClip(clip1);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 9, (byte) 106, (byte) 104, (byte) 99, (byte) 103, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getValue(int datasetIndex)
    {
      double num = double.NaN;
      ValueDataset dataset = this.getDataset(datasetIndex);
      if (dataset != null)
      {
        Number number = dataset.getValue();
        if (number != null)
          num = number.doubleValue();
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 28, (byte) 99, (byte) 144, (byte) 114, (byte) 99, (byte) 135, (byte) 109, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addScale(int index, DialScale scale)
    {
      if (scale == null)
      {
        string str = "Null 'scale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        DialScale dialScale = (DialScale) this.scales.get(index);
        if (dialScale != null)
          this.removeLayer((DialLayer) dialScale);
        this.layers.add((object) scale);
        this.scales.set(index, (object) scale);
        scale.addChangeListener((DialLayerChangeListener) this);
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 63, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mapDatasetToScale(int index, int scaleIndex)
    {
      this.datasetToScaleMap.set(index, (object) new Integer(scaleIndex));
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 75, (byte) 114, (byte) 114, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DialScale getScaleForDataset(int datasetIndex)
    {
      DialScale dialScale = (DialScale) this.scales.get(0);
      Integer integer = (Integer) this.datasetToScaleMap.get(datasetIndex);
      if (integer != null)
        dialScale = this.getScale(integer.intValue());
      return dialScale;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 111, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void dialLayerChanged(DialLayerChangeEvent @event)
    {
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 124, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DialPlot))
        return false;
      DialPlot dialPlot = (DialPlot) obj;
      if (!ObjectUtilities.equal((object) this.background, (object) dialPlot.background) || !ObjectUtilities.equal((object) this.cap, (object) dialPlot.cap) || (!Object.instancehelper_equals((object) this.dialFrame, (object) dialPlot.dialFrame) || this.viewX != dialPlot.viewX) || (this.viewY != dialPlot.viewY || this.viewW != dialPlot.viewW || (this.viewH != dialPlot.viewH || !Object.instancehelper_equals((object) this.layers, (object) dialPlot.layers))) || !Object.instancehelper_equals((object) this.pointers, (object) dialPlot.pointers))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 167, (byte) 102, (byte) 113, (byte) 113, (byte) 113, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 37 * (37 * (37 * 193 + ObjectUtilities.hashCode((object) this.background)) + ObjectUtilities.hashCode((object) this.cap)) + Object.instancehelper_hashCode((object) this.dialFrame);
      long num2 = Double.doubleToLongBits(this.viewX);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.viewY);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.viewW);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.viewH);
      return 37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
    }

    public override string getPlotType()
    {
      return "DialPlot";
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 199, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 212, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
    }
  }
}
