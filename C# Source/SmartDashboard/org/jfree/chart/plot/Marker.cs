// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.Marker
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using java.util;
using javax.swing.@event;
using org.jfree.chart.@event;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class Marker : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -734389651405327166L;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Stroke stroke;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;
    private float alpha;
    private string label;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    private RectangleAnchor labelAnchor;
    private TextAnchor labelTextAnchor;
    private RectangleInsets labelOffset;
    private LengthAdjustmentType labelOffsetType;
    [NonSerialized]
    private EventListenerList listenerList;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 102, (byte) 159, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Marker(Paint paint)
      : this(paint, (Stroke) new BasicStroke(0.5f), (Paint) Color.gray, (Stroke) new BasicStroke(0.5f), 0.8f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 232, (byte) 6, (byte) 231, (byte) 124, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 116, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 137, (byte) 115, (byte) 107, (byte) 107, (byte) 127, (byte) 16, (byte) 107, (byte) 139, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Marker(Paint paint, Stroke stroke, Paint outlinePaint, Stroke outlineStroke, float alpha)
    {
      base.\u002Ector();
      Marker marker = this;
      this.label = (string) null;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if ((double) alpha < 0.0 || (double) alpha > 1.0)
      {
        string str = "The 'alpha' value must be in the range 0.0f to 1.0f";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.stroke = stroke;
        this.outlinePaint = outlinePaint;
        this.outlineStroke = outlineStroke;
        this.alpha = alpha;
        this.labelFont = new Font("SansSerif", 0, 9);
        this.labelPaint = (Paint) Color.black;
        this.labelAnchor = RectangleAnchor.__\u003C\u003ETOP_LEFT;
        this.labelOffset = new RectangleInsets(3.0, 3.0, 3.0, 3.0);
        this.labelOffsetType = LengthAdjustmentType.__\u003C\u003ECONTRACT;
        this.labelTextAnchor = TextAnchor.__\u003C\u003ECENTER;
        this.listenerList = new EventListenerList();
      }
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Marker()
      : this((Paint) Color.gray)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Marker([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Marker obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Marker obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual float getAlpha()
    {
      return this.alpha;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    public virtual string getLabel()
    {
      return this.label;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 188, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void notifyListeners(MarkerChangeEvent @event)
    {
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener != null ? Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener : (Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener = Marker.class\u0024("org.jfree.chart.event.MarkerChangeListener"))))
          ((MarkerChangeListener) listenerList[index + 1]).markerChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable((ushort) 533)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, Marker.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.stroke = stroke;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      this.outlinePaint = paint;
      this.notifyListeners(new MarkerChangeEvent(this));
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke)
    {
      this.outlineStroke = stroke;
      this.notifyListeners(new MarkerChangeEvent(this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 114, (byte) 144, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAlpha(float alpha)
    {
      if ((double) alpha < 0.0 || (double) alpha > 1.0)
      {
        string str = "The 'alpha' value must be in the range 0.0f to 1.0f";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.alpha = alpha;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabel(string label)
    {
      this.label = label;
      this.notifyListeners(new MarkerChangeEvent(this));
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFont = font;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 36, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelPaint = paint;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual RectangleAnchor getLabelAnchor()
    {
      return this.labelAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelAnchor = anchor;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual RectangleInsets getLabelOffset()
    {
      return this.labelOffset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOffset(RectangleInsets offset)
    {
      if (offset == null)
      {
        string str = "Null 'offset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelOffset = offset;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual LengthAdjustmentType getLabelOffsetType()
    {
      return this.labelOffsetType;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 119, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOffsetType(LengthAdjustmentType adj)
    {
      if (adj == null)
      {
        string str = "Null 'adj' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelOffsetType = adj;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    public virtual TextAnchor getLabelTextAnchor()
    {
      return this.labelTextAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 146, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelTextAnchor(TextAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelTextAnchor = anchor;
        this.notifyListeners(new MarkerChangeEvent(this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 163, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(MarkerChangeListener listener)
    {
      this.listenerList.add(Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener != null ? Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener : (Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener = Marker.class\u0024("org.jfree.chart.event.MarkerChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(MarkerChangeListener listener)
    {
      this.listenerList.remove(Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener != null ? Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener : (Marker.class\u0024org\u0024jfree\u0024chart\u0024event\u0024MarkerChangeListener = Marker.class\u0024("org.jfree.chart.event.MarkerChangeListener")), (EventListener) listener);
    }

    [LineNumberTable((ushort) 577)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual EventListener[] getListeners(Class listenerType)
    {
      return this.listenerList.getListeners(listenerType);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 218, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Marker))
        return false;
      Marker marker = (Marker) obj;
      return PaintUtilities.equal(this.paint, marker.paint) && ObjectUtilities.equal((object) this.stroke, (object) marker.stroke) && (PaintUtilities.equal(this.outlinePaint, marker.outlinePaint) && ObjectUtilities.equal((object) this.outlineStroke, (object) marker.outlineStroke)) && ((double) this.alpha == (double) marker.alpha && ObjectUtilities.equal((object) this.label, (object) marker.label) && (ObjectUtilities.equal((object) this.labelFont, (object) marker.labelFont) && PaintUtilities.equal(this.labelPaint, marker.labelPaint))) && (this.labelAnchor == marker.labelAnchor && this.labelTextAnchor == marker.labelTextAnchor && (ObjectUtilities.equal((object) this.labelOffset, (object) marker.labelOffset) && this.labelOffsetType.equals((object) marker.labelOffsetType)));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 642)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 27, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writePaint(this.labelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 45, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.listenerList = new EventListenerList();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Marker.__\u003CcallerID\u003E == null)
        Marker.__\u003CcallerID\u003E = (CallerID) new Marker.__\u003CCallerID\u003E();
      return Marker.__\u003CcallerID\u003E;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
