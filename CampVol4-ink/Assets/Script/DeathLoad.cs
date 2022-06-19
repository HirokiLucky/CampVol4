using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathLoad : MonoBehaviour
{
    [SerializeField] private unitychanStatus status;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            status.hp = 0;
            if (status.hp <= 0)
            {
                status.death++;
                status.life--;
                if (status.life <= 0)
                {
                    Gamesystem.isClear1 = false;
                    Gamesystem.isClear2= false;
                    Gamesystem.isClear3= false;
                    status.hp = 10;
                    status.life = 100;
                    status.star = 0;
                    SceneManager.LoadScene("Stand_koki");
                }
                else
                {
                    SceneManager.LoadScene("nagaiArea2");
                    status.hp = 10;
                }
            }
        }

        
    }
    
}
