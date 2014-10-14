// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.ChartEntity
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
using org.jfree.chart;
using org.jfree.chart.imagemap;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class ChartEntity : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -4445994133561919083L;
    [NonSerialized]
    private Shape area;
    private string toolTipText;
    private string urlText;

    [LineNumberTable(new byte[] {(byte) 88, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartEntity(Shape area, string toolTipText, string urlText)
    {
      base.\u002Ector();
      ChartEntity chartEntity = this;
      if (area == null)
      {
        string str = "Null 'area' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.area = area;
        this.toolTipText = toolTipText;
        this.urlText = urlText;
      }
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartEntity(Shape area, string toolTipText)
      : this(area, toolTipText, (string) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartEntity(Shape area)
      : this(area, (string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ChartEntity obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ChartEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 99, (byte) 144, (byte) 108, (byte) 108, (byte) 110, (byte) 142, (byte) 100, (byte) 132, (byte) 100, (byte) 164})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getRectCoords([In] Rectangle2D obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'rectangle' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = ByteCodeHelper.d2i(((RectangularShape) obj0).getX());
        int num2 = ByteCodeHelper.d2i(((RectangularShape) obj0).getY());
        int num3 = num1 + ByteCodeHelper.d2i(((RectangularShape) obj0).getWidth());
        int num4 = num2 + ByteCodeHelper.d2i(((RectangularShape) obj0).getHeight());
        if (num3 == num1)
          ++num3;
        if (num4 == num2)
          ++num4;
        return new StringBuffer().append(num1).append(",").append(num2).append(",").append(num3).append(",").append(num4).toString();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 99, (byte) 144, (byte) 102, (byte) 98, (byte) 103, (byte) 109, (byte) 107, (byte) 104, (byte) 99, (byte) 98, (byte) 111, (byte) 187, (byte) 108, (byte) 111, (byte) 108, (byte) 143, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getPolyCoords([In] Shape obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        StringBuffer stringBuffer = new StringBuffer();
        int num = 1;
        float[] numArray = new float[6];
        PathIterator pathIterator = obj0.getPathIterator((AffineTransform) null, 1.0);
        while (!pathIterator.isDone())
        {
          pathIterator.currentSegment(numArray);
          if (num != 0)
          {
            num = 0;
            stringBuffer.append(ByteCodeHelper.f2i(numArray[0]));
            stringBuffer.append(",").append(ByteCodeHelper.f2i(numArray[1]));
          }
          else
          {
            stringBuffer.append(",");
            stringBuffer.append(ByteCodeHelper.f2i(numArray[0]));
            stringBuffer.append(",");
            stringBuffer.append(ByteCodeHelper.f2i(numArray[1]));
          }
          pathIterator.next();
        }
        return stringBuffer.toString();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 109, (byte) 166})]
    public virtual string getShapeType()
    {
      return this.area is Rectangle2D ? "rect" : "poly";
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 109, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getShapeCoords()
    {
      if (this.area is Rectangle2D)
        return this.getRectCoords((Rectangle2D) this.area);
      else
        return this.getPolyCoords(this.area);
    }

    public virtual Shape getArea()
    {
      return this.area;
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setArea(Shape area)
    {
      if (area == null)
      {
        string str = "Null 'area' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.area = area;
    }

    public virtual void setToolTipText(string text)
    {
      this.toolTipText = text;
    }

    public virtual string getURLText()
    {
      return this.urlText;
    }

    public virtual void setURLText(string text)
    {
      this.urlText = text;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 102, (byte) 159, (byte) 3, (byte) 159, (byte) 3, (byte) 105, (byte) 159, (byte) 48, (byte) 99, (byte) 179, (byte) 99, (byte) 213, (byte) 204, (byte) 99, (byte) 140, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getImageMapAreaTag(ToolTipTagFragmentGenerator toolTipTagFragmentGenerator, URLTagFragmentGenerator urlTagFragmentGenerator)
    {
      StringBuffer stringBuffer = new StringBuffer();
      int num1 = this.urlText != null ? (String.instancehelper_equals(this.urlText, (object) "") ? 0 : 1) : 0;
      int num2 = this.toolTipText != null ? (String.instancehelper_equals(this.toolTipText, (object) "") ? 0 : 1) : 0;
      if (num1 != 0 || num2 != 0)
      {
        stringBuffer.append(new StringBuffer().append("<area shape=\"").append(this.getShapeType()).append("\"").append(" coords=\"").append(this.getShapeCoords()).append("\"").toString());
        if (num2 != 0)
          stringBuffer.append(toolTipTagFragmentGenerator.generateToolTipFragment(this.toolTipText));
        if (num1 != 0)
          stringBuffer.append(urlTagFragmentGenerator.generateURLFragment(this.urlText));
        else
          stringBuffer.append(" nohref=\"nohref\"");
        if (num2 == 0)
          stringBuffer.append(" alt=\"\"");
        stringBuffer.append("/>");
      }
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 107, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer("ChartEntity: ");
      stringBuffer.append("tooltip = ");
      stringBuffer.append(this.toolTipText);
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ChartEntity))
        return false;
      ChartEntity chartEntity = (ChartEntity) obj;
      return Object.instancehelper_equals((object) this.area, (object) chartEntity.area) && ObjectUtilities.equal((object) this.toolTipText, (object) chartEntity.toolTipText) && ObjectUtilities.equal((object) this.urlText, (object) chartEntity.urlText);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 99, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(37, this.toolTipText), this.urlText);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 410)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 51, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.area, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.area = SerialUtilities.readShape(obj0);
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
