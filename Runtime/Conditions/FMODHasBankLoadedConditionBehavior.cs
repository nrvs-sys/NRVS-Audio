using UnityEngine;

namespace NRVS.Audio
{
    [CreateAssetMenu(fileName = "Condition_ FMOD Has Bank Loaded_ New", menuName = "Behaviors/Conditions/Audio/FMOD Has Bank Loaded")]
    public class FMODHasBankLoadedConditionBehavior : ConditionBehavior
    {
        [SerializeField]
        string bankName = "Master";

        protected override bool Evaluate()
        {
            return FMODUnity.RuntimeManager.HasBankLoaded(bankName);
        }
    }
}
