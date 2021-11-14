using UnityEngine;

public enum ExectutionState
{
    NONE,
    ACTIVE,
    COMPLETED,
    TERMINATED
}

public abstract class State : ScriptableObject
{
    public ExectutionState ExectutionState { get; protected set; }

    public virtual void OnEnable()
    {
        ExectutionState = ExectutionState.NONE;
    }

    public virtual bool EnterState()
    {
        ExectutionState = ExectutionState.ACTIVE;
        return true;
    }

    public abstract void UpdateState();

    public virtual bool ExitState()
    {
        ExectutionState = ExectutionState.COMPLETED;
        return true;
    }
}
