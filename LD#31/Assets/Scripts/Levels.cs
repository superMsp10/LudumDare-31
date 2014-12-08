using UnityEngine;
using System.Collections.Generic;

public class Levels : MonoBehaviour
{
		public GameObject[] Cameras;
		public GameObject thisCam;
		public AudioClip[] clips;
		public AudioSource thisAu;
		public List<Entities> theseE;
		public List<Creator> theseC;
		public List<Collector> theseCol;
		public AudioM thisAuM;
		public GameManeger thisM;

		// Use this for initialization
		
	
		// Update is called once per frame
		
		void Start ()
		{


		}

		void Update ()
		{
				if (!audio.isPlaying && clips.Length >= 1) {
						thisAu.clip = clips [Random.Range (0, clips.Length)];
						thisAu.volume = thisAuM.getBMV ();
						thisAu.Play ();
				}
				if (thisM.inGame) {
						foreach (Entities en in theseE) {
							
								en.UpdateEntity ();
			
								
						}
						foreach (Collector en in theseCol) {
				
								en.UpdateEntity ();
				
				
						}
						foreach (Creator c in theseC) {
								c.UpdateEntity ();


						}
				}
		}

		public void StartLevel ()
		{
				gameObject.SetActive (true);	
			
				
		}
	
		public void endLevel ()
		{
				gameObject.SetActive (false);
		
		}
	
		public void addEntity (Entities en)
		{
				theseE.Add (en);
				en.gameObject.transform.SetParent (transform.FindChild ("Entities"));
		}
	
		public void deleteEntity (Entities en)
		{
				theseE.Remove (en);
		}

		public void addC (Creator en)
		{
				theseC.Add (en);
				en.gameObject.transform.SetParent (transform.FindChild ("Entities"));
		}
	
		public void deleteC (Creator en)
		{
				theseC.Remove (en);
		}

		public void addCol (Collector en)
		{
				theseCol.Add (en);
				en.gameObject.transform.SetParent (transform.FindChild ("Entities"));
		}
	
		public void deleteCol (Collector en)
		{
				theseCol.Remove (en);
		}
		
		public void changeCam (int i)
		{

					
				thisCam.SetActive (false);
				thisCam = Cameras [i];
				thisCam.SetActive (true);

				


		}
	
}
