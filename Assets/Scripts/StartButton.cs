using System;
using System.Collections;
using System.Collections.Generic;
using Maze;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class StartButton : MonoBehaviour
{
    [SerializeField] private MazeManager mazeManager;
    [SerializeField] private Camera mainCamera;

    /**
     * sets maze size and camera position for easy maze condition
     */
    public void EasyMaze()
    {
        mazeManager.setMazeSize(new Vector2Int(5, 5));
        mazeManager.setHoleAmount(10);
        mainCamera.transform.position = new Vector3(0f, 16f, 0f);
        StartGame();
    }
    
    /**
     * sets maze size and camera position for normal maze condition
     */
    public void NormalMaze()
    {
        mazeManager.setMazeSize(new Vector2Int(6, 6));
        mazeManager.setHoleAmount(20);
        mainCamera.transform.position = new Vector3(0f, 18.5f, -1.5f);
        StartGame();
    }
    
    /**
     * sets maze size and camera position for hard maze condition
     */
    public void HardMaze()
    {
        mazeManager.setMazeSize(new Vector2Int(7,7));
        mazeManager.setHoleAmount(30);
        mainCamera.transform.position = new Vector3(0f, 21f, 0f);
        StartGame();
    }
    
    /**
     * triggers the transition from MainMenu to SetUpGame 
     */
    public void StartGame()
    {
        StateMachine.TriggerTransition(Transition.SetUpGame);
    }
    
}
