using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int healt = 10;

    private int coins;
    
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public void CollectiontCoins()
    {
        coins++;
        print("Собранные монетки;" + coins):
    }
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
    public void TakeDamage(int damage)
    {
        healt -= damage;
        print("Здоровье игрока: " + healt);
    }

    
    
}
