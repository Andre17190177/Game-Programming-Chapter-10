using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToProblemMenu : MonoBehaviour
{
    public Button ProblemMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        ProblemMenuButton.onClick.AddListener(ProblemMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ProblemMenu()
    {
        SceneManager.LoadScene("Problem 10");
    }
}
