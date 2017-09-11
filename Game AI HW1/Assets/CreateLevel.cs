using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

//-1.68 to 1.68 for x
//-1.92 to 1.92 for y

public class CreateLevel : MonoBehaviour {

    string path = "Assets/level.txt";
    public Transform player;
    public Transform wall;
    public Transform pellet;
    public Transform floor;
    public Transform globals;
    public Transform red_ghost;
    public Transform yellow_ghost;
    public Transform blue_ghost;
    public Transform purple_ghost;

	// Use this for initialization
	void Start () {

        //Instantiate globals at runtime.
        Instantiate(globals);
        globals.GetComponent<Globals>().resetScore();

        //Set screen resolution.
        Screen.SetResolution(1920,1080, false);

        //Verify the path is valid.
        if (!(File.Exists(path)))
        {
            Debug.LogError("Invalid Path");
        }

        //Read in the file and create a 2d array of data.
		StreamReader reader = new StreamReader(path);
        Int32[][] jagged = new Int32[28][];
        for (int k=0; k<28; k++)
        {
            jagged[k] = new Int32[31];
        }
        Int32 ch;
        int i = 0;
        int j = 0;
        while ((ch = reader.Read()) >= 0)
        {
            //Debug.Log(x);
            if (ch != 13 && ch != 10)
            {
                //Debug.Log(x);
                jagged[i][j] = ch;
                i++;
            }
            else
            {
                j++;
                i = 0;
                reader.Read();
            }
        }
        
        //Create the level using the data array.
        for (int x=-14; x<14; x++)
        {
            for (int y=-16; y<15; y++)
            {
                //Debug.Log(jagged[x+14][y+16]);
                if (jagged[x+14][y+16] == 88)
                {
                    Instantiate(wall, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x+14][y+16] == 79)
                {
                    Instantiate(pellet, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                    Instantiate(floor, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x+14][y+16] == 32)
                {
                    Instantiate(floor, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x+14][y+16] == 80)
                {
                    Instantiate(floor, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                    Instantiate(player, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x + 14][y + 16] == 82)
                {
                    Instantiate(red_ghost, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x + 14][y + 16] == 77)
                {
                    Instantiate(purple_ghost, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x + 14][y + 16] == 89)
                {
                    Instantiate(yellow_ghost, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else if (jagged[x + 14][y + 16] == 66)
                {
                    Instantiate(blue_ghost, new Vector3((x * 0.3f), (y * -0.3f), 0), Quaternion.identity);
                }
                else
                {
                    Debug.LogWarning("Invalid character in level file.");
                }
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
