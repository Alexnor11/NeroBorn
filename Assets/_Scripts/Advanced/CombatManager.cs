using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatManager : BaseManager
{       
    public override string state
    {
        get { return _state; }
        set { _state = value; }
    }

    public override void Initialize()
    {
        _state = "BaseManager initialized..";
        Debug.Log(_state);
    }
}
