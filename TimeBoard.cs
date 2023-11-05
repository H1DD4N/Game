using System.IO;
using UnityEngine;

namespace Game.ScoreBoards
{
    public class TimeBoard : MonoBehaviour
    {
        [SerializeField] private int maxTimeBoardEntries = 5;
        [SerializeField] private Transform timeScoreHolderTransform = null;
        [SerializeField] private GameObject timeScoreEntryObject = null;

        [Header ("Test")]
        
        [SerializeField] ScoreBoardEntryData testEntryData = new ScoreBoardEntryData();

        private string SavePath => $"{Application.persistentDataPath}/highscores.json";

        private void Start()
        {
            ScoreBoardSaveData savedTimes = GetSavedTime();

            SaveScores(savedTimes);

            UpdateUI(savedTimes);
        }

        [ContextMenu("Add Test Entry")]
        public void AddTestEntry()
        {
            AddEntry(testEntryData);
        }

        public void AddEntry(ScoreBoardEntryData scoreBoardEntryData)
        {
            ScoreBoardSaveData savedTimes = GetSavedTime();

            bool scoreAdded = false;

            for (int i = 0; i < savedTimes.bestTime.Count; i++)
            {
                if(scoreBoardEntryData.entryTime > savedTimes.bestTime[i].entryTime)
                {
                    savedTimes.bestTime.Insert(i, scoreBoardEntryData);
                    scoreAdded = true;
                    break;
                }
            }

            if(!scoreAdded && savedTimes.bestTime.Count < maxTimeBoardEntries)
            {
                savedTimes.bestTime.Add(scoreBoardEntryData);
            }

            if(savedTimes.bestTime.Count > maxTimeBoardEntries)
            {
                savedTimes.bestTime.RemoveRange(maxTimeBoardEntries, savedTimes.bestTime.Count - maxTimeBoardEntries);
            }

            UpdateUI(savedTimes);

            SaveScores(savedTimes);
        }

        private void UpdateUI(ScoreBoardSaveData savedScores)
        {
            foreach (Transform child in timeScoreHolderTransform)
            {
                Destroy(child.gameObject);
            }

            foreach(ScoreBoardEntryData highscore in savedScores.bestTime)
            {
                Instantiate(timeScoreEntryObject, timeScoreHolderTransform).GetComponent<ScoreBoardEntryUI>().Initialise(highscore);
      
            }
        }

        private ScoreBoardSaveData GetSavedTime()
        {
            if (!File.Exists(SavePath))
            {
                File.Create(SavePath).Dispose();
                return new ScoreBoardSaveData();
            }

            using (StreamReader stream = new StreamReader(SavePath))
            {
                string json = stream.ReadToEnd();

                return JsonUtility.FromJson<ScoreBoardSaveData>(json);
            }
        }

        private void SaveScores(ScoreBoardSaveData scoreBoardSaveData)
        {
            using(StreamWriter stream = new StreamWriter(SavePath))
            {
                string json = JsonUtility.ToJson(scoreBoardSaveData, true);
                stream.Write(json);
            }
        }


    }
      
}



