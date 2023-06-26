using Lib.Interfaces;
using UnityEngine;

namespace Lib
{
    public class Spell
    {
        private Transform _playerTransform;
        
        private ISpellBase _spellBase;
        private ISpellEffect _spellEffect;
        
        public Spell(Transform playerTransform, ISpellBase spellBase, ISpellEffect spellEffect)
        {
            _playerTransform = playerTransform;
            _spellBase = spellBase;
            _spellEffect = spellEffect;
        }

        public void Cast()
        {
            var obj = _spellBase.Create(_playerTransform);
            _spellEffect.ApplyEffect(obj);
        }
    }
}