using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonM<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instacne
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;
                if(instance == null)
                {
                    // 생성
                    GameObject obj = new GameObject();
                    obj.AddComponent<T>();
                    instance = obj.GetComponent<T>();
                }
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
