﻿using AdditionalCommands.Helpers;
using RimWorld;
using SR.ModRimWorld.RaidExtension;

namespace AdditionalCommands.RaidExtension
{
    public class HostileTraveler : HostileVisitor
    {
        public HostileTraveler()
        {
            worker = new IncidentWorkerHositleTraveler();
            worker.def = IncidentDef.Named("SrHositleTraveler");
            Category = IncidentCategoryDefOf.Misc;
        }
    }

}
