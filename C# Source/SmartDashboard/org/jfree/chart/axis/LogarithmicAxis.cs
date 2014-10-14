// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.LogarithmicAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class LogarithmicAxis : NumberAxis
  {
    private const long serialVersionUID = 2502918599004103054L;
    internal static double __\u003C\u003ELOG10_VALUE;
    public const double SMALL_LOG_VALUE = 1E-100;
    protected internal bool allowNegativesFlag;
    protected internal bool strictValuesFlag;
    internal NumberFormat __\u003C\u003EnumberFormatterObj;
    protected internal bool expTickLabelsFlag;
    protected internal bool log10TickLabelsFlag;
    protected internal bool autoRangeNextLogFlag;
    protected internal bool smallLogFlag;

    [Modifiers]
    public static double LOG10_VALUE
    {
      [HideFromJava] get
      {
        return LogarithmicAxis.__\u003C\u003ELOG10_VALUE;
      }
    }

    [Modifiers]
    protected internal NumberFormat numberFormatterObj
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EnumberFormatterObj;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EnumberFormatterObj = value;
      }
    }

    [LineNumberTable((ushort) 118)]
    static LogarithmicAxis()
    {
      NumberAxis.__\u003Cclinit\u003E();
      LogarithmicAxis.__\u003C\u003ELOG10_VALUE = Math.log(10.0);
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 233, (byte) 34, (byte) 231, (byte) 70, (byte) 167, (byte) 203, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 73, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogarithmicAxis(string label)
      : base(label)
    {
      LogarithmicAxis logarithmicAxis = this;
      this.allowNegativesFlag = false;
      this.strictValuesFlag = true;
      this.__\u003C\u003EnumberFormatterObj = NumberFormat.getInstance();
      this.expTickLabelsFlag = false;
      this.log10TickLabelsFlag = false;
      this.autoRangeNextLogFlag = false;
      this.smallLogFlag = false;
      this.setupNumberFmtObj();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LogarithmicAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 173, (byte) 191, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setupNumberFmtObj()
    {
      if (!(this.__\u003C\u003EnumberFormatterObj is DecimalFormat))
        return;
      ((DecimalFormat) this.__\u003C\u003EnumberFormatterObj).applyPattern(!this.expTickLabelsFlag ? "0.###" : "0E0");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 109, (byte) 159, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setupSmallLogFlag()
    {
      double lowerBound = this.getRange().getLowerBound();
      this.smallLogFlag = !this.allowNegativesFlag && lowerBound < 10.0 && lowerBound > 0.0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 106, (byte) 99, (byte) 133, (byte) 109, (byte) 188, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double adjustedLog10(double val)
    {
      int num1 = val < 0.0 ? 1 : 0;
      if (num1 != 0)
        val = -val;
      if (val < 10.0)
        val += (10.0 - val) / 10.0;
      double num2 = Math.log(val) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE;
      if (num1 != 0)
        return -num2;
      else
        return num2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 106, (byte) 99, (byte) 165, (byte) 105, (byte) 191, (byte) 15, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double adjustedPow10(double val)
    {
      int num1 = val < 0.0 ? 1 : 0;
      if (num1 != 0)
        val = -val;
      double num2 = val >= 1.0 ? Math.pow(10.0, val) : (Math.pow(10.0, val + 1.0) - 10.0) / 9.0;
      if (num1 != 0)
        return -num2;
      else
        return num2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 139, (byte) 141, (byte) 111, (byte) 104, (byte) 150, (byte) 141, (byte) 144, (byte) 137, (byte) 213, (byte) 235, (byte) 69, (byte) 137, (byte) 111, (byte) 104, (byte) 211, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double computeLogFloor(double lower)
    {
      return !this.allowNegativesFlag ? (lower <= 0.0 ? Math.floor(lower) : Math.pow(10.0, Math.floor(Math.log(lower) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE))) : (lower <= 10.0 ? (lower >= -10.0 ? Math.floor(lower) : -Math.pow(10.0, -Math.floor(-(Math.log(-lower) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE)))) : Math.pow(10.0, Math.floor(Math.log(lower) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 139, (byte) 173, (byte) 111, (byte) 104, (byte) 150, (byte) 173, (byte) 144, (byte) 137, (byte) 213, (byte) 235, (byte) 69, (byte) 169, (byte) 111, (byte) 104, (byte) 211, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double computeLogCeil(double upper)
    {
      return !this.allowNegativesFlag ? (upper <= 0.0 ? Math.ceil(upper) : Math.pow(10.0, Math.ceil(Math.log(upper) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE))) : (upper <= 10.0 ? (upper >= -10.0 ? Math.ceil(upper) : -Math.pow(10.0, -Math.ceil(-(Math.log(-upper) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE)))) : Math.pow(10.0, Math.ceil(Math.log(upper) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE)));
    }

    [LineNumberTable((ushort) 321)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double switchedLog10(double val)
    {
      return !this.smallLogFlag ? this.adjustedLog10(val) : Math.log(val) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE;
    }

    [LineNumberTable((ushort) 340)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double switchedPow10(double val)
    {
      return !this.smallLogFlag ? this.adjustedPow10(val) : Math.pow(10.0, val);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(Range range)
    {
      base.setRange(range);
      this.setupSmallLogFlag();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 131, (byte) 130, (byte) 171, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string makeTickLabel(double val, bool forceFmtFlag)
    {
      if (this.expTickLabelsFlag || forceFmtFlag)
        return String.instancehelper_toLowerCase(this.__\u003C\u003EnumberFormatterObj.format(val));
      else
        return this.getTickUnit().valueToString(val);
    }

    [LineNumberTable((ushort) 1085)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string makeTickLabel(double val)
    {
      return this.makeTickLabel(val, false);
    }

    public virtual void setAllowNegativesFlag(bool flgVal)
    {
      this.allowNegativesFlag = flgVal;
    }

    public virtual bool getAllowNegativesFlag()
    {
      return this.allowNegativesFlag;
    }

    public virtual void setStrictValuesFlag(bool flgVal)
    {
      this.strictValuesFlag = flgVal;
    }

    public virtual bool getStrictValuesFlag()
    {
      return this.strictValuesFlag;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 89, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExpTickLabelsFlag(bool flgVal)
    {
      this.expTickLabelsFlag = flgVal;
      this.setupNumberFmtObj();
    }

    public virtual bool getExpTickLabelsFlag()
    {
      return this.expTickLabelsFlag;
    }

    public virtual void setLog10TickLabelsFlag(bool flag)
    {
      this.log10TickLabelsFlag = flag;
    }

    public virtual bool getLog10TickLabelsFlag()
    {
      return this.log10TickLabelsFlag;
    }

    public virtual void setAutoRangeNextLogFlag(bool flag)
    {
      this.autoRangeNextLogFlag = flag;
    }

    public virtual bool getAutoRangeNextLogFlag()
    {
      return this.autoRangeNextLogFlag;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 137, (byte) 103, (byte) 99, (byte) 161, (byte) 107, (byte) 167, (byte) 104, (byte) 131, (byte) 103, (byte) 202, (byte) 104, (byte) 184, (byte) 240, (byte) 71, (byte) 153, (byte) 143, (byte) 114, (byte) 135, (byte) 248, (byte) 69, (byte) 104, (byte) 169, (byte) 188, (byte) 168, (byte) 201, (byte) 154, (byte) 144, (byte) 114, (byte) 135, (byte) 185, (byte) 255, (byte) 15, (byte) 69, (byte) 112, (byte) 117, (byte) 147, (byte) 159, (byte) 3, (byte) 226, (byte) 69, (byte) 220, (byte) 105, (byte) 107, (byte) 116, (byte) 179, (byte) 104, (byte) 138, (byte) 159, (byte) 8, (byte) 116, (byte) 211, (byte) 112, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      Range range = ((ValueAxisPlot) plot).getDataRange((ValueAxis) this);
      double lower;
      if (range == null)
      {
        range = this.getDefaultAutoRange();
        lower = range.getLowerBound();
      }
      else
      {
        lower = range.getLowerBound();
        if (this.strictValuesFlag && !this.allowNegativesFlag && lower <= 0.0)
        {
          string str = "Values less than or equal to zero not allowed with logarithmic axis";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      double lowerMargin;
      if (lower > 0.0 && (lowerMargin = this.getLowerMargin()) > 0.0)
      {
        double num1 = Math.log(lower) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE;
        double num2;
        if ((num2 = Math.abs(num1)) < 1.0)
          num2 = 1.0;
        lower = Math.pow(10.0, num1 - num2 * lowerMargin);
      }
      if (this.autoRangeNextLogFlag)
        lower = this.computeLogFloor(lower);
      if (!this.allowNegativesFlag && lower >= 0.0 && lower < 1E-100)
        lower = range.getLowerBound();
      double upper1 = range.getUpperBound();
      double upperMargin;
      if (upper1 > 0.0 && (upperMargin = this.getUpperMargin()) > 0.0)
      {
        double num1 = Math.log(upper1) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE;
        double num2;
        if ((num2 = Math.abs(num1)) < 1.0)
          num2 = 1.0;
        upper1 = Math.pow(10.0, num1 + num2 * upperMargin);
      }
      double upper2;
      if (!this.allowNegativesFlag && upper1 < 1.0 && (upper1 > 0.0 && lower > 0.0))
      {
        double num = Math.pow(10.0, Math.ceil(-(Math.log(upper1) / LogarithmicAxis.__\u003C\u003ELOG10_VALUE) + 0.001));
        upper2 = num <= 0.0 ? Math.ceil(upper1) : Math.ceil(upper1 * num) / num;
      }
      else
        upper2 = !this.autoRangeNextLogFlag ? Math.ceil(upper1) : this.computeLogCeil(upper1);
      double rangeMinimumSize = this.getAutoRangeMinimumSize();
      if (upper2 - lower < rangeMinimumSize)
      {
        upper2 = (upper2 + lower + rangeMinimumSize) / 2.0;
        lower = (upper2 + lower - rangeMinimumSize) / 2.0;
        if (upper2 - lower < rangeMinimumSize)
        {
          double num1 = Math.abs(upper2);
          double num2 = num1 <= 1E-100 ? 0.01 : num1 / 100.0;
          upper2 = (upper2 + lower + num2) / 2.0;
          lower = (upper2 + lower - num2) / 2.0;
        }
      }
      this.setRange(new Range(lower, upper2), false, false);
      this.setupSmallLogFlag();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 1, (byte) 103, (byte) 110, (byte) 142, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 169, (byte) 139, (byte) 104, (byte) 209})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D plotArea, RectangleEdge edge)
    {
      Range range = this.getRange();
      double num1 = this.switchedLog10(range.getLowerBound());
      double num2 = this.switchedLog10(range.getUpperBound());
      double num3 = 0.0;
      double num4 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num3 = ((RectangularShape) plotArea).getMinX();
        num4 = ((RectangularShape) plotArea).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num3 = ((RectangularShape) plotArea).getMaxY();
        num4 = ((RectangularShape) plotArea).getMinY();
      }
      value = this.switchedLog10(value);
      if (this.isInverted())
        return num4 - (value - num1) / (num2 - num1) * (num4 - num3);
      else
        return num3 + (value - num1) / (num2 - num1) * (num4 - num3);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 43, (byte) 103, (byte) 110, (byte) 142, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 169, (byte) 104, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D plotArea, RectangleEdge edge)
    {
      Range range = this.getRange();
      double num1 = this.switchedLog10(range.getLowerBound());
      double num2 = this.switchedLog10(range.getUpperBound());
      double num3 = 0.0;
      double num4 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num3 = ((RectangularShape) plotArea).getX();
        num4 = ((RectangularShape) plotArea).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num3 = ((RectangularShape) plotArea).getMaxY();
        num4 = ((RectangularShape) plotArea).getMinY();
      }
      if (this.isInverted())
        return this.switchedPow10(num2 - (java2DValue - num3) / (num4 - num3) * (num2 - num1));
      else
        return this.switchedPow10(num1 + (java2DValue - num3) / (num4 - num3) * (num2 - num1));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 75, (byte) 115, (byte) 181, (byte) 104, (byte) 255, (byte) 13, (byte) 71, (byte) 254, (byte) 69, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomRange(double lowerPercent, double upperPercent)
    {
      double num1 = this.switchedLog10(this.getRange().getLowerBound());
      double num2 = this.switchedLog10(this.getRange().getUpperBound()) - num1;
      this.setRange(!this.isInverted() ? new Range(this.switchedPow10(num1 + num2 * lowerPercent), this.switchedPow10(num1 + num2 * upperPercent)) : new Range(this.switchedPow10(num1 + num2 * (1.0 - upperPercent)), this.switchedPow10(num1 + num2 * (1.0 - lowerPercent))));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 109, (byte) 102, (byte) 167, (byte) 168, (byte) 116, (byte) 202, (byte) 168, (byte) 147, (byte) 147, (byte) 223, (byte) 0, (byte) 230, (byte) 69, (byte) 99, (byte) 141, (byte) 140, (byte) 139, (byte) 127, (byte) 11, (byte) 255, (byte) 0, (byte) 69, (byte) 244, (byte) 70, (byte) 174, (byte) 176, (byte) 236, (byte) 71, (byte) 255, (byte) 19, (byte) 70, (byte) 100, (byte) 134, (byte) 191, (byte) 62, (byte) 100, (byte) 191, (byte) 9, (byte) 103, (byte) 197, (byte) 227, (byte) 70, (byte) 255, (byte) 27, (byte) 71, (byte) 101, (byte) 194, (byte) 146, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 150, (byte) 233, (byte) 159, (byte) 160, (byte) 11, (byte) 235, (byte) 160, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Range range = this.getRange();
      double val1 = range.getLowerBound();
      if (this.smallLogFlag && val1 < 1E-100)
        val1 = 1E-100;
      double upperBound = range.getUpperBound();
      int num1 = ByteCodeHelper.d2i(Math.rint(this.switchedLog10(val1)));
      int num2 = ByteCodeHelper.d2i(Math.rint(this.switchedLog10(upperBound)));
      if (num1 == num2 && num1 > 0 && Math.pow(10.0, (double) num1) > val1)
        num1 += -1;
      int num3 = 0;
      for (int index1 = num1; index1 <= num2; ++index1)
      {
        for (int index2 = 0; index2 < 10; ++index2)
        {
          double val2;
          string label;
          if (this.smallLogFlag)
          {
            val2 = Math.pow(10.0, (double) index1) + Math.pow(10.0, (double) index1) * (double) index2;
            if (this.expTickLabelsFlag || index1 < 0 && val2 > 0.0 && val2 < 1.0)
            {
              if (index2 == 0 || index1 > -4 && index2 < 2 || val2 >= upperBound)
              {
                this.__\u003C\u003EnumberFormatterObj.setMaximumFractionDigits(-index1);
                label = this.makeTickLabel(val2, true);
              }
              else
                label = "";
            }
            else
              label = index2 < 1 || index1 < 1 && index2 < 5 || (index2 < 4 - index1 || val2 >= upperBound) ? this.makeTickLabel(val2) : "";
          }
          else
          {
            if (num3 != 0)
              index2 += -1;
            val2 = index1 < 0 ? -(Math.pow(10.0, (double) -index1) - Math.pow(10.0, (double) (-index1 - 1)) * (double) index2) : Math.pow(10.0, (double) index1) + Math.pow(10.0, (double) index1) * (double) index2;
            if (num3 == 0)
            {
              if (Math.abs(val2 - 1.0) < 0.0001 && val1 <= 0.0 && upperBound >= 0.0)
              {
                val2 = 0.0;
                num3 = 1;
              }
            }
            else
              num3 = 0;
            label = this.expTickLabelsFlag && index2 < 2 || index2 < 1 || (index1 < 1 && index2 < 5 || (index2 < 4 - index1 || val2 >= upperBound)) ? this.makeTickLabel(val2) : "";
          }
          if (val2 > upperBound)
            return (List) arrayList;
          if (val2 >= val1 - 1E-100)
          {
            double angle = 0.0;
            TextAnchor textAnchor;
            TextAnchor rotationAnchor;
            if (this.isVerticalTickLabels())
            {
              textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
              rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
              angle = edge != RectangleEdge.__\u003C\u003ETOP ? -1.0 * Math.PI / 2.0 : Math.PI / 2.0;
            }
            else if (edge == RectangleEdge.__\u003C\u003ETOP)
            {
              textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
              rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            }
            else
            {
              textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
              rotationAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
            }
            NumberTick numberTick = new NumberTick((Number) new Double(val2), label, textAnchor, rotationAnchor, angle);
            ((List) arrayList).add((object) numberTick);
          }
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 2, (byte) 166, (byte) 173, (byte) 116, (byte) 170, (byte) 173, (byte) 146, (byte) 147, (byte) 220, (byte) 228, (byte) 69, (byte) 99, (byte) 140, (byte) 100, (byte) 102, (byte) 163, (byte) 140, (byte) 139, (byte) 127, (byte) 11, (byte) 135, (byte) 136, (byte) 191, (byte) 3, (byte) 136, (byte) 191, (byte) 3, (byte) 133, (byte) 136, (byte) 100, (byte) 173, (byte) 179, (byte) 229, (byte) 69, (byte) 174, (byte) 244, (byte) 71, (byte) 204, (byte) 100, (byte) 134, (byte) 159, (byte) 62, (byte) 103, (byte) 135, (byte) 223, (byte) 4, (byte) 103, (byte) 99, (byte) 236, (byte) 69, (byte) 136, (byte) 223, (byte) 30, (byte) 136, (byte) 223, (byte) 27, (byte) 136, (byte) 100, (byte) 173, (byte) 179, (byte) 226, (byte) 69, (byte) 103, (byte) 197, (byte) 103, (byte) 195, (byte) 101, (byte) 162, (byte) 146, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 103, (byte) 173, (byte) 103, (byte) 103, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 251, (byte) 159, (byte) 122, (byte) 235, (byte) 57, (byte) 235, (byte) 160, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List refreshTicksVertical(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      double val = this.getRange().getLowerBound();
      if (this.smallLogFlag && val < 1E-100)
        val = 1E-100;
      double upperBound = this.getRange().getUpperBound();
      int num1 = ByteCodeHelper.d2i(Math.rint(this.switchedLog10(val)));
      int num2 = ByteCodeHelper.d2i(Math.rint(this.switchedLog10(upperBound)));
      if (num1 == num2 && num1 > 0 && Math.pow(10.0, (double) num1) > val)
        num1 += -1;
      int num3 = 0;
      for (int index1 = num1; index1 <= num2; ++index1)
      {
        int num4 = 10;
        if (index1 == num2)
          num4 = 1;
        for (int index2 = 0; index2 < num4; ++index2)
        {
          double num5;
          string label;
          if (this.smallLogFlag)
          {
            num5 = Math.pow(10.0, (double) index1) + Math.pow(10.0, (double) index1) * (double) index2;
            if (index2 == 0)
            {
              if (this.log10TickLabelsFlag)
                label = new StringBuffer().append("10^").append(index1).toString();
              else if (this.expTickLabelsFlag)
                label = new StringBuffer().append("1e").append(index1).toString();
              else if (index1 >= 0)
              {
                NumberFormat numberFormatOverride = this.getNumberFormatOverride();
                label = numberFormatOverride == null ? Long.toString(ByteCodeHelper.d2l(Math.rint(num5))) : numberFormatOverride.format(num5);
              }
              else
              {
                this.__\u003C\u003EnumberFormatterObj.setMaximumFractionDigits(-index1);
                label = this.__\u003C\u003EnumberFormatterObj.format(num5);
              }
            }
            else
              label = "";
          }
          else
          {
            if (num3 != 0)
              index2 += -1;
            num5 = index1 < 0 ? -(Math.pow(10.0, (double) -index1) - Math.pow(10.0, (double) (-index1 - 1)) * (double) index2) : Math.pow(10.0, (double) index1) + Math.pow(10.0, (double) index1) * (double) index2;
            if (index2 == 0)
            {
              if (num3 == 0)
              {
                if (index1 > num1 && index1 < num2 && Math.abs(num5 - 1.0) < 0.0001)
                {
                  num5 = 0.0;
                  num3 = 1;
                  label = "0";
                }
                else if (this.log10TickLabelsFlag)
                  label = new StringBuffer().append(index1 >= 0 ? "" : "-").append("10^").append(Math.abs(index1)).toString();
                else if (this.expTickLabelsFlag)
                {
                  label = new StringBuffer().append(index1 >= 0 ? "" : "-").append("1e").append(Math.abs(index1)).toString();
                }
                else
                {
                  NumberFormat numberFormatOverride = this.getNumberFormatOverride();
                  label = numberFormatOverride == null ? Long.toString(ByteCodeHelper.d2l(Math.rint(num5))) : numberFormatOverride.format(num5);
                }
              }
              else
              {
                label = "";
                num3 = 0;
              }
            }
            else
            {
              label = "";
              num3 = 0;
            }
          }
          if (num5 > upperBound)
            return (List) arrayList;
          if (num5 >= val - 1E-100)
          {
            double angle = 0.0;
            TextAnchor textAnchor;
            TextAnchor rotationAnchor;
            if (this.isVerticalTickLabels())
            {
              if (edge == RectangleEdge.__\u003C\u003ELEFT)
              {
                textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
                rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
                angle = -1.0 * Math.PI / 2.0;
              }
              else
              {
                textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
                rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
                angle = Math.PI / 2.0;
              }
            }
            else if (edge == RectangleEdge.__\u003C\u003ELEFT)
            {
              textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
              rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            }
            else
            {
              textAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
              rotationAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
            }
            ((List) arrayList).add((object) new NumberTick((Number) new Double(num5), label, textAnchor, rotationAnchor, angle));
          }
        }
      }
      return (List) arrayList;
    }
  }
}
