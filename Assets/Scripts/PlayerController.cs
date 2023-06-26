using System;
using Lib;
using Lib.Bases;
using Lib.Effects;
using Lib.Interfaces;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum SpellBase
    {
        Projectile,
        Block
    }
    [SerializeField] private SpellBase spellBase;
    
    enum SpellEffect
    {
        Fire,
        Ice,
        Earth
    }
    [SerializeField] private SpellEffect spellEffect;
    
    void OnFire()
    {
        CastSpell();
    }

    void CastSpell()
    {
        ISpellBase @base = spellBase switch
        {
            SpellBase.Projectile => new ProjectileBase(),
            SpellBase.Block => new BlockBase(),
            _ => throw new ArgumentOutOfRangeException()
        };
        
        ISpellEffect effect = spellEffect switch
        {
            SpellEffect.Fire => new FireEffect(),
            SpellEffect.Ice => new IceEffect(),
            SpellEffect.Earth => new EarthEffect(),
            _ => throw new ArgumentOutOfRangeException()
        };

        var spell = new Spell(this.gameObject.transform, @base, effect);
        spell.Cast();
    }
}
