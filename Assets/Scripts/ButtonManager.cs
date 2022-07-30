using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    string uName;
    public GameObject uNameIF;

    public void StartButton()
    {
        uName = uNameIF.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString("uname", uName);
        SceneManager.LoadScene("Roll-A-Ball");
    }
}
