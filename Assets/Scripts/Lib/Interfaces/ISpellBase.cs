using UnityEngine;

namespace Lib.Interfaces
{
    public interface ISpellBase
    {
        GameObject Create(Transform playerTransform);
    }
}