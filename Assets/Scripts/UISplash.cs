using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISplash : MonoBehaviour
{

    
    void Awake()
    {
        SceneManager.Instacne.SceneLoad("LoginScene");
    }

}
