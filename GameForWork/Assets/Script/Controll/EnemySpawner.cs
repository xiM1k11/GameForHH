using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Префаб противника
    public int numberOfEnemiesToSpawn = 3; // Количество противников, которые нужно создать

    // Границы, внутри которых будут размещены противники
    public float minX = 45f;
    public float maxX = 63f;
    public float minY = 3f;
    public float maxY = 13f;
    public float minZ = 0f;
    public float maxZ = 0f;

    private void Start()
    {
        // Создаем заданное количество противников
        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            // Генерируем случайные координаты для размещения противника
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(minZ, maxZ);

            // Создаем экземпляр противника из префаба
            GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(randomX, randomY, randomZ), Quaternion.identity);
        }
    }
    
}

