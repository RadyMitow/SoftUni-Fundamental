using System;
using System.Collections.Generic;
using System.Linq;

    class Ranking
    {
    static void Main()
    {
        Dictionary<string, string> contestsDic = new Dictionary<string, string>();
        string contestInfo = Console.ReadLine();

        while (contestInfo != "end of contests")
        {
            contestsDic.Add(contestInfo.Split(':').ToArray()[0], contestInfo.Split(':').ToArray()[1]);
            contestInfo = Console.ReadLine();
        }
        Dictionary<string, Dictionary<string, int>> studentDic = new Dictionary<string, Dictionary<string, int>>();
        string examInfo = Console.ReadLine();
        while (examInfo != "end of submissions")
        {
            string[] exam = examInfo.Split('=').ToArray();
            string examName = exam[0];
            string pass = exam[1].Trim('>');
            string student = exam[2].Trim('>');
            int points = int.Parse(exam[3].Trim('>'));

            if (contestsDic.ContainsKey(examName))
            {
                if (contestsDic[examName].Contains(pass))
                {
                    if (!studentDic.ContainsKey(student))
                    {
                        studentDic.Add(student, new Dictionary<string, int>());
                        studentDic[student].Add(examName, points);
                    }
                    else
                    {
                        if (studentDic[student].ContainsKey(examName))
                        {
                            if (studentDic[student][examName] < points)
                            {
                                studentDic[student][examName] = points;
                            }
                        }
                        else
                        {
                            studentDic[student].Add(examName, points);
                        }

                    }
                }

            }
            examInfo = Console.ReadLine();
        }
        int bestCandidatepoints = 0;
        string bestCandidate = null;
        foreach (var kvp in studentDic)
        {
            int searchedCandidatepoints = 0;

            foreach (var examVpoints in kvp.Value)
            {
                searchedCandidatepoints += examVpoints.Value;
            }
            if (searchedCandidatepoints> bestCandidatepoints)
            {
                bestCandidatepoints = searchedCandidatepoints;
                bestCandidate = kvp.Key;
            }


        }
        Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatepoints} points.");
        Console.WriteLine("Ranking: ");
        foreach (var kvd in studentDic.OrderBy(name => name.Key))
        {
            Console.WriteLine($"{kvd.Key}");
            foreach (var item in kvd.Value.OrderByDescending(points => points.Value))
            {
                Console.WriteLine($"#  {item.Key} -> {item.Value}");

            }

        }
    }
}
