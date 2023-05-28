using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeSystem : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Image _PanelImage;
    [SerializeField] private float _speed;
    [SerializeField, Header("ŽŸ‚ÌƒV[ƒ“‚Ì–¼‘O‚ð‚±‚±‚É")] private string nextSceneName;
    private bool isSceneChange;
    private Color PanelColor;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(canvas);
        isSceneChange = false;
        PanelColor = _PanelImage.color;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            blackout();
        }
    }
    private void blackout()
    {
        StartCoroutine(Sceneblackout());
    }

    private IEnumerator Sceneblackout()
    {
        while (!isSceneChange)
        {
            PanelColor.a += 0.1f;
            _PanelImage.color = PanelColor;

            if (PanelColor.a >= 1)
                isSceneChange = true;

            yield return new WaitForSeconds(0.05f);
        }
        SceneManager.LoadScene(nextSceneName);
        yield return new WaitForSeconds(1f);
        while(isSceneChange)
        {
            PanelColor.a -= 0.1f;
            _PanelImage.color = PanelColor;

            if (PanelColor.a < 0)
                isSceneChange = false;
            yield return new WaitForSeconds(0.05f);
        }
    }
}