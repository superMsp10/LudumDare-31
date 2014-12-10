using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
		public GameManeger thisM;
		public int cash = 200;
		public Text cashUI;
		public HoldAble holding1;
		public GameObject defaultO;
		public Image changeSprite;
		private GameObject use;
		public Levels won;

		void Start ()
		{
				
				
		}
	
		void Update ()
		{
			
				if (cash > 2000) {
						thisM.changeLev (won);
						cash = 0;
						thisM.inGame = false;
				}
				cashUI.text = "Money : $" + cash.ToString ();
				if (Input.GetMouseButton (1)) {
						if (holding1 != null && holding1.isUsable) {
								
								Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
								RaycastHit hit;
								if (Physics.Raycast (ray, out hit, 1000)) {
				
										GameObject gam = (GameObject)Instantiate (use, hit.point, Quaternion.identity);
										Entities e = gam.GetComponent<Entities> ();
										e.thisL = thisM.currentLev;
										e.thisM = thisM;
								}
								changeItem (defaultO);
						}
				}
		}

		public void changeItem (GameObject h)
		{
				holding1 = h.GetComponent<HoldAble> ();
				changeSprite.sprite = holding1.onbject;
				use = h;
				if (h.name == "Creator 1") {
						Creator c = h.GetComponent<Creator> ();
						c.target = thisM.currentLev.theseCol [0].gameObject;
				}


		}

		public void buy (GameObject h)
		{
				HoldAble hol = h.GetComponent<HoldAble> ();
				if (hol.price < cash) {
						cash -= hol.price;
						changeItem (h);
				}

		}

		

}
