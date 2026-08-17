using System.Collections;
using UnityEngine;

public class FakeDebugLogs : MonoBehaviour
{
    private IEnumerator Start()
    {
        Debug.Log("=== ИНИЦИАЛИЗАЦИЯ СИСТЕМЫ ===");
        yield return new WaitForSeconds(1f);

        // Генерация уровня
        //Debug.Log("Генерация уровня: создание сетки 10x10");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 1 создан в координатах [3,2]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 2 создан в координатах [3,3]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 3 создан в координатах [3,4]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 1 создан в координатах [3,5]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 4 создан в координатах [4,5]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 2 создан в координатах [4,4]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 3 создан в координатах [4,6]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 1 создан в координатах [5,6]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 4 создан в координатах [5,5]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 1 создан в координатах [5,4]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 5 создан в координатах [5,3]");
        //yield return new WaitForSeconds(0.1f);

        //Debug.Log("Сектор 1 создан в координатах [6,5]");
        //yield return new WaitForSeconds(0.1f);

        

        

        //Debug.Log("Генерация уровня успешно завершена");
        //yield return new WaitForSeconds(1f);

        //// Система заданий
        //Debug.Log("Система заданий: новое задание получено");
        //Debug.Log("Тип задания: уборка объектов");
        //Debug.Log("Необходимо очистить объектов: 5");
        //yield return new WaitForSeconds(1f);

        //// Уборка объектов
        //Debug.Log("Игрок взаимодействует с объектом загрязнения");
        //Debug.Log("Объект очищен");
        //Debug.Log("Очищено объектов: 1");
        //yield return new WaitForSeconds(5f);

        //Debug.Log("Игрок взаимодействует с объектом загрязнения");
        //Debug.Log("Объект очищен");
        //Debug.Log("Очищено объектов: 2");
        //yield return new WaitForSeconds(4f);

        //Debug.Log("Игрок взаимодействует с объектом загрязнения");
        //Debug.Log("Объект очищен");
        //Debug.Log("Очищено объектов: 3");
        //yield return new WaitForSeconds(3f);

        //Debug.Log("Игрок взаимодействует с объектом загрязнения");
        //Debug.Log("Объект очищен");
        //Debug.Log("Очищено объектов: 4");
        //yield return new WaitForSeconds(2f);

        //Debug.Log("Игрок взаимодействует с объектом загрязнения");
        //Debug.Log("Объект очищен");
        //Debug.Log("Очищено объектов: 5");
        //Debug.Log("Задание выполнено");
        //yield return new WaitForSeconds(5f);

        //// Инвентарь
        //Debug.Log("В инвентарь добавлен предмет: Швабра");
        //yield return new WaitForSeconds(0.5f);

        //Debug.Log("В инвентарь добавлен предмет: Ведро");
        //yield return new WaitForSeconds(0.5f);

        //Debug.Log("В инвентарь добавлен предмет: Фонарик");
        //yield return new WaitForSeconds(0.5f);

        //Debug.Log("В инвентарь добавлен предмет: Ключ");
        //yield return new WaitForSeconds(0.5f);

        //Debug.LogWarning("Инвентарь заполнен");
        //yield return new WaitForSeconds(1f);

        // ИИ монстра
        Debug.Log("Монстр: состояние Патрулирование");
        yield return new WaitForSeconds(14f);

        Debug.Log("Монстр обнаружил игрока");
        Debug.Log("Монстр переключен в состояние Преследование");
        yield return new WaitForSeconds(22f);

        Debug.Log("Монстр потерял игрока");
        Debug.Log("Монстр возвращается к патрулированию");
        yield return new WaitForSeconds(31f);

        // Финал
        Debug.Log("=== ТЕСТИРОВАНИЕ УСПЕШНО ЗАВЕРШЕНО ===");
    }
}