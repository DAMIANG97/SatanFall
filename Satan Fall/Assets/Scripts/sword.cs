using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sword : MonoBehaviour
{
    public int LevelIndex;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            SceneManager.LoadScene(LevelIndex);
        }

}
}
