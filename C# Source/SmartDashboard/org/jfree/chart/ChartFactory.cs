// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartFactory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.axis;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.chart.renderer.category;
using org.jfree.chart.renderer.xy;
using org.jfree.chart.title;
using org.jfree.chart.urls;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.data.statistics;
using org.jfree.data.xy;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  public abstract class ChartFactory : Object
  {
    private static ChartTheme currentTheme = (ChartTheme) new StandardChartTheme("JFree");

    [LineNumberTable((ushort) 229)]
    static ChartFactory()
    {
    }

    [LineNumberTable((ushort) 226)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartFactory()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 221, (byte) 73, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 109, (byte) 105, (byte) 99, (byte) 140, (byte) 99, (byte) 172, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createXYLineChart(string title, string xAxisLabel, string yAxisLabel, XYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        XYLineAndShapeRenderer andShapeRenderer = new XYLineAndShapeRenderer(true, false);
        XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) andShapeRenderer);
        xyPlot.setOrientation(orientation);
        if (num1 != 0)
          andShapeRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new StandardXYToolTipGenerator());
        if (num2 != 0)
          andShapeRenderer.setURLGenerator((XYURLGenerator) new StandardXYURLGenerator());
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    public static ChartTheme getChartTheme()
    {
      return ChartFactory.currentTheme;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 99, (byte) 144, (byte) 198, (byte) 104, (byte) 103, (byte) 114, (byte) 106, (byte) 172, (byte) 106, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setChartTheme(ChartTheme theme)
    {
      if (theme == null)
      {
        string str = "Null 'theme' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ChartFactory.currentTheme = theme;
        if (!(theme is StandardChartTheme))
          return;
        if (String.instancehelper_equals(((StandardChartTheme) theme).getName(), (object) "Legacy"))
        {
          BarRenderer.setDefaultBarPainter((BarPainter) new StandardBarPainter());
          XYBarRenderer.setDefaultBarPainter((XYBarPainter) new StandardXYBarPainter());
        }
        else
        {
          BarRenderer.setDefaultBarPainter((BarPainter) new GradientBarPainter());
          XYBarRenderer.setDefaultBarPainter((XYBarPainter) new GradientXYBarPainter());
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 68, (byte) 68, (byte) 103, (byte) 109, (byte) 127, (byte) 12, (byte) 99, (byte) 141, (byte) 147, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart(string title, PieDataset dataset, bool legend, bool tooltips, Locale locale)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = legend ? 1 : 0;
      PiePlot piePlot = new PiePlot(dataset);
      piePlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator(locale));
      piePlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator(locale));
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot, num2 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 60, (byte) 103, (byte) 103, (byte) 107, (byte) 127, (byte) 12, (byte) 99, (byte) 139, (byte) 99, (byte) 139, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart(string title, PieDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      PiePlot piePlot = new PiePlot(dataset);
      piePlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator());
      piePlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator());
      if (num2 != 0)
        piePlot.setURLGenerator((PieURLGenerator) new StandardPieURLGenerator());
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 45, (byte) 112, (byte) 104, (byte) 110, (byte) 159, (byte) 13, (byte) 99, (byte) 174, (byte) 104, (byte) 99, (byte) 99, (byte) 167, (byte) 111, (byte) 117, (byte) 110, (byte) 106, (byte) 138, (byte) 100, (byte) 99, (byte) 176, (byte) 142, (byte) 102, (byte) 223, (byte) 10, (byte) 159, (byte) 3, (byte) 191, (byte) 4, (byte) 223, (byte) 7, (byte) 185, (byte) 151, (byte) 99, (byte) 255, (byte) 68, (byte) 69, (byte) 133, (byte) 99, (byte) 169, (byte) 181, (byte) 103, (byte) 98, (byte) 255, (byte) 106, (byte) 69, (byte) 137, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart(string title, PieDataset dataset, PieDataset previousDataset, int percentDiffForMaxScale, bool greenForIncrease, bool legend, bool tooltips, Locale locale, bool subTitle, bool showDifference)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = showDifference ? 1 : 0;
      int num3 = greenForIncrease ? 1 : 0;
      int num4 = legend ? 1 : 0;
      int num5 = subTitle ? 1 : 0;
      PiePlot piePlot = new PiePlot(dataset);
      piePlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator(locale));
      piePlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator(locale));
      List keys = dataset.getKeys();
      DefaultPieDataset defaultPieDataset = (DefaultPieDataset) null;
      if (num2 != 0)
        defaultPieDataset = new DefaultPieDataset();
      double num6 = (double) byte.MaxValue / (double) percentDiffForMaxScale;
      Iterator iterator = keys.iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        Number number1 = dataset.getValue(comparable);
        Number number2 = previousDataset.getValue(comparable);
        if (number2 == null)
        {
          if (num3 != 0)
            piePlot.setSectionPaint(comparable, (Paint) Color.green);
          else
            piePlot.setSectionPaint(comparable, (Paint) Color.red);
          if (num2 != 0)
            defaultPieDataset.setValue((IComparable) new StringBuffer().append((object) comparable).append(" (+100%)").toString(), number1);
        }
        else
        {
          double num7 = (number1.doubleValue() / number2.doubleValue() - 1.0) * 100.0;
          double num8 = Math.abs(num7) < (double) percentDiffForMaxScale ? Math.abs(num7) * num6 : (double) byte.MaxValue;
          if (num3 != 0 && number1.doubleValue() > number2.doubleValue() || num3 == 0 && number1.doubleValue() < number2.doubleValue())
            piePlot.setSectionPaint(comparable, (Paint) new Color(0, ByteCodeHelper.d2i(num8), 0));
          else
            piePlot.setSectionPaint(comparable, (Paint) new Color(ByteCodeHelper.d2i(num8), 0, 0));
          if (num2 != 0)
            defaultPieDataset.setValue((IComparable) new StringBuffer().append((object) comparable).append(" (").append(num7 < 0.0 ? "" : "+").append(NumberFormat.getPercentInstance().format(num7 / 100.0)).append(")").toString(), number1);
        }
      }
      if (num2 != 0)
        piePlot.setDataset((PieDataset) defaultPieDataset);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot, num4 != 0);
      if (num5 != 0)
      {
        TextTitle.__\u003Cclinit\u003E();
        TextTitle textTitle = new TextTitle(new StringBuffer().append("Bright ").append(num3 == 0 ? "green" : "red").append("=change >=-").append(percentDiffForMaxScale).append("%, Bright ").append(num3 != 0 ? "green" : "red").append("=change >=+").append(percentDiffForMaxScale).append("%").toString(), new Font("SansSerif", 0, 10));
        jfc.addSubtitle((Title) textTitle);
      }
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 14, (byte) 84, (byte) 104, (byte) 108, (byte) 159, (byte) 13, (byte) 99, (byte) 140, (byte) 99, (byte) 172, (byte) 104, (byte) 99, (byte) 99, (byte) 167, (byte) 111, (byte) 117, (byte) 110, (byte) 106, (byte) 138, (byte) 100, (byte) 99, (byte) 176, (byte) 142, (byte) 102, (byte) 223, (byte) 10, (byte) 159, (byte) 3, (byte) 191, (byte) 4, (byte) 223, (byte) 7, (byte) 185, (byte) 151, (byte) 99, (byte) 255, (byte) 68, (byte) 69, (byte) 133, (byte) 99, (byte) 169, (byte) 182, (byte) 103, (byte) 98, (byte) 255, (byte) 106, (byte) 69, (byte) 137, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart(string title, PieDataset dataset, PieDataset previousDataset, int percentDiffForMaxScale, bool greenForIncrease, bool legend, bool tooltips, bool urls, bool subTitle, bool showDifference)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = showDifference ? 1 : 0;
      int num4 = greenForIncrease ? 1 : 0;
      int num5 = legend ? 1 : 0;
      int num6 = subTitle ? 1 : 0;
      PiePlot piePlot = new PiePlot(dataset);
      piePlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator());
      piePlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator());
      if (num2 != 0)
        piePlot.setURLGenerator((PieURLGenerator) new StandardPieURLGenerator());
      List keys = dataset.getKeys();
      DefaultPieDataset defaultPieDataset = (DefaultPieDataset) null;
      if (num3 != 0)
        defaultPieDataset = new DefaultPieDataset();
      double num7 = (double) byte.MaxValue / (double) percentDiffForMaxScale;
      Iterator iterator = keys.iterator();
      while (iterator.hasNext())
      {
        IComparable comparable = (IComparable) iterator.next();
        Number number1 = dataset.getValue(comparable);
        Number number2 = previousDataset.getValue(comparable);
        if (number2 == null)
        {
          if (num4 != 0)
            piePlot.setSectionPaint(comparable, (Paint) Color.green);
          else
            piePlot.setSectionPaint(comparable, (Paint) Color.red);
          if (num3 != 0)
            defaultPieDataset.setValue((IComparable) new StringBuffer().append((object) comparable).append(" (+100%)").toString(), number1);
        }
        else
        {
          double num8 = (number1.doubleValue() / number2.doubleValue() - 1.0) * 100.0;
          double num9 = Math.abs(num8) < (double) percentDiffForMaxScale ? Math.abs(num8) * num7 : (double) byte.MaxValue;
          if (num4 != 0 && number1.doubleValue() > number2.doubleValue() || num4 == 0 && number1.doubleValue() < number2.doubleValue())
            piePlot.setSectionPaint(comparable, (Paint) new Color(0, ByteCodeHelper.d2i(num9), 0));
          else
            piePlot.setSectionPaint(comparable, (Paint) new Color(ByteCodeHelper.d2i(num9), 0, 0));
          if (num3 != 0)
            defaultPieDataset.setValue((IComparable) new StringBuffer().append((object) comparable).append(" (").append(num8 < 0.0 ? "" : "+").append(NumberFormat.getPercentInstance().format(num8 / 100.0)).append(")").toString(), number1);
        }
      }
      if (num3 != 0)
        piePlot.setDataset((PieDataset) defaultPieDataset);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot, num5 != 0);
      if (num6 != 0)
      {
        TextTitle.__\u003Cclinit\u003E();
        TextTitle textTitle = new TextTitle(new StringBuffer().append("Bright ").append(num4 == 0 ? "green" : "red").append("=change >=-").append(percentDiffForMaxScale).append("%, Bright ").append(num4 != 0 ? "green" : "red").append("=change >=+").append(percentDiffForMaxScale).append("%").toString(), new Font("SansSerif", 0, 10));
        jfc.addSubtitle((Title) textTitle);
      }
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 246, (byte) 68, (byte) 103, (byte) 109, (byte) 127, (byte) 12, (byte) 99, (byte) 141, (byte) 147, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createRingChart(string title, PieDataset dataset, bool legend, bool tooltips, Locale locale)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = legend ? 1 : 0;
      RingPlot ringPlot = new RingPlot(dataset);
      ringPlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator(locale));
      ringPlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        ringPlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator(locale));
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) ringPlot, num2 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 238, (byte) 71, (byte) 103, (byte) 107, (byte) 127, (byte) 12, (byte) 99, (byte) 139, (byte) 99, (byte) 139, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createRingChart(string title, PieDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      RingPlot ringPlot = new RingPlot(dataset);
      ringPlot.setLabelGenerator((PieSectionLabelGenerator) new StandardPieSectionLabelGenerator());
      ringPlot.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        ringPlot.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator());
      if (num2 != 0)
        ringPlot.setURLGenerator((PieURLGenerator) new StandardPieURLGenerator());
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) ringPlot, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 229, (byte) 136, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 135, (byte) 99, (byte) 135, (byte) 114, (byte) 169, (byte) 99, (byte) 103, (byte) 114, (byte) 169, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createMultiplePieChart(string title, CategoryDataset dataset, TableOrder order, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        MultiplePiePlot multiplePiePlot = new MultiplePiePlot(dataset);
        multiplePiePlot.setDataExtractOrder(order);
        multiplePiePlot.setBackgroundPaint((Paint) null);
        multiplePiePlot.setOutlineStroke((Stroke) null);
        if (num1 != 0)
        {
          StandardPieToolTipGenerator toolTipGenerator = new StandardPieToolTipGenerator();
          ((PiePlot) multiplePiePlot.getPieChart().getPlot()).setToolTipGenerator((PieToolTipGenerator) toolTipGenerator);
        }
        if (num2 != 0)
        {
          StandardPieURLGenerator standardPieUrlGenerator = new StandardPieURLGenerator();
          ((PiePlot) multiplePiePlot.getPieChart().getPlot()).setURLGenerator((PieURLGenerator) standardPieUrlGenerator);
        }
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) multiplePiePlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 217, (byte) 68, (byte) 103, (byte) 127, (byte) 12, (byte) 99, (byte) 141, (byte) 147, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart3D(string title, PieDataset dataset, bool legend, bool tooltips, Locale locale)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = legend ? 1 : 0;
      PiePlot3D piePlot3D = new PiePlot3D(dataset);
      piePlot3D.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot3D.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator(locale));
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot3D, num2 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 210, (byte) 167, (byte) 103, (byte) 127, (byte) 12, (byte) 99, (byte) 139, (byte) 99, (byte) 139, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPieChart3D(string title, PieDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      PiePlot3D piePlot3D = new PiePlot3D(dataset);
      piePlot3D.setInsets(new RectangleInsets(0.0, 5.0, 5.0, 5.0));
      if (num1 != 0)
        piePlot3D.setToolTipGenerator((PieToolTipGenerator) new StandardPieToolTipGenerator());
      if (num2 != 0)
        piePlot3D.setURLGenerator((PieURLGenerator) new StandardPieURLGenerator());
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) piePlot3D, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 200, (byte) 72, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 135, (byte) 114, (byte) 158, (byte) 108, (byte) 105, (byte) 103, (byte) 104, (byte) 136, (byte) 99, (byte) 135, (byte) 114, (byte) 169, (byte) 99, (byte) 103, (byte) 114, (byte) 169, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createMultiplePieChart3D(string title, CategoryDataset dataset, TableOrder order, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        MultiplePiePlot multiplePiePlot = new MultiplePiePlot(dataset);
        multiplePiePlot.setDataExtractOrder(order);
        multiplePiePlot.setBackgroundPaint((Paint) null);
        multiplePiePlot.setOutlineStroke((Stroke) null);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart pieChart = new JFreeChart((Plot) new PiePlot3D((PieDataset) null));
        TextTitle.__\u003Cclinit\u003E();
        TextTitle title1 = new TextTitle("Series Title", new Font("SansSerif", 1, 12));
        title1.setPosition(RectangleEdge.__\u003C\u003EBOTTOM);
        pieChart.setTitle(title1);
        pieChart.removeLegend();
        pieChart.setBackgroundPaint((Paint) null);
        multiplePiePlot.setPieChart(pieChart);
        if (num1 != 0)
        {
          StandardPieToolTipGenerator toolTipGenerator = new StandardPieToolTipGenerator();
          ((PiePlot) multiplePiePlot.getPieChart().getPlot()).setToolTipGenerator((PieToolTipGenerator) toolTipGenerator);
        }
        if (num2 != 0)
        {
          StandardPieURLGenerator standardPieUrlGenerator = new StandardPieURLGenerator();
          ((PiePlot) multiplePiePlot.getPieChart().getPlot()).setURLGenerator((PieURLGenerator) standardPieUrlGenerator);
        }
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) multiplePiePlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 184, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 136, (byte) 103, (byte) 105, (byte) 145, (byte) 105, (byte) 145, (byte) 105, (byte) 98, (byte) 105, (byte) 145, (byte) 105, (byte) 145, (byte) 137, (byte) 99, (byte) 172, (byte) 99, (byte) 204, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createBarChart(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
        NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
        BarRenderer barRenderer = new BarRenderer();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          ItemLabelPosition position1 = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE3, TextAnchor.__\u003C\u003ECENTER_LEFT);
          barRenderer.setBasePositiveItemLabelPosition(position1);
          ItemLabelPosition position2 = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE9, TextAnchor.__\u003C\u003ECENTER_RIGHT);
          barRenderer.setBaseNegativeItemLabelPosition(position2);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          ItemLabelPosition position1 = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE12, TextAnchor.__\u003C\u003EBOTTOM_CENTER);
          barRenderer.setBasePositiveItemLabelPosition(position1);
          ItemLabelPosition position2 = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EOUTSIDE6, TextAnchor.__\u003C\u003ETOP_CENTER);
          barRenderer.setBaseNegativeItemLabelPosition(position2);
        }
        if (num1 != 0)
          barRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          barRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) barRenderer);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 166, (byte) 137, (byte) 100, (byte) 176, (byte) 103, (byte) 136, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 204, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createStackedBarChart(string title, string domainAxisLabel, string rangeAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(domainAxisLabel);
        NumberAxis numberAxis = new NumberAxis(rangeAxisLabel);
        StackedBarRenderer stackedBarRenderer = new StackedBarRenderer();
        if (num1 != 0)
          stackedBarRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          stackedBarRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) stackedBarRenderer);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 152, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 136, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 204, (byte) 141, (byte) 105, (byte) 169, (byte) 108, (byte) 140, (byte) 140, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createBarChart3D(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis3D categoryAxis3D = new CategoryAxis3D(categoryAxisLabel);
        NumberAxis3D numberAxis3D = new NumberAxis3D(valueAxisLabel);
        BarRenderer3D barRenderer3D = new BarRenderer3D();
        if (num1 != 0)
          barRenderer3D.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          barRenderer3D.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, (CategoryAxis) categoryAxis3D, (ValueAxis) numberAxis3D, (CategoryItemRenderer) barRenderer3D);
        categoryPlot.setOrientation(orientation);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          categoryPlot.setRowRenderingOrder(SortOrder.__\u003C\u003EDESCENDING);
          categoryPlot.setColumnRenderingOrder(SortOrder.__\u003C\u003EDESCENDING);
        }
        categoryPlot.setForegroundAlpha(0.75f);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 136, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 168, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 236, (byte) 69, (byte) 141, (byte) 105, (byte) 169, (byte) 204, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createStackedBarChart3D(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis3D categoryAxis3D = new CategoryAxis3D(categoryAxisLabel);
        NumberAxis3D numberAxis3D = new NumberAxis3D(valueAxisLabel);
        StackedBarRenderer3D stackedBarRenderer3D = new StackedBarRenderer3D();
        if (num1 != 0)
          stackedBarRenderer3D.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          stackedBarRenderer3D.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, (CategoryAxis) categoryAxis3D, (ValueAxis) numberAxis3D, (CategoryItemRenderer) stackedBarRenderer3D);
        categoryPlot.setOrientation(orientation);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          categoryPlot.setColumnRenderingOrder(SortOrder.__\u003C\u003EDESCENDING);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 120, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 139, (byte) 136, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 204, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createAreaChart(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
        domainAxis.setCategoryMargin(0.0);
        NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
        AreaRenderer areaRenderer = new AreaRenderer();
        if (num1 != 0)
          areaRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          areaRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) areaRenderer);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 106, (byte) 73, (byte) 100, (byte) 144, (byte) 103, (byte) 107, (byte) 136, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 204, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createStackedAreaChart(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
        domainAxis.setCategoryMargin(0.0);
        NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
        StackedAreaRenderer stackedAreaRenderer = new StackedAreaRenderer();
        if (num1 != 0)
          stackedAreaRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          stackedAreaRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) stackedAreaRenderer);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 92, (byte) 73, (byte) 100, (byte) 144, (byte) 103, (byte) 136, (byte) 105, (byte) 99, (byte) 172, (byte) 99, (byte) 172, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createLineChart(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
        NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
        LineAndShapeRenderer andShapeRenderer = new LineAndShapeRenderer(true, false);
        if (num1 != 0)
          andShapeRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          andShapeRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) andShapeRenderer);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 79, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 136, (byte) 103, (byte) 99, (byte) 172, (byte) 99, (byte) 172, (byte) 141, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createLineChart3D(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis3D categoryAxis3D = new CategoryAxis3D(categoryAxisLabel);
        NumberAxis3D numberAxis3D = new NumberAxis3D(valueAxisLabel);
        LineRenderer3D lineRenderer3D = new LineRenderer3D();
        if (num1 != 0)
          lineRenderer3D.setBaseToolTipGenerator((CategoryToolTipGenerator) new StandardCategoryToolTipGenerator());
        if (num2 != 0)
          lineRenderer3D.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, (CategoryAxis) categoryAxis3D, (ValueAxis) numberAxis3D, (CategoryItemRenderer) lineRenderer3D);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 66, (byte) 137, (byte) 103, (byte) 136, (byte) 103, (byte) 99, (byte) 214, (byte) 99, (byte) 204, (byte) 141, (byte) 108, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createGanttChart(string title, string categoryAxisLabel, string dateAxisLabel, IntervalCategoryDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
      DateAxis dateAxis = new DateAxis(dateAxisLabel);
      GanttRenderer ganttRenderer = new GanttRenderer();
      if (num1 != 0)
        ganttRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new IntervalCategoryToolTipGenerator("{3} - {4}", DateFormat.getDateInstance()));
      if (num2 != 0)
        ganttRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
      CategoryPlot categoryPlot = new CategoryPlot((CategoryDataset) dataset, domainAxis, (ValueAxis) dateAxis, (CategoryItemRenderer) ganttRenderer);
      categoryPlot.setOrientation(PlotOrientation.__\u003C\u003EHORIZONTAL);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 53, (byte) 169, (byte) 100, (byte) 144, (byte) 103, (byte) 139, (byte) 136, (byte) 103, (byte) 105, (byte) 191, (byte) 0, (byte) 105, (byte) 105, (byte) 98, (byte) 105, (byte) 187, (byte) 105, (byte) 137, (byte) 99, (byte) 135, (byte) 137, (byte) 99, (byte) 204, (byte) 141, (byte) 103, (byte) 108, (byte) 108, (byte) 110, (byte) 105, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createWaterfallChart(string title, string categoryAxisLabel, string valueAxisLabel, CategoryDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
        domainAxis.setCategoryMargin(0.0);
        NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
        WaterfallBarRenderer waterfallBarRenderer = new WaterfallBarRenderer();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          ItemLabelPosition position = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, Math.PI / 2.0);
          waterfallBarRenderer.setBasePositiveItemLabelPosition(position);
          waterfallBarRenderer.setBaseNegativeItemLabelPosition(position);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          ItemLabelPosition position = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, 0.0);
          waterfallBarRenderer.setBasePositiveItemLabelPosition(position);
          waterfallBarRenderer.setBaseNegativeItemLabelPosition(position);
        }
        if (num1 != 0)
        {
          StandardCategoryToolTipGenerator toolTipGenerator = new StandardCategoryToolTipGenerator();
          waterfallBarRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) toolTipGenerator);
        }
        if (num2 != 0)
          waterfallBarRenderer.setBaseItemURLGenerator((CategoryURLGenerator) new StandardCategoryURLGenerator());
        CategoryPlot categoryPlot = new CategoryPlot(dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) waterfallBarRenderer);
        categoryPlot.clearRangeMarkers();
        ValueMarker valueMarker = new ValueMarker(0.0);
        valueMarker.setPaint((Paint) Color.black);
        categoryPlot.addRangeMarker((Marker) valueMarker, Layer.__\u003C\u003EFOREGROUND);
        categoryPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 36, (byte) 130, (byte) 102, (byte) 103, (byte) 102, (byte) 103, (byte) 103, (byte) 127, (byte) 0, (byte) 103, (byte) 107, (byte) 147, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createPolarChart(string title, XYDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num = legend ? 1 : 0;
      PolarPlot polarPlot = new PolarPlot();
      polarPlot.setDataset(dataset);
      NumberAxis numberAxis = new NumberAxis();
      numberAxis.setAxisLineVisible(false);
      numberAxis.setTickMarksVisible(false);
      numberAxis.setTickLabelInsets(new RectangleInsets(0.0, 0.0, 0.0, 0.0));
      polarPlot.setAxis((ValueAxis) numberAxis);
      polarPlot.setRenderer((PolarItemRenderer) new DefaultPolarItemRenderer());
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) polarPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 26, (byte) 73, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 136, (byte) 140, (byte) 99, (byte) 99, (byte) 167, (byte) 99, (byte) 99, (byte) 135, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createScatterPlot(string title, string xAxisLabel, string yAxisLabel, XYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        numberAxis2.setAutoRangeIncludesZero(false);
        XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) null);
        StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
        if (num1 != 0)
          toolTipGenerator = new StandardXYToolTipGenerator();
        StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
        if (num2 != 0)
          standardXyurlGenerator = new StandardXYURLGenerator();
        XYLineAndShapeRenderer andShapeRenderer = new XYLineAndShapeRenderer(false, true);
        andShapeRenderer.setBaseToolTipGenerator((XYToolTipGenerator) toolTipGenerator);
        andShapeRenderer.setURLGenerator((XYURLGenerator) standardXyurlGenerator);
        xyPlot.setRenderer((XYItemRenderer) andShapeRenderer);
        xyPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 11, (byte) 171, (byte) 100, (byte) 144, (byte) 98, (byte) 99, (byte) 170, (byte) 104, (byte) 104, (byte) 132, (byte) 136, (byte) 103, (byte) 131, (byte) 99, (byte) 169, (byte) 135, (byte) 137, (byte) 99, (byte) 172, (byte) 111, (byte) 137, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createXYBarChart(string title, string xAxisLabel, bool dateAxis, string yAxisLabel, IntervalXYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = dateAxis ? 1 : 0;
      int num2 = tooltips ? 1 : 0;
      int num3 = urls ? 1 : 0;
      int num4 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ValueAxis domainAxis;
        if (num1 != 0)
        {
          domainAxis = (ValueAxis) new DateAxis(xAxisLabel);
        }
        else
        {
          NumberAxis numberAxis = new NumberAxis(xAxisLabel);
          numberAxis.setAutoRangeIncludesZero(false);
          domainAxis = (ValueAxis) numberAxis;
        }
        NumberAxis numberAxis1 = new NumberAxis(yAxisLabel);
        XYBarRenderer xyBarRenderer = new XYBarRenderer();
        if (num2 != 0)
        {
          StandardXYToolTipGenerator toolTipGenerator = num1 == 0 ? new StandardXYToolTipGenerator() : StandardXYToolTipGenerator.getTimeSeriesInstance();
          xyBarRenderer.setBaseToolTipGenerator((XYToolTipGenerator) toolTipGenerator);
        }
        if (num3 != 0)
          xyBarRenderer.setURLGenerator((XYURLGenerator) new StandardXYURLGenerator());
        XYPlot xyPlot = new XYPlot((XYDataset) dataset, domainAxis, (ValueAxis) numberAxis1, (XYItemRenderer) xyBarRenderer);
        xyPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num4 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 250, (byte) 169, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 108, (byte) 105, (byte) 140, (byte) 99, (byte) 99, (byte) 167, (byte) 99, (byte) 99, (byte) 167, (byte) 145, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createXYAreaChart(string title, string xAxisLabel, string yAxisLabel, XYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) null);
        xyPlot.setOrientation(orientation);
        xyPlot.setForegroundAlpha(0.5f);
        StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
        if (num1 != 0)
          toolTipGenerator = new StandardXYToolTipGenerator();
        StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
        if (num2 != 0)
          standardXyurlGenerator = new StandardXYURLGenerator();
        xyPlot.setRenderer((XYItemRenderer) new XYAreaRenderer(4, (XYToolTipGenerator) toolTipGenerator, (XYURLGenerator) standardXyurlGenerator));
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 236, (byte) 169, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 104, (byte) 99, (byte) 99, (byte) 167, (byte) 99, (byte) 99, (byte) 135, (byte) 139, (byte) 104, (byte) 109, (byte) 137, (byte) 137, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createStackedXYAreaChart(string title, string xAxisLabel, string yAxisLabel, TableXYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        numberAxis1.setLowerMargin(0.0);
        numberAxis1.setUpperMargin(0.0);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
        if (num1 != 0)
          toolTipGenerator = new StandardXYToolTipGenerator();
        StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
        if (num2 != 0)
          standardXyurlGenerator = new StandardXYURLGenerator();
        StackedXYAreaRenderer2 stackedXyAreaRenderer2 = new StackedXYAreaRenderer2((XYToolTipGenerator) toolTipGenerator, (XYURLGenerator) standardXyurlGenerator);
        stackedXyAreaRenderer2.setOutline(true);
        XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) stackedXyAreaRenderer2);
        xyPlot.setOrientation(orientation);
        xyPlot.setRangeAxis((ValueAxis) numberAxis2);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 210, (byte) 169, (byte) 100, (byte) 144, (byte) 103, (byte) 104, (byte) 140, (byte) 99, (byte) 99, (byte) 167, (byte) 99, (byte) 99, (byte) 135, (byte) 171, (byte) 108, (byte) 105, (byte) 105, (byte) 104, (byte) 104, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createXYStepChart(string title, string xAxisLabel, string yAxisLabel, XYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        DateAxis dateAxis = new DateAxis(xAxisLabel);
        NumberAxis numberAxis = new NumberAxis(yAxisLabel);
        numberAxis.setStandardTickUnits(NumberAxis.createIntegerTickUnits());
        StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
        if (num1 != 0)
          toolTipGenerator = new StandardXYToolTipGenerator();
        StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
        if (num2 != 0)
          standardXyurlGenerator = new StandardXYURLGenerator();
        XYStepRenderer xyStepRenderer = new XYStepRenderer((XYToolTipGenerator) toolTipGenerator, (XYURLGenerator) standardXyurlGenerator);
        XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) null);
        xyPlot.setRenderer((XYItemRenderer) xyStepRenderer);
        xyPlot.setOrientation(orientation);
        xyPlot.setDomainCrosshairVisible(false);
        xyPlot.setRangeCrosshairVisible(false);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 196, (byte) 137, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 136, (byte) 99, (byte) 99, (byte) 167, (byte) 99, (byte) 99, (byte) 135, (byte) 204, (byte) 108, (byte) 105, (byte) 105, (byte) 104, (byte) 104, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createXYStepAreaChart(string title, string xAxisLabel, string yAxisLabel, XYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
        if (num1 != 0)
          toolTipGenerator = new StandardXYToolTipGenerator();
        StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
        if (num2 != 0)
          standardXyurlGenerator = new StandardXYURLGenerator();
        XYStepAreaRenderer stepAreaRenderer = new XYStepAreaRenderer(3, (XYToolTipGenerator) toolTipGenerator, (XYURLGenerator) standardXyurlGenerator);
        XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) null);
        xyPlot.setRenderer((XYItemRenderer) stepAreaRenderer);
        xyPlot.setOrientation(orientation);
        xyPlot.setDomainCrosshairVisible(false);
        xyPlot.setRangeCrosshairVisible(false);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 181, (byte) 137, (byte) 103, (byte) 111, (byte) 111, (byte) 104, (byte) 104, (byte) 140, (byte) 99, (byte) 99, (byte) 199, (byte) 99, (byte) 99, (byte) 167, (byte) 137, (byte) 105, (byte) 105, (byte) 137, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createTimeSeriesChart(string title, string timeAxisLabel, string valueAxisLabel, XYDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(timeAxisLabel);
      dateAxis.setLowerMargin(0.02);
      dateAxis.setUpperMargin(0.02);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      numberAxis.setAutoRangeIncludesZero(false);
      XYPlot xyPlot = new XYPlot(dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) null);
      StandardXYToolTipGenerator toolTipGenerator = (StandardXYToolTipGenerator) null;
      if (num1 != 0)
        toolTipGenerator = StandardXYToolTipGenerator.getTimeSeriesInstance();
      StandardXYURLGenerator standardXyurlGenerator = (StandardXYURLGenerator) null;
      if (num2 != 0)
        standardXyurlGenerator = new StandardXYURLGenerator();
      XYLineAndShapeRenderer andShapeRenderer = new XYLineAndShapeRenderer(true, false);
      andShapeRenderer.setBaseToolTipGenerator((XYToolTipGenerator) toolTipGenerator);
      andShapeRenderer.setURLGenerator((XYURLGenerator) standardXyurlGenerator);
      xyPlot.setRenderer((XYItemRenderer) andShapeRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 168, (byte) 67, (byte) 103, (byte) 103, (byte) 106, (byte) 107, (byte) 148, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createCandlestickChart(string title, string timeAxisLabel, string valueAxisLabel, OHLCDataset dataset, bool legend)
    {
      int num = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(timeAxisLabel);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) null);
      xyPlot.setRenderer((XYItemRenderer) new CandlestickRenderer());
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 161, (byte) 131, (byte) 103, (byte) 103, (byte) 102, (byte) 107, (byte) 107, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createHighLowChart(string title, string timeAxisLabel, string valueAxisLabel, OHLCDataset dataset, bool legend)
    {
      int num = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(timeAxisLabel);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      HighLowRenderer highLowRenderer = new HighLowRenderer();
      highLowRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new HighLowItemLabelGenerator());
      XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) highLowRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 152, (byte) 163, (byte) 103, (byte) 104, (byte) 103, (byte) 102, (byte) 107, (byte) 107, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createHighLowChart(string title, string timeAxisLabel, string valueAxisLabel, OHLCDataset dataset, Timeline timeline, bool legend)
    {
      int num = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(timeAxisLabel);
      dateAxis.setTimeline(timeline);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      HighLowRenderer highLowRenderer = new HighLowRenderer();
      highLowRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new HighLowItemLabelGenerator());
      XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) highLowRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 142, (byte) 169, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 136, (byte) 140, (byte) 136, (byte) 99, (byte) 140, (byte) 99, (byte) 140, (byte) 105, (byte) 137, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createBubbleChart(string title, string xAxisLabel, string yAxisLabel, XYZDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        numberAxis2.setAutoRangeIncludesZero(false);
        XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) null);
        XYBubbleRenderer xyBubbleRenderer = new XYBubbleRenderer(2);
        if (num1 != 0)
          xyBubbleRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new StandardXYZToolTipGenerator());
        if (num2 != 0)
          xyBubbleRenderer.setURLGenerator((XYURLGenerator) new StandardXYZURLGenerator());
        xyPlot.setRenderer((XYItemRenderer) xyBubbleRenderer);
        xyPlot.setOrientation(orientation);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 129, (byte) 105, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 136, (byte) 103, (byte) 99, (byte) 140, (byte) 99, (byte) 172, (byte) 109, (byte) 105, (byte) 104, (byte) 104, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createHistogram(string title, string xAxisLabel, string yAxisLabel, IntervalXYDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NumberAxis numberAxis1 = new NumberAxis(xAxisLabel);
        numberAxis1.setAutoRangeIncludesZero(false);
        NumberAxis numberAxis2 = new NumberAxis(yAxisLabel);
        XYBarRenderer xyBarRenderer = new XYBarRenderer();
        if (num1 != 0)
          xyBarRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new StandardXYToolTipGenerator());
        if (num2 != 0)
          xyBarRenderer.setURLGenerator((XYURLGenerator) new StandardXYURLGenerator());
        XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) numberAxis1, (ValueAxis) numberAxis2, (XYItemRenderer) xyBarRenderer);
        xyPlot.setOrientation(orientation);
        xyPlot.setDomainZeroBaselineVisible(true);
        xyPlot.setRangeZeroBaselineVisible(true);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 118, (byte) 163, (byte) 103, (byte) 103, (byte) 135, (byte) 102, (byte) 139, (byte) 139, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createBoxAndWhiskerChart(string title, string categoryAxisLabel, string valueAxisLabel, BoxAndWhiskerCategoryDataset dataset, bool legend)
    {
      int num = legend ? 1 : 0;
      CategoryAxis domainAxis = new CategoryAxis(categoryAxisLabel);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      numberAxis.setAutoRangeIncludesZero(false);
      BoxAndWhiskerRenderer andWhiskerRenderer = new BoxAndWhiskerRenderer();
      andWhiskerRenderer.setBaseToolTipGenerator((CategoryToolTipGenerator) new BoxAndWhiskerToolTipGenerator());
      CategoryPlot categoryPlot = new CategoryPlot((CategoryDataset) dataset, domainAxis, (ValueAxis) numberAxis, (CategoryItemRenderer) andWhiskerRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) categoryPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 109, (byte) 99, (byte) 103, (byte) 103, (byte) 103, (byte) 111, (byte) 107, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createBoxAndWhiskerChart(string title, string timeAxisLabel, string valueAxisLabel, BoxAndWhiskerXYDataset dataset, bool legend)
    {
      int num = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(timeAxisLabel);
      NumberAxis numberAxis = new NumberAxis(valueAxisLabel);
      numberAxis.setAutoRangeIncludesZero(false);
      XYBoxAndWhiskerRenderer andWhiskerRenderer = new XYBoxAndWhiskerRenderer(10.0);
      XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) andWhiskerRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 101, (byte) 169, (byte) 103, (byte) 104, (byte) 153, (byte) 103, (byte) 99, (byte) 140, (byte) 99, (byte) 140, (byte) 109, (byte) 149, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createWindPlot(string title, string xAxisLabel, string yAxisLabel, WindDataset dataset, bool legend, bool tooltips, bool urls)
    {
      int num1 = tooltips ? 1 : 0;
      int num2 = urls ? 1 : 0;
      int num3 = legend ? 1 : 0;
      DateAxis dateAxis = new DateAxis(xAxisLabel);
      NumberAxis numberAxis = new NumberAxis(yAxisLabel);
      numberAxis.setRange(-12.0, 12.0);
      WindItemRenderer windItemRenderer = new WindItemRenderer();
      if (num1 != 0)
        windItemRenderer.setBaseToolTipGenerator((XYToolTipGenerator) new StandardXYToolTipGenerator());
      if (num2 != 0)
        windItemRenderer.setURLGenerator((XYURLGenerator) new StandardXYURLGenerator());
      XYPlot xyPlot = new XYPlot((XYDataset) dataset, (ValueAxis) dateAxis, (ValueAxis) numberAxis, (XYItemRenderer) windItemRenderer);
      JFreeChart.__\u003Cclinit\u003E();
      JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) xyPlot, num3 != 0);
      ChartFactory.currentTheme.apply(jfc);
      return jfc;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 91, (byte) 130, (byte) 99, (byte) 144, (byte) 103, (byte) 102, (byte) 135, (byte) 147, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JFreeChart createWaferMapChart(string title, WaferMapDataset dataset, PlotOrientation orientation, bool legend, bool tooltips, bool urls)
    {
      int num = legend ? 1 : 0;
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        WaferMapPlot waferMapPlot = new WaferMapPlot(dataset);
        WaferMapRenderer renderer = new WaferMapRenderer();
        waferMapPlot.setRenderer(renderer);
        JFreeChart.__\u003Cclinit\u003E();
        JFreeChart jfc = new JFreeChart(title, JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) waferMapPlot, num != 0);
        ChartFactory.currentTheme.apply(jfc);
        return jfc;
      }
    }
  }
}
