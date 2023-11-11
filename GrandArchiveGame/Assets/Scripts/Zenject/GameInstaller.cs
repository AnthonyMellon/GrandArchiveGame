using GrandArchive.Phases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        base.InstallBindings();
        {
            Container.BindFactory<List<Action>, List<Action>, PhaseRecollect, PhaseRecollect.Factory>();
            Container.BindFactory<List<Action>, List<Action>, PhaseMaterialise, PhaseMaterialise.Factory>();
            Container.BindFactory<List<Action>, List<Action>, PhaseMain, PhaseMain.Factory>();
            Container.BindFactory<List<Action>, List<Action>, PhaseEnd, PhaseEnd.Factory>();
            Container.BindFactory<List<Action>, List<Action>, PhaseDraw, PhaseDraw.Factory>();
            Container.BindFactory<List<Action>, List<Action>, PhaseAttack, PhaseAttack.Factory>();
        }
    }
}
