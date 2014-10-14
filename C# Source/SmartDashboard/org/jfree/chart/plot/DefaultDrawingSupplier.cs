// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.DefaultDrawingSupplier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.plot.DrawingSupplier", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultDrawingSupplier : Object, DrawingSupplier, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal static Paint[] __\u003C\u003EDEFAULT_PAINT_SEQUENCE = ChartColor.createDefaultPaintArray();
    private const long serialVersionUID = -7339847061039422538L;
    internal static Paint[] __\u003C\u003EDEFAULT_OUTLINE_PAINT_SEQUENCE;
    internal static Paint[] __\u003C\u003EDEFAULT_FILL_PAINT_SEQUENCE;
    internal static Stroke[] __\u003C\u003EDEFAULT_STROKE_SEQUENCE;
    internal static Stroke[] __\u003C\u003EDEFAULT_OUTLINE_STROKE_SEQUENCE;
    internal static Shape[] __\u003C\u003EDEFAULT_SHAPE_SEQUENCE;
    [NonSerialized]
    private Paint[] paintSequence;
    private int paintIndex;
    [NonSerialized]
    private Paint[] outlinePaintSequence;
    private int outlinePaintIndex;
    [NonSerialized]
    private Paint[] fillPaintSequence;
    private int fillPaintIndex;
    [NonSerialized]
    private Stroke[] strokeSequence;
    private int strokeIndex;
    [NonSerialized]
    private Stroke[] outlineStrokeSequence;
    private int outlineStrokeIndex;
    [NonSerialized]
    private Shape[] shapeSequence;
    private int shapeIndex;

    [Modifiers]
    public static Paint[] DEFAULT_PAINT_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_PAINT_SEQUENCE;
      }
    }

    [Modifiers]
    public static Paint[] DEFAULT_OUTLINE_PAINT_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_PAINT_SEQUENCE;
      }
    }

    [Modifiers]
    public static Paint[] DEFAULT_FILL_PAINT_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_FILL_PAINT_SEQUENCE;
      }
    }

    [Modifiers]
    public static Stroke[] DEFAULT_STROKE_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_STROKE_SEQUENCE;
      }
    }

    [Modifiers]
    public static Stroke[] DEFAULT_OUTLINE_STROKE_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_STROKE_SEQUENCE;
      }
    }

    [Modifiers]
    public static Shape[] DEFAULT_SHAPE_SEQUENCE
    {
      [HideFromJava] get
      {
        return DefaultDrawingSupplier.__\u003C\u003EDEFAULT_SHAPE_SEQUENCE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 202, (byte) 211, (byte) 211, (byte) 250, (byte) 69, (byte) 250, (byte) 69})]
    static DefaultDrawingSupplier()
    {
      Paint[] paintArray1 = new Paint[1];
      int index1 = 0;
      // ISSUE: variable of the null type
      __Null local1 = Color.lightGray;
      paintArray1[index1] = (Paint) local1;
      DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_PAINT_SEQUENCE = paintArray1;
      Paint[] paintArray2 = new Paint[1];
      int index2 = 0;
      // ISSUE: variable of the null type
      __Null local2 = Color.white;
      paintArray2[index2] = (Paint) local2;
      DefaultDrawingSupplier.__\u003C\u003EDEFAULT_FILL_PAINT_SEQUENCE = paintArray2;
      Stroke[] strokeArray1 = new Stroke[1];
      int index3 = 0;
      BasicStroke basicStroke1 = new BasicStroke(1f, 2, 2);
      strokeArray1[index3] = (Stroke) basicStroke1;
      DefaultDrawingSupplier.__\u003C\u003EDEFAULT_STROKE_SEQUENCE = strokeArray1;
      Stroke[] strokeArray2 = new Stroke[1];
      int index4 = 0;
      BasicStroke basicStroke2 = new BasicStroke(1f, 2, 2);
      strokeArray2[index4] = (Stroke) basicStroke2;
      DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_STROKE_SEQUENCE = strokeArray2;
      DefaultDrawingSupplier.__\u003C\u003EDEFAULT_SHAPE_SEQUENCE = DefaultDrawingSupplier.createStandardSeriesShapes();
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 136, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultDrawingSupplier(Paint[] paintSequence, Paint[] outlinePaintSequence, Stroke[] strokeSequence, Stroke[] outlineStrokeSequence, Shape[] shapeSequence)
    {
      base.\u002Ector();
      DefaultDrawingSupplier defaultDrawingSupplier = this;
      this.paintSequence = paintSequence;
      this.fillPaintSequence = DefaultDrawingSupplier.__\u003C\u003EDEFAULT_FILL_PAINT_SEQUENCE;
      this.outlinePaintSequence = outlinePaintSequence;
      this.strokeSequence = strokeSequence;
      this.outlineStrokeSequence = outlineStrokeSequence;
      this.shapeSequence = shapeSequence;
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 255, (byte) 7, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultDrawingSupplier()
      : this(DefaultDrawingSupplier.__\u003C\u003EDEFAULT_PAINT_SEQUENCE, DefaultDrawingSupplier.__\u003C\u003EDEFAULT_FILL_PAINT_SEQUENCE, DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_PAINT_SEQUENCE, DefaultDrawingSupplier.__\u003C\u003EDEFAULT_STROKE_SEQUENCE, DefaultDrawingSupplier.__\u003C\u003EDEFAULT_OUTLINE_STROKE_SEQUENCE, DefaultDrawingSupplier.__\u003C\u003EDEFAULT_SHAPE_SEQUENCE)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 136, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultDrawingSupplier(Paint[] paintSequence, Paint[] fillPaintSequence, Paint[] outlinePaintSequence, Stroke[] strokeSequence, Stroke[] outlineStrokeSequence, Shape[] shapeSequence)
    {
      base.\u002Ector();
      DefaultDrawingSupplier defaultDrawingSupplier = this;
      this.paintSequence = paintSequence;
      this.fillPaintSequence = fillPaintSequence;
      this.outlinePaintSequence = outlinePaintSequence;
      this.strokeSequence = strokeSequence;
      this.outlineStrokeSequence = outlineStrokeSequence;
      this.shapeSequence = shapeSequence;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultDrawingSupplier([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultDrawingSupplier obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultDrawingSupplier obj0)
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

    [LineNumberTable((ushort) 516)]
    private static int[] intArray([In] double obj0, [In] double obj1, [In] double obj2)
    {
      int[] numArray = new int[3];
      int index1 = 0;
      int num1 = ByteCodeHelper.d2i(obj0);
      numArray[index1] = num1;
      int index2 = 1;
      int num2 = ByteCodeHelper.d2i(obj1);
      numArray[index2] = num2;
      int index3 = 2;
      int num3 = ByteCodeHelper.d2i(obj2);
      numArray[index3] = num3;
      return numArray;
    }

    [LineNumberTable((ushort) 531)]
    private static int[] intArray([In] double obj0, [In] double obj1, [In] double obj2, [In] double obj3)
    {
      int[] numArray = new int[4];
      int index1 = 0;
      int num1 = ByteCodeHelper.d2i(obj0);
      numArray[index1] = num1;
      int index2 = 1;
      int num2 = ByteCodeHelper.d2i(obj1);
      numArray[index2] = num2;
      int index3 = 2;
      int num3 = ByteCodeHelper.d2i(obj2);
      numArray[index3] = num3;
      int index4 = 3;
      int num4 = ByteCodeHelper.d2i(obj3);
      numArray[index4] = num4;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 32, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 102, (byte) 130, (byte) 103, (byte) 109, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool equalShapes([In] Shape[] obj0, [In] Shape[] obj1)
    {
      if (obj0 == null)
      {
        return obj1 == null;
      }
      else
      {
        if (obj1 == null || obj0.Length != obj1.Length)
          return false;
        for (int index = 0; index < obj0.Length; ++index)
        {
          if (!ShapeUtilities.equal(obj0[index], obj1[index]))
            return false;
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 136, (byte) 106, (byte) 109, (byte) 98, (byte) 162, (byte) 142, (byte) 174, (byte) 110, (byte) 107, (byte) 172, (byte) 115, (byte) 116, (byte) 172, (byte) 191, (byte) 3, (byte) 110, (byte) 108, (byte) 172, (byte) 191, (byte) 3, (byte) 107, (byte) 111, (byte) 172, (byte) 191, (byte) 3, (byte) 106, (byte) 111, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape[] createStandardSeriesShapes()
    {
      Shape[] shapeArray = new Shape[10];
      double num1 = 6.0;
      double num2 = num1 / 2.0;
      shapeArray[0] = (Shape) new Rectangle2D.Double(-num2, -num2, num1, num1);
      shapeArray[1] = (Shape) new Ellipse2D.Double(-num2, -num2, num1, num1);
      int[] numArray1 = DefaultDrawingSupplier.intArray(0.0, num2, -num2);
      int[] numArray2 = DefaultDrawingSupplier.intArray(-num2, num2, num2);
      shapeArray[2] = (Shape) new Polygon(numArray1, numArray2, 3);
      int[] numArray3 = DefaultDrawingSupplier.intArray(0.0, num2, 0.0, -num2);
      int[] numArray4 = DefaultDrawingSupplier.intArray(-num2, 0.0, num2, 0.0);
      shapeArray[3] = (Shape) new Polygon(numArray3, numArray4, 4);
      shapeArray[4] = (Shape) new Rectangle2D.Double(-num2, -num2 / 2.0, num1, num1 / 2.0);
      int[] numArray5 = DefaultDrawingSupplier.intArray(-num2, num2, 0.0);
      int[] numArray6 = DefaultDrawingSupplier.intArray(-num2, -num2, num2);
      shapeArray[5] = (Shape) new Polygon(numArray5, numArray6, 3);
      shapeArray[6] = (Shape) new Ellipse2D.Double(-num2, -num2 / 2.0, num1, num1 / 2.0);
      int[] numArray7 = DefaultDrawingSupplier.intArray(-num2, num2, -num2);
      int[] numArray8 = DefaultDrawingSupplier.intArray(-num2, 0.0, num2);
      shapeArray[7] = (Shape) new Polygon(numArray7, numArray8, 3);
      shapeArray[8] = (Shape) new Rectangle2D.Double(-num2 / 2.0, -num2, num1 / 2.0, num1);
      int[] numArray9 = DefaultDrawingSupplier.intArray(-num2, num2, num2);
      int[] numArray10 = DefaultDrawingSupplier.intArray(0.0, -num2, num2);
      shapeArray[9] = (Shape) new Polygon(numArray9, numArray10, 3);
      return shapeArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Paint getNextPaint()
    {
      Paint[] paintArray = this.paintSequence;
      int num1 = this.paintIndex;
      int length = this.paintSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Paint paint = paintArray[index];
      ++this.paintIndex;
      return paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Paint getNextOutlinePaint()
    {
      Paint[] paintArray = this.outlinePaintSequence;
      int num1 = this.outlinePaintIndex;
      int length = this.outlinePaintSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Paint paint = paintArray[index];
      ++this.outlinePaintIndex;
      return paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Paint getNextFillPaint()
    {
      Paint[] paintArray = this.fillPaintSequence;
      int num1 = this.fillPaintIndex;
      int length = this.fillPaintSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Paint paint = paintArray[index];
      ++this.fillPaintIndex;
      return paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Stroke getNextStroke()
    {
      Stroke[] strokeArray = this.strokeSequence;
      int num1 = this.strokeIndex;
      int length = this.strokeSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Stroke stroke = strokeArray[index];
      ++this.strokeIndex;
      return stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Stroke getNextOutlineStroke()
    {
      Stroke[] strokeArray = this.outlineStrokeSequence;
      int num1 = this.outlineStrokeIndex;
      int length = this.outlineStrokeSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Stroke stroke = strokeArray[index];
      ++this.outlineStrokeIndex;
      return stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 159, (byte) 0, (byte) 110})]
    public virtual Shape getNextShape()
    {
      Shape[] shapeArray = this.shapeSequence;
      int num1 = this.shapeIndex;
      int length = this.shapeSequence.Length;
      int num2 = -1;
      int index = length != num2 ? num1 % length : 0;
      Shape shape = shapeArray[index];
      ++this.shapeIndex;
      return shape;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 100, (byte) 162, (byte) 104, (byte) 162, (byte) 135, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 116, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultDrawingSupplier))
        return false;
      DefaultDrawingSupplier defaultDrawingSupplier = (DefaultDrawingSupplier) obj;
      return Arrays.equals((object[]) this.paintSequence, (object[]) defaultDrawingSupplier.paintSequence) && this.paintIndex == defaultDrawingSupplier.paintIndex && (Arrays.equals((object[]) this.outlinePaintSequence, (object[]) defaultDrawingSupplier.outlinePaintSequence) && this.outlinePaintIndex == defaultDrawingSupplier.outlinePaintIndex) && (Arrays.equals((object[]) this.strokeSequence, (object[]) defaultDrawingSupplier.strokeSequence) && this.strokeIndex == defaultDrawingSupplier.strokeIndex && (Arrays.equals((object[]) this.outlineStrokeSequence, (object[]) defaultDrawingSupplier.outlineStrokeSequence) && this.outlineStrokeIndex == defaultDrawingSupplier.outlineStrokeIndex)) && (this.equalShapes(this.shapeSequence, defaultDrawingSupplier.shapeSequence) && this.shapeIndex == defaultDrawingSupplier.shapeIndex);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 57, (byte) 134, (byte) 104, (byte) 103, (byte) 102, (byte) 46, (byte) 198, (byte) 104, (byte) 103, (byte) 102, (byte) 46, (byte) 198, (byte) 104, (byte) 103, (byte) 102, (byte) 46, (byte) 198, (byte) 104, (byte) 103, (byte) 104, (byte) 47, (byte) 200, (byte) 105, (byte) 104, (byte) 105, (byte) 47, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int length1 = this.paintSequence.Length;
      obj0.writeInt(length1);
      for (int index = 0; index < length1; ++index)
        SerialUtilities.writePaint(this.paintSequence[index], obj0);
      int length2 = this.outlinePaintSequence.Length;
      obj0.writeInt(length2);
      for (int index = 0; index < length2; ++index)
        SerialUtilities.writePaint(this.outlinePaintSequence[index], obj0);
      int length3 = this.strokeSequence.Length;
      obj0.writeInt(length3);
      for (int index = 0; index < length3; ++index)
        SerialUtilities.writeStroke(this.strokeSequence[index], obj0);
      int length4 = this.outlineStrokeSequence.Length;
      obj0.writeInt(length4);
      for (int index = 0; index < length4; ++index)
        SerialUtilities.writeStroke(this.outlineStrokeSequence[index], obj0);
      int length5 = this.shapeSequence.Length;
      obj0.writeInt(length5);
      for (int index = 0; index < length5; ++index)
        SerialUtilities.writeShape(this.shapeSequence[index], obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 134, (byte) 103, (byte) 108, (byte) 102, (byte) 46, (byte) 198, (byte) 103, (byte) 108, (byte) 102, (byte) 46, (byte) 198, (byte) 103, (byte) 108, (byte) 102, (byte) 46, (byte) 198, (byte) 103, (byte) 108, (byte) 104, (byte) 47, (byte) 200, (byte) 104, (byte) 109, (byte) 105, (byte) 47, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      int length1 = obj0.readInt();
      this.paintSequence = new Paint[length1];
      for (int index = 0; index < length1; ++index)
        this.paintSequence[index] = SerialUtilities.readPaint(obj0);
      int length2 = obj0.readInt();
      this.outlinePaintSequence = new Paint[length2];
      for (int index = 0; index < length2; ++index)
        this.outlinePaintSequence[index] = SerialUtilities.readPaint(obj0);
      int length3 = obj0.readInt();
      this.strokeSequence = new Stroke[length3];
      for (int index = 0; index < length3; ++index)
        this.strokeSequence[index] = SerialUtilities.readStroke(obj0);
      int length4 = obj0.readInt();
      this.outlineStrokeSequence = new Stroke[length4];
      for (int index = 0; index < length4; ++index)
        this.outlineStrokeSequence[index] = SerialUtilities.readStroke(obj0);
      int length5 = obj0.readInt();
      this.shapeSequence = new Shape[length5];
      for (int index = 0; index < length5; ++index)
        this.shapeSequence[index] = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (DefaultDrawingSupplier) base.clone();
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
