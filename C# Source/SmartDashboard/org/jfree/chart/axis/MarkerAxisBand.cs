// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.MarkerAxisBand
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class MarkerAxisBand : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -1729482413886398919L;
    private NumberAxis axis;
    private double topOuterGap;
    private double topInnerGap;
    private double bottomOuterGap;
    private double bottomInnerGap;
    private Font font;
    private List markers;

    [LineNumberTable(new byte[] {(byte) 59, (byte) 104, (byte) 103, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkerAxisBand(NumberAxis axis, double topOuterGap, double topInnerGap, double bottomOuterGap, double bottomInnerGap, Font font)
    {
      base.\u002Ector();
      MarkerAxisBand markerAxisBand = this;
      this.axis = axis;
      this.topOuterGap = topOuterGap;
      this.topInnerGap = topInnerGap;
      this.bottomOuterGap = bottomOuterGap;
      this.bottomInnerGap = bottomInnerGap;
      this.font = font;
      this.markers = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MarkerAxisBand([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MarkerAxisBand obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 102, (byte) 110, (byte) 183, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHeight(Graphics2D g2)
    {
      double num = 0.0;
      if (this.markers.size() > 0)
        num = this.topOuterGap + this.topInnerGap + (double) this.font.getLineMetrics("123g", g2.getFontRenderContext()).getHeight() + this.bottomInnerGap + this.bottomOuterGap;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 110, (byte) 103, (byte) 104, (byte) 106, (byte) 104, (byte) 110, (byte) 155, (byte) 175, (byte) 223, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawStringInRect([In] Graphics2D obj0, [In] Rectangle2D obj1, [In] Font obj2, [In] string obj3)
    {
      ((Graphics) obj0).setFont(obj2);
      FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics(obj2);
      Rectangle2D textBounds = TextUtilities.getTextBounds(obj3, obj0, fontMetrics);
      double x = ((RectangularShape) obj1).getX();
      if (((RectangularShape) textBounds).getWidth() < ((RectangularShape) obj1).getWidth())
        x += (((RectangularShape) obj1).getWidth() - ((RectangularShape) textBounds).getWidth()) / 2.0;
      LineMetrics lineMetrics = obj2.getLineMetrics(obj3, obj0.getFontRenderContext());
      obj0.drawString(obj3, (float) x, (float) (((RectangularShape) obj1).getMaxY() - this.bottomInnerGap) - lineMetrics.getDescent());
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarker(IntervalMarker marker)
    {
      this.markers.add((object) marker);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 105, (byte) 108, (byte) 107, (byte) 108, (byte) 189, (byte) 190, (byte) 181, (byte) 182, (byte) 255, (byte) 8, (byte) 69, (byte) 104, (byte) 178, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 136, (byte) 107, (byte) 117, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, double x, double y)
    {
      double height = this.getHeight(g2);
      Iterator iterator = this.markers.iterator();
      while (iterator.hasNext())
      {
        IntervalMarker intervalMarker = (IntervalMarker) iterator.next();
        double num1 = Math.max(intervalMarker.getStartValue(), this.axis.getRange().getLowerBound());
        double num2 = Math.min(intervalMarker.getEndValue(), this.axis.getRange().getUpperBound());
        double num3 = this.axis.valueToJava2D(num1, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        double num4 = this.axis.valueToJava2D(num2, dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        Rectangle2D.Double @double = new Rectangle2D.Double(num3, y + this.topOuterGap, num4 - num3, height - this.topOuterGap - this.bottomOuterGap);
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, intervalMarker.getAlpha()));
        g2.setPaint(intervalMarker.getPaint());
        g2.fill((Shape) @double);
        g2.setPaint(intervalMarker.getOutlinePaint());
        g2.draw((Shape) @double);
        g2.setComposite(composite);
        g2.setPaint((Paint) Color.black);
        this.drawStringInRect(g2, (Rectangle2D) @double, this.font, intervalMarker.getLabel());
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MarkerAxisBand))
        return false;
      MarkerAxisBand markerAxisBand = (MarkerAxisBand) obj;
      return this.topOuterGap == markerAxisBand.topOuterGap && this.topInnerGap == markerAxisBand.topInnerGap && (this.bottomInnerGap == markerAxisBand.bottomInnerGap && this.bottomOuterGap == markerAxisBand.bottomOuterGap) && (ObjectUtilities.equal((object) this.font, (object) markerAxisBand.font) && ObjectUtilities.equal((object) this.markers, (object) markerAxisBand.markers));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 99, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 19 * (19 * 37 + this.font.hashCode()) + Object.instancehelper_hashCode((object) this.markers);
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
