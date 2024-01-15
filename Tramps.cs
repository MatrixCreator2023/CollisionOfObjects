using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Tramps : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        EditorSceneManager.LoadScene("Level_1");
        
    }


    
    
}
