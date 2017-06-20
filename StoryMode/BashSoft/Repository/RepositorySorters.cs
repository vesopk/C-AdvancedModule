using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                PrintStudents(wantedData.OrderBy(x => x.Value.Sum()).Take(studentsToTake)
                    .ToDictionary(pair => pair.Key,pair => pair.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(wantedData.OrderByDescending(x => x.Value.Sum()).Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private static void PrintStudents(Dictionary<string, List<int>> studentsSorted)
        {
            foreach (var student in studentsSorted)
            {
                OutputWriter.PrintStudent(student);
            }
        }

        //private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue,
        //    KeyValuePair<string, List<int>> secondValue)
        //{
        //    var totalOfFirstMarks = 0;
        //    foreach (var i in firstValue.Value)
        //    {
        //        totalOfFirstMarks += i;
        //    }
        //    var totalSecondMarks = 0;
        //    foreach (var i in secondValue.Value)
        //    {
        //        totalSecondMarks += i;
        //    }
        //    return totalSecondMarks.CompareTo(totalOfFirstMarks);
        //}

        //private static int CompareInDescendingOrder(KeyValuePair<string, List<int>> firstValue,
        //    KeyValuePair<string, List<int>> secondValue)
        //{
        //    var totalOfFirstMarks = 0;
        //    foreach (var i in firstValue.Value)
        //    {
        //        totalOfFirstMarks += i;
        //    }
        //    var totalSecondMarks = 0;
        //    foreach (var i in secondValue.Value)
        //    {
        //        totalSecondMarks += i;
        //    }
        //    return totalOfFirstMarks.CompareTo(totalSecondMarks);
        //}

        //private static Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> studentsWanted,
        //    int takeCount,
        //    Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        //{
        //    var valuesTaken = 0;
        //    var studentsSorted = new Dictionary<string,List<int>>();
        //    var nextInOrder = new KeyValuePair<string,List<int>>();
        //    var isSorted = false;

        //    while (valuesTaken < takeCount)
        //    {
        //        isSorted = true;

        //        foreach (var studentWithScore in studentsWanted)
        //        {
        //            if (!String.IsNullOrEmpty(nextInOrder.Key))
        //            {
        //                var comaprisonResult = Comparison(studentWithScore, nextInOrder);
        //                if (comaprisonResult >= 0 && !studentsSorted.ContainsKey(studentWithScore.Key))
        //                {
        //                    nextInOrder = studentWithScore;
        //                    isSorted = false;
        //                }
        //            }
        //            else
        //            {
        //                if (!studentsSorted.ContainsKey(studentWithScore.Key))
        //                {
        //                    nextInOrder = studentWithScore;
        //                    isSorted = false;
        //                }
        //            }
        //        }

        //        if (!isSorted)
        //        {
        //            studentsSorted.Add(nextInOrder.Key,nextInOrder.Value);
        //            valuesTaken++;
        //            nextInOrder = new KeyValuePair<string, List<int>>();
        //        }
        //    }

        //    return studentsSorted;
        //}
    }
}
