using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ExitingGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
         /*��״̬����false�����˳���Ϸ*/
         UnityEditor.EditorApplication.isPlaying = false;
         Application.Quit();
    }
}
