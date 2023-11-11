using CardGameCore;
using CardGameCore.bases;
using GrandArchive.Phases;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Zenject;

public class GATurn : Turn
{
    private TurnPhase.TurnPhaseFactory<PhaseMaterialise> _materialisePhaseFactory;
    private TurnPhase.TurnPhaseFactory<PhaseRecollect> _recollectPhaseFactory;
    private TurnPhase.TurnPhaseFactory<PhaseDraw> _drawPhaseFactory;
    private TurnPhase.TurnPhaseFactory<PhaseMain> _mainPhaseFactory;
    private TurnPhase.TurnPhaseFactory<PhaseEnd> _endPhaseFactory;
    private TurnPhase.TurnPhaseFactory<PhaseAttack> _attackPhaseFactory;

    [Inject]
    private void Initialise(TurnPhase.TurnPhaseFactory<PhaseMaterialise> materialisePhaseFactory)
    {
        _materialisePhaseFactory = materialisePhaseFactory;
        SetupTurn();
    }

    protected override void CreatePhases()
    {
        phases.Add(GAConstants.TurnPhase.Materialise, _materialisePhaseFactory.Create(
            new List<Action> { OnTurnStart },
            new List<Action> { /* once a card has been materialised and stack is resolved */ }));

        phases.Add(GAConstants.TurnPhase.Recollect, _recollectPhaseFactory.Create(
            new List<Action> { phases[GAConstants.TurnPhase.Materialise].OnPhaseEnd },
            new List<Action> { /* once cards have been recollected and stack is resolved */ }));

        phases.Add(GAConstants.TurnPhase.Draw, _drawPhaseFactory.Create(
            new List<Action> { phases[GAConstants.TurnPhase.Recollect].OnPhaseEnd },
            new List<Action> { /* once a card has been drawn an stack is resolved */ }));

        phases.Add(GAConstants.TurnPhase.Main, _mainPhaseFactory.Create(
            new List<Action> { phases[GAConstants.TurnPhase.Draw].OnPhaseEnd },
            new List<Action> { /* some the end turn button is pressed and stack is resolved */}));

        phases.Add(GAConstants.TurnPhase.End, _endPhaseFactory.Create(
            new List<Action> { phases[GAConstants.TurnPhase.Main].OnPhaseEnd },
            new List<Action> { /* once the stack is resolved */}));

        phases.Add(GAConstants.TurnPhase.Attack, _attackPhaseFactory.Create(
            new List<Action> { /* When a card declares an attack*/ },
            new List<Action> { /* once the stack is resolved */}));

    }
}
