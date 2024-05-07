using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostTower : Tower
{
    /// <summary>
    /// The towers slowing factor stat
    /// </summary>
    [SerializeField]
    private float slowingFactor;

    private void Start()
    {
        //Sets the tower elements
        ElementType = Element.FROST;
    }

    /// <summary>
    /// Gets the tower's debuff
    /// </summary>
    /// <returns>A frost debuff</returns>
    public override Debuff GetDebuff()
    {
        return new FrostDebuff(slowingFactor, DebuffDuration, Target);
    }
}
