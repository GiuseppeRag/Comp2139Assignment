﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Sasign1
{
    public class Survey
    { /*
            [SurveyId]     INT            NOT NULL,
    [ResponseTime] TINYINT        NULL,
    [Efficentcy]   TINYINT        NULL,
    [Resolution]   TINYINT        NULL,
    [Comments]     NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([SurveyId] ASC)
        */
        public int survayId { get; private set; }
        public int incidentId { get; private set; }
        public int responeseTime { get; set; }
        public int efficentcy { get; set; }
        public int resolution { get; set; }
        public string comments {
            get {
                return comments;
            }
            set {
                if (value.Length > 250)
                    comments = value.Substring(0, 250);
                else
                    comments = value;
            } }

        public Survey (int incidentId, int responeseTime, int efficentcy, int resolution, string comments)
        {
            this.survayId = -1;
            this.responeseTime = responeseTime;
            this.efficentcy = efficentcy;
            this.resolution = resolution;
            this.comments = comments;
        }
    }
}
