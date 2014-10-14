// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.RingPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.urls;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class RingPlot : PiePlot, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 1556064784129676620L;
    private bool separatorsVisible;
    [NonSerialized]
    private Stroke separatorStroke;
    [NonSerialized]
    private Paint separatorPaint;
    private double innerSeparatorExtension;
    private double outerSeparatorExtension;
    private double sectionDepth;

    [HideFromJava]
    static RingPlot()
    {
      PiePlot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 105, (byte) 103, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RingPlot(PieDataset dataset)
      : base(dataset)
    {
      RingPlot ringPlot = this;
      this.separatorsVisible = true;
      this.separatorStroke = (Stroke) new BasicStroke(0.5f);
      this.separatorPaint = (Paint) Color.gray;
      this.innerSeparatorExtension = 0.2;
      this.outerSeparatorExtension = 0.2;
      this.sectionDepth = 0.2;
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RingPlot()
      : this((PieDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RingPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] RingPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RingPlot obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 99, (byte) 144, (byte) 104, (byte) 104, (byte) 101, (byte) 104, (byte) 105, (byte) 103, (byte) 104, (byte) 105, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Line2D extendLine([In] Line2D obj0, [In] double obj1, [In] double obj2)
    {
      if (obj0 == null)
      {
        string str = "Null 'line' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double x1 = obj0.getX1();
        double x2 = obj0.getX2();
        double num1 = x2 - x1;
        double y1 = obj0.getY1();
        double y2 = obj0.getY2();
        double num2 = y2 - y1;
        return (Line2D) new Line2D.Double(x1 - obj1 * num1, y1 - obj1 * num2, x2 + obj2 * num1, y2 + obj2 * num2);
      }
    }

    public virtual double getSectionDepth()
    {
      return this.sectionDepth;
    }

    public virtual bool getSeparatorsVisible()
    {
      return this.separatorsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeparatorsVisible(bool visible)
    {
      this.separatorsVisible = visible;
      this.fireChangeEvent();
    }

    public virtual Stroke getSeparatorStroke()
    {
      return this.separatorStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeparatorStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.separatorStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getSeparatorPaint()
    {
      return this.separatorPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeparatorPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.separatorPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual double getInnerSeparatorExtension()
    {
      return this.innerSeparatorExtension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInnerSeparatorExtension(double percent)
    {
      this.innerSeparatorExtension = percent;
      this.fireChangeEvent();
    }

    public virtual double getOuterSeparatorExtension()
    {
      return this.outerSeparatorExtension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 159, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOuterSeparatorExtension(double percent)
    {
      this.outerSeparatorExtension = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 186, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSectionDepth(double sectionDepth)
    {
      this.sectionDepth = sectionDepth;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 110, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PiePlotState initialise(Graphics2D g2, Rectangle2D plotArea, PiePlot plot, Integer index, PlotRenderingInfo info)
    {
      PiePlotState piePlotState = base.initialise(g2, plotArea, plot, index, info);
      piePlotState.setPassesRequired(3);
      return piePlotState;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 103, (byte) 104, (byte) 99, (byte) 129, (byte) 104, (byte) 102, (byte) 134, (byte) 103, (byte) 104, (byte) 106, (byte) 155, (byte) 104, (byte) 106, (byte) 187, (byte) 176, (byte) 104, (byte) 114, (byte) 105, (byte) 103, (byte) 105, (byte) 105, (byte) 142, (byte) 156, (byte) 206, (byte) 115, (byte) 153, (byte) 103, (byte) 105, (byte) 169, (byte) 146, (byte) 103, (byte) 159, (byte) 2, (byte) 112, (byte) 112, (byte) 135, (byte) 181, (byte) 100, (byte) 104, (byte) 105, (byte) 105, (byte) 100, (byte) 145, (byte) 104, (byte) 136, (byte) 101, (byte) 104, (byte) 106, (byte) 104, (byte) 104, (byte) 106, (byte) 106, (byte) 104, (byte) 104, (byte) 104, (byte) 200, (byte) 108, (byte) 105, (byte) 103, (byte) 99, (byte) 136, (byte) 100, (byte) 172, (byte) 99, (byte) 104, (byte) 100, (byte) 178, (byte) 183, (byte) 169, (byte) 98, (byte) 101, (byte) 104, (byte) 182, (byte) 108, (byte) 108, (byte) 200, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawItem(Graphics2D g2, int section, Rectangle2D dataArea, PiePlotState state, int currentPass)
    {
      PieDataset dataset = this.getDataset();
      Number number = dataset.getValue(section);
      if (number == null)
        return;
      double num1 = number.doubleValue();
      Rotation direction = this.getDirection();
      double latestAngle;
      double angle;
      if (direction == Rotation.__\u003C\u003ECLOCKWISE)
      {
        latestAngle = state.getLatestAngle();
        angle = latestAngle - num1 / state.getTotal() * 360.0;
      }
      else if (direction == Rotation.__\u003C\u003EANTICLOCKWISE)
      {
        latestAngle = state.getLatestAngle();
        angle = latestAngle + num1 / state.getTotal() * 360.0;
      }
      else
      {
        string str = "Rotation type not recognised.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
      double extent = angle - latestAngle;
      if (Math.abs(extent) > this.getMinimumArcAngleToDraw())
      {
        IComparable sectionKey = this.getSectionKey(section);
        double explodePercent = 0.0;
        double maximumExplodePercent = this.getMaximumExplodePercent();
        if (maximumExplodePercent > 0.0)
          explodePercent = this.getExplodePercent(sectionKey) / maximumExplodePercent;
        Rectangle2D arcBounds = this.getArcBounds(state.getPieArea(), state.getExplodedPieArea(), latestAngle, extent, explodePercent);
        Arc2D.Double double1 = new Arc2D.Double(arcBounds, latestAngle, extent, 0);
        double num2 = this.sectionDepth / 2.0;
        RectangleInsets.__\u003Cclinit\u003E();
        RectangleInsets rectangleInsets = new RectangleInsets(UnitType.__\u003C\u003ERELATIVE, num2, num2, num2, num2);
        Rectangle2D.Double double2 = new Rectangle2D.Double();
        ((Rectangle2D) double2).setRect(arcBounds);
        rectangleInsets.trim((Rectangle2D) double2);
        Arc2D.Double double3 = new Arc2D.Double((Rectangle2D) double2, latestAngle + extent, -extent, 0);
        GeneralPath generalPath = new GeneralPath();
        ((Path2D.Float) generalPath).moveTo((float) ((Arc2D) double1).getStartPoint().getX(), (float) ((Arc2D) double1).getStartPoint().getY());
        ((Path2D.Float) generalPath).append(((Arc2D) double1).getPathIterator((AffineTransform) null), false);
        ((Path2D.Float) generalPath).append(((Arc2D) double3).getPathIterator((AffineTransform) null), true);
        ((Path2D) generalPath).closePath();
        Line2D.Double double4 = new Line2D.Double(((Arc2D) double3).getEndPoint(), ((Arc2D) double1).getStartPoint());
        if (currentPass == 0)
        {
          Paint shadowPaint = this.getShadowPaint();
          double shadowXoffset = this.getShadowXOffset();
          double shadowYoffset = this.getShadowYOffset();
          if (shadowPaint != null)
          {
            Shape translatedShape = ShapeUtilities.createTranslatedShape((Shape) generalPath, shadowXoffset, shadowYoffset);
            g2.setPaint(shadowPaint);
            g2.fill(translatedShape);
          }
        }
        else if (currentPass == 1)
        {
          Paint paint1 = this.lookupSectionPaint(sectionKey);
          g2.setPaint(paint1);
          g2.fill((Shape) generalPath);
          Paint paint2 = this.lookupSectionOutlinePaint(sectionKey);
          Stroke stroke = this.lookupSectionOutlineStroke(sectionKey);
          if (paint2 != null && stroke != null)
          {
            g2.setPaint(paint2);
            g2.setStroke(stroke);
            g2.draw((Shape) generalPath);
          }
          if (state.getInfo() != null)
          {
            EntityCollection entityCollection = state.getEntityCollection();
            if (entityCollection != null)
            {
              string toolTipText = (string) null;
              PieToolTipGenerator toolTipGenerator = this.getToolTipGenerator();
              if (toolTipGenerator != null)
                toolTipText = toolTipGenerator.generateToolTip(dataset, sectionKey);
              string urlText = (string) null;
              PieURLGenerator urlGenerator = this.getURLGenerator();
              if (urlGenerator != null)
                urlText = urlGenerator.generateURL(dataset, sectionKey, this.getPieIndex());
              PieSectionEntity pieSectionEntity = new PieSectionEntity((Shape) generalPath, dataset, this.getPieIndex(), section, sectionKey, toolTipText, urlText);
              entityCollection.add((ChartEntity) pieSectionEntity);
            }
          }
        }
        else if (currentPass == 2 && this.separatorsVisible)
        {
          Line2D line2D = this.extendLine((Line2D) double4, this.innerSeparatorExtension, this.outerSeparatorExtension);
          g2.setStroke(this.separatorStroke);
          g2.setPaint(this.separatorPaint);
          g2.draw((Shape) line2D);
        }
      }
      state.setLatestAngle(angle);
    }

    [LineNumberTable((ushort) 467)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override double getLabelLinkDepth()
    {
      return Math.min(base.getLabelLinkDepth(), this.getSectionDepth() / 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is RingPlot))
        return false;
      RingPlot ringPlot = (RingPlot) obj;
      if (this.separatorsVisible != ringPlot.separatorsVisible || !ObjectUtilities.equal((object) this.separatorStroke, (object) ringPlot.separatorStroke) || (!PaintUtilities.equal(this.separatorPaint, ringPlot.separatorPaint) || this.innerSeparatorExtension != ringPlot.innerSeparatorExtension) || (this.outerSeparatorExtension != ringPlot.outerSeparatorExtension || this.sectionDepth != ringPlot.sectionDepth))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.separatorStroke, obj0);
      SerialUtilities.writePaint(this.separatorPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 188, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.separatorStroke = SerialUtilities.readStroke(obj0);
      this.separatorPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
