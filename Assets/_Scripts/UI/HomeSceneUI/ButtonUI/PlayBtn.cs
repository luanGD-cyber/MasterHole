using _Scripts.Sound;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

namespace _Scripts.UI.HomeSceneUI.ButtonUI
{
    public class PlayBtn : ChangeSceneBtn
    {
        public UnityEvent OnClick;
        
        public override void ChangeScene()
        {
            ManagerSound.Instance.PlayEffectSound(EnumEffectSound.ButtonClick);
            
            OnClick?.Invoke();
            int currentEnergy = PlayerPrefs.GetInt(StringPlayerPrefs.CURRENT_ENERGY, 0);
          
            if (currentEnergy == 0) return;
            base.ChangeScene();
          
        }
    }
}