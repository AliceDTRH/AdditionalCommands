﻿using AdditionalCommands.Helpers;
using RimWorld;
using VEE;

namespace AdditionalCommands.Commands.VanillaEventsExpanded
{
    class Drought : MiscEvents
    {
        public Drought()
        {
            worker = new IncidentWorker_MakeGameConditionVEE();
            worker.def = IncidentDef.Named("VEE_Drought");
        }
    }
}
