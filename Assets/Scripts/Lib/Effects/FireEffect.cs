using Lib.Interfaces;
using UnityEngine;

namespace Lib.Effects
{
    public class FireEffect : ISpellEffect
    {
        public void ApplyEffect(GameObject obj)
        {
            obj.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}