# Screeps2021
New Refactored Screeps (2020+)

# Notes
- When near death, make screep 'elder', wrap up tasks and return to spawn for recycling energy
- Mining Spot Roster and Map in memory of Spawn (screeps access)
- screep decides what to do, not the spawn, but the spawn owns all screeps in room
- when screep changes room, new (our)spawn owns or no spawn owns them, screep decides where to go and what to do
- Spawn can broadcast requests, screeps can respond, or not respond
- map room into spawn memory, try to autobuild when possible
- monitor cpu / bucket / ticks, add stats etc
- harvesting stats
- screep stats
- Minerals
- Factories
- Links
- PowerScreeps
- Labs

# Spawning
- body part decider ( spawn )
- screep initial type/role
- spawn timing
- spawn energy demands
- spawn strategy
- Emergency Mode
- spawn stats
- Rush Controller mode

# Harvesting

# Building

# Exploring

# Combat

# Recycling

# Death

# Memory

# my misc notes
- all sorts of crap below

# move costs
- Road - 1
- Land - 2
- Swamp - 10

# Energy Max Storage
- Spawn 300
- Extension adds 50
- exact location of extensions within a room does not matter
- one extension can be used by several spawns

# Body Parts
- WORK, MOVE,CARRY,ATTACK,RANGED_ATTACK,HEAL,CLAIM,TOUGH
- https://docs.screeps.com/creeps.html

# Fatigue Points
- 1 point per body part on roads, 2 on plain land, 10 on swamp
- Each MOVE body part decreases fatigue points by 2 per tick
- cannot move when fatigue is more than zero

# Basic Worker
- [CARRY, WORK, MOVE]

# old deprecated calls
- Method `Game.map.getTerrainAt` is deprecated and will be removed
