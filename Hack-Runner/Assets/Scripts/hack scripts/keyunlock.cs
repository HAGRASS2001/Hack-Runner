﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyunlock : MonoBehaviour
{
    public List<Button> numbers;
    private int[] numberarray = {1, 5 , 6, 9, 10};
    public int counter = 0;
    public int falsecounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (counter == 5) {

        }
        else if (counter > 5)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers[i].image.color = Color.red;
                numbers[i].interactable = false;
            }
        }
    }

    public void PressButton(Button number) {

        for (int i = 0; i < numberarray.Length; i++) {
            if (int.Parse(number.GetComponentInChildren<Text>().text) == numberarray[i])
            {
                number.interactable = false;
                number.image.color = Color.green;
            }
        }
        counter++;
    }
}