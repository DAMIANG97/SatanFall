using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene0 : MonoBehaviour
{

    public int LevelIndex;


    private void Update()
    {


            if (Input.GetKeyDown(KeyCode.X))
            {
            SceneManager.LoadScene(LevelIndex);
        }



    }

}