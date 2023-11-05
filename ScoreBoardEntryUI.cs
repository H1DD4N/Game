using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Game.ScoreBoards;

public class ScoreBoardEntryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI entryNameText = null;
    [SerializeField] private TextMeshProUGUI entryTimeText = null;

    public void Initialise(ScoreBoardEntryData scoreBoardEntryData)
    {
        entryNameText.text = scoreBoardEntryData.entryName;
        entryTimeText.text = scoreBoardEntryData.entryTime.ToString();

    }
}
