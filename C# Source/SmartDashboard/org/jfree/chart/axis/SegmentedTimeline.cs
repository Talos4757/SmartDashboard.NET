// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.SegmentedTimeline
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"org.jfree.chart.axis.Timeline", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class SegmentedTimeline : Object, Timeline, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    [Obsolete]
    public static TimeZone DEFAULT_TIME_ZONE = TimeZone.getDefault();
    private const long serialVersionUID = 1093779862539903110L;
    public const long DAY_SEGMENT_SIZE = 86400000L;
    public const long HOUR_SEGMENT_SIZE = 3600000L;
    public const long FIFTEEN_MINUTE_SEGMENT_SIZE = 900000L;
    public const long MINUTE_SEGMENT_SIZE = 60000L;
    [Obsolete]
    public static long FIRST_MONDAY_AFTER_1900;
    [Obsolete]
    public static TimeZone NO_DST_TIME_ZONE;
    private Calendar workingCalendarNoDST;
    private Calendar workingCalendar;
    private long segmentSize;
    private int segmentsIncluded;
    private int segmentsExcluded;
    private int groupSegmentCount;
    private long startTime;
    private long segmentsIncludedSize;
    private long segmentsExcludedSize;
    private long segmentsGroupSize;
    private List exceptionSegments;
    private SegmentedTimeline baseTimeline;
    private bool adjustForDaylightSaving;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 234, (byte) 160, (byte) 71, (byte) 107, (byte) 223, (byte) 11, (byte) 112, (byte) 112, (byte) 105, (byte) 106, (byte) 202, (byte) 112})]
    static SegmentedTimeline()
    {
      int rawOffset = TimeZone.getDefault().getRawOffset();
      SimpleTimeZone.__\u003Cclinit\u003E();
      SegmentedTimeline.NO_DST_TIME_ZONE = (TimeZone) new SimpleTimeZone(rawOffset, new StringBuffer().append("UTC-").append(rawOffset).toString());
      GregorianCalendar.__\u003Cclinit\u003E();
      GregorianCalendar gregorianCalendar = new GregorianCalendar(SegmentedTimeline.NO_DST_TIME_ZONE);
      ((Calendar) gregorianCalendar).set(1900, 0, 1, 0, 0, 0);
      ((Calendar) gregorianCalendar).set(14, 0);
      while (((Calendar) gregorianCalendar).get(7) != 2)
        ((Calendar) gregorianCalendar).add(5, 1);
      SegmentedTimeline.FIRST_MONDAY_AFTER_1900 = ((Calendar) gregorianCalendar).getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 232, (byte) 159, (byte) 161, (byte) 235, (byte) 101, (byte) 235, (byte) 79, (byte) 231, (byte) 109, (byte) 103, (byte) 103, (byte) 135, (byte) 115, (byte) 116, (byte) 116, (byte) 147, (byte) 107, (byte) 127, (byte) 7, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SegmentedTimeline(long segmentSize, int segmentsIncluded, int segmentsExcluded)
    {
      base.\u002Ector();
      SegmentedTimeline segmentedTimeline = this;
      this.workingCalendar = Calendar.getInstance();
      this.exceptionSegments = (List) new ArrayList();
      this.adjustForDaylightSaving = false;
      this.segmentSize = segmentSize;
      this.segmentsIncluded = segmentsIncluded;
      this.segmentsExcluded = segmentsExcluded;
      this.groupSegmentCount = this.segmentsIncluded + this.segmentsExcluded;
      this.segmentsIncludedSize = (long) this.segmentsIncluded * this.segmentSize;
      this.segmentsExcludedSize = (long) this.segmentsExcluded * this.segmentSize;
      this.segmentsGroupSize = this.segmentsIncludedSize + this.segmentsExcludedSize;
      int rawOffset = TimeZone.getDefault().getRawOffset();
      SimpleTimeZone.__\u003Cclinit\u003E();
      SimpleTimeZone simpleTimeZone = new SimpleTimeZone(rawOffset, new StringBuffer().append("UTC-").append(rawOffset).toString());
      GregorianCalendar.__\u003Cclinit\u003E();
      this.workingCalendarNoDST = (Calendar) new GregorianCalendar((TimeZone) simpleTimeZone, Locale.getDefault());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SegmentedTimeline([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SegmentedTimeline obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SegmentedTimeline obj0)
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

    public virtual long getStartTime()
    {
      return this.startTime;
    }

    [LineNumberTable((ushort) 167)]
    internal static long access\u0024000([In] SegmentedTimeline obj0)
    {
      return obj0.startTime;
    }

    [LineNumberTable((ushort) 167)]
    internal static long access\u0024100([In] SegmentedTimeline obj0)
    {
      return obj0.segmentSize;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 70, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getDate(long value)
    {
      this.workingCalendarNoDST.setTime(new Date(value));
      return this.workingCalendarNoDST.getTime();
    }

    [LineNumberTable((ushort) 167)]
    internal static int access\u0024200([In] SegmentedTimeline obj0)
    {
      return obj0.segmentsIncluded;
    }

    [LineNumberTable((ushort) 167)]
    internal static int access\u0024300([In] SegmentedTimeline obj0)
    {
      return obj0.groupSegmentCount;
    }

    [LineNumberTable((ushort) 167)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int access\u0024400([In] SegmentedTimeline obj0, [In] SegmentedTimeline.Segment obj1)
    {
      return obj0.binarySearchExceptionSegments(obj1);
    }

    [LineNumberTable((ushort) 1057)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SegmentedTimeline.Segment getSegment(long millisecond)
    {
      return new SegmentedTimeline.Segment(this, millisecond);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 7, (byte) 98, (byte) 142, (byte) 103, (byte) 102, (byte) 178, (byte) 114, (byte) 162, (byte) 105, (byte) 134, (byte) 105, (byte) 166, (byte) 144, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int binarySearchExceptionSegments([In] SegmentedTimeline.Segment obj0)
    {
      int num1 = 0;
      int num2 = this.exceptionSegments.size() - 1;
      while (num1 <= num2)
      {
        int num3 = (num1 + num2) / 2;
        SegmentedTimeline.Segment segment = (SegmentedTimeline.Segment) this.exceptionSegments.get(num3);
        if (obj0.contains(segment) || segment.contains(obj0))
          return num3;
        if (segment.before(obj0))
          num1 = num3 + 1;
        else if (segment.after(obj0))
        {
          num2 = num3 - 1;
        }
        else
        {
          string str = "Invalid condition.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalStateException(str);
        }
      }
      return -(num1 + 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 107, (byte) 223, (byte) 7, (byte) 103, (byte) 112, (byte) 105, (byte) 106, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long firstMondayAfter1900()
    {
      int rawOffset = TimeZone.getDefault().getRawOffset();
      SimpleTimeZone.__\u003Cclinit\u003E();
      GregorianCalendar gregorianCalendar = new GregorianCalendar((TimeZone) new SimpleTimeZone(rawOffset, new StringBuffer().append("UTC-").append(rawOffset).toString()));
      ((Calendar) gregorianCalendar).set(1900, 0, 1, 0, 0, 0);
      ((Calendar) gregorianCalendar).set(14, 0);
      while (((Calendar) gregorianCalendar).get(7) != 2)
        ((Calendar) gregorianCalendar).add(5, 1);
      return ((Calendar) gregorianCalendar).getTime().getTime();
    }

    public virtual void setStartTime(long millisecond)
    {
      this.startTime = millisecond;
    }

    public virtual long getSegmentSize()
    {
      return this.segmentSize;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 142, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SegmentedTimeline newMondayThroughFridayTimeline()
    {
      SegmentedTimeline segmentedTimeline = new SegmentedTimeline(86400000L, 5, 2);
      segmentedTimeline.setStartTime(SegmentedTimeline.firstMondayAfter1900());
      return segmentedTimeline;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 188, (byte) 102, (byte) 110, (byte) 208, (byte) 110, (byte) 176, (byte) 124, (byte) 208, (byte) 159, (byte) 4, (byte) 240, (byte) 69, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseTimeline(SegmentedTimeline baseTimeline)
    {
      if (baseTimeline != null)
      {
        if (baseTimeline.getSegmentSize() < this.segmentSize)
        {
          string str = "baseTimeline.getSegmentSize() is smaller than segmentSize";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else if (baseTimeline.getStartTime() > this.startTime)
        {
          string str = "baseTimeline.getStartTime() is after startTime";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          long segmentSize = baseTimeline.getSegmentSize();
          long num1 = this.segmentSize;
          long num2 = -1L;
          if ((num1 != num2 ? segmentSize % num1 : 0L) != 0L)
          {
            string str = "baseTimeline.getSegmentSize() is not multiple of segmentSize";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
          else
          {
            long num3 = this.startTime - baseTimeline.getStartTime();
            long num4 = this.segmentSize;
            long num5 = -1L;
            if ((num4 != num5 ? num3 % num4 : 0L) != 0L)
            {
              string str = "baseTimeline is not aligned";
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new IllegalArgumentException(str);
            }
          }
        }
      }
      this.baseTimeline = baseTimeline;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 225, (byte) 105, (byte) 116, (byte) 146, (byte) 105, (byte) 222, (byte) 105, (byte) 137, (byte) 110, (byte) 191, (byte) 8, (byte) 104, (byte) 133, (byte) 106, (byte) 118, (byte) 148, (byte) 242, (byte) 74, (byte) 106, (byte) 249, (byte) 70, (byte) 247, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long toTimelineValue(long millisecond)
    {
      long num1 = millisecond - this.startTime;
      long num2 = num1;
      long num3 = this.segmentsGroupSize;
      long num4 = -1L;
      long num5 = num3 != num4 ? num2 % num3 : 0L;
      long num6 = num1;
      long num7 = this.segmentsGroupSize;
      long num8 = -1L;
      long num9 = num7 != num8 ? num6 / num7 : -num6;
      long num10;
      if (num5 >= this.segmentsIncludedSize)
      {
        num10 = this.toTimelineValue(this.startTime + this.segmentsGroupSize * (num9 + 1L));
      }
      else
      {
        SegmentedTimeline.Segment segment = this.getSegment(millisecond);
        if (segment.inExceptionSegments())
        {
          int num11;
          while ((num11 = this.binarySearchExceptionSegments(segment)) >= 0)
            segment = this.getSegment(millisecond = ((SegmentedTimeline.Segment) this.exceptionSegments.get(num11)).getSegmentEnd() + 1L);
          num10 = this.toTimelineValue(millisecond);
        }
        else
        {
          long num11 = millisecond - this.startTime;
          long num12 = num11;
          long num13 = this.segmentsGroupSize;
          long num14 = -1L;
          long num15 = num13 != num14 ? num12 % num13 : 0L;
          long num16 = num11;
          long num17 = this.segmentsGroupSize;
          long num18 = -1L;
          long num19 = num17 != num18 ? num16 / num17 : -num16;
          long exceptionSegmentCount = this.getExceptionSegmentCount(this.startTime, millisecond - 1L);
          num10 = num15 >= this.segmentsIncludedSize ? this.segmentsIncludedSize * (num19 + 1L) - exceptionSegmentCount * this.segmentSize : this.segmentsIncludedSize * num19 + num15 - exceptionSegmentCount * this.segmentSize;
        }
      }
      return num10;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 145, (byte) 100, (byte) 163, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 137, (byte) 99, (byte) 139, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getExceptionSegmentCount(long fromMillisecond, long toMillisecond)
    {
      if (toMillisecond < fromMillisecond)
        return 0L;
      int num = 0;
      Iterator iterator = this.exceptionSegments.iterator();
      while (iterator.hasNext())
      {
        SegmentedTimeline.Segment segment = ((SegmentedTimeline.Segment) iterator.next()).intersect(fromMillisecond, toMillisecond);
        if (segment != null)
          num = (int) ((long) num + segment.getSegmentCount());
      }
      return (long) num;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 43, (byte) 103, (byte) 107, (byte) 108, (byte) 255, (byte) 55, (byte) 71, (byte) 154, (byte) 108, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getTime(Date date)
    {
      long time = date.getTime();
      if (this.adjustForDaylightSaving)
      {
        this.workingCalendar.setTime(date);
        this.workingCalendarNoDST.set(this.workingCalendar.get(1), this.workingCalendar.get(2), this.workingCalendar.get(5), this.workingCalendar.get(11), this.workingCalendar.get(12), this.workingCalendar.get(13));
        this.workingCalendarNoDST.set(14, this.workingCalendar.get(14));
        time = this.workingCalendarNoDST.getTime().getTime();
      }
      return time;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 91, (byte) 98, (byte) 107, (byte) 113, (byte) 255, (byte) 55, (byte) 72, (byte) 218, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getTimeFromLong(long date)
    {
      long num = date;
      if (this.adjustForDaylightSaving)
      {
        this.workingCalendarNoDST.setTime(new Date(date));
        this.workingCalendar.set(this.workingCalendarNoDST.get(1), this.workingCalendarNoDST.get(2), this.workingCalendarNoDST.get(5), this.workingCalendarNoDST.get(11), this.workingCalendarNoDST.get(12), this.workingCalendarNoDST.get(13));
        this.workingCalendar.set(14, this.workingCalendarNoDST.get(14));
        num = this.workingCalendar.getTime().getTime();
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 119, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsDomainValue(long millisecond)
    {
      return (this.getSegment(millisecond).inIncludeSegments() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 146, (byte) 100, (byte) 223, (byte) 32, (byte) 104, (byte) 130, (byte) 103, (byte) 105, (byte) 162, (byte) 166, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsDomainRange(long domainValueStart, long domainValueEnd)
    {
      if (domainValueEnd < domainValueStart)
      {
        string str = new StringBuffer().append("domainValueEnd (").append(domainValueEnd).append(") < domainValueStart (").append(domainValueStart).append(")").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        SegmentedTimeline.Segment segment = this.getSegment(domainValueStart);
        int num;
        do
        {
          num = segment.inIncludeSegments() ? 1 : 0;
          if (!segment.contains(domainValueEnd))
            segment.inc();
          else
            break;
        }
        while (num != 0);
        return num != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 6, (byte) 104, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addException([In] SegmentedTimeline.Segment obj0)
    {
      if (!obj0.inIncludeSegments())
        return;
      this.exceptionSegments.add(-(this.binarySearchExceptionSegments(obj0) + 1), (object) obj0);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 195, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addException(long millisecond)
    {
      this.addException(new SegmentedTimeline.Segment(this, millisecond));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 229, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addException(Date exceptionDate)
    {
      this.addException(this.getTime(exceptionDate));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 214, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addException(long fromDomainValue, long toDomainValue)
    {
      this.addException((SegmentedTimeline.Segment) new SegmentedTimeline.SegmentRange(this, fromDomainValue, toDomainValue));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 30, (byte) 109, (byte) 203, (byte) 109, (byte) 110, (byte) 168, (byte) 167, (byte) 103, (byte) 134, (byte) 168, (byte) 136, (byte) 162, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addBaseTimelineException(long domainValue)
    {
      SegmentedTimeline.Segment segment1 = this.baseTimeline.getSegment(domainValue);
      if (!segment1.inIncludeSegments())
        return;
      SegmentedTimeline.Segment segment2 = this.getSegment(segment1.getSegmentStart());
      while (segment2.getSegmentStart() <= segment1.getSegmentEnd())
      {
        if (segment2.inIncludeSegments())
        {
          long segmentStart = segment2.getSegmentStart();
          long segmentEnd;
          do
          {
            segmentEnd = segment2.getSegmentEnd();
            segment2.inc();
          }
          while (segment2.inIncludeSegments());
          this.addException(segmentStart, segmentEnd);
        }
        else
          segment2.inc();
      }
    }

    public virtual int getSegmentsExcluded()
    {
      return this.segmentsExcluded;
    }

    public virtual int getGroupSegmentCount()
    {
      return this.groupSegmentCount;
    }

    public virtual int getSegmentsIncluded()
    {
      return this.segmentsIncluded;
    }

    [LineNumberTable((ushort) 529)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getExceptionSegments()
    {
      return Collections.unmodifiableList(this.exceptionSegments);
    }

    [LineNumberTable((ushort) 1089)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool equals([In] object obj0, [In] object obj1)
    {
      return obj0 == obj1 || obj0 != null && Object.instancehelper_equals(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 144, (byte) 150, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SegmentedTimeline newFifteenMinuteTimeline()
    {
      SegmentedTimeline segmentedTimeline = new SegmentedTimeline(900000L, 28, 68);
      segmentedTimeline.setStartTime(SegmentedTimeline.firstMondayAfter1900() + 36L * segmentedTimeline.getSegmentSize());
      segmentedTimeline.setBaseTimeline(SegmentedTimeline.newMondayThroughFridayTimeline());
      return segmentedTimeline;
    }

    public virtual bool getAdjustForDaylightSaving()
    {
      return this.adjustForDaylightSaving;
    }

    public virtual void setAdjustForDaylightSaving(bool adjust)
    {
      this.adjustForDaylightSaving = adjust;
    }

    public virtual long getSegmentsExcludedSize()
    {
      return this.segmentsExcludedSize;
    }

    public virtual long getSegmentsGroupSize()
    {
      return this.segmentsGroupSize;
    }

    public virtual long getSegmentsIncludedSize()
    {
      return this.segmentsIncludedSize;
    }

    public virtual void setExceptionSegments(List exceptionSegments)
    {
      this.exceptionSegments = exceptionSegments;
    }

    public virtual SegmentedTimeline getBaseTimeline()
    {
      return this.baseTimeline;
    }

    [LineNumberTable((ushort) 656)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long toTimelineValue(Date date)
    {
      return this.toTimelineValue(this.getTime(date));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 44, (byte) 223, (byte) 9, (byte) 167, (byte) 236, (byte) 70, (byte) 159, (byte) 14, (byte) 167, (byte) 135, (byte) 134, (byte) 232, (byte) 60, (byte) 235, (byte) 71, (byte) 167, (byte) 112, (byte) 102, (byte) 171, (byte) 101, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long toMillisecond(long timelineValue)
    {
      long num1 = this.startTime + timelineValue;
      long num2 = timelineValue;
      long num3 = this.segmentsIncludedSize;
      long num4 = -1L;
      long num5 = (num3 != num4 ? num2 / num3 : -num2) * this.segmentsExcludedSize;
      SegmentedTimeline.Segment segment = new SegmentedTimeline.Segment(this, num1 + num5);
      for (long index = this.startTime; index <= segment.segmentStart; {
        long num6;
        index = num6 + 1L;
      }
      )
      {
label_2:
        long fromMillisecond = index;
        long num6 = segment.millisecond;
        long num7 = this.segmentSize;
        long num8 = -1L;
        long toMillisecond = (num7 != num8 ? num6 / num7 : -num6) * this.segmentSize - 1L;
        long exceptionSegmentCount;
        if ((exceptionSegmentCount = this.getExceptionSegmentCount(fromMillisecond, toMillisecond)) > 0L)
        {
          index = segment.segmentStart;
          int num9 = 0;
          while (true)
          {
            if ((long) num9 < exceptionSegmentCount)
            {
              do
              {
                segment.inc();
              }
              while (segment.inExcludeSegments());
              ++num9;
            }
            else
              goto label_2;
          }
        }
        else
        {
          num6 = segment.segmentStart;
          while (segment.inExceptionSegments() || segment.inExcludeSegments())
          {
            segment.inc();
            num6 += this.segmentSize;
          }
        }
      }
      return this.getTimeFromLong(segment.millisecond);
    }

    [LineNumberTable((ushort) 757)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsDomainValue(Date date)
    {
      return (this.containsDomainValue(this.getTime(date)) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 804)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsDomainRange(Date dateDomainValueStart, Date dateDomainValueEnd)
    {
      return (this.containsDomainRange(this.getTime(dateDomainValueStart), this.getTime(dateDomainValueEnd)) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 246, (byte) 111, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addExceptions(List exceptionList)
    {
      Iterator iterator = exceptionList.iterator();
      while (iterator.hasNext())
        this.addException((Date) iterator.next());
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 73, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addBaseTimelineException(Date date)
    {
      this.addBaseTimelineException(this.getTime(date));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 89, (byte) 141, (byte) 145, (byte) 232, (byte) 69, (byte) 140, (byte) 255, (byte) 4, (byte) 70, (byte) 109, (byte) 105, (byte) 168, (byte) 167, (byte) 104, (byte) 134, (byte) 168, (byte) 143, (byte) 162, (byte) 232, (byte) 69, (byte) 114, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addBaseTimelineExclusions(long fromBaseDomainValue, long toBaseDomainValue)
    {
      SegmentedTimeline.Segment segment1 = this.baseTimeline.getSegment(fromBaseDomainValue);
      while (segment1.getSegmentStart() <= toBaseDomainValue && !segment1.inExcludeSegments())
        segment1.inc();
      while (segment1.getSegmentStart() <= toBaseDomainValue)
      {
        long num = segment1.getSegmentStart() + (long) this.baseTimeline.getSegmentsExcluded() * this.baseTimeline.getSegmentSize() - 1L;
        SegmentedTimeline.Segment segment2 = this.getSegment(segment1.getSegmentStart());
        while (segment2.getSegmentStart() <= num)
        {
          if (segment2.inIncludeSegments())
          {
            long segmentStart = segment2.getSegmentStart();
            long segmentEnd;
            do
            {
              segmentEnd = segment2.getSegmentEnd();
              segment2.inc();
            }
            while (segment2.inIncludeSegments());
            this.addException((SegmentedTimeline.Segment) new SegmentedTimeline.BaseTimelineSegmentRange(this, segmentStart, segmentEnd));
          }
          else
            segment2.inc();
        }
        segment1.inc((long) this.baseTimeline.getGroupSegmentCount());
      }
    }

    [LineNumberTable((ushort) 1075)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SegmentedTimeline.Segment getSegment(Date date)
    {
      return this.getSegment(this.getTime(date));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 218, (byte) 107, (byte) 135, (byte) 111, (byte) 111, (byte) 111, (byte) 112, (byte) 148, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (!(o is SegmentedTimeline))
        return false;
      SegmentedTimeline segmentedTimeline = (SegmentedTimeline) o;
      return this.segmentSize == segmentedTimeline.getSegmentSize() && this.segmentsIncluded == segmentedTimeline.getSegmentsIncluded() && (this.segmentsExcluded == segmentedTimeline.getSegmentsExcluded() && this.startTime == segmentedTimeline.getStartTime()) && this.equals((object) this.exceptionSegments, (object) segmentedTimeline.getExceptionSegments());
    }

    public virtual int hashCode()
    {
      return 37 * (37 * 19 + (int) (this.segmentSize ^ (long) ((ulong) this.segmentSize >> 32))) + (int) (this.startTime ^ (long) ((ulong) this.startTime >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 82, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (SegmentedTimeline) base.clone();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [InnerClass]
    [SourceFile("SegmentedTimeline.java")]
    [Serializable]
    public class BaseTimelineSegmentRange : SegmentedTimeline.SegmentRange
    {
      [Modifiers]
      private SegmentedTimeline this\u00240;

      [LineNumberTable(new byte[] {(byte) 166, (byte) 96, (byte) 43, (byte) 135})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BaseTimelineSegmentRange(SegmentedTimeline st, long fromDomainValue, long toDomainValue)
        : base(st, fromDomainValue, toDomainValue)
      {
        SegmentedTimeline.BaseTimelineSegmentRange timelineSegmentRange = this;
        this.this\u00240 = st;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BaseTimelineSegmentRange([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.Comparable", "java.lang.Cloneable", "java.io.Serializable"})]
    [SourceFile("SegmentedTimeline.java")]
    [Serializable]
    public class Segment : Object, Comparable, Cloneable.__Interface, Serializable.__Interface, ISerializable
    {
      protected internal long segmentNumber;
      protected internal long segmentStart;
      protected internal long segmentEnd;
      protected internal long millisecond;
      [Modifiers]
      private SegmentedTimeline this\u00240;

      [LineNumberTable(new byte[] {(byte) 164, (byte) 111, (byte) 143})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Segment(SegmentedTimeline st)
      {
        base.\u002Ector();
        SegmentedTimeline.Segment segment = this;
        this.this\u00240 = st;
      }

      [LineNumberTable(new byte[] {(byte) 164, (byte) 120, (byte) 111, (byte) 109, (byte) 154, (byte) 150, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Segment(SegmentedTimeline st, long millisecond)
      {
        base.\u002Ector();
        SegmentedTimeline.Segment segment = this;
        this.this\u00240 = st;
        this.segmentNumber = this.calculateSegmentNumber(millisecond);
        this.segmentStart = SegmentedTimeline.access\u0024000(st) + this.segmentNumber * SegmentedTimeline.access\u0024100(st);
        this.segmentEnd = this.segmentStart + SegmentedTimeline.access\u0024100(st) - 1L;
        this.millisecond = millisecond;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Segment([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector();
        Serialization.readObject((object) this, obj0);
      }

      [HideFromJava]
      public static implicit operator Cloneable([In] SegmentedTimeline.Segment obj0)
      {
        Cloneable cloneable;
        cloneable.__\u003Cref\u003E = (__Null) obj0;
        return cloneable;
      }

      [HideFromJava]
      public static implicit operator Serializable([In] SegmentedTimeline.Segment obj0)
      {
        Serializable serializable;
        serializable.__\u003Cref\u003E = (__Null) obj0;
        return serializable;
      }

      [LineNumberTable(new byte[] {(byte) 164, (byte) 137, (byte) 110, (byte) 223, (byte) 4})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual long calculateSegmentNumber(long millis)
      {
        if (millis >= SegmentedTimeline.access\u0024000(this.this\u00240))
        {
          long num1 = millis - SegmentedTimeline.access\u0024000(this.this\u00240);
          long num2 = SegmentedTimeline.access\u0024100(this.this\u00240);
          long num3 = -1L;
          if (num2 == num3)
            return -num1;
          else
            return num1 / num2;
        }
        else
        {
          long num1 = millis - SegmentedTimeline.access\u0024000(this.this\u00240);
          long num2 = SegmentedTimeline.access\u0024100(this.this\u00240);
          long num3 = -1L;
          return (num2 != num3 ? num1 / num2 : -num1) - 1L;
        }
      }

      public virtual long getSegmentStart()
      {
        return this.segmentStart;
      }

      public virtual long getSegmentEnd()
      {
        return this.segmentEnd;
      }

      public virtual bool contains(long from, long to)
      {
        return this.segmentStart <= from && to <= this.segmentEnd;
      }

      public virtual long getSegmentNumber()
      {
        return this.segmentNumber;
      }

      public virtual long getMillisecond()
      {
        return this.millisecond;
      }

      [LineNumberTable((ushort) 1422)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool before(SegmentedTimeline.Segment other)
      {
        return this.segmentEnd < other.getSegmentStart();
      }

      [LineNumberTable((ushort) 1434)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool after(SegmentedTimeline.Segment other)
      {
        return this.segmentStart > other.getSegmentEnd();
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 136, (byte) 159, (byte) 0, (byte) 101, (byte) 143})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private long getSegmentNumberRelativeToGroup()
      {
        long num1 = this.segmentNumber;
        long num2 = (long) SegmentedTimeline.access\u0024300(this.this\u00240);
        long num3 = -1L;
        long num4 = num2 != num3 ? num1 % num2 : 0L;
        if (num4 < 0L)
          num4 += (long) SegmentedTimeline.access\u0024300(this.this\u00240);
        return num4;
      }

      [LineNumberTable((ushort) 1550)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool inExceptionSegments()
      {
        return SegmentedTimeline.access\u0024400(this.this\u00240, this) >= 0;
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 166, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void inc(long n)
      {
        this.segmentNumber += n;
        long num = n * SegmentedTimeline.access\u0024100(this.this\u00240);
        this.segmentStart += num;
        this.segmentEnd += num;
        this.millisecond += num;
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 188, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void dec(long n)
      {
        this.segmentNumber -= n;
        long num = n * SegmentedTimeline.access\u0024100(this.this\u00240);
        this.segmentStart -= num;
        this.segmentEnd -= num;
        this.millisecond -= num;
      }

      public virtual long getSegmentCount()
      {
        return 1L;
      }

      [LineNumberTable((ushort) 1339)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Date getDate()
      {
        return this.this\u00240.getDate(this.millisecond);
      }

      public virtual bool contains(long millis)
      {
        return this.segmentStart <= millis && millis <= this.segmentEnd;
      }

      [LineNumberTable((ushort) 1378)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool contains(SegmentedTimeline.Segment segment)
      {
        return (this.contains(segment.getSegmentStart(), segment.getSegmentEnd()) ? 1 : 0) != 0;
      }

      public virtual bool contained(long from, long to)
      {
        return from <= this.segmentStart && this.segmentEnd <= to;
      }

      public virtual SegmentedTimeline.Segment intersect(long from, long to)
      {
        if (from <= this.segmentStart && this.segmentEnd <= to)
          return this;
        else
          return (SegmentedTimeline.Segment) null;
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 52, (byte) 104, (byte) 103, (byte) 255, (byte) 30, (byte) 70})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool equals(object @object)
      {
        if (!(@object is SegmentedTimeline.Segment))
          return false;
        SegmentedTimeline.Segment segment = (SegmentedTimeline.Segment) @object;
        return this.segmentNumber == segment.getSegmentNumber() && this.segmentStart == segment.getSegmentStart() && (this.segmentEnd == segment.getSegmentEnd() && this.millisecond == segment.getMillisecond());
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 72, (byte) 154, (byte) 97})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual SegmentedTimeline.Segment copy()
      {
        SegmentedTimeline.Segment segment;
        try
        {
          segment = (SegmentedTimeline.Segment) this.clone();
        }
        catch (CloneNotSupportedException ex)
        {
          goto label_3;
        }
        return segment;
label_3:
        return (SegmentedTimeline.Segment) null;
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 89, (byte) 103, (byte) 105, (byte) 130, (byte) 105, (byte) 162})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int compareTo(object @object)
      {
        SegmentedTimeline.Segment other = (SegmentedTimeline.Segment) @object;
        if (this.before(other))
          return -1;
        return this.after(other) ? 1 : 0;
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 108, (byte) 148, (byte) 173})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool inIncludeSegments()
      {
        return this.getSegmentNumberRelativeToGroup() < (long) SegmentedTimeline.access\u0024200(this.this\u00240) && !this.inExceptionSegments();
      }

      [LineNumberTable((ushort) 1517)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool inExcludeSegments()
      {
        return this.getSegmentNumberRelativeToGroup() >= (long) SegmentedTimeline.access\u0024200(this.this\u00240);
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 178, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void inc()
      {
        this.inc(1L);
      }

      [LineNumberTable(new byte[] {(byte) 165, (byte) 200, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void dec()
      {
        this.dec(1L);
      }

      public virtual void moveIndexToStart()
      {
        this.millisecond = this.segmentStart;
      }

      public virtual void moveIndexToEnd()
      {
        this.millisecond = this.segmentEnd;
      }

      [HideFromJava]
      int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
      {
        return this.compareTo(obj0);
      }

      [SecurityCritical]
      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        Serialization.writeObject((object) this, obj0);
      }
    }

    [InnerClass]
    [SourceFile("SegmentedTimeline.java")]
    [Serializable]
    public class SegmentRange : SegmentedTimeline.Segment
    {
      private long segmentCount;
      [Modifiers]
      private SegmentedTimeline this\u00240;

      [LineNumberTable(new byte[] {(byte) 165, (byte) 237, (byte) 144, (byte) 104, (byte) 232, (byte) 71, (byte) 103, (byte) 109, (byte) 108, (byte) 108, (byte) 150})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SegmentRange(SegmentedTimeline st, long fromMillisecond, long toMillisecond)
        : base(st)
      {
        SegmentedTimeline.SegmentRange segmentRange = this;
        this.this\u00240 = st;
        SegmentedTimeline.Segment segment1 = st.getSegment(fromMillisecond);
        SegmentedTimeline.Segment segment2 = st.getSegment(toMillisecond);
        this.millisecond = fromMillisecond;
        this.segmentNumber = this.calculateSegmentNumber(fromMillisecond);
        this.segmentStart = segment1.segmentStart;
        this.segmentEnd = segment2.segmentEnd;
        this.segmentCount = segment2.getSegmentNumber() - segment1.getSegmentNumber() + 1L;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected SegmentRange([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public override long getSegmentCount()
      {
        return this.segmentCount;
      }

      [LineNumberTable(new byte[] {(byte) 166, (byte) 23, (byte) 109, (byte) 237, (byte) 69, (byte) 100, (byte) 176})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override SegmentedTimeline.Segment intersect(long from, long to)
      {
        long fromMillisecond = Math.max(from, this.segmentStart);
        long toMillisecond = Math.min(to, this.segmentEnd);
        if (fromMillisecond > toMillisecond)
          return (SegmentedTimeline.Segment) null;
        return (SegmentedTimeline.Segment) new SegmentedTimeline.SegmentRange(this.this\u00240, fromMillisecond, toMillisecond);
      }

      [LineNumberTable(new byte[] {(byte) 166, (byte) 44, (byte) 114, (byte) 142, (byte) 104, (byte) 2, (byte) 232, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool inIncludeSegments()
      {
        SegmentedTimeline.Segment segment = this.this\u00240.getSegment(this.segmentStart);
        while (segment.getSegmentStart() < this.segmentEnd)
        {
          if (!segment.inIncludeSegments())
            return false;
          segment.inc();
        }
        return true;
      }

      [LineNumberTable(new byte[] {(byte) 166, (byte) 60, (byte) 114, (byte) 142, (byte) 104, (byte) 2, (byte) 232, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool inExcludeSegments()
      {
        SegmentedTimeline.Segment segment = this.this\u00240.getSegment(this.segmentStart);
        while (segment.getSegmentStart() < this.segmentEnd)
        {
          if (!segment.inExceptionSegments())
            return false;
          segment.inc();
        }
        return true;
      }

      [LineNumberTable((ushort) 1727)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void inc(long n)
      {
        string str = "Not implemented in SegmentRange";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }
  }
}
