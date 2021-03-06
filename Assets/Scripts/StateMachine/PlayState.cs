using System;
using UnityEngine;


public class PlayState : State
{
    private static State instance;
    public static event EnterEvent OnEnterPlayEvent;
    public static event ExitEvent OnExitPlayEvent;

    public override void OnEnter()
    {
        if (OnEnterPlayEvent != null)
        {
            OnEnterPlayEvent();
        }
    }

    public override void OnExit()
    {
        if (OnExitPlayEvent != null)
        {
            OnExitPlayEvent();
        }
    }
    
    /**
     * returns instance of PlayState and creates an instance if one doesn't exist
     */
    public static State GetInstance()
    {
        if (instance == null)
        {
            instance = new PlayState();
        }
        return instance;
    }
        
    private PlayState(){}
}