using CardGameCore.bases;
using GrandArchive.Phases;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using CardGameCore.Controllers;

public static class GAConstants
{
    public enum TurnPhase
    {
        Recollect,
        Materialise,
        Main,
        End,
        Draw,
        Attack
    }
}
