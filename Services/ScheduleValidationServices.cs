using C969_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C969_Project.Services
{
    internal class ScheduleValidationServices
    {
        public static bool AreBothWithinBusinessHours(DateTime start, DateTime end)
        {
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            // Convert both to Eastern Standard Time
            DateTime startEst = TimeZoneInfo.ConvertTime(start, easternZone);
            DateTime endEst = TimeZoneInfo.ConvertTime(end, easternZone);

            // Same calendar day for appointment
            if (startEst.Date != endEst.Date)
            {
                return false;
            }

            // Start time must not be after end time
            if (startEst > endEst)
            {
                return false;
            }

            // Check both times for weekday and betweem 9am-5pm 
            return IsWithinBusinessHours(startEst) && IsWithinBusinessHours(endEst);
        }

        public static bool HasOverlap(
            DateTime newStart,
            DateTime newEnd,
            IEnumerable<Appointment> existingAppointments,
            int? currentAppointmentId = null)
        {
            if (newStart >= newEnd) return false;

            return existingAppointments.Any(existing =>
                // Exclude current appointment when editing
                (!currentAppointmentId.HasValue || existing.AppointmentId != currentAppointmentId.Value)
                // Overlap comparison (since GetAppointments converts DB UTC to Local, these compare in Local time)
                && newStart < existing.End
                && newEnd > existing.Start
            );
        }

        private static bool IsWithinBusinessHours(DateTime estDateTime)
        {
            // Check weekday
            if (estDateTime.DayOfWeek == DayOfWeek.Saturday || estDateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            // Check time window (9:00 AM to 5:00 PM)
            TimeOnly time = TimeOnly.FromDateTime(estDateTime);
            return time.IsBetween(new TimeOnly(9, 0), new TimeOnly(17, 0));
        }
    }
}
