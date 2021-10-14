using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BottomBorder : MonoBehaviour
{
    private bool _isGameEnded;
    [SerializeField] private GameObject _panel;
    [SerializeField] private Text _statusInfo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (_isGameEnded)
        {
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SetGameOver(false);
    }

    public void SetGameOver(bool isWin)
    {
        _isGameEnded = true;

        _statusInfo.text = isWin ? "YOU WIN!" : "YOU LOSE!";
        _panel.gameObject.SetActive(true);
    }
}
