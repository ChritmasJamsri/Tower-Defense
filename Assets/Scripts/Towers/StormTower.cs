using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormTower : Tower
{
    private void Start()
    {
        //Sets the element type
        ElementType = Element.STORM;
    }

    /// <summary>
    /// Gets a debuff
    /// </summary>
    /// <returns>A storm debuff</returns>
    public override Debuff GetDebuff()
    {
        return new StormDebuff(Target, DebuffDuration);
    }
}
