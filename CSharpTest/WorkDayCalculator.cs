﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (weekEnds == null)
            {
                DateTime endDate = startDate.AddDays(dayCount - 1);
                return endDate;
            }
            else
            {
                int weekDays = 0;
                foreach (var weekDay in weekEnds)
                {
                    weekDays += weekDay.EndDate.Day - weekDay.StartDate.Day;
                }
                int days = dayCount + weekDays;
                int result = days;
                DateTime endDate = startDate.AddDays(result);
                return endDate;
            }
        }
    }
}