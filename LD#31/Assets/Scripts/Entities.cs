using UnityEngine;
using System.Collections;

public class Entities : MonoBehaviour
{
		public Levels thisL;
		public GameManeger thisM;

		// Use this for initialization
		void Start ()
		{
				thisL.addEntity (this);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
		
		void OnDestroy ()
		{
				thisL.deleteEntity (this);
		}
}

