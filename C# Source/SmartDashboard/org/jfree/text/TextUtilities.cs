// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.lang;
using java.text;
using org.jfree.@base;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.text
{
  public class TextUtilities : Object
  {
    internal static LogContext __\u003C\u003Elogger = Log.createContext(TextUtilities.class\u0024org\u0024jfree\u0024text\u0024TextUtilities != null ? TextUtilities.class\u0024org\u0024jfree\u0024text\u0024TextUtilities : (TextUtilities.class\u0024org\u0024jfree\u0024text\u0024TextUtilities = TextUtilities.class\u0024("org.jfree.text.TextUtilities")));
    private static bool useDrawRotatedStringWorkaround;
    private static bool useFontMetricsGetStringBounds;
    internal static Class class\u0024org\u0024jfree\u0024text\u0024TextUtilities;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    protected internal static LogContext logger
    {
      [HideFromJava] get
      {
        return TextUtilities.__\u003C\u003Elogger;
      }
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 255, (byte) 9, (byte) 82, (byte) 134, (byte) 186, (byte) 109, (byte) 174, (byte) 208, (byte) 186, (byte) 109, (byte) 171, (byte) 255, (byte) 6, (byte) 73, (byte) 226, (byte) 59, (byte) 161, (byte) 102, (byte) 134})]
    static TextUtilities()
    {
      try
      {
        int num = ObjectUtilities.isJDK14() ? 1 : 0;
        string configProperty1 = BaseBoot.getInstance().getGlobalConfig().getConfigProperty("org.jfree.text.UseDrawRotatedStringWorkaround", "auto");
        TextUtilities.useDrawRotatedStringWorkaround = !String.instancehelper_equals(configProperty1, (object) "auto") ? String.instancehelper_equals(configProperty1, (object) "true") : num == 0;
        string configProperty2 = BaseBoot.getInstance().getGlobalConfig().getConfigProperty("org.jfree.text.UseFontMetricsGetStringBounds", "auto");
        if (String.instancehelper_equals(configProperty2, (object) "auto"))
        {
          TextUtilities.useFontMetricsGetStringBounds = num == 1;
          return;
        }
        else
        {
          TextUtilities.useFontMetricsGetStringBounds = String.instancehelper_equals(configProperty2, (object) "true");
          return;
        }
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      TextUtilities.useDrawRotatedStringWorkaround = true;
      TextUtilities.useFontMetricsGetStringBounds = true;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 103, (byte) 201, (byte) 147, (byte) 159, (byte) 0, (byte) 130, (byte) 105, (byte) 104, (byte) 108, (byte) 159, (byte) 5, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rectangle2D getTextBounds(string text, Graphics2D g2, FontMetrics fm)
    {
      Rectangle2D rectangle2D;
      if (TextUtilities.useFontMetricsGetStringBounds)
      {
        rectangle2D = fm.getStringBounds(text, (Graphics) g2);
        LineMetrics lineMetrics = fm.getFont().getLineMetrics(text, g2.getFontRenderContext());
        rectangle2D.setRect(((RectangularShape) rectangle2D).getX(), ((RectangularShape) rectangle2D).getY(), ((RectangularShape) rectangle2D).getWidth(), (double) lineMetrics.getHeight());
      }
      else
      {
        double num1 = (double) fm.stringWidth(text);
        double num2 = (double) fm.getHeight();
        if (TextUtilities.__\u003C\u003Elogger.isDebugEnabled())
          TextUtilities.__\u003C\u003Elogger.debug((object) new StringBuffer().append("Height = ").append(num2).toString());
        rectangle2D = (Rectangle2D) new Rectangle2D.Double(0.0, (double) -fm.getAscent(), num1, num2);
      }
      return rectangle2D;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 197, (byte) 112, (byte) 129, (byte) 138, (byte) 159, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void drawRotatedString(string text, Graphics2D g2, float x, float y, TextAnchor textAnchor, double angle, float rotationX, float rotationY)
    {
      if (text == null || String.instancehelper_equals(text, (object) ""))
        return;
      float[] numArray = TextUtilities.deriveTextBoundsAnchorOffsets(g2, text, textAnchor);
      TextUtilities.drawRotatedString(text, g2, x + numArray[0], y + numArray[1], angle, rotationX, rotationY);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 102, (byte) 102, (byte) 103, (byte) 98, (byte) 98, (byte) 104, (byte) 112, (byte) 142, (byte) 101, (byte) 111, (byte) 130, (byte) 113, (byte) 100, (byte) 99, (byte) 116, (byte) 134, (byte) 101, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 103, (byte) 106, (byte) 191, (byte) 13, (byte) 105, (byte) 156, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TextBlock createTextBlock(string text, Font font, Paint paint, float maxWidth, int maxLines, TextMeasurer measurer)
    {
      TextBlock textBlock = new TextBlock();
      BreakIterator lineInstance = BreakIterator.getLineInstance();
      lineInstance.setText(text);
      int num1 = 0;
      int num2 = 0;
      int num3 = String.instancehelper_length(text);
label_1:
      while (num1 < num3 && num2 < maxLines)
      {
        int num4 = TextUtilities.nextLineBreak(text, num1, maxWidth, lineInstance, measurer);
        if (num4 == -1)
        {
          textBlock.addLine(String.instancehelper_substring(text, num1), font, paint);
          return textBlock;
        }
        else
        {
          textBlock.addLine(String.instancehelper_substring(text, num1, num4), font, paint);
          ++num2;
          num1 = num4;
          while (true)
          {
            if (num1 < String.instancehelper_length(text) && (int) String.instancehelper_charAt(text, num1) == 10)
              ++num1;
            else
              goto label_1;
          }
        }
      }
      if (num1 < num3)
      {
        TextLine lastLine = textBlock.getLastLine();
        TextFragment lastTextFragment = lastLine.getLastTextFragment();
        string text1 = lastTextFragment.getText();
        string text2 = "...";
        if (String.instancehelper_length(text1) > 3)
          text2 = new StringBuffer().append(String.instancehelper_substring(text1, 0, String.instancehelper_length(text1) - 3)).append("...").toString();
        lastLine.removeFragment(lastTextFragment);
        TextFragment.__\u003Cclinit\u003E();
        TextFragment fragment = new TextFragment(text2, lastTextFragment.getFont(), lastTextFragment.getPaint());
        lastLine.addFragment(fragment);
      }
      return textBlock;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 130, (byte) 102, (byte) 98, (byte) 106, (byte) 100, (byte) 134, (byte) 111, (byte) 101, (byte) 130, (byte) 111, (byte) 101, (byte) 99, (byte) 111, (byte) 102, (byte) 101, (byte) 163, (byte) 163, (byte) 104, (byte) 195, (byte) 98, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int nextLineBreak([In] string obj0, [In] int obj1, [In] float obj2, [In] BreakIterator obj3, [In] TextMeasurer obj4)
    {
      int i1 = obj1;
      float num1 = 0.0f;
      int num2 = 1;
      int num3 = String.instancehelper_indexOf(obj0, 10, obj1);
      if (num3 < 0)
        num3 = int.MaxValue;
      int i2;
      while ((i2 = obj3.next()) != -1)
      {
        if (i2 > num3)
          return num3;
        num1 += obj4.getStringWidth(obj0, i1, i2);
        if ((double) num1 > (double) obj2)
        {
          if (num2 == 0)
            return obj3.previous();
          while ((double) obj4.getStringWidth(obj0, obj1, i2) > (double) obj2)
          {
            i2 += -1;
            if (i2 <= obj1)
              return i2;
          }
          return i2;
        }
        else
        {
          num2 = 0;
          i1 = i2;
        }
      }
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 29, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 106, (byte) 106, (byte) 105, (byte) 102, (byte) 107, (byte) 105, (byte) 105, (byte) 103, (byte) 135, (byte) 255, (byte) 9, (byte) 70, (byte) 180, (byte) 255, (byte) 9, (byte) 70, (byte) 203, (byte) 216, (byte) 184, (byte) 216, (byte) 169, (byte) 216, (byte) 191, (byte) 0, (byte) 216, (byte) 169, (byte) 216, (byte) 179, (byte) 99, (byte) 136, (byte) 101, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float[] deriveTextBoundsAnchorOffsets([In] Graphics2D obj0, [In] string obj1, [In] TextAnchor obj2, [In] Rectangle2D obj3)
    {
      float[] numArray = new float[3];
      FontRenderContext fontRenderContext = obj0.getFontRenderContext();
      Font font = ((Graphics) obj0).getFont();
      FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics(font);
      Rectangle2D textBounds = TextUtilities.getTextBounds(obj1, obj0, fontMetrics);
      LineMetrics lineMetrics = font.getLineMetrics(obj1, fontRenderContext);
      float ascent = lineMetrics.getAscent();
      numArray[2] = -ascent;
      float num1 = ascent / 2f;
      float descent = lineMetrics.getDescent();
      float leading = lineMetrics.getLeading();
      float num2 = 0.0f;
      float num3 = 0.0f;
      if (obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ECENTER || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER)
        num2 = (float) -((RectangularShape) textBounds).getWidth() / 2f;
      else if (obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num2 = (float) -((RectangularShape) textBounds).getWidth();
      if (obj2 == TextAnchor.__\u003C\u003ETOP_LEFT || obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT)
        num3 = -descent - leading + (float) ((RectangularShape) textBounds).getHeight();
      else if (obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num3 = num1;
      else if (obj2 == TextAnchor.__\u003C\u003ECENTER_LEFT || obj2 == TextAnchor.__\u003C\u003ECENTER || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT)
        num3 = -descent - leading + (float) (((RectangularShape) textBounds).getHeight() / 2.0);
      else if (obj2 == TextAnchor.__\u003C\u003EBASELINE_LEFT || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT)
        num3 = 0.0f;
      else if (obj2 == TextAnchor.__\u003C\u003EBOTTOM_LEFT || obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num3 = -lineMetrics.getDescent() - lineMetrics.getLeading();
      if (obj3 != null)
        obj3.setRect(textBounds);
      numArray[0] = num2;
      numArray[1] = num3;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 154, (byte) 112, (byte) 161, (byte) 167, (byte) 145, (byte) 135, (byte) 135, (byte) 152, (byte) 107, (byte) 162, (byte) 139, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void drawRotatedString(string text, Graphics2D g2, float textX, float textY, double angle, float rotateX, float rotateY)
    {
      if (text == null || String.instancehelper_equals(text, (object) ""))
        return;
      AffineTransform transform = g2.getTransform();
      AffineTransform rotateInstance = AffineTransform.getRotateInstance(angle, (double) rotateX, (double) rotateY);
      g2.transform(rotateInstance);
      if (TextUtilities.useDrawRotatedStringWorkaround)
      {
        TextLayout.__\u003Cclinit\u003E();
        new TextLayout(text, ((Graphics) g2).getFont(), g2.getFontRenderContext()).draw(g2, textX, textY);
      }
      else
        g2.drawString(text, textX, textY);
      g2.setTransform(transform);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 36, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 106, (byte) 106, (byte) 105, (byte) 107, (byte) 105, (byte) 105, (byte) 103, (byte) 135, (byte) 255, (byte) 9, (byte) 70, (byte) 180, (byte) 255, (byte) 9, (byte) 70, (byte) 203, (byte) 216, (byte) 184, (byte) 216, (byte) 169, (byte) 216, (byte) 191, (byte) 0, (byte) 216, (byte) 169, (byte) 216, (byte) 179, (byte) 101, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float[] deriveTextBoundsAnchorOffsets([In] Graphics2D obj0, [In] string obj1, [In] TextAnchor obj2)
    {
      float[] numArray = new float[2];
      FontRenderContext fontRenderContext = obj0.getFontRenderContext();
      Font font = ((Graphics) obj0).getFont();
      FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics(font);
      Rectangle2D textBounds = TextUtilities.getTextBounds(obj1, obj0, fontMetrics);
      LineMetrics lineMetrics = font.getLineMetrics(obj1, fontRenderContext);
      float num1 = lineMetrics.getAscent() / 2f;
      float descent = lineMetrics.getDescent();
      float leading = lineMetrics.getLeading();
      float num2 = 0.0f;
      float num3 = 0.0f;
      if (obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ECENTER || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER)
        num2 = (float) -((RectangularShape) textBounds).getWidth() / 2f;
      else if (obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num2 = (float) -((RectangularShape) textBounds).getWidth();
      if (obj2 == TextAnchor.__\u003C\u003ETOP_LEFT || obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT)
        num3 = -descent - leading + (float) ((RectangularShape) textBounds).getHeight();
      else if (obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num3 = num1;
      else if (obj2 == TextAnchor.__\u003C\u003ECENTER_LEFT || obj2 == TextAnchor.__\u003C\u003ECENTER || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT)
        num3 = -descent - leading + (float) (((RectangularShape) textBounds).getHeight() / 2.0);
      else if (obj2 == TextAnchor.__\u003C\u003EBASELINE_LEFT || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT)
        num3 = 0.0f;
      else if (obj2 == TextAnchor.__\u003C\u003EBOTTOM_LEFT || obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num3 = -lineMetrics.getDescent() - lineMetrics.getLeading();
      numArray[0] = num2;
      numArray[1] = num3;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 123, (byte) 103, (byte) 103, (byte) 110, (byte) 103, (byte) 106, (byte) 104, (byte) 107, (byte) 104, (byte) 104, (byte) 103, (byte) 135, (byte) 255, (byte) 9, (byte) 70, (byte) 172, (byte) 255, (byte) 9, (byte) 70, (byte) 179, (byte) 255, (byte) 9, (byte) 70, (byte) 202, (byte) 216, (byte) 183, (byte) 216, (byte) 191, (byte) 2, (byte) 216, (byte) 167, (byte) 216, (byte) 169, (byte) 216, (byte) 176, (byte) 101, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float[] deriveRotationAnchorOffsets([In] Graphics2D obj0, [In] string obj1, [In] TextAnchor obj2)
    {
      float[] numArray = new float[2];
      FontRenderContext fontRenderContext = obj0.getFontRenderContext();
      LineMetrics lineMetrics = ((Graphics) obj0).getFont().getLineMetrics(obj1, fontRenderContext);
      FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics();
      Rectangle2D textBounds = TextUtilities.getTextBounds(obj1, obj0, fontMetrics);
      float num1 = lineMetrics.getAscent() / 2f;
      float descent = lineMetrics.getDescent();
      float leading = lineMetrics.getLeading();
      float num2 = 0.0f;
      float num3 = 0.0f;
      if (obj2 == TextAnchor.__\u003C\u003ETOP_LEFT || obj2 == TextAnchor.__\u003C\u003ECENTER_LEFT || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_LEFT || obj2 == TextAnchor.__\u003C\u003EBASELINE_LEFT) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT)
        num2 = 0.0f;
      else if (obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ECENTER || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER)
        num2 = (float) ((RectangularShape) textBounds).getWidth() / 2f;
      else if (obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT || (obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT) || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num2 = (float) ((RectangularShape) textBounds).getWidth();
      if (obj2 == TextAnchor.__\u003C\u003ETOP_LEFT || obj2 == TextAnchor.__\u003C\u003ETOP_CENTER || obj2 == TextAnchor.__\u003C\u003ETOP_RIGHT)
        num3 = descent + leading - (float) ((RectangularShape) textBounds).getHeight();
      else if (obj2 == TextAnchor.__\u003C\u003ECENTER_LEFT || obj2 == TextAnchor.__\u003C\u003ECENTER || obj2 == TextAnchor.__\u003C\u003ECENTER_RIGHT)
        num3 = descent + leading - (float) (((RectangularShape) textBounds).getHeight() / 2.0);
      else if (obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER || obj2 == TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT)
        num3 = -num1;
      else if (obj2 == TextAnchor.__\u003C\u003EBASELINE_LEFT || obj2 == TextAnchor.__\u003C\u003EBASELINE_CENTER || obj2 == TextAnchor.__\u003C\u003EBASELINE_RIGHT)
        num3 = 0.0f;
      else if (obj2 == TextAnchor.__\u003C\u003EBOTTOM_LEFT || obj2 == TextAnchor.__\u003C\u003EBOTTOM_CENTER || obj2 == TextAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num3 = lineMetrics.getDescent() + lineMetrics.getLeading();
      numArray[0] = num2;
      numArray[1] = num3;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 223, (byte) 112, (byte) 130, (byte) 103, (byte) 105, (byte) 140, (byte) 104, (byte) 146, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape calculateRotatedStringBounds(string text, Graphics2D g2, float textX, float textY, double angle, float rotateX, float rotateY)
    {
      if (text == null || String.instancehelper_equals(text, (object) ""))
        return (Shape) null;
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
      Rectangle2D textBounds = TextUtilities.getTextBounds(text, g2, fontMetrics);
      Shape transformedShape = AffineTransform.getTranslateInstance((double) textX, (double) textY).createTransformedShape((Shape) textBounds);
      return AffineTransform.getRotateInstance(angle, (double) rotateX, (double) rotateY).createTransformedShape(transformedShape);
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, TextUtilities.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 104, (byte) 99, (byte) 144, (byte) 102, (byte) 98, (byte) 106, (byte) 98, (byte) 102, (byte) 108, (byte) 100, (byte) 106, (byte) 107, (byte) 106, (byte) 172, (byte) 130, (byte) 98, (byte) 99, (byte) 107, (byte) 172, (byte) 196, (byte) 105, (byte) 130, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TextBlock createTextBlock(string text, Font font, Paint paint)
    {
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TextBlock textBlock = new TextBlock();
        string text1 = text;
        int num1 = String.instancehelper_length(text) > 0 ? 1 : 0;
        while (num1 != 0)
        {
          int num2 = String.instancehelper_indexOf(text1, "\n");
          if (num2 > 0)
          {
            string text2 = String.instancehelper_substring(text1, 0, num2);
            if (num2 < String.instancehelper_length(text1) - 1)
            {
              textBlock.addLine(text2, font, paint);
              text1 = String.instancehelper_substring(text1, num2 + 1);
            }
            else
              num1 = 0;
          }
          else if (num2 == 0)
          {
            if (num2 < String.instancehelper_length(text1) - 1)
              text1 = String.instancehelper_substring(text1, num2 + 1);
            else
              num1 = 0;
          }
          else
          {
            textBlock.addLine(text1, font, paint);
            num1 = 0;
          }
        }
        return textBlock;
      }
    }

    [LineNumberTable((ushort) 206)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TextBlock createTextBlock(string text, Font font, Paint paint, float maxWidth, TextMeasurer measurer)
    {
      return TextUtilities.createTextBlock(text, font, paint, maxWidth, int.MaxValue, measurer);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 102, (byte) 171, (byte) 159, (byte) 8, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rectangle2D drawAlignedString(string text, Graphics2D g2, float x, float y, TextAnchor anchor)
    {
      Rectangle2D.Double @double = new Rectangle2D.Double();
      float[] numArray = TextUtilities.deriveTextBoundsAnchorOffsets(g2, text, anchor, (Rectangle2D) @double);
      ((Rectangle2D) @double).setRect((double) (x + numArray[0]), (double) (y + numArray[1] + numArray[2]), ((RectangularShape) @double).getWidth(), ((RectangularShape) @double).getHeight());
      g2.drawString(text, x + numArray[0], y + numArray[1]);
      return (Rectangle2D) @double;
    }

    public static void setUseDrawRotatedStringWorkaround(bool use)
    {
      TextUtilities.useDrawRotatedStringWorkaround = use;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void drawRotatedString(string text, Graphics2D g2, double angle, float x, float y)
    {
      TextUtilities.drawRotatedString(text, g2, x, y, angle, x, y);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 222, (byte) 112, (byte) 129, (byte) 138, (byte) 138, (byte) 223, (byte) 19})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void drawRotatedString(string text, Graphics2D g2, float x, float y, TextAnchor textAnchor, double angle, TextAnchor rotationAnchor)
    {
      if (text == null || String.instancehelper_equals(text, (object) ""))
        return;
      float[] numArray1 = TextUtilities.deriveTextBoundsAnchorOffsets(g2, text, textAnchor);
      float[] numArray2 = TextUtilities.deriveRotationAnchorOffsets(g2, text, rotationAnchor);
      TextUtilities.drawRotatedString(text, g2, x + numArray1[0], y + numArray1[1], angle, x + numArray1[0] + numArray2[0], y + numArray1[1] + numArray2[1]);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 254, (byte) 112, (byte) 130, (byte) 138, (byte) 108, (byte) 191, (byte) 25, (byte) 138, (byte) 108, (byte) 191, (byte) 25, (byte) 191, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Shape calculateRotatedStringBounds(string text, Graphics2D g2, float x, float y, TextAnchor textAnchor, double angle, TextAnchor rotationAnchor)
    {
      if (text == null || String.instancehelper_equals(text, (object) ""))
        return (Shape) null;
      float[] numArray1 = TextUtilities.deriveTextBoundsAnchorOffsets(g2, text, textAnchor);
      if (TextUtilities.__\u003C\u003Elogger.isDebugEnabled())
        TextUtilities.__\u003C\u003Elogger.debug((object) new StringBuffer().append("TextBoundsAnchorOffsets = ").append(numArray1[0]).append(", ").append(numArray1[1]).toString());
      float[] numArray2 = TextUtilities.deriveRotationAnchorOffsets(g2, text, rotationAnchor);
      if (TextUtilities.__\u003C\u003Elogger.isDebugEnabled())
        TextUtilities.__\u003C\u003Elogger.debug((object) new StringBuffer().append("RotationAnchorOffsets = ").append(numArray2[0]).append(", ").append(numArray2[1]).toString());
      return TextUtilities.calculateRotatedStringBounds(text, g2, x + numArray1[0], y + numArray1[1], angle, x + numArray1[0] + numArray2[0], y + numArray1[1] + numArray2[1]);
    }

    public static bool getUseFontMetricsGetStringBounds()
    {
      return TextUtilities.useFontMetricsGetStringBounds;
    }

    public static void setUseFontMetricsGetStringBounds(bool use)
    {
      TextUtilities.useFontMetricsGetStringBounds = use;
    }

    public static bool isUseDrawRotatedStringWorkaround()
    {
      return TextUtilities.useDrawRotatedStringWorkaround;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TextUtilities.__\u003CcallerID\u003E == null)
        TextUtilities.__\u003CcallerID\u003E = (CallerID) new TextUtilities.__\u003CCallerID\u003E();
      return TextUtilities.__\u003CcallerID\u003E;
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
