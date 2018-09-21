using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class SongScript {
    private enum SpawnEvent { SPAWN_ENEMY, SPAWN_TRAIL }
    private List<SongData> steps;

    public SongScript()
    {
        steps = new List<SongData>();        
    }

    public void AddStep(float lowerBound, float upperBound, int amountOfSpawns)
    {
        steps.Add(new SongData(lowerBound, upperBound, amountOfSpawns));
    }

    public int getSpawns(float songTimeLineInSeconds)
    {
       SongData stepData = steps
            .Where(step => songTimeLineInSeconds >= step.getLowerBound() & songTimeLineInSeconds <= step.getUpperBound())
            .FirstOrDefault();

        return (stepData == null) ? -1 : stepData.getAmountOfEvents();
    }

    private class SongData
    {
        private float lowerBound;
        private float upperBound;
        private int amountOfEvents;
        private SpawnEvent type;

        public SongData(float lowerBound, float upperBound, int amountOfEvents) : this(lowerBound, upperBound, amountOfEvents, SpawnEvent.SPAWN_ENEMY) { }

        public SongData(float lowerBound, float upperBound, int amountOfEvents, SpawnEvent type)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.amountOfEvents = amountOfEvents;
            this.type = type;
        }

        public float getLowerBound()
        {
            return this.lowerBound;
        }

        public float getUpperBound()
        {
            return this.upperBound;
        }

        public int getAmountOfEvents()
        {
            return this.amountOfEvents;
        }
    }


}


