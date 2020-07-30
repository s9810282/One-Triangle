using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingScene : MonoBehaviour
{
    [SerializeField] Image loadingBar;

    AsyncOperation asyncOper;

    // Start is called before the first frame update
    void Start()
    {
        LoadingPlayScene();
    }

    public void LoadingPlayScene()
    {
        
        asyncOper = SceneManager.LoadSceneAsync("Play");
        StartCoroutine(LoadingEffect());
    }


    IEnumerator LoadingEffect()
    {
        float time = 0f;
        WaitForSeconds waitTime = new WaitForSeconds(0.05f);

        asyncOper.allowSceneActivation = false;

        while (!asyncOper.isDone)
        {
            loadingBar.fillAmount = asyncOper.progress;
            Debug.Log(asyncOper.progress);

            time += 0.05f;

            if (time >= 2f)
                break;

            yield return waitTime;
        }

        Debug.Log("Start");

        loadingBar.fillAmount = 1f;
        yield return new WaitForSeconds(1f);

        //fade작업 추가예정

        asyncOper.allowSceneActivation = true;

    }
}
