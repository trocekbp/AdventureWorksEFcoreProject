﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class vJobCandidateEducation
{
    public int JobCandidateID { get; set; }

    public string? Edu_Level { get; set; }

    public DateTime? Edu_StartDate { get; set; }

    public DateTime? Edu_EndDate { get; set; }

    public string? Edu_Degree { get; set; }

    public string? Edu_Major { get; set; }

    public string? Edu_Minor { get; set; }

    public string? Edu_GPA { get; set; }

    public string? Edu_GPAScale { get; set; }

    public string? Edu_School { get; set; }

    public string? Edu_Loc_CountryRegion { get; set; }

    public string? Edu_Loc_State { get; set; }

    public string? Edu_Loc_City { get; set; }
}
