// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.panel.CrosshairOverlay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.beans;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.panel
{
  [Implements(new string[] {"org.jfree.chart.panel.Overlay", "java.beans.PropertyChangeListener", "org.jfree.util.PublicCloneable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CrosshairOverlay : AbstractOverlay, Overlay, PropertyChangeListener, EventListener, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private List xCrosshairs;
    private List yCrosshairs;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrosshairOverlay()
    {
      CrosshairOverlay crosshairOverlay = this;
      this.xCrosshairs = (List) new ArrayList();
      this.yCrosshairs = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CrosshairOverlay([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CrosshairOverlay obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CrosshairOverlay obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getDomainCrosshairs()
    {
      return (List) new ArrayList((Collection) this.xCrosshairs);
    }

    [LineNumberTable((ushort) 170)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRangeCrosshairs()
    {
      return (List) new ArrayList((Collection) this.yCrosshairs);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 122, (byte) 150, (byte) 103, (byte) 103, (byte) 109, (byte) 109, (byte) 103, (byte) 108, (byte) 143, (byte) 105, (byte) 125, (byte) 106, (byte) 106, (byte) 106, (byte) 153, (byte) 114, (byte) 106, (byte) 125, (byte) 106, (byte) 106, (byte) 106, (byte) 185, (byte) 109, (byte) 104, (byte) 109, (byte) 104, (byte) 142, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVerticalCrosshair(Graphics2D g2, Rectangle2D dataArea, double x, Crosshair crosshair)
    {
      if (x < ((RectangularShape) dataArea).getMinX() || x > ((RectangularShape) dataArea).getMaxX())
        return;
      Line2D.Double @double = new Line2D.Double(x, ((RectangularShape) dataArea).getMinY(), x, ((RectangularShape) dataArea).getMaxY());
      Paint paint = g2.getPaint();
      Stroke stroke = g2.getStroke();
      g2.setPaint(crosshair.getPaint());
      g2.setStroke(crosshair.getStroke());
      g2.draw((Shape) @double);
      if (crosshair.isLabelVisible())
      {
        string text = crosshair.getLabelGenerator().generateLabel(crosshair);
        RectangleAnchor labelAnchor = crosshair.getLabelAnchor();
        Point2D point2D1 = this.calculateLabelPoint((Line2D) @double, labelAnchor, 5.0, 5.0);
        float x1 = (float) point2D1.getX();
        float y = (float) point2D1.getY();
        TextAnchor textAnchor = this.textAlignPtForLabelAnchorV(labelAnchor);
        Shape shape = TextUtilities.calculateRotatedStringBounds(text, g2, x1, y, textAnchor, 0.0, TextAnchor.__\u003C\u003ECENTER);
        if (!((RectangularShape) dataArea).contains(shape.getBounds2D()))
        {
          RectangleAnchor rectangleAnchor = this.flipAnchorH(labelAnchor);
          Point2D point2D2 = this.calculateLabelPoint((Line2D) @double, rectangleAnchor, 5.0, 5.0);
          x1 = (float) point2D2.getX();
          y = (float) point2D2.getY();
          textAnchor = this.textAlignPtForLabelAnchorV(rectangleAnchor);
          shape = TextUtilities.calculateRotatedStringBounds(text, g2, x1, y, textAnchor, 0.0, TextAnchor.__\u003C\u003ECENTER);
        }
        g2.setPaint(crosshair.getLabelBackgroundPaint());
        g2.fill(shape);
        g2.setPaint(crosshair.getLabelOutlinePaint());
        g2.draw(shape);
        TextUtilities.drawAlignedString(text, g2, x1, y, textAnchor);
      }
      g2.setPaint(paint);
      g2.setStroke(stroke);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 122, (byte) 150, (byte) 103, (byte) 103, (byte) 109, (byte) 109, (byte) 103, (byte) 108, (byte) 143, (byte) 105, (byte) 125, (byte) 106, (byte) 106, (byte) 106, (byte) 153, (byte) 114, (byte) 106, (byte) 125, (byte) 106, (byte) 106, (byte) 106, (byte) 217, (byte) 109, (byte) 104, (byte) 109, (byte) 104, (byte) 142, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontalCrosshair(Graphics2D g2, Rectangle2D dataArea, double y, Crosshair crosshair)
    {
      if (y < ((RectangularShape) dataArea).getMinY() || y > ((RectangularShape) dataArea).getMaxY())
        return;
      Line2D.Double @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), y, ((RectangularShape) dataArea).getMaxX(), y);
      Paint paint = g2.getPaint();
      Stroke stroke = g2.getStroke();
      g2.setPaint(crosshair.getPaint());
      g2.setStroke(crosshair.getStroke());
      g2.draw((Shape) @double);
      if (crosshair.isLabelVisible())
      {
        string text = crosshair.getLabelGenerator().generateLabel(crosshair);
        RectangleAnchor labelAnchor = crosshair.getLabelAnchor();
        Point2D point2D1 = this.calculateLabelPoint((Line2D) @double, labelAnchor, 5.0, 5.0);
        float x = (float) point2D1.getX();
        float y1 = (float) point2D1.getY();
        TextAnchor textAnchor = this.textAlignPtForLabelAnchorH(labelAnchor);
        Shape shape = TextUtilities.calculateRotatedStringBounds(text, g2, x, y1, textAnchor, 0.0, TextAnchor.__\u003C\u003ECENTER);
        if (!((RectangularShape) dataArea).contains(shape.getBounds2D()))
        {
          RectangleAnchor rectangleAnchor = this.flipAnchorV(labelAnchor);
          Point2D point2D2 = this.calculateLabelPoint((Line2D) @double, rectangleAnchor, 5.0, 5.0);
          x = (float) point2D2.getX();
          y1 = (float) point2D2.getY();
          textAnchor = this.textAlignPtForLabelAnchorH(rectangleAnchor);
          shape = TextUtilities.calculateRotatedStringBounds(text, g2, x, y1, textAnchor, 0.0, TextAnchor.__\u003C\u003ECENTER);
        }
        g2.setPaint(crosshair.getLabelBackgroundPaint());
        g2.fill(shape);
        g2.setPaint(crosshair.getLabelOutlinePaint());
        g2.draw(shape);
        TextUtilities.drawAlignedString(text, g2, x, y1, textAnchor);
      }
      g2.setPaint(paint);
      g2.setStroke(stroke);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 102, (byte) 102, (byte) 189, (byte) 189, (byte) 189, (byte) 189, (byte) 104, (byte) 137, (byte) 113, (byte) 105, (byte) 122, (byte) 99, (byte) 136, (byte) 99, (byte) 136, (byte) 99, (byte) 152, (byte) 102, (byte) 221, (byte) 122, (byte) 105, (byte) 99, (byte) 151, (byte) 99, (byte) 151, (byte) 99, (byte) 137, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Point2D calculateLabelPoint([In] Line2D obj0, [In] RectangleAnchor obj1, [In] double obj2, [In] double obj3)
    {
      int num1 = obj1 == RectangleAnchor.__\u003C\u003EBOTTOM_LEFT || obj1 == RectangleAnchor.__\u003C\u003ELEFT || obj1 == RectangleAnchor.__\u003C\u003ETOP_LEFT ? 1 : 0;
      int num2 = obj1 == RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT || obj1 == RectangleAnchor.__\u003C\u003ERIGHT || obj1 == RectangleAnchor.__\u003C\u003ETOP_RIGHT ? 1 : 0;
      int num3 = obj1 == RectangleAnchor.__\u003C\u003ETOP_LEFT || obj1 == RectangleAnchor.__\u003C\u003ETOP || obj1 == RectangleAnchor.__\u003C\u003ETOP_RIGHT ? 1 : 0;
      int num4 = obj1 == RectangleAnchor.__\u003C\u003EBOTTOM_LEFT || obj1 == RectangleAnchor.__\u003C\u003EBOTTOM || obj1 == RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT ? 1 : 0;
      RectangleAnchor.coordinates((Rectangle2D) obj0.getBounds(), obj1);
      double num5;
      double num6;
      if (obj0.getX1() == obj0.getX2())
      {
        num5 = obj0.getX1();
        num6 = (obj0.getY1() + obj0.getY2()) / 2.0;
        if (num1 != 0)
          num5 -= obj2;
        if (num2 != 0)
          num5 += obj2;
        if (num3 != 0)
          num6 = Math.min(obj0.getY1(), obj0.getY2()) + obj3;
        if (num4 != 0)
          num6 = Math.max(obj0.getY1(), obj0.getY2()) - obj3;
      }
      else
      {
        num5 = (obj0.getX1() + obj0.getX2()) / 2.0;
        num6 = obj0.getY1();
        if (num1 != 0)
          num5 = Math.min(obj0.getX1(), obj0.getX2()) + obj2;
        if (num2 != 0)
          num5 = Math.max(obj0.getX1(), obj0.getX2()) - obj2;
        if (num3 != 0)
          num6 -= obj3;
        if (num4 != 0)
          num6 += obj3;
      }
      return (Point2D) new Point2D.Double(num5, num6);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 102, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextAnchor textAlignPtForLabelAnchorH([In] RectangleAnchor obj0)
    {
      TextAnchor textAnchor = TextAnchor.__\u003C\u003ECENTER;
      if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ELEFT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ERIGHT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM))
        textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_RIGHT;
      return textAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 98, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RectangleAnchor flipAnchorV([In] RectangleAnchor obj0)
    {
      RectangleAnchor rectangleAnchor = obj0;
      if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_RIGHT;
      return rectangleAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 32, (byte) 102, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextAnchor textAlignPtForLabelAnchorV([In] RectangleAnchor obj0)
    {
      TextAnchor textAnchor = TextAnchor.__\u003C\u003ECENTER;
      if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP))
        textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ELEFT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ERIGHT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_LEFT;
      return textAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 98, (byte) 98, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RectangleAnchor flipAnchorH([In] RectangleAnchor obj0)
    {
      RectangleAnchor rectangleAnchor = obj0;
      if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ETOP_LEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ELEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ERIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003ERIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003ELEFT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else if (obj0.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
        rectangleAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_LEFT;
      return rectangleAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 99, (byte) 144, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDomainCrosshair(Crosshair crosshair)
    {
      if (crosshair == null)
      {
        string str = "Null 'crosshair' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.xCrosshairs.add((object) crosshair);
        crosshair.addPropertyChangeListener((PropertyChangeListener) this);
      }
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeDomainCrosshair(Crosshair crosshair)
    {
      if (crosshair == null)
      {
        string str = "Null 'crosshair' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.xCrosshairs.remove((object) crosshair))
          return;
        crosshair.removePropertyChangeListener((PropertyChangeListener) this);
        this.fireOverlayChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 109, (byte) 129, (byte) 103, (byte) 107, (byte) 109, (byte) 109, (byte) 231, (byte) 61, (byte) 230, (byte) 69, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearDomainCrosshairs()
    {
      if (this.xCrosshairs.isEmpty())
        return;
      List domainCrosshairs = this.getDomainCrosshairs();
      for (int index = 0; index < domainCrosshairs.size(); ++index)
      {
        Crosshair crosshair = (Crosshair) domainCrosshairs.get(index);
        this.xCrosshairs.remove((object) crosshair);
        crosshair.removePropertyChangeListener((PropertyChangeListener) this);
      }
      this.fireOverlayChanged();
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 99, (byte) 144, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addRangeCrosshair(Crosshair crosshair)
    {
      if (crosshair == null)
      {
        string str = "Null 'crosshair' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.yCrosshairs.add((object) crosshair);
        crosshair.addPropertyChangeListener((PropertyChangeListener) this);
      }
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRangeCrosshair(Crosshair crosshair)
    {
      if (crosshair == null)
      {
        string str = "Null 'crosshair' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.yCrosshairs.remove((object) crosshair))
          return;
        crosshair.removePropertyChangeListener((PropertyChangeListener) this);
        this.fireOverlayChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 109, (byte) 129, (byte) 103, (byte) 107, (byte) 109, (byte) 109, (byte) 231, (byte) 61, (byte) 230, (byte) 69, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearRangeCrosshairs()
    {
      if (this.yCrosshairs.isEmpty())
        return;
      List rangeCrosshairs = this.getRangeCrosshairs();
      for (int index = 0; index < rangeCrosshairs.size(); ++index)
      {
        Crosshair crosshair = (Crosshair) rangeCrosshairs.get(index);
        this.yCrosshairs.remove((object) crosshair);
        crosshair.removePropertyChangeListener((PropertyChangeListener) this);
      }
      this.fireOverlayChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void propertyChange(PropertyChangeEvent e)
    {
      this.fireOverlayChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 108, (byte) 104, (byte) 104, (byte) 109, (byte) 108, (byte) 110, (byte) 105, (byte) 106, (byte) 111, (byte) 109, (byte) 174, (byte) 172, (byte) 101, (byte) 104, (byte) 104, (byte) 109, (byte) 108, (byte) 110, (byte) 105, (byte) 106, (byte) 111, (byte) 109, (byte) 174, (byte) 172, (byte) 101, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintOverlay(Graphics2D g2, ChartPanel chartPanel)
    {
      Shape clip = ((Graphics) g2).getClip();
      Rectangle2D screenDataArea = chartPanel.getScreenDataArea();
      g2.clip((Shape) screenDataArea);
      XYPlot xyPlot = (XYPlot) chartPanel.getChart().getPlot();
      ValueAxis domainAxis = xyPlot.getDomainAxis();
      RectangleEdge domainAxisEdge = xyPlot.getDomainAxisEdge();
      Iterator iterator1 = this.xCrosshairs.iterator();
      while (iterator1.hasNext())
      {
        Crosshair crosshair = (Crosshair) iterator1.next();
        if (crosshair.isVisible())
        {
          double d = crosshair.getValue();
          double num = domainAxis.valueToJava2D(d, screenDataArea, domainAxisEdge);
          if (xyPlot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
            this.drawVerticalCrosshair(g2, screenDataArea, num, crosshair);
          else
            this.drawHorizontalCrosshair(g2, screenDataArea, num, crosshair);
        }
      }
      ValueAxis rangeAxis = xyPlot.getRangeAxis();
      RectangleEdge rangeAxisEdge = xyPlot.getRangeAxisEdge();
      Iterator iterator2 = this.yCrosshairs.iterator();
      while (iterator2.hasNext())
      {
        Crosshair crosshair = (Crosshair) iterator2.next();
        if (crosshair.isVisible())
        {
          double d = crosshair.getValue();
          double num = rangeAxis.valueToJava2D(d, screenDataArea, rangeAxisEdge);
          if (xyPlot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
            this.drawHorizontalCrosshair(g2, screenDataArea, num, crosshair);
          else
            this.drawVerticalCrosshair(g2, screenDataArea, num, crosshair);
        }
      }
      ((Graphics) g2).setClip(clip);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CrosshairOverlay))
        return false;
      CrosshairOverlay crosshairOverlay = (CrosshairOverlay) obj;
      return Object.instancehelper_equals((object) this.xCrosshairs, (object) crosshairOverlay.xCrosshairs) && Object.instancehelper_equals((object) this.yCrosshairs, (object) crosshairOverlay.yCrosshairs);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 108, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      CrosshairOverlay crosshairOverlay = (CrosshairOverlay) base.clone();
      crosshairOverlay.xCrosshairs = (List) ObjectUtilities.deepClone((Collection) this.xCrosshairs);
      crosshairOverlay.yCrosshairs = (List) ObjectUtilities.deepClone((Collection) this.yCrosshairs);
      return (object) crosshairOverlay;
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
