using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToiletScript : MonoBehaviour
{
    public string game1SceneName = "Game";
    public string game2SceneName = "Game1";
    public string game3SceneName = "Game2";
    public float delayTime = 3f; // ����ɶ�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Poop"))
        {
            StartCoroutine(ChangeSceneWithDelay());
        }
    }

    private IEnumerator ChangeSceneWithDelay()
    {
        // �Ȱ�������������
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(delayTime);

        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == game1SceneName)
        {
            SceneManager.LoadScene(game2SceneName);
        }
        else if (currentSceneName == game2SceneName)
        {
            SceneManager.LoadScene(game3SceneName);
        }

        // ��_������������
        Time.timeScale = 1f;
    }
}