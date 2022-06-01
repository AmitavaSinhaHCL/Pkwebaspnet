﻿using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using HclNextGenSocialGoal.Data.Models;
using HclNextGenSocialGoal.Model.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HclNextGenSocialGoal.Data
{
    public class GoalsSampleData : DropCreateDatabaseIfModelChanges<SocialGoalEntities>
    {
        protected override void Seed(SocialGoalEntities context)
        {
            new List<Metric>
            {
                new Metric { Type ="%"},
                new Metric { Type ="$"},
                new Metric { Type ="$ M"},
                new Metric { Type ="Rs"},
                new Metric { Type ="Hours"},
                new Metric { Type ="Km"},
                new Metric { Type ="Kg"},
                new Metric { Type ="Years"}

            }.ForEach(m => context.Metrics.Add(m));

            new List<GoalStatus>
            {
                new GoalStatus{GoalStatusType="In Progress"},
                new GoalStatus{GoalStatusType="On Hold"},
                new GoalStatus{GoalStatusType="Completed"}
            }.ForEach(m => context.GoalStatus.Add(m));

            context.Commit();

        }

    }
}