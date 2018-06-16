using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class rigid : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {


            GameObject.Destroy(other.gameObject);

            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

