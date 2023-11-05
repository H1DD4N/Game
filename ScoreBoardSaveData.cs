using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Game.ScoreBoards
{
    [Serializable]
    public class ScoreBoardSaveData 
    {
        public List<ScoreBoardEntryData> bestTime = new List<ScoreBoardEntryData> ();
    }
}

