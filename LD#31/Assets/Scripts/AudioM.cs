using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioM : MonoBehaviour
{
		private float BackgroundM;
		public GameManeger thisM;
		public float defaultVolume = 1;
		public Slider[] sliderUI;
		


		// Use this for initialization
		void Start ()
		{
				BackgroundM = PlayerPrefs.GetFloat ("BackM", defaultVolume);
				changeBMV (BackgroundM);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		public void playSound (Vector3 pos, string category, AudioClip clip)
		{
				float v = 0;
				if (category == "b")
						v = BackgroundM;
				else
						Debug.LogError ("No audio");
				//else if (category == "s")
				//v = EnemyS;
				AudioSource.PlayClipAtPoint (clip, pos, v);
		
		}

		public void changeBMV (float volume)
		{
				
				BackgroundM = volume;
				foreach (Levels l in thisM.lev) {
						
						l.thisAu.volume = volume;
				}
				foreach (Slider s in sliderUI) {
			
						s.value = volume;
				}
			



		}

		public float getBMV ()
		{

				return BackgroundM;
		}
			
		void OnDestroy ()
		{
				PlayerPrefs.SetFloat ("BackM", BackgroundM);

		}
}
