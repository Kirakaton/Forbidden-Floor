using UnityEngine;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    [Header("Настройки задания")]
    public int requiredCleanCount = 10;

    private int currentCleanCount = 0;
    private int totalScore = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ObjectCleaned(int score = 1)
    {
        currentCleanCount++;
        totalScore += score;

        Debug.Log($"Очищено {currentCleanCount}/{requiredCleanCount} | Счёт: {totalScore}");

        if (currentCleanCount >= requiredCleanCount)
        {
            CompleteQuest();
        }
    }

    private void CompleteQuest()
    {
        Debug.Log("Задание выполнено!");
        // сюда добавишь логику перехода / UI / следующее задание
    }

    public int GetCurrentCount() => currentCleanCount;
    public int GetRequiredCount() => requiredCleanCount;
    public int GetScore() => totalScore;
}