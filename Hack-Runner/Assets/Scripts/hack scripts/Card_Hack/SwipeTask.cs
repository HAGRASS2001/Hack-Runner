﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTask : MonoBehaviour
{
    // Start is called before the first frame update


    public List<SwipePoint> _swipePoints = new List<SwipePoint>();

public float _countdownMax = 0.5f;


    public GameObject green_On;
    public GameObject red_On;


private int _currentSwipePointIndex = 0;
private float _countdown =0;
    private void Update()
    {
        _countdown -= Time.deltaTime;
        if (_currentSwipePointIndex != 0 && _countdown <= 0)
        {
            _currentSwipePointIndex = 0;
            StartCoroutine(FinishTask(false));
        }
        
    }

    private IEnumerator FinishTask(bool wasSuccessful)
    {
        if (wasSuccessful) {
            green_On.SetActive(true);
        }
    else
        {
            red_On.SetActive(true);
        }
        yield return new WaitForSeconds(1.5f);
        green_On.SetActive(false);
        red_On.SetActive(false);
    }


    public void SwipePointTrigger(SwipePoint swipePoint)
    {
        if (swipePoint == _swipePoints[_currentSwipePointIndex])
        {
            _currentSwipePointIndex++;
            _countdown = _countdownMax;
        }
        if (_currentSwipePointIndex >= _swipePoints.Count)
        {
            _currentSwipePointIndex = 0;
            StartCoroutine(FinishTask(true));
        }


    }
}