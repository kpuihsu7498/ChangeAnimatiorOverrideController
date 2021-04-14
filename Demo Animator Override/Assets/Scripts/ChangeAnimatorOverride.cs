using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCombat{
    SwordCombat,
    HandCombat
}

[System.Serializable]
public class AnimatorOverride
{
    public string name;
    public AnimatorOverrideController overrideController;
    public TypeCombat typeCombat;
}
public class ChangeAnimatorOverride : MonoBehaviour
{
    public List<AnimatorOverride> animatorOverrides;
    public TypeCombat typeCombatCharacter;

    private void Update()
    {
        ChangeAnimator();
    }

    private void ChangeAnimator()
    {
        foreach(AnimatorOverride animator in animatorOverrides)
        {
            if(animator.typeCombat.Equals(typeCombatCharacter))
            {
                GetComponent<Animator>().runtimeAnimatorController = animator.overrideController as RuntimeAnimatorController;
            }
        }
    }
}
