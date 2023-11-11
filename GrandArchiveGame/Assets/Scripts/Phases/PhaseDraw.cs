using CardGameCore.bases;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace GrandArchive.Phases
{
    public class PhaseDraw : TurnPhase
    {
        protected override void RunPhase()
        {
            base.RunPhase();
            EndPhase();
        }

        public class Factory : TurnPhaseFactory<PhaseDraw> { };
    }
}
