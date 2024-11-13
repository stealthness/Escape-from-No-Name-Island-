using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace _Scripts.Managers
{
    public class DayNightCycle : MonoBehaviour
    {
        
        public Light2D MoonLight;
        public Light2D SunLight;
        
        [SerializeField] private float MoonLightIntensity = 0.5f;
        [SerializeField] private float SunLightIntensity = 1f;
        
        void Start()
        {
            Debug.Log("DayNightCycle : Game Started");
            
            InvokeRepeating(nameof(ChangePassiveLight), 10, 20);
        }

        public void ChangePassiveLight()
        {
            Debug.Log("ChangePassiveLight");
            if (MoonLight.intensity > SunLight.intensity)
            {
                StartCoroutine(FadeLight(SunLight, 5, SunLightIntensity, false));
                StartCoroutine(FadeLight(MoonLight, 5, MoonLightIntensity, true));
            }
            else
            {
                StartCoroutine(FadeLight(MoonLight, 5, MoonLightIntensity, false));
                StartCoroutine(FadeLight(SunLight, 5, SunLightIntensity, true));
            }
            
            
            // MoonLight.SetActive(!MoonLight.activeSelf);
            // SunLight.SetActive(!SunLight.activeSelf);
        }

        IEnumerator FadeLight(Light2D light, float fadeDuration, float targetIntensity = 1, bool fadeIn = true)
        {
            float elapsedTime = 0;

            while (elapsedTime < fadeDuration)
            {
                if (fadeIn)
                {
                    light.intensity =
                        Mathf.Lerp(targetIntensity, 0, elapsedTime / fadeDuration);
                }
                else
                {
                    light.intensity = targetIntensity - Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
                }
                
                elapsedTime += Time.deltaTime;
            }
            
            
            yield return null;
        }
    }
}