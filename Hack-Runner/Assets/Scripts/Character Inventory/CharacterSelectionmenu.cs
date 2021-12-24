using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] playerObjects;
    public int selectedCharacter = 0;
    public string gameScene = "Character Selection Scene";
    private string selectedCharacterDataName = "SelectedCharacter";
    void Start()
    {
        HideAllCharacters();
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObjects[selectedCharacter].SetActive(true);
    }
    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }

      



        public void NextCharacter()
        {
            playerObjects[selectedCharacter].SetActive(false);
            selectedCharacter++;
            if (selectedCharacter >= playerObjects.Length)
            {
                selectedCharacter = 0;
            }
            playerObjects[selectedCharacter].SetActive(true);
        }


    public void PreviousCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerObjects.Length - 1;
            playerObjects[selectedCharacter].SetActive(true);
        }
    }

    public void PlayButton()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        Application.LoadLevel("scene3 with all hacks");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
