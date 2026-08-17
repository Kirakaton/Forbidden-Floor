using UnityEngine;

public class DirtyObject : MonoBehaviour
{
    [Header("Визуал")]
    [SerializeField] private GameObject dirtVisual;

    [Header("Тип загрязнения")]
    public DirtType dirtType;

    [Header("Очки за очистку")]
    public int scoreValue = 1;

    private bool isCleaned = false;

    public enum DirtType
    {
        Floor,    // пол
        Wall,     // стена
        Glass,    // стекло
        Trash     // мусор
    }

    public bool IsCleaned => isCleaned;

    public void Clean()
    {
        if (isCleaned) return;

        isCleaned = true;
        dirtVisual.SetActive(false);

        QuestManager.Instance.ObjectCleaned(scoreValue);

        Debug.Log($"Очищено: {gameObject.name} | Тип: {dirtType}");
    }
}