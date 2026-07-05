using System.Collections;
using UnityEngine;
using Unity.Cinemachine;
using TMPro;
using UnityEngine.SceneManagement;

namespace HarshData
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        //ParticleData
        public ParticleSystem carTurnLeftPS;
        public ParticleSystem carTurnRightPS;
        public ParticleSystem boostPS;
        public ParticleSystem crashEffect;

        //CarSpeedData
        [SerializeField] private float normalSpeed = 50f;
        [SerializeField] private float boostSpeed = 100f;
        [SerializeField] private float boostDuration = 5f;
        public float carSpeedData = 50;
        private Coroutine speedBoostCoroutine;
        private bool isBoostActive;

        //CinemachineData
        public Vector3 normalCameraOffset;
        public Vector3 boostCameraOffset;
        public CinemachineFollow cinemachineCameraOffset;
        private Vector3 targetOffset;
        [SerializeField] private float cameraSmoothSpeed = 5f;

        //CarLightData
        [SerializeField] private CarIndicator[] playerCarIndicator;

        //GameDecision
        public bool isGameEnd;

        //AudioData
        public AudioSource soundEffectsAS;
        public AudioSource backgroundAS;
        public AudioClip[] clips;

        //ScoreData
        [SerializeField] private TMP_Text coinText;
        public int CoinCount { get; private set; }
        [SerializeField] private GameObject menuPanel;


        private void Awake()
        {
            instance = this;
            Application.targetFrameRate = 60;
            QualitySettings.vSyncCount = 0;
            CoinCount = 0;
        }

        private void Start()
        {
            carSpeedData = normalSpeed;
            targetOffset = normalCameraOffset;
            cinemachineCameraOffset.FollowOffset = normalCameraOffset;
            
        }

        private void Update()
        {
            cinemachineCameraOffset.FollowOffset = Vector3.Lerp(
            cinemachineCameraOffset.FollowOffset,
            targetOffset,
            Time.deltaTime * cameraSmoothSpeed);
        }




        public void TriggerTurnParticleSystem(int direction)
        {
            // Play particles
            if (direction > 0)
            {
                carTurnRightPS.Play();
                PlayerCarTurnIndicator(false);
            }
            else if (direction < 0)
            {
                carTurnLeftPS.Play();
                PlayerCarTurnIndicator(true);
            }
          
        }


        public void ActivateSpeedBoost()
        {
            if (isBoostActive)
                return;

            if (speedBoostCoroutine != null)
            {
                StopCoroutine(speedBoostCoroutine);
            }

            speedBoostCoroutine = StartCoroutine(SpeedBoostRoutine());
           
        }

        private IEnumerator SpeedBoostRoutine()
        {
            isBoostActive = true;
            carSpeedData = boostSpeed;
            boostPS.Play();
            TriggerPlayerIndicator();
            SetCinemachineCameraOffset(boostCameraOffset);
            yield return new WaitForSeconds(boostDuration);

            carSpeedData = normalSpeed;

            isBoostActive = false;
            speedBoostCoroutine = null;
            boostPS.Stop();
            StopPlayerIndicator();
            SetCinemachineCameraOffset(normalCameraOffset);
        }

        public float GetCarSpeed()
        {
            return carSpeedData;
        }

        public void SetCinemachineCameraOffset(Vector3 offset)
        {
           targetOffset = offset;
        }

        public void TriggerPlayerIndicator()
        {
            foreach(var obj in playerCarIndicator)
            {
                obj.StartIndicator();
            }
        }

        public void StopPlayerIndicator()
        {
            foreach (var obj in playerCarIndicator)
            {
                obj.StopIndicator();
            }
        }


        public void PlayerCarTurnIndicator(bool isLeft)
        {
            if(isBoostActive == false)
            {
                if (isLeft)
                {
                    playerCarIndicator[1].StopIndicator();
                    playerCarIndicator[0].TriggerIndicatorWithStopDelay();
                }
                else
                {
                    playerCarIndicator[0].StopIndicator();
                    playerCarIndicator[1].TriggerIndicatorWithStopDelay();
                }
            }

        }

        public void SetIsGameEnd(bool isGameEnd)
        {
            this.isGameEnd = isGameEnd;
            boostPS.Stop();
            StopPlayerIndicator();
            SetCinemachineCameraOffset(normalCameraOffset);
            TriggerSoundEffect(clips[0]);
            backgroundAS.Stop();
            Invoke(nameof(TriggerMenuPanel), 1.5f);
        }

        public void TriggerMenuPanel()
        {
            menuPanel.SetActive(true);
        }

        public void TriggerSoundEffect(AudioClip clip)
        {
            soundEffectsAS.PlayOneShot(clip);
        }

        public void AddCoin()
        {
            CoinCount++;
            coinText.text = "COINS- "+ CoinCount.ToString();
        }

        public void ReloadScene()
        {
            Debug.Log("LoadScene");
            SceneManager.LoadScene(0);
        }


    }
}

