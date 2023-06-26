using Lib;
using Lib.Base;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private string spellName;
    [SerializeField] private SpellBuilder.SpellBases spellBase;
    [SerializeField] private Spell.Elements spellElement;
    [SerializeField] private Spell.Effects spellEffect;
    
    void OnFire()
    {
        CastSpell();
    }

    void CastSpell()
    {
        var spell = new SpellBuilder()
            .AddName(spellName)
            .WithBase(spellBase)
            .AddElement(spellElement)
            .AddEffect(spellEffect)
            .Build();
        
        spell.Cast();
    }
}
