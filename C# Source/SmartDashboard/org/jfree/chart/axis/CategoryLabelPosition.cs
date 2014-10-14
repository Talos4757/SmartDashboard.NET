// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryLabelPosition
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.text;
using org.jfree.ui;
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
  public class CategoryLabelPosition : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5168681143844183864L;
    private RectangleAnchor categoryAnchor;
    private TextBlockAnchor labelAnchor;
    private TextAnchor rotationAnchor;
    private double angle;
    private CategoryLabelWidthType widthType;
    private float widthRatio;

    [LineNumberTable(new byte[] {(byte) 97, (byte) 136, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 100, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 106, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPosition(RectangleAnchor categoryAnchor, TextBlockAnchor labelAnchor, TextAnchor rotationAnchor, double angle, CategoryLabelWidthType widthType, float widthRatio)
    {
      base.\u002Ector();
      CategoryLabelPosition categoryLabelPosition = this;
      if (categoryAnchor == null)
      {
        string str = "Null 'categoryAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (labelAnchor == null)
      {
        string str = "Null 'labelAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rotationAnchor == null)
      {
        string str = "Null 'rotationAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (widthType == null)
      {
        string str = "Null 'widthType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.categoryAnchor = categoryAnchor;
        this.labelAnchor = labelAnchor;
        this.rotationAnchor = rotationAnchor;
        this.angle = angle;
        this.widthType = widthType;
        this.widthRatio = widthRatio;
      }
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 159, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPosition()
      : this(RectangleAnchor.__\u003C\u003ECENTER, TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.95f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPosition(RectangleAnchor categoryAnchor, TextBlockAnchor labelAnchor)
      : this(categoryAnchor, labelAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.95f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPosition(RectangleAnchor categoryAnchor, TextBlockAnchor labelAnchor, CategoryLabelWidthType widthType, float widthRatio)
      : this(categoryAnchor, labelAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0, widthType, widthRatio)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryLabelPosition([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryLabelPosition obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual RectangleAnchor getCategoryAnchor()
    {
      return this.categoryAnchor;
    }

    public virtual TextBlockAnchor getLabelAnchor()
    {
      return this.labelAnchor;
    }

    public virtual double getAngle()
    {
      return this.angle;
    }

    public virtual float getWidthRatio()
    {
      return this.widthRatio;
    }

    public virtual CategoryLabelWidthType getWidthType()
    {
      return this.widthType;
    }

    public virtual TextAnchor getRotationAnchor()
    {
      return this.rotationAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryLabelPosition))
        return false;
      CategoryLabelPosition categoryLabelPosition = (CategoryLabelPosition) obj;
      return this.categoryAnchor.equals((object) categoryLabelPosition.categoryAnchor) && this.labelAnchor.equals((object) categoryLabelPosition.labelAnchor) && (this.rotationAnchor.equals((object) categoryLabelPosition.rotationAnchor) && this.angle == categoryLabelPosition.angle) && (this.widthType == categoryLabelPosition.widthType && (double) this.widthRatio == (double) categoryLabelPosition.widthRatio);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 113, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * 19 + this.categoryAnchor.hashCode()) + this.labelAnchor.hashCode()) + this.rotationAnchor.hashCode();
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
