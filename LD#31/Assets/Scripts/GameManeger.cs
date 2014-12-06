using UnityEngine;
using System.Collections;

public class GameManeger : MonoBehaviour
{
		public Levels[] lev;
		public Levels startLevel;
		public Levels currentLev;

		// Use this for initialization
		void Start ()
		{
				lev = FindObjectsOfType<Levels> ();
				foreach (Levels l in lev) {
						l.gameObject.SetActive (false);

				}
				if (startLevel != null) {
						changeLev (startLevel);
				} else {
						changeLev (getLevels ("Level1"));
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
		
		public Levels getLevels (int i)
		{
				return lev [i];
		}

		public Levels getLevels (string s)
		{
				Levels thisLevel = currentLev;
				foreach (Levels l in lev) {
						if (l.name == s) {
								thisLevel = l;
						}
				}
				return thisLevel;
		}
		
		public void changeLev (Levels l)
		{
				if (currentLev != null) {
						currentLev.endLevel ();
				}
	
				currentLev = l;
				currentLev.StartLevel ();

		}
	
	
}
