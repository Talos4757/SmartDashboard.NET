// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.PeriodAxisLabelInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using java.lang.reflect;
using java.text;
using java.util;
using org.jfree.data.time;
using org.jfree.io;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class PeriodAxisLabelInfo : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal static RectangleInsets __\u003C\u003EDEFAULT_INSETS = new RectangleInsets(2.0, 2.0, 2.0, 2.0);
    internal static Font __\u003C\u003EDEFAULT_FONT = new Font("SansSerif", 0, 10);
    internal static Paint __\u003C\u003EDEFAULT_LABEL_PAINT = (Paint) Color.black;
    internal static Stroke __\u003C\u003EDEFAULT_DIVIDER_STROKE = (Stroke) new BasicStroke(0.5f);
    internal static Paint __\u003C\u003EDEFAULT_DIVIDER_PAINT = (Paint) Color.gray;
    private const long serialVersionUID = 5710451740920277357L;
    private Class periodClass;
    private RectangleInsets padding;
    private DateFormat dateFormat;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    private bool drawDividers;
    [NonSerialized]
    private Stroke dividerStroke;
    [NonSerialized]
    private Paint dividerPaint;
    internal static Class class\u0024java\u0024util\u0024Date;
    internal static Class class\u0024java\u0024util\u0024TimeZone;
    internal static Class class\u0024java\u0024util\u0024Locale;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static RectangleInsets DEFAULT_INSETS
    {
      [HideFromJava] get
      {
        return PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_INSETS;
      }
    }

    [Modifiers]
    public static Font DEFAULT_FONT
    {
      [HideFromJava] get
      {
        return PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_LABEL_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_DIVIDER_STROKE
    {
      [HideFromJava] get
      {
        return PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_DIVIDER_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_DIVIDER_PAINT
    {
      [HideFromJava] get
      {
        return PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_DIVIDER_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 223, (byte) 15, (byte) 210, (byte) 170, (byte) 175})]
    static PeriodAxisLabelInfo()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 103, (byte) 99, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 100, (byte) 176, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxisLabelInfo(Class periodClass, DateFormat dateFormat, RectangleInsets padding, Font labelFont, Paint labelPaint, bool drawDividers, Stroke dividerStroke, Paint dividerPaint)
    {
      int num = drawDividers ? 1 : 0;
      base.\u002Ector();
      PeriodAxisLabelInfo periodAxisLabelInfo = this;
      if (periodClass == null)
      {
        string str = "Null 'periodClass' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dateFormat == null)
      {
        string str = "Null 'dateFormat' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (labelFont == null)
      {
        string str = "Null 'labelFont' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (labelPaint == null)
      {
        string str = "Null 'labelPaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dividerStroke == null)
      {
        string str = "Null 'dividerStroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dividerPaint == null)
      {
        string str = "Null 'dividerPaint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.periodClass = periodClass;
        this.dateFormat = dateFormat;
        this.padding = padding;
        this.labelFont = labelFont;
        this.labelPaint = labelPaint;
        this.drawDividers = num != 0;
        this.dividerStroke = dividerStroke;
        this.dividerPaint = dividerPaint;
      }
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 255, (byte) 5, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxisLabelInfo(Class periodClass, DateFormat dateFormat)
      : this(periodClass, dateFormat, PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_INSETS, PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_FONT, PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_LABEL_PAINT, true, PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_DIVIDER_STROKE, PeriodAxisLabelInfo.__\u003C\u003EDEFAULT_DIVIDER_PAINT)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PeriodAxisLabelInfo([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PeriodAxisLabelInfo obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PeriodAxisLabelInfo obj0)
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

    public virtual Class getPeriodClass()
    {
      return this.periodClass;
    }

    public virtual DateFormat getDateFormat()
    {
      return this.dateFormat;
    }

    public virtual RectangleInsets getPadding()
    {
      return this.padding;
    }

    public virtual bool getDrawDividers()
    {
      return this.drawDividers;
    }

    public virtual Stroke getDividerStroke()
    {
      return this.dividerStroke;
    }

    public virtual Paint getDividerPaint()
    {
      return this.dividerPaint;
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 130, (byte) 159, (byte) 91, (byte) 255, (byte) 25, (byte) 69, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod createInstance(Date millisecond, TimeZone zone, Locale locale)
    {
      RegularTimePeriod regularTimePeriod = (RegularTimePeriod) null;
      try
      {
        Class class1 = this.periodClass;
        Class[] classArray = new Class[3];
        int index1 = 0;
        Class class2 = PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Date != null ? PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Date : (PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Date = PeriodAxisLabelInfo.class\u0024("java.util.Date"));
        classArray[index1] = class2;
        int index2 = 1;
        Class class3 = PeriodAxisLabelInfo.class\u0024java\u0024util\u0024TimeZone != null ? PeriodAxisLabelInfo.class\u0024java\u0024util\u0024TimeZone : (PeriodAxisLabelInfo.class\u0024java\u0024util\u0024TimeZone = PeriodAxisLabelInfo.class\u0024("java.util.TimeZone"));
        classArray[index2] = class3;
        int index3 = 2;
        Class class4 = PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Locale != null ? PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Locale : (PeriodAxisLabelInfo.class\u0024java\u0024util\u0024Locale = PeriodAxisLabelInfo.class\u0024("java.util.Locale"));
        classArray[index3] = class4;
        CallerID callerId1 = PeriodAxisLabelInfo.__\u003CGetCallerID\u003E();
        Constructor declaredConstructor = class1.getDeclaredConstructor(classArray, callerId1);
        object[] objArray = new object[3];
        int index4 = 0;
        Date date = millisecond;
        objArray[index4] = (object) date;
        int index5 = 1;
        TimeZone timeZone = zone;
        objArray[index5] = (object) timeZone;
        int index6 = 2;
        Locale locale1 = locale;
        objArray[index6] = (object) locale1;
        CallerID callerId2 = PeriodAxisLabelInfo.__\u003CGetCallerID\u003E();
        regularTimePeriod = (RegularTimePeriod) declaredConstructor.newInstance(objArray, callerId2);
        goto label_5;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
label_5:
      return regularTimePeriod;
    }

    [LineNumberTable((ushort) 295)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, PeriodAxisLabelInfo.__\u003CGetCallerID\u003E());
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

    [Obsolete]
    [LineNumberTable((ushort) 275)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod createInstance(Date millisecond, TimeZone zone)
    {
      return this.createInstance(millisecond, zone, Locale.getDefault());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 100, (byte) 130, (byte) 107, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PeriodAxisLabelInfo))
        return false;
      PeriodAxisLabelInfo periodAxisLabelInfo = (PeriodAxisLabelInfo) obj;
      return Object.instancehelper_equals((object) periodAxisLabelInfo.periodClass, (object) this.periodClass) && periodAxisLabelInfo.dateFormat.equals((object) this.dateFormat) && (periodAxisLabelInfo.padding.equals((object) this.padding) && periodAxisLabelInfo.labelFont.equals((object) this.labelFont)) && (Object.instancehelper_equals((object) periodAxisLabelInfo.labelPaint, (object) this.labelPaint) && periodAxisLabelInfo.drawDividers == this.drawDividers && (Object.instancehelper_equals((object) periodAxisLabelInfo.dividerStroke, (object) this.dividerStroke) && Object.instancehelper_equals((object) periodAxisLabelInfo.dividerPaint, (object) this.dividerPaint)));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 99, (byte) 111, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num = 37 * Object.instancehelper_hashCode((object) this.periodClass);
      return 37 * this.dateFormat.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 253, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (PeriodAxisLabelInfo) base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.labelPaint, obj0);
      SerialUtilities.writeStroke(this.dividerStroke, obj0);
      SerialUtilities.writePaint(this.dividerPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.dividerStroke = SerialUtilities.readStroke(obj0);
      this.dividerPaint = SerialUtilities.readPaint(obj0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PeriodAxisLabelInfo.__\u003CcallerID\u003E == null)
        PeriodAxisLabelInfo.__\u003CcallerID\u003E = (CallerID) new PeriodAxisLabelInfo.__\u003CCallerID\u003E();
      return PeriodAxisLabelInfo.__\u003CcallerID\u003E;
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
