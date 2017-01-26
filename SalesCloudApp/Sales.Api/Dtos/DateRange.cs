using System;

namespace Sales.Api.Dtos
{
    public interface IRange<T>
    {
        T Start { get; }
        T End { get; }
        bool Includes(T value);
        bool Includes(IRange<T> range);
    }

    public class DateRange : IRange<DateTime>
    {
        public DateRange(DateTime start, DateTime end)
        {
            if(Start > End)
            {
                throw new InvalidOperationException("Start date must be before End date!");
            }

            Start = start;
            End = end;
        }

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public bool Includes(DateTime value)
        {
            return (Start <= value) && (value <= End);
        }

        public bool Includes(IRange<DateTime> range)
        {
            return (Start <= range.Start) && (range.End <= End);
        }

        public static bool TryParse(string text, out DateRange range)
        {
            range = null;
            var dates = text.Split('|');
            if (dates.Length != 2)
            {
                return false;
            }

            var start = DateTime.Parse(dates[0]);
            var end = DateTime.Parse(dates[1]);
            try
            {
                range = new DateRange(start, end);
            }
            catch(InvalidOperationException)
            {
                return false;
            }

            return true;
        }
    }
}