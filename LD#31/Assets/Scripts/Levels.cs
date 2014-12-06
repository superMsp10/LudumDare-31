using UnityEngine;
using System.Collections.Generic;

public class Levels : MonoBehaviour
{
		public GameObject thisCam;
		public List<Entities> theseE;

		// Use this for initialization
		
	
		// Update is called once per frame
		void Update ()
		{
	
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
}
