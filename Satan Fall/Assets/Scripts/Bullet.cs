using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private int LevelIndex=1;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            SceneManager.LoadScene(LevelIndex);
        }
    }



}

