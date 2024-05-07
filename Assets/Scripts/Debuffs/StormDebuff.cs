using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sub class for the storm debuff
/// </summary>
public class StormDebuff : Debuff
{
    /// <summary>
    /// The storm debuff's constructor
    /// </summary>
    /// <param name="target">The target to apply the debuff to</param>
    /// <param name="duration">The debuff's duration</param>
    public StormDebuff(Monster target, float duration) : base(target,duration)
    {
        if (target != null)
        {
            target.Speed = 0;
        }
    }

    /// <summary>
    /// Removes the debuff from the target
    /// </summary>
    public override void Remove()
    {
        if (target != null)
        {
            //resets the speed
            target.Speed = target.MaxSpeed;
            base.Remove();
        }

    
    }

}
