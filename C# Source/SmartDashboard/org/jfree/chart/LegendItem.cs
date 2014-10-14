// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.LegendItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class LegendItem : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    [Modifiers]
    private static Shape UNUSED_SHAPE = (Shape) new Line2D.Float();
    [Modifiers]
    private static Stroke UNUSED_STROKE = (Stroke) new BasicStroke(0.0f);
    private const long serialVersionUID = -797214582948827144L;
    private Dataset dataset;
    private IComparable seriesKey;
    private int datasetIndex;
    private int series;
    private string label;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    [NonSerialized]
    private AttributedString attributedLabel;
    private string description;
    private string toolTipText;
    private string urlText;
    private bool shapeVisible;
    [NonSerialized]
    private Shape shape;
    private bool shapeFilled;
    [NonSerialized]
    private Paint fillPaint;
    private GradientPaintTransformer fillPaintTransformer;
    private bool shapeOutlineVisible;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;
    private bool lineVisible;
    [NonSerialized]
    private Shape line;
    [NonSerialized]
    private Stroke lineStroke;
    [NonSerialized]
    private Paint linePaint;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 234, (byte) 70})]
    static LegendItem()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 159, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label, Paint paint)
      : this(label, (string) null, (string) null, (string) null, (Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0), paint)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 255, (byte) 15, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label, string description, string toolTipText, string urlText, Shape shape, Paint fillPaint)
      : this(label, description, toolTipText, urlText, true, shape, true, fillPaint, false, (Paint) Color.black, LegendItem.UNUSED_STROKE, false, LegendItem.UNUSED_SHAPE, LegendItem.UNUSED_STROKE, (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 58, (byte) 76, (byte) 137, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 103, (byte) 104, (byte) 107, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label, string description, string toolTipText, string urlText, bool shapeVisible, Shape shape, bool shapeFilled, Paint fillPaint, bool shapeOutlineVisible, Paint outlinePaint, Stroke outlineStroke, bool lineVisible, Shape line, Stroke lineStroke, Paint linePaint)
    {
      int num1 = shapeVisible ? 1 : 0;
      int num2 = shapeFilled ? 1 : 0;
      int num3 = shapeOutlineVisible ? 1 : 0;
      int num4 = lineVisible ? 1 : 0;
      base.\u002Ector();
      LegendItem legendItem = this;
      if (label == null)
      {
        string str = "Null 'label' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (fillPaint == null)
      {
        string str = "Null 'fillPaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (lineStroke == null)
      {
        string str = "Null 'lineStroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (outlinePaint == null)
      {
        string str = "Null 'outlinePaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (outlineStroke == null)
      {
        string str = "Null 'outlineStroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.label = label;
        this.labelPaint = (Paint) null;
        this.attributedLabel = (AttributedString) null;
        this.description = description;
        this.shapeVisible = num1 != 0;
        this.shape = shape;
        this.shapeFilled = num2 != 0;
        this.fillPaint = fillPaint;
        this.fillPaintTransformer = (GradientPaintTransformer) new StandardGradientPaintTransformer();
        this.shapeOutlineVisible = num3 != 0;
        this.outlinePaint = outlinePaint;
        this.outlineStroke = outlineStroke;
        this.lineVisible = num4 != 0;
        this.line = line;
        this.lineStroke = lineStroke;
        this.linePaint = linePaint;
        this.toolTipText = toolTipText;
        this.urlText = urlText;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 22, (byte) 108, (byte) 137, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 176, (byte) 114, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 103, (byte) 104, (byte) 107, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(AttributedString label, string description, string toolTipText, string urlText, bool shapeVisible, Shape shape, bool shapeFilled, Paint fillPaint, bool shapeOutlineVisible, Paint outlinePaint, Stroke outlineStroke, bool lineVisible, Shape line, Stroke lineStroke, Paint linePaint)
    {
      int num1 = shapeVisible ? 1 : 0;
      int num2 = shapeFilled ? 1 : 0;
      int num3 = shapeOutlineVisible ? 1 : 0;
      int num4 = lineVisible ? 1 : 0;
      base.\u002Ector();
      LegendItem legendItem = this;
      if (label == null)
      {
        string str = "Null 'label' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (fillPaint == null)
      {
        string str = "Null 'fillPaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (lineStroke == null)
      {
        string str = "Null 'lineStroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (line == null)
      {
        string str = "Null 'line' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (linePaint == null)
      {
        string str = "Null 'linePaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (outlinePaint == null)
      {
        string str = "Null 'outlinePaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (outlineStroke == null)
      {
        string str = "Null 'outlineStroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.label = this.characterIteratorToString((CharacterIterator) label.getIterator());
        this.attributedLabel = label;
        this.description = description;
        this.shapeVisible = num1 != 0;
        this.shape = shape;
        this.shapeFilled = num2 != 0;
        this.fillPaint = fillPaint;
        this.fillPaintTransformer = (GradientPaintTransformer) new StandardGradientPaintTransformer();
        this.shapeOutlineVisible = num3 != 0;
        this.outlinePaint = outlinePaint;
        this.outlineStroke = outlineStroke;
        this.lineVisible = num4 != 0;
        this.line = line;
        this.lineStroke = lineStroke;
        this.linePaint = linePaint;
        this.toolTipText = toolTipText;
        this.urlText = urlText;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label)
      : this(label, (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 159, (byte) 255, (byte) 9, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label, string description, string toolTipText, string urlText, Shape shape, Paint fillPaint, Stroke outlineStroke, Paint outlinePaint)
      : this(label, description, toolTipText, urlText, true, shape, true, fillPaint, true, outlinePaint, outlineStroke, false, LegendItem.UNUSED_SHAPE, LegendItem.UNUSED_STROKE, (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 255, (byte) 12, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(string label, string description, string toolTipText, string urlText, Shape line, Stroke lineStroke, Paint linePaint)
      : this(label, description, toolTipText, urlText, false, LegendItem.UNUSED_SHAPE, false, (Paint) Color.black, false, (Paint) Color.black, LegendItem.UNUSED_STROKE, true, line, lineStroke, linePaint)
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 255, (byte) 15, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(AttributedString label, string description, string toolTipText, string urlText, Shape shape, Paint fillPaint)
      : this(label, description, toolTipText, urlText, true, shape, true, fillPaint, false, (Paint) Color.black, LegendItem.UNUSED_STROKE, false, LegendItem.UNUSED_SHAPE, LegendItem.UNUSED_STROKE, (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 255, (byte) 9, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(AttributedString label, string description, string toolTipText, string urlText, Shape shape, Paint fillPaint, Stroke outlineStroke, Paint outlinePaint)
      : this(label, description, toolTipText, urlText, true, shape, true, fillPaint, true, outlinePaint, outlineStroke, false, LegendItem.UNUSED_SHAPE, LegendItem.UNUSED_STROKE, (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 72, (byte) 255, (byte) 12, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendItem(AttributedString label, string description, string toolTipText, string urlText, Shape line, Stroke lineStroke, Paint linePaint)
      : this(label, description, toolTipText, urlText, false, LegendItem.UNUSED_SHAPE, false, (Paint) Color.black, false, (Paint) Color.black, LegendItem.UNUSED_STROKE, true, line, lineStroke, linePaint)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LegendItem obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LegendItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 162, (byte) 103, (byte) 103, (byte) 100, (byte) 100, (byte) 134, (byte) 103, (byte) 99, (byte) 104, (byte) 105, (byte) 102, (byte) 102, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string characterIteratorToString([In] CharacterIterator obj0)
    {
      int length = obj0.getEndIndex() - obj0.getBeginIndex();
      if (length <= 0)
        return "";
      char[] chArray = new char[length];
      int index1 = 0;
      for (int index2 = (int) obj0.first(); index2 != (int) ushort.MaxValue; index2 = (int) obj0.next())
      {
        chArray[index1] = (char) index2;
        ++index1;
      }
      return String.newhelper(chArray);
    }

    public virtual Dataset getDataset()
    {
      return this.dataset;
    }

    public virtual void setDataset(Dataset dataset)
    {
      this.dataset = dataset;
    }

    public virtual int getDatasetIndex()
    {
      return this.datasetIndex;
    }

    public virtual void setDatasetIndex(int index)
    {
      this.datasetIndex = index;
    }

    public virtual IComparable getSeriesKey()
    {
      return this.seriesKey;
    }

    public virtual void setSeriesKey(IComparable key)
    {
      this.seriesKey = key;
    }

    public virtual int getSeriesIndex()
    {
      return this.series;
    }

    public virtual void setSeriesIndex(int index)
    {
      this.series = index;
    }

    public virtual string getLabel()
    {
      return this.label;
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    public virtual void setLabelFont(Font font)
    {
      this.labelFont = font;
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    public virtual void setLabelPaint(Paint paint)
    {
      this.labelPaint = paint;
    }

    public virtual AttributedString getAttributedLabel()
    {
      return this.attributedLabel;
    }

    public virtual string getDescription()
    {
      return this.description;
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    public virtual string getURLText()
    {
      return this.urlText;
    }

    public virtual bool isShapeVisible()
    {
      return this.shapeVisible;
    }

    public virtual Shape getShape()
    {
      return this.shape;
    }

    public virtual bool isShapeFilled()
    {
      return this.shapeFilled;
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 154, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.fillPaint = paint;
    }

    public virtual bool isShapeOutlineVisible()
    {
      return this.shapeOutlineVisible;
    }

    public virtual Stroke getLineStroke()
    {
      return this.lineStroke;
    }

    public virtual Paint getLinePaint()
    {
      return this.linePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 196, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.linePaint = paint;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 219, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.outlinePaint = paint;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    public virtual bool isLineVisible()
    {
      return this.lineVisible;
    }

    public virtual Shape getLine()
    {
      return this.line;
    }

    public virtual GradientPaintTransformer getFillPaintTransformer()
    {
      return this.fillPaintTransformer;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 21, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaintTransformer(GradientPaintTransformer transformer)
    {
      if (transformer == null)
      {
        string str = "Null 'transformer' attribute.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.fillPaintTransformer = transformer;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 35, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 116, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LegendItem))
        return false;
      LegendItem legendItem = (LegendItem) obj;
      return this.datasetIndex == legendItem.datasetIndex && this.series == legendItem.series && (String.instancehelper_equals(this.label, (object) legendItem.label) && AttributedStringUtilities.equal(this.attributedLabel, legendItem.attributedLabel)) && (ObjectUtilities.equal((object) this.description, (object) legendItem.description) && this.shapeVisible == legendItem.shapeVisible && (ShapeUtilities.equal(this.shape, legendItem.shape) && this.shapeFilled == legendItem.shapeFilled)) && (PaintUtilities.equal(this.fillPaint, legendItem.fillPaint) && ObjectUtilities.equal((object) this.fillPaintTransformer, (object) legendItem.fillPaintTransformer) && (this.shapeOutlineVisible == legendItem.shapeOutlineVisible && Object.instancehelper_equals((object) this.outlineStroke, (object) legendItem.outlineStroke)) && PaintUtilities.equal(this.outlinePaint, legendItem.outlinePaint)) && ((this.lineVisible ? 0 : 1) != (legendItem.lineVisible ? 1 : 0) && ShapeUtilities.equal(this.line, legendItem.line) && (Object.instancehelper_equals((object) this.lineStroke, (object) legendItem.lineStroke) && PaintUtilities.equal(this.linePaint, legendItem.linePaint)) && (ObjectUtilities.equal((object) this.labelFont, (object) legendItem.labelFont) && PaintUtilities.equal(this.labelPaint, legendItem.labelPaint)));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 116, (byte) 108, (byte) 109, (byte) 108, (byte) 177, (byte) 113, (byte) 109, (byte) 108, (byte) 177, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      LegendItem legendItem = (LegendItem) base.clone();
      if (this.seriesKey is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.seriesKey;
        legendItem.seriesKey = (IComparable) publicCloneable.clone();
      }
      legendItem.shape = ShapeUtilities.clone(this.shape);
      if (this.fillPaintTransformer is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.fillPaintTransformer;
        legendItem.fillPaintTransformer = (GradientPaintTransformer) publicCloneable.clone();
      }
      legendItem.line = ShapeUtilities.clone(this.line);
      return (object) legendItem;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 140, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeAttributedString(this.attributedLabel, obj0);
      SerialUtilities.writeShape(this.shape, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeShape(this.line, obj0);
      SerialUtilities.writeStroke(this.lineStroke, obj0);
      SerialUtilities.writePaint(this.linePaint, obj0);
      SerialUtilities.writePaint(this.labelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 162, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.attributedLabel = SerialUtilities.readAttributedString(obj0);
      this.shape = SerialUtilities.readShape(obj0);
      this.fillPaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.line = SerialUtilities.readShape(obj0);
      this.lineStroke = SerialUtilities.readStroke(obj0);
      this.linePaint = SerialUtilities.readPaint(obj0);
      this.labelPaint = SerialUtilities.readPaint(obj0);
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
