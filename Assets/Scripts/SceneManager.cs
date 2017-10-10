using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : SingletonM<SceneManager>
{

    protected override void Awake()
    {
        base.Awake();
    }

    public void SceneLoad(string strsceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(strsceneName);
    }

    private IEnumerator SceneLoadCoroutine(string strsceneName)
    {
        yield return 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene(strsceneName);

    }


}
