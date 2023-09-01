using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private Button gameStartButton;
    private Button characterButton;
    private Button settingsButton;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        gameStartButton = root.Q<Button>("StartButton");
        characterButton = root.Q<Button>("CharacterButton");
        settingsButton = root.Q<Button>("SettingsButton");

        gameStartButton.RegisterCallback<ClickEvent>(this.OnGameStartButtonClicked);
        characterButton.RegisterCallback<ClickEvent>(this.OnChactertButtonClicked);
        settingsButton.RegisterCallback<ClickEvent>(this.OnSettingsButtonClicked);
    }

    private void OnGameStartButtonClicked(ClickEvent evt)
    {
        Debug.Log("Game Start");
        SceneManager.LoadScene("Proto");
    }

    private void OnChactertButtonClicked(ClickEvent evt)
    {
        Debug.Log("Chacters");
    }

    private void OnSettingsButtonClicked(ClickEvent evt)
    {
        Debug.Log("Settings");
    }

}
