// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.DateTitle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.text;
using java.util;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class DateTitle : TextTitle, Serializable.__Interface
  {
    private const long serialVersionUID = -465434812763159881L;

    [HideFromJava]
    static DateTitle()
    {
      TextTitle.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 159, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTitle(int style)
      : this(style, Locale.getDefault(), new Font("Dialog", 0, 12), (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 191, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTitle(int style, Locale locale, Font font, Paint paint)
      : this(style, locale, font, paint, RectangleEdge.__\u003C\u003EBOTTOM, HorizontalAlignment.__\u003C\u003ERIGHT, VerticalAlignment.__\u003C\u003ECENTER, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 191, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTitle(int style, Locale locale, Font font, Paint paint, RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment, RectangleInsets padding)
      : base(DateFormat.getDateInstance(style, locale).format(new Date()), font, paint, position, horizontalAlignment, verticalAlignment, padding)
    {
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTitle()
      : this(1)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DateTitle obj0)
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

    [LineNumberTable(new byte[] {(byte) 125, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDateFormat(int style, Locale locale)
    {
      this.setText(DateFormat.getDateInstance(style, locale).format(new Date()));
    }
  }
}
