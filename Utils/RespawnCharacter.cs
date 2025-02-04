﻿using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace RPGMods.Utils
{
    public class RespawnCharacter
    {
        private static EntityManager entityManager = Plugin.Server.EntityManager;
        public static void Respawn(Entity VictimEntity, PlayerCharacter player, Entity userEntity) {
            if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": attempting auto respawn");
            var bufferSystem = Plugin.Server.GetOrCreateSystem<EntityCommandBufferSystem>();

            if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": buffer system obtained");
            unsafe
            {
                var playerLocation = player.LastValidPosition;
                if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": got last valid position");
                var location = Plugin.Server.EntityManager.GetComponentData<LocalToWorld>(userEntity).Position;
                if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": got current positon");
                float3 spawnAt;
                if(math.abs(location.x - playerLocation.x) < 0.1 && math.abs(location.y - playerLocation.y) < 0.1) {
                    if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": current xy and last valid are less than 0.1 diff using last valid");
                    spawnAt = new float3(playerLocation.x, playerLocation.y, location.z);
                } else {
                    if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": current and last valid very different, using last valid at height 6");
                    spawnAt = new float3(playerLocation.x, playerLocation.y, 6);
                }

                if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": setting spawn loaction as nullable unboxed");
                var spawnLocation = new Il2CppSystem.Nullable_Unboxed<float3>(spawnAt);
                if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": getting server bootstrap");
                var server = Plugin.Server.GetOrCreateSystem<ServerBootstrapSystem>();


                if (Helper.deathLogging) Plugin.Logger.LogInfo(DateTime.Now + ": respawning character");

                server.RespawnCharacter(bufferSystem.CreateCommandBuffer(), userEntity, customSpawnLocation: spawnLocation, previousCharacter: VictimEntity, fadeOutEntity: userEntity);
            }
        }
    }
}
