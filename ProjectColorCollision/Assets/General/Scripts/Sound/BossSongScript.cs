using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSongScript : SongScript {

	public BossSongScript()
    {
        loadSnareDrumSteps();
        

    }

    private void loadSnareDrumSteps()
    {
        AddStep(2f, 2.1f, 2);
        AddStep(3.6f, 3.7f, 2);
        AddStep(4.5f, 4.6f, 2);
        AddStep(5.8f, 5.9f, 2);
        AddStep(6.8f, 6.9f, 2);
        AddStep(8.4f, 8.5f, 2);
        AddStep(9.2f, 9.3f, 2);
        AddStep(10.9f, 11f, 2);
        AddStep(11.7f, 11.8f, 1);
        AddStep(11.8f, 11.9f, 1);
        AddStep(11.9f, 12f, 1);
        AddStep(12f, 12.1f, 1);
        AddStep(14f, 14.1f, 2);
        AddStep(15.5f, 15.6f, 2);
        AddStep(16.4f, 16.5f, 1);
        AddStep(16.5f, 16.6f, 1);
        AddStep(16.6f, 16.7f, 1);
        AddStep(16.7f, 16.8f, 1);

        AddStep(18.7f, 18.8f, 1);
        //AddStep(19.3f, 19.4f, 1);
        //AddStep(19.9f, 20f, 1);
        AddStep(19.6f, 19.7f, 1);
        AddStep(20.3f, 20.4f, 1);
    }
}
