using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //Значение здоровья
    public int health;
    //Максимальное значение здоровья
    public int maxHealth;
    public GameObject itemPrefab;
    //Функция получения урона
    public void TakeHit(int damage)
    {
        health -= damage;

        //Если здоровье меньше 0 - уничтожить объект на котором весит этот скрипт
        if (health <= 0 )
        {
            if (gameObject.CompareTag("Player"))
                {
                Application.LoadLevel(Application.loadedLevel);
                }
                else
                    {
                      GameObject item = Instantiate(itemPrefab, transform.position, Quaternion.identity);
                      Destroy(gameObject);
                    }         
            
        }
            
    }

    //Функция прибавления здоровья
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        //Если здоровье, после пополнения, больше максимального значения - здоровье будет равно максимальному значению.
        if (health > maxHealth)
        {
            health = maxHealth;
        }            
    }
}