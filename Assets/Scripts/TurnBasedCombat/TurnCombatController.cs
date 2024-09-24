using UnityEngine;
using UnityEngine.Events;

public enum TurnState
{
    StandbyPhase,
    MainPhase,
    PreBattle,
    BattlePhase,
    PostBattle,
    EndPhase
} 

public class TurnCombatController : MonoBehaviour
{
    private TurnState _currentState;

    public UnityEvent<TurnState> OnStateChanged = new UnityEvent<TurnState> ();

    public void ChangeState(TurnState newState)
    {
        switch (newState)
        {
            case TurnState.StandbyPhase:
                break;
            case TurnState.MainPhase:
                break;
            case TurnState.PreBattle:
                break;
            case TurnState.BattlePhase:
                break;
            case TurnState.PostBattle:
                break;
            case TurnState.EndPhase:
                break;
        }

        _currentState = newState;
        OnStateChanged.Invoke(_currentState);
    }

}
