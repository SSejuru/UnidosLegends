using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
public enum CombatState
{
    CombatInitialization,
    StandbyPhase,
    MainPhase,
    PreBattle,
    BattlePhase,
    PostBattle,
    EndPhase
}

public class CombatStateMachine 
{
    private Dictionary<CombatState, IState> states = new Dictionary<CombatState, IState>();

    private CombatState currentState;
    private IState currentStateInterface = null;

    public IState CurrentStateObject => currentStateInterface;
    public CombatState CurrentStateEnum => currentState;

    public UnityEvent<CombatState> OnEnterState = new UnityEvent<CombatState>();
    public UnityEvent<CombatState> OnExitState = new UnityEvent<CombatState>();


    public void SetInitialState()
    {
        currentState = CombatState.CombatInitialization;
        currentStateInterface = states[currentState];
        OnEnterState.Invoke(currentState);
    }

    public void ChangeState(IState prevStateTemplate, CombatState newState)
    {
        CombatState prevState = currentState;

        if (prevStateTemplate != states[currentState])
        {
            Debug.LogWarning("-- ERROR:  Invalid call to change state. From: " + prevState + " to " + newState);
        }

        states[currentState]?.ExitState();
        OnExitState?.Invoke(prevState);

        currentState = newState;

        currentStateInterface = states[currentState];

        currentStateInterface?.EnterState();
        OnEnterState?.Invoke(newState);
    }

    public void Tick(float deltaTime)
    {
        if (currentStateInterface != null)
        {
            currentStateInterface.Tick(deltaTime);
        };
    }
}
